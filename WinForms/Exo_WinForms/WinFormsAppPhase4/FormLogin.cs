using ClassLibrary8Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAppPhase4
{
	public partial class FormLogin : Form
	{
		public string Login { get => this.textBoxLogin.Text; }
		public string Password { get => this.textBoxPassword.Text; }
		public FormLogin()
		{
			InitializeComponent();
		}

		private void buttonAnnuler_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void buttonOK_Click(object sender, EventArgs e)
		{
			if (Validation.LoginOk(textBoxLogin.Text,textBoxPassword.Text))
			{
				this.Close();
			}
			
		}
	}
}
