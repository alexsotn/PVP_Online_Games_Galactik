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

	public partial class Bye_Flot_And_Deff : Form
	{
		pay_to_fleets_deff harak_FD; resurs_planets load_res;
		int codes_FD = 0, id_user;
		public Bye_Flot_And_Deff(int id_user_my, int flag)
		{
			InitializeComponent();
			load_res = resurs_planets.load_res(id_user_my);
			codes_FD = flag; id_user = id_user_my;
			switch (flag)
			{
				case 301://флот с 301-309
					imege_ICON.Image = imageL_FleetDeff.Images["fleet_1.gif"];
					neme_obj.Text = "Транспортник";
					txt_info.Text = "У этого корабля нет ни вооружения, ни каких-либо других технологий на борту. По этой причине никогда не следует запускать их без спровождения. Благодаря своему высокоразвитому двигателю внутреннего сгорания большой транспорт служит в качестве быстрого межпланетного доставщика ресурсов, также он сопровождает флоты при нападениях на вражеские планеты, чтобы захватить как можно больше ресурсов.";
					break;
				case 302:
					imege_ICON.Image = imageL_FleetDeff.Images["fleet_2.gif"];
					neme_obj.Text = "Истрибитель";
					txt_info.Text = "При дальнейшем развитии лёгкого истребителя учёные дошли до момента, когда стало ясно, что обыкновенный двигатель не обладает необходимой мощью. Для того, чтобы оптимально передвигать корабль был впервые использован импульсный двигатель.";
					break;
				case 303:
					imege_ICON.Image = imageL_FleetDeff.Images["fleet_3.gif"];
					neme_obj.Text = "Крейсер";
					txt_info.Text = "Крейсеры почти втрое сильней защищены, чем  истребители и обладают более чем удвоенной огневой мощью. К тому же они очень быстры. Нет лучшего оружия против средней защиты";
					break;
				case 304:
					imege_ICON.Image = imageL_FleetDeff.Images["fleet_4.gif"];
					neme_obj.Text = "Линкор";
					txt_info.Text = "Линкоры как правило составляют основу флота. Их тяжёлые орудия, высокая скорость и большой грузовой тоннаж делают их серьёзными противниками.";
					break;
				case 305:
					imege_ICON.Image = imageL_FleetDeff.Images["fleet_5.gif"];
					neme_obj.Text = "Шпионский зонд";
					txt_info.Text = "Шпионские зонды - это маленькие манёвренные корабли, которые доставляют с больших расстояний данные о флотах и планетах. Их высокомощный двигатель позволяет им преодолевать большие расстояния за несколько секунд..";
					break;
				case 306:
					imege_ICON.Image = imageL_FleetDeff.Images["fleet_6.gif"];
					neme_obj.Text = "Бомбордировщик";
					txt_info.Text = "Бомбардировщик был разработан специально для того, чтобы уничтожать планетарную защиту. С помощью лазерного прицела он точно сбрасывает плазменные бомбы на поверхность планеты и таким образом наносит огромные повреждения оборонительным сооружениям.";
					break;
				case 307:
					imege_ICON.Image = imageL_FleetDeff.Images["fleet_7.gif"];
					neme_obj.Text = "Солнечный спутник";
					txt_info.Text = "Один спутник добовляет энергии + 50ед. \nСолнечные спутники запускаются на орбиту планеты. Они фокусируют солнечную энергию и передают её на наземную станцию. Эффективность солнечных спутников зависит от мощи солнечного излучения. Из-за своего соотношения цены и качества солнечные спутники решают энергетические проблемы многих миров. Но внимание: солнечные спутники могут быть уничтожены в бою.";
					break;
				case 308:
					imege_ICON.Image = imageL_FleetDeff.Images["fleet_8.gif"];
					neme_obj.Text = "Уничтожитель";
					txt_info.Text = "Уничтожитель - король среди военных кораблей. Так как уничтожители очень велики, их манёвренность очень ограничена, и в бою они подобны скорее боевой станции, чем боевому кораблю. Потребление дейтерия у них так же высоко, как и их боевая мощь.";
					break;
				case 309:
					imege_ICON.Image = imageL_FleetDeff.Images["fleet_9.gif"];
					neme_obj.Text = "Звезда смерти";
					txt_info.Text = "Звезда смерти оснащена гравитонной пушкой, которая может уничтожать такие корабли, как уничтожитель, и даже луны. Так как для этого требуется большое количество энергии, она состоит почти лишь из генераторов. Только огромные звёздные империи могут вообще предоставить ресурсы и работников, чтобы построить этот размером с луну корабль.";
					break;
				case 401://оборона с 401-406
					imege_ICON.Image = imageL_FleetDeff.Images["1.gif"];
					neme_obj.Text = "Ракетная установка";
					txt_info.Text = "Ракетная установка - простое и дешёвое средство обороны. Так как это развитие обычных баллистических орудий, то ему не требуется дальнейшей модернизации. ";
					break;
				case 402:
					imege_ICON.Image = imageL_FleetDeff.Images["2.gif"];
					neme_obj.Text = "Лазерная установка";
					txt_info.Text = "Для компенсации чрезмерных успехов в области технологии космических кораблей учёные должны были создать оборонительное сооружение, справляющееся с более крупными и лучше вооружёнными флотами. Это привело к появлению рождение лёгкого лазера.";
					break;
				case 403:
					imege_ICON.Image = imageL_FleetDeff.Images["3.gif"];
					neme_obj.Text = "Пушка Гаусса";
					txt_info.Text = "Пушка Гаусса - это ничто иное, как значительно бoльшая версия этой конструкции. Многотонные заряды магнетически ускоряются при огромных затратах энергии и имеют такую выходную скорость, что частички грязи в воздухе вокруг заряда сгорают, а отдача сотрясает землю. ";
					break;
				case 404:
					imege_ICON.Image = imageL_FleetDeff.Images["4.gif"];
					neme_obj.Text = "Ионное орудие";
					txt_info.Text = "В 21-м столетии на Земле уже существовало то, что общеизвестно как ЭМИ. ЭМИ означает электромагнитный импульс, который обладает способностью индуцировать дополнительные напряжения в схемы и тем самым причинять массовые помехи, которые могут уничтожить все чувствительные приборы.";
					break;
				case 405:
					imege_ICON.Image = imageL_FleetDeff.Images["5.gif"];
					neme_obj.Text = "Плазменное орудие";
					txt_info.Text = "Светящийся голубоватым цветом плазменный шар выглядит внушительно, только спрашивается, долго ли им будет наслаждаться команда корабля-цели, если через несколько секунд броня разорвётся на куски, а электроника сгорит... Плазменное орудие считается вообще самым страшным оружием, и у этой техники есть своя цена.";
					break;
				case 406:
					imege_ICON.Image = imageL_FleetDeff.Images["6.jpg"];
					neme_obj.Text = "Щитовой купол";
					txt_info.Text = "Развитие щитовой технологии привело к появлению щитового поля поланеты. Он состоит из читой энергии и спопобен принять на себя первый удар атукующего флота";
					break;

			}
			harak_FD = pay_to_fleets_deff.set_pay_to_FD(id_user_my, flag);
			txt_att.Text = harak_FD.attack.ToString("#,#");
			txt_chit.Text = harak_FD.shields.ToString("#,#");
			txt_deff.Text = harak_FD.armor.ToString("#,#");
			txt_gruz.Text = harak_FD.hold.ToString("#,#");
			txt_speeds.Text = harak_FD.speed.ToString("#,#");
			txt_PD.Text = harak_FD.consumption_ditriy.ToString("#,#");
			time_naims.Text = harak_FD.time_str;

			res_M.Text = harak_FD.res_m.ToString("#,#");
			res_K.Text = harak_FD.res_k.ToString("#,#");
			res_D.Text = harak_FD.res_d.ToString("#,#");

			colich.Maximum = max_have();
		}

		private void Bye_Flot_And_Deff_Load(object sender, EventArgs e)
		{
			pb_metal.Image = ListI_resurs.Images[0];
			pb_kristal.Image = ListI_resurs.Images[1];
			pb_detr.Image = ListI_resurs.Images[2];
		}

		private void max_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			colich.Value = colich.Maximum;

		}

		public int max_have()
		{
			int have_metal = -1, have_kristal = -1, have_detrium = -1;
			if (harak_FD.res_m > 0)
				have_metal = Convert.ToInt32(load_res.res_metal / harak_FD.res_m);
			if (harak_FD.res_k > 0)
				have_kristal = Convert.ToInt32(load_res.res_kristal / harak_FD.res_k);
			if (harak_FD.res_d > 0)
				have_detrium = Convert.ToInt32(load_res.res_deuterium / harak_FD.res_d);
			int[] mas_int = new int[3] { have_metal, have_kristal, have_detrium };
			int colich_item_min = 999999999;
			for (int i = 0; i < mas_int.Count(); i++)
			{
				if (colich_item_min > mas_int[i] && mas_int[i] > 0)
					colich_item_min = mas_int[i];
			}
			return colich_item_min;
		}

		private void colich_ValueChanged(object sender, EventArgs e)
		{
			if (colich.Maximum > 0)
			{
				res_M.Text = (harak_FD.res_m * colich.Value).ToString("#,#");
				res_K.Text = (harak_FD.res_k * colich.Value).ToString("#,#");
				res_D.Text = (harak_FD.res_d * colich.Value).ToString("#,#");
			}
		}

		private void min_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			if (colich.Maximum > 0)
				colich.Value = 1;

		}

		private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			if (colich.Value != 0)
			{
				if (resurs_planets.to_pay(id_user, Convert.ToInt64(harak_FD.res_m * colich.Value), Convert.ToInt64(harak_FD.res_k * colich.Value), Convert.ToInt64(harak_FD.res_d * colich.Value)))
				{
					if (timer_tech_prom_deff_fleets.hire_fllet_deff(id_user, codes_FD, harak_FD.time_fleets, Convert.ToInt32(colich.Value)))
					{
						MessageBox.Show("Вы поставили на наем: " + colich.Value.ToString() + " ед.");
						Close();
					}
				}
			}
			else
				MessageBox.Show("У вас не хватает ресурсов!!!!");
		}

		private void bt_Home_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
