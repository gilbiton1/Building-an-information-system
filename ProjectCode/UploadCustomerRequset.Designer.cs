namespace partBproject
{
	partial class UploadCustomerRequset
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
            this.UCChooseAppartmentNumberHeadLine = new System.Windows.Forms.Label();
            this.UCChooseSupplierHeadLine = new System.Windows.Forms.Label();
            this.UCContentHeadLine = new System.Windows.Forms.Label();
            this.UCApprove = new System.Windows.Forms.Button();
            this.UCCancel = new System.Windows.Forms.Button();
            this.UCChooseProjectHeadLine = new System.Windows.Forms.Label();
            this.UCChooseProject = new System.Windows.Forms.ComboBox();
            this.UCRChooseApartment = new System.Windows.Forms.ComboBox();
            this.UCChooseSupplier = new System.Windows.Forms.ComboBox();
            this.sUPPLIERSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sUPPLIERSTableAdapter = new partBproject.SAD_2DataSetTableAdapters.SUPPLIERSTableAdapter();
            this.UCRrichText = new System.Windows.Forms.RichTextBox();
            this.projectError = new System.Windows.Forms.ErrorProvider(this.components);
            this.apartmentError = new System.Windows.Forms.ErrorProvider(this.components);
            this.supplierError = new System.Windows.Forms.ErrorProvider(this.components);
            this.contentError = new System.Windows.Forms.ErrorProvider(this.components);
            this.showDomain = new System.Windows.Forms.Label();
            this.SupplierDomain = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.sAD_2DataSet = new partBproject.SAD_2DataSet();
            this.search = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sUPPLIERSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apartmentError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contentError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAD_2DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // UCChooseAppartmentNumberHeadLine
            // 
            this.UCChooseAppartmentNumberHeadLine.AutoSize = true;
            this.UCChooseAppartmentNumberHeadLine.BackColor = System.Drawing.Color.Transparent;
            this.UCChooseAppartmentNumberHeadLine.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UCChooseAppartmentNumberHeadLine.ForeColor = System.Drawing.Color.White;
            this.UCChooseAppartmentNumberHeadLine.Location = new System.Drawing.Point(799, 192);
            this.UCChooseAppartmentNumberHeadLine.Name = "UCChooseAppartmentNumberHeadLine";
            this.UCChooseAppartmentNumberHeadLine.Size = new System.Drawing.Size(78, 22);
            this.UCChooseAppartmentNumberHeadLine.TabIndex = 0;
            this.UCChooseAppartmentNumberHeadLine.Text = "בחר דירה";
            // 
            // UCChooseSupplierHeadLine
            // 
            this.UCChooseSupplierHeadLine.AutoSize = true;
            this.UCChooseSupplierHeadLine.BackColor = System.Drawing.Color.Transparent;
            this.UCChooseSupplierHeadLine.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UCChooseSupplierHeadLine.ForeColor = System.Drawing.Color.White;
            this.UCChooseSupplierHeadLine.Location = new System.Drawing.Point(369, 135);
            this.UCChooseSupplierHeadLine.Name = "UCChooseSupplierHeadLine";
            this.UCChooseSupplierHeadLine.Size = new System.Drawing.Size(78, 22);
            this.UCChooseSupplierHeadLine.TabIndex = 1;
            this.UCChooseSupplierHeadLine.Text = "בחר ספק";
            // 
            // UCContentHeadLine
            // 
            this.UCContentHeadLine.AutoSize = true;
            this.UCContentHeadLine.BackColor = System.Drawing.Color.Transparent;
            this.UCContentHeadLine.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UCContentHeadLine.ForeColor = System.Drawing.Color.White;
            this.UCContentHeadLine.Location = new System.Drawing.Point(836, 258);
            this.UCContentHeadLine.Name = "UCContentHeadLine";
            this.UCContentHeadLine.Size = new System.Drawing.Size(41, 22);
            this.UCContentHeadLine.TabIndex = 2;
            this.UCContentHeadLine.Text = "תוכן";
            this.UCContentHeadLine.Click += new System.EventHandler(this.UCContentHeadLine_Click);
            // 
            // UCApprove
            // 
            this.UCApprove.BackColor = System.Drawing.Color.Peru;
            this.UCApprove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UCApprove.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UCApprove.Location = new System.Drawing.Point(663, 429);
            this.UCApprove.Name = "UCApprove";
            this.UCApprove.Size = new System.Drawing.Size(214, 49);
            this.UCApprove.TabIndex = 3;
            this.UCApprove.Text = "העלאת דרישה";
            this.UCApprove.UseVisualStyleBackColor = false;
            this.UCApprove.Click += new System.EventHandler(this.UCApprove_Click);
            // 
            // UCCancel
            // 
            this.UCCancel.BackgroundImage = global::partBproject.Properties.Resources.Picture11;
            this.UCCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.UCCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UCCancel.Location = new System.Drawing.Point(12, 475);
            this.UCCancel.Name = "UCCancel";
            this.UCCancel.Size = new System.Drawing.Size(58, 49);
            this.UCCancel.TabIndex = 4;
            this.UCCancel.UseVisualStyleBackColor = true;
            this.UCCancel.Click += new System.EventHandler(this.UCCancel_Click);
            // 
            // UCChooseProjectHeadLine
            // 
            this.UCChooseProjectHeadLine.AutoSize = true;
            this.UCChooseProjectHeadLine.BackColor = System.Drawing.Color.Transparent;
            this.UCChooseProjectHeadLine.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UCChooseProjectHeadLine.ForeColor = System.Drawing.Color.White;
            this.UCChooseProjectHeadLine.Location = new System.Drawing.Point(776, 136);
            this.UCChooseProjectHeadLine.Name = "UCChooseProjectHeadLine";
            this.UCChooseProjectHeadLine.Size = new System.Drawing.Size(101, 22);
            this.UCChooseProjectHeadLine.TabIndex = 5;
            this.UCChooseProjectHeadLine.Text = "בחר פרוייקט";
            // 
            // UCChooseProject
            // 
            this.UCChooseProject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UCChooseProject.FormattingEnabled = true;
            this.UCChooseProject.Location = new System.Drawing.Point(592, 136);
            this.UCChooseProject.Name = "UCChooseProject";
            this.UCChooseProject.Size = new System.Drawing.Size(156, 21);
            this.UCChooseProject.TabIndex = 6;
            this.UCChooseProject.TabStop = false;
            this.UCChooseProject.SelectedIndexChanged += new System.EventHandler(this.UploadCustomerRequset_Load);
            // 
            // UCRChooseApartment
            // 
            this.UCRChooseApartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UCRChooseApartment.FormattingEnabled = true;
            this.UCRChooseApartment.Location = new System.Drawing.Point(588, 195);
            this.UCRChooseApartment.Name = "UCRChooseApartment";
            this.UCRChooseApartment.Size = new System.Drawing.Size(160, 21);
            this.UCRChooseApartment.TabIndex = 7;
            this.UCRChooseApartment.SelectedIndexChanged += new System.EventHandler(this.UCRChooseApartment_SelectedIndexChanged_1);
            // 
            // UCChooseSupplier
            // 
            this.UCChooseSupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UCChooseSupplier.FormattingEnabled = true;
            this.UCChooseSupplier.Location = new System.Drawing.Point(157, 136);
            this.UCChooseSupplier.Name = "UCChooseSupplier";
            this.UCChooseSupplier.Size = new System.Drawing.Size(161, 21);
            this.UCChooseSupplier.TabIndex = 8;
            this.UCChooseSupplier.SelectedIndexChanged += new System.EventHandler(this.UCChooseSupplier_SelectedIndexChanged);
            // 
            // sUPPLIERSTableAdapter
            // 
            this.sUPPLIERSTableAdapter.ClearBeforeFill = true;
            // 
            // UCRrichText
            // 
            this.UCRrichText.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UCRrichText.Location = new System.Drawing.Point(270, 258);
            this.UCRrichText.Name = "UCRrichText";
            this.UCRrichText.Size = new System.Drawing.Size(478, 135);
            this.UCRrichText.TabIndex = 9;
            this.UCRrichText.Text = "ניתן להקליד עד 300 תווים";
            this.UCRrichText.TextChanged += new System.EventHandler(this.UCRrichText_TextChanged);
            // 
            // projectError
            // 
            this.projectError.ContainerControl = this;
            // 
            // apartmentError
            // 
            this.apartmentError.ContainerControl = this;
            // 
            // supplierError
            // 
            this.supplierError.ContainerControl = this;
            // 
            // contentError
            // 
            this.contentError.ContainerControl = this;
            // 
            // showDomain
            // 
            this.showDomain.AutoSize = true;
            this.showDomain.BackColor = System.Drawing.Color.Black;
            this.showDomain.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showDomain.ForeColor = System.Drawing.Color.White;
            this.showDomain.Location = new System.Drawing.Point(259, 192);
            this.showDomain.Name = "showDomain";
            this.showDomain.Size = new System.Drawing.Size(59, 22);
            this.showDomain.TabIndex = 10;
            this.showDomain.Text = "label1";
            this.showDomain.Visible = false;
            this.showDomain.Click += new System.EventHandler(this.showDomain_Click);
            // 
            // SupplierDomain
            // 
            this.SupplierDomain.AutoSize = true;
            this.SupplierDomain.BackColor = System.Drawing.Color.Transparent;
            this.SupplierDomain.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SupplierDomain.ForeColor = System.Drawing.Color.White;
            this.SupplierDomain.Location = new System.Drawing.Point(351, 192);
            this.SupplierDomain.Name = "SupplierDomain";
            this.SupplierDomain.Size = new System.Drawing.Size(96, 22);
            this.SupplierDomain.TabIndex = 11;
            this.SupplierDomain.Text = "תחום עיסוק";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(663, 45);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(237, 38);
            this.label11.TabIndex = 45;
            this.label11.Text = "העלאת דרישה לשינוי";
            // 
            // sAD_2DataSet
            // 
            this.sAD_2DataSet.DataSetName = "SAD_2DataSet";
            this.sAD_2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(489, 135);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(80, 21);
            this.search.TabIndex = 46;
            this.search.Text = "חפש דירות";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // UploadCustomerRequset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::partBproject.Properties.Resources.Picture10;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(970, 536);
            this.Controls.Add(this.search);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.SupplierDomain);
            this.Controls.Add(this.showDomain);
            this.Controls.Add(this.UCRrichText);
            this.Controls.Add(this.UCChooseSupplier);
            this.Controls.Add(this.UCRChooseApartment);
            this.Controls.Add(this.UCChooseProject);
            this.Controls.Add(this.UCChooseProjectHeadLine);
            this.Controls.Add(this.UCCancel);
            this.Controls.Add(this.UCApprove);
            this.Controls.Add(this.UCContentHeadLine);
            this.Controls.Add(this.UCChooseSupplierHeadLine);
            this.Controls.Add(this.UCChooseAppartmentNumberHeadLine);
            this.DoubleBuffered = true;
            this.Name = "UploadCustomerRequset";
            this.Text = "UploadCustomerRequset";
            this.Load += new System.EventHandler(this.UploadCustomerRequset_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sUPPLIERSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apartmentError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contentError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAD_2DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label UCChooseAppartmentNumberHeadLine;
		private System.Windows.Forms.Label UCChooseSupplierHeadLine;
		private System.Windows.Forms.Label UCContentHeadLine;
		private System.Windows.Forms.Button UCApprove;
		private System.Windows.Forms.Button UCCancel;
		private System.Windows.Forms.Label UCChooseProjectHeadLine;
		private System.Windows.Forms.ComboBox UCChooseProject;
		private System.Windows.Forms.ComboBox UCRChooseApartment;
		private System.Windows.Forms.ComboBox UCChooseSupplier;
        private System.Windows.Forms.BindingSource sUPPLIERSBindingSource;
        private SAD_2DataSetTableAdapters.SUPPLIERSTableAdapter sUPPLIERSTableAdapter;
        private System.Windows.Forms.RichTextBox UCRrichText;
        private System.Windows.Forms.ErrorProvider projectError;
        private System.Windows.Forms.ErrorProvider apartmentError;
        private System.Windows.Forms.ErrorProvider supplierError;
        private System.Windows.Forms.ErrorProvider contentError;
        private System.Windows.Forms.Label SupplierDomain;
        private System.Windows.Forms.Label showDomain;
        private System.Windows.Forms.Label label11;
        private SAD_2DataSet sAD_2DataSet;
        private System.Windows.Forms.Button search;
    }
}