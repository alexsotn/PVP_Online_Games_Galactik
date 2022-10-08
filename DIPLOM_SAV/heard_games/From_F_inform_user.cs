using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPLOM_SAV.heard_games
{
	public class From_F_inform_user : statistik_user
	{
		public string login { get; set; }
		public string planets_data { get; set; }
		public bool sex { get; set; }
		public int war_win { get; set; }
		public int war_gameovar { get; set; }


		public int pozit_all_r { get; set; }
		public int pozit_prom_r { get; set; }
		public int pozit_tech_r { get; set; }
		public int pozit_fllets_r { get; set; }
		public int pozit_deff_r { get; set; }


		public int img_avatar { get; set; }
		public int img_war_scn { get; set; }
		public int img_prom_scn { get; set; }

		public int g { get; set; }
		public int p { get; set; }

		public static From_F_inform_user get_info_USER(int ID)
		{
			From_F_inform_user info = new From_F_inform_user();
			SqlConnection conn = new SqlConnection();
			conn.ConnectionString = ConfigurationManager.ConnectionStrings["AccessBD"].ConnectionString;
			try
			{
				conn.Open();
				SqlCommand cmd = new SqlCommand();
				cmd.Connection = conn;
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.CommandText = "set_inform_user";// Название процедуры на сервере
				cmd.Parameters.Add(new SqlParameter("@id_user", ID));
				SqlDataReader reader = cmd.ExecuteReader();
				while (reader.Read())
				{

					info.login = Convert.ToString(reader["login"]);
					info.sex = Convert.ToBoolean(reader["sex"]);
					info.planets_data = Convert.ToString(reader["names_planets"] + " ["+ reader["galaxy"] +":" +reader["planet"]+"]");
					info.g = Convert.ToInt32(reader["galaxy"]);
					info.p = Convert.ToInt32(reader["planet"]);

					info.war_win = Convert.ToInt32(reader["war_win"]);
					info.war_gameovar = Convert.ToInt32(reader["war_gameovor"]);
					info.img_avatar = Convert.ToInt32(reader["avatar_imege"]);
					info.img_prom_scn = Convert.ToInt32(reader["prom_imege"]);
					info.img_war_scn = Convert.ToInt32(reader["war_imege"]);


					info.pozit_all_r = Convert.ToInt32(reader["position_all"]);
					info.pozit_prom_r = Convert.ToInt32(reader["position_prom"]);
					info.pozit_tech_r = Convert.ToInt32(reader["position_tech"]);
					info.pozit_fllets_r = Convert.ToInt32(reader["position_fllet"]);
					info.pozit_deff_r = Convert.ToInt32(reader["position_deff"]);

					info.all_rating = Convert.ToInt32(reader["all_rating"]);
					info.prom_rating = Convert.ToInt32(reader["prom_rating"]);
					info.tech_rating = Convert.ToInt32(reader["tech_rating"]);
					info.fleets_rating = Convert.ToInt32(reader["fleets_rating"]);
					info.deff_rating = Convert.ToInt32(reader["deff_rating"]);

				}
				conn.Close();
			}
			catch
			{
				conn.Close();
			}
			return info;
		}
		

	}
}
