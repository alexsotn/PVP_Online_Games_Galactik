using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server_games
{
	public class Spy_report : flets_deff
	{
		public int ataked_tech { get; set; }
		public int shield_tech { get; set; }
		public int defence_tech { get; set; }
		public int shield_planets_tech { get; set; }
		public long res_m { get; set; }
		public long res_k { get; set; }
		public long res_d { get; set; }


		public static string Spy_planets(int id_user_Spypes)
		{
			string JsonObj = "";
			SqlConnection conn = new SqlConnection();
			conn.ConnectionString = ConfigurationManager.ConnectionStrings["AccessBD"].ConnectionString;
			try
			{
				conn.Open();
				SqlCommand cmd = new SqlCommand();
				cmd.Connection = conn;
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.CommandText = "spy_report_SERVER";// Название процедуры на сервере
				cmd.Parameters.Add(new SqlParameter("@id_user", id_user_Spypes));
				SqlDataReader reader = cmd.ExecuteReader();
				Spy_report report = new Spy_report();
				while (reader.Read())
				{
					report = new Spy_report();
					report.ataked_tech = Convert.ToInt32(reader["ataked_tech"]);
					report.shield_tech = Convert.ToInt32(reader["shield_tech"]);
					report.defence_tech = Convert.ToInt32(reader["defence_tech"]);
					report.shield_planets_tech = Convert.ToInt32(reader["shield_planets_tech"]);
					report.flt_301 = Convert.ToInt32(reader["flt_301"]);
					report.flt_302 = Convert.ToInt32(reader["flt_302"]);
					report.flt_303 = Convert.ToInt32(reader["flt_303"]);
					report.flt_304 = Convert.ToInt32(reader["flt_304"]);
					report.flt_305 = Convert.ToInt32(reader["flt_305"]);
					report.flt_306 = Convert.ToInt32(reader["flt_306"]);
					report.flt_307 = Convert.ToInt32(reader["flt_307"]);
					report.flt_308 = Convert.ToInt32(reader["flt_308"]);
					report.flt_309 = Convert.ToInt32(reader["flt_309"]);
					report.deff_401 = Convert.ToInt32(reader["deff_401"]);
					report.deff_402 = Convert.ToInt32(reader["deff_402"]);
					report.deff_403 = Convert.ToInt32(reader["deff_403"]);
					report.deff_404 = Convert.ToInt32(reader["deff_404"]);
					report.deff_405 = Convert.ToInt32(reader["deff_405"]);
					report.deff_406 = Convert.ToInt32(reader["deff_406"]);
					//ресурсы на планете
					report.res_m = Convert.ToInt64(reader["res_metal"]);
					report.res_k = Convert.ToInt64(reader["res_kristal"]);
					report.res_d = Convert.ToInt64(reader["res_deuterium"]);
				}
				conn.Close();
				JsonObj = JsonConvert.SerializeObject(report);
			}
			catch
			{
				conn.Close();
			}
			return JsonObj;
		}

		public static bool Write_report(int id_Rows_timers, string fson_data, int id_att, int id_deff)
		{
			SqlConnection conn = new SqlConnection();
			conn.ConnectionString = ConfigurationManager.ConnectionStrings["AccessBD"].ConnectionString;
			try
			{
				conn.Open();
				SqlCommand cmd = new SqlCommand();
				cmd.Connection = conn;
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.CommandText = "SERVER_returt_fleets_mission";// Название процедуры на сервере
				cmd.Parameters.Add(new SqlParameter("@ID_rows", id_Rows_timers));
				cmd.Parameters.Add(new SqlParameter("@Json_data", fson_data));
				cmd.Parameters.Add(new SqlParameter("@ID_att", id_att));
				cmd.Parameters.Add(new SqlParameter("@ID_defer", id_deff));
				//SqlDataReader reader = cmd.ExecuteReader();
				if (cmd.ExecuteNonQuery() > 0)
				{
					conn.Close();
					return true;
				}
				conn.Close();

			}
			catch (Exception e)
			{
				MessageBox.Show(e.Message.ToString());
				conn.Close();
			}
			return false;
		}
		public static bool Up_return_fleets_inPlanets(flets_deff FD, int id_my, int id_rows, long res_m, long res_k, long res_d)
		{
			SqlConnection conn = new SqlConnection();
			conn.ConnectionString = ConfigurationManager.ConnectionStrings["AccessBD"].ConnectionString;
			try
			{
				conn.Open();
				SqlCommand cmd = new SqlCommand();
				cmd.Connection = conn;
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.CommandText = "atakets_UP_Planets_FLEETS_SERVER";// Название процедуры на сервере
				cmd.Parameters.Add(new SqlParameter("@id_rows", id_rows));
				cmd.Parameters.Add(new SqlParameter("@id_user", id_my));
				cmd.Parameters.Add(new SqlParameter("@flt_301", FD.flt_301));
				cmd.Parameters.Add(new SqlParameter("@flt_302", FD.flt_302));
				cmd.Parameters.Add(new SqlParameter("@flt_303", FD.flt_303));
				cmd.Parameters.Add(new SqlParameter("@flt_304", FD.flt_304));
				cmd.Parameters.Add(new SqlParameter("@flt_305", FD.flt_305));
				cmd.Parameters.Add(new SqlParameter("@flt_306", FD.flt_306));
				cmd.Parameters.Add(new SqlParameter("@flt_308", FD.flt_308));
				cmd.Parameters.Add(new SqlParameter("@flt_309", FD.flt_309));

				cmd.Parameters.Add(new SqlParameter("@res_m", res_m));
				cmd.Parameters.Add(new SqlParameter("@res_k", res_k));
				cmd.Parameters.Add(new SqlParameter("@res_d", res_d));
				//SqlDataReader reader = cmd.ExecuteReader();
				if (cmd.ExecuteNonQuery() > 0)
				{
					conn.Close();
					return true;
				}
				conn.Close();

			}
			catch (Exception e)
			{
				MessageBox.Show(e.Message.ToString());
				conn.Close();
			}
			return false;
		}

	}
}
