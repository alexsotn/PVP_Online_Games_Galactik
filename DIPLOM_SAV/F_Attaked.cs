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
using Newtonsoft.Json;

namespace DIPLOM_SAV
{
	public partial class F_Attaked : Form
	{
		int Distance = 0,  timer_fly = 0; long prise_fly = 0, glob_grus_max = 0;
		string json_Mycors, json_Vragkors, json_fls;
		int id_my, id_vrags;
		int colich_flt = 0;
		fleets_deff _Flets;
		private void bt_includes_Click(object sender, EventArgs e)
		{
			if (glob_grus_max > 0)
			{
				resurs_planets res = resurs_planets.load_res(id_my);
				if (res.res_deuterium > prise_fly)
				{
					if (ataked_planed_timer.atted_planets(id_my, id_vrags, json_fls, colich_flt, timer_fly, json_Mycors, json_Vragkors, glob_grus_max, prise_fly, _Flets))
					{
						MessageBox.Show("Флот отправлен в полет)))");
						Close();
					}
				}
				else
					MessageBox.Show("У вас не хватает дейтрия для оплаты полёта!!!");
			}
			else
				MessageBox.Show("Флот не возможно отправить в полет!!! Трюм меньше чем нужет для полета");
		}


		public F_Attaked(int id_user_att, int id_vrag, coorditates Vraga, string json_flets, long couts_flets, long speeds_fleets, long grus_max, long prise_deit, fleets_deff FD)
		{
			InitializeComponent();
			coorditates My_coors = coorditates.My_cordinats(id_user_att);
			Distance = (1000 + (Math.Abs(My_coors.G - Vraga.G) * 100 + Math.Abs(My_coors.P - Vraga.P) * 10));
			prise_fly = Convert.ToInt64(Distance * prise_deit) / 100000; // 10 000 - доп параметр на растчет полета 
			timer_fly = 450 + ((450 * Distance) / 1000); //450сек = 7,5 минут полет в одной системе

			json_Mycors = JsonConvert.SerializeObject(My_coors);
			json_Vragkors = JsonConvert.SerializeObject(Vraga);
			json_fls = json_flets;
			colich_flt = Convert.ToInt32(couts_flets);
			id_my = id_user_att; id_vrags = id_vrag;
			_Flets = FD;


			cor_G.Text = Vraga.G.ToString();
			cor_P.Text = Vraga.P.ToString();
			combo_mission.SelectedIndex = 0;
			txt_speeds.Text = speeds_fleets.ToString("#,#");
			txt_long.Text = Distance.ToString("#,#");
			txt_cost.Text = prise_fly.ToString("#,#");
			glob_grus_max  = (grus_max - prise_fly);
			txt_gruz.Text = glob_grus_max.ToString("#,#");
			timer_sec.Text = ataked_planed_timer.timer_Convet_Minuts(timer_fly);

		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
