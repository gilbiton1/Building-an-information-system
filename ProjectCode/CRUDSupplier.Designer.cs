namespace partBproject
{
    partial class CRUDSupplier
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
            this.addSupplier = new System.Windows.Forms.Button();
            this.searchSupplier = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addSupplier
            // 
            this.addSupplier.BackColor = System.Drawing.Color.Peru;
            this.addSupplier.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addSupplier.Location = new System.Drawing.Point(333, 110);
            this.addSupplier.Name = "addSupplier";
            this.addSupplier.Size = new System.Drawing.Size(185, 82);
            this.addSupplier.TabIndex = 0;
            this.addSupplier.Text = "הוסף ספק";
            this.addSupplier.UseVisualStyleBackColor = false;
            this.addSupplier.Click += new System.EventHandler(this.addSupplier_Click);
            // 
            // searchSupplier
            // 
            this.searchSupplier.BackColor = System.Drawing.Color.Peru;
            this.searchSupplier.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchSupplier.Location = new System.Drawing.Point(55, 110);
            this.searchSupplier.Name = "searchSupplier";
            this.searchSupplier.Size = new System.Drawing.Size(190, 82);
            this.searchSupplier.TabIndex = 1;
            this.searchSupplier.Text = "עדכן ספק";
            this.searchSupplier.UseVisualStyleBackColor = false;
            this.searchSupplier.Click += new System.EventHandler(this.searchSupplier_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::partBproject.Properties.Resources.Picture11;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(12, 365);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(51, 43);
            this.button1.TabIndex = 2;
            this.button1.Text = "חזור";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(218, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 38);
            this.label1.TabIndex = 7;
            this.label1.Text = "ניהול ספקים";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // CRUDSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::partBproject.Properties.Resources.Picture10;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(584, 420);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.searchSupplier);
            this.Controls.Add(this.addSupplier);
            this.DoubleBuffered = true;
            this.Name = "CRUDSupplier";
            this.Text = "CRUDSupplier";
            this.Load += new System.EventHandler(this.CRUDSupplier_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addSupplier;
        private System.Windows.Forms.Button searchSupplier;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}