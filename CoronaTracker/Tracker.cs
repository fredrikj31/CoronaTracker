using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoronaTracker {

	/// <summary>
	/// Making a new object with the relative information received from the api.
	/// </summary>
	public class Tracking {
		public int newRecovered;
		public int totalRecovered;
		public int newDeaths;
		public int totalDeaths;
		public int newConfirmed;
		public int totalConfirmed;

		public string dateTracked;
		public string countryName;
	}

	class Tracker {
		// Creating a new web client.
		WebClient webClient;

		public Tracker() {
			// Setting the security protocols for the webbrowser in the contructor.
			ServicePointManager.Expect100Continue = true;
			ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

			webClient = new WebClient();

			webClient.Encoding = Encoding.UTF8;
		}

		/// <summary>
		/// Getting the global stats from the api, then returning it in the choosen format.
		/// </summary>
		/// <returns>Returning the global stats, which includes 24 hour lookup, and total cases.</returns>
		public Tracking getGlobalStats() {
			// Downloads the result from the api endpoint.
			string apiCall = this.webClient.DownloadString("https://api.covid19api.com/summary");

			Tracking result = new Tracking();

			// Then parsing it into JSON, so it's easier to work with.
			JsonDocument doc = JsonDocument.Parse(apiCall);
			// Defining the root of the json document.
			JsonElement root = doc.RootElement;

			//Debug.WriteLine(root.GetProperty("Global"));

			// Setting the values of the different stats to the correspondent variabel in the object.
			result.countryName = "Global";
			result.dateTracked = root.GetProperty("Global").GetProperty("Date").GetString();
			result.newConfirmed = root.GetProperty("Global").GetProperty("NewConfirmed").GetInt32();
			result.totalConfirmed = root.GetProperty("Global").GetProperty("TotalConfirmed").GetInt32();
			result.newDeaths = root.GetProperty("Global").GetProperty("NewDeaths").GetInt32();
			result.totalDeaths = root.GetProperty("Global").GetProperty("TotalDeaths").GetInt32();
			result.newRecovered = root.GetProperty("Global").GetProperty("NewRecovered").GetInt32();
			result.totalRecovered = root.GetProperty("Global").GetProperty("TotalRecovered").GetInt32();

			return result;
		}

		/// <summary>
		/// Getting the stats in a selected date range of a country, then returning the result.
		/// </summary>
		/// <param name="inputCountry">The searched country's name.</param>
		/// <param name="startDate">The start date of the date range.</param>
		/// <param name="endDate">The last date of the date range.</param>
		/// <returns>Returns the stats of a giving country in a giving date range.</returns>
		public Tracking getRangeStats(string inputCountry, string startDate, string endDate) {
			// Creating the result object to store all the stats in.
			Tracking result = new Tracking();

			// Making some default values, if the api does not return some of the data.
			int startTotalConfirmed = 0;
			int endTotalConfirmed = 0;
			int startTotalDeaths = 0;
			int endTotalDeaths = 0;
			int startTotalRecovered = 0;
			int endTotalRecovered = 0;

			string apiCall = "";

			// Trying to call the api, if it returns an error, then show an error message to the user.
			try {
				// Downloading the result onto the client, then setting the apiCall to the response.
				apiCall = this.webClient.DownloadString("https://api.covid19api.com/country/" + inputCountry.ToLower().Replace(" ", "-") + "?from=" + startDate + "&to=" + endDate);
			} catch (Exception) {
				MessageBox.Show("No stats for that country in that date range. \nPlease choose another date range", "Date Range Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return result;
			}

			// Parse the result into JSON, so it gets easier to work with.
			JsonDocument doc = JsonDocument.Parse(apiCall);
			// Defining the root of the json document.
			JsonElement root = doc.RootElement;

			// Converting the root of the json document into a JSON element.
			JsonElement.ArrayEnumerator results = root.EnumerateArray();

			// Looping through the elements in the array of trackings.
			foreach (var tempResult in results) {
				// See if the date of the tracking match the start date of the selected range by the client.
				if (DateTime.Parse(tempResult.GetProperty("Date").GetString()).ToString("yyyy-MM-dd") == startDate) {
					// If it does, then add it to the total count of confirmed cases, deaths and recovered.
					startTotalConfirmed += tempResult.GetProperty("Confirmed").GetInt32();
					startTotalDeaths += tempResult.GetProperty("Deaths").GetInt32();
					startTotalRecovered += tempResult.GetProperty("Recovered").GetInt32();
					continue;
				// See if the date of the tracking matches the end date of the selected range by the client.
				} else if (DateTime.Parse(tempResult.GetProperty("Date").GetString()).ToString("yyyy-MM-dd") == endDate) {
					// If it does, then add it to the total count of confirmed cases, deaths and recovered.
					endTotalConfirmed += tempResult.GetProperty("Confirmed").GetInt32();
					endTotalDeaths += tempResult.GetProperty("Deaths").GetInt32();
					endTotalRecovered += tempResult.GetProperty("Recovered").GetInt32();
					continue;
				// Otherwise if the tracking does not match either of start or end date, then continue.
				} else {
					continue;
				}
			}

			// Calculting the total of new confirmed, deaths and recovered personen in the selected period.
			int totalConfirmed = endTotalConfirmed - startTotalConfirmed;
			int totalDeaths = endTotalDeaths - startTotalDeaths;
			int totalRecovered = endTotalRecovered - startTotalRecovered;

			// Setting the stats into the result object.
			result.countryName = inputCountry;
			// Format the date to a range, so it gets more readable.
			result.dateTracked = startDate + " to " + endDate;
			result.newConfirmed = 0;
			result.newDeaths = 0;
			result.newRecovered = 0;
			result.totalConfirmed = totalConfirmed;
			result.totalDeaths = totalDeaths;
			result.totalRecovered = totalRecovered;


			return result;
		}

		/// <summary>
		/// Gets the overall stats of a country.
		/// </summary>
		/// <param name="inputCountry">The name of the searched country.</param>
		/// <returns>Returns the stats of the country which includes a 24 hour overview, and total stats.</returns>
		public Tracking getOverallStats(string inputCountry) {

			// Creating the new JsonElement, which includes a list of all the countries.
			JsonElement resultCountry = new JsonElement();
			// Creating the result tracking object.
			Tracking returnResult = new Tracking();

			// Downloading the result from the api.
			string apiCall = this.webClient.DownloadString("https://api.covid19api.com/summary");

			// Parsing the data into a JsonDocument.
			JsonDocument doc = JsonDocument.Parse(apiCall);
			JsonElement root = doc.RootElement;

			// Making the JsonDocument into a array which we can loop through.
			JsonElement.ArrayEnumerator countries = root.GetProperty("Countries").EnumerateArray();

			// Loop through every country in the list of countries.
			foreach (var country in countries) {
				// Checkes if the name of the search country matches the the looped country's name.
				if (country.GetProperty("Slug").GetString() == inputCountry.ToLower().Replace(" ", "-")) {
					// If it does, then setting the result country to the looped country.
					resultCountry = country;
					break;
				// Else continue the loop.
				} else {
					continue;
				}
			}

			// Check if country was found
			if (resultCountry.ValueKind.ToString() == "Undefined") {
				return returnResult;
			}

			// Binding the stats to the result object, then returing the result object.
			returnResult.countryName = inputCountry;
			returnResult.dateTracked = resultCountry.GetProperty("Date").GetString();
			returnResult.totalConfirmed = resultCountry.GetProperty("TotalConfirmed").GetInt32();
			returnResult.newConfirmed = resultCountry.GetProperty("NewConfirmed").GetInt32();
			returnResult.totalDeaths = resultCountry.GetProperty("TotalDeaths").GetInt32();
			returnResult.newDeaths = resultCountry.GetProperty("NewDeaths").GetInt32();
			returnResult.totalRecovered = resultCountry.GetProperty("TotalRecovered").GetInt32();
			returnResult.newRecovered = resultCountry.GetProperty("NewRecovered").GetInt32();

			return returnResult;
		}

		/// <summary>
		/// Gets the correspondent country code to the inputted country.
		/// </summary>
		/// <param name="countryName">The name of the country.</param>
		/// <returns>The country code of the giving country.</returns>
		public string getCountryCode(string countryName) {
			// Getting the path of the included file which contains a list of countries.
			string path = Path.Combine(Environment.CurrentDirectory, @"..\..");
			var filename = Path.Combine(path, "CountryCode.json");

			string countryCode = "Not Found";

			// If the file exists, then continue.
			if (File.Exists(filename)) {
				// Reading the files content.
				string textContent = File.ReadAllText(filename);

				// Parsing the content of the file into JSON.
				JsonDocument doc = JsonDocument.Parse(textContent);
				JsonElement root = doc.RootElement;

				JsonElement countryList = root.GetProperty("countries");

				// Looping through the list of country codes.
				foreach (var item in countryList.EnumerateArray()) {
					// If the looped country's name matches the inputted country's name, then setting the looped items country code to a variable named country code
					if (item.GetProperty("name").GetString() == countryName) {
						countryCode = item.GetProperty("code").GetString();
						break;
					} else {
						continue;
					}
				}
			// Throws an error message if the file was not found.
			} else {
				MessageBox.Show("The country list file does not exist in the current project. \n Contact Fredrik Johansen for the fix.", "File Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			return countryCode;
		}

	}
}
