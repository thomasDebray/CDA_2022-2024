namespace WinFormsAppCities
{
	partial class FormUnCity
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
			this.labelNomCity = new System.Windows.Forms.Label();
			this.textBoxNomCity = new System.Windows.Forms.TextBox();
			this.labelCountryCode = new System.Windows.Forms.Label();
			this.comboBoxCountryCode = new System.Windows.Forms.ComboBox();
			this.buttonValider = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// labelNomCity
			// 
			this.labelNomCity.AutoSize = true;
			this.labelNomCity.Location = new System.Drawing.Point(12, 9);
			this.labelNomCity.Name = "labelNomCity";
			this.labelNomCity.Size = new System.Drawing.Size(84, 15);
			this.labelNomCity.TabIndex = 0;
			this.labelNomCity.Text = "Nom de la city";
			// 
			// textBoxNomCity
			// 
			this.textBoxNomCity.Location = new System.Drawing.Point(102, 6);
			this.textBoxNomCity.Name = "textBoxNomCity";
			this.textBoxNomCity.Size = new System.Drawing.Size(121, 23);
			this.textBoxNomCity.TabIndex = 1;
			// 
			// labelCountryCode
			// 
			this.labelCountryCode.AutoSize = true;
			this.labelCountryCode.Location = new System.Drawing.Point(12, 45);
			this.labelCountryCode.Name = "labelCountryCode";
			this.labelCountryCode.Size = new System.Drawing.Size(81, 15);
			this.labelCountryCode.TabIndex = 2;
			this.labelCountryCode.Text = "Country Code";
			// 
			// comboBoxCountryCode
			// 
			this.comboBoxCountryCode.FormattingEnabled = true;
			this.comboBoxCountryCode.Location = new System.Drawing.Point(102, 42);
			this.comboBoxCountryCode.Name = "comboBoxCountryCode";
			this.comboBoxCountryCode.Size = new System.Drawing.Size(121, 23);
			this.comboBoxCountryCode.TabIndex = 3;
			// 
			// buttonValider
			// 
			this.buttonValider.Location = new System.Drawing.Point(148, 71);
			this.buttonValider.Name = "buttonValider";
			this.buttonValider.Size = new System.Drawing.Size(75, 23);
			this.buttonValider.TabIndex = 4;
			this.buttonValider.Text = "Valider";
			this.buttonValider.UseVisualStyleBackColor = true;
			this.buttonValider.Click += new System.EventHandler(this.buttonValider_Click);
			// 
			// FormUnCity
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(229, 100);
			this.Controls.Add(this.buttonValider);
			this.Controls.Add(this.comboBoxCountryCode);
			this.Controls.Add(this.labelCountryCode);
			this.Controls.Add(this.textBoxNomCity);
			this.Controls.Add(this.labelNomCity);
			this.Name = "FormUnCity";
			this.Text = "FormUnCity";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Label labelNomCity;
		private TextBox textBoxNomCity;
		private Label labelCountryCode;
		private ComboBox comboBoxCountryCode;
		private Button buttonValider;
	}
}