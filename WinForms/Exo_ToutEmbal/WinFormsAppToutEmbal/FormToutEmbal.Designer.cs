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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormToutEmbal));
			this.timerProductionA = new System.Windows.Forms.Timer(this.components);
			this.timerProductionB = new System.Windows.Forms.Timer(this.components);
			this.timerProductionC = new System.Windows.Forms.Timer(this.components);
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.productionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.démarrerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aDemarrerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.bDemarrerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cDemarrerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.arrêterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aArreterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.bArreterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cArreterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.continuerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aContinuerToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
			this.bContinuerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cContinuerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.labelProductionA = new System.Windows.Forms.Label();
			this.labelProductionB = new System.Windows.Forms.Label();
			this.labelProductionC = new System.Windows.Forms.Label();
			this.progressBarProductionA = new System.Windows.Forms.ProgressBar();
			this.progressBarProductionB = new System.Windows.Forms.ProgressBar();
			this.progressBarProductionC = new System.Windows.Forms.ProgressBar();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.labelTauxDefautGlobalA = new System.Windows.Forms.Label();
			this.textBoxTauxDefautGlobalA = new System.Windows.Forms.TextBox();
			this.labelTauxDefautHeureA = new System.Windows.Forms.Label();
			this.textBoxTauxDefautHeureA = new System.Windows.Forms.TextBox();
			this.textBoxNbCaisseA = new System.Windows.Forms.TextBox();
			this.labelNbCaisseA = new System.Windows.Forms.Label();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.labelTauxDefautGlobalB = new System.Windows.Forms.Label();
			this.labelTauxDefautHeureB = new System.Windows.Forms.Label();
			this.labelNbCaisseB = new System.Windows.Forms.Label();
			this.textBoxTauxDefautGlobalB = new System.Windows.Forms.TextBox();
			this.textBoxTauxDefautHeureB = new System.Windows.Forms.TextBox();
			this.textBoxNbCaisseB = new System.Windows.Forms.TextBox();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.labelTauxDefautGlobalC = new System.Windows.Forms.Label();
			this.labelTauxDefautHeureC = new System.Windows.Forms.Label();
			this.labelNbCaisseC = new System.Windows.Forms.Label();
			this.textBoxTauxDefautGlobalC = new System.Windows.Forms.TextBox();
			this.textBoxTauxDefautHeureC = new System.Windows.Forms.TextBox();
			this.textBoxNbCaisseC = new System.Windows.Forms.TextBox();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.toolStripButtonAVert = new System.Windows.Forms.ToolStripButton();
			this.toolStripButtonARouge = new System.Windows.Forms.ToolStripButton();
			this.toolStripButtonAOrange = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripButtonBVert = new System.Windows.Forms.ToolStripButton();
			this.toolStripButtonBRouge = new System.Windows.Forms.ToolStripButton();
			this.toolStripButtonBOrange = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripButtonCVert = new System.Windows.Forms.ToolStripButton();
			this.toolStripButtonCRouge = new System.Windows.Forms.ToolStripButton();
			this.toolStripButtonCOrange = new System.Windows.Forms.ToolStripButton();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabelCaisseA = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabelCaisseB = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabelCaisseC = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabelHeure = new System.Windows.Forms.ToolStripStatusLabel();
			this.timerHeure = new System.Windows.Forms.Timer(this.components);
			this.menuStrip1.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.tabPage3.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.productionToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(460, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fichierToolStripMenuItem
			// 
			this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitterToolStripMenuItem});
			this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
			this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
			this.fichierToolStripMenuItem.Text = "Fichier";
			// 
			// quitterToolStripMenuItem
			// 
			this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
			this.quitterToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
			this.quitterToolStripMenuItem.Text = "Quitter";
			this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
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
			this.démarrerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aDemarrerToolStripMenuItem,
            this.bDemarrerToolStripMenuItem,
            this.cDemarrerToolStripMenuItem});
			this.démarrerToolStripMenuItem.Name = "démarrerToolStripMenuItem";
			this.démarrerToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
			this.démarrerToolStripMenuItem.Text = "Démarrer";
			// 
			// aDemarrerToolStripMenuItem
			// 
			this.aDemarrerToolStripMenuItem.Name = "aDemarrerToolStripMenuItem";
			this.aDemarrerToolStripMenuItem.Size = new System.Drawing.Size(82, 22);
			this.aDemarrerToolStripMenuItem.Text = "A";
			this.aDemarrerToolStripMenuItem.Click += new System.EventHandler(this.aToolStripMenuItem_Click);
			// 
			// bDemarrerToolStripMenuItem
			// 
			this.bDemarrerToolStripMenuItem.Name = "bDemarrerToolStripMenuItem";
			this.bDemarrerToolStripMenuItem.Size = new System.Drawing.Size(82, 22);
			this.bDemarrerToolStripMenuItem.Text = "B";
			this.bDemarrerToolStripMenuItem.Click += new System.EventHandler(this.bDemarrerToolStripMenuItem_Click);
			// 
			// cDemarrerToolStripMenuItem
			// 
			this.cDemarrerToolStripMenuItem.Name = "cDemarrerToolStripMenuItem";
			this.cDemarrerToolStripMenuItem.Size = new System.Drawing.Size(82, 22);
			this.cDemarrerToolStripMenuItem.Text = "C";
			this.cDemarrerToolStripMenuItem.Click += new System.EventHandler(this.cDemarrerToolStripMenuItem_Click);
			// 
			// arrêterToolStripMenuItem
			// 
			this.arrêterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aArreterToolStripMenuItem,
            this.bArreterToolStripMenuItem,
            this.cArreterToolStripMenuItem});
			this.arrêterToolStripMenuItem.Name = "arrêterToolStripMenuItem";
			this.arrêterToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
			this.arrêterToolStripMenuItem.Text = "Arrêter";
			// 
			// aArreterToolStripMenuItem
			// 
			this.aArreterToolStripMenuItem.Enabled = false;
			this.aArreterToolStripMenuItem.Name = "aArreterToolStripMenuItem";
			this.aArreterToolStripMenuItem.Size = new System.Drawing.Size(82, 22);
			this.aArreterToolStripMenuItem.Text = "A";
			this.aArreterToolStripMenuItem.Click += new System.EventHandler(this.aArreterToolStripMenuItem_Click);
			// 
			// bArreterToolStripMenuItem
			// 
			this.bArreterToolStripMenuItem.Enabled = false;
			this.bArreterToolStripMenuItem.Name = "bArreterToolStripMenuItem";
			this.bArreterToolStripMenuItem.Size = new System.Drawing.Size(82, 22);
			this.bArreterToolStripMenuItem.Text = "B";
			this.bArreterToolStripMenuItem.Click += new System.EventHandler(this.bArreterToolStripMenuItem_Click);
			// 
			// cArreterToolStripMenuItem
			// 
			this.cArreterToolStripMenuItem.Enabled = false;
			this.cArreterToolStripMenuItem.Name = "cArreterToolStripMenuItem";
			this.cArreterToolStripMenuItem.Size = new System.Drawing.Size(82, 22);
			this.cArreterToolStripMenuItem.Text = "C";
			this.cArreterToolStripMenuItem.Click += new System.EventHandler(this.cArreterToolStripMenuItem_Click);
			// 
			// continuerToolStripMenuItem
			// 
			this.continuerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aContinuerToolStripMenuItem2,
            this.bContinuerToolStripMenuItem,
            this.cContinuerToolStripMenuItem});
			this.continuerToolStripMenuItem.Name = "continuerToolStripMenuItem";
			this.continuerToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
			this.continuerToolStripMenuItem.Text = "Continuer";
			// 
			// aContinuerToolStripMenuItem2
			// 
			this.aContinuerToolStripMenuItem2.Enabled = false;
			this.aContinuerToolStripMenuItem2.Name = "aContinuerToolStripMenuItem2";
			this.aContinuerToolStripMenuItem2.Size = new System.Drawing.Size(82, 22);
			this.aContinuerToolStripMenuItem2.Text = "A";
			this.aContinuerToolStripMenuItem2.Click += new System.EventHandler(this.aContinuerToolStripMenuItem2_Click);
			// 
			// bContinuerToolStripMenuItem
			// 
			this.bContinuerToolStripMenuItem.Enabled = false;
			this.bContinuerToolStripMenuItem.Name = "bContinuerToolStripMenuItem";
			this.bContinuerToolStripMenuItem.Size = new System.Drawing.Size(82, 22);
			this.bContinuerToolStripMenuItem.Text = "B";
			this.bContinuerToolStripMenuItem.Click += new System.EventHandler(this.bContinuerToolStripMenuItem_Click);
			// 
			// cContinuerToolStripMenuItem
			// 
			this.cContinuerToolStripMenuItem.Enabled = false;
			this.cContinuerToolStripMenuItem.Name = "cContinuerToolStripMenuItem";
			this.cContinuerToolStripMenuItem.Size = new System.Drawing.Size(82, 22);
			this.cContinuerToolStripMenuItem.Text = "C";
			this.cContinuerToolStripMenuItem.Click += new System.EventHandler(this.cContinuerToolStripMenuItem_Click);
			// 
			// labelProductionA
			// 
			this.labelProductionA.AutoSize = true;
			this.labelProductionA.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.labelProductionA.Location = new System.Drawing.Point(12, 200);
			this.labelProductionA.Name = "labelProductionA";
			this.labelProductionA.Size = new System.Drawing.Size(79, 15);
			this.labelProductionA.TabIndex = 1;
			this.labelProductionA.Text = "Production A";
			// 
			// labelProductionB
			// 
			this.labelProductionB.AutoSize = true;
			this.labelProductionB.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.labelProductionB.Location = new System.Drawing.Point(12, 229);
			this.labelProductionB.Name = "labelProductionB";
			this.labelProductionB.Size = new System.Drawing.Size(79, 15);
			this.labelProductionB.TabIndex = 2;
			this.labelProductionB.Text = "Production B";
			// 
			// labelProductionC
			// 
			this.labelProductionC.AutoSize = true;
			this.labelProductionC.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.labelProductionC.Location = new System.Drawing.Point(12, 258);
			this.labelProductionC.Name = "labelProductionC";
			this.labelProductionC.Size = new System.Drawing.Size(78, 15);
			this.labelProductionC.TabIndex = 3;
			this.labelProductionC.Text = "Production C";
			// 
			// progressBarProductionA
			// 
			this.progressBarProductionA.Location = new System.Drawing.Point(162, 192);
			this.progressBarProductionA.Name = "progressBarProductionA";
			this.progressBarProductionA.Size = new System.Drawing.Size(292, 23);
			this.progressBarProductionA.Step = 1;
			this.progressBarProductionA.TabIndex = 4;
			// 
			// progressBarProductionB
			// 
			this.progressBarProductionB.Location = new System.Drawing.Point(162, 221);
			this.progressBarProductionB.Name = "progressBarProductionB";
			this.progressBarProductionB.Size = new System.Drawing.Size(292, 23);
			this.progressBarProductionB.TabIndex = 5;
			// 
			// progressBarProductionC
			// 
			this.progressBarProductionC.Location = new System.Drawing.Point(162, 250);
			this.progressBarProductionC.Name = "progressBarProductionC";
			this.progressBarProductionC.Size = new System.Drawing.Size(292, 23);
			this.progressBarProductionC.TabIndex = 6;
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Controls.Add(this.tabPage3);
			this.tabControl1.Location = new System.Drawing.Point(162, 66);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(296, 120);
			this.tabControl1.TabIndex = 7;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.labelTauxDefautGlobalA);
			this.tabPage1.Controls.Add(this.textBoxTauxDefautGlobalA);
			this.tabPage1.Controls.Add(this.labelTauxDefautHeureA);
			this.tabPage1.Controls.Add(this.textBoxTauxDefautHeureA);
			this.tabPage1.Controls.Add(this.textBoxNbCaisseA);
			this.tabPage1.Controls.Add(this.labelNbCaisseA);
			this.tabPage1.Location = new System.Drawing.Point(4, 24);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(288, 92);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Type A";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// labelTauxDefautGlobalA
			// 
			this.labelTauxDefautGlobalA.AutoSize = true;
			this.labelTauxDefautGlobalA.Location = new System.Drawing.Point(6, 67);
			this.labelTauxDefautGlobalA.Name = "labelTauxDefautGlobalA";
			this.labelTauxDefautGlobalA.Size = new System.Drawing.Size(166, 15);
			this.labelTauxDefautGlobalA.TabIndex = 10;
			this.labelTauxDefautGlobalA.Text = "Taux défaut depuis démarrage";
			// 
			// textBoxTauxDefautGlobalA
			// 
			this.textBoxTauxDefautGlobalA.Location = new System.Drawing.Point(224, 64);
			this.textBoxTauxDefautGlobalA.Name = "textBoxTauxDefautGlobalA";
			this.textBoxTauxDefautGlobalA.Size = new System.Drawing.Size(58, 23);
			this.textBoxTauxDefautGlobalA.TabIndex = 9;
			// 
			// labelTauxDefautHeureA
			// 
			this.labelTauxDefautHeureA.AutoSize = true;
			this.labelTauxDefautHeureA.Location = new System.Drawing.Point(6, 38);
			this.labelTauxDefautHeureA.Name = "labelTauxDefautHeureA";
			this.labelTauxDefautHeureA.Size = new System.Drawing.Size(101, 15);
			this.labelTauxDefautHeureA.TabIndex = 8;
			this.labelTauxDefautHeureA.Text = "Taux défaut heure";
			// 
			// textBoxTauxDefautHeureA
			// 
			this.textBoxTauxDefautHeureA.Location = new System.Drawing.Point(224, 35);
			this.textBoxTauxDefautHeureA.Name = "textBoxTauxDefautHeureA";
			this.textBoxTauxDefautHeureA.Size = new System.Drawing.Size(58, 23);
			this.textBoxTauxDefautHeureA.TabIndex = 2;
			// 
			// textBoxNbCaisseA
			// 
			this.textBoxNbCaisseA.Location = new System.Drawing.Point(224, 6);
			this.textBoxNbCaisseA.Name = "textBoxNbCaisseA";
			this.textBoxNbCaisseA.Size = new System.Drawing.Size(58, 23);
			this.textBoxNbCaisseA.TabIndex = 1;
			// 
			// labelNbCaisseA
			// 
			this.labelNbCaisseA.AutoSize = true;
			this.labelNbCaisseA.Location = new System.Drawing.Point(6, 9);
			this.labelNbCaisseA.Name = "labelNbCaisseA";
			this.labelNbCaisseA.Size = new System.Drawing.Size(216, 15);
			this.labelNbCaisseA.TabIndex = 0;
			this.labelNbCaisseA.Text = "Nombre de caisses depuis le démarrage";
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.labelTauxDefautGlobalB);
			this.tabPage2.Controls.Add(this.labelTauxDefautHeureB);
			this.tabPage2.Controls.Add(this.labelNbCaisseB);
			this.tabPage2.Controls.Add(this.textBoxTauxDefautGlobalB);
			this.tabPage2.Controls.Add(this.textBoxTauxDefautHeureB);
			this.tabPage2.Controls.Add(this.textBoxNbCaisseB);
			this.tabPage2.Location = new System.Drawing.Point(4, 24);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(288, 92);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Type B";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// labelTauxDefautGlobalB
			// 
			this.labelTauxDefautGlobalB.AutoSize = true;
			this.labelTauxDefautGlobalB.Location = new System.Drawing.Point(6, 67);
			this.labelTauxDefautGlobalB.Name = "labelTauxDefautGlobalB";
			this.labelTauxDefautGlobalB.Size = new System.Drawing.Size(166, 15);
			this.labelTauxDefautGlobalB.TabIndex = 8;
			this.labelTauxDefautGlobalB.Text = "Taux défaut depuis démarrage";
			// 
			// labelTauxDefautHeureB
			// 
			this.labelTauxDefautHeureB.AutoSize = true;
			this.labelTauxDefautHeureB.Location = new System.Drawing.Point(6, 38);
			this.labelTauxDefautHeureB.Name = "labelTauxDefautHeureB";
			this.labelTauxDefautHeureB.Size = new System.Drawing.Size(101, 15);
			this.labelTauxDefautHeureB.TabIndex = 4;
			this.labelTauxDefautHeureB.Text = "Taux défaut heure";
			// 
			// labelNbCaisseB
			// 
			this.labelNbCaisseB.AutoSize = true;
			this.labelNbCaisseB.Location = new System.Drawing.Point(6, 9);
			this.labelNbCaisseB.Name = "labelNbCaisseB";
			this.labelNbCaisseB.Size = new System.Drawing.Size(216, 15);
			this.labelNbCaisseB.TabIndex = 3;
			this.labelNbCaisseB.Text = "Nombre de caisses depuis le démarrage";
			// 
			// textBoxTauxDefautGlobalB
			// 
			this.textBoxTauxDefautGlobalB.Location = new System.Drawing.Point(224, 64);
			this.textBoxTauxDefautGlobalB.Name = "textBoxTauxDefautGlobalB";
			this.textBoxTauxDefautGlobalB.Size = new System.Drawing.Size(58, 23);
			this.textBoxTauxDefautGlobalB.TabIndex = 2;
			// 
			// textBoxTauxDefautHeureB
			// 
			this.textBoxTauxDefautHeureB.Location = new System.Drawing.Point(224, 35);
			this.textBoxTauxDefautHeureB.Name = "textBoxTauxDefautHeureB";
			this.textBoxTauxDefautHeureB.Size = new System.Drawing.Size(58, 23);
			this.textBoxTauxDefautHeureB.TabIndex = 1;
			// 
			// textBoxNbCaisseB
			// 
			this.textBoxNbCaisseB.Location = new System.Drawing.Point(224, 6);
			this.textBoxNbCaisseB.Name = "textBoxNbCaisseB";
			this.textBoxNbCaisseB.Size = new System.Drawing.Size(58, 23);
			this.textBoxNbCaisseB.TabIndex = 0;
			// 
			// tabPage3
			// 
			this.tabPage3.Controls.Add(this.labelTauxDefautGlobalC);
			this.tabPage3.Controls.Add(this.labelTauxDefautHeureC);
			this.tabPage3.Controls.Add(this.labelNbCaisseC);
			this.tabPage3.Controls.Add(this.textBoxTauxDefautGlobalC);
			this.tabPage3.Controls.Add(this.textBoxTauxDefautHeureC);
			this.tabPage3.Controls.Add(this.textBoxNbCaisseC);
			this.tabPage3.Location = new System.Drawing.Point(4, 24);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage3.Size = new System.Drawing.Size(288, 92);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "Type C";
			this.tabPage3.UseVisualStyleBackColor = true;
			// 
			// labelTauxDefautGlobalC
			// 
			this.labelTauxDefautGlobalC.AutoSize = true;
			this.labelTauxDefautGlobalC.Location = new System.Drawing.Point(6, 67);
			this.labelTauxDefautGlobalC.Name = "labelTauxDefautGlobalC";
			this.labelTauxDefautGlobalC.Size = new System.Drawing.Size(166, 15);
			this.labelTauxDefautGlobalC.TabIndex = 5;
			this.labelTauxDefautGlobalC.Text = "Taux défaut depuis démarrage";
			// 
			// labelTauxDefautHeureC
			// 
			this.labelTauxDefautHeureC.AutoSize = true;
			this.labelTauxDefautHeureC.Location = new System.Drawing.Point(6, 38);
			this.labelTauxDefautHeureC.Name = "labelTauxDefautHeureC";
			this.labelTauxDefautHeureC.Size = new System.Drawing.Size(101, 15);
			this.labelTauxDefautHeureC.TabIndex = 4;
			this.labelTauxDefautHeureC.Text = "Taux défaut heure";
			// 
			// labelNbCaisseC
			// 
			this.labelNbCaisseC.AutoSize = true;
			this.labelNbCaisseC.Location = new System.Drawing.Point(6, 9);
			this.labelNbCaisseC.Name = "labelNbCaisseC";
			this.labelNbCaisseC.Size = new System.Drawing.Size(216, 15);
			this.labelNbCaisseC.TabIndex = 3;
			this.labelNbCaisseC.Text = "Nombre de caisses depuis le démarrage";
			// 
			// textBoxTauxDefautGlobalC
			// 
			this.textBoxTauxDefautGlobalC.Location = new System.Drawing.Point(224, 64);
			this.textBoxTauxDefautGlobalC.Name = "textBoxTauxDefautGlobalC";
			this.textBoxTauxDefautGlobalC.Size = new System.Drawing.Size(58, 23);
			this.textBoxTauxDefautGlobalC.TabIndex = 2;
			// 
			// textBoxTauxDefautHeureC
			// 
			this.textBoxTauxDefautHeureC.Location = new System.Drawing.Point(224, 35);
			this.textBoxTauxDefautHeureC.Name = "textBoxTauxDefautHeureC";
			this.textBoxTauxDefautHeureC.Size = new System.Drawing.Size(58, 23);
			this.textBoxTauxDefautHeureC.TabIndex = 1;
			// 
			// textBoxNbCaisseC
			// 
			this.textBoxNbCaisseC.Location = new System.Drawing.Point(224, 6);
			this.textBoxNbCaisseC.Name = "textBoxNbCaisseC";
			this.textBoxNbCaisseC.Size = new System.Drawing.Size(58, 23);
			this.textBoxNbCaisseC.TabIndex = 0;
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonAVert,
            this.toolStripButtonARouge,
            this.toolStripButtonAOrange,
            this.toolStripSeparator1,
            this.toolStripButtonBVert,
            this.toolStripButtonBRouge,
            this.toolStripButtonBOrange,
            this.toolStripSeparator2,
            this.toolStripButtonCVert,
            this.toolStripButtonCRouge,
            this.toolStripButtonCOrange});
			this.toolStrip1.Location = new System.Drawing.Point(0, 24);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(460, 25);
			this.toolStrip1.TabIndex = 8;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// toolStripButtonAVert
			// 
			this.toolStripButtonAVert.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAVert.Image")));
			this.toolStripButtonAVert.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonAVert.Name = "toolStripButtonAVert";
			this.toolStripButtonAVert.Size = new System.Drawing.Size(35, 22);
			this.toolStripButtonAVert.Text = "A";
			this.toolStripButtonAVert.Click += new System.EventHandler(this.toolStripButtonAVert_Click);
			// 
			// toolStripButtonARouge
			// 
			this.toolStripButtonARouge.Enabled = false;
			this.toolStripButtonARouge.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonARouge.Image")));
			this.toolStripButtonARouge.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonARouge.Name = "toolStripButtonARouge";
			this.toolStripButtonARouge.Size = new System.Drawing.Size(35, 22);
			this.toolStripButtonARouge.Text = "A";
			this.toolStripButtonARouge.Click += new System.EventHandler(this.toolStripButtonARouge_Click);
			// 
			// toolStripButtonAOrange
			// 
			this.toolStripButtonAOrange.Enabled = false;
			this.toolStripButtonAOrange.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAOrange.Image")));
			this.toolStripButtonAOrange.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonAOrange.Name = "toolStripButtonAOrange";
			this.toolStripButtonAOrange.Size = new System.Drawing.Size(35, 22);
			this.toolStripButtonAOrange.Text = "A";
			this.toolStripButtonAOrange.Click += new System.EventHandler(this.toolStripButtonAOrange_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// toolStripButtonBVert
			// 
			this.toolStripButtonBVert.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonBVert.Image")));
			this.toolStripButtonBVert.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonBVert.Name = "toolStripButtonBVert";
			this.toolStripButtonBVert.Size = new System.Drawing.Size(34, 22);
			this.toolStripButtonBVert.Text = "B";
			this.toolStripButtonBVert.Click += new System.EventHandler(this.toolStripButtonBVert_Click);
			// 
			// toolStripButtonBRouge
			// 
			this.toolStripButtonBRouge.Enabled = false;
			this.toolStripButtonBRouge.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonBRouge.Image")));
			this.toolStripButtonBRouge.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonBRouge.Name = "toolStripButtonBRouge";
			this.toolStripButtonBRouge.Size = new System.Drawing.Size(34, 22);
			this.toolStripButtonBRouge.Text = "B";
			this.toolStripButtonBRouge.Click += new System.EventHandler(this.toolStripButtonBRouge_Click);
			// 
			// toolStripButtonBOrange
			// 
			this.toolStripButtonBOrange.Enabled = false;
			this.toolStripButtonBOrange.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonBOrange.Image")));
			this.toolStripButtonBOrange.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonBOrange.Name = "toolStripButtonBOrange";
			this.toolStripButtonBOrange.Size = new System.Drawing.Size(34, 22);
			this.toolStripButtonBOrange.Text = "B";
			this.toolStripButtonBOrange.Click += new System.EventHandler(this.toolStripButtonBOrange_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
			// 
			// toolStripButtonCVert
			// 
			this.toolStripButtonCVert.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonCVert.Image")));
			this.toolStripButtonCVert.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonCVert.Name = "toolStripButtonCVert";
			this.toolStripButtonCVert.Size = new System.Drawing.Size(35, 22);
			this.toolStripButtonCVert.Text = "C";
			this.toolStripButtonCVert.Click += new System.EventHandler(this.toolStripButtonCVert_Click);
			// 
			// toolStripButtonCRouge
			// 
			this.toolStripButtonCRouge.Enabled = false;
			this.toolStripButtonCRouge.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonCRouge.Image")));
			this.toolStripButtonCRouge.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonCRouge.Name = "toolStripButtonCRouge";
			this.toolStripButtonCRouge.Size = new System.Drawing.Size(35, 22);
			this.toolStripButtonCRouge.Text = "C";
			this.toolStripButtonCRouge.Click += new System.EventHandler(this.toolStripButtonCRouge_Click);
			// 
			// toolStripButtonCOrange
			// 
			this.toolStripButtonCOrange.Enabled = false;
			this.toolStripButtonCOrange.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonCOrange.Image")));
			this.toolStripButtonCOrange.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonCOrange.Name = "toolStripButtonCOrange";
			this.toolStripButtonCOrange.Size = new System.Drawing.Size(35, 22);
			this.toolStripButtonCOrange.Text = "C";
			this.toolStripButtonCOrange.Click += new System.EventHandler(this.toolStripButtonCOrange_Click);
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelCaisseA,
            this.toolStripStatusLabelCaisseB,
            this.toolStripStatusLabelCaisseC,
            this.toolStripStatusLabelHeure});
			this.statusStrip1.Location = new System.Drawing.Point(0, 281);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(460, 22);
			this.statusStrip1.TabIndex = 9;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// toolStripStatusLabelCaisseA
			// 
			this.toolStripStatusLabelCaisseA.Margin = new System.Windows.Forms.Padding(0, 3, 15, 2);
			this.toolStripStatusLabelCaisseA.Name = "toolStripStatusLabelCaisseA";
			this.toolStripStatusLabelCaisseA.Size = new System.Drawing.Size(86, 17);
			this.toolStripStatusLabelCaisseA.Text = "Caisses A : prêt";
			this.toolStripStatusLabelCaisseA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// toolStripStatusLabelCaisseB
			// 
			this.toolStripStatusLabelCaisseB.Margin = new System.Windows.Forms.Padding(0, 3, 15, 2);
			this.toolStripStatusLabelCaisseB.Name = "toolStripStatusLabelCaisseB";
			this.toolStripStatusLabelCaisseB.Size = new System.Drawing.Size(85, 17);
			this.toolStripStatusLabelCaisseB.Text = "Caisses B : prêt";
			this.toolStripStatusLabelCaisseB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// toolStripStatusLabelCaisseC
			// 
			this.toolStripStatusLabelCaisseC.Margin = new System.Windows.Forms.Padding(0, 3, 15, 2);
			this.toolStripStatusLabelCaisseC.Name = "toolStripStatusLabelCaisseC";
			this.toolStripStatusLabelCaisseC.Size = new System.Drawing.Size(86, 17);
			this.toolStripStatusLabelCaisseC.Text = "Caisses C : prêt";
			this.toolStripStatusLabelCaisseC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// toolStripStatusLabelHeure
			// 
			this.toolStripStatusLabelHeure.Name = "toolStripStatusLabelHeure";
			this.toolStripStatusLabelHeure.Size = new System.Drawing.Size(39, 17);
			this.toolStripStatusLabelHeure.Text = "Heure";
			// 
			// timerHeure
			// 
			this.timerHeure.Enabled = true;
			this.timerHeure.Interval = 1000;
			this.timerHeure.Tick += new System.EventHandler(this.timerHeure_Tick);
			// 
			// FormToutEmbal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(460, 303);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.progressBarProductionC);
			this.Controls.Add(this.progressBarProductionB);
			this.Controls.Add(this.progressBarProductionA);
			this.Controls.Add(this.labelProductionC);
			this.Controls.Add(this.labelProductionB);
			this.Controls.Add(this.labelProductionA);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "FormToutEmbal";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "PRODUCTION DES CAISSES";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormToutEmbal_FormClosing);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			this.tabPage3.ResumeLayout(false);
			this.tabPage3.PerformLayout();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Timer timerProductionA;
		private System.Windows.Forms.Timer timerProductionB;
		private System.Windows.Forms.Timer timerProductionC;
		private MenuStrip menuStrip1;
		private ToolStripMenuItem fichierToolStripMenuItem;
		private ToolStripMenuItem quitterToolStripMenuItem;
		private ToolStripMenuItem productionToolStripMenuItem;
		private ToolStripMenuItem démarrerToolStripMenuItem;
		private ToolStripMenuItem aDemarrerToolStripMenuItem;
		private ToolStripMenuItem bDemarrerToolStripMenuItem;
		private ToolStripMenuItem cDemarrerToolStripMenuItem;
		private ToolStripMenuItem arrêterToolStripMenuItem;
		private ToolStripMenuItem aArreterToolStripMenuItem;
		private ToolStripMenuItem bArreterToolStripMenuItem;
		private ToolStripMenuItem cArreterToolStripMenuItem;
		private ToolStripMenuItem continuerToolStripMenuItem;
		private ToolStripMenuItem aContinuerToolStripMenuItem2;
		private ToolStripMenuItem bContinuerToolStripMenuItem;
		private ToolStripMenuItem cContinuerToolStripMenuItem;
		private Label labelProductionA;
		private Label labelProductionB;
		private Label labelProductionC;
		private ProgressBar progressBarProductionA;
		private ProgressBar progressBarProductionB;
		private ProgressBar progressBarProductionC;
		private TabControl tabControl1;
		private TabPage tabPage1;
		private Label labelTauxDefautGlobalA;
		private TextBox textBoxTauxDefautGlobalA;
		private Label labelTauxDefautHeureA;
		private TextBox textBoxTauxDefautHeureA;
		private TextBox textBoxNbCaisseA;
		private Label labelNbCaisseA;
		private TabPage tabPage2;
		private Label labelTauxDefautGlobalB;
		private Label labelTauxDefautHeureB;
		private Label labelNbCaisseB;
		private TextBox textBoxTauxDefautGlobalB;
		private TextBox textBoxTauxDefautHeureB;
		private TextBox textBoxNbCaisseB;
		private TabPage tabPage3;
		private Label labelTauxDefautGlobalC;
		private Label labelTauxDefautHeureC;
		private Label labelNbCaisseC;
		private TextBox textBoxTauxDefautGlobalC;
		private TextBox textBoxTauxDefautHeureC;
		private TextBox textBoxNbCaisseC;
		private ToolStrip toolStrip1;
		private ToolStripButton toolStripButtonAVert;
		private ToolStripButton toolStripButtonARouge;
		private ToolStripButton toolStripButtonAOrange;
		private ToolStripSeparator toolStripSeparator1;
		private ToolStripButton toolStripButtonBVert;
		private ToolStripButton toolStripButtonBRouge;
		private ToolStripButton toolStripButtonBOrange;
		private ToolStripSeparator toolStripSeparator2;
		private ToolStripButton toolStripButtonCVert;
		private ToolStripButton toolStripButtonCRouge;
		private ToolStripButton toolStripButtonCOrange;
		private StatusStrip statusStrip1;
		private ToolStripStatusLabel toolStripStatusLabelCaisseA;
		private ToolStripStatusLabel toolStripStatusLabelCaisseB;
		private ToolStripStatusLabel toolStripStatusLabelCaisseC;
		private ToolStripStatusLabel toolStripStatusLabelHeure;
		private System.Windows.Forms.Timer timerHeure;
	}
}