namespace WinFormsControlLibraryToutEmbal
{
	partial class UserControlStats
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
			this.labelTauxDefautGlobal = new System.Windows.Forms.Label();
			this.textBoxTauxDefautGlobal = new System.Windows.Forms.TextBox();
			this.labelTauxDefautHeure = new System.Windows.Forms.Label();
			this.textBoxTauxDefautHeure = new System.Windows.Forms.TextBox();
			this.textBoxNbCaisse = new System.Windows.Forms.TextBox();
			this.labelNbCaisse = new System.Windows.Forms.Label();
			this.groupBoxProduction = new System.Windows.Forms.GroupBox();
			this.groupBoxProduction.SuspendLayout();
			this.SuspendLayout();
			// 
			// labelTauxDefautGlobal
			// 
			this.labelTauxDefautGlobal.AutoSize = true;
			this.labelTauxDefautGlobal.Location = new System.Drawing.Point(6, 77);
			this.labelTauxDefautGlobal.Name = "labelTauxDefautGlobal";
			this.labelTauxDefautGlobal.Size = new System.Drawing.Size(166, 15);
			this.labelTauxDefautGlobal.TabIndex = 16;
			this.labelTauxDefautGlobal.Text = "Taux défaut depuis démarrage";
			// 
			// textBoxTauxDefautGlobal
			// 
			this.textBoxTauxDefautGlobal.Location = new System.Drawing.Point(224, 74);
			this.textBoxTauxDefautGlobal.Name = "textBoxTauxDefautGlobal";
			this.textBoxTauxDefautGlobal.Size = new System.Drawing.Size(58, 23);
			this.textBoxTauxDefautGlobal.TabIndex = 15;
			// 
			// labelTauxDefautHeure
			// 
			this.labelTauxDefautHeure.AutoSize = true;
			this.labelTauxDefautHeure.Location = new System.Drawing.Point(6, 48);
			this.labelTauxDefautHeure.Name = "labelTauxDefautHeure";
			this.labelTauxDefautHeure.Size = new System.Drawing.Size(101, 15);
			this.labelTauxDefautHeure.TabIndex = 14;
			this.labelTauxDefautHeure.Text = "Taux défaut heure";
			// 
			// textBoxTauxDefautHeure
			// 
			this.textBoxTauxDefautHeure.Location = new System.Drawing.Point(224, 45);
			this.textBoxTauxDefautHeure.Name = "textBoxTauxDefautHeure";
			this.textBoxTauxDefautHeure.Size = new System.Drawing.Size(58, 23);
			this.textBoxTauxDefautHeure.TabIndex = 13;
			// 
			// textBoxNbCaisse
			// 
			this.textBoxNbCaisse.Location = new System.Drawing.Point(224, 16);
			this.textBoxNbCaisse.Name = "textBoxNbCaisse";
			this.textBoxNbCaisse.Size = new System.Drawing.Size(58, 23);
			this.textBoxNbCaisse.TabIndex = 12;
			// 
			// labelNbCaisse
			// 
			this.labelNbCaisse.AutoSize = true;
			this.labelNbCaisse.Location = new System.Drawing.Point(6, 19);
			this.labelNbCaisse.Name = "labelNbCaisse";
			this.labelNbCaisse.Size = new System.Drawing.Size(216, 15);
			this.labelNbCaisse.TabIndex = 11;
			this.labelNbCaisse.Text = "Nombre de caisses depuis le démarrage";
			// 
			// groupBoxProduction
			// 
			this.groupBoxProduction.Controls.Add(this.labelNbCaisse);
			this.groupBoxProduction.Controls.Add(this.labelTauxDefautGlobal);
			this.groupBoxProduction.Controls.Add(this.textBoxNbCaisse);
			this.groupBoxProduction.Controls.Add(this.textBoxTauxDefautGlobal);
			this.groupBoxProduction.Controls.Add(this.textBoxTauxDefautHeure);
			this.groupBoxProduction.Controls.Add(this.labelTauxDefautHeure);
			this.groupBoxProduction.Location = new System.Drawing.Point(3, 3);
			this.groupBoxProduction.Name = "groupBoxProduction";
			this.groupBoxProduction.Size = new System.Drawing.Size(291, 118);
			this.groupBoxProduction.TabIndex = 17;
			this.groupBoxProduction.TabStop = false;
			this.groupBoxProduction.Text = "NomProd";
			// 
			// UserControlStats
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.groupBoxProduction);
			this.Name = "UserControlStats";
			this.Size = new System.Drawing.Size(298, 129);
			this.groupBoxProduction.ResumeLayout(false);
			this.groupBoxProduction.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private Label labelTauxDefautGlobal;
		private TextBox textBoxTauxDefautGlobal;
		private Label labelTauxDefautHeure;
		private TextBox textBoxTauxDefautHeure;
		private TextBox textBoxNbCaisse;
		private Label labelNbCaisse;
		private GroupBox groupBoxProduction;
	}
}
