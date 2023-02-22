namespace partBproject
{
	partial class createContact
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
            this.CCChooseWorkerHeadLine = new System.Windows.Forms.Label();
            this.CCSubjectHeadLine = new System.Windows.Forms.Label();
            this.CCContentHeadLine = new System.Windows.Forms.Label();
            this.CCApprove = new System.Windows.Forms.Button();
            this.CCCancel = new System.Windows.Forms.Button();
            this.CCChooseWorker = new System.Windows.Forms.ComboBox();
            this.CCSubject = new System.Windows.Forms.TextBox();
            this.CCContent = new System.Windows.Forms.RichTextBox();
            this.subjectError = new System.Windows.Forms.ErrorProvider(this.components);
            this.contentError = new System.Windows.Forms.ErrorProvider(this.components);
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.subjectError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contentError)).BeginInit();
            this.SuspendLayout();
            // 
            // CCChooseWorkerHeadLine
            // 
            this.CCChooseWorkerHeadLine.AutoSize = true;
            this.CCChooseWorkerHeadLine.BackColor = System.Drawing.Color.Transparent;
            this.CCChooseWorkerHeadLine.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CCChooseWorkerHeadLine.ForeColor = System.Drawing.Color.White;
            this.CCChooseWorkerHeadLine.Location = new System.Drawing.Point(667, 122);
            this.CCChooseWorkerHeadLine.Name = "CCChooseWorkerHeadLine";
            this.CCChooseWorkerHeadLine.Size = new System.Drawing.Size(78, 22);
            this.CCChooseWorkerHeadLine.TabIndex = 0;
            this.CCChooseWorkerHeadLine.Text = "בחר עובד";
            // 
            // CCSubjectHeadLine
            // 
            this.CCSubjectHeadLine.AutoSize = true;
            this.CCSubjectHeadLine.BackColor = System.Drawing.Color.Transparent;
            this.CCSubjectHeadLine.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CCSubjectHeadLine.ForeColor = System.Drawing.Color.White;
            this.CCSubjectHeadLine.Location = new System.Drawing.Point(698, 173);
            this.CCSubjectHeadLine.Name = "CCSubjectHeadLine";
            this.CCSubjectHeadLine.Size = new System.Drawing.Size(47, 22);
            this.CCSubjectHeadLine.TabIndex = 1;
            this.CCSubjectHeadLine.Text = "נושא";
            // 
            // CCContentHeadLine
            // 
            this.CCContentHeadLine.AutoSize = true;
            this.CCContentHeadLine.BackColor = System.Drawing.Color.Transparent;
            this.CCContentHeadLine.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CCContentHeadLine.ForeColor = System.Drawing.Color.White;
            this.CCContentHeadLine.Location = new System.Drawing.Point(655, 218);
            this.CCContentHeadLine.Name = "CCContentHeadLine";
            this.CCContentHeadLine.Size = new System.Drawing.Size(90, 22);
            this.CCContentHeadLine.TabIndex = 2;
            this.CCContentHeadLine.Text = "תוכן הפניה";
            // 
            // CCApprove
            // 
            this.CCApprove.BackColor = System.Drawing.Color.Peru;
            this.CCApprove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CCApprove.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CCApprove.Location = new System.Drawing.Point(583, 380);
            this.CCApprove.Name = "CCApprove";
            this.CCApprove.Size = new System.Drawing.Size(162, 37);
            this.CCApprove.TabIndex = 3;
            this.CCApprove.Text = "שלח פניה";
            this.CCApprove.UseVisualStyleBackColor = false;
            this.CCApprove.Click += new System.EventHandler(this.CCApprove_Click);
            // 
            // CCCancel
            // 
            this.CCCancel.BackgroundImage = global::partBproject.Properties.Resources.Picture11;
            this.CCCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CCCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CCCancel.Location = new System.Drawing.Point(12, 411);
            this.CCCancel.Name = "CCCancel";
            this.CCCancel.Size = new System.Drawing.Size(43, 34);
            this.CCCancel.TabIndex = 4;
            this.CCCancel.UseVisualStyleBackColor = true;
            this.CCCancel.Click += new System.EventHandler(this.CCCancel_Click);
            // 
            // CCChooseWorker
            // 
            this.CCChooseWorker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CCChooseWorker.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CCChooseWorker.FormattingEnabled = true;
            this.CCChooseWorker.Location = new System.Drawing.Point(505, 122);
            this.CCChooseWorker.Name = "CCChooseWorker";
            this.CCChooseWorker.Size = new System.Drawing.Size(121, 25);
            this.CCChooseWorker.TabIndex = 5;
            this.CCChooseWorker.SelectedIndexChanged += new System.EventHandler(this.CCChooseWorker_SelectedIndexChanged_1);
            // 
            // CCSubject
            // 
            this.CCSubject.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CCSubject.Location = new System.Drawing.Point(505, 175);
            this.CCSubject.Name = "CCSubject";
            this.CCSubject.Size = new System.Drawing.Size(121, 23);
            this.CCSubject.TabIndex = 6;
            // 
            // CCContent
            // 
            this.CCContent.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CCContent.Location = new System.Drawing.Point(88, 221);
            this.CCContent.Name = "CCContent";
            this.CCContent.Size = new System.Drawing.Size(538, 128);
            this.CCContent.TabIndex = 8;
            this.CCContent.Text = "";
            // 
            // subjectError
            // 
            this.subjectError.ContainerControl = this;
            // 
            // contentError
            // 
            this.contentError.ContainerControl = this;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(639, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 38);
            this.label11.TabIndex = 43;
            this.label11.Text = "צור קשר";
            // 
            // createContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::partBproject.Properties.Resources.Picture10;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(837, 457);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.CCContent);
            this.Controls.Add(this.CCSubject);
            this.Controls.Add(this.CCChooseWorker);
            this.Controls.Add(this.CCCancel);
            this.Controls.Add(this.CCApprove);
            this.Controls.Add(this.CCContentHeadLine);
            this.Controls.Add(this.CCSubjectHeadLine);
            this.Controls.Add(this.CCChooseWorkerHeadLine);
            this.DoubleBuffered = true;
            this.Name = "createContact";
            this.Text = "createContact";
            this.Load += new System.EventHandler(this.createContact_Load);
            ((System.ComponentModel.ISupportInitialize)(this.subjectError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contentError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label CCChooseWorkerHeadLine;
		private System.Windows.Forms.Label CCSubjectHeadLine;
		private System.Windows.Forms.Label CCContentHeadLine;
		private System.Windows.Forms.Button CCApprove;
		private System.Windows.Forms.Button CCCancel;
		private System.Windows.Forms.ComboBox CCChooseWorker;
		private System.Windows.Forms.TextBox CCSubject;
		private System.Windows.Forms.RichTextBox CCContent;
        private System.Windows.Forms.ErrorProvider subjectError;
        private System.Windows.Forms.ErrorProvider contentError;
        private System.Windows.Forms.Label label11;
    }
}