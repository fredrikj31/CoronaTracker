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

		public DateTime dateTracked;
		public string countryName;
	}

	class Tracker {
		WebClient webClient = new WebClient();


		public Tracker() {
			ServicePointManager.Expect100Continue = true;
			ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

			webClient = new WebClient();

			webClient.Encoding = Encoding.UTF8;
		}


		public JsonElement getGlobalStats() {
			string result = this.webClient.DownloadString("https://api.covid19api.com/summary");

			JsonDocument doc = JsonDocument.Parse(result);
			JsonElement root = doc.RootElement;

			Debug.WriteLine(root.GetProperty("Global"));

			return root.GetProperty("Global");
		}

		public void getCountryStats(string inputCountry) {
			string result = this.webClient.DownloadString("https://api.covid19api.com/summary");

			JsonDocument doc = JsonDocument.Parse(result);
			JsonElement root = doc.RootElement;
		}

		public string getCountryCode(string countryName) {
			string path = System.IO.Path.Combine(Environment.CurrentDirectory, @"..\..");
			var filename = Path.Combine(path, "CountryCode.json");

			string countryCode = "Not Found";

			if (File.Exists(filename)) {
				string textContent = System.IO.File.ReadAllText(filename);

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
