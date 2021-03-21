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
			

			
		}

		private void button1_Click(object sender, EventArgs e) {
			track.getGlobalStats();
			this.updateImage(countryName: "Denmark");
		}


		private void updateTexts(string countryName, int totalCases, int newCases, int recoveredPersons) {

		}

		private void updateImage(string countryName) {
			string path = System.IO.Path.Combine(Environment.CurrentDirectory, @"..\..");
			var filename = Path.Combine(path, "CountryCode.json");

			string countryCode = "";

			if (File.Exists(filename)) {
				string textContent = System.IO.File.ReadAllText(filename);
				Debug.WriteLine(textContent);

				JsonDocument doc = JsonDocument.Parse(textContent);
				JsonElement root = doc.RootElement;

				Debug.WriteLine(root.GetProperty("countries"));
			} else {

			}

			//pictureBoxCountry.Load("");
		}
	}
}
