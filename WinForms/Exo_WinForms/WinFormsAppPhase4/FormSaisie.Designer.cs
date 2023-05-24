namespace WinFormsAppPhase4
{
	partial class FormSaisie
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
			this.label1 = new System.Windows.Forms.Label();
			this.textBoxSaisie = new System.Windows.Forms.TextBox();
			this.buttonValider = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(95, 15);
			this.label1.TabIndex = 0;
			this.label1.Text = "Tapez votre texte";
			// 
			// textBoxSaisie
			// 
			this.textBoxSaisie.Location = new System.Drawing.Point(12, 27);
			this.textBoxSaisie.Name = "textBoxSaisie";
			this.textBoxSaisie.Size = new System.Drawing.Size(285, 23);
			this.textBoxSaisie.TabIndex = 1;
			// 
			// buttonValider
			// 
			this.buttonValider.Location = new System.Drawing.Point(303, 26);
			this.buttonValider.Name = "buttonValider";
			this.buttonValider.Size = new System.Drawing.Size(75, 23);
			this.buttonValider.TabIndex = 2;
			this.buttonValider.Text = "Valider";
			this.buttonValider.UseVisualStyleBackColor = true;
			this.buttonValider.Click += new System.EventHandler(this.buttonValider_Click);
			// 
			// FormSaisie
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(389, 67);
			this.Controls.Add(this.buttonValider);
			this.Controls.Add(this.textBoxSaisie);
			this.Controls.Add(this.label1);
			this.Name = "FormSaisie";
			this.Text = "Saisie";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Label label1;
		private TextBox textBoxSaisie;
		private Button buttonValider;
	}
}