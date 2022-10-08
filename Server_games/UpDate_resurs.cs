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
	public class UpDate_resurs
	{

		public static void List_User_planets()
		{
			SqlConnection conn = new SqlConnection();
			conn.ConnectionString = ConfigurationManager.ConnectionStrings["AccessBD"].ConnectionString;
			try
			{
				conn.Open();
				SqlCommand cmd = new SqlCommand();
				cmd.Connection = conn;
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.CommandText = "list_user_ID_SERVER";// Название процедуры на сервере
				SqlDataReader reader = cmd.ExecuteReader();
				conn.Close();
				while (reader.Read())
				{
					Update_Res(Convert.ToInt32(reader["id_owner"]));
				}
				conn.Close();
			}
			catch
			{
				conn.Close();
			}
		}


		public static void Update_Res(int id_user)
		{
			SqlConnection conn = new SqlConnection();
			conn.ConnectionString = ConfigurationManager.ConnectionStrings["AccessBD"].ConnectionString;
			try
			{
				conn.Open();
				SqlCommand cmd = new SqlCommand();
				cmd.Connection = conn;
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.CommandText = "Up_date_resurs_User_SERVER";// Название процедуры на сервере
				cmd.Parameters.Add(new SqlParameter("@id_user", id_user));
				cmd.ExecuteNonQuery();
				conn.Close();
			}
			catch
			{
				conn.Close();
			}
		}
		public static void Delete_All_sms_and_Report()
		{
			SqlConnection conn = new SqlConnection();
			conn.ConnectionString = ConfigurationManager.ConnectionStrings["AccessBD"].ConnectionString;
			try
			{
				conn.Open();
				SqlCommand cmd = new SqlCommand();
				cmd.Connection = conn;
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.CommandText = "del_SMS_and_Reports_SERVER";// Название процедуры на сервере
				if (cmd.ExecuteNonQuery() > 0)
					MessageBox.Show("Таблицы очищены от удаленных смс");
				conn.Close();
			}
			catch(Exception e)
			{
				conn.Close();
				MessageBox.Show(e.Message.ToString());
			}
		}

	}
}
