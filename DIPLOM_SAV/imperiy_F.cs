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
	public partial class imperiy_F : Form
	{
		public imperiy_F(int id_user)
		{
			InitializeComponent();
			planets plnts = planets.get_planets_info(id_user);
			name_p.Text = plnts.names_planets;
			poit_XY.Text = "[ " + plnts.G.ToString() + ":" + plnts.P.ToString() + " ]";
			size_P.Text = plnts.p_busyness.ToString() + " / " + plnts.p_max_size.ToString();
			picture_Planet.Image = imageP.Images[plnts.p_imege];
			resurs_planets load_res = resurs_planets.load_res(id_user);
			res_m.Text = load_res.res_metal.ToString("#,#");
			res_k.Text = load_res.res_kristal.ToString("#,#");
			res_d.Text = load_res.res_deuterium.ToString("#,#");
			res_enrg.Text = load_res.res_energy.ToString("#,#");

			res_m_h.Text = load_res.production_metal.ToString("#,#");
			res_k_h.Text = load_res.production_kristal.ToString("#,#");
			res_d_h.Text = load_res.production_deuterium.ToString("#,#");

			planets pln = planets.set_planets_info_from_Arens(id_user);
			Lv_metal.Text = pln.bld_mine_metal.ToString() + " ур.";
			Lv_kristal.Text = pln.bld_mine_kristal.ToString() + " ур.";
			Lv_drt.Text = pln.bld_mine_deuterium.ToString() + " ур.";
			Lv_metal_S.Text = pln.bld_warehouse_metal.ToString() + " ур.";
			Lv_kristal_S.Text = pln.bld_warehouse_kristal.ToString() + " ур.";
			Lv_dtr_S.Text = pln.bld_warehouse_deuterium.ToString() + " ур.";
			Lv_solar.Text = pln.bld_solar_plant.ToString() + " ур.";
			Lv_terraF.Text = pln.bld_terraformer.ToString() + " ур.";
			Lv_lab.Text = pln.bld_laboratory.ToString() + " ур.";
			Lv_nota_fab.Text = pln.bld_nano_factory.ToString() + " ур.";
			Lv_fab_rob.Text = pln.bld_robot_factory.ToString() + " ур.";
			Lv_werf.Text = pln.bld_shipyard.ToString() + "ур.";

			technologies tech = technologies.Load_tech(id_user);
			txt_201.Text = tech.spy_tech.ToString() + " ур.";
			txt_202.Text = tech.computer_tech.ToString() + " ур.";
			txt_203.Text = tech.ataked_tech.ToString() + " ур.";
			txt_204.Text = tech.shield_tech.ToString() + " ур.";
			txt_205.Text = tech.defence_tech.ToString() + " ур.";
			txt_206.Text = tech.energy_tech.ToString() + " ур.";
			txt_207.Text = tech.giper_tech.ToString() + " ур.";
			txt_208.Text = tech.oborona_planets_tech.ToString() + " ур.";
			txt_209.Text = tech.shield_planets_tech.ToString() + " ур.";

			fleets_deff fleets_deff = fleets_deff.get_fleets_deff(id_user);
			t301.Text = fleets_deff.flt_301.ToString();
			t302.Text = fleets_deff.flt_302.ToString();
			t303.Text = fleets_deff.flt_303.ToString();
			t304.Text = fleets_deff.flt_304.ToString();
			t305.Text = fleets_deff.flt_305.ToString();
			t306.Text = fleets_deff.flt_306.ToString();
			t307.Text = fleets_deff.flt_307.ToString();
			t308.Text = fleets_deff.flt_308.ToString();
			t309.Text = fleets_deff.flt_309.ToString();
			t401.Text = fleets_deff.deff_401.ToString();
			t402.Text = fleets_deff.deff_402.ToString();
			t403.Text = fleets_deff.deff_403.ToString();
			t404.Text = fleets_deff.deff_404.ToString();
			t405.Text = fleets_deff.deff_405.ToString();
			t406.Text = fleets_deff.deff_406.ToString();
		}
	}
}
