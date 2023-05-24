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
	public partial class UserControlStats : UserControl
	{
		private string valeurDefautGlobal;
		private string valeurDefautHoraire;
		public UserControlStats()
		{
			InitializeComponent();
		}

		public string Nom { get => groupBoxProduction.Text; set => groupBoxProduction.Text = value; }

		public string ValeurNbCaisse { get =>  textBoxNbCaisse.Text; set => textBoxNbCaisse.Text = value; }
		public string ValeurDefautGlobal { get => textBoxTauxDefautGlobal.Text; set => textBoxTauxDefautGlobal.Text = value; }
		public string ValeurDefautHoraire { get => textBoxTauxDefautHeure.Text; set => textBoxTauxDefautHeure.Text = value; }
	}
}
