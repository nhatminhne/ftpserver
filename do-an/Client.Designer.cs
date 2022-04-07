namespace do_an
{
    partial class Client
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Client));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.ip_server = new System.Windows.Forms.TextBox();
            this.user = new System.Windows.Forms.TextBox();
            this.pass = new System.Windows.Forms.TextBox();
            this.encode = new System.Windows.Forms.Label();
            this.decode = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.send = new System.Windows.Forms.Label();
            this.connect = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sign_up = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.quit = new System.Windows.Forms.Label();
            this.prev = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.download = new System.Windows.Forms.Label();
            this.delete = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Quicksand", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(6, 121);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(399, 172);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // ip_server
            // 
            this.ip_server.Font = new System.Drawing.Font("Quicksand", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ip_server.ForeColor = System.Drawing.Color.DarkSalmon;
            this.ip_server.Location = new System.Drawing.Point(140, 45);
            this.ip_server.Name = "ip_server";
            this.ip_server.Size = new System.Drawing.Size(198, 29);
            this.ip_server.TabIndex = 2;
            this.ip_server.Text = "192.168.1.5";
            // 
            // user
            // 
            this.user.Font = new System.Drawing.Font("Quicksand", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user.ForeColor = System.Drawing.Color.DarkSalmon;
            this.user.Location = new System.Drawing.Point(140, 89);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(198, 29);
            this.user.TabIndex = 2;
            this.user.Text = "nhom_4";
            // 
            // pass
            // 
            this.pass.Font = new System.Drawing.Font("Quicksand", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass.ForeColor = System.Drawing.Color.DarkSalmon;
            this.pass.Location = new System.Drawing.Point(140, 124);
            this.pass.Name = "pass";
            this.pass.PasswordChar = '*';
            this.pass.Size = new System.Drawing.Size(198, 29);
            this.pass.TabIndex = 2;
            this.pass.Text = "123";
            // 
            // encode
            // 
            this.encode.AutoSize = true;
            this.encode.BackColor = System.Drawing.Color.LightSalmon;
            this.encode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.encode.Font = new System.Drawing.Font("Quicksand", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.encode.ForeColor = System.Drawing.Color.Transparent;
            this.encode.Location = new System.Drawing.Point(27, 48);
            this.encode.Name = "encode";
            this.encode.Size = new System.Drawing.Size(72, 25);
            this.encode.TabIndex = 3;
            this.encode.Text = "Encode";
            this.encode.Click += new System.EventHandler(this.encode_Click);
            // 
            // decode
            // 
            this.decode.AutoSize = true;
            this.decode.BackColor = System.Drawing.Color.LightSalmon;
            this.decode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.decode.Font = new System.Drawing.Font("Quicksand", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decode.ForeColor = System.Drawing.Color.Transparent;
            this.decode.Location = new System.Drawing.Point(27, 103);
            this.decode.Name = "decode";
            this.decode.Size = new System.Drawing.Size(74, 25);
            this.decode.TabIndex = 4;
            this.decode.Text = "Decode";
            this.decode.Click += new System.EventHandler(this.decode_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Quicksand", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Salmon;
            this.label1.Location = new System.Drawing.Point(23, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "IP Server:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Quicksand", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Salmon;
            this.label2.Location = new System.Drawing.Point(23, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "User:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Quicksand", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Salmon;
            this.label3.Location = new System.Drawing.Point(23, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Chocolate;
            this.label4.Location = new System.Drawing.Point(6, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(201, 30);
            this.label4.TabIndex = 5;
            this.label4.Text = "Reply From Server:";
            // 
            // send
            // 
            this.send.AutoSize = true;
            this.send.BackColor = System.Drawing.Color.LightSalmon;
            this.send.Cursor = System.Windows.Forms.Cursors.Hand;
            this.send.Font = new System.Drawing.Font("Quicksand", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.send.ForeColor = System.Drawing.Color.Transparent;
            this.send.Location = new System.Drawing.Point(15, 39);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(53, 25);
            this.send.TabIndex = 6;
            this.send.Text = "Send";
            this.send.Click += new System.EventHandler(this.send_Click_1);
            // 
            // connect
            // 
            this.connect.AutoSize = true;
            this.connect.BackColor = System.Drawing.Color.LightSalmon;
            this.connect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.connect.Font = new System.Drawing.Font("Quicksand", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connect.ForeColor = System.Drawing.Color.Transparent;
            this.connect.Location = new System.Drawing.Point(383, 127);
            this.connect.Name = "connect";
            this.connect.Size = new System.Drawing.Size(79, 25);
            this.connect.TabIndex = 6;
            this.connect.Text = "Connect";
            this.connect.Click += new System.EventHandler(this.connect_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.PeachPuff;
            this.groupBox1.Controls.Add(this.sign_up);
            this.groupBox1.Controls.Add(this.user);
            this.groupBox1.Controls.Add(this.ip_server);
            this.groupBox1.Controls.Add(this.connect);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.pass);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Chocolate;
            this.groupBox1.Location = new System.Drawing.Point(526, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(477, 167);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login";
            // 
            // sign_up
            // 
            this.sign_up.AutoSize = true;
            this.sign_up.BackColor = System.Drawing.Color.LightSalmon;
            this.sign_up.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sign_up.Font = new System.Drawing.Font("Quicksand", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sign_up.ForeColor = System.Drawing.Color.Transparent;
            this.sign_up.Location = new System.Drawing.Point(389, 92);
            this.sign_up.Name = "sign_up";
            this.sign_up.Size = new System.Drawing.Size(73, 25);
            this.sign_up.TabIndex = 11;
            this.sign_up.Text = "Sign up";
            this.sign_up.Click += new System.EventHandler(this.sign_up_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.PapayaWhip;
            this.groupBox2.Controls.Add(this.quit);
            this.groupBox2.Controls.Add(this.prev);
            this.groupBox2.Controls.Add(this.back);
            this.groupBox2.Controls.Add(this.webBrowser1);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.richTextBox1);
            this.groupBox2.Font = new System.Drawing.Font("Bungee", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1009, 510);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "FTP Client";
            // 
            // quit
            // 
            this.quit.AutoSize = true;
            this.quit.BackColor = System.Drawing.Color.LightSalmon;
            this.quit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.quit.Font = new System.Drawing.Font("Quicksand", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quit.ForeColor = System.Drawing.Color.Transparent;
            this.quit.Location = new System.Drawing.Point(427, 463);
            this.quit.Name = "quit";
            this.quit.Size = new System.Drawing.Size(46, 25);
            this.quit.TabIndex = 5;
            this.quit.Text = "Quit";
            this.quit.Click += new System.EventHandler(this.quit_Click);
            // 
            // prev
            // 
            this.prev.BackColor = System.Drawing.Color.LightSalmon;
            this.prev.Font = new System.Drawing.Font("Quicksand", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prev.ForeColor = System.Drawing.Color.Transparent;
            this.prev.Location = new System.Drawing.Point(422, 321);
            this.prev.Name = "prev";
            this.prev.Size = new System.Drawing.Size(51, 46);
            this.prev.TabIndex = 10;
            this.prev.Text = ">>";
            this.prev.UseVisualStyleBackColor = false;
            this.prev.Click += new System.EventHandler(this.prev_Click);
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.LightSalmon;
            this.back.Font = new System.Drawing.Font("Quicksand", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.ForeColor = System.Drawing.Color.Transparent;
            this.back.Location = new System.Drawing.Point(422, 269);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(51, 46);
            this.back.TabIndex = 10;
            this.back.Text = "<<";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(479, 269);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(524, 235);
            this.webBrowser1.TabIndex = 9;
            this.webBrowser1.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.webBrowser1_Navigated);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.PeachPuff;
            this.groupBox4.Controls.Add(this.download);
            this.groupBox4.Controls.Add(this.delete);
            this.groupBox4.Controls.Add(this.send);
            this.groupBox4.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.Chocolate;
            this.groupBox4.Location = new System.Drawing.Point(11, 321);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(188, 167);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Application";
            // 
            // download
            // 
            this.download.AutoSize = true;
            this.download.BackColor = System.Drawing.Color.LightSalmon;
            this.download.Cursor = System.Windows.Forms.Cursors.Hand;
            this.download.Font = new System.Drawing.Font("Quicksand", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.download.ForeColor = System.Drawing.Color.Transparent;
            this.download.Location = new System.Drawing.Point(15, 75);
            this.download.Name = "download";
            this.download.Size = new System.Drawing.Size(94, 25);
            this.download.TabIndex = 8;
            this.download.Text = "Download";
            this.download.Click += new System.EventHandler(this.download_Click);
            // 
            // delete
            // 
            this.delete.AutoSize = true;
            this.delete.BackColor = System.Drawing.Color.LightSalmon;
            this.delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delete.Font = new System.Drawing.Font("Quicksand", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.ForeColor = System.Drawing.Color.Transparent;
            this.delete.Location = new System.Drawing.Point(15, 113);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(66, 25);
            this.delete.TabIndex = 7;
            this.delete.Text = "Delete";
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.PeachPuff;
            this.groupBox3.Controls.Add(this.encode);
            this.groupBox3.Controls.Add(this.decode);
            this.groupBox3.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Chocolate;
            this.groupBox3.Location = new System.Drawing.Point(233, 321);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(161, 167);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "AES Crypto";
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(1033, 534);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Client";
            this.Text = "Client";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Client_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox ip_server;
        private System.Windows.Forms.TextBox user;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.Label encode;
        private System.Windows.Forms.Label decode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label send;
        private System.Windows.Forms.Label connect;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button prev;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Label delete;
        private System.Windows.Forms.Label download;
        private System.Windows.Forms.Label sign_up;
        private System.Windows.Forms.Label quit;
    }
}