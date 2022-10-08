
namespace DIPLOM_SAV
{
	partial class forma_treb_FLT_DEFF
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
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.grid = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.name_T = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Lv_neob = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Lv_esct = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cheken = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.Controls.Add(this.grid, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(645, 199);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// grid
			// 
			this.grid.AllowUserToAddRows = false;
			this.grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name_T,
            this.Lv_neob,
            this.Lv_esct,
            this.cheken});
			this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
			this.grid.Enabled = false;
			this.grid.Location = new System.Drawing.Point(3, 43);
			this.grid.Name = "grid";
			this.grid.ReadOnly = true;
			this.grid.RowHeadersVisible = false;
			this.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.grid.Size = new System.Drawing.Size(639, 153);
			this.grid.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label1.Location = new System.Drawing.Point(3, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(639, 40);
			this.label1.TabIndex = 0;
			this.label1.Text = "НЕобходимо открыть!";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// name_T
			// 
			this.name_T.DataPropertyName = "name_trb";
			this.name_T.FillWeight = 232.9019F;
			this.name_T.HeaderText = "Наименование";
			this.name_T.Name = "name_T";
			this.name_T.ReadOnly = true;
			// 
			// Lv_neob
			// 
			this.Lv_neob.DataPropertyName = "trb_level";
			this.Lv_neob.FillWeight = 69.69801F;
			this.Lv_neob.HeaderText = "Нужно";
			this.Lv_neob.Name = "Lv_neob";
			this.Lv_neob.ReadOnly = true;
			// 
			// Lv_esct
			// 
			this.Lv_esct.DataPropertyName = "have_leval";
			this.Lv_esct.FillWeight = 77.09551F;
			this.Lv_esct.HeaderText = "Есть";
			this.Lv_esct.Name = "Lv_esct";
			this.Lv_esct.ReadOnly = true;
			// 
			// cheken
			// 
			this.cheken.DataPropertyName = "chek";
			this.cheken.FillWeight = 20.30457F;
			this.cheken.HeaderText = "*";
			this.cheken.Name = "cheken";
			this.cheken.ReadOnly = true;
			// 
			// forma_treb_FLT_DEFF
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::DIPLOM_SAV.Properties.Resources.tab2r_bg;
			this.ClientSize = new System.Drawing.Size(645, 199);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Margin = new System.Windows.Forms.Padding(6);
			this.Name = "forma_treb_FLT_DEFF";
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView grid;
		private System.Windows.Forms.DataGridViewTextBoxColumn name_T;
		private System.Windows.Forms.DataGridViewTextBoxColumn Lv_neob;
		private System.Windows.Forms.DataGridViewTextBoxColumn Lv_esct;
		private System.Windows.Forms.DataGridViewCheckBoxColumn cheken;
	}
}