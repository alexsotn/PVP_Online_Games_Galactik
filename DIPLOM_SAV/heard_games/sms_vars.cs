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
	public class sms_vars
	{
		public int id { get; set; }
		public string sms_attaker { get; set; }// ник игрока атаки
		public string sms_deffers { get; set; }// ник игрока защиты
		public int id_report { get; set; }
		public string dates_timer { get; set; }
		public string missions { get; set; }
		public string coor_Att_vs_Deff { get; set; }

		public int id_att { get; set; }// ник игрока атаки
		public int id_deff { get; set; }// ник игрока защиты

		public static List<sms_vars> list_sms(int users, int flags)
		{
			List<sms_vars> result = new List<sms_vars>();
			SqlConnection conn = new SqlConnection();
			conn.ConnectionString = ConfigurationManager.ConnectionStrings["AccessBD"].ConnectionString;
			SqlCommand cmd; SqlDataReader reader;
			try
			{
				conn.Open();
				cmd = new SqlCommand();
				cmd.Connection = conn;
				cmd.CommandType = CommandType.StoredProcedure;
				if (flags == 1)
					cmd.CommandText = "list_sms_WAR";// Название процедуры на сервере
				else
					cmd.CommandText = "list_sms_WAR_My";// Название процедуры на сервере
				cmd.Parameters.Add(new SqlParameter("@id_user", users));
				reader = cmd.ExecuteReader();
				while (reader.Read())
				{
					sms_vars sms = new sms_vars();
					sms.id = Convert.ToInt32(reader["id"]);
					sms.sms_attaker = Convert.ToString(reader["att"]);
					sms.sms_deffers = Convert.ToString(reader["deff"]);
					sms.id_report = Convert.ToInt32(reader["id_reports"]);
					sms.dates_timer = Convert.ToString(reader["message_time"]);
					sms.missions = Convert.ToString(reader["missions"]);
					sms.coor_Att_vs_Deff = Convert.ToString(reader["coor_Att_vs_Deff"]);

					result.Add(sms);
				}
				conn.Close();

			}
			catch
			{
				conn.Close();
			}
			return result;
		}
		public static sms_vars items_sms(int id_Rows)
		{
			sms_vars sms = new sms_vars();
			SqlConnection conn = new SqlConnection();
			conn.ConnectionString = ConfigurationManager.ConnectionStrings["AccessBD"].ConnectionString;
			SqlCommand cmd; SqlDataReader reader;
			try
			{
				conn.Open();
				cmd = new SqlCommand();
				cmd.Connection = conn;
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.CommandText = "items_sms_WAR";// Название процедуры на сервере
				cmd.Parameters.Add(new SqlParameter("@id_Rows", id_Rows));
				reader = cmd.ExecuteReader();
				while (reader.Read())
				{
					sms.id = Convert.ToInt32(reader["id"]);
					sms.sms_attaker = Convert.ToString(reader["N_att"]);
					sms.sms_deffers = Convert.ToString(reader["N_deff"]);
					sms.id_att = Convert.ToInt32(reader["sms_attaker"]);
					sms.id_deff = Convert.ToInt32(reader["sms_deffers"]);
					sms.id_report = Convert.ToInt32(reader["id_reports"]);
					sms.dates_timer = Convert.ToString(reader["message_time"]);
					sms.missions = Convert.ToString(reader["missions"]);
					sms.coor_Att_vs_Deff = Convert.ToString(reader["coor_Att_vs_Deff"]);
				}
				conn.Close();

			}
			catch
			{
				conn.Close();
			}
			return sms;
		}
	}
}
