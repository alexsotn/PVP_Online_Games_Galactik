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
	public partial class forma_treb_FLT_DEFF : Form
	{
		public forma_treb_FLT_DEFF(int user,int codes)
		{
			InitializeComponent();
			grid.DataSource = requirement_trb.get_requirement_trb(user, codes, 300400);
		}
	}
}
