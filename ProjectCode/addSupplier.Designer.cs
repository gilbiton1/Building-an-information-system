namespace partBproject
{
    partial class addSupplier
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.supID = new System.Windows.Forms.TextBox();
            this.supName = new System.Windows.Forms.TextBox();
            this.supAddress = new System.Windows.Forms.TextBox();
            this.comboBoxProff = new System.Windows.Forms.ComboBox();
            this.approve = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.errorID = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorAddress = new System.Windows.Forms.ErrorProvider(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.supPhone = new System.Windows.Forms.TextBox();
            this.errorPhone = new System.Windows.Forms.ErrorProvider(this.components);
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPhone)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(555, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "תעודת זהות";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(567, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "שם הספק";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(592, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "כתובת";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(279, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "תחום";
            // 
            // supID
            // 
            this.supID.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supID.Location = new System.Drawing.Point(402, 124);
            this.supID.Name = "supID";
            this.supID.Size = new System.Drawing.Size(115, 23);
            this.supID.TabIndex = 4;
            // 
            // supName
            // 
            this.supName.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supName.Location = new System.Drawing.Point(402, 182);
            this.supName.Name = "supName";
            this.supName.Size = new System.Drawing.Size(114, 23);
            this.supName.TabIndex = 5;
            // 
            // supAddress
            // 
            this.supAddress.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supAddress.Location = new System.Drawing.Point(402, 235);
            this.supAddress.Name = "supAddress";
            this.supAddress.Size = new System.Drawing.Size(115, 23);
            this.supAddress.TabIndex = 6;
            // 
            // comboBoxProff
            // 
            this.comboBoxProff.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProff.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxProff.FormattingEnabled = true;
            this.comboBoxProff.Location = new System.Drawing.Point(86, 120);
            this.comboBoxProff.Name = "comboBoxProff";
            this.comboBoxProff.Size = new System.Drawing.Size(125, 25);
            this.comboBoxProff.TabIndex = 7;
            // 
            // approve
            // 
            this.approve.BackColor = System.Drawing.Color.Peru;
            this.approve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.approve.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.approve.Location = new System.Drawing.Point(467, 307);
            this.approve.Name = "approve";
            this.approve.Size = new System.Drawing.Size(184, 40);
            this.approve.TabIndex = 8;
            this.approve.Text = "הוסף ספק";
            this.approve.UseVisualStyleBackColor = false;
            this.approve.Click += new System.EventHandler(this.approve_Click);
            // 
            // cancel
            // 
            this.cancel.BackgroundImage = global::partBproject.Properties.Resources.Picture11;
            this.cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel.Location = new System.Drawing.Point(12, 408);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(50, 45);
            this.cancel.TabIndex = 9;
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(247, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 22);
            this.label5.TabIndex = 10;
            this.label5.Text = "טלפון נייד";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // supPhone
            // 
            this.supPhone.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supPhone.Location = new System.Drawing.Point(86, 181);
            this.supPhone.Name = "supPhone";
            this.supPhone.Size = new System.Drawing.Size(125, 23);
            this.supPhone.TabIndex = 11;
            // 
            // errorPhone
            // 
            this.errorPhone.ContainerControl = this;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(479, 30);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(198, 38);
            this.label11.TabIndex = 44;
            this.label11.Text = "הוספת ספק חדש";
            // 
            // addSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::partBproject.Properties.Resources.Picture10;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(726, 465);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.supPhone);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.approve);
            this.Controls.Add(this.comboBoxProff);
            this.Controls.Add(this.supAddress);
            this.Controls.Add(this.supName);
            this.Controls.Add(this.supID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "addSupplier";
            this.Text = "addSupplier";
            this.Load += new System.EventHandler(this.addSupplier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPhone)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox supID;
        private System.Windows.Forms.TextBox supName;
        private System.Windows.Forms.TextBox supAddress;
        private System.Windows.Forms.ComboBox comboBoxProff;
        private System.Windows.Forms.Button approve;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.ErrorProvider errorID;
        private System.Windows.Forms.ErrorProvider errorName;
        private System.Windows.Forms.ErrorProvider errorAddress;
        private System.Windows.Forms.TextBox supPhone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ErrorProvider errorPhone;
        private System.Windows.Forms.Label label11;
    }
}