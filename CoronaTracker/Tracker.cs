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
		WebClient webClient;


		public Tracker() {
			ServicePointManager.Expect100Continue = true;
			ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

			webClient = new WebClient();

			webClient.Encoding = Encoding.UTF8;
		}


		public Tracking getGlobalStats() {
			string apiCall = this.webClient.DownloadString("https://api.covid19api.com/summary");

			Tracking result = new Tracking();

			JsonDocument doc = JsonDocument.Parse(apiCall);
			JsonElement root = doc.RootElement;

			Debug.WriteLine(root.GetProperty("Global"));

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

		public Tracking getRangeStats(string inputCountry, string startDate, string endDate) {
			Tracking result = new Tracking();

			int startTotalConfirmed = 0;
			int endTotalConfirmed = 0;
			int startTotalDeaths = 0;
			int endTotalDeaths = 0;
			int startTotalRecovered = 0;
			int endTotalRecovered = 0;

			string apiCall = "";

			try {
				apiCall = this.webClient.DownloadString("https://api.covid19api.com/country/" + inputCountry.ToLower().Replace(" ", "-") + "?from=" + startDate + "&to=" + endDate);
			} catch (Exception) {
				MessageBox.Show("No stats for that country in that date range. \nPlease choose another date range", "Date Range Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return result;
			}

			JsonDocument doc = JsonDocument.Parse(apiCall);
			JsonElement root = doc.RootElement;

			JsonElement.ArrayEnumerator results = root.EnumerateArray();

			foreach (var tempResult in results) {
				if (DateTime.Parse(tempResult.GetProperty("Date").GetString()).ToString("yyyy-MM-dd") == startDate) {
					startTotalConfirmed += tempResult.GetProperty("Confirmed").GetInt32();
					startTotalDeaths += tempResult.GetProperty("Deaths").GetInt32();
					startTotalRecovered += tempResult.GetProperty("Recovered").GetInt32();
					continue;
				} else if (DateTime.Parse(tempResult.GetProperty("Date").GetString()).ToString("yyyy-MM-dd") == endDate) {
					endTotalConfirmed += tempResult.GetProperty("Confirmed").GetInt32();
					endTotalDeaths += tempResult.GetProperty("Deaths").GetInt32();
					endTotalRecovered += tempResult.GetProperty("Recovered").GetInt32();
					continue;
				} else {
					continue;
				}
			}

			int totalConfirmed = endTotalConfirmed - startTotalConfirmed;
			int totalDeaths = endTotalDeaths - startTotalDeaths;
			int totalRecovered = endTotalRecovered - startTotalRecovered;

			result.countryName = inputCountry;
			result.dateTracked = startDate + " to " + endDate;
			result.newConfirmed = 0;
			result.newDeaths = 0;
			result.newRecovered = 0;
			result.totalConfirmed = totalConfirmed;
			result.totalDeaths = totalDeaths;
			result.totalRecovered = totalRecovered;


			return result;
		}

		public Tracking getOverallStats(string inputCountry) {

			JsonElement resultCountry = new JsonElement();
			Tracking returnResult = new Tracking();

			string apiCall = this.webClient.DownloadString("https://api.covid19api.com/summary");

			JsonDocument doc = JsonDocument.Parse(apiCall);
			JsonElement root = doc.RootElement;


			JsonElement.ArrayEnumerator countries = root.GetProperty("Countries").EnumerateArray();

			foreach (var country in countries) {
				if (country.GetProperty("Slug").GetString() == inputCountry.ToLower().Replace(" ", "-")) {
					resultCountry = country;
					break;
				} else {
					continue;
				}
			}

			// Check if country was found
			if (resultCountry.ValueKind.ToString() == "Undefined") {
				return returnResult;
			}

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

		public string getCountryCode(string countryName) {
			string path = Path.Combine(Environment.CurrentDirectory, @"..\..");
			var filename = Path.Combine(path, "CountryCode.json");

			string countryCode = "Not Found";

			if (File.Exists(filename)) {
				string textContent = File.ReadAllText(filename);

				JsonDocument doc = JsonDocument.Parse(textContent);
				JsonElement root = doc.RootElement;

				JsonElement countryList = root.GetProperty("countries");

				foreach (var item in countryList.EnumerateArray()) {
					if (item.GetProperty("name").GetString() == countryName) {
						countryCode = item.GetProperty("code").GetString();
						break;
					} else {
						continue;
					}
				}
			} else {
				MessageBox.Show("The country list file does not exist in the current project. \n Contact Fredrik Johansen for the fix.", "File Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			return countryCode;
		}

	}
}
