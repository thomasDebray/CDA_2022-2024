namespace WinFormsAppCities
{
	partial class FormCity
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
			this.dataGridViewCities = new System.Windows.Forms.DataGridView();
			this.cityIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cityNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.countryCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.countryCodeNavigationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cityBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.buttonAjouterUnCitY = new System.Windows.Forms.Button();
			this.labelId = new System.Windows.Forms.Label();
			this.textBoxId = new System.Windows.Forms.TextBox();
			this.buttonSuprimerUnCity = new System.Windows.Forms.Button();
			this.buttonModifyUnCity = new System.Windows.Forms.Button();
			this.buttonSaveAll = new System.Windows.Forms.Button();
			this.cityBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewCities)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cityBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cityBindingSource1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridViewCities
			// 
			this.dataGridViewCities.AutoGenerateColumns = false;
			this.dataGridViewCities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewCities.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cityIdDataGridViewTextBoxColumn,
            this.cityNameDataGridViewTextBoxColumn,
            this.countryCodeDataGridViewTextBoxColumn,
            this.countryCodeNavigationDataGridViewTextBoxColumn});
			this.dataGridViewCities.DataSource = this.cityBindingSource;
			this.dataGridViewCities.Location = new System.Drawing.Point(12, 12);
			this.dataGridViewCities.Name = "dataGridViewCities";
			this.dataGridViewCities.RowTemplate.Height = 25;
			this.dataGridViewCities.Size = new System.Drawing.Size(399, 248);
			this.dataGridViewCities.TabIndex = 0;
			// 
			// cityIdDataGridViewTextBoxColumn
			// 
			this.cityIdDataGridViewTextBoxColumn.DataPropertyName = "CityId";
			this.cityIdDataGridViewTextBoxColumn.HeaderText = "CityId";
			this.cityIdDataGridViewTextBoxColumn.Name = "cityIdDataGridViewTextBoxColumn";
			// 
			// cityNameDataGridViewTextBoxColumn
			// 
			this.cityNameDataGridViewTextBoxColumn.DataPropertyName = "CityName";
			this.cityNameDataGridViewTextBoxColumn.HeaderText = "CityName";
			this.cityNameDataGridViewTextBoxColumn.Name = "cityNameDataGridViewTextBoxColumn";
			// 
			// countryCodeDataGridViewTextBoxColumn
			// 
			this.countryCodeDataGridViewTextBoxColumn.DataPropertyName = "CountryCode";
			this.countryCodeDataGridViewTextBoxColumn.HeaderText = "CountryCode";
			this.countryCodeDataGridViewTextBoxColumn.Name = "countryCodeDataGridViewTextBoxColumn";
			// 
			// countryCodeNavigationDataGridViewTextBoxColumn
			// 
			this.countryCodeNavigationDataGridViewTextBoxColumn.DataPropertyName = "CountryCodeNavigation";
			this.countryCodeNavigationDataGridViewTextBoxColumn.HeaderText = "CountryCodeNavigation";
			this.countryCodeNavigationDataGridViewTextBoxColumn.Name = "countryCodeNavigationDataGridViewTextBoxColumn";
			this.countryCodeNavigationDataGridViewTextBoxColumn.Visible = false;
			// 
			// cityBindingSource
			// 
			this.cityBindingSource.DataSource = typeof(WinFormsAppCities.Models.City);
			// 
			// buttonAjouterUnCitY
			// 
			this.buttonAjouterUnCitY.Location = new System.Drawing.Point(587, 12);
			this.buttonAjouterUnCitY.Name = "buttonAjouterUnCitY";
			this.buttonAjouterUnCitY.Size = new System.Drawing.Size(75, 23);
			this.buttonAjouterUnCitY.TabIndex = 1;
			this.buttonAjouterUnCitY.Text = "Ajouter";
			this.buttonAjouterUnCitY.UseVisualStyleBackColor = true;
			this.buttonAjouterUnCitY.Click += new System.EventHandler(this.buttonAjouterUnCitY_Click);
			// 
			// labelId
			// 
			this.labelId.AutoSize = true;
			this.labelId.Location = new System.Drawing.Point(446, 59);
			this.labelId.Name = "labelId";
			this.labelId.Size = new System.Drawing.Size(18, 15);
			this.labelId.TabIndex = 2;
			this.labelId.Text = "ID";
			// 
			// textBoxId
			// 
			this.textBoxId.Location = new System.Drawing.Point(470, 56);
			this.textBoxId.Name = "textBoxId";
			this.textBoxId.Size = new System.Drawing.Size(30, 23);
			this.textBoxId.TabIndex = 3;
			// 
			// buttonSuprimerUnCity
			// 
			this.buttonSuprimerUnCity.Location = new System.Drawing.Point(587, 56);
			this.buttonSuprimerUnCity.Name = "buttonSuprimerUnCity";
			this.buttonSuprimerUnCity.Size = new System.Drawing.Size(75, 23);
			this.buttonSuprimerUnCity.TabIndex = 4;
			this.buttonSuprimerUnCity.Text = "Supprimer";
			this.buttonSuprimerUnCity.UseVisualStyleBackColor = true;
			this.buttonSuprimerUnCity.Click += new System.EventHandler(this.buttonSuprimerUnCity_Click);
			// 
			// buttonModifyUnCity
			// 
			this.buttonModifyUnCity.Location = new System.Drawing.Point(506, 56);
			this.buttonModifyUnCity.Name = "buttonModifyUnCity";
			this.buttonModifyUnCity.Size = new System.Drawing.Size(75, 23);
			this.buttonModifyUnCity.TabIndex = 6;
			this.buttonModifyUnCity.Text = "Modifier";
			this.buttonModifyUnCity.UseVisualStyleBackColor = true;
			this.buttonModifyUnCity.Click += new System.EventHandler(this.buttonModifyUnCity_Click);
			// 
			// buttonSaveAll
			// 
			this.buttonSaveAll.Location = new System.Drawing.Point(587, 237);
			this.buttonSaveAll.Name = "buttonSaveAll";
			this.buttonSaveAll.Size = new System.Drawing.Size(127, 23);
			this.buttonSaveAll.TabIndex = 7;
			this.buttonSaveAll.Text = "Sauvegarder";
			this.buttonSaveAll.UseVisualStyleBackColor = true;
			this.buttonSaveAll.Click += new System.EventHandler(this.buttonSaveAll_Click);
			// 
			// cityBindingSource1
			// 
			this.cityBindingSource1.DataSource = typeof(WinFormsAppCities.Models.City);
			// 
			// FormCity
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(726, 272);
			this.Controls.Add(this.buttonSaveAll);
			this.Controls.Add(this.buttonModifyUnCity);
			this.Controls.Add(this.buttonSuprimerUnCity);
			this.Controls.Add(this.textBoxId);
			this.Controls.Add(this.labelId);
			this.Controls.Add(this.buttonAjouterUnCitY);
			this.Controls.Add(this.dataGridViewCities);
			this.Name = "FormCity";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FormCity";
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewCities)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cityBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cityBindingSource1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DataGridView dataGridViewCities;
		private Button buttonAjouterUnCitY;
		private Label labelId;
		private TextBox textBoxId;
		private Button buttonSuprimerUnCity;
		private Button buttonModifyUnCity;
		private Button buttonSaveAll;
		private BindingSource cityBindingSource;
		private DataGridViewTextBoxColumn cityIdDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn cityNameDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn countryCodeDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn countryCodeNavigationDataGridViewTextBoxColumn;
		private BindingSource cityBindingSource1;
	}
}