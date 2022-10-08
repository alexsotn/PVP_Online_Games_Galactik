using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using DIPLOM_SAV.heard_games;

namespace DIPLOM_SAV
{
	public partial class war_report : Form
	{
		var_report report;
		public war_report(int id_report)
		{
			InitializeComponent();
			sms_vars item_sms = sms_vars.items_sms(id_report);
			report = var_report.item_WAR_report(item_sms.id_report);
			dates.Text += item_sms.dates_timer.ToString();
			names_Opnets.Text = item_sms.sms_attaker.ToString() +" VS "+ item_sms.sms_deffers.ToString();

			if (report.WON == 1)
			{
				win_WAR.Text += item_sms.sms_attaker.ToString();
				res_win.Text += "Метал:" + report.res_m.ToString("#,#") + " Кристал: " + report.res_k.ToString("#,#") + " Дейтерий: " + report.res_d.ToString("#,#");
			}
			else
			{
				win_WAR.Text += item_sms.sms_deffers.ToString();
				res_win.Visible = false;
			}
		}

		private void war_report_Load(object sender, EventArgs e)
		{
			File.WriteAllText("War_repot.html", report.html_rep.ToString());
			string path = HttpUtility.HtmlEncode(Path.Combine(Directory.GetCurrentDirectory(), "War_repot.html"));
			webBrowser1.Navigate(path);
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
