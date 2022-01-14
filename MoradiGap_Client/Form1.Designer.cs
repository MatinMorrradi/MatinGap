
namespace MoradiGap_Client
{
    partial class ClientForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Send_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Message_txt = new System.Windows.Forms.TextBox();
            this.Contact_Txt = new System.Windows.Forms.TextBox();
            this.Gap_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Connect_btn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Connect_Txt = new System.Windows.Forms.TextBox();
            this.UserName_Txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.UserName_Txt);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.Connect_Txt);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.Connect_btn);
            this.panel1.Location = new System.Drawing.Point(22, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(589, 97);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.OldLace;
            this.panel2.Controls.Add(this.Send_btn);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.Message_txt);
            this.panel2.Controls.Add(this.Contact_Txt);
            this.panel2.Location = new System.Drawing.Point(22, 329);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(573, 62);
            this.panel2.TabIndex = 1;
            // 
            // Send_btn
            // 
            this.Send_btn.Enabled = false;
            this.Send_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Send_btn.Location = new System.Drawing.Point(3, 30);
            this.Send_btn.Name = "Send_btn";
            this.Send_btn.Size = new System.Drawing.Size(53, 29);
            this.Send_btn.TabIndex = 5;
            this.Send_btn.Text = "ارسال";
            this.Send_btn.UseVisualStyleBackColor = true;
            this.Send_btn.Click += new System.EventHandler(this.Send_btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(509, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "پیام :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(509, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "مخاطب :";
            // 
            // Message_txt
            // 
            this.Message_txt.Enabled = false;
            this.Message_txt.Location = new System.Drawing.Point(63, 32);
            this.Message_txt.Name = "Message_txt";
            this.Message_txt.Size = new System.Drawing.Size(440, 23);
            this.Message_txt.TabIndex = 1;
            // 
            // Contact_Txt
            // 
            this.Contact_Txt.Location = new System.Drawing.Point(3, 3);
            this.Contact_Txt.Name = "Contact_Txt";
            this.Contact_Txt.Size = new System.Drawing.Size(500, 23);
            this.Contact_Txt.TabIndex = 0;
            // 
            // Gap_txt
            // 
            this.Gap_txt.BackColor = System.Drawing.SystemColors.Info;
            this.Gap_txt.Location = new System.Drawing.Point(89, 115);
            this.Gap_txt.Multiline = true;
            this.Gap_txt.Name = "Gap_txt";
            this.Gap_txt.Size = new System.Drawing.Size(522, 208);
            this.Gap_txt.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(19, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "گفتگو ها :";
            // 
            // Connect_btn
            // 
            this.Connect_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Connect_btn.Image = global::MoradiGap_Client.Properties.Resources.con1;
            this.Connect_btn.Location = new System.Drawing.Point(0, 0);
            this.Connect_btn.Name = "Connect_btn";
            this.Connect_btn.Size = new System.Drawing.Size(112, 97);
            this.Connect_btn.TabIndex = 0;
            this.Connect_btn.Text = "اتصال به سرور";
            this.Connect_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Connect_btn.UseVisualStyleBackColor = true;
            this.Connect_btn.Click += new System.EventHandler(this.Connect_btn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(470, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "آی پی سرور : ";
            // 
            // Connect_Txt
            // 
            this.Connect_Txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Connect_Txt.Location = new System.Drawing.Point(364, 11);
            this.Connect_Txt.Name = "Connect_Txt";
            this.Connect_Txt.Size = new System.Drawing.Size(100, 16);
            this.Connect_Txt.TabIndex = 2;
            this.Connect_Txt.Text = "127.0.0.1:9000";
            // 
            // UserName_Txt
            // 
            this.UserName_Txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserName_Txt.Location = new System.Drawing.Point(254, 45);
            this.UserName_Txt.Multiline = true;
            this.UserName_Txt.Name = "UserName_Txt";
            this.UserName_Txt.Size = new System.Drawing.Size(220, 25);
            this.UserName_Txt.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(480, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "نام کاربری :  ";
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(632, 403);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Gap_txt);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ClientForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "گپ";
            this.Load += new System.EventHandler(this.ClientForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox Gap_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Send_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Message_txt;
        private System.Windows.Forms.TextBox Contact_Txt;
        private System.Windows.Forms.TextBox UserName_Txt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Connect_Txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Connect_btn;
    }
}

