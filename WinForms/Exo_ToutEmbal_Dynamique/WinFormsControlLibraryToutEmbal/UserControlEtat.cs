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
	public partial class UserControlEtat : UserControl
	{
		public UserControlEtat()
		{
			InitializeComponent();
		}

		public string NomBoutonVert { get => buttonVert.Text; set => buttonVert.Text = value; }
		public string NomBoutonRouge { get => buttonRouge.Text; set => buttonRouge.Text = value; }
		public string NomBoutonOrange { get => buttonOrange.Text; set => buttonOrange.Text = value; }
		public bool ActifBoutonVert { get => buttonVert.Enabled; set => buttonVert.Enabled = value; }
		public bool ActifBoutonRouge { get => buttonRouge.Enabled; set => buttonRouge.Enabled = value; }
		public bool ActifBoutonOrange { get => buttonOrange.Enabled; set => buttonOrange.Enabled= value; }

		//public delegate void DlgClickBouton(object sender);
		public event EventHandler ClickBoutonVert;
		public event EventHandler ClickBoutonRouge;
		public event EventHandler ClickBoutonOrange;

		private void buttonVert_Click(object sender, EventArgs e)
		{
			if (ClickBoutonVert != null)
			{
				ClickBoutonVert(this,new EventArgs());
			}

		}

		private void buttonRouge_Click(object sender, EventArgs e)
		{
			if (ClickBoutonRouge != null)
			{
				ClickBoutonRouge(this,new EventArgs());
			}
		}

		private void buttonOrange_Click(object sender, EventArgs e)
		{
			if (ClickBoutonOrange != null)
			{
				ClickBoutonOrange(this, new EventArgs());
			}
		}
	}
}
