using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DIPLOM_SAV.heard_games;

namespace DIPLOM_SAV
{
	public partial class spy_sms : Form
	{
		int my_ids = -1; sms_vars item_sms; main_F F_main;
		public spy_sms(int id, int my_id, main_F f_main)
		{
			InitializeComponent();
			item_sms = sms_vars.items_sms(id);

			Spy_report report = Spy_report.item_Spy_report(item_sms.id_report);
			times_report.Text += item_sms.dates_timer.ToString();
			res_m.Text = report.res_m.ToString("#,#");
			res_k.Text = report.res_k.ToString("#,#");
			res_d.Text = report.res_d.ToString("#,#");
			// исследование
			tech_O.Text = report.ataked_tech.ToString();
			tech_Ch.Text = report.shield_tech.ToString();
			tech_Br.Text = report.defence_tech.ToString();
			tech_StP.Text = report.shield_planets_tech.ToString();
			// данные флота
			fleet_1.Text = report.flt_301.ToString();
			fleet_2.Text = report.flt_302.ToString();
			fleet_3.Text = report.flt_303.ToString();
			fleet_4.Text = report.flt_304.ToString();
			fleet_5.Text = report.flt_306.ToString();
			fleet_6.Text = report.flt_308.ToString();
			fleet_7.Text = report.flt_309.ToString();
			fleet_8.Text = report.flt_305.ToString();
			// оборона
			deff_1.Text = report.deff_401.ToString();
			deff_2.Text = report.deff_402.ToString();
			deff_3.Text = report.deff_403.ToString();
			deff_4.Text = report.deff_404.ToString();
			deff_5.Text = report.deff_405.ToString();
			deff_6.Text = report.deff_406.ToString();

			my_ids = my_id; F_main = f_main;


		}

		private void bt_attacet_Click(object sender, EventArgs e)
		{
			var form_1 = new fleets_F(my_ids, galactikCoor.items_galactik_for_ID_user(Convert.ToInt32(item_sms.id_deff)));
			form_1.MdiParent = F_main;
			form_1.Show();
			Close();
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void spy_sms_Load(object sender, EventArgs e)
		{
			
		}
	}
}
