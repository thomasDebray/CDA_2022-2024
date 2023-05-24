using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsControlLibraryToutEmbal
{
	public partial class UserControlProgression : UserControl
	{
		public UserControlProgression()
		{
			InitializeComponent();
		}

		public string LabelProdNom { get => labelNomProd.Text; set => labelNomProd.Text = value; }
		public int ProgressionMax { get => progressBarProdProgression.Maximum; set => progressBarProdProgression.Maximum = value; }
		public int Valeur { get => progressBarProdProgression.Value; set => progressBarProdProgression.Value = value; }
	}
}
