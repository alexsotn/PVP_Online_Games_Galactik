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
	public class bilds_tech
	{
		public int code_bld_tech { get; set; } // код постройки или исследования
		public long res_m { get; set; }
		public long res_k { get; set; }
		public long res_d { get; set; }
		public long res_energy { get; set; }
		public long time_sec { get; set; }  // время на постройку
		public string time_bld { get; set; }  // время на постройку
		public int lv_tek { get; set; }
		public static bilds_tech Load_bilds_tech(int id_user, int code_BT)
		{
			bilds_tech bt = new bilds_tech();
			SqlConnection conn = new SqlConnection();
			conn.ConnectionString = ConfigurationManager.ConnectionStrings["AccessBD"].ConnectionString;
			try
			{
				conn.Open();
				SqlCommand cmd;

				cmd = new SqlCommand();
				cmd.Connection = conn;
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.CommandText = "Lv_select";// Название процедуры на сервере
				cmd.Parameters.Add(new SqlParameter("@codes", code_BT));
				cmd.Parameters.Add(new SqlParameter("@id_us", id_user));
				SqlDataReader reader = cmd.ExecuteReader();
				while (reader.Read())
				{
					bt.lv_tek = Convert.ToInt32(reader["Lv"]);
				}
				conn.Close();
				conn.Open();
				cmd = new SqlCommand();
				cmd.Connection = conn;
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.CommandText = "param_bld_tech";// Название процедуры на сервере
				cmd.Parameters.Add(new SqlParameter("@codes_param", code_BT));
				cmd.Parameters.Add(new SqlParameter("@id_user", id_user));
				cmd.Parameters.Add(new SqlParameter("@Lv", bt.lv_tek));
				reader = cmd.ExecuteReader();
				while (reader.Read())
				{
					bt.res_m = Convert.ToInt32(reader["res_m"]);
					bt.res_k = Convert.ToInt32(reader["res_k"]);
					bt.res_d = Convert.ToInt32(reader["res_d"]);
					bt.res_energy = Convert.ToInt32(reader["res_energy"]);
					bt.time_sec = Convert.ToInt64(reader["time_bld"]);
					if (code_BT == 109)
						bt.time_bld = timer_Convet_Minuts(84000);
					else
						bt.time_bld = timer_Convet_Minuts(Convert.ToInt32(reader["time_bld"]));
				}
				conn.Close();
			}
			catch
			{
				conn.Close();
			}
			return bt;
		}
		public static string timer_Convet_Minuts(int sec)
		{
			int minutes = sec / 60;
			int newSec = sec - minutes * 60;
			int hour = minutes / 60;
			int newMinnutes = minutes - hour * 60;
			TimeSpan time = new TimeSpan(hour, newMinnutes, newSec);
			return time.ToString();
		}

	}
}
