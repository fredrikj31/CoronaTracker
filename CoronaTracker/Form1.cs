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

		private void buttonSearch_Click(object sender, EventArgs e) {

			this.updateImage(countryName: "Denmark");

		}

		private void buttonGlobal_Click(object sender, EventArgs e) {
			pictureBoxCountry.Image = Properties.Resources.Webp_net_resizeimage;
			pictureBoxCountry.Refresh();

			labelCountry.Text = "Global";

			track.getGlobalStats();
		}


		private void updateTexts(string countryName, int totalCases, int newCases, int recoveredPersons) {

		}

		private void updateImage(string countryName) {
			string countryCode = track.getCountryCode(countryName);

			if (countryCode == "Not Found") {
				MessageBox.Show("The country code was not found. \n Please check your spelling for mistakes", "Country Name Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			pictureBoxCountry.Load("https://www.countryflags.io/"+ countryCode +"/flat/64.png");
		}
	}
}
