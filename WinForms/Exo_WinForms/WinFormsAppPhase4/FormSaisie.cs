using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsAppCheckBoxEtRadioButton;

namespace WinFormsAppPhase4
{
	public partial class FormSaisie : Form
	{

		public string Texte { get => this.textBoxSaisie.Text; }

		public FormSaisie()
		{
			InitializeComponent();
		}



		private void buttonValider_Click(object sender, EventArgs e)
		{
			//WindowApp newFeuille = new WindowApp();
			//newFeuille.MdiParent = ;
			//newFeuille.Show();
			//Phase4Mere toolStripStatusLabelOperation.Text = "Check box";
			this.Close();
		}
	}
}
