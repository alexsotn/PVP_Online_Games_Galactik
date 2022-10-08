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
	public partial class rating_F : Form
	{
		main_F F; int my_id = 0;
		public rating_F(main_F f, int id)
		{
			InitializeComponent();
			F = f;
			my_id = id;
		}

		private void rating_F_Load(object sender, EventArgs e)
		{
			combo_sort.SelectedIndex = 0;
			grid_rating.DataSource = rating_list.list(0);
		}

		private void combo_sort_SelectedIndexChanged(object sender, EventArgs e)
		{
			grid_rating.DataSource = rating_list.list(combo_sort.SelectedIndex);
		}

		private void grid_rating_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			int id = Convert.ToInt32(this.grid_rating.CurrentRow.Cells[0].Value);
			var form_1 = new inform_user(my_id, id, F);
			form_1.StartPosition = FormStartPosition.CenterScreen;
			tableLayoutPanel1.Visible = false;
			form_1.ShowDialog();
			tableLayoutPanel1.Visible = true;
		}
	}
}
