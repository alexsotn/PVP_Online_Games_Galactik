
namespace DIPLOM_SAV
{
	partial class war_report
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.panel1 = new System.Windows.Forms.Panel();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.dates = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.res_win = new System.Windows.Forms.Label();
			this.names_Opnets = new System.Windows.Forms.Label();
			this.win_WAR = new System.Windows.Forms.Label();
			this.webBrowser1 = new System.Windows.Forms.WebBrowser();
			this.panel1.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackgroundImage = global::DIPLOM_SAV.Properties.Resources.background_IMAGE;
			this.panel1.Controls.Add(this.tableLayoutPanel1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(747, 193);
			this.panel1.TabIndex = 1;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.dates, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.res_win, 1, 5);
			this.tableLayoutPanel1.Controls.Add(this.names_Opnets, 1, 2);
			this.tableLayoutPanel1.Controls.Add(this.win_WAR, 1, 3);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 7;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(747, 193);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// dates
			// 
			this.dates.AutoSize = true;
			this.dates.BackColor = System.Drawing.Color.Transparent;
			this.dates.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dates.ForeColor = System.Drawing.Color.White;
			this.dates.Location = new System.Drawing.Point(43, 0);
			this.dates.Name = "dates";
			this.dates.Size = new System.Drawing.Size(701, 40);
			this.dates.TabIndex = 9;
			this.dates.Text = "Время боя: ";
			this.dates.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.Chartreuse;
			this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox1.Image = global::DIPLOM_SAV.Properties.Resources.back;
			this.pictureBox1.Location = new System.Drawing.Point(3, 3);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(34, 34);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 8;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// res_win
			// 
			this.res_win.AutoSize = true;
			this.res_win.Dock = System.Windows.Forms.DockStyle.Fill;
			this.res_win.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.res_win.ForeColor = System.Drawing.Color.White;
			this.res_win.Location = new System.Drawing.Point(43, 140);
			this.res_win.Name = "res_win";
			this.res_win.Size = new System.Drawing.Size(701, 25);
			this.res_win.TabIndex = 6;
			this.res_win.Text = "Аттакущий захватил ресурсы:  ";
			this.res_win.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// names_Opnets
			// 
			this.names_Opnets.AutoSize = true;
			this.names_Opnets.BackColor = System.Drawing.Color.Transparent;
			this.names_Opnets.Dock = System.Windows.Forms.DockStyle.Fill;
			this.names_Opnets.ForeColor = System.Drawing.Color.White;
			this.names_Opnets.Location = new System.Drawing.Point(43, 65);
			this.names_Opnets.Name = "names_Opnets";
			this.names_Opnets.Size = new System.Drawing.Size(701, 25);
			this.names_Opnets.TabIndex = 2;
			this.names_Opnets.Text = "#names_Opnets";
			this.names_Opnets.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// win_WAR
			// 
			this.win_WAR.AutoSize = true;
			this.win_WAR.Dock = System.Windows.Forms.DockStyle.Fill;
			this.win_WAR.ForeColor = System.Drawing.Color.White;
			this.win_WAR.Location = new System.Drawing.Point(43, 90);
			this.win_WAR.Name = "win_WAR";
			this.win_WAR.Size = new System.Drawing.Size(701, 25);
			this.win_WAR.TabIndex = 4;
			this.win_WAR.Text = "Победитель в бое:   ";
			// 
			// webBrowser1
			// 
			this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.webBrowser1.Location = new System.Drawing.Point(0, 193);
			this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
			this.webBrowser1.Name = "webBrowser1";
			this.webBrowser1.Size = new System.Drawing.Size(747, 428);
			this.webBrowser1.TabIndex = 2;
			// 
			// war_report
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(747, 621);
			this.Controls.Add(this.webBrowser1);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "war_report";
			this.Load += new System.EventHandler(this.war_report_Load);
			this.panel1.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label names_Opnets;
		private System.Windows.Forms.Label res_win;
		private System.Windows.Forms.Label win_WAR;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label dates;
		private System.Windows.Forms.WebBrowser webBrowser1;
	}
}