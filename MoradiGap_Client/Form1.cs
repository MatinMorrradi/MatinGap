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

namespace MoradiGap_Client
{
    public partial class ClientForm : Form
    {
        public ClientForm()
        {
            InitializeComponent();
        }
        SimpleTcpClient client;
        private void ClientForm_Load(object sender, EventArgs e)
        {
            string ip = Connect_Txt.Text;
            client = new SimpleTcpClient(ip);

            client.Events.Connected += Events_Connected;
            client.Events.Disconnected += Events_Disconnected;
            client.Events.DataReceived += Events_DataReceived;
            Send_btn.Enabled = true;
            Message_txt.Enabled = true;

        }

        private void Events_DataReceived(object sender, DataReceivedEventArgs e)
        {
            Gap_txt.Text += Encoding.UTF8.GetString(e.Data) + Environment.NewLine;
        }

        private void Events_Disconnected(object sender, ClientDisconnectedEventArgs e)
        {
            Gap_txt.Text += "آفلاین شدید . " + Environment.NewLine;
        }

        private void Events_Connected(object sender, ClientConnectedEventArgs e)
        {
            Gap_txt.Text += "آنلاین شدید  . " + Environment.NewLine;

        }

        private void Send_btn_Click(object sender, EventArgs e)
        {
            if (client.IsConnected)
            {
                if (!string.IsNullOrEmpty(Message_txt.Text) && !string.IsNullOrEmpty(Contact_Txt.Text))
                {
                    client.Send("++" + Contact_Txt.Text + "#" + Message_txt.Text);
                    Gap_txt.Text += UserName_Txt.Text + " : " + Message_txt.Text + Environment.NewLine;
                    Message_txt.Text = string.Empty;
                }
                else if (!string.IsNullOrEmpty(Message_txt.Text) && string.IsNullOrEmpty(Contact_Txt.Text))
                {
                    client.Send(Message_txt.Text);
                    Gap_txt.Text += UserName_Txt.Text + " : " + Message_txt.Text + Environment.NewLine;
                    Message_txt.Text = string.Empty;
                }

            }
        }

        private void Connect_btn_Click(object sender, EventArgs e)
        {
            
            if (!string.IsNullOrEmpty(UserName_Txt.Text) && !string.IsNullOrEmpty(Connect_Txt.Text))
            {
                try
                {
                    client.Connect();
                    client.Send("##" + UserName_Txt.Text);
                    Gap_txt.Text += "به سرور متصل شدید" + Environment.NewLine;
                    Connect_btn.Enabled = false;
                    UserName_Txt.Enabled = false;
                    Connect_Txt.Enabled = false;

                }
                catch (Exception)
                {

                    Gap_txt.Text += "سرور پیدا نشد" + Environment.NewLine;
                }

            }
        }
    }
}
