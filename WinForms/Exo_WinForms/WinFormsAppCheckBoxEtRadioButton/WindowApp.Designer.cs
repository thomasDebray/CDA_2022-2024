namespace WinFormsAppCheckBoxEtRadioButton
{
    partial class WindowApp
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
			this.textBoxTexteOriginal = new System.Windows.Forms.TextBox();
			this.labelTapezTexte = new System.Windows.Forms.Label();
			this.textBoxTexteModif = new System.Windows.Forms.TextBox();
			this.groupBoxChoix = new System.Windows.Forms.GroupBox();
			this.checkBoxCasse = new System.Windows.Forms.CheckBox();
			this.checkBoxCouleurCaracteres = new System.Windows.Forms.CheckBox();
			this.checkBoxCouleurFond = new System.Windows.Forms.CheckBox();
			this.groupBoxFond = new System.Windows.Forms.GroupBox();
			this.radioButtonFondBleu = new System.Windows.Forms.RadioButton();
			this.radioButtonFondVert = new System.Windows.Forms.RadioButton();
			this.radioButtonFondRouge = new System.Windows.Forms.RadioButton();
			this.groupBoxCaracteres = new System.Windows.Forms.GroupBox();
			this.radioButtonCaractereNoir = new System.Windows.Forms.RadioButton();
			this.radioButtonCaractereBlanc = new System.Windows.Forms.RadioButton();
			this.radioButtonCaractereRouge = new System.Windows.Forms.RadioButton();
			this.groupBoxCasse = new System.Windows.Forms.GroupBox();
			this.radioButtonCasseMaj = new System.Windows.Forms.RadioButton();
			this.radioButtonCasseMin = new System.Windows.Forms.RadioButton();
			this.groupBoxChoix.SuspendLayout();
			this.groupBoxFond.SuspendLayout();
			this.groupBoxCaracteres.SuspendLayout();
			this.groupBoxCasse.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBoxTexteOriginal
			// 
			this.textBoxTexteOriginal.Location = new System.Drawing.Point(6, 30);
			this.textBoxTexteOriginal.Name = "textBoxTexteOriginal";
			this.textBoxTexteOriginal.Size = new System.Drawing.Size(226, 23);
			this.textBoxTexteOriginal.TabIndex = 4;
			this.textBoxTexteOriginal.TextChanged += new System.EventHandler(this.textBoxTexteOriginal_TextChanged);
			// 
			// labelTapezTexte
			// 
			this.labelTapezTexte.AutoSize = true;
			this.labelTapezTexte.Location = new System.Drawing.Point(6, 12);
			this.labelTapezTexte.Name = "labelTapezTexte";
			this.labelTapezTexte.Size = new System.Drawing.Size(95, 15);
			this.labelTapezTexte.TabIndex = 3;
			this.labelTapezTexte.Text = "Tapez votre texte";
			// 
			// textBoxTexteModif
			// 
			this.textBoxTexteModif.BackColor = System.Drawing.Color.WhiteSmoke;
			this.textBoxTexteModif.Location = new System.Drawing.Point(6, 83);
			this.textBoxTexteModif.Name = "textBoxTexteModif";
			this.textBoxTexteModif.ReadOnly = true;
			this.textBoxTexteModif.Size = new System.Drawing.Size(226, 23);
			this.textBoxTexteModif.TabIndex = 6;
			// 
			// groupBoxChoix
			// 
			this.groupBoxChoix.Controls.Add(this.checkBoxCasse);
			this.groupBoxChoix.Controls.Add(this.checkBoxCouleurCaracteres);
			this.groupBoxChoix.Controls.Add(this.checkBoxCouleurFond);
			this.groupBoxChoix.Enabled = false;
			this.groupBoxChoix.Location = new System.Drawing.Point(238, 12);
			this.groupBoxChoix.Name = "groupBoxChoix";
			this.groupBoxChoix.Size = new System.Drawing.Size(152, 100);
			this.groupBoxChoix.TabIndex = 7;
			this.groupBoxChoix.TabStop = false;
			this.groupBoxChoix.Text = "Choix";
			// 
			// checkBoxCasse
			// 
			this.checkBoxCasse.AutoSize = true;
			this.checkBoxCasse.Location = new System.Drawing.Point(6, 72);
			this.checkBoxCasse.Name = "checkBoxCasse";
			this.checkBoxCasse.Size = new System.Drawing.Size(56, 19);
			this.checkBoxCasse.TabIndex = 8;
			this.checkBoxCasse.Text = "Casse";
			this.checkBoxCasse.UseVisualStyleBackColor = true;
			this.checkBoxCasse.CheckedChanged += new System.EventHandler(this.checkBoxCasse_CheckedChanged);
			// 
			// checkBoxCouleurCaracteres
			// 
			this.checkBoxCouleurCaracteres.AutoSize = true;
			this.checkBoxCouleurCaracteres.Location = new System.Drawing.Point(6, 47);
			this.checkBoxCouleurCaracteres.Name = "checkBoxCouleurCaracteres";
			this.checkBoxCouleurCaracteres.Size = new System.Drawing.Size(145, 19);
			this.checkBoxCouleurCaracteres.TabIndex = 8;
			this.checkBoxCouleurCaracteres.Text = "Couleur des caractères";
			this.checkBoxCouleurCaracteres.UseVisualStyleBackColor = true;
			this.checkBoxCouleurCaracteres.CheckedChanged += new System.EventHandler(this.checkBoxCouleurCaracteres_CheckedChanged);
			// 
			// checkBoxCouleurFond
			// 
			this.checkBoxCouleurFond.AutoSize = true;
			this.checkBoxCouleurFond.Location = new System.Drawing.Point(6, 22);
			this.checkBoxCouleurFond.Name = "checkBoxCouleurFond";
			this.checkBoxCouleurFond.Size = new System.Drawing.Size(113, 19);
			this.checkBoxCouleurFond.TabIndex = 8;
			this.checkBoxCouleurFond.Text = "Couleur du fond";
			this.checkBoxCouleurFond.UseVisualStyleBackColor = true;
			this.checkBoxCouleurFond.CheckedChanged += new System.EventHandler(this.checkBoxCouleurFond_CheckedChanged);
			// 
			// groupBoxFond
			// 
			this.groupBoxFond.Controls.Add(this.radioButtonFondBleu);
			this.groupBoxFond.Controls.Add(this.radioButtonFondVert);
			this.groupBoxFond.Controls.Add(this.radioButtonFondRouge);
			this.groupBoxFond.Location = new System.Drawing.Point(6, 112);
			this.groupBoxFond.Name = "groupBoxFond";
			this.groupBoxFond.Size = new System.Drawing.Size(95, 100);
			this.groupBoxFond.TabIndex = 8;
			this.groupBoxFond.TabStop = false;
			this.groupBoxFond.Text = "Fond";
			this.groupBoxFond.Visible = false;
			// 
			// radioButtonFondBleu
			// 
			this.radioButtonFondBleu.AutoSize = true;
			this.radioButtonFondBleu.Location = new System.Drawing.Point(6, 72);
			this.radioButtonFondBleu.Name = "radioButtonFondBleu";
			this.radioButtonFondBleu.Size = new System.Drawing.Size(48, 19);
			this.radioButtonFondBleu.TabIndex = 9;
			this.radioButtonFondBleu.TabStop = true;
			this.radioButtonFondBleu.Text = "Bleu";
			this.radioButtonFondBleu.UseVisualStyleBackColor = true;
			this.radioButtonFondBleu.CheckedChanged += new System.EventHandler(this.radioButtonFondBleu_CheckedChanged);
			// 
			// radioButtonFondVert
			// 
			this.radioButtonFondVert.AutoSize = true;
			this.radioButtonFondVert.Location = new System.Drawing.Point(6, 47);
			this.radioButtonFondVert.Name = "radioButtonFondVert";
			this.radioButtonFondVert.Size = new System.Drawing.Size(45, 19);
			this.radioButtonFondVert.TabIndex = 9;
			this.radioButtonFondVert.TabStop = true;
			this.radioButtonFondVert.Text = "Vert";
			this.radioButtonFondVert.UseVisualStyleBackColor = true;
			this.radioButtonFondVert.CheckedChanged += new System.EventHandler(this.radioButtonFondVert_CheckedChanged);
			// 
			// radioButtonFondRouge
			// 
			this.radioButtonFondRouge.AutoSize = true;
			this.radioButtonFondRouge.Location = new System.Drawing.Point(6, 22);
			this.radioButtonFondRouge.Name = "radioButtonFondRouge";
			this.radioButtonFondRouge.Size = new System.Drawing.Size(59, 19);
			this.radioButtonFondRouge.TabIndex = 9;
			this.radioButtonFondRouge.TabStop = true;
			this.radioButtonFondRouge.Text = "Rouge";
			this.radioButtonFondRouge.UseVisualStyleBackColor = true;
			this.radioButtonFondRouge.CheckedChanged += new System.EventHandler(this.radioButtonFondRouge_CheckedChanged);
			// 
			// groupBoxCaracteres
			// 
			this.groupBoxCaracteres.Controls.Add(this.radioButtonCaractereNoir);
			this.groupBoxCaracteres.Controls.Add(this.radioButtonCaractereBlanc);
			this.groupBoxCaracteres.Controls.Add(this.radioButtonCaractereRouge);
			this.groupBoxCaracteres.Location = new System.Drawing.Point(107, 112);
			this.groupBoxCaracteres.Name = "groupBoxCaracteres";
			this.groupBoxCaracteres.Size = new System.Drawing.Size(95, 100);
			this.groupBoxCaracteres.TabIndex = 9;
			this.groupBoxCaracteres.TabStop = false;
			this.groupBoxCaracteres.Text = "Caractères";
			this.groupBoxCaracteres.Visible = false;
			// 
			// radioButtonCaractereNoir
			// 
			this.radioButtonCaractereNoir.AutoSize = true;
			this.radioButtonCaractereNoir.Location = new System.Drawing.Point(6, 72);
			this.radioButtonCaractereNoir.Name = "radioButtonCaractereNoir";
			this.radioButtonCaractereNoir.Size = new System.Drawing.Size(48, 19);
			this.radioButtonCaractereNoir.TabIndex = 11;
			this.radioButtonCaractereNoir.TabStop = true;
			this.radioButtonCaractereNoir.Text = "Noir";
			this.radioButtonCaractereNoir.UseVisualStyleBackColor = true;
			this.radioButtonCaractereNoir.CheckedChanged += new System.EventHandler(this.radioButtonCaractereNoir_CheckedChanged);
			// 
			// radioButtonCaractereBlanc
			// 
			this.radioButtonCaractereBlanc.AutoSize = true;
			this.radioButtonCaractereBlanc.Location = new System.Drawing.Point(6, 47);
			this.radioButtonCaractereBlanc.Name = "radioButtonCaractereBlanc";
			this.radioButtonCaractereBlanc.Size = new System.Drawing.Size(54, 19);
			this.radioButtonCaractereBlanc.TabIndex = 11;
			this.radioButtonCaractereBlanc.TabStop = true;
			this.radioButtonCaractereBlanc.Text = "Blanc";
			this.radioButtonCaractereBlanc.UseVisualStyleBackColor = true;
			this.radioButtonCaractereBlanc.CheckedChanged += new System.EventHandler(this.radioButtonCaractereBlanc_CheckedChanged);
			// 
			// radioButtonCaractereRouge
			// 
			this.radioButtonCaractereRouge.AutoSize = true;
			this.radioButtonCaractereRouge.Location = new System.Drawing.Point(6, 22);
			this.radioButtonCaractereRouge.Name = "radioButtonCaractereRouge";
			this.radioButtonCaractereRouge.Size = new System.Drawing.Size(59, 19);
			this.radioButtonCaractereRouge.TabIndex = 11;
			this.radioButtonCaractereRouge.TabStop = true;
			this.radioButtonCaractereRouge.Text = "Rouge";
			this.radioButtonCaractereRouge.UseVisualStyleBackColor = true;
			this.radioButtonCaractereRouge.CheckedChanged += new System.EventHandler(this.radioButtonCaractereRouge_CheckedChanged);
			// 
			// groupBoxCasse
			// 
			this.groupBoxCasse.Controls.Add(this.radioButtonCasseMaj);
			this.groupBoxCasse.Controls.Add(this.radioButtonCasseMin);
			this.groupBoxCasse.Location = new System.Drawing.Point(208, 112);
			this.groupBoxCasse.Name = "groupBoxCasse";
			this.groupBoxCasse.Size = new System.Drawing.Size(92, 78);
			this.groupBoxCasse.TabIndex = 10;
			this.groupBoxCasse.TabStop = false;
			this.groupBoxCasse.Text = "Casse";
			this.groupBoxCasse.Visible = false;
			// 
			// radioButtonCasseMaj
			// 
			this.radioButtonCasseMaj.AutoSize = true;
			this.radioButtonCasseMaj.Location = new System.Drawing.Point(6, 47);
			this.radioButtonCasseMaj.Name = "radioButtonCasseMaj";
			this.radioButtonCasseMaj.Size = new System.Drawing.Size(84, 19);
			this.radioButtonCasseMaj.TabIndex = 11;
			this.radioButtonCasseMaj.TabStop = true;
			this.radioButtonCasseMaj.Text = "Majuscules";
			this.radioButtonCasseMaj.UseVisualStyleBackColor = true;
			this.radioButtonCasseMaj.CheckedChanged += new System.EventHandler(this.radioButtonCasseMaj_CheckedChanged);
			// 
			// radioButtonCasseMin
			// 
			this.radioButtonCasseMin.AutoSize = true;
			this.radioButtonCasseMin.Location = new System.Drawing.Point(6, 22);
			this.radioButtonCasseMin.Name = "radioButtonCasseMin";
			this.radioButtonCasseMin.Size = new System.Drawing.Size(85, 19);
			this.radioButtonCasseMin.TabIndex = 11;
			this.radioButtonCasseMin.TabStop = true;
			this.radioButtonCasseMin.Text = "Minuscules";
			this.radioButtonCasseMin.UseVisualStyleBackColor = true;
			this.radioButtonCasseMin.CheckedChanged += new System.EventHandler(this.radioButtonCasseMin_CheckedChanged);
			// 
			// WindowApp
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(397, 217);
			this.Controls.Add(this.groupBoxCasse);
			this.Controls.Add(this.groupBoxCaracteres);
			this.Controls.Add(this.groupBoxFond);
			this.Controls.Add(this.groupBoxChoix);
			this.Controls.Add(this.textBoxTexteModif);
			this.Controls.Add(this.textBoxTexteOriginal);
			this.Controls.Add(this.labelTapezTexte);
			this.Name = "WindowApp";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "CheckBox et RadioButton";
			this.groupBoxChoix.ResumeLayout(false);
			this.groupBoxChoix.PerformLayout();
			this.groupBoxFond.ResumeLayout(false);
			this.groupBoxFond.PerformLayout();
			this.groupBoxCaracteres.ResumeLayout(false);
			this.groupBoxCaracteres.PerformLayout();
			this.groupBoxCasse.ResumeLayout(false);
			this.groupBoxCasse.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private TextBox textBoxTexteOriginal;
        private Label labelTapezTexte;
        private TextBox textBoxTexteModif;
        private GroupBox groupBoxChoix;
        private CheckBox checkBoxCasse;
        private CheckBox checkBoxCouleurCaracteres;
        private CheckBox checkBoxCouleurFond;
        private GroupBox groupBoxFond;
        private RadioButton radioButtonFondVert;
        private RadioButton radioButtonFondRouge;
        private RadioButton radioButtonFondBleu;
        private GroupBox groupBoxCaracteres;
        private GroupBox groupBoxCasse;
        private RadioButton radioButtonCaractereNoir;
        private RadioButton radioButtonCaractereBlanc;
        private RadioButton radioButtonCaractereRouge;
        private RadioButton radioButtonCasseMaj;
        private RadioButton radioButtonCasseMin;
    }
}