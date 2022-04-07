namespace do_an
{
    partial class sign
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sign));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sign_up = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.user = new System.Windows.Forms.Label();
            this.pass_text = new System.Windows.Forms.TextBox();
            this.user_text = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.PapayaWhip;
            this.groupBox1.Controls.Add(this.sign_up);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.user);
            this.groupBox1.Controls.Add(this.pass_text);
            this.groupBox1.Controls.Add(this.user_text);
            this.groupBox1.Font = new System.Drawing.Font("Bungee", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(394, 266);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sign up";
            // 
            // sign_up
            // 
            this.sign_up.AutoSize = true;
            this.sign_up.BackColor = System.Drawing.Color.LightSalmon;
            this.sign_up.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sign_up.Font = new System.Drawing.Font("Quicksand", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sign_up.ForeColor = System.Drawing.Color.Transparent;
            this.sign_up.Location = new System.Drawing.Point(311, 227);
            this.sign_up.Name = "sign_up";
            this.sign_up.Size = new System.Drawing.Size(73, 25);
            this.sign_up.TabIndex = 1;
            this.sign_up.Text = "Sign up";
            this.sign_up.Click += new System.EventHandler(this.sign_up_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.PapayaWhip;
            this.label2.Font = new System.Drawing.Font("Quicksand", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Salmon;
            this.label2.Location = new System.Drawing.Point(37, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password:";
            // 
            // user
            // 
            this.user.AutoSize = true;
            this.user.BackColor = System.Drawing.Color.PapayaWhip;
            this.user.Font = new System.Drawing.Font("Quicksand", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user.ForeColor = System.Drawing.Color.Salmon;
            this.user.Location = new System.Drawing.Point(37, 105);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(54, 25);
            this.user.TabIndex = 1;
            this.user.Text = "User:";
            // 
            // pass_text
            // 
            this.pass_text.Font = new System.Drawing.Font("Quicksand", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass_text.ForeColor = System.Drawing.Color.DarkSalmon;
            this.pass_text.Location = new System.Drawing.Point(151, 158);
            this.pass_text.Name = "pass_text";
            this.pass_text.Size = new System.Drawing.Size(132, 29);
            this.pass_text.TabIndex = 0;
            // 
            // user_text
            // 
            this.user_text.Font = new System.Drawing.Font("Quicksand", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_text.ForeColor = System.Drawing.Color.DarkSalmon;
            this.user_text.Location = new System.Drawing.Point(151, 101);
            this.user_text.Name = "user_text";
            this.user_text.Size = new System.Drawing.Size(132, 29);
            this.user_text.TabIndex = 0;
            // 
            // sign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(418, 290);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "sign";
            this.Text = "Sign up";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label sign_up;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label user;
        private System.Windows.Forms.TextBox pass_text;
        private System.Windows.Forms.TextBox user_text;
    }
}