
namespace CoronaTracker {
	partial class Form1 {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.label1 = new System.Windows.Forms.Label();
			this.textBoxSearch = new System.Windows.Forms.TextBox();
			this.buttonSearchWithoutDate = new System.Windows.Forms.Button();
			this.labelCountry = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.pictureBoxCountry = new System.Windows.Forms.PictureBox();
			this.labelTotalCases = new System.Windows.Forms.Label();
			this.labelTotalRecovered = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.labelNewCases = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.buttonGlobal = new System.Windows.Forms.Button();
			this.labelDate = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.labelNewDeaths = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.labelTotalDeaths = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.labelNewRecovered = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.monthCalendar = new System.Windows.Forms.MonthCalendar();
			this.buttonSearchWithDate = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxCountry)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(0, 7);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(183, 25);
			this.label1.TabIndex = 1;
			this.label1.Text = "Search By Country:";
			// 
			// textBoxSearch
			// 
			this.textBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxSearch.Location = new System.Drawing.Point(184, 4);
			this.textBoxSearch.Name = "textBoxSearch";
			this.textBoxSearch.Size = new System.Drawing.Size(175, 30);
			this.textBoxSearch.TabIndex = 2;
			this.textBoxSearch.Text = "Denmark";
			// 
			// buttonSearchWithoutDate
			// 
			this.buttonSearchWithoutDate.Location = new System.Drawing.Point(365, 7);
			this.buttonSearchWithoutDate.Name = "buttonSearchWithoutDate";
			this.buttonSearchWithoutDate.Size = new System.Drawing.Size(104, 24);
			this.buttonSearchWithoutDate.TabIndex = 3;
			this.buttonSearchWithoutDate.Text = "Search w/o Date";
			this.buttonSearchWithoutDate.UseVisualStyleBackColor = true;
			this.buttonSearchWithoutDate.Click += new System.EventHandler(this.buttonSearchWithoutDate_Click);
			// 
			// labelCountry
			// 
			this.labelCountry.AutoSize = true;
			this.labelCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelCountry.Location = new System.Drawing.Point(93, 137);
			this.labelCountry.Name = "labelCountry";
			this.labelCountry.Size = new System.Drawing.Size(0, 25);
			this.labelCountry.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(18, 251);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(124, 25);
			this.label3.TabIndex = 5;
			this.label3.Text = "Total Cases:";
			// 
			// pictureBoxCountry
			// 
			this.pictureBoxCountry.Location = new System.Drawing.Point(23, 118);
			this.pictureBoxCountry.Name = "pictureBoxCountry";
			this.pictureBoxCountry.Size = new System.Drawing.Size(64, 64);
			this.pictureBoxCountry.TabIndex = 6;
			this.pictureBoxCountry.TabStop = false;
			// 
			// labelTotalCases
			// 
			this.labelTotalCases.AutoSize = true;
			this.labelTotalCases.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelTotalCases.ForeColor = System.Drawing.Color.Red;
			this.labelTotalCases.Location = new System.Drawing.Point(136, 252);
			this.labelTotalCases.Name = "labelTotalCases";
			this.labelTotalCases.Size = new System.Drawing.Size(0, 25);
			this.labelTotalCases.TabIndex = 7;
			// 
			// labelTotalRecovered
			// 
			this.labelTotalRecovered.AutoSize = true;
			this.labelTotalRecovered.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelTotalRecovered.ForeColor = System.Drawing.Color.Green;
			this.labelTotalRecovered.Location = new System.Drawing.Point(287, 340);
			this.labelTotalRecovered.Name = "labelTotalRecovered";
			this.labelTotalRecovered.Size = new System.Drawing.Size(0, 25);
			this.labelTotalRecovered.TabIndex = 13;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(132, 340);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(161, 25);
			this.label4.TabIndex = 12;
			this.label4.Text = "Total Recovered:";
			// 
			// labelNewCases
			// 
			this.labelNewCases.AutoSize = true;
			this.labelNewCases.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelNewCases.ForeColor = System.Drawing.Color.Red;
			this.labelNewCases.Location = new System.Drawing.Point(131, 287);
			this.labelNewCases.Name = "labelNewCases";
			this.labelNewCases.Size = new System.Drawing.Size(0, 25);
			this.labelNewCases.TabIndex = 11;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(18, 286);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(119, 25);
			this.label7.TabIndex = 10;
			this.label7.Text = "New Cases:";
			// 
			// buttonGlobal
			// 
			this.buttonGlobal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonGlobal.Location = new System.Drawing.Point(16, 41);
			this.buttonGlobal.Name = "buttonGlobal";
			this.buttonGlobal.Size = new System.Drawing.Size(146, 26);
			this.buttonGlobal.TabIndex = 14;
			this.buttonGlobal.Text = "World Stats";
			this.buttonGlobal.UseVisualStyleBackColor = true;
			this.buttonGlobal.Click += new System.EventHandler(this.buttonGlobal_Click);
			// 
			// labelDate
			// 
			this.labelDate.AutoSize = true;
			this.labelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelDate.ForeColor = System.Drawing.Color.Teal;
			this.labelDate.Location = new System.Drawing.Point(71, 197);
			this.labelDate.Name = "labelDate";
			this.labelDate.Size = new System.Drawing.Size(0, 25);
			this.labelDate.TabIndex = 16;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(18, 197);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(59, 25);
			this.label8.TabIndex = 15;
			this.label8.Text = "Date:";
			// 
			// labelNewDeaths
			// 
			this.labelNewDeaths.AutoSize = true;
			this.labelNewDeaths.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelNewDeaths.ForeColor = System.Drawing.Color.Red;
			this.labelNewDeaths.Location = new System.Drawing.Point(415, 287);
			this.labelNewDeaths.Name = "labelNewDeaths";
			this.labelNewDeaths.Size = new System.Drawing.Size(0, 25);
			this.labelNewDeaths.TabIndex = 24;
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label14.Location = new System.Drawing.Point(297, 286);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(124, 25);
			this.label14.TabIndex = 23;
			this.label14.Text = "New Deaths:";
			// 
			// labelTotalDeaths
			// 
			this.labelTotalDeaths.AutoSize = true;
			this.labelTotalDeaths.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelTotalDeaths.ForeColor = System.Drawing.Color.Red;
			this.labelTotalDeaths.Location = new System.Drawing.Point(420, 252);
			this.labelTotalDeaths.Name = "labelTotalDeaths";
			this.labelTotalDeaths.Size = new System.Drawing.Size(0, 25);
			this.labelTotalDeaths.TabIndex = 22;
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label16.Location = new System.Drawing.Point(297, 251);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(129, 25);
			this.label16.TabIndex = 21;
			this.label16.Text = "Total Deaths:";
			// 
			// labelNewRecovered
			// 
			this.labelNewRecovered.AutoSize = true;
			this.labelNewRecovered.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelNewRecovered.ForeColor = System.Drawing.Color.Green;
			this.labelNewRecovered.Location = new System.Drawing.Point(282, 377);
			this.labelNewRecovered.Name = "labelNewRecovered";
			this.labelNewRecovered.Size = new System.Drawing.Size(0, 25);
			this.labelNewRecovered.TabIndex = 26;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(132, 377);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(156, 25);
			this.label10.TabIndex = 25;
			this.label10.Text = "New Recovered:";
			// 
			// monthCalendar
			// 
			this.monthCalendar.Location = new System.Drawing.Point(372, 43);
			this.monthCalendar.MaxSelectionCount = 100000;
			this.monthCalendar.MinDate = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
			this.monthCalendar.Name = "monthCalendar";
			this.monthCalendar.TabIndex = 28;
			// 
			// buttonSearchWithDate
			// 
			this.buttonSearchWithDate.Location = new System.Drawing.Point(471, 7);
			this.buttonSearchWithDate.Name = "buttonSearchWithDate";
			this.buttonSearchWithDate.Size = new System.Drawing.Size(93, 24);
			this.buttonSearchWithDate.TabIndex = 29;
			this.buttonSearchWithDate.Text = "Search /w Date";
			this.buttonSearchWithDate.UseVisualStyleBackColor = true;
			this.buttonSearchWithDate.Click += new System.EventHandler(this.buttonSearchWithDate_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(356, 428);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(206, 13);
			this.label2.TabIndex = 30;
			this.label2.Text = "The \"new\" stats are data for 24 hours ago";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(569, 450);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.buttonSearchWithDate);
			this.Controls.Add(this.monthCalendar);
			this.Controls.Add(this.labelNewRecovered);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.labelNewDeaths);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.labelTotalDeaths);
			this.Controls.Add(this.label16);
			this.Controls.Add(this.labelDate);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.buttonGlobal);
			this.Controls.Add(this.labelTotalRecovered);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.labelNewCases);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.labelTotalCases);
			this.Controls.Add(this.pictureBoxCountry);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.labelCountry);
			this.Controls.Add(this.buttonSearchWithoutDate);
			this.Controls.Add(this.textBoxSearch);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxCountry)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBoxSearch;
		private System.Windows.Forms.Button buttonSearchWithoutDate;
		private System.Windows.Forms.Label labelCountry;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.PictureBox pictureBoxCountry;
		private System.Windows.Forms.Label labelTotalCases;
		private System.Windows.Forms.Label labelTotalRecovered;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label labelNewCases;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button buttonGlobal;
		private System.Windows.Forms.Label labelDate;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label labelNewDeaths;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label labelTotalDeaths;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label labelNewRecovered;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.MonthCalendar monthCalendar;
		private System.Windows.Forms.Button buttonSearchWithDate;
		private System.Windows.Forms.Label label2;
	}
}

