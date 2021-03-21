using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

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

	}
}
