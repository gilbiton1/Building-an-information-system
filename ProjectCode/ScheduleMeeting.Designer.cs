namespace partBproject
{
    partial class ScheduleMeeting
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
            this.SMChooseWorkerHeadLine = new System.Windows.Forms.Label();
            this.SMChooseHourHeadLine = new System.Windows.Forms.Label();
            this.SMChooseDateHeadLine = new System.Windows.Forms.Label();
            this.SMChooseHour = new System.Windows.Forms.ComboBox();
            this.SMChooseWorker = new System.Windows.Forms.ComboBox();
            this.SCScheduled = new System.Windows.Forms.Button();
            this.SMCancel = new System.Windows.Forms.Button();
            this.chooseDate = new System.Windows.Forms.ComboBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.button1 = new System.Windows.Forms.Button();
            this.nullDate = new System.Windows.Forms.ErrorProvider(this.components);
            this.nullHour = new System.Windows.Forms.ErrorProvider(this.components);
            this.nullWorker = new System.Windows.Forms.ErrorProvider(this.components);
            this.employeeRole = new System.Windows.Forms.Label();
            this.showRole = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nullDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nullHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nullWorker)).BeginInit();
            this.SuspendLayout();
            // 
            // SMChooseWorkerHeadLine
            // 
            this.SMChooseWorkerHeadLine.AutoSize = true;
            this.SMChooseWorkerHeadLine.BackColor = System.Drawing.Color.Transparent;
            this.SMChooseWorkerHeadLine.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SMChooseWorkerHeadLine.ForeColor = System.Drawing.Color.White;
            this.SMChooseWorkerHeadLine.Location = new System.Drawing.Point(754, 134);
            this.SMChooseWorkerHeadLine.Name = "SMChooseWorkerHeadLine";
            this.SMChooseWorkerHeadLine.Size = new System.Drawing.Size(78, 22);
            this.SMChooseWorkerHeadLine.TabIndex = 0;
            this.SMChooseWorkerHeadLine.Text = "בחר עובד";
            // 
            // SMChooseHourHeadLine
            // 
            this.SMChooseHourHeadLine.AutoSize = true;
            this.SMChooseHourHeadLine.BackColor = System.Drawing.Color.Transparent;
            this.SMChooseHourHeadLine.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SMChooseHourHeadLine.ForeColor = System.Drawing.Color.White;
            this.SMChooseHourHeadLine.Location = new System.Drawing.Point(754, 352);
            this.SMChooseHourHeadLine.Name = "SMChooseHourHeadLine";
            this.SMChooseHourHeadLine.Size = new System.Drawing.Size(78, 22);
            this.SMChooseHourHeadLine.TabIndex = 1;
            this.SMChooseHourHeadLine.Text = "בחר שעה";
            // 
            // SMChooseDateHeadLine
            // 
            this.SMChooseDateHeadLine.AutoSize = true;
            this.SMChooseDateHeadLine.BackColor = System.Drawing.Color.Transparent;
            this.SMChooseDateHeadLine.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SMChooseDateHeadLine.ForeColor = System.Drawing.Color.White;
            this.SMChooseDateHeadLine.Location = new System.Drawing.Point(741, 256);
            this.SMChooseDateHeadLine.Name = "SMChooseDateHeadLine";
            this.SMChooseDateHeadLine.Size = new System.Drawing.Size(91, 22);
            this.SMChooseDateHeadLine.TabIndex = 3;
            this.SMChooseDateHeadLine.Text = "בחר תאריך";
            // 
            // SMChooseHour
            // 
            this.SMChooseHour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SMChooseHour.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SMChooseHour.FormattingEnabled = true;
            this.SMChooseHour.Location = new System.Drawing.Point(552, 353);
            this.SMChooseHour.Name = "SMChooseHour";
            this.SMChooseHour.Size = new System.Drawing.Size(131, 25);
            this.SMChooseHour.TabIndex = 4;
            this.SMChooseHour.SelectedIndexChanged += new System.EventHandler(this.SMChooseHour_SelectedIndexChanged);
            this.SMChooseHour.Click += new System.EventHandler(this.SMChooseHour_Click_2);
            // 
            // SMChooseWorker
            // 
            this.SMChooseWorker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SMChooseWorker.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SMChooseWorker.FormattingEnabled = true;
            this.SMChooseWorker.Location = new System.Drawing.Point(556, 135);
            this.SMChooseWorker.Name = "SMChooseWorker";
            this.SMChooseWorker.Size = new System.Drawing.Size(127, 25);
            this.SMChooseWorker.TabIndex = 5;
            this.SMChooseWorker.SelectedIndexChanged += new System.EventHandler(this.SMChooseWorker_SelectedIndexChanged);
            // 
            // SCScheduled
            // 
            this.SCScheduled.BackColor = System.Drawing.Color.Peru;
            this.SCScheduled.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SCScheduled.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SCScheduled.Location = new System.Drawing.Point(607, 430);
            this.SCScheduled.Name = "SCScheduled";
            this.SCScheduled.Size = new System.Drawing.Size(225, 46);
            this.SCScheduled.TabIndex = 6;
            this.SCScheduled.Text = "קבע פגישה";
            this.SCScheduled.UseVisualStyleBackColor = false;
            this.SCScheduled.Click += new System.EventHandler(this.SCScheduled_Click);
            // 
            // SMCancel
            // 
            this.SMCancel.BackgroundImage = global::partBproject.Properties.Resources.Picture11;
            this.SMCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SMCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SMCancel.Location = new System.Drawing.Point(12, 460);
            this.SMCancel.Name = "SMCancel";
            this.SMCancel.Size = new System.Drawing.Size(51, 44);
            this.SMCancel.TabIndex = 7;
            this.SMCancel.Text = "בטל";
            this.SMCancel.UseVisualStyleBackColor = true;
            this.SMCancel.Click += new System.EventHandler(this.SMCancel_Click);
            // 
            // chooseDate
            // 
            this.chooseDate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.chooseDate.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chooseDate.FormattingEnabled = true;
            this.chooseDate.Location = new System.Drawing.Point(556, 257);
            this.chooseDate.Name = "chooseDate";
            this.chooseDate.Size = new System.Drawing.Size(127, 25);
            this.chooseDate.TabIndex = 8;
            this.chooseDate.SelectedIndexChanged += new System.EventHandler(this.chooseDate_SelectedIndexChanged);
            this.chooseDate.Click += new System.EventHandler(this.chooseDate_Click_1);
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.Peru;
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(492, 132);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(49, 31);
            this.searchButton.TabIndex = 9;
            this.searchButton.Text = "חפש";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.BackColor = System.Drawing.Color.Black;
            this.monthCalendar1.Location = new System.Drawing.Point(239, 257);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 10;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Peru;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(492, 257);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(49, 31);
            this.button1.TabIndex = 11;
            this.button1.Text = "בחר";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // nullDate
            // 
            this.nullDate.ContainerControl = this;
            // 
            // nullHour
            // 
            this.nullHour.ContainerControl = this;
            // 
            // nullWorker
            // 
            this.nullWorker.ContainerControl = this;
            // 
            // employeeRole
            // 
            this.employeeRole.AutoSize = true;
            this.employeeRole.BackColor = System.Drawing.Color.Transparent;
            this.employeeRole.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeRole.ForeColor = System.Drawing.Color.White;
            this.employeeRole.Location = new System.Drawing.Point(725, 191);
            this.employeeRole.Name = "employeeRole";
            this.employeeRole.Size = new System.Drawing.Size(107, 22);
            this.employeeRole.TabIndex = 12;
            this.employeeRole.Text = "תפקיד העובד";
            this.employeeRole.Click += new System.EventHandler(this.employeeRole_Click);
            // 
            // showRole
            // 
            this.showRole.AutoSize = true;
            this.showRole.BackColor = System.Drawing.Color.Black;
            this.showRole.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showRole.ForeColor = System.Drawing.Color.White;
            this.showRole.Location = new System.Drawing.Point(552, 191);
            this.showRole.Name = "showRole";
            this.showRole.Size = new System.Drawing.Size(59, 22);
            this.showRole.TabIndex = 13;
            this.showRole.Text = "label1";
            this.showRole.Visible = false;
            this.showRole.Click += new System.EventHandler(this.showRole_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(670, 38);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(162, 38);
            this.label11.TabIndex = 45;
            this.label11.Text = "קביעת פגישה";
            // 
            // ScheduleMeeting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::partBproject.Properties.Resources.Picture10;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(917, 516);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.showRole);
            this.Controls.Add(this.employeeRole);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.chooseDate);
            this.Controls.Add(this.SMCancel);
            this.Controls.Add(this.SCScheduled);
            this.Controls.Add(this.SMChooseWorker);
            this.Controls.Add(this.SMChooseHour);
            this.Controls.Add(this.SMChooseDateHeadLine);
            this.Controls.Add(this.SMChooseHourHeadLine);
            this.Controls.Add(this.SMChooseWorkerHeadLine);
            this.DoubleBuffered = true;
            this.Name = "ScheduleMeeting";
            this.Text = "ScheduleMeeting";
            this.Load += new System.EventHandler(this.ScheduleMeeting_Load);
            this.Click += new System.EventHandler(this.ScheduleMeeting_Click);
            ((System.ComponentModel.ISupportInitialize)(this.nullDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nullHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nullWorker)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SMChooseWorkerHeadLine;
        private System.Windows.Forms.Label SMChooseHourHeadLine;
        private System.Windows.Forms.Label SMChooseDateHeadLine;
        private System.Windows.Forms.ComboBox SMChooseHour;
        private System.Windows.Forms.ComboBox SMChooseWorker;
        private System.Windows.Forms.Button SCScheduled;
        private System.Windows.Forms.Button SMCancel;
        private System.Windows.Forms.ComboBox chooseDate;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ErrorProvider nullDate;
        private System.Windows.Forms.ErrorProvider nullHour;
        private System.Windows.Forms.ErrorProvider nullWorker;
        private System.Windows.Forms.Label showRole;
        private System.Windows.Forms.Label employeeRole;
        private System.Windows.Forms.Label label11;
    }
}