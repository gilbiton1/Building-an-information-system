namespace partBproject
{
    partial class searchSupplier
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
            this.supPhone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cancel = new System.Windows.Forms.Button();
            this.approve = new System.Windows.Forms.Button();
            this.supAddress = new System.Windows.Forms.TextBox();
            this.supName = new System.Windows.Forms.TextBox();
            this.supID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.Button();
            this.errorID = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorAddress = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorPhone = new System.Windows.Forms.ErrorProvider(this.components);
            this.comboBoxProff = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.SSerrorID = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPhone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SSerrorID)).BeginInit();
            this.SuspendLayout();
            // 
            // supPhone
            // 
            this.supPhone.Location = new System.Drawing.Point(49, 212);
            this.supPhone.Name = "supPhone";
            this.supPhone.Size = new System.Drawing.Size(143, 20);
            this.supPhone.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(210, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 22);
            this.label5.TabIndex = 22;
            this.label5.Text = "טלפון נייד";
            // 
            // cancel
            // 
            this.cancel.BackgroundImage = global::partBproject.Properties.Resources.Picture11;
            this.cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel.Location = new System.Drawing.Point(12, 425);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(50, 44);
            this.cancel.TabIndex = 21;
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // approve
            // 
            this.approve.BackColor = System.Drawing.Color.Peru;
            this.approve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.approve.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.approve.Location = new System.Drawing.Point(501, 337);
            this.approve.Name = "approve";
            this.approve.Size = new System.Drawing.Size(159, 35);
            this.approve.TabIndex = 20;
            this.approve.Text = "עדכן פרטים";
            this.approve.UseVisualStyleBackColor = false;
            this.approve.Click += new System.EventHandler(this.approve_Click);
            // 
            // supAddress
            // 
            this.supAddress.Location = new System.Drawing.Point(396, 269);
            this.supAddress.Name = "supAddress";
            this.supAddress.Size = new System.Drawing.Size(137, 20);
            this.supAddress.TabIndex = 18;
            // 
            // supName
            // 
            this.supName.Location = new System.Drawing.Point(396, 205);
            this.supName.Name = "supName";
            this.supName.Size = new System.Drawing.Size(137, 20);
            this.supName.TabIndex = 17;
            // 
            // supID
            // 
            this.supID.Location = new System.Drawing.Point(396, 137);
            this.supID.Name = "supID";
            this.supID.Size = new System.Drawing.Size(137, 20);
            this.supID.TabIndex = 16;
            this.supID.TextChanged += new System.EventHandler(this.supID_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(240, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 22);
            this.label4.TabIndex = 15;
            this.label4.Text = "תחום";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(602, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 22);
            this.label3.TabIndex = 14;
            this.label3.Text = "כתובת";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(577, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 22);
            this.label2.TabIndex = 13;
            this.label2.Text = "שם הספק";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(564, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 22);
            this.label1.TabIndex = 12;
            this.label1.Text = "תעודת זהות";
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.Color.Peru;
            this.search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.Location = new System.Drawing.Point(338, 135);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(52, 23);
            this.search.TabIndex = 24;
            this.search.Text = "חפש";
            this.search.UseVisualStyleBackColor = false;
            this.search.Click += new System.EventHandler(this.search_Click);
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
            // comboBoxProff
            // 
            this.comboBoxProff.FormattingEnabled = true;
            this.comboBoxProff.Location = new System.Drawing.Point(49, 134);
            this.comboBoxProff.Name = "comboBoxProff";
            this.comboBoxProff.Size = new System.Drawing.Size(143, 21);
            this.comboBoxProff.TabIndex = 25;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(489, 27);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(172, 38);
            this.label11.TabIndex = 67;
            this.label11.Text = "עדכן ספק קיים";
            // 
            // SSerrorID
            // 
            this.SSerrorID.ContainerControl = this;
            // 
            // searchSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::partBproject.Properties.Resources.Picture10;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(738, 481);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.comboBoxProff);
            this.Controls.Add(this.search);
            this.Controls.Add(this.supPhone);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.approve);
            this.Controls.Add(this.supAddress);
            this.Controls.Add(this.supName);
            this.Controls.Add(this.supID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "searchSupplier";
            this.Text = "searchSupplier";
            this.Load += new System.EventHandler(this.searchSupplier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPhone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SSerrorID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox supPhone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button approve;
        private System.Windows.Forms.TextBox supAddress;
        private System.Windows.Forms.TextBox supName;
        private System.Windows.Forms.TextBox supID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.ErrorProvider errorID;
        private System.Windows.Forms.ErrorProvider errorName;
        private System.Windows.Forms.ErrorProvider errorAddress;
        private System.Windows.Forms.ErrorProvider errorPhone;
        private System.Windows.Forms.ComboBox comboBoxProff;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ErrorProvider SSerrorID;
    }
}