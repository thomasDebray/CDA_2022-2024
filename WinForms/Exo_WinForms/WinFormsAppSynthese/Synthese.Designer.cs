namespace WinFormsAppSynthese
{
    partial class Synthese
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
			this.labelNom = new System.Windows.Forms.Label();
			this.labelCapital = new System.Windows.Forms.Label();
			this.labelDuree = new System.Windows.Forms.Label();
			this.labelPeriodicite = new System.Windows.Forms.Label();
			this.textBoxNom = new System.Windows.Forms.TextBox();
			this.textBoxCapital = new System.Windows.Forms.TextBox();
			this.labelNombreMoisRemboursement = new System.Windows.Forms.Label();
			this.hScrollBarNombreMoisRemboursement = new System.Windows.Forms.HScrollBar();
			this.listBoxPeriodicite = new System.Windows.Forms.ListBox();
			this.groupBoxTaux = new System.Windows.Forms.GroupBox();
			this.radioButtonTaux9 = new System.Windows.Forms.RadioButton();
			this.radioButtonTaux8 = new System.Windows.Forms.RadioButton();
			this.radioButtonTaux7 = new System.Windows.Forms.RadioButton();
			this.buttonOk = new System.Windows.Forms.Button();
			this.buttonAnnuler = new System.Windows.Forms.Button();
			this.labelRemboursement = new System.Windows.Forms.Label();
			this.labelNombreRemboursement = new System.Windows.Forms.Label();
			this.labelMontantRemboursement = new System.Windows.Forms.Label();
			this.groupBoxTaux.SuspendLayout();
			this.SuspendLayout();
			// 
			// labelNom
			// 
			this.labelNom.AutoSize = true;
			this.labelNom.Location = new System.Drawing.Point(12, 12);
			this.labelNom.Name = "labelNom";
			this.labelNom.Size = new System.Drawing.Size(34, 15);
			this.labelNom.TabIndex = 0;
			this.labelNom.Text = "Nom";
			// 
			// labelCapital
			// 
			this.labelCapital.AutoSize = true;
			this.labelCapital.Location = new System.Drawing.Point(12, 41);
			this.labelCapital.Name = "labelCapital";
			this.labelCapital.Size = new System.Drawing.Size(99, 15);
			this.labelCapital.TabIndex = 1;
			this.labelCapital.Text = "Capital emprunté";
			// 
			// labelDuree
			// 
			this.labelDuree.AutoSize = true;
			this.labelDuree.Location = new System.Drawing.Point(12, 82);
			this.labelDuree.Name = "labelDuree";
			this.labelDuree.Size = new System.Drawing.Size(103, 30);
			this.labelDuree.TabIndex = 2;
			this.labelDuree.Text = "Durée en mois du \r\nremboursement";
			// 
			// labelPeriodicite
			// 
			this.labelPeriodicite.AutoSize = true;
			this.labelPeriodicite.Location = new System.Drawing.Point(12, 123);
			this.labelPeriodicite.Name = "labelPeriodicite";
			this.labelPeriodicite.Size = new System.Drawing.Size(167, 15);
			this.labelPeriodicite.TabIndex = 3;
			this.labelPeriodicite.Text = "Périodicité de remboursement";
			// 
			// textBoxNom
			// 
			this.textBoxNom.Location = new System.Drawing.Point(131, 12);
			this.textBoxNom.Name = "textBoxNom";
			this.textBoxNom.Size = new System.Drawing.Size(100, 23);
			this.textBoxNom.TabIndex = 4;
			this.textBoxNom.TextChanged += new System.EventHandler(this.textBoxNom_TextChanged);
			// 
			// textBoxCapital
			// 
			this.textBoxCapital.Location = new System.Drawing.Point(131, 41);
			this.textBoxCapital.Name = "textBoxCapital";
			this.textBoxCapital.Size = new System.Drawing.Size(100, 23);
			this.textBoxCapital.TabIndex = 5;
			this.textBoxCapital.TextChanged += new System.EventHandler(this.textBoxCapital_TextChanged);
			// 
			// labelNombreMoisRemboursement
			// 
			this.labelNombreMoisRemboursement.AutoSize = true;
			this.labelNombreMoisRemboursement.Location = new System.Drawing.Point(131, 82);
			this.labelNombreMoisRemboursement.Name = "labelNombreMoisRemboursement";
			this.labelNombreMoisRemboursement.Size = new System.Drawing.Size(13, 15);
			this.labelNombreMoisRemboursement.TabIndex = 6;
			this.labelNombreMoisRemboursement.Text = "1";
			// 
			// hScrollBarNombreMoisRemboursement
			// 
			this.hScrollBarNombreMoisRemboursement.LargeChange = 12;
			this.hScrollBarNombreMoisRemboursement.Location = new System.Drawing.Point(170, 80);
			this.hScrollBarNombreMoisRemboursement.Name = "hScrollBarNombreMoisRemboursement";
			this.hScrollBarNombreMoisRemboursement.Size = new System.Drawing.Size(120, 17);
			this.hScrollBarNombreMoisRemboursement.TabIndex = 7;
			this.hScrollBarNombreMoisRemboursement.ValueChanged += new System.EventHandler(this.hScrollBarNombreMoisRemboursement_ValueChanged);
			// 
			// listBoxPeriodicite
			// 
			this.listBoxPeriodicite.FormattingEnabled = true;
			this.listBoxPeriodicite.ItemHeight = 15;
			this.listBoxPeriodicite.Location = new System.Drawing.Point(12, 141);
			this.listBoxPeriodicite.Name = "listBoxPeriodicite";
			this.listBoxPeriodicite.Size = new System.Drawing.Size(120, 94);
			this.listBoxPeriodicite.TabIndex = 8;
			this.listBoxPeriodicite.SelectedIndexChanged += new System.EventHandler(this.listBoxPeriodicite_SelectedIndexChanged);
			// 
			// groupBoxTaux
			// 
			this.groupBoxTaux.Controls.Add(this.radioButtonTaux9);
			this.groupBoxTaux.Controls.Add(this.radioButtonTaux8);
			this.groupBoxTaux.Controls.Add(this.radioButtonTaux7);
			this.groupBoxTaux.Location = new System.Drawing.Point(304, 12);
			this.groupBoxTaux.Name = "groupBoxTaux";
			this.groupBoxTaux.Size = new System.Drawing.Size(101, 100);
			this.groupBoxTaux.TabIndex = 9;
			this.groupBoxTaux.TabStop = false;
			this.groupBoxTaux.Text = "Taux d\'intérêt";
			// 
			// radioButtonTaux9
			// 
			this.radioButtonTaux9.AutoSize = true;
			this.radioButtonTaux9.Location = new System.Drawing.Point(6, 72);
			this.radioButtonTaux9.Name = "radioButtonTaux9";
			this.radioButtonTaux9.Size = new System.Drawing.Size(44, 19);
			this.radioButtonTaux9.TabIndex = 10;
			this.radioButtonTaux9.TabStop = true;
			this.radioButtonTaux9.Text = "9 %";
			this.radioButtonTaux9.UseVisualStyleBackColor = true;
			this.radioButtonTaux9.CheckedChanged += new System.EventHandler(this.radioButtonTaux9_CheckedChanged);
			// 
			// radioButtonTaux8
			// 
			this.radioButtonTaux8.AutoSize = true;
			this.radioButtonTaux8.Location = new System.Drawing.Point(6, 47);
			this.radioButtonTaux8.Name = "radioButtonTaux8";
			this.radioButtonTaux8.Size = new System.Drawing.Size(44, 19);
			this.radioButtonTaux8.TabIndex = 10;
			this.radioButtonTaux8.TabStop = true;
			this.radioButtonTaux8.Text = "8 %";
			this.radioButtonTaux8.UseVisualStyleBackColor = true;
			this.radioButtonTaux8.CheckedChanged += new System.EventHandler(this.radioButtonTaux8_CheckedChanged);
			// 
			// radioButtonTaux7
			// 
			this.radioButtonTaux7.AutoSize = true;
			this.radioButtonTaux7.Location = new System.Drawing.Point(6, 22);
			this.radioButtonTaux7.Name = "radioButtonTaux7";
			this.radioButtonTaux7.Size = new System.Drawing.Size(44, 19);
			this.radioButtonTaux7.TabIndex = 10;
			this.radioButtonTaux7.TabStop = true;
			this.radioButtonTaux7.Text = "7 %";
			this.radioButtonTaux7.UseVisualStyleBackColor = true;
			this.radioButtonTaux7.CheckedChanged += new System.EventHandler(this.radioButtonTaux7_CheckedChanged);
			// 
			// buttonOk
			// 
			this.buttonOk.Location = new System.Drawing.Point(430, 12);
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.Size = new System.Drawing.Size(75, 23);
			this.buttonOk.TabIndex = 10;
			this.buttonOk.Text = "OK";
			this.buttonOk.UseVisualStyleBackColor = true;
			// 
			// buttonAnnuler
			// 
			this.buttonAnnuler.Location = new System.Drawing.Point(430, 41);
			this.buttonAnnuler.Name = "buttonAnnuler";
			this.buttonAnnuler.Size = new System.Drawing.Size(75, 23);
			this.buttonAnnuler.TabIndex = 11;
			this.buttonAnnuler.Text = "Annuler";
			this.buttonAnnuler.UseVisualStyleBackColor = true;
			// 
			// labelRemboursement
			// 
			this.labelRemboursement.AutoSize = true;
			this.labelRemboursement.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.labelRemboursement.Location = new System.Drawing.Point(353, 141);
			this.labelRemboursement.Name = "labelRemboursement";
			this.labelRemboursement.Size = new System.Drawing.Size(106, 15);
			this.labelRemboursement.TabIndex = 12;
			this.labelRemboursement.Text = "Remboursements";
			// 
			// labelNombreRemboursement
			// 
			this.labelNombreRemboursement.AutoSize = true;
			this.labelNombreRemboursement.ForeColor = System.Drawing.Color.Red;
			this.labelNombreRemboursement.Location = new System.Drawing.Point(304, 141);
			this.labelNombreRemboursement.Name = "labelNombreRemboursement";
			this.labelNombreRemboursement.Size = new System.Drawing.Size(13, 15);
			this.labelNombreRemboursement.TabIndex = 13;
			this.labelNombreRemboursement.Text = "1";
			// 
			// labelMontantRemboursement
			// 
			this.labelMontantRemboursement.AutoSize = true;
			this.labelMontantRemboursement.ForeColor = System.Drawing.Color.Red;
			this.labelMontantRemboursement.Location = new System.Drawing.Point(384, 183);
			this.labelMontantRemboursement.Name = "labelMontantRemboursement";
			this.labelMontantRemboursement.Size = new System.Drawing.Size(0, 15);
			this.labelMontantRemboursement.TabIndex = 14;
			// 
			// Synthese
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(514, 243);
			this.Controls.Add(this.labelMontantRemboursement);
			this.Controls.Add(this.labelNombreRemboursement);
			this.Controls.Add(this.labelRemboursement);
			this.Controls.Add(this.buttonAnnuler);
			this.Controls.Add(this.buttonOk);
			this.Controls.Add(this.groupBoxTaux);
			this.Controls.Add(this.listBoxPeriodicite);
			this.Controls.Add(this.hScrollBarNombreMoisRemboursement);
			this.Controls.Add(this.labelNombreMoisRemboursement);
			this.Controls.Add(this.textBoxCapital);
			this.Controls.Add(this.textBoxNom);
			this.Controls.Add(this.labelPeriodicite);
			this.Controls.Add(this.labelDuree);
			this.Controls.Add(this.labelCapital);
			this.Controls.Add(this.labelNom);
			this.Name = "Synthese";
			this.Text = "Synthese";
			this.groupBoxTaux.ResumeLayout(false);
			this.groupBoxTaux.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private Label labelNom;
        private Label labelCapital;
        private Label labelDuree;
        private Label labelPeriodicite;
        private TextBox textBoxNom;
        private TextBox textBoxCapital;
        private Label labelNombreMoisRemboursement;
        private HScrollBar hScrollBarNombreMoisRemboursement;
        private ListBox listBoxPeriodicite;
        private GroupBox groupBoxTaux;
        private RadioButton radioButtonTaux9;
        private RadioButton radioButtonTaux8;
        private RadioButton radioButtonTaux7;
        private Button buttonOk;
        private Button buttonAnnuler;
        private Label labelRemboursement;
        private Label labelNombreRemboursement;
        private Label labelMontantRemboursement;
    }
}