namespace partBproject
{
    partial class EnterMeetingTimes
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
            this.chooseWorkerHeadLine = new System.Windows.Forms.Label();
            this.EMChooseDateHeadLine = new System.Windows.Forms.Label();
            this.EMCcjooseHourHeadLine = new System.Windows.Forms.Label();
            this.dateMeet = new System.Windows.Forms.DateTimePicker();
            this.EMschedule = new System.Windows.Forms.Button();
            this.EMCCancel = new System.Windows.Forms.Button();
            this.TimeMeet = new System.Windows.Forms.DateTimePicker();
            this.comboBoxWorker = new System.Windows.Forms.ComboBox();
            this.DateError = new System.Windows.Forms.ErrorProvider(this.components);
            this.TimeError = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorWorker = new System.Windows.Forms.ErrorProvider(this.components);
            this.dataGridMeetings = new System.Windows.Forms.DataGridView();
            this.showMeetings = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DateError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorWorker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMeetings)).BeginInit();
            this.SuspendLayout();
            // 
            // chooseWorkerHeadLine
            // 
            this.chooseWorkerHeadLine.AutoSize = true;
            this.chooseWorkerHeadLine.BackColor = System.Drawing.Color.Transparent;
            this.chooseWorkerHeadLine.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chooseWorkerHeadLine.ForeColor = System.Drawing.Color.White;
            this.chooseWorkerHeadLine.Location = new System.Drawing.Point(711, 142);
            this.chooseWorkerHeadLine.Name = "chooseWorkerHeadLine";
            this.chooseWorkerHeadLine.Size = new System.Drawing.Size(78, 22);
            this.chooseWorkerHeadLine.TabIndex = 3;
            this.chooseWorkerHeadLine.Text = "בחר עובד";
            this.chooseWorkerHeadLine.Click += new System.EventHandler(this.label1_Click);
            // 
            // EMChooseDateHeadLine
            // 
            this.EMChooseDateHeadLine.AutoSize = true;
            this.EMChooseDateHeadLine.BackColor = System.Drawing.Color.Transparent;
            this.EMChooseDateHeadLine.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EMChooseDateHeadLine.ForeColor = System.Drawing.Color.White;
            this.EMChooseDateHeadLine.Location = new System.Drawing.Point(698, 299);
            this.EMChooseDateHeadLine.Name = "EMChooseDateHeadLine";
            this.EMChooseDateHeadLine.Size = new System.Drawing.Size(91, 22);
            this.EMChooseDateHeadLine.TabIndex = 4;
            this.EMChooseDateHeadLine.Text = "בחר תאריך";
            // 
            // EMCcjooseHourHeadLine
            // 
            this.EMCcjooseHourHeadLine.AutoSize = true;
            this.EMCcjooseHourHeadLine.BackColor = System.Drawing.Color.Transparent;
            this.EMCcjooseHourHeadLine.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EMCcjooseHourHeadLine.ForeColor = System.Drawing.Color.White;
            this.EMCcjooseHourHeadLine.Location = new System.Drawing.Point(711, 356);
            this.EMCcjooseHourHeadLine.Name = "EMCcjooseHourHeadLine";
            this.EMCcjooseHourHeadLine.Size = new System.Drawing.Size(78, 22);
            this.EMCcjooseHourHeadLine.TabIndex = 5;
            this.EMCcjooseHourHeadLine.Text = "בחר שעה";
            // 
            // dateMeet
            // 
            this.dateMeet.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateMeet.Location = new System.Drawing.Point(468, 305);
            this.dateMeet.Name = "dateMeet";
            this.dateMeet.Size = new System.Drawing.Size(196, 23);
            this.dateMeet.TabIndex = 6;
            this.dateMeet.ValueChanged += new System.EventHandler(this.dateMeet_ValueChanged);
            // 
            // EMschedule
            // 
            this.EMschedule.BackColor = System.Drawing.Color.Peru;
            this.EMschedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EMschedule.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EMschedule.Location = new System.Drawing.Point(630, 489);
            this.EMschedule.Name = "EMschedule";
            this.EMschedule.Size = new System.Drawing.Size(159, 42);
            this.EMschedule.TabIndex = 7;
            this.EMschedule.Text = "הזן פגישה";
            this.EMschedule.UseVisualStyleBackColor = false;
            this.EMschedule.Click += new System.EventHandler(this.EMschedule_Click);
            // 
            // EMCCancel
            // 
            this.EMCCancel.BackgroundImage = global::partBproject.Properties.Resources.Picture11;
            this.EMCCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.EMCCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EMCCancel.Location = new System.Drawing.Point(12, 534);
            this.EMCCancel.Name = "EMCCancel";
            this.EMCCancel.Size = new System.Drawing.Size(48, 41);
            this.EMCCancel.TabIndex = 8;
            this.EMCCancel.UseVisualStyleBackColor = true;
            this.EMCCancel.Click += new System.EventHandler(this.EMCCancel_Click);
            // 
            // TimeMeet
            // 
            this.TimeMeet.CustomFormat = "HH:mm";
            this.TimeMeet.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeMeet.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.TimeMeet.Location = new System.Drawing.Point(543, 356);
            this.TimeMeet.Name = "TimeMeet";
            this.TimeMeet.ShowUpDown = true;
            this.TimeMeet.Size = new System.Drawing.Size(121, 23);
            this.TimeMeet.TabIndex = 9;
            this.TimeMeet.ValueChanged += new System.EventHandler(this.TimeMeet_ValueChanged);
            // 
            // comboBoxWorker
            // 
            this.comboBoxWorker.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxWorker.FormattingEnabled = true;
            this.comboBoxWorker.Location = new System.Drawing.Point(477, 142);
            this.comboBoxWorker.Name = "comboBoxWorker";
            this.comboBoxWorker.Size = new System.Drawing.Size(187, 25);
            this.comboBoxWorker.TabIndex = 10;
            this.comboBoxWorker.SelectedIndexChanged += new System.EventHandler(this.comboBoxWorker_SelectedIndexChanged);
            // 
            // DateError
            // 
            this.DateError.ContainerControl = this;
            // 
            // TimeError
            // 
            this.TimeError.ContainerControl = this;
            // 
            // errorWorker
            // 
            this.errorWorker.ContainerControl = this;
            // 
            // dataGridMeetings
            // 
            this.dataGridMeetings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMeetings.Location = new System.Drawing.Point(66, 121);
            this.dataGridMeetings.Name = "dataGridMeetings";
            this.dataGridMeetings.Size = new System.Drawing.Size(294, 172);
            this.dataGridMeetings.TabIndex = 12;
            // 
            // showMeetings
            // 
            this.showMeetings.BackColor = System.Drawing.Color.Peru;
            this.showMeetings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showMeetings.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showMeetings.Location = new System.Drawing.Point(407, 131);
            this.showMeetings.Name = "showMeetings";
            this.showMeetings.Size = new System.Drawing.Size(64, 46);
            this.showMeetings.TabIndex = 13;
            this.showMeetings.Text = "הצג פגישות";
            this.showMeetings.UseVisualStyleBackColor = false;
            this.showMeetings.Click += new System.EventHandler(this.showMeetings_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(607, 35);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(216, 38);
            this.label11.TabIndex = 44;
            this.label11.Text = "הזנת מועדי פגישות";
            // 
            // EnterMeetingTimes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::partBproject.Properties.Resources.Picture10;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(895, 587);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.showMeetings);
            this.Controls.Add(this.dataGridMeetings);
            this.Controls.Add(this.comboBoxWorker);
            this.Controls.Add(this.TimeMeet);
            this.Controls.Add(this.EMCCancel);
            this.Controls.Add(this.EMschedule);
            this.Controls.Add(this.dateMeet);
            this.Controls.Add(this.EMCcjooseHourHeadLine);
            this.Controls.Add(this.EMChooseDateHeadLine);
            this.Controls.Add(this.chooseWorkerHeadLine);
            this.DoubleBuffered = true;
            this.Name = "EnterMeetingTimes";
            this.Text = "EnterMeetingTimes";
            this.Load += new System.EventHandler(this.EnterMeetingTimes_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.DateError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorWorker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMeetings)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label chooseWorkerHeadLine;
        private System.Windows.Forms.Label EMChooseDateHeadLine;
        private System.Windows.Forms.Label EMCcjooseHourHeadLine;
        private System.Windows.Forms.DateTimePicker dateMeet;
        private System.Windows.Forms.Button EMschedule;
        private System.Windows.Forms.Button EMCCancel;
        private System.Windows.Forms.DateTimePicker TimeMeet;
        private System.Windows.Forms.ComboBox comboBoxWorker;
        private System.Windows.Forms.ErrorProvider DateError;
        private System.Windows.Forms.ErrorProvider TimeError;
        private System.Windows.Forms.ErrorProvider errorWorker;
        private System.Windows.Forms.Button showMeetings;
        private System.Windows.Forms.DataGridView dataGridMeetings;
        private System.Windows.Forms.Label label11;
    }
}