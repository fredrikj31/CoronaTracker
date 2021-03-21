
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
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			this.label1 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.buttonSearch = new System.Windows.Forms.Button();
			this.labelCountry = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.pictureBoxCountry = new System.Windows.Forms.PictureBox();
			this.labelInfectedPersons = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.buttonGlobal = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxCountry)).BeginInit();
			this.SuspendLayout();
			// 
			// progressBar1
			// 
			this.progressBar1.Location = new System.Drawing.Point(464, 336);
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(269, 29);
			this.progressBar1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(13, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(183, 25);
			this.label1.TabIndex = 1;
			this.label1.Text = "Search By Country:";
			// 
			// textBox1
			// 
			this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox1.Location = new System.Drawing.Point(197, 10);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(186, 30);
			this.textBox1.TabIndex = 2;
			// 
			// buttonSearch
			// 
			this.buttonSearch.Location = new System.Drawing.Point(388, 14);
			this.buttonSearch.Name = "buttonSearch";
			this.buttonSearch.Size = new System.Drawing.Size(75, 23);
			this.buttonSearch.TabIndex = 3;
			this.buttonSearch.Text = "Search";
			this.buttonSearch.UseVisualStyleBackColor = true;
			this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
			// 
			// labelCountry
			// 
			this.labelCountry.AutoSize = true;
			this.labelCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelCountry.Location = new System.Drawing.Point(88, 93);
			this.labelCountry.Name = "labelCountry";
			this.labelCountry.Size = new System.Drawing.Size(91, 25);
			this.labelCountry.TabIndex = 4;
			this.labelCountry.Text = "Denmark";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(13, 159);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(129, 25);
			this.label3.TabIndex = 5;
			this.label3.Text = "Total Cases: ";
			// 
			// pictureBoxCountry
			// 
			this.pictureBoxCountry.Image = global::CoronaTracker.Properties.Resources.Webp_net_resizeimage;
			this.pictureBoxCountry.Location = new System.Drawing.Point(18, 74);
			this.pictureBoxCountry.Name = "pictureBoxCountry";
			this.pictureBoxCountry.Size = new System.Drawing.Size(64, 64);
			this.pictureBoxCountry.TabIndex = 6;
			this.pictureBoxCountry.TabStop = false;
			// 
			// labelInfectedPersons
			// 
			this.labelInfectedPersons.AutoSize = true;
			this.labelInfectedPersons.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelInfectedPersons.ForeColor = System.Drawing.Color.Red;
			this.labelInfectedPersons.Location = new System.Drawing.Point(132, 160);
			this.labelInfectedPersons.Name = "labelInfectedPersons";
			this.labelInfectedPersons.Size = new System.Drawing.Size(83, 25);
			this.labelInfectedPersons.TabIndex = 7;
			this.labelInfectedPersons.Text = "123.456";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Green;
			this.label2.Location = new System.Drawing.Point(197, 229);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(72, 25);
			this.label2.TabIndex = 13;
			this.label2.Text = "78.900";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(13, 229);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(194, 25);
			this.label4.TabIndex = 12;
			this.label4.Text = "Recovered Persons: ";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.Red;
			this.label6.Location = new System.Drawing.Point(127, 195);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(83, 25);
			this.label6.TabIndex = 11;
			this.label6.Text = "123.456";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(13, 194);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(124, 25);
			this.label7.TabIndex = 10;
			this.label7.Text = "New Cases: ";
			// 
			// buttonGlobal
			// 
			this.buttonGlobal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonGlobal.Location = new System.Drawing.Point(468, 13);
			this.buttonGlobal.Name = "buttonGlobal";
			this.buttonGlobal.Size = new System.Drawing.Size(77, 26);
			this.buttonGlobal.TabIndex = 14;
			this.buttonGlobal.Text = "Global";
			this.buttonGlobal.UseVisualStyleBackColor = true;
			this.buttonGlobal.Click += new System.EventHandler(this.buttonGlobal_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.buttonGlobal);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.labelInfectedPersons);
			this.Controls.Add(this.pictureBoxCountry);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.labelCountry);
			this.Controls.Add(this.buttonSearch);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.progressBar1);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxCountry)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ProgressBar progressBar1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button buttonSearch;
		private System.Windows.Forms.Label labelCountry;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.PictureBox pictureBoxCountry;
		private System.Windows.Forms.Label labelInfectedPersons;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button buttonGlobal;
	}
}

