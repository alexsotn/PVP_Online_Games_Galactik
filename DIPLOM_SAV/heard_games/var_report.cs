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
	public class var_report
	{
		public string html_rep { get; set; }
		public int  WON { get; set; }
		public long res_m { get; set; }
		public long res_k { get; set; }
		public long res_d { get; set; }
		public string Names_VS { get; set; }

		public static var_report item_WAR_report(int id_wars)
		{
			// отркрыть одно сообщение 
			var_report report = new var_report();
			SqlConnection conn = new SqlConnection();
			conn.ConnectionString = ConfigurationManager.ConnectionStrings["AccessBD"].ConnectionString;
			try
			{
				conn.Open();
				SqlCommand cmd = new SqlCommand();
				cmd.Connection = conn;
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.CommandText = "items_war_REPORT";// Название процедуры на сервере
				cmd.Parameters.Add(new SqlParameter("@id_Rows", id_wars));
				SqlDataReader reader = cmd.ExecuteReader();
				while (reader.Read())
				{
					report.html_rep = (Convert.ToString(reader["array_datas"])); 
					report.WON = (Convert.ToInt32(reader["won"])); 
					report.res_m = (Convert.ToInt64(reader["res_metal"])); 
					report.res_k = (Convert.ToInt64(reader["res_kristal"])); 
					report.res_d = (Convert.ToInt64(reader["res_deuterium"])); 
				}
				conn.Close();
			}
			catch
			{
				conn.Close();
			}
			return report;
		}
	}
}
