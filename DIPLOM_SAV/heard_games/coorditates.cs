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
	public class coorditates
	{
		public int G { get; set; }
		public int P { get; set; }

		public static coorditates My_cordinats(int id_user)
		{
			coorditates coors = new coorditates();
			SqlConnection conn = new SqlConnection();
			conn.ConnectionString = ConfigurationManager.ConnectionStrings["AccessBD"].ConnectionString;
			try
			{
				conn.Open();
				SqlCommand cmd = new SqlCommand();
				cmd.Connection = conn;
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.CommandText = "set_My_coordinates";// Название процедуры на сервере
				cmd.Parameters.Add(new SqlParameter("@id_user", id_user));
				SqlDataReader reader = cmd.ExecuteReader();
				while (reader.Read())
				{
					coors.G = Convert.ToInt32(reader["galaxy"]);
					coors.P = Convert.ToInt32(reader["planet"]);
				}
				conn.Close();
			}
			catch
			{
				conn.Close();
			}
			return coors;
		}
	}
}
