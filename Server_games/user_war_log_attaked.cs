using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Server_games
{
	public class user_war_log_attaked
	{
		public int id { get; set; }
		public int user_ataker { get; set; }
		public int user_deffer { get; set; }
		public flets_deff Flet_attaker { get; set; }
		public flets_deff Flet_defer { get; set; }
		public static user_war_log_attaked load_data_user(int id_Report, int id_owner, int id_target_owner, string sts)
		{
			user_war_log_attaked log = new user_war_log_attaked();
			SqlConnection conn = new SqlConnection();
			conn.ConnectionString = ConfigurationManager.ConnectionStrings["AccessBD"].ConnectionString;
			try
			{
				conn.Open();
				SqlCommand cmd = new SqlCommand();
				cmd.Connection = conn;
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.CommandText = "load_fleets_and_deff";// Название процедуры на сервере
				cmd.Parameters.Add(new SqlParameter("@id_user", id_target_owner));
				SqlDataReader reader = cmd.ExecuteReader();
				while (reader.Read())
				{
					flets_deff Deffers = new flets_deff();
					Deffers.flt_301 = Convert.ToInt32(reader["flt_301"]);
					Deffers.flt_302 = Convert.ToInt32(reader["flt_302"]);
					Deffers.flt_303 = Convert.ToInt32(reader["flt_303"]);
					Deffers.flt_304 = Convert.ToInt32(reader["flt_304"]);
					Deffers.flt_305 = Convert.ToInt32(reader["flt_305"]);
					Deffers.flt_306 = Convert.ToInt32(reader["flt_306"]);
					Deffers.flt_307 = Convert.ToInt32(reader["flt_307"]);
					Deffers.flt_308 = Convert.ToInt32(reader["flt_308"]);
					Deffers.flt_309 = Convert.ToInt32(reader["flt_309"]);
					Deffers.deff_401 = Convert.ToInt32(reader["deff_401"]);
					Deffers.deff_402 = Convert.ToInt32(reader["deff_402"]);
					Deffers.deff_403 = Convert.ToInt32(reader["deff_403"]);
					Deffers.deff_404 = Convert.ToInt32(reader["deff_404"]);
					Deffers.deff_405 = Convert.ToInt32(reader["deff_405"]);
					Deffers.deff_406 = Convert.ToInt32(reader["deff_406"]);

					log.Flet_defer = Deffers;
					//
					log.id = id_Report;
					log.user_ataker = id_owner;
					log.user_deffer = id_target_owner;
					log.Flet_attaker = JsonConvert.DeserializeObject<flets_deff>(sts);
				}
				conn.Close();
			}
			catch
			{
				//return false;
				conn.Close();
			}
			return log;
		}
	}
}
