using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Specialized;
using System.Configuration;
using System.Data;
using System.IO;

namespace DIPLOM_SAV.heard_games
{
	public class users
	{
		public int id { get; set; }
		public string login { get; set; }
		public string pass { get; set; }
		public string email { get; set; }
		public bool sex { get; set; }
		public bool online_status { get; set; }
		public int new_message { get; set; }
		public int credits { get; set; }
		public int avatar_imege { get; set; }

		public class status_online
		{
			public int user_online_all { get; set; }
			public int user_online_counts { get; set; }

			public static status_online load_data()
			{
				status_online online = new status_online();
				SqlConnection conn = new SqlConnection();
				conn.ConnectionString = ConfigurationManager.ConnectionStrings["AccessBD"].ConnectionString;
				try
				{
					conn.Open();
					SqlCommand cmd = new SqlCommand();
					cmd.Connection = conn;
					cmd.CommandType = CommandType.StoredProcedure;
					cmd.CommandText = "user_status_online_list";// Название процедуры на сервере
					SqlDataReader reader = cmd.ExecuteReader();
					while (reader.Read())
					{
						online.user_online_all = Convert.ToInt32(reader["user_online_all"]);
						online.user_online_counts = Convert.ToInt32(reader["user_online_counts"]);
					}
					conn.Close();
				}
				catch
				{
					conn.Close();
				}
				return online;
			}
		}

		public static bool regist_users(string login, string pass, string emal, bool sex, int imeges)
		{
			bool Result = false;
			//

			SqlConnection conn = new SqlConnection();
			conn.ConnectionString = ConfigurationManager.ConnectionStrings["AccessBD"].ConnectionString;
			try
			{

				conn.Open();
				SqlCommand cmd = new SqlCommand();
				cmd.Connection = conn;
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.CommandText = "regestration_user";// Название процедуры на сервере
				cmd.Parameters.Add(new SqlParameter("@login", login));
				cmd.Parameters.Add(new SqlParameter("@pass", Convert_String_to_byte(pass)));
				cmd.Parameters.Add(new SqlParameter("@email", emal));
				cmd.Parameters.Add(new SqlParameter("@sex", sex));
				cmd.Parameters.Add(new SqlParameter("@avatar_imege", imeges));
				int id_new_user = Convert.ToInt32(cmd.ExecuteScalar());
				if (id_new_user > 0)
				{
					conn.Close();
					bool tek = false;
					while (tek == false)
					{
						Random rand = new Random();
						int g = rand.Next(1, 100);
						int p = rand.Next(1, 9);
						if (new_cordinat(g, p))
						{
							tek = true;
							conn.Open();
							cmd = new SqlCommand();
							cmd.Connection = conn;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.CommandText = "create_new_planets";// Название процедуры на сервере
							cmd.Parameters.Add(new SqlParameter("@id_owner", id_new_user));
							cmd.Parameters.Add(new SqlParameter("@galaxy", g));
							cmd.Parameters.Add(new SqlParameter("@planet", p));
							cmd.Parameters.Add(new SqlParameter("@p_imege", rand.Next(0, 15)));
							cmd.Parameters.Add(new SqlParameter("@p_diameter", rand.Next(10000, 20000)));
							cmd.Parameters.Add(new SqlParameter("@p_temperatura", rand.Next(-200, 200)));
							if (cmd.ExecuteNonQuery() > 0)
							{
								cmd = new SqlCommand();
								cmd.Connection = conn;
								cmd.CommandType = CommandType.StoredProcedure;
								cmd.CommandText = "create_rating_users";// Название процедуры на сервере
								cmd.Parameters.Add(new SqlParameter("@id_owner", id_new_user));
								if (cmd.ExecuteNonQuery() > 0)
								{
									cmd = new SqlCommand();
									cmd.Connection = conn;
									cmd.CommandType = CommandType.StoredProcedure;
									cmd.CommandText = "create_prom_war_level_users";// Название процедуры на сервере
									cmd.Parameters.Add(new SqlParameter("@id_owner", id_new_user));
									if (cmd.ExecuteNonQuery() > 0)
									{
										Result = true;
									}
								}
							}
						}
					}
				}
				conn.Close();
			}
			catch (Exception e)
			{
				MessageBox.Show("Ошибка: " + e.Message);
				conn.Close();
			}
			return Result;
		}

		public static int avtorization(string login, string pass)
		{
			int Result = 0;
			SqlConnection conn = new SqlConnection();
			conn.ConnectionString = ConfigurationManager.ConnectionStrings["AccessBD"].ConnectionString;
			try
			{
				conn.Open();
				SqlCommand cmd = new SqlCommand();
				cmd.Connection = conn;
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.Add(new SqlParameter("@login_email", login));
				cmd.Parameters.Add(new SqlParameter("@pass", Convert_String_to_byte(pass)));
				cmd.CommandText = "avtorization_user";// Название процедуры на сервере
				SqlDataReader reader = cmd.ExecuteReader();

				while (reader.Read())
				{
					Result = Convert.ToInt32(reader["id"]);
				}
				conn.Close();
			}
			catch
			{
				conn.Close();
			}
			return Result;
		}
		public static users load_userdata(string login, string pass)
		{
			users Result = new users();
			SqlConnection conn = new SqlConnection();
			conn.ConnectionString = ConfigurationManager.ConnectionStrings["AccessBD"].ConnectionString;
			try
			{
				conn.Open();
				SqlCommand cmd = new SqlCommand();
				cmd.Connection = conn;
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.CommandText = "avtorization_user";// Название процедуры на сервере
				SqlDataReader reader = cmd.ExecuteReader();
				while (reader.Read())
				{
					Result.id = Convert.ToInt32(reader["ID"]);


				}
				conn.Close();
			}
			catch
			{
				conn.Close();
			}
			return Result;
		}
		public static users load_SMS_and_Credits(int ID)
		{
			users Result = new users();
			SqlConnection conn = new SqlConnection();
			conn.ConnectionString = ConfigurationManager.ConnectionStrings["AccessBD"].ConnectionString;
			try
			{
				conn.Open();
				SqlCommand cmd = new SqlCommand();
				cmd.Connection = conn;
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.CommandText = "load_newSMS_credits";// Название процедуры на сервере
				cmd.Parameters.Add(new SqlParameter("@ID_users", ID));
				SqlDataReader reader = cmd.ExecuteReader();
				while (reader.Read())
				{
					Result.new_message = Convert.ToInt32(reader["new_message"]);
					Result.credits = Convert.ToInt32(reader["credits"]);
				}
				conn.Close();
			}
			catch
			{
				conn.Close();
			}
			return Result;
		}
		public static users seting_users_open_Form(int id_user)
		{
			users user = new users();
			SqlConnection conn = new SqlConnection();
			conn.ConnectionString = ConfigurationManager.ConnectionStrings["AccessBD"].ConnectionString;
			try
			{
				conn.Open();
				SqlCommand cmd = new SqlCommand();
				cmd.Connection = conn;
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.CommandText = "select_userer_from_setting";// Название процедуры на сервере
				cmd.Parameters.Add(new SqlParameter("@id_user", id_user));
				SqlDataReader reader = cmd.ExecuteReader();
				while (reader.Read())
				{
					user.login = Convert.ToString(reader["login"]);
					user.pass = Convert_byte_to_String(Convert.ToString(reader["pass"]));
					user.email = Convert.ToString(reader["email"]);
					user.sex = Convert.ToBoolean(reader["sex"]);
					user.avatar_imege = Convert.ToInt32(reader["avatar_imege"]);
				}
				conn.Close();
			}
			catch
			{
				conn.Close();
			}
			return user;
		}
		public static users set_ID_owner(int g, int p)
		{
			users user = new users();
			SqlConnection conn = new SqlConnection();
			conn.ConnectionString = ConfigurationManager.ConnectionStrings["AccessBD"].ConnectionString;
			try
			{
				conn.Open();
				SqlCommand cmd = new SqlCommand();
				cmd.Connection = conn;
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.CommandText = "find_ID_user_on_Galactik_and_planets";// Название процедуры на сервере
				cmd.Parameters.Add(new SqlParameter("@galaxy", g));
				cmd.Parameters.Add(new SqlParameter("@planet", p));
				SqlDataReader reader = cmd.ExecuteReader();
				while (reader.Read())
				{
					user.id = Convert.ToInt32(reader["id_owner"]);
					user.login = Convert.ToString(reader["namse_user"]);
				}
				conn.Close();
			}
			catch
			{
				conn.Close();
			}
			return user;
		}
		public static bool save_UpDate_user(users user, int id_user)
		{
			SqlConnection conn = new SqlConnection();
			conn.ConnectionString = ConfigurationManager.ConnectionStrings["AccessBD"].ConnectionString;
			try
			{
				conn.Open();
				SqlCommand cmd = new SqlCommand();
				cmd.Connection = conn;

				cmd.CommandType = CommandType.StoredProcedure;
				cmd.CommandText = "up_date_user_setting";// Название процедуры на сервере
				cmd.Parameters.Add(new SqlParameter("@id_user", id_user));
				cmd.Parameters.Add(new SqlParameter("@login_new", user.login));
				cmd.Parameters.Add(new SqlParameter("@pass_new", Convert_String_to_byte(user.pass)));
				cmd.Parameters.Add(new SqlParameter("@emal_new", user.email));
				cmd.Parameters.Add(new SqlParameter("@sex_new", user.sex));
				cmd.Parameters.Add(new SqlParameter("@avatar_new", user.avatar_imege));
				if (cmd.ExecuteNonQuery() > 0)
				{
					conn.Close();
					return true;
				}
			}
			catch (Exception e)
			{
				MessageBox.Show("Ошибка: " + e.Message);
				conn.Close();
			}
			return false;
		}
		public static string Convert_String_to_byte(string str)
		{
			var bytes = Encoding.UTF8.GetBytes(str.ToString());
			for (int i = 0; i < bytes.Length; i++) bytes[i] ^= 0x5a;
			return Convert.ToBase64String(bytes);
		}
		public static string Convert_byte_to_String(string str)
		{
			try
			{
				var bytes = Convert.FromBase64String(str);
				for (int i = 0; i < bytes.Length; i++) bytes[i] ^= 0x5a;
				return Encoding.UTF8.GetString(bytes);
			}
			catch (Exception)
			{
				MessageBox.Show("Сообщение не подлежит востановлению!!! Нарушена стуруктура сообщения!!!");
				return "";
			}
		}
		public static bool new_cordinat(int g, int p)
		{
			bool Result = false;
			//
			SqlConnection conn = new SqlConnection();
			conn.ConnectionString = ConfigurationManager.ConnectionStrings["AccessBD"].ConnectionString;
			try
			{
				conn.Open();
				SqlCommand cmd = new SqlCommand();
				cmd.Connection = conn;

				cmd.CommandType = CommandType.StoredProcedure;
				cmd.CommandText = "checking_for_uniqueness_Gal_Plan";// Название процедуры на сервере
				cmd.Parameters.Add(new SqlParameter("@g", g));
				cmd.Parameters.Add(new SqlParameter("@p", p));
				string qp = Convert.ToString(cmd.ExecuteScalar());
				if (qp == "")
					return true;
				conn.Close();
			}
			catch (Exception e)
			{
				MessageBox.Show("Ошибка: " + e.Message);
				conn.Close();
			}
			return Result;
		}
		public static bool new_login_and_email(string L, string E)
		{
			bool Result = false;
			//
			SqlConnection conn = new SqlConnection();
			conn.ConnectionString = ConfigurationManager.ConnectionStrings["AccessBD"].ConnectionString;
			try
			{
				conn.Open();
				SqlCommand cmd = new SqlCommand();
				cmd.Connection = conn;

				cmd.CommandType = CommandType.StoredProcedure;
				cmd.CommandText = "uniqueness_login_email";// Название процедуры на сервере
				cmd.Parameters.Add(new SqlParameter("@login", L));
				cmd.Parameters.Add(new SqlParameter("@emal", E));
				string qp = Convert.ToString(cmd.ExecuteScalar());
				if (qp == "")
					return true;
				conn.Close();
			}
			catch (Exception e)
			{
				MessageBox.Show("Ошибка: " + e.Message);
				conn.Close();
			}
			return Result;
		}

		public static bool online_stat(int id_user, int status)
		{
			SqlConnection conn = new SqlConnection();
			conn.ConnectionString = ConfigurationManager.ConnectionStrings["AccessBD"].ConnectionString;
			try
			{
				conn.Open();
				SqlCommand cmd = new SqlCommand();
				cmd.Connection = conn;

				cmd.CommandType = CommandType.StoredProcedure;
				cmd.CommandText = "user_status_online";// Название процедуры на сервере
				cmd.Parameters.Add(new SqlParameter("@id_user", id_user));
				cmd.Parameters.Add(new SqlParameter("@status", status));
				if (cmd.ExecuteNonQuery() > 0)
					return true;
				conn.Close();
			}
			catch (Exception e)
			{
				MessageBox.Show("Ошибка: " + e.Message);
				conn.Close();
			}
			return false;
		}
	}
}
