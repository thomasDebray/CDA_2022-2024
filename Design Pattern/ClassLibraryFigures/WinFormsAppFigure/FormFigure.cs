using ClassLibraryFigures;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAppFigure
{
	public partial class FormFigure : Form
	{
		private Figures dessin;
		public FormFigure()
		{
			InitializeComponent();
			dessin = new Figures(0, 0);

			dessin.Add(new Cercle(10, 10, 10));
			dessin.Add(new ClassLibraryFigures.Rectangle(100, 10, 20, 20));
		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{
			dessin.Accept(new ClassVisiteurDeFigurePourWinform(e.Graphics));

		}
	}
}
