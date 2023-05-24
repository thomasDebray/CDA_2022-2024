namespace WinFormsControlLibraryToutEmbal
{
	partial class UserControlEtat
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
			this.buttonVert = new System.Windows.Forms.Button();
			this.buttonRouge = new System.Windows.Forms.Button();
			this.buttonOrange = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// buttonVert
			// 
			this.buttonVert.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.buttonVert.BackColor = System.Drawing.Color.LimeGreen;
			this.buttonVert.Location = new System.Drawing.Point(0, 0);
			this.buttonVert.Name = "buttonVert";
			this.buttonVert.Size = new System.Drawing.Size(50, 50);
			this.buttonVert.TabIndex = 0;
			this.buttonVert.Text = "nom";
			this.buttonVert.UseVisualStyleBackColor = false;
			this.buttonVert.Click += new System.EventHandler(this.buttonVert_Click);
			// 
			// buttonRouge
			// 
			this.buttonRouge.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.buttonRouge.BackColor = System.Drawing.Color.Firebrick;
			this.buttonRouge.Enabled = false;
			this.buttonRouge.Location = new System.Drawing.Point(56, 0);
			this.buttonRouge.Name = "buttonRouge";
			this.buttonRouge.Size = new System.Drawing.Size(50, 50);
			this.buttonRouge.TabIndex = 1;
			this.buttonRouge.Text = "nom";
			this.buttonRouge.UseVisualStyleBackColor = false;
			this.buttonRouge.Click += new System.EventHandler(this.buttonRouge_Click);
			// 
			// buttonOrange
			// 
			this.buttonOrange.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.buttonOrange.BackColor = System.Drawing.Color.DarkOrange;
			this.buttonOrange.Enabled = false;
			this.buttonOrange.Location = new System.Drawing.Point(112, 0);
			this.buttonOrange.Name = "buttonOrange";
			this.buttonOrange.Size = new System.Drawing.Size(50, 50);
			this.buttonOrange.TabIndex = 2;
			this.buttonOrange.Text = "nom";
			this.buttonOrange.UseVisualStyleBackColor = false;
			this.buttonOrange.Click += new System.EventHandler(this.buttonOrange_Click);
			// 
			// UserControlEtat
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.buttonOrange);
			this.Controls.Add(this.buttonRouge);
			this.Controls.Add(this.buttonVert);
			this.Name = "UserControlEtat";
			this.Size = new System.Drawing.Size(175, 50);
			this.ResumeLayout(false);

		}

		#endregion

		private Button buttonVert;
		private Button buttonRouge;
		private Button buttonOrange;
	}
}
