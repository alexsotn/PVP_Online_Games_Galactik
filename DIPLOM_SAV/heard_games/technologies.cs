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
	public class technologies
	{
		public int spy_tech { get; set; }
		public int computer_tech { get; set; }
		public int ataked_tech { get; set; }
		public int shield_tech { get; set; }
		public int defence_tech { get; set; }
		public int energy_tech { get; set; }
		public int giper_tech { get; set; }
		public int oborona_planets_tech { get; set; }
		public int shield_planets_tech { get; set; }
		

		public static technologies Load_tech(int ID_user)
		{
			technologies Tech = new technologies();
			SqlConnection conn = new SqlConnection();
			conn.ConnectionString = ConfigurationManager.ConnectionStrings["AccessBD"].ConnectionString;
			try
			{
				conn.Open();
				SqlCommand cmd = new SqlCommand();
				cmd.Connection = conn;
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.CommandText = "load_tech_user";// Название процедуры на сервере
				cmd.Parameters.Add(new SqlParameter("@id_user", ID_user));
				SqlDataReader reader = cmd.ExecuteReader();
				while (reader.Read())
				{
					Tech.spy_tech = Convert.ToInt32(reader["spy_tech"]);
					Tech.computer_tech = Convert.ToInt32(reader["computer_tech"]);
					Tech.ataked_tech = Convert.ToInt32(reader["ataked_tech"]);
					Tech.shield_tech = Convert.ToInt32(reader["shield_tech"]);
					Tech.defence_tech = Convert.ToInt32(reader["defence_tech"]);
					Tech.energy_tech = Convert.ToInt32(reader["energy_tech"]);
					Tech.giper_tech = Convert.ToInt32(reader["giper_tech"]);
					Tech.oborona_planets_tech = Convert.ToInt32(reader["oborona_planets_tech"]);
					Tech.shield_planets_tech = Convert.ToInt32(reader["shield_planets_tech"]);
				}
				conn.Close();
			}
			catch
			{
				conn.Close();
			}
			return Tech;
		}
	}
}
