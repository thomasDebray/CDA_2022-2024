namespace ExemplePatternCommand
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelDessin = new Panel();
            groupBox1 = new GroupBox();
            labelPositionCharlieY = new Label();
            labelPositionCharlieX = new Label();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            groupBox2 = new GroupBox();
            buttonValider = new Button();
            label5 = new Label();
            numericNbPas = new NumericUpDown();
            radioButtonBot = new RadioButton();
            radioButtonUp = new RadioButton();
            radioButtonRight = new RadioButton();
            radioButtonLeft = new RadioButton();
            buttonUndo = new Button();
            buttonRedo = new Button();
            listBoxAnnuler = new ListBox();
            listBoxRepeter = new ListBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericNbPas).BeginInit();
            SuspendLayout();
            // 
            // panelDessin
            // 
            panelDessin.Location = new Point(26, 12);
            panelDessin.Name = "panelDessin";
            panelDessin.Size = new Size(512, 512);
            panelDessin.TabIndex = 0;
            panelDessin.Paint += panelDessiner_Paint;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(labelPositionCharlieY);
            groupBox1.Controls.Add(labelPositionCharlieX);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(556, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(181, 171);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Charlie";
            // 
            // labelPositionCharlieY
            // 
            labelPositionCharlieY.AutoSize = true;
            labelPositionCharlieY.Location = new Point(107, 123);
            labelPositionCharlieY.Name = "labelPositionCharlieY";
            labelPositionCharlieY.Size = new Size(13, 15);
            labelPositionCharlieY.TabIndex = 3;
            labelPositionCharlieY.Text = "0";
            // 
            // labelPositionCharlieX
            // 
            labelPositionCharlieX.AutoSize = true;
            labelPositionCharlieX.Location = new Point(107, 74);
            labelPositionCharlieX.Name = "labelPositionCharlieX";
            labelPositionCharlieX.Size = new Size(13, 15);
            labelPositionCharlieX.TabIndex = 2;
            labelPositionCharlieX.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 123);
            label2.Name = "label2";
            label2.Size = new Size(17, 15);
            label2.TabIndex = 1;
            label2.Text = "Y:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 74);
            label1.Name = "label1";
            label1.Size = new Size(17, 15);
            label1.TabIndex = 0;
            label1.Text = "X:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(562, 365);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 5;
            label3.Text = "Annuler";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(883, 365);
            label4.Name = "label4";
            label4.Size = new Size(47, 15);
            label4.TabIndex = 6;
            label4.Text = "Repeter";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(buttonValider);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(numericNbPas);
            groupBox2.Controls.Add(radioButtonBot);
            groupBox2.Controls.Add(radioButtonUp);
            groupBox2.Controls.Add(radioButtonRight);
            groupBox2.Controls.Add(radioButtonLeft);
            groupBox2.Location = new Point(556, 207);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(407, 123);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Faire bouger Charlie";
            // 
            // buttonValider
            // 
            buttonValider.Location = new Point(6, 81);
            buttonValider.Name = "buttonValider";
            buttonValider.Size = new Size(368, 36);
            buttonValider.TabIndex = 6;
            buttonValider.Text = "EN ROUTE CHARLIE!";
            buttonValider.UseVisualStyleBackColor = true;
            buttonValider.Click += buttonValider_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 64);
            label5.Name = "label5";
            label5.Size = new Size(88, 15);
            label5.TabIndex = 5;
            label5.Text = "Nombre de pas";
            // 
            // numericNbPas
            // 
            numericNbPas.Location = new Point(107, 56);
            numericNbPas.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericNbPas.Name = "numericNbPas";
            numericNbPas.Size = new Size(258, 23);
            numericNbPas.TabIndex = 4;
            numericNbPas.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // radioButtonBot
            // 
            radioButtonBot.AutoSize = true;
            radioButtonBot.Location = new Point(306, 31);
            radioButtonBot.Name = "radioButtonBot";
            radioButtonBot.Size = new Size(59, 19);
            radioButtonBot.TabIndex = 3;
            radioButtonBot.TabStop = true;
            radioButtonBot.Text = "En bas";
            radioButtonBot.UseVisualStyleBackColor = true;
            // 
            // radioButtonUp
            // 
            radioButtonUp.AutoSize = true;
            radioButtonUp.Location = new Point(206, 31);
            radioButtonUp.Name = "radioButtonUp";
            radioButtonUp.Size = new Size(65, 19);
            radioButtonUp.TabIndex = 2;
            radioButtonUp.TabStop = true;
            radioButtonUp.Text = "En haut";
            radioButtonUp.UseVisualStyleBackColor = true;
            // 
            // radioButtonRight
            // 
            radioButtonRight.AutoSize = true;
            radioButtonRight.Location = new Point(106, 31);
            radioButtonRight.Name = "radioButtonRight";
            radioButtonRight.Size = new Size(67, 19);
            radioButtonRight.TabIndex = 1;
            radioButtonRight.TabStop = true;
            radioButtonRight.Text = "A droite";
            radioButtonRight.UseVisualStyleBackColor = true;
            // 
            // radioButtonLeft
            // 
            radioButtonLeft.AutoSize = true;
            radioButtonLeft.Location = new Point(6, 31);
            radioButtonLeft.Name = "radioButtonLeft";
            radioButtonLeft.Size = new Size(75, 19);
            radioButtonLeft.TabIndex = 0;
            radioButtonLeft.TabStop = true;
            radioButtonLeft.Text = "A gauche";
            radioButtonLeft.UseVisualStyleBackColor = true;
            // 
            // buttonUndo
            // 
            buttonUndo.Location = new Point(731, 352);
            buttonUndo.Name = "buttonUndo";
            buttonUndo.Size = new Size(55, 41);
            buttonUndo.TabIndex = 8;
            buttonUndo.Text = "←";
            buttonUndo.UseVisualStyleBackColor = true;
            buttonUndo.Click += buttonUndo_Click;
            // 
            // buttonRedo
            // 
            buttonRedo.Location = new Point(1011, 352);
            buttonRedo.Name = "buttonRedo";
            buttonRedo.Size = new Size(55, 41);
            buttonRedo.TabIndex = 9;
            buttonRedo.Text = "→";
            buttonRedo.UseVisualStyleBackColor = true;
            buttonRedo.Click += buttonRedo_Click;
            // 
            // listBoxAnnuler
            // 
            listBoxAnnuler.FormattingEnabled = true;
            listBoxAnnuler.ItemHeight = 15;
            listBoxAnnuler.Location = new Point(562, 399);
            listBoxAnnuler.Name = "listBoxAnnuler";
            listBoxAnnuler.Size = new Size(224, 229);
            listBoxAnnuler.TabIndex = 10;
            // 
            // listBoxRepeter
            // 
            listBoxRepeter.FormattingEnabled = true;
            listBoxRepeter.ItemHeight = 15;
            listBoxRepeter.Location = new Point(842, 399);
            listBoxRepeter.Name = "listBoxRepeter";
            listBoxRepeter.Size = new Size(224, 229);
            listBoxRepeter.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1169, 658);
            Controls.Add(listBoxAnnuler);
            Controls.Add(listBoxRepeter);
            Controls.Add(buttonRedo);
            Controls.Add(buttonUndo);
            Controls.Add(groupBox2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(groupBox1);
            Controls.Add(panelDessin);
            Name = "Form1";
            Text = "Charlie Pattern Command";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericNbPas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelDessin;
        private GroupBox groupBox1;
        private Label labelPositionCharlieX;
        private Label label2;
        private Label label1;
        private Label labelPositionCharlieY;
        private Label label3;
        private Label label4;
        private GroupBox groupBox2;
        private RadioButton radioButtonBot;
        private RadioButton radioButtonUp;
        private RadioButton radioButtonRight;
        private RadioButton radioButtonLeft;
        private Label label5;
        private NumericUpDown numericNbPas;
        private Button buttonValider;
        private Button buttonUndo;
        private Button buttonRedo;
        private ListBox listBoxAnnuler;
        private ListBox listBoxRepeter;
    }
}