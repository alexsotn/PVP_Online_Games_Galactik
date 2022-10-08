using DIPLOM_SAV.heard_games;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DIPLOM_SAV
{
	public partial class avtorization : Form
	{
		public avtorization()
		{
			InitializeComponent();
			users.status_online onl_list =  users.status_online.load_data();
			txt_online_user.Text = onl_list.user_online_counts.ToString();
			txt_user_all.Text = onl_list.user_online_all.ToString();
		}

		private void txt_pass_Enter(object sender, EventArgs e)
		{
			txt_pass.Text = null;
			txt_pass.ForeColor = Color.Black;
		}

		private void txt_login_Enter(object sender, EventArgs e)
		{
			txt_login.Text = null;
			txt_login.ForeColor = Color.Black;
		}
		public void Leahe(object sender, EventArgs e)
		{
			(sender as TextBox).Invalidate();
			string txt = (sender as TextBox).Text;
			int q = Convert.ToInt32((sender as TextBox).Tag);
			if (txt == "")
			{
				if (q == 1)
				{
					txt_login.Text = "login";
					txt_login.ForeColor = Color.Gray;
				}
				else
				{
					txt_pass.Text = "*****";
					txt_pass.ForeColor = Color.Gray;
				}
			}
		}

		private void reges_Click(object sender, EventArgs e)
		{
			var form = new regestration();
			form.StartPosition = FormStartPosition.CenterScreen;
			form.ShowDialog();
		}

		private void bt_exit_Click(object sender, EventArgs e)
		{
			//Random rand = new Random();
			//MessageBox.Show(Math.Round(Convert.ToDouble((100 * Convert.ToDouble(50)) / Convert.ToDouble(80)),2).ToString());
			Application.Exit();
		}

		private void bt_input_Click(object sender, EventArgs e)
		{
			int ID = users.avtorization(txt_login.Text, txt_pass.Text);
			if ( ID != 0)
			{
				
				var form = new main_F(ID);
				form.StartPosition = FormStartPosition.CenterScreen;
				form.Show();
				Hide();
			}
			else
				MessageBox.Show("Не удалось авторизироваться!");

		}

		private void avtorization_Load(object sender, EventArgs e)
		{
			//users xml_u = users.load_user_xml();
			//if (xml_u.login !=null)
			//{
			//	txt_login.Text = xml_u.login;
			//	txt_pass.Text = xml_u.pass;
			//}
		}
	}
}
