namespace WinFormsControlLibraryToutEmbal
{
	partial class UserControlProgression
	{
		/// <summary> 
		/// Variable nécessaire au concepteur.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Nettoyage des ressources utilisées.
		/// </summary>
		/// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Code généré par le Concepteur de composants

		/// <summary> 
		/// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
		/// le contenu de cette méthode avec l'éditeur de code.
		/// </summary>
		private void InitializeComponent()
		{
			this.progressBarProdProgression = new System.Windows.Forms.ProgressBar();
			this.labelNomProd = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// progressBarProdProgression
			// 
			this.progressBarProdProgression.Dock = System.Windows.Forms.DockStyle.Right;
			this.progressBarProdProgression.Location = new System.Drawing.Point(75, 0);
			this.progressBarProdProgression.Name = "progressBarProdProgression";
			this.progressBarProdProgression.Size = new System.Drawing.Size(665, 30);
			this.progressBarProdProgression.TabIndex = 0;
			// 
			// labelNomProd
			// 
			this.labelNomProd.AutoSize = true;
			this.labelNomProd.Dock = System.Windows.Forms.DockStyle.Left;
			this.labelNomProd.Location = new System.Drawing.Point(0, 0);
			this.labelNomProd.Name = "labelNomProd";
			this.labelNomProd.Size = new System.Drawing.Size(69, 15);
			this.labelNomProd.TabIndex = 1;
			this.labelNomProd.Text = "Production ";
			// 
			// UserControlProgression
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.labelNomProd);
			this.Controls.Add(this.progressBarProdProgression);
			this.Name = "UserControlProgression";
			this.Size = new System.Drawing.Size(740, 30);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private ProgressBar progressBarProdProgression;
		private Label labelNomProd;
	}
}
