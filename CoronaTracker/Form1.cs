using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoronaTracker {
	public partial class Form1 : Form {

		Tracker track = new Tracker();

		public Form1() {
			InitializeComponent();
		}

		private void buttonSearchWithoutDate_Click(object sender, EventArgs e) {

			string inputCountry = textBoxSearch.Text;

			Tracking result = track.getOverallStats(inputCountry: textBoxSearch.Text);

			if (this.updateImage(countryName: result.countryName)) {
				this.updateTexts(result.countryName, result.newConfirmed, result.totalConfirmed, result.newDeaths, result.totalDeaths, result.newRecovered, result.totalRecovered, result.dateTracked);
			} else {
				textBoxSearch.Text = "";
			}

		}

		private void buttonGlobal_Click(object sender, EventArgs e) {
			Tracking result = track.getGlobalStats();

			this.updateTexts(result.countryName, result.newConfirmed, result.totalConfirmed, result.newDeaths, result.totalDeaths, result.newRecovered, result.totalRecovered, result.dateTracked);
			pictureBoxCountry.Image = Properties.Resources.Webp_net_resizeimage;
			pictureBoxCountry.Refresh();
		}


		private void updateTexts(string countryName, int newConfirmed, int totalConfirmed, int newDeaths, int totalDeaths, int newRecovered, int totalRecovered, DateTime dateTracked) {

			labelCountry.Text = countryName;
			labelDate.Text = dateTracked.ToString().Replace("T", " ").Replace("Z", "").Replace("-", "/");

			labelNewCases.Text = String.Format("{0:n0}", newConfirmed);
			labelTotalCases.Text = String.Format("{0:n0}", totalConfirmed);
			labelNewDeaths.Text = String.Format("{0:n0}", newDeaths);
			labelTotalDeaths.Text = String.Format("{0:n0}", totalDeaths);
			labelNewRecovered.Text = String.Format("{0:n0}", newRecovered);
			labelTotalRecovered.Text = String.Format("{0:n0}", totalRecovered);

		}

		private bool updateImage(string countryName) {
			string countryCode = track.getCountryCode(countryName);

			if (countryCode == "Not Found") {
				MessageBox.Show("The country code was not found. \nPlease check your spelling for mistakes", "Country Name Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

				return false;
			} else {
				pictureBoxCountry.Load("https://www.countryflags.io/" + countryCode + "/flat/64.png");
				
				return true;
			}
		}
	}
}
