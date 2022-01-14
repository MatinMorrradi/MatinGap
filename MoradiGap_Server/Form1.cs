using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimpleTcp;

namespace MoradiGap_Server
{
    public partial class ServerForm : Form
    {
        public ServerForm()
        {
            InitializeComponent();
        }
        SimpleTcpServer server;
        Chat_RoomEntities db = new Chat_RoomEntities();
        private void ServerForm_Load(object sender, EventArgs e)
        {
            db = new Chat_RoomEntities();
            //ip like 127.0.0.1 and port like 9000
            IpPort_txt.Text = "127.0.0.1:9000";

            server = new SimpleTcpServer(IpPort_txt.Text);
            StartServer_btn.Enabled = true;
            
            //Events 
            server.Events.ClientConnected += Events_ClientConnected;
            server.Events.ClientDisconnected += Events_ClientDisconnected;
            server.Events.DataReceived += Events_DataReceived;

        }
        List<Tbl_User> userlist = new List<Tbl_User>();
        
        //when data received from one client
        private void Events_DataReceived(object sender, DataReceivedEventArgs e)
        {
            string D = Encoding.UTF8.GetString(e.Data);
            if (D.Substring(0, 2) == "##")
            {
                Tbl_User newuser = new Tbl_User();
                newuser.User_IpPort = e.IpPort;
                newuser.User_UserName = D.Substring(2);
                userlist.Add(newuser);
                Status_txt.Text += newuser.User_IpPort + " : " + newuser.User_UserName + " وارد شد" + Environment.NewLine;
                Users_List.Items.Add(newuser.User_UserName);
            }
            else if (D.Substring(0, 2) == "++")
            {
                int count = 1;
                foreach (var item in D.Substring(2))
                {
                    if (item == '#')
                    {
                        break;
                    }
                    count++;
                }
                string qUser_Sender = D.Substring(2, count - 1);
                //find ip      
                var qUser = userlist.Where(p => p.User_UserName == qUser_Sender).FirstOrDefault();
                string qUser_Rec = userlist.Where(p => p.User_IpPort == e.IpPort).FirstOrDefault().User_UserName;
                Status_txt.Text +=qUser_Rec + " " + " پیامی را برای"+qUser_Sender+ "ارسال کرد"+Environment.NewLine;
                if (qUser != null)
                {
                    server.Send(qUser.User_IpPort,qUser_Rec + " : "+ D.Substring(count + 2));
                }

            }
            else
            {
                string qUser_Rec = userlist.Where(p => p.User_IpPort == e.IpPort).FirstOrDefault().User_UserName;
                foreach(var i in userlist)
                {
                    server.Send(i.User_IpPort, qUser_Rec + " : " + D);
                }
            }

        }

        //when client Dis connected
        private void Events_ClientDisconnected(object sender, ClientDisconnectedEventArgs e)
        {
            Status_txt.Text += e.IpPort + "کاربر دیس کانکت شد : " + Environment.NewLine;
            //Remove User from list 
            string userName = userlist.Where(p => p.User_IpPort == e.IpPort).FirstOrDefault().User_UserName;
            Users_List.Items.Remove(userName);
        }

        //when client be Online
        private void Events_ClientConnected(object sender, ClientConnectedEventArgs e)
        {
            Status_txt.Text += e.IpPort + "کاربر کانکت شد " + Environment.NewLine;
            Users_List.Items.Add(e.IpPort);
        }

        //when we run server 
        private void StartServer_btn_Click(object sender, EventArgs e)
        {
            server.Start();
            Status_txt.Text += "سرور فعال است" + Environment.NewLine;
            StartServer_btn.Enabled = false;
            Status_txt.Enabled = true;
            Data_txt.Enabled = true;
            Send_btn.Enabled = true;
            Users_List.Enabled = true;
        }

        //when we send sth from server to sb like one client
        private void Send_btn_Click(object sender, EventArgs e)
        {
            if (server.IsListening)
            {
                if (!string.IsNullOrEmpty(Data_txt.Text))
                {
                    try
                    {
                        string ipPort = userlist.Where(p => p.User_UserName == Users_List.SelectedItem.ToString()).FirstOrDefault().User_IpPort;
                        server.Send(ipPort, "سرور : " + Data_txt.Text);
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("کاربر انتخاب نشده است");
                    }

                    Status_txt.Text += "سرور : " + Data_txt.Text + Environment.NewLine;
                    Data_txt.Text = string.Empty;
                }

            }
        }
    }
}
