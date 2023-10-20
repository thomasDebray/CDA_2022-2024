namespace WinFormsAppFigure
{
	partial class FormFigure
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
			panelFigure = new Panel();
			SuspendLayout();
			// 
			// panelFigure
			// 
			panelFigure.Location = new Point(36, 33);
			panelFigure.Name = "panelFigure";
			panelFigure.Size = new Size(718, 378);
			panelFigure.TabIndex = 0;
			panelFigure.Paint += panel1_Paint;
			// 
			// FormFigure
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(panelFigure);
			Name = "FormFigure";
			Text = "FormFigure";
			ResumeLayout(false);
		}

		#endregion

		private Panel panelFigure;
	}
}