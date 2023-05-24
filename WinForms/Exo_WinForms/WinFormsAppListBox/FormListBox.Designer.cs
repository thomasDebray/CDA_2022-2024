namespace WinFormsAppListBox
{
    partial class FormListBox
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
            this.labelNouvelElement = new System.Windows.Forms.Label();
            this.textBoxNvlElement = new System.Windows.Forms.TextBox();
            this.buttonAjoutListe = new System.Windows.Forms.Button();
            this.labelIndexElement = new System.Windows.Forms.Label();
            this.textBoxIndexElement = new System.Windows.Forms.TextBox();
            this.buttonSelectionner = new System.Windows.Forms.Button();
            this.buttonViderListe = new System.Windows.Forms.Button();
            this.labelListe = new System.Windows.Forms.Label();
            this.listBoxListe = new System.Windows.Forms.ListBox();
            this.labelProprietes = new System.Windows.Forms.Label();
            this.labelText = new System.Windows.Forms.Label();
            this.labelSelectedINdex = new System.Windows.Forms.Label();
            this.labelItemsCount = new System.Windows.Forms.Label();
            this.textBoxSelectedIndex = new System.Windows.Forms.TextBox();
            this.textBoxItemsCount = new System.Windows.Forms.TextBox();
            this.textBoxText = new System.Windows.Forms.TextBox();
            this.errorProviderElmIncorrect = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderIndexIncorrect = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderElmIncorrect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderIndexIncorrect)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNouvelElement
            // 
            this.labelNouvelElement.AutoSize = true;
            this.labelNouvelElement.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelNouvelElement.Location = new System.Drawing.Point(12, 9);
            this.labelNouvelElement.Name = "labelNouvelElement";
            this.labelNouvelElement.Size = new System.Drawing.Size(96, 15);
            this.labelNouvelElement.TabIndex = 0;
            this.labelNouvelElement.Text = "Nouvel Elément";
            // 
            // textBoxNvlElement
            // 
            this.textBoxNvlElement.Location = new System.Drawing.Point(12, 27);
            this.textBoxNvlElement.Name = "textBoxNvlElement";
            this.textBoxNvlElement.Size = new System.Drawing.Size(126, 23);
            this.textBoxNvlElement.TabIndex = 1;
            this.textBoxNvlElement.TextChanged += new System.EventHandler(this.textBoxNvlElement_TextChanged);
            // 
            // buttonAjoutListe
            // 
            this.buttonAjoutListe.Location = new System.Drawing.Point(12, 56);
            this.buttonAjoutListe.Name = "buttonAjoutListe";
            this.buttonAjoutListe.Size = new System.Drawing.Size(126, 23);
            this.buttonAjoutListe.TabIndex = 2;
            this.buttonAjoutListe.Text = "Ajout Liste";
            this.buttonAjoutListe.UseVisualStyleBackColor = true;
            this.buttonAjoutListe.Click += new System.EventHandler(this.buttonAjoutListe_Click);
            // 
            // labelIndexElement
            // 
            this.labelIndexElement.AutoSize = true;
            this.labelIndexElement.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelIndexElement.Location = new System.Drawing.Point(175, 9);
            this.labelIndexElement.Name = "labelIndexElement";
            this.labelIndexElement.Size = new System.Drawing.Size(88, 15);
            this.labelIndexElement.TabIndex = 3;
            this.labelIndexElement.Text = "Index Elément";
            // 
            // textBoxIndexElement
            // 
            this.textBoxIndexElement.Location = new System.Drawing.Point(175, 27);
            this.textBoxIndexElement.Name = "textBoxIndexElement";
            this.textBoxIndexElement.Size = new System.Drawing.Size(45, 23);
            this.textBoxIndexElement.TabIndex = 4;
            this.textBoxIndexElement.TextChanged += new System.EventHandler(this.textBoxIndexElement_TextChanged);
            // 
            // buttonSelectionner
            // 
            this.buttonSelectionner.Location = new System.Drawing.Point(239, 27);
            this.buttonSelectionner.Name = "buttonSelectionner";
            this.buttonSelectionner.Size = new System.Drawing.Size(113, 23);
            this.buttonSelectionner.TabIndex = 5;
            this.buttonSelectionner.Text = "Sélectionner";
            this.buttonSelectionner.UseVisualStyleBackColor = true;
            this.buttonSelectionner.Click += new System.EventHandler(this.buttonSelectionner_Click);
            // 
            // buttonViderListe
            // 
            this.buttonViderListe.Location = new System.Drawing.Point(239, 56);
            this.buttonViderListe.Name = "buttonViderListe";
            this.buttonViderListe.Size = new System.Drawing.Size(113, 23);
            this.buttonViderListe.TabIndex = 6;
            this.buttonViderListe.Text = "Vider la Liste";
            this.buttonViderListe.UseVisualStyleBackColor = true;
            this.buttonViderListe.Click += new System.EventHandler(this.buttonViderListe_Click);
            // 
            // labelListe
            // 
            this.labelListe.AutoSize = true;
            this.labelListe.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelListe.Location = new System.Drawing.Point(12, 98);
            this.labelListe.Name = "labelListe";
            this.labelListe.Size = new System.Drawing.Size(33, 15);
            this.labelListe.TabIndex = 7;
            this.labelListe.Text = "Liste";
            // 
            // listBoxListe
            // 
            this.listBoxListe.FormattingEnabled = true;
            this.listBoxListe.ItemHeight = 15;
            this.listBoxListe.Location = new System.Drawing.Point(12, 116);
            this.listBoxListe.Name = "listBoxListe";
            this.listBoxListe.Size = new System.Drawing.Size(126, 94);
            this.listBoxListe.TabIndex = 8;
            this.listBoxListe.SelectedIndexChanged += new System.EventHandler(this.listBoxListe_SelectedIndexChanged);
            // 
            // labelProprietes
            // 
            this.labelProprietes.AutoSize = true;
            this.labelProprietes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelProprietes.Location = new System.Drawing.Point(175, 98);
            this.labelProprietes.Name = "labelProprietes";
            this.labelProprietes.Size = new System.Drawing.Size(65, 15);
            this.labelProprietes.TabIndex = 9;
            this.labelProprietes.Text = "Propriétés";
            // 
            // labelText
            // 
            this.labelText.AutoSize = true;
            this.labelText.Location = new System.Drawing.Point(175, 190);
            this.labelText.Name = "labelText";
            this.labelText.Size = new System.Drawing.Size(28, 15);
            this.labelText.TabIndex = 10;
            this.labelText.Text = "Text";
            // 
            // labelSelectedINdex
            // 
            this.labelSelectedINdex.AutoSize = true;
            this.labelSelectedINdex.Location = new System.Drawing.Point(175, 161);
            this.labelSelectedINdex.Name = "labelSelectedINdex";
            this.labelSelectedINdex.Size = new System.Drawing.Size(83, 15);
            this.labelSelectedINdex.TabIndex = 11;
            this.labelSelectedINdex.Text = "Selected Index";
            // 
            // labelItemsCount
            // 
            this.labelItemsCount.AutoSize = true;
            this.labelItemsCount.Location = new System.Drawing.Point(175, 132);
            this.labelItemsCount.Name = "labelItemsCount";
            this.labelItemsCount.Size = new System.Drawing.Size(72, 15);
            this.labelItemsCount.TabIndex = 12;
            this.labelItemsCount.Text = "Items Count";
            // 
            // textBoxSelectedIndex
            // 
            this.textBoxSelectedIndex.Location = new System.Drawing.Point(264, 158);
            this.textBoxSelectedIndex.Name = "textBoxSelectedIndex";
            this.textBoxSelectedIndex.ReadOnly = true;
            this.textBoxSelectedIndex.Size = new System.Drawing.Size(45, 23);
            this.textBoxSelectedIndex.TabIndex = 13;
            // 
            // textBoxItemsCount
            // 
            this.textBoxItemsCount.Location = new System.Drawing.Point(264, 129);
            this.textBoxItemsCount.Name = "textBoxItemsCount";
            this.textBoxItemsCount.ReadOnly = true;
            this.textBoxItemsCount.Size = new System.Drawing.Size(45, 23);
            this.textBoxItemsCount.TabIndex = 14;
            this.textBoxItemsCount.Text = "0";
            // 
            // textBoxText
            // 
            this.textBoxText.Location = new System.Drawing.Point(264, 187);
            this.textBoxText.Name = "textBoxText";
            this.textBoxText.ReadOnly = true;
            this.textBoxText.Size = new System.Drawing.Size(88, 23);
            this.textBoxText.TabIndex = 15;
            // 
            // errorProviderElmIncorrect
            // 
            this.errorProviderElmIncorrect.BlinkRate = 0;
            this.errorProviderElmIncorrect.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderElmIncorrect.ContainerControl = this;
            // 
            // errorProviderIndexIncorrect
            // 
            this.errorProviderIndexIncorrect.BlinkRate = 0;
            this.errorProviderIndexIncorrect.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderIndexIncorrect.ContainerControl = this;
            // 
            // FormListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 215);
            this.Controls.Add(this.textBoxText);
            this.Controls.Add(this.textBoxItemsCount);
            this.Controls.Add(this.textBoxSelectedIndex);
            this.Controls.Add(this.labelItemsCount);
            this.Controls.Add(this.labelSelectedINdex);
            this.Controls.Add(this.labelText);
            this.Controls.Add(this.labelProprietes);
            this.Controls.Add(this.listBoxListe);
            this.Controls.Add(this.labelListe);
            this.Controls.Add(this.buttonViderListe);
            this.Controls.Add(this.buttonSelectionner);
            this.Controls.Add(this.textBoxIndexElement);
            this.Controls.Add(this.labelIndexElement);
            this.Controls.Add(this.buttonAjoutListe);
            this.Controls.Add(this.textBoxNvlElement);
            this.Controls.Add(this.labelNouvelElement);
            this.Name = "FormListBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Les listes et leurs propriétés";
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderElmIncorrect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderIndexIncorrect)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelNouvelElement;
        private TextBox textBoxNvlElement;
        private Button buttonAjoutListe;
        private Label labelIndexElement;
        private TextBox textBoxIndexElement;
        private Button buttonSelectionner;
        private Button buttonViderListe;
        private Label labelListe;
        private ListBox listBoxListe;
        private Label labelProprietes;
        private Label labelText;
        private Label labelSelectedINdex;
        private Label labelItemsCount;
        private TextBox textBoxSelectedIndex;
        private TextBox textBoxItemsCount;
        private TextBox textBoxText;
        private ErrorProvider errorProviderElmIncorrect;
        private ErrorProvider errorProviderIndexIncorrect;
    }
}