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
	public partial class Simulytor_F : Form
	{
		public Simulytor_F()
		{
			InitializeComponent();
		}

		private void clear_ATT_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			att_tech_O.Value = 0;
			att_tech_Shett.Value = 0;
			att_tech_B.Value = 0;
			//флот
			att_fleet_1.Value = 0;
			att_fleet_2.Value = 0;
			att_fleet_3.Value = 0;
			att_fleet_4.Value = 0;
			att_fleet_5.Value = 0;
			att_fleet_6.Value = 0;
			att_fleet_7.Value = 0;
			att_fleet_8.Value = 0;
		}

		private void clear_DEFF_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			deff_tech_O.Value = 0;
			deff_tech_Sh.Value = 0;
			deff_tech_B.Value = 0;
			deff_tech_ShP.Value = 0;
			//флот
			deff_fleet_1.Value = 0;
			deff_fleet_2.Value = 0;
			deff_fleet_3.Value = 0;
			deff_fleet_4.Value = 0;
			deff_fleet_5.Value = 0;
			deff_fleet_6.Value = 0;
			deff_fleet_7.Value = 0;
			deff_fleet_8.Value = 0;
			//оборона
			deff_obor_1.Value = 0;
			deff_obor_2.Value = 0;
			deff_obor_3.Value = 0;
			deff_obor_4.Value = 0;
			deff_obor_5.Value = 0;
			deff_obor_6.Value = 0;
		}
	}
}
