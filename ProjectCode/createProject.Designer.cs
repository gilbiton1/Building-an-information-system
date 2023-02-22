using System;

namespace partBproject
{
	partial class createProject
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
            this.serialNumberHeadLine = new System.Windows.Forms.Label();
            this.projectNameHeadLine = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.locationHeadLine = new System.Windows.Forms.Label();
            this.stageHeadLine = new System.Windows.Forms.Label();
            this.statusHeadLine = new System.Windows.Forms.Label();
            this.cityHeadLine = new System.Windows.Forms.Label();
            this.CPapproveButton = new System.Windows.Forms.Button();
            this.CPcancelButton = new System.Windows.Forms.Button();
            this.projectText = new System.Windows.Forms.TextBox();
            this.locationText = new System.Windows.Forms.TextBox();
            this.CPcomboBoxStage = new System.Windows.Forms.ComboBox();
            this.CPcomboBoxStatus = new System.Windows.Forms.ComboBox();
            this.CPCityText = new System.Windows.Forms.TextBox();
            this.CPEndTime = new System.Windows.Forms.DateTimePicker();
            this.nameError = new System.Windows.Forms.ErrorProvider(this.components);
            this.locationError = new System.Windows.Forms.ErrorProvider(this.components);
            this.cityError = new System.Windows.Forms.ErrorProvider(this.components);
            this.stageError = new System.Windows.Forms.ErrorProvider(this.components);
            this.serialNumberText = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nameError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stageError)).BeginInit();
            this.SuspendLayout();
            // 
            // serialNumberHeadLine
            // 
            this.serialNumberHeadLine.AutoSize = true;
            this.serialNumberHeadLine.BackColor = System.Drawing.Color.Transparent;
            this.serialNumberHeadLine.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serialNumberHeadLine.ForeColor = System.Drawing.Color.White;
            this.serialNumberHeadLine.Location = new System.Drawing.Point(550, 125);
            this.serialNumberHeadLine.Name = "serialNumberHeadLine";
            this.serialNumberHeadLine.Size = new System.Drawing.Size(102, 22);
            this.serialNumberHeadLine.TabIndex = 0;
            this.serialNumberHeadLine.Text = "מספר סידורי";
            // 
            // projectNameHeadLine
            // 
            this.projectNameHeadLine.AutoSize = true;
            this.projectNameHeadLine.BackColor = System.Drawing.Color.Transparent;
            this.projectNameHeadLine.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectNameHeadLine.ForeColor = System.Drawing.Color.White;
            this.projectNameHeadLine.Location = new System.Drawing.Point(546, 181);
            this.projectNameHeadLine.Name = "projectNameHeadLine";
            this.projectNameHeadLine.Size = new System.Drawing.Size(106, 22);
            this.projectNameHeadLine.TabIndex = 1;
            this.projectNameHeadLine.Text = "שם הפרוייקט";
            this.projectNameHeadLine.Click += new System.EventHandler(this.projectNameHeadLine_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(522, 243);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "מועד סיום מוערך";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // locationHeadLine
            // 
            this.locationHeadLine.AutoSize = true;
            this.locationHeadLine.BackColor = System.Drawing.Color.Transparent;
            this.locationHeadLine.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationHeadLine.ForeColor = System.Drawing.Color.White;
            this.locationHeadLine.Location = new System.Drawing.Point(594, 302);
            this.locationHeadLine.Name = "locationHeadLine";
            this.locationHeadLine.Size = new System.Drawing.Size(58, 22);
            this.locationHeadLine.TabIndex = 3;
            this.locationHeadLine.Text = "כתובת";
            // 
            // stageHeadLine
            // 
            this.stageHeadLine.AutoSize = true;
            this.stageHeadLine.BackColor = System.Drawing.Color.Transparent;
            this.stageHeadLine.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stageHeadLine.ForeColor = System.Drawing.Color.White;
            this.stageHeadLine.Location = new System.Drawing.Point(234, 125);
            this.stageHeadLine.Name = "stageHeadLine";
            this.stageHeadLine.Size = new System.Drawing.Size(42, 22);
            this.stageHeadLine.TabIndex = 4;
            this.stageHeadLine.Text = "שלב";
            // 
            // statusHeadLine
            // 
            this.statusHeadLine.AutoSize = true;
            this.statusHeadLine.BackColor = System.Drawing.Color.Transparent;
            this.statusHeadLine.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusHeadLine.ForeColor = System.Drawing.Color.White;
            this.statusHeadLine.Location = new System.Drawing.Point(215, 187);
            this.statusHeadLine.Name = "statusHeadLine";
            this.statusHeadLine.Size = new System.Drawing.Size(61, 22);
            this.statusHeadLine.TabIndex = 5;
            this.statusHeadLine.Text = "סטטוס";
            // 
            // cityHeadLine
            // 
            this.cityHeadLine.AutoSize = true;
            this.cityHeadLine.BackColor = System.Drawing.Color.Transparent;
            this.cityHeadLine.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityHeadLine.ForeColor = System.Drawing.Color.White;
            this.cityHeadLine.Location = new System.Drawing.Point(234, 245);
            this.cityHeadLine.Name = "cityHeadLine";
            this.cityHeadLine.Size = new System.Drawing.Size(34, 22);
            this.cityHeadLine.TabIndex = 6;
            this.cityHeadLine.Text = "עיר";
            // 
            // CPapproveButton
            // 
            this.CPapproveButton.BackColor = System.Drawing.Color.Peru;
            this.CPapproveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CPapproveButton.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPapproveButton.Location = new System.Drawing.Point(448, 370);
            this.CPapproveButton.Name = "CPapproveButton";
            this.CPapproveButton.Size = new System.Drawing.Size(204, 45);
            this.CPapproveButton.TabIndex = 7;
            this.CPapproveButton.Text = "צור פרויקט";
            this.CPapproveButton.UseVisualStyleBackColor = false;
            this.CPapproveButton.Click += new System.EventHandler(this.CPapproveButton_Click_1);
            // 
            // CPcancelButton
            // 
            this.CPcancelButton.BackgroundImage = global::partBproject.Properties.Resources.Picture11;
            this.CPcancelButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CPcancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CPcancelButton.Location = new System.Drawing.Point(12, 431);
            this.CPcancelButton.Name = "CPcancelButton";
            this.CPcancelButton.Size = new System.Drawing.Size(49, 42);
            this.CPcancelButton.TabIndex = 8;
            this.CPcancelButton.UseVisualStyleBackColor = true;
            this.CPcancelButton.Click += new System.EventHandler(this.CPcancelButton_Click);
            // 
            // projectText
            // 
            this.projectText.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectText.Location = new System.Drawing.Point(313, 182);
            this.projectText.Name = "projectText";
            this.projectText.Size = new System.Drawing.Size(188, 23);
            this.projectText.TabIndex = 9;
            // 
            // locationText
            // 
            this.locationText.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationText.Location = new System.Drawing.Point(313, 301);
            this.locationText.Name = "locationText";
            this.locationText.Size = new System.Drawing.Size(188, 23);
            this.locationText.TabIndex = 10;
            this.locationText.TextChanged += new System.EventHandler(this.locationText_TextChanged_1);
            // 
            // CPcomboBoxStage
            // 
            this.CPcomboBoxStage.BackColor = System.Drawing.Color.White;
            this.CPcomboBoxStage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CPcomboBoxStage.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPcomboBoxStage.FormattingEnabled = true;
            this.CPcomboBoxStage.Location = new System.Drawing.Point(63, 125);
            this.CPcomboBoxStage.Name = "CPcomboBoxStage";
            this.CPcomboBoxStage.Size = new System.Drawing.Size(119, 25);
            this.CPcomboBoxStage.TabIndex = 11;
            this.CPcomboBoxStage.SelectedIndexChanged += new System.EventHandler(this.CPcomboBoxStage_SelectedIndexChanged);
            // 
            // CPcomboBoxStatus
            // 
            this.CPcomboBoxStatus.BackColor = System.Drawing.Color.White;
            this.CPcomboBoxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CPcomboBoxStatus.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPcomboBoxStatus.FormattingEnabled = true;
            this.CPcomboBoxStatus.Location = new System.Drawing.Point(63, 184);
            this.CPcomboBoxStatus.Name = "CPcomboBoxStatus";
            this.CPcomboBoxStatus.Size = new System.Drawing.Size(119, 25);
            this.CPcomboBoxStatus.TabIndex = 12;
            // 
            // CPCityText
            // 
            this.CPCityText.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPCityText.Location = new System.Drawing.Point(63, 245);
            this.CPCityText.Name = "CPCityText";
            this.CPCityText.Size = new System.Drawing.Size(119, 23);
            this.CPCityText.TabIndex = 13;
            // 
            // CPEndTime
            // 
            this.CPEndTime.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPEndTime.Location = new System.Drawing.Point(313, 243);
            this.CPEndTime.MinDate = new System.DateTime(2022, 6, 13, 0, 0, 0, 0);
            this.CPEndTime.Name = "CPEndTime";
            this.CPEndTime.Size = new System.Drawing.Size(188, 23);
            this.CPEndTime.TabIndex = 14;
            this.CPEndTime.ValueChanged += new System.EventHandler(this.CPEndTime_ValueChanged);
            // 
            // nameError
            // 
            this.nameError.ContainerControl = this;
            // 
            // locationError
            // 
            this.locationError.ContainerControl = this;
            // 
            // cityError
            // 
            this.cityError.ContainerControl = this;
            // 
            // stageError
            // 
            this.stageError.ContainerControl = this;
            // 
            // serialNumberText
            // 
            this.serialNumberText.AutoSize = true;
            this.serialNumberText.Location = new System.Drawing.Point(346, 44);
            this.serialNumberText.Name = "serialNumberText";
            this.serialNumberText.Size = new System.Drawing.Size(0, 13);
            this.serialNumberText.TabIndex = 15;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(468, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(210, 38);
            this.label11.TabIndex = 44;
            this.label11.Text = "יצירת פרויקט חדש";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(444, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 22);
            this.label2.TabIndex = 45;
            // 
            // createProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::partBproject.Properties.Resources.Picture10;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(727, 485);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.serialNumberText);
            this.Controls.Add(this.CPEndTime);
            this.Controls.Add(this.CPCityText);
            this.Controls.Add(this.CPcomboBoxStatus);
            this.Controls.Add(this.CPcomboBoxStage);
            this.Controls.Add(this.locationText);
            this.Controls.Add(this.projectText);
            this.Controls.Add(this.CPcancelButton);
            this.Controls.Add(this.CPapproveButton);
            this.Controls.Add(this.cityHeadLine);
            this.Controls.Add(this.statusHeadLine);
            this.Controls.Add(this.stageHeadLine);
            this.Controls.Add(this.locationHeadLine);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.projectNameHeadLine);
            this.Controls.Add(this.serialNumberHeadLine);
            this.DoubleBuffered = true;
            this.Name = "createProject";
            this.Text = "createProject";
            this.Load += new System.EventHandler(this.createProject_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nameError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stageError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        private void CPcomboBoxStage_SelectedIndexChanged(object sender, EventArgs e)
        {
           // throw new NotImplementedException();
        }

        private void CPEndTime_ValueChanged(object sender, EventArgs e)
        {
          //  throw new NotImplementedException();
        }

        private void label1_Click(object sender, EventArgs e)
        {
          //  throw new NotImplementedException();
        }

        private void projectNameHeadLine_Click(object sender, EventArgs e)
        {
          //  throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label serialNumberHeadLine;
		private System.Windows.Forms.Label projectNameHeadLine;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label locationHeadLine;
		private System.Windows.Forms.Label stageHeadLine;
		private System.Windows.Forms.Label statusHeadLine;
		private System.Windows.Forms.Label cityHeadLine;
		private System.Windows.Forms.Button CPapproveButton;
		private System.Windows.Forms.Button CPcancelButton;
		private System.Windows.Forms.TextBox projectText;
		private System.Windows.Forms.TextBox locationText;
		private System.Windows.Forms.ComboBox CPcomboBoxStage;
		private System.Windows.Forms.ComboBox CPcomboBoxStatus;
		private System.Windows.Forms.TextBox CPCityText;
		private System.Windows.Forms.DateTimePicker CPEndTime;
        private System.Windows.Forms.ErrorProvider nameError;
        private System.Windows.Forms.ErrorProvider locationError;
        private System.Windows.Forms.ErrorProvider cityError;
        private System.Windows.Forms.ErrorProvider stageError;
        private System.Windows.Forms.Label serialNumberText;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label2;
    }
}