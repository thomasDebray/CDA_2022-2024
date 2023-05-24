using ClassLibraryCities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsAppCities.Models;

namespace WinFormsAppCities
{
	public partial class FormCity : Form
	{
		private CitiesContext dbContext;
		private List<CCity> cities;	
		public FormCity()
		{
			InitializeComponent();
			//Creer le context vers la source
			dbContext = new CitiesContext();
			//Chargement de la table Cities
			dbContext.Cities.Load<City>();
			//dbContext.Cities.Load();

			cities = new List<CCity>();
			//insert tous les cities

			//Realisation d'un binding entre la source de donnée Cities et le datagridview
			this.dataGridViewCities.DataSource = dbContext.Cities.Local.ToBindingList();

		}

		private void Trace(string message)
		{
			//textBoxConsole.Text += "-----------------------" + message + "------------------------" + Environment.NewLine;
			//dbContext.ChangeTracker.DetectChanges();
			//textBoxConsole.Text += dbContext.ChangeTracker.DebugView.LongView;
		}

		private void buttonAjouterUnCitY_Click(object sender, EventArgs e)
		{

			//City c = new City();
			//c.CityName = "PewJusteCity";
			//c.CountryCode = "PW";
			////Country country = new Country();
			////country.CountryCode = "PW";
			////country.CountryName = "PewPewLandLand";
			////c.CountryCodeNavigation = country;

			//Trace("Avant de l'avoir Add");
			//dbContext.Cities.Add(c);
			//Trace("Apres de l'avoir Add");

			//dbContext.SaveChanges();

			//Trace("Apres de avoir sauvegardé les changements: un INSERT à été réalisé sur la BD");


			FormUnCity f = new FormUnCity(dbContext);
			f.ShowDialog();
			this.dataGridViewCities.Refresh();
		}

		private void buttonSuprimerUnCity_Click(object sender, EventArgs e)
		{
			int id;
			bool idOk = int.TryParse(this.textBoxId.Text, out id);
			if (idOk)
			{
				City? cASupprimer = dbContext.Cities.Find(id);
				if (cASupprimer != null)
				{
					dbContext.Cities.Remove(cASupprimer);
					//Trace("Apres l'avoir Remove");

					dbContext.SaveChanges();
					//Trace("Apres avoir sauvegardé les changements: un DELETE à été réalisé sur la BD");
				}
			}
		}

		private void buttonSuprimerUnCity_Click2(object sender, EventArgs e)
		{
			// ne marche pas
			//https://stackoverflow.com/questions/16194162/entitystate-deleted-does-not-work-removeentity-does
			int id;
			bool idOk = int.TryParse(this.textBoxId.Text, out id);
			if (idOk)
			{
				City cityASupprimer = new City() { CityId = id };
				dbContext.Entry(cityASupprimer).State = EntityState.Deleted;

				//Trace("Apres l'avoir dit quel City à definir comme supprimer");

				dbContext.SaveChanges();
				//Trace("Apres avoir sauvegardé les changements: un DELETE à été réalisé sur la BD");
			}

		}


		private void buttonModifyUnCity_Click(object sender, EventArgs e)
		{
			int id;
			if (int.TryParse(this.textBoxId.Text, out id)&&dbContext.Cities.Find(id)!=null)
			{
				CCity monCity = new CCity(dbContext.Cities.Find(id).CityId, dbContext.Cities.Find(id).CityName, dbContext.Cities.Find(id).CountryCode);
				FormUnCity f = new FormUnCity(dbContext, monCity);
				f.ShowDialog();
				this.dataGridViewCities.Refresh();
			}
			//string nouveauNom = this.textBoxNom.Text;

				//City? cAModifier = dbContext.Cities.Find(id);
				//if (cAModifier != null)
				//{
				//	cAModifier.CityName = this.textBoxNom.Text;

				//	dbContext.Cities.Update(cAModifier);
				//	//Trace("Apres l'avoir Modifier");

				//	dbContext.SaveChanges();
				//	//Trace("Apres avoir sauvegardé les changements: un UPDATE à été réalisé sur la BD");
				//	this.dataGridViewCities.Refresh();
				//}
		}

		private void buttonSaveAll_Click(object sender, EventArgs e)
		{
			dbContext.SaveChanges();
			this.dataGridViewCities.Refresh();
		}

	}
}
