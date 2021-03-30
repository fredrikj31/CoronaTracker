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

		/// <summary>
		/// Enables the search WITHOUT date button to work, here is where we grab the search text,
		/// and make the query to the scraper script. Then returning the result to the format scripts.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void buttonSearchWithoutDate_Click(object sender, EventArgs e) {

			string inputCountry = textBoxSearch.Text;

			Tracking result = track.getOverallStats(inputCountry: textBoxSearch.Text);

			if (this.updateImage(countryName: result.countryName)) {
				this.updateTexts(result.countryName, result.newConfirmed, result.totalConfirmed, result.newDeaths, result.totalDeaths, result.newRecovered, result.totalRecovered, result.dateTracked);
			} else {
				textBoxSearch.Text = "";
			}

		}

		/// <summary>
		/// Runs when the global button is pressed. Here will we grab the overall stats from the globe, then returning the data.
		/// Then formatting the result in the different textboxes.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void buttonGlobal_Click(object sender, EventArgs e) {
			// Querying the global stats from the tracker class
			Tracking result = track.getGlobalStats();

			// Getting the results, then updating the labels with the stats.
			this.updateTexts(result.countryName, result.newConfirmed, result.totalConfirmed, result.newDeaths, result.totalDeaths, result.newRecovered, result.totalRecovered, result.dateTracked);
			
			// Setting the image to a globe, because it's the global stats.
			// I was not getting this image from the api, because it does not support a globe image.
			pictureBoxCountry.Image = Properties.Resources.Webp_net_resizeimage;
			// Then refresing the image to see the new updated image.
			pictureBoxCountry.Refresh();
		}

		/// <summary>
		/// Main function that formats the data, and transfering the data to the different labels.
		/// </summary>
		/// <param name="countryName">The country's name. If global stats selected, then insert "Global".</param>
		/// <param name="newConfirmed">The number of new confirmed cases with COVID-19.</param>
		/// <param name="totalConfirmed">The total of cases confirmed with COVID-19.</param>
		/// <param name="newDeaths">The number of new deaths in the past 24 hours.</param>
		/// <param name="totalDeaths">The total number of deaths.</param>
		/// <param name="newRecovered">The number of recovered persons in the past 24 hours.</param>
		/// <param name="totalRecovered">The total number of recovered personen.</param>
		/// <param name="dateTracked">The date the stats were tracked, formatted in the US standard.</param>
		private void updateTexts(string countryName, int newConfirmed, int totalConfirmed, int newDeaths, int totalDeaths, int newRecovered, int totalRecovered, string dateTracked) {

			// Setting the country label to the selected country name.
			labelCountry.Text = countryName;
			// Stripping the time from the date, and placing the "-" with "/"
			labelDate.Text = dateTracked.ToString().Replace("T", " ").Replace("Z", "").Replace("-", "/").Split('.')[0];

			// Formatting the number stats so the format is: 123.456.
			labelNewCases.Text = String.Format("{0:n0}", newConfirmed);
			labelTotalCases.Text = String.Format("{0:n0}", totalConfirmed);
			labelNewDeaths.Text = String.Format("{0:n0}", newDeaths);
			labelTotalDeaths.Text = String.Format("{0:n0}", totalDeaths);
			labelNewRecovered.Text = String.Format("{0:n0}", newRecovered);
			labelTotalRecovered.Text = String.Format("{0:n0}", totalRecovered);

		}

		/// <summary>
		/// Getting the image from an api, then updating the image.
		/// </summary>
		/// <param name="countryName">The country's name.</param>
		/// <returns></returns>
		private bool updateImage(string countryName) {
			// Getting the country code from the attached file, that contains all the country codes.
			string countryCode = track.getCountryCode(countryName);

			// If the country code returned "Not Found" then throw an error.
			if (countryCode == "Not Found") {
				MessageBox.Show("The country code was not found. \nPlease check your spelling for mistakes", "Country Name Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

				return false;
			} else {
				// Updating the image with the image from the api, in the format 64x64 pixels, and the flat format.
				pictureBoxCountry.Load("https://www.countryflags.io/" + countryCode + "/flat/64.png");
				
				return true;
			}
		}

		/// <summary>
		/// Runs when the search button WITH date is clicked.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void buttonSearchWithDate_Click(object sender, EventArgs e) {

			// Getting the search query from the textbox, then setting the value to the inputCountry.
			string inputCountry = textBoxSearch.Text;

			// Adding 2 different formats because of api endpoint and visualization.
			string startDateAPI = monthCalendar.SelectionRange.Start.ToString("yyyy-MM-dd");
			string endDateAPI = monthCalendar.SelectionRange.End.ToString("yyyy-MM/dd");

			string startDate = monthCalendar.SelectionRange.Start.ToString("dd/MM/yyyy");
			string endDate = monthCalendar.SelectionRange.End.ToString("dd/MM/yyyy");

			// Querying the country code, to get the data from the api.
			Tracking result = track.getRangeStats(inputCountry: textBoxSearch.Text, startDate: startDateAPI, endDate: endDateAPI);

			// Updates the image if the function returns true.
			if (this.updateImage(countryName: textBoxSearch.Text)) {
				// Update the labels with the stats.
				this.updateTexts(result.countryName, result.newConfirmed, result.totalConfirmed, result.newDeaths, result.totalDeaths, result.newRecovered, result.totalRecovered, startDate + " to " + endDate);
			} else {
				// If the country was not found, then empty the search text field. The function returns an error code.
				textBoxSearch.Text = "";
			}

		}

		/// <summary>
		/// When the form loads, it sets the max date on the month calender to tommorrow.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Form1_Load(object sender, EventArgs e) {
			monthCalendar.MaxDate = DateTime.Now.AddDays(1);
		}
	}
}
