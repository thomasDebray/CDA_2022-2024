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
using ClassLibraryCities;
using Microsoft.EntityFrameworkCore;

namespace WinFormsAppCities
{
	public partial class FormUnCity : Form
	{
		CCity monCity;

		CitiesContext context;

		//mode creation
		public FormUnCity(CitiesContext context)
		{
			InitializeComponent();
			this.context = context;
			context.Countries.Load<Country>();
			this.comboBoxCountryCode.DataSource = this.context.Countries.Local.ToBindingList();
			this.comboBoxCountryCode.ValueMember = "CountryCode";
		}

		//mode modification
		public FormUnCity(CitiesContext context, CCity cityAModifier)
		{
			InitializeComponent();
			monCity = cityAModifier;
			this.context = context;
			context.Countries.Load<Country>();
			this.comboBoxCountryCode.DataSource = this.context.Countries.Local.ToBindingList();
			this.comboBoxCountryCode.ValueMember = "CountryCode";
			int index=0;
			for (int i = 0; i < this.comboBoxCountryCode.Items.Count; i++)
			{
				if (((Country)this.comboBoxCountryCode.Items[i]).CountryCode==monCity.CodeCountry)
				{
					index = i;
				}
			}
			this.comboBoxCountryCode.SelectedIndex = index;
			this.textBoxNomCity.Text = monCity.NomCity;

		}

		private void buttonValider_Click(object sender, EventArgs e)
		{
			if (monCity == null)
			{
				//creer l'objet metier
				monCity = new CCity(this.textBoxNomCity.Text, ((Country)this.comboBoxCountryCode.SelectedItem).CountryCode);

				//sauvegarder l'objet metier ds BD
				City city = new City();
				city.CityName = monCity.NomCity;
				city.CountryCode = monCity.CodeCountry;

				context.Cities.Add(city);
				context.SaveChanges();

				monCity.Id = city.CityId;
			}
			else
			{
				//mettre a jour object metier
				// monCity...
				monCity.NomCity = this.textBoxNomCity.Text;
				monCity.CodeCountry = ((Country)this.comboBoxCountryCode.SelectedItem).CountryCode;
				//persistance de l'object metier
				City? cAModifier = context.Cities.Find(monCity.Id);
				if (cAModifier != null)
				{
					cAModifier.CityName = this.monCity.NomCity;// monCity.cituName
					cAModifier.CountryCode = this.monCity.CodeCountry;

					context.Cities.Update(cAModifier);
					//Trace("Apres l'avoir Modifier");

					context.SaveChanges();
					//Trace("Apres avoir sauvegardé les changements: un UPDATE à été réalisé sur la BD");
					//this.dataGridViewCities.Refresh();
				}
			}
			this.Close();
		}
	}
}
