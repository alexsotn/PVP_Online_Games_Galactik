
namespace DIPLOM_SAV
{
	partial class rating_F
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.combo_sort = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.grid_rating = new System.Windows.Forms.DataGridView();
			this.ID_user = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.pos = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Gamer = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Balls = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tableLayoutPanel1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grid_rating)).BeginInit();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
			this.tableLayoutPanel1.ColumnCount = 3;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 400F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 400F));
			this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 3);
			this.tableLayoutPanel1.Controls.Add(this.label1, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 2);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 5;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(1300, 800);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.grid_rating);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(403, 153);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(494, 594);
			this.panel1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(403, 60);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(494, 50);
			this.label1.TabIndex = 1;
			this.label1.Text = "РЕЙТИНГ";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.combo_sort);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(403, 113);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(494, 34);
			this.panel2.TabIndex = 2;
			// 
			// combo_sort
			// 
			this.combo_sort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.combo_sort.FormattingEnabled = true;
			this.combo_sort.Items.AddRange(new object[] {
            "Все",
            "Флот",
            "Оборона",
            "Пойстройки",
            "Исследование"});
			this.combo_sort.Location = new System.Drawing.Point(224, 4);
			this.combo_sort.Name = "combo_sort";
			this.combo_sort.Size = new System.Drawing.Size(158, 28);
			this.combo_sort.TabIndex = 1;
			this.combo_sort.SelectedIndexChanged += new System.EventHandler(this.combo_sort_SelectedIndexChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(121, 7);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(97, 20);
			this.label2.TabIndex = 0;
			this.label2.Text = "Рейтинг по:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// grid_rating
			// 
			this.grid_rating.AllowUserToAddRows = false;
			this.grid_rating.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.grid_rating.BackgroundColor = System.Drawing.Color.SteelBlue;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.grid_rating.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.grid_rating.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grid_rating.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_user,
            this.pos,
            this.Gamer,
            this.Balls});
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.grid_rating.DefaultCellStyle = dataGridViewCellStyle2;
			this.grid_rating.Dock = System.Windows.Forms.DockStyle.Fill;
			this.grid_rating.Location = new System.Drawing.Point(0, 0);
			this.grid_rating.Name = "grid_rating";
			this.grid_rating.ReadOnly = true;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.grid_rating.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.grid_rating.RowHeadersVisible = false;
			this.grid_rating.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.grid_rating.Size = new System.Drawing.Size(494, 594);
			this.grid_rating.TabIndex = 0;
			this.grid_rating.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_rating_CellDoubleClick);
			// 
			// ID_user
			// 
			this.ID_user.DataPropertyName = "users_id";
			this.ID_user.HeaderText = "ID_user";
			this.ID_user.Name = "ID_user";
			this.ID_user.ReadOnly = true;
			this.ID_user.Visible = false;
			// 
			// pos
			// 
			this.pos.DataPropertyName = "pozition";
			this.pos.HeaderText = "Место";
			this.pos.Name = "pos";
			this.pos.ReadOnly = true;
			// 
			// Gamer
			// 
			this.Gamer.DataPropertyName = "names_user";
			this.Gamer.HeaderText = "Игрок";
			this.Gamer.Name = "Gamer";
			this.Gamer.ReadOnly = true;
			// 
			// Balls
			// 
			this.Balls.DataPropertyName = "balls";
			this.Balls.HeaderText = "Очки";
			this.Balls.Name = "Balls";
			this.Balls.ReadOnly = true;
			// 
			// rating_F
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::DIPLOM_SAV.Properties.Resources.background_IMAGE;
			this.ClientSize = new System.Drawing.Size(1300, 800);
			this.Controls.Add(this.tableLayoutPanel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "rating_F";
			this.Load += new System.EventHandler(this.rating_F_Load);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.grid_rating)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.ComboBox combo_sort;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DataGridView grid_rating;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID_user;
		private System.Windows.Forms.DataGridViewTextBoxColumn pos;
		private System.Windows.Forms.DataGridViewTextBoxColumn Gamer;
		private System.Windows.Forms.DataGridViewTextBoxColumn Balls;
	}
}