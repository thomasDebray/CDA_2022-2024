namespace WinFormsAppComposantsDeDefilement
{
    partial class FormComposantsDeDefilement
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
            this.labelRouge = new System.Windows.Forms.Label();
            this.labelVert = new System.Windows.Forms.Label();
            this.Bleu = new System.Windows.Forms.Label();
            this.hScrollBarRouge = new System.Windows.Forms.HScrollBar();
            this.hScrollBarVert = new System.Windows.Forms.HScrollBar();
            this.hScrollBarBleu = new System.Windows.Forms.HScrollBar();
            this.numericUpDownRouge = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownVert = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownBleu = new System.Windows.Forms.NumericUpDown();
            this.panelRouge = new System.Windows.Forms.Panel();
            this.panelVert = new System.Windows.Forms.Panel();
            this.panelBleu = new System.Windows.Forms.Panel();
            this.panelResultat = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRouge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVert)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBleu)).BeginInit();
            this.SuspendLayout();
            // 
            // labelRouge
            // 
            this.labelRouge.AutoSize = true;
            this.labelRouge.Location = new System.Drawing.Point(12, 9);
            this.labelRouge.Name = "labelRouge";
            this.labelRouge.Size = new System.Drawing.Size(41, 15);
            this.labelRouge.TabIndex = 0;
            this.labelRouge.Text = "Rouge";
            // 
            // labelVert
            // 
            this.labelVert.AutoSize = true;
            this.labelVert.Location = new System.Drawing.Point(12, 43);
            this.labelVert.Name = "labelVert";
            this.labelVert.Size = new System.Drawing.Size(27, 15);
            this.labelVert.TabIndex = 1;
            this.labelVert.Text = "Vert";
            // 
            // Bleu
            // 
            this.Bleu.AutoSize = true;
            this.Bleu.Location = new System.Drawing.Point(12, 77);
            this.Bleu.Name = "Bleu";
            this.Bleu.Size = new System.Drawing.Size(30, 15);
            this.Bleu.TabIndex = 2;
            this.Bleu.Text = "Bleu";
            // 
            // hScrollBarRouge
            // 
            this.hScrollBarRouge.Location = new System.Drawing.Point(56, 9);
            this.hScrollBarRouge.Name = "hScrollBarRouge";
            this.hScrollBarRouge.Size = new System.Drawing.Size(152, 17);
            this.hScrollBarRouge.TabIndex = 3;
            this.hScrollBarRouge.ValueChanged += new System.EventHandler(this.hScrollBarRouge_ValueChanged);
            // 
            // hScrollBarVert
            // 
            this.hScrollBarVert.Location = new System.Drawing.Point(56, 43);
            this.hScrollBarVert.Name = "hScrollBarVert";
            this.hScrollBarVert.Size = new System.Drawing.Size(152, 17);
            this.hScrollBarVert.TabIndex = 4;
            this.hScrollBarVert.ValueChanged += new System.EventHandler(this.hScrollBarVert_ValueChanged);
            // 
            // hScrollBarBleu
            // 
            this.hScrollBarBleu.Location = new System.Drawing.Point(56, 77);
            this.hScrollBarBleu.Name = "hScrollBarBleu";
            this.hScrollBarBleu.Size = new System.Drawing.Size(152, 17);
            this.hScrollBarBleu.TabIndex = 5;
            this.hScrollBarBleu.ValueChanged += new System.EventHandler(this.hScrollBarBleu_ValueChanged);
            // 
            // numericUpDownRouge
            // 
            this.numericUpDownRouge.Location = new System.Drawing.Point(211, 7);
            this.numericUpDownRouge.Name = "numericUpDownRouge";
            this.numericUpDownRouge.Size = new System.Drawing.Size(120, 23);
            this.numericUpDownRouge.TabIndex = 6;
            this.numericUpDownRouge.ValueChanged += new System.EventHandler(this.numericUpDownRouge_ValueChanged);
            // 
            // numericUpDownVert
            // 
            this.numericUpDownVert.Location = new System.Drawing.Point(211, 43);
            this.numericUpDownVert.Name = "numericUpDownVert";
            this.numericUpDownVert.Size = new System.Drawing.Size(120, 23);
            this.numericUpDownVert.TabIndex = 7;
            this.numericUpDownVert.ValueChanged += new System.EventHandler(this.numericUpDownVert_ValueChanged);
            // 
            // numericUpDownBleu
            // 
            this.numericUpDownBleu.Location = new System.Drawing.Point(211, 77);
            this.numericUpDownBleu.Name = "numericUpDownBleu";
            this.numericUpDownBleu.Size = new System.Drawing.Size(120, 23);
            this.numericUpDownBleu.TabIndex = 8;
            this.numericUpDownBleu.ValueChanged += new System.EventHandler(this.numericUpDownBleu_ValueChanged);
            // 
            // panelRouge
            // 
            this.panelRouge.BackColor = System.Drawing.Color.Black;
            this.panelRouge.Location = new System.Drawing.Point(337, 7);
            this.panelRouge.Name = "panelRouge";
            this.panelRouge.Size = new System.Drawing.Size(59, 23);
            this.panelRouge.TabIndex = 9;
            // 
            // panelVert
            // 
            this.panelVert.BackColor = System.Drawing.Color.Black;
            this.panelVert.Location = new System.Drawing.Point(337, 43);
            this.panelVert.Name = "panelVert";
            this.panelVert.Size = new System.Drawing.Size(59, 23);
            this.panelVert.TabIndex = 10;
            // 
            // panelBleu
            // 
            this.panelBleu.BackColor = System.Drawing.Color.Black;
            this.panelBleu.Location = new System.Drawing.Point(337, 77);
            this.panelBleu.Name = "panelBleu";
            this.panelBleu.Size = new System.Drawing.Size(59, 23);
            this.panelBleu.TabIndex = 11;
            // 
            // panelResultat
            // 
            this.panelResultat.Location = new System.Drawing.Point(12, 106);
            this.panelResultat.Name = "panelResultat";
            this.panelResultat.Size = new System.Drawing.Size(384, 61);
            this.panelResultat.TabIndex = 12;
            // 
            // FormComposantsDeDefilement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 175);
            this.Controls.Add(this.panelResultat);
            this.Controls.Add(this.panelBleu);
            this.Controls.Add(this.panelVert);
            this.Controls.Add(this.panelRouge);
            this.Controls.Add(this.numericUpDownBleu);
            this.Controls.Add(this.numericUpDownVert);
            this.Controls.Add(this.numericUpDownRouge);
            this.Controls.Add(this.hScrollBarBleu);
            this.Controls.Add(this.hScrollBarVert);
            this.Controls.Add(this.hScrollBarRouge);
            this.Controls.Add(this.Bleu);
            this.Controls.Add(this.labelVert);
            this.Controls.Add(this.labelRouge);
            this.Name = "FormComposantsDeDefilement";
            this.Text = "Defilement";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRouge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVert)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBleu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelRouge;
        private Label labelVert;
        private Label Bleu;
        private HScrollBar hScrollBarRouge;
        private HScrollBar hScrollBarVert;
        private HScrollBar hScrollBarBleu;
        private NumericUpDown numericUpDownRouge;
        private NumericUpDown numericUpDownVert;
        private NumericUpDown numericUpDownBleu;
        private Panel panelRouge;
        private Panel panelVert;
        private Panel panelBleu;
        private Panel panelResultat;
    }
}