namespace partBproject
{
    partial class CRUDEmployee
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
            this.addEmployee = new System.Windows.Forms.Button();
            this.updateEmployee = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addEmployee
            // 
            this.addEmployee.BackColor = System.Drawing.Color.Peru;
            this.addEmployee.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEmployee.Location = new System.Drawing.Point(337, 100);
            this.addEmployee.Name = "addEmployee";
            this.addEmployee.Size = new System.Drawing.Size(192, 86);
            this.addEmployee.TabIndex = 0;
            this.addEmployee.Text = "הוסף עובד חדש";
            this.addEmployee.UseVisualStyleBackColor = false;
            this.addEmployee.Click += new System.EventHandler(this.button1_Click);
            // 
            // updateEmployee
            // 
            this.updateEmployee.BackColor = System.Drawing.Color.Peru;
            this.updateEmployee.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateEmployee.Location = new System.Drawing.Point(62, 100);
            this.updateEmployee.Name = "updateEmployee";
            this.updateEmployee.Size = new System.Drawing.Size(192, 86);
            this.updateEmployee.TabIndex = 1;
            this.updateEmployee.Text = "עדכן עובד קיים";
            this.updateEmployee.UseVisualStyleBackColor = false;
            this.updateEmployee.Click += new System.EventHandler(this.updateEmployee_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::partBproject.Properties.Resources.Picture11;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(12, 367);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 45);
            this.button1.TabIndex = 2;
            this.button1.Text = "חזור";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(220, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 38);
            this.label1.TabIndex = 6;
            this.label1.Text = "ניהול עובדים";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // CRUDEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::partBproject.Properties.Resources.Picture10;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(597, 424);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.updateEmployee);
            this.Controls.Add(this.addEmployee);
            this.DoubleBuffered = true;
            this.Name = "CRUDEmployee";
            this.Text = "CRUDEmployee";
            this.Load += new System.EventHandler(this.CRUDEmployee_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addEmployee;
        private System.Windows.Forms.Button updateEmployee;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}