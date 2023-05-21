namespace Examples
{
    partial class Registration
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
            this.userName = new System.Windows.Forms.TextBox();
            this.userPs = new System.Windows.Forms.TextBox();
            this.SignIn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.password = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.loginShow = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // userName
            // 
            this.userName.Location = new System.Drawing.Point(41, 41);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(251, 20);
            this.userName.TabIndex = 0;
            // 
            // userPs
            // 
            this.userPs.Location = new System.Drawing.Point(41, 90);
            this.userPs.Name = "userPs";
            this.userPs.Size = new System.Drawing.Size(251, 20);
            this.userPs.TabIndex = 1;
            this.userPs.UseSystemPasswordChar = true;
            // 
            // SignIn
            // 
            this.SignIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SignIn.Location = new System.Drawing.Point(217, 137);
            this.SignIn.Name = "SignIn";
            this.SignIn.Size = new System.Drawing.Size(75, 23);
            this.SignIn.TabIndex = 2;
            this.SignIn.Text = "Отправить";
            this.SignIn.UseVisualStyleBackColor = true;
            this.SignIn.Click += new System.EventHandler(this.SignIn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.loginShow);
            this.groupBox1.Controls.Add(this.password);
            this.groupBox1.Controls.Add(this.name);
            this.groupBox1.Controls.Add(this.userPs);
            this.groupBox1.Controls.Add(this.userName);
            this.groupBox1.Controls.Add(this.SignIn);
            this.groupBox1.Location = new System.Drawing.Point(12, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(310, 160);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Регистрация";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Location = new System.Drawing.Point(7, 74);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(45, 13);
            this.password.TabIndex = 4;
            this.password.Text = "Пароль";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(7, 31);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(29, 13);
            this.name.TabIndex = 3;
            this.name.Text = "Имя";
            // 
            // loginShow
            // 
            this.loginShow.AutoSize = true;
            this.loginShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginShow.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.loginShow.Location = new System.Drawing.Point(16, 142);
            this.loginShow.Name = "loginShow";
            this.loginShow.Size = new System.Drawing.Size(141, 13);
            this.loginShow.TabIndex = 6;
            this.loginShow.Text = "Есть аккаунт залогинтесь";
            this.loginShow.Click += new System.EventHandler(this.loginShow_Click);
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 261);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(350, 300);
            this.MinimumSize = new System.Drawing.Size(350, 300);
            this.Name = "Registration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Домашняя бухгалтерия";
            this.Load += new System.EventHandler(this.Registration_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox userName;
        private System.Windows.Forms.TextBox userPs;
        private System.Windows.Forms.Button SignIn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label loginShow;
    }
}