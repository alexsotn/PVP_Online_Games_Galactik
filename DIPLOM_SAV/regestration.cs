using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DIPLOM_SAV.heard_games;

namespace DIPLOM_SAV
{
	public partial class regestration : Form
	{
		public regestration()
		{
			InitializeComponent();
			combo_Wom.SelectedIndex = 0;
		}
		Random rand = new Random();
		int corect_ = -1;
		private void pictureBox1_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void bt_reg_Click(object sender, EventArgs e)
		{

			if (txt_codes.Text != "") {
				if (corect_ == Convert.ToInt32(txt_codes.Text))
				{
					if (txt_login.Text != "" && txt_pass.Text != "" && txt_mail.Text != "")
					{
						int imeges = rand.Next(0, 7);
						bool sex = Convert.ToBoolean(combo_Wom.SelectedIndex);

						if (users.new_login_and_email(txt_login.Text, txt_mail.Text))
						{
							if (users.regist_users(txt_login.Text, txt_pass.Text, txt_mail.Text, sex, imeges))
							{
								MessageBox.Show("Поздравляю с регестрацией! Воспользуйтесь своими данными для входа и войдите в игру)");
								Close();
							}
						}
						else
							MessageBox.Show("Пользватель с таким LOGIN или ПОЧТНОЙ уже существует в ИГРЕ ");

					}
					else
						MessageBox.Show("Какое-то из полей не заполено!!!");
				}
				else
				{
					MessageBox.Show("Неверный код!!!");
					txt_codes.Clear();
				}
			}
			else
			{
				MessageBox.Show("Поле скечкод не заполенно!!!");
				txt_codes.Clear();
			}

		}

		private void regestration_Load(object sender, EventArgs e)
		{
			corect_ = rand.Next(50000, 90000);
			code_skech.Text += "  " + corect_.ToString();
		}
	}
}
