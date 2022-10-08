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
	public class prom_war_level
	{
		public int exp_var { get; set; }
		public int exp_prom { get; set; }
		public int war_lv { get; set; }
		public int prom_lv { get; set; }
		public int war_imege { get; set; }
		public int prom_imege { get; set; }
		public int war_win { get; set; }
		public int war_gameovor { get; set; }

		

		public static prom_war_level load_PRL(int ID)
		{
			prom_war_level Result = new prom_war_level();
			SqlConnection conn = new SqlConnection();
			conn.ConnectionString = ConfigurationManager.ConnectionStrings["AccessBD"].ConnectionString;
			try
			{
				conn.Open();
				SqlCommand cmd = new SqlCommand();
				cmd.Connection = conn;
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.CommandText = "get_PW_Level";// Название процедуры на сервере
				cmd.Parameters.Add(new SqlParameter("@id_user", ID));
				SqlDataReader reader = cmd.ExecuteReader();
				while (reader.Read())
				{
					Result.war_lv = Convert.ToInt32(reader["war_lv"]);
					Result.war_imege = Convert.ToInt32(reader["war_imege"]);
					Result.war_win = Convert.ToInt32(reader["war_win"]);
					Result.war_gameovor = Convert.ToInt32(reader["war_gameovor"]);
					Result.exp_var = Convert.ToInt32(reader["exp_var"]);
					Result.prom_lv = Convert.ToInt32(reader["prom_lv"]);
					Result.prom_imege = Convert.ToInt32(reader["prom_imege"]);
					Result.exp_prom = Convert.ToInt32(reader["exp_prom"]);
				}
				conn.Close();
			}
			catch
			{
				conn.Close();
			}
			return Result;
		}
	}


}
