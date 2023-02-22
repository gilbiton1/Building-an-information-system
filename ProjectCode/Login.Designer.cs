namespace partBproject
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
            this.components = new System.ComponentModel.Container();
            this.userName = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.approveLogin = new System.Windows.Forms.Button();
            this.exitHome = new System.Windows.Forms.Button();
            this.wrongPassword = new System.Windows.Forms.ErrorProvider(this.components);
            this.hidePassword = new System.Windows.Forms.Button();
            this.showPassword = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.wrongPassword)).BeginInit();
            this.SuspendLayout();
            // 
            // userName
            // 
            this.userName.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userName.ForeColor = System.Drawing.Color.Black;
            this.userName.Location = new System.Drawing.Point(154, 117);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(126, 23);
            this.userName.TabIndex = 0;
            this.userName.TextChanged += new System.EventHandler(this.userName_TextChanged);
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.ForeColor = System.Drawing.Color.Black;
            this.password.Location = new System.Drawing.Point(169, 169);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(111, 23);
            this.password.TabIndex = 1;
            this.password.TextChanged += new System.EventHandler(this.password_TextChanged);
            this.password.Validating += new System.ComponentModel.CancelEventHandler(this.password_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(314, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "שם משתמש";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(351, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "סיסמה";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft New Tai Lue", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(58, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(409, 28);
            this.label3.TabIndex = 5;
            this.label3.Text = "ברוכים הבאים לחברת \"אברהם אליהו ובניו בע\"מ\"";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // approveLogin
            // 
            this.approveLogin.BackColor = System.Drawing.Color.Peru;
            this.approveLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.approveLogin.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.approveLogin.ForeColor = System.Drawing.Color.Black;
            this.approveLogin.Location = new System.Drawing.Point(154, 223);
            this.approveLogin.Name = "approveLogin";
            this.approveLogin.Size = new System.Drawing.Size(254, 28);
            this.approveLogin.TabIndex = 6;
            this.approveLogin.Text = "כניסה";
            this.approveLogin.UseVisualStyleBackColor = false;
            this.approveLogin.Click += new System.EventHandler(this.approveLogin_Click);
            this.approveLogin.Validating += new System.ComponentModel.CancelEventHandler(this.approveLogin_Validating);
            // 
            // exitHome
            // 
            this.exitHome.BackgroundImage = global::partBproject.Properties.Resources.Picture11;
            this.exitHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exitHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitHome.ForeColor = System.Drawing.Color.Black;
            this.exitHome.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.exitHome.Location = new System.Drawing.Point(12, 282);
            this.exitHome.Name = "exitHome";
            this.exitHome.Size = new System.Drawing.Size(43, 39);
            this.exitHome.TabIndex = 7;
            this.exitHome.UseVisualStyleBackColor = true;
            this.exitHome.Click += new System.EventHandler(this.exitHome_Click);
            // 
            // wrongPassword
            // 
            this.wrongPassword.ContainerControl = this;
            // 
            // hidePassword
            // 
            this.hidePassword.BackColor = System.Drawing.Color.White;
            this.hidePassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.hidePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hidePassword.ForeColor = System.Drawing.Color.Black;
            this.hidePassword.Image = global::partBproject.Properties.Resources.Picture9;
            this.hidePassword.Location = new System.Drawing.Point(154, 169);
            this.hidePassword.Name = "hidePassword";
            this.hidePassword.Size = new System.Drawing.Size(28, 22);
            this.hidePassword.TabIndex = 8;
            this.hidePassword.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hidePassword.UseVisualStyleBackColor = false;
            this.hidePassword.Click += new System.EventHandler(this.hidePassword_Click);
            // 
            // showPassword
            // 
            this.showPassword.BackColor = System.Drawing.Color.White;
            this.showPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showPassword.ForeColor = System.Drawing.Color.Black;
            this.showPassword.Image = global::partBproject.Properties.Resources.עין_פתוחה;
            this.showPassword.Location = new System.Drawing.Point(154, 169);
            this.showPassword.Name = "showPassword";
            this.showPassword.Size = new System.Drawing.Size(28, 23);
            this.showPassword.TabIndex = 9;
            this.showPassword.UseVisualStyleBackColor = false;
            this.showPassword.Click += new System.EventHandler(this.showPassword_Click_1);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::partBproject.Properties.Resources.Picture10;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(526, 333);
            this.Controls.Add(this.showPassword);
            this.Controls.Add(this.hidePassword);
            this.Controls.Add(this.exitHome);
            this.Controls.Add(this.approveLogin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.password);
            this.Controls.Add(this.userName);
            this.DoubleBuffered = true;
            this.Name = "Login";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.wrongPassword)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox userName;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button approveLogin;
        private System.Windows.Forms.Button exitHome;
        private System.Windows.Forms.ErrorProvider wrongPassword;
        private System.Windows.Forms.Button showPassword;
        private System.Windows.Forms.Button hidePassword;
    }
}