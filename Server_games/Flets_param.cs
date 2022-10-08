using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server_games
{
	public class Flets_param
	{
		public long attack { get; set; }//атака
		public long shields { get; set; }//щиты
		public long armor { get; set; }//броня
		public int  Res_all { get; set; }//броня

		public static Flets_param set_pay_to_FD(int id_user, int code_FD)
		{
			Flets_param list = new Flets_param();
			SqlConnection conn = new SqlConnection();
			conn.ConnectionString = ConfigurationManager.ConnectionStrings["AccessBD"].ConnectionString;
			try
			{
				conn.Open();
				SqlCommand cmd = new SqlCommand();
				cmd.Connection = conn;
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.CommandText = "FLEETS_param_Battle_War_SEVERE";// Название процедуры на сервере
				cmd.Parameters.Add(new SqlParameter("@id_user", id_user));
				cmd.Parameters.Add(new SqlParameter("@codes", code_FD));
				SqlDataReader reader = cmd.ExecuteReader();
				while (reader.Read())
				{
					list.attack = Convert.ToInt32(reader["Att"]);
					list.shields = Convert.ToInt32(reader["Shit"]);
					list.armor = Convert.ToInt32(reader["Deff"]);
					list.Res_all = Convert.ToInt32(reader["res_all"]);
				}
				conn.Close();
			}
			catch
			{
				conn.Close();
			}
			return list;
		}
	}
}
