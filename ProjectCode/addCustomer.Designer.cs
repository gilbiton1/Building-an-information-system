namespace partBproject
{
    partial class addCustomer
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
            this.cusAddress = new System.Windows.Forms.TextBox();
            this.cusName = new System.Windows.Forms.TextBox();
            this.cusEmail = new System.Windows.Forms.TextBox();
            this.cusID = new System.Windows.Forms.TextBox();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.cencel = new System.Windows.Forms.Button();
            this.approve = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorID = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorAddress = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorPhone = new System.Windows.Forms.ErrorProvider(this.components);
            this.cusPhone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cusBirthdate = new System.Windows.Forms.DateTimePicker();
            this.cusMinRange = new System.Windows.Forms.TextBox();
            this.cusMaxRange = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cusPassword = new System.Windows.Forms.TextBox();
            this.errorEmail = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorPassword = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorBirthdate = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorMinRange = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorMaxRange = new System.Windows.Forms.ErrorProvider(this.components);
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPhone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorBirthdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorMinRange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorMaxRange)).BeginInit();
            this.SuspendLayout();
            // 
            // cusAddress
            // 
            this.cusAddress.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cusAddress.Location = new System.Drawing.Point(63, 116);
            this.cusAddress.Name = "cusAddress";
            this.cusAddress.Size = new System.Drawing.Size(121, 23);
            this.cusAddress.TabIndex = 31;
            this.cusAddress.TextChanged += new System.EventHandler(this.cusAddress_TextChanged);
            // 
            // cusName
            // 
            this.cusName.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cusName.Location = new System.Drawing.Point(432, 164);
            this.cusName.Name = "cusName";
            this.cusName.Size = new System.Drawing.Size(121, 23);
            this.cusName.TabIndex = 30;
            this.cusName.TextChanged += new System.EventHandler(this.cusName_TextChanged);
            // 
            // cusEmail
            // 
            this.cusEmail.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cusEmail.Location = new System.Drawing.Point(432, 213);
            this.cusEmail.Name = "cusEmail";
            this.cusEmail.Size = new System.Drawing.Size(121, 23);
            this.cusEmail.TabIndex = 29;
            this.cusEmail.TextChanged += new System.EventHandler(this.cusEmail_TextChanged);
            // 
            // cusID
            // 
            this.cusID.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cusID.Location = new System.Drawing.Point(432, 119);
            this.cusID.Name = "cusID";
            this.cusID.Size = new System.Drawing.Size(121, 23);
            this.cusID.TabIndex = 28;
            this.cusID.TextChanged += new System.EventHandler(this.cusID_TextChanged);
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStatus.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Location = new System.Drawing.Point(63, 164);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(121, 25);
            this.comboBoxStatus.TabIndex = 26;
            this.comboBoxStatus.SelectedIndexChanged += new System.EventHandler(this.comboBoxStatus_SelectedIndexChanged);
            // 
            // cencel
            // 
            this.cencel.BackgroundImage = global::partBproject.Properties.Resources.Picture11;
            this.cencel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cencel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cencel.Location = new System.Drawing.Point(21, 427);
            this.cencel.Name = "cencel";
            this.cencel.Size = new System.Drawing.Size(45, 43);
            this.cencel.TabIndex = 25;
            this.cencel.UseVisualStyleBackColor = true;
            this.cencel.Click += new System.EventHandler(this.cencel_Click);
            // 
            // approve
            // 
            this.approve.BackColor = System.Drawing.Color.Peru;
            this.approve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.approve.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.approve.Location = new System.Drawing.Point(409, 367);
            this.approve.Name = "approve";
            this.approve.Size = new System.Drawing.Size(269, 38);
            this.approve.TabIndex = 24;
            this.approve.Text = "הוסף עובד";
            this.approve.UseVisualStyleBackColor = false;
            this.approve.Click += new System.EventHandler(this.approve_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(242, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 22);
            this.label7.TabIndex = 23;
            this.label7.Text = "סטטוס";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(245, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 22);
            this.label6.TabIndex = 22;
            this.label6.Text = "כתובת";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(644, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 22);
            this.label2.TabIndex = 21;
            this.label2.Text = "שם";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(621, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 22);
            this.label3.TabIndex = 20;
            this.label3.Text = "אימייל";
            this.label3.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(583, 307);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 22);
            this.label5.TabIndex = 19;
            this.label5.Text = "תאריך לידה";
            this.label5.Click += new System.EventHandler(this.label3_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(200, 212);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 22);
            this.label8.TabIndex = 18;
            this.label8.Text = "מחיר מינימלי";
            this.label8.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(582, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 22);
            this.label1.TabIndex = 17;
            this.label1.Text = "תעודת זהות";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // errorID
            // 
            this.errorID.ContainerControl = this;
            // 
            // errorName
            // 
            this.errorName.ContainerControl = this;
            // 
            // errorAddress
            // 
            this.errorAddress.ContainerControl = this;
            // 
            // errorPhone
            // 
            this.errorPhone.ContainerControl = this;
            // 
            // cusPhone
            // 
            this.cusPhone.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cusPhone.Location = new System.Drawing.Point(432, 258);
            this.cusPhone.Name = "cusPhone";
            this.cusPhone.Size = new System.Drawing.Size(121, 23);
            this.cusPhone.TabIndex = 35;
            this.cusPhone.TextChanged += new System.EventHandler(this.cusPhone_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(597, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 22);
            this.label4.TabIndex = 34;
            this.label4.Text = "טלפון נייד";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // cusBirthdate
            // 
            this.cusBirthdate.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cusBirthdate.Location = new System.Drawing.Point(353, 307);
            this.cusBirthdate.Name = "cusBirthdate";
            this.cusBirthdate.Size = new System.Drawing.Size(200, 23);
            this.cusBirthdate.TabIndex = 36;
            this.cusBirthdate.ValueChanged += new System.EventHandler(this.cusBirthdate_ValueChanged);
            // 
            // cusMinRange
            // 
            this.cusMinRange.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cusMinRange.Location = new System.Drawing.Point(63, 213);
            this.cusMinRange.Name = "cusMinRange";
            this.cusMinRange.Size = new System.Drawing.Size(119, 23);
            this.cusMinRange.TabIndex = 37;
            this.cusMinRange.TextChanged += new System.EventHandler(this.cusMinRange_TextChanged);
            // 
            // cusMaxRange
            // 
            this.cusMaxRange.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cusMaxRange.Location = new System.Drawing.Point(63, 259);
            this.cusMaxRange.Name = "cusMaxRange";
            this.cusMaxRange.Size = new System.Drawing.Size(119, 23);
            this.cusMaxRange.TabIndex = 38;
            this.cusMaxRange.TextChanged += new System.EventHandler(this.cusMaxRange_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(189, 257);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 22);
            this.label9.TabIndex = 39;
            this.label9.Text = "מחיר מקסימלי";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(242, 308);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 22);
            this.label10.TabIndex = 41;
            this.label10.Text = "סיסמה";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // cusPassword
            // 
            this.cusPassword.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cusPassword.Location = new System.Drawing.Point(63, 306);
            this.cusPassword.Name = "cusPassword";
            this.cusPassword.Size = new System.Drawing.Size(119, 23);
            this.cusPassword.TabIndex = 40;
            this.cusPassword.TextChanged += new System.EventHandler(this.cusPassword_TextChanged);
            // 
            // errorEmail
            // 
            this.errorEmail.ContainerControl = this;
            // 
            // errorPassword
            // 
            this.errorPassword.ContainerControl = this;
            // 
            // errorBirthdate
            // 
            this.errorBirthdate.ContainerControl = this;
            // 
            // errorMinRange
            // 
            this.errorMinRange.ContainerControl = this;
            // 
            // errorMaxRange
            // 
            this.errorMaxRange.ContainerControl = this;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(477, 30);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(201, 38);
            this.label11.TabIndex = 42;
            this.label11.Text = "הוספת לקוח חדש";
            // 
            // addCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::partBproject.Properties.Resources.Picture10;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(758, 482);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cusPassword);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cusMaxRange);
            this.Controls.Add(this.cusMinRange);
            this.Controls.Add(this.cusBirthdate);
            this.Controls.Add(this.cusPhone);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cusAddress);
            this.Controls.Add(this.cusName);
            this.Controls.Add(this.cusEmail);
            this.Controls.Add(this.cusID);
            this.Controls.Add(this.comboBoxStatus);
            this.Controls.Add(this.cencel);
            this.Controls.Add(this.approve);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "addCustomer";
            this.Text = "addCustomer";
            this.Load += new System.EventHandler(this.addCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPhone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorBirthdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorMinRange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorMaxRange)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox cusAddress;
        private System.Windows.Forms.TextBox cusName;
        private System.Windows.Forms.TextBox cusEmail;
        private System.Windows.Forms.TextBox cusID;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.Button cencel;
        private System.Windows.Forms.Button approve;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorID;
        private System.Windows.Forms.DateTimePicker cusBirthdate;
        private System.Windows.Forms.TextBox cusPhone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ErrorProvider errorName;
        private System.Windows.Forms.ErrorProvider errorAddress;
        private System.Windows.Forms.ErrorProvider errorPhone;
        private System.Windows.Forms.TextBox cusMaxRange;
        private System.Windows.Forms.TextBox cusMinRange;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox cusPassword;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ErrorProvider errorEmail;
        private System.Windows.Forms.ErrorProvider errorPassword;
        private System.Windows.Forms.ErrorProvider errorBirthdate;
        private System.Windows.Forms.ErrorProvider errorMinRange;
        private System.Windows.Forms.ErrorProvider errorMaxRange;
        private System.Windows.Forms.Label label11;
    }
}