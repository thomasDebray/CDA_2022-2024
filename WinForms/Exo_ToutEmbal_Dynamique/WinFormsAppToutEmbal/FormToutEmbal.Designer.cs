namespace WinFormsAppToutEmbal
{
	partial class FormToutEmbal
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
			this.menuStripToutEmbal = new System.Windows.Forms.MenuStrip();
			this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ajouterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.bToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.productionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.démarrerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.arrêterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.continuerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.panelEtat = new System.Windows.Forms.Panel();
			this.panelStats = new System.Windows.Forms.Panel();
			this.panelProgression = new System.Windows.Forms.Panel();
			this.menuStripToutEmbal.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStripToutEmbal
			// 
			this.menuStripToutEmbal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.productionToolStripMenuItem});
			this.menuStripToutEmbal.Location = new System.Drawing.Point(0, 0);
			this.menuStripToutEmbal.Name = "menuStripToutEmbal";
			this.menuStripToutEmbal.Size = new System.Drawing.Size(747, 24);
			this.menuStripToutEmbal.TabIndex = 0;
			this.menuStripToutEmbal.Text = "menuStrip1";
			// 
			// fichierToolStripMenuItem
			// 
			this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitterToolStripMenuItem,
            this.ajouterToolStripMenuItem});
			this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
			this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
			this.fichierToolStripMenuItem.Text = "Fichier";
			// 
			// quitterToolStripMenuItem
			// 
			this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
			this.quitterToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
			this.quitterToolStripMenuItem.Text = "Quitter";
			this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
			// 
			// ajouterToolStripMenuItem
			// 
			this.ajouterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aToolStripMenuItem,
            this.bToolStripMenuItem,
            this.cToolStripMenuItem});
			this.ajouterToolStripMenuItem.Name = "ajouterToolStripMenuItem";
			this.ajouterToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
			this.ajouterToolStripMenuItem.Text = "Ajouter";
			// 
			// aToolStripMenuItem
			// 
			this.aToolStripMenuItem.Name = "aToolStripMenuItem";
			this.aToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
			this.aToolStripMenuItem.Text = "Production A";
			this.aToolStripMenuItem.Click += new System.EventHandler(this.aToolStripMenuItem_Click);
			// 
			// bToolStripMenuItem
			// 
			this.bToolStripMenuItem.Name = "bToolStripMenuItem";
			this.bToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
			this.bToolStripMenuItem.Text = "Production B";
			this.bToolStripMenuItem.Click += new System.EventHandler(this.bToolStripMenuItem_Click);
			// 
			// cToolStripMenuItem
			// 
			this.cToolStripMenuItem.Name = "cToolStripMenuItem";
			this.cToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
			this.cToolStripMenuItem.Text = "Production C";
			this.cToolStripMenuItem.Click += new System.EventHandler(this.cToolStripMenuItem_Click);
			// 
			// productionToolStripMenuItem
			// 
			this.productionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.démarrerToolStripMenuItem,
            this.arrêterToolStripMenuItem,
            this.continuerToolStripMenuItem});
			this.productionToolStripMenuItem.Name = "productionToolStripMenuItem";
			this.productionToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
			this.productionToolStripMenuItem.Text = "Production";
			// 
			// démarrerToolStripMenuItem
			// 
			this.démarrerToolStripMenuItem.Name = "démarrerToolStripMenuItem";
			this.démarrerToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
			this.démarrerToolStripMenuItem.Text = "Démarrer";
			// 
			// arrêterToolStripMenuItem
			// 
			this.arrêterToolStripMenuItem.Name = "arrêterToolStripMenuItem";
			this.arrêterToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
			this.arrêterToolStripMenuItem.Text = "Arrêter";
			// 
			// continuerToolStripMenuItem
			// 
			this.continuerToolStripMenuItem.Name = "continuerToolStripMenuItem";
			this.continuerToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
			this.continuerToolStripMenuItem.Text = "Continuer";
			// 
			// panelEtat
			// 
			this.panelEtat.AutoScroll = true;
			this.panelEtat.Location = new System.Drawing.Point(0, 27);
			this.panelEtat.Name = "panelEtat";
			this.panelEtat.Size = new System.Drawing.Size(747, 75);
			this.panelEtat.TabIndex = 2;
			// 
			// panelStats
			// 
			this.panelStats.AutoScroll = true;
			this.panelStats.Location = new System.Drawing.Point(0, 108);
			this.panelStats.Name = "panelStats";
			this.panelStats.Size = new System.Drawing.Size(747, 153);
			this.panelStats.TabIndex = 3;
			// 
			// panelProgression
			// 
			this.panelProgression.AutoScroll = true;
			this.panelProgression.Location = new System.Drawing.Point(0, 267);
			this.panelProgression.Name = "panelProgression";
			this.panelProgression.Size = new System.Drawing.Size(747, 221);
			this.panelProgression.TabIndex = 4;
			// 
			// FormToutEmbal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(747, 500);
			this.Controls.Add(this.panelProgression);
			this.Controls.Add(this.panelStats);
			this.Controls.Add(this.panelEtat);
			this.Controls.Add(this.menuStripToutEmbal);
			this.MainMenuStrip = this.menuStripToutEmbal;
			this.Name = "FormToutEmbal";
			this.Text = "PRODUCTION DES CAISSES";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormToutEmbal_FormClosing);
			this.menuStripToutEmbal.ResumeLayout(false);
			this.menuStripToutEmbal.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private MenuStrip menuStripToutEmbal;
		private ToolStripMenuItem fichierToolStripMenuItem;
		private ToolStripMenuItem quitterToolStripMenuItem;
		private ToolStripMenuItem ajouterToolStripMenuItem;
		private ToolStripMenuItem aToolStripMenuItem;
		private ToolStripMenuItem bToolStripMenuItem;
		private ToolStripMenuItem cToolStripMenuItem;
		private ToolStripMenuItem productionToolStripMenuItem;
		private ToolStripMenuItem démarrerToolStripMenuItem;
		private ToolStripMenuItem arrêterToolStripMenuItem;
		private ToolStripMenuItem continuerToolStripMenuItem;
		private Panel panelEtat;
		private Panel panelStats;
		private Panel panelProgression;
	}
}