namespace WinFormsAppListBoxEtComboBox
{
    partial class FormListBoxEtComboBox
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
            this.comboBoxSource = new System.Windows.Forms.ComboBox();
            this.labelSource = new System.Windows.Forms.Label();
            this.listBoxCible = new System.Windows.Forms.ListBox();
            this.buttonAjouter = new System.Windows.Forms.Button();
            this.buttonAjouterTout = new System.Windows.Forms.Button();
            this.buttonEnleverTout = new System.Windows.Forms.Button();
            this.buttonEnlever = new System.Windows.Forms.Button();
            this.labelCible = new System.Windows.Forms.Label();
            this.buttonHaut = new System.Windows.Forms.Button();
            this.buttonBas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxSource
            // 
            this.comboBoxSource.FormattingEnabled = true;
            this.comboBoxSource.Location = new System.Drawing.Point(12, 27);
            this.comboBoxSource.Name = "comboBoxSource";
            this.comboBoxSource.Size = new System.Drawing.Size(121, 23);
            this.comboBoxSource.TabIndex = 0;
            this.comboBoxSource.DropDown += new System.EventHandler(this.comboBoxSource_DropDown);
            this.comboBoxSource.SelectedIndexChanged += new System.EventHandler(this.comboBoxSource_SelectedIndexChanged);
            // 
            // labelSource
            // 
            this.labelSource.AutoSize = true;
            this.labelSource.Location = new System.Drawing.Point(12, 9);
            this.labelSource.Name = "labelSource";
            this.labelSource.Size = new System.Drawing.Size(43, 15);
            this.labelSource.TabIndex = 1;
            this.labelSource.Text = "Source";
            // 
            // listBoxCible
            // 
            this.listBoxCible.FormattingEnabled = true;
            this.listBoxCible.ItemHeight = 15;
            this.listBoxCible.Location = new System.Drawing.Point(220, 27);
            this.listBoxCible.Name = "listBoxCible";
            this.listBoxCible.Size = new System.Drawing.Size(120, 154);
            this.listBoxCible.TabIndex = 2;
            this.listBoxCible.SelectedIndexChanged += new System.EventHandler(this.listBoxCible_SelectedIndexChanged);
            // 
            // buttonAjouter
            // 
            this.buttonAjouter.Enabled = false;
            this.buttonAjouter.Location = new System.Drawing.Point(139, 27);
            this.buttonAjouter.Name = "buttonAjouter";
            this.buttonAjouter.Size = new System.Drawing.Size(75, 23);
            this.buttonAjouter.TabIndex = 3;
            this.buttonAjouter.Text = ">";
            this.buttonAjouter.UseVisualStyleBackColor = true;
            this.buttonAjouter.Click += new System.EventHandler(this.buttonAjouter_Click);
            // 
            // buttonAjouterTout
            // 
            this.buttonAjouterTout.Location = new System.Drawing.Point(139, 56);
            this.buttonAjouterTout.Name = "buttonAjouterTout";
            this.buttonAjouterTout.Size = new System.Drawing.Size(75, 23);
            this.buttonAjouterTout.TabIndex = 4;
            this.buttonAjouterTout.Text = ">>";
            this.buttonAjouterTout.UseVisualStyleBackColor = true;
            this.buttonAjouterTout.Click += new System.EventHandler(this.buttonAjouterTout_Click);
            // 
            // buttonEnleverTout
            // 
            this.buttonEnleverTout.Enabled = false;
            this.buttonEnleverTout.Location = new System.Drawing.Point(139, 158);
            this.buttonEnleverTout.Name = "buttonEnleverTout";
            this.buttonEnleverTout.Size = new System.Drawing.Size(75, 23);
            this.buttonEnleverTout.TabIndex = 5;
            this.buttonEnleverTout.Text = "<<";
            this.buttonEnleverTout.UseVisualStyleBackColor = true;
            this.buttonEnleverTout.Click += new System.EventHandler(this.buttonEnleverTout_Click);
            // 
            // buttonEnlever
            // 
            this.buttonEnlever.Enabled = false;
            this.buttonEnlever.Location = new System.Drawing.Point(139, 129);
            this.buttonEnlever.Name = "buttonEnlever";
            this.buttonEnlever.Size = new System.Drawing.Size(75, 23);
            this.buttonEnlever.TabIndex = 6;
            this.buttonEnlever.Text = "<";
            this.buttonEnlever.UseVisualStyleBackColor = true;
            this.buttonEnlever.Click += new System.EventHandler(this.buttonEnlever_Click);
            // 
            // labelCible
            // 
            this.labelCible.AutoSize = true;
            this.labelCible.Location = new System.Drawing.Point(220, 9);
            this.labelCible.Name = "labelCible";
            this.labelCible.Size = new System.Drawing.Size(34, 15);
            this.labelCible.TabIndex = 7;
            this.labelCible.Text = "Cible";
            // 
            // buttonHaut
            // 
            this.buttonHaut.Enabled = false;
            this.buttonHaut.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonHaut.Location = new System.Drawing.Point(239, 187);
            this.buttonHaut.Name = "buttonHaut";
            this.buttonHaut.Size = new System.Drawing.Size(38, 23);
            this.buttonHaut.TabIndex = 8;
            this.buttonHaut.Text = "↑";
            this.buttonHaut.UseVisualStyleBackColor = true;
            this.buttonHaut.Click += new System.EventHandler(this.buttonHaut_Click);
            // 
            // buttonBas
            // 
            this.buttonBas.Enabled = false;
            this.buttonBas.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonBas.Location = new System.Drawing.Point(283, 187);
            this.buttonBas.Name = "buttonBas";
            this.buttonBas.Size = new System.Drawing.Size(38, 23);
            this.buttonBas.TabIndex = 9;
            this.buttonBas.Text = "↓";
            this.buttonBas.UseVisualStyleBackColor = true;
            this.buttonBas.Click += new System.EventHandler(this.buttonBas_Click);
            // 
            // FormListBoxEtComboBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 216);
            this.Controls.Add(this.buttonBas);
            this.Controls.Add(this.buttonHaut);
            this.Controls.Add(this.labelCible);
            this.Controls.Add(this.buttonEnlever);
            this.Controls.Add(this.buttonEnleverTout);
            this.Controls.Add(this.buttonAjouterTout);
            this.Controls.Add(this.buttonAjouter);
            this.Controls.Add(this.listBoxCible);
            this.Controls.Add(this.labelSource);
            this.Controls.Add(this.comboBoxSource);
            this.Name = "FormListBoxEtComboBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Les listes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormListBoxEtComboBox_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox comboBoxSource;
        private Label labelSource;
        private ListBox listBoxCible;
        private Button buttonAjouter;
        private Button buttonAjouterTout;
        private Button buttonEnleverTout;
        private Button buttonEnlever;
        private Label labelCible;
        private Button buttonHaut;
        private Button buttonBas;
    }
}