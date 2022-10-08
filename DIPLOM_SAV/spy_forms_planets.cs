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
	public partial class spy_forms_planets : Form
	{
		coorditates My_coors, Varags; galactikCoor coors_vrag;
		fleets_deff flt_305;
		int ID_owner, id_torget;
		public spy_forms_planets(int id_My,  galactikCoor coors)
		{
			InitializeComponent();
			Varags = new coorditates();
			My_coors = coorditates.My_cordinats(id_My);
			coors_vrag = coors;
			Varags.G = coors.G;
			Varags.P = coors.P;
			ID_owner = id_My;
			id_torget = coors.id_user;
			flt_305 = fleets_deff.get_fleets_deff(ID_owner);
			txt_cols.Maximum = flt_305.flt_305;
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (Convert.ToInt32(txt_cols.Text) > 0)
			{
				fleets_deff flets = new fleets_deff();
				flets.flt_305 = Convert.ToInt32(txt_cols.Text);
				int flets_305 = Convert.ToInt32(txt_cols.Text);
				string JSON_flets_305 = JsonConvert.SerializeObject(flets);
				string json_Mycors = JsonConvert.SerializeObject(My_coors);
				string json_Vragkors = JsonConvert.SerializeObject(Varags);

				if (ataked_planed_timer.spys_planets(ID_owner, id_torget, JSON_flets_305, flets_305, json_Mycors, json_Vragkors, flets_305))
				{
					MessageBox.Show("Шпионские зонты отправлены ))))");
					Close();
				}
				else
					MessageBox.Show("Ошибка: У вас нет шпионских зонтов!!!!");
			}
			else
				MessageBox.Show("Не выбрали ни 1-го шпионского зонта!!!");
		}
	}
}
