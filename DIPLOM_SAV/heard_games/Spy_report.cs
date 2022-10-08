using Newtonsoft.Json;
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
	public class Spy_report : fleets_deff
	{
		public int ataked_tech { get; set; }
		public int shield_tech { get; set; }
		public int defence_tech { get; set; }
		public int shield_planets_tech { get; set; }
		public int res_m { get; set; }
		public int res_k { get; set; }
		public int res_d { get; set; }



		public static Spy_report item_Spy_report(int id_wars)
		{
			// отркрыть одно сообщение 
			Spy_report report = new Spy_report();
			SqlConnection conn = new SqlConnection();
			conn.ConnectionString = ConfigurationManager.ConnectionStrings["AccessBD"].ConnectionString;
			try
			{
				conn.Open();
				SqlCommand cmd = new SqlCommand();
				cmd.Connection = conn;
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.CommandText = "load_Report_Spy";// Название процедуры на сервере
				cmd.Parameters.Add(new SqlParameter("@id_rows", id_wars));
				SqlDataReader reader = cmd.ExecuteReader();
				while (reader.Read())
				{
					report = JsonConvert.DeserializeObject<Spy_report>(Convert.ToString(reader["array_datas"])); ;
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
