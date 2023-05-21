namespace Examples
{
    partial class Login
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.registerShow = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.userPs = new System.Windows.Forms.TextBox();
            this.userName = new System.Windows.Forms.TextBox();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.registerShow);
            this.groupBox1.Controls.Add(this.password);
            this.groupBox1.Controls.Add(this.name);
            this.groupBox1.Controls.Add(this.userPs);
            this.groupBox1.Controls.Add(this.userName);
            this.groupBox1.Controls.Add(this.LoginBtn);
            this.groupBox1.Location = new System.Drawing.Point(12, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(310, 160);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Логин";
            // 
            // registerShow
            // 
            this.registerShow.AutoSize = true;
            this.registerShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registerShow.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.registerShow.Location = new System.Drawing.Point(17, 142);
            this.registerShow.Name = "registerShow";
            this.registerShow.Size = new System.Drawing.Size(179, 13);
            this.registerShow.TabIndex = 5;
            this.registerShow.Text = "нету аккаунта зарегистрируйтесь";
            this.registerShow.Click += new System.EventHandler(this.registerShow_Click);
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
            // userPs
            // 
            this.userPs.Location = new System.Drawing.Point(41, 90);
            this.userPs.Name = "userPs";
            this.userPs.Size = new System.Drawing.Size(251, 20);
            this.userPs.TabIndex = 1;
            this.userPs.UseSystemPasswordChar = true;
            // 
            // userName
            // 
            this.userName.Location = new System.Drawing.Point(41, 41);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(251, 20);
            this.userName.TabIndex = 0;
            // 
            // LoginBtn
            // 
            this.LoginBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginBtn.Location = new System.Drawing.Point(217, 137);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(75, 23);
            this.LoginBtn.TabIndex = 2;
            this.LoginBtn.Text = "Отправить";
            this.LoginBtn.UseVisualStyleBackColor = true;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 261);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Домашняя бухгалтерия";
            this.Load += new System.EventHandler(this.Login_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.TextBox userPs;
        private System.Windows.Forms.TextBox userName;
        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.Label registerShow;
    }
}