
namespace MoradiGap_Server
{
    partial class ServerForm
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
            this.IpPort_txt = new System.Windows.Forms.TextBox();
            this.Status_txt = new System.Windows.Forms.TextBox();
            this.Data_txt = new System.Windows.Forms.TextBox();
            this.Users_List = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.StartServer_btn = new System.Windows.Forms.Button();
            this.Send_btn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // IpPort_txt
            // 
            this.IpPort_txt.Location = new System.Drawing.Point(127, 12);
            this.IpPort_txt.Name = "IpPort_txt";
            this.IpPort_txt.Size = new System.Drawing.Size(110, 23);
            this.IpPort_txt.TabIndex = 0;
            // 
            // Status_txt
            // 
            this.Status_txt.Enabled = false;
            this.Status_txt.Location = new System.Drawing.Point(60, 50);
            this.Status_txt.Multiline = true;
            this.Status_txt.Name = "Status_txt";
            this.Status_txt.Size = new System.Drawing.Size(410, 268);
            this.Status_txt.TabIndex = 1;
            // 
            // Data_txt
            // 
            this.Data_txt.Enabled = false;
            this.Data_txt.Location = new System.Drawing.Point(60, 335);
            this.Data_txt.Name = "Data_txt";
            this.Data_txt.Size = new System.Drawing.Size(410, 23);
            this.Data_txt.TabIndex = 2;
            // 
            // Users_List
            // 
            this.Users_List.Enabled = false;
            this.Users_List.FormattingEnabled = true;
            this.Users_List.ItemHeight = 16;
            this.Users_List.Location = new System.Drawing.Point(4, 33);
            this.Users_List.Name = "Users_List";
            this.Users_List.Size = new System.Drawing.Size(141, 292);
            this.Users_List.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "آی پی سرور:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 338);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "پیام:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "پیام ها:";
            // 
            // StartServer_btn
            // 
            this.StartServer_btn.Enabled = false;
            this.StartServer_btn.Location = new System.Drawing.Point(243, 12);
            this.StartServer_btn.Name = "StartServer_btn";
            this.StartServer_btn.Size = new System.Drawing.Size(227, 23);
            this.StartServer_btn.TabIndex = 7;
            this.StartServer_btn.Text = "فعال شدن ";
            this.StartServer_btn.UseVisualStyleBackColor = true;
            this.StartServer_btn.Click += new System.EventHandler(this.StartServer_btn_Click);
            // 
            // Send_btn
            // 
            this.Send_btn.Enabled = false;
            this.Send_btn.Location = new System.Drawing.Point(60, 364);
            this.Send_btn.Name = "Send_btn";
            this.Send_btn.Size = new System.Drawing.Size(410, 27);
            this.Send_btn.TabIndex = 8;
            this.Send_btn.Text = "ارسال";
            this.Send_btn.UseVisualStyleBackColor = true;
            this.Send_btn.Click += new System.EventHandler(this.Send_btn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "کاربران";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.Users_List);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(476, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(148, 341);
            this.panel1.TabIndex = 10;
            // 
            // ServerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(632, 403);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Send_btn);
            this.Controls.Add(this.StartServer_btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Data_txt);
            this.Controls.Add(this.Status_txt);
            this.Controls.Add(this.IpPort_txt);
            this.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ServerForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "سرور";
            this.Load += new System.EventHandler(this.ServerForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox IpPort_txt;
        private System.Windows.Forms.TextBox Status_txt;
        private System.Windows.Forms.TextBox Data_txt;
        private System.Windows.Forms.ListBox Users_List;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button StartServer_btn;
        private System.Windows.Forms.Button Send_btn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
    }
}

