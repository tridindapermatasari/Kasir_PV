/*
 * Created by SharpDevelop.
 * User: Amru khair
 * Date: 4/20/2022
 * Time: 7:30 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace CRUD_PV
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.Kode = new System.Windows.Forms.TextBox();
			this.Nama = new System.Windows.Forms.TextBox();
			this.HargaJual = new System.Windows.Forms.TextBox();
			this.HargaBeli = new System.Windows.Forms.TextBox();
			this.Jumlah = new System.Windows.Forms.TextBox();
			this.SimpanBtn = new System.Windows.Forms.Button();
			this.UpdateBtn = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.HapusbtnClick = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.searchBox = new System.Windows.Forms.TextBox();
			this.refresh = new System.Windows.Forms.Button();
			this.Satuan = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(9, 63);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(75, 19);
			this.label1.TabIndex = 0;
			this.label1.Text = "Kode Barang";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(7, 94);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(75, 19);
			this.label2.TabIndex = 1;
			this.label2.Text = "Nama Barang";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(8, 129);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(75, 19);
			this.label3.TabIndex = 2;
			this.label3.Text = "Harga Jual";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(9, 165);
			this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(75, 19);
			this.label4.TabIndex = 3;
			this.label4.Text = "Harga Beli";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(10, 196);
			this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(77, 19);
			this.label5.TabIndex = 4;
			this.label5.Text = "Jumlah";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(7, 226);
			this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(75, 19);
			this.label6.TabIndex = 5;
			this.label6.Text = "Satuan";
			// 
			// Kode
			// 
			this.Kode.Location = new System.Drawing.Point(89, 61);
			this.Kode.Margin = new System.Windows.Forms.Padding(2);
			this.Kode.Name = "Kode";
			this.Kode.Size = new System.Drawing.Size(236, 20);
			this.Kode.TabIndex = 6;
			// 
			// Nama
			// 
			this.Nama.Location = new System.Drawing.Point(88, 91);
			this.Nama.Margin = new System.Windows.Forms.Padding(2);
			this.Nama.Name = "Nama";
			this.Nama.Size = new System.Drawing.Size(237, 20);
			this.Nama.TabIndex = 7;
			// 
			// HargaJual
			// 
			this.HargaJual.Location = new System.Drawing.Point(88, 127);
			this.HargaJual.Margin = new System.Windows.Forms.Padding(2);
			this.HargaJual.Name = "HargaJual";
			this.HargaJual.Size = new System.Drawing.Size(237, 20);
			this.HargaJual.TabIndex = 8;
			this.HargaJual.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HargaJual_KeyPress);
			// 
			// HargaBeli
			// 
			this.HargaBeli.Location = new System.Drawing.Point(88, 162);
			this.HargaBeli.Margin = new System.Windows.Forms.Padding(2);
			this.HargaBeli.Name = "HargaBeli";
			this.HargaBeli.Size = new System.Drawing.Size(237, 20);
			this.HargaBeli.TabIndex = 9;
			this.HargaBeli.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HargaBeli_KeyPress);
			// 
			// Jumlah
			// 
			this.Jumlah.Location = new System.Drawing.Point(88, 196);
			this.Jumlah.Margin = new System.Windows.Forms.Padding(2);
			this.Jumlah.Name = "Jumlah";
			this.Jumlah.Size = new System.Drawing.Size(236, 20);
			this.Jumlah.TabIndex = 10;
			this.Jumlah.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Jumlah_KeyPress);
			// 
			// SimpanBtn
			// 
			this.SimpanBtn.BackColor = System.Drawing.SystemColors.Info;
			this.SimpanBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SimpanBtn.Location = new System.Drawing.Point(396, 107);
			this.SimpanBtn.Margin = new System.Windows.Forms.Padding(2);
			this.SimpanBtn.Name = "SimpanBtn";
			this.SimpanBtn.Size = new System.Drawing.Size(115, 35);
			this.SimpanBtn.TabIndex = 12;
			this.SimpanBtn.Text = "Simpan";
			this.SimpanBtn.UseVisualStyleBackColor = false;
			this.SimpanBtn.Click += new System.EventHandler(this.SimpanBtnClick);
			// 
			// UpdateBtn
			// 
			this.UpdateBtn.BackColor = System.Drawing.SystemColors.Info;
			this.UpdateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.UpdateBtn.Location = new System.Drawing.Point(516, 107);
			this.UpdateBtn.Margin = new System.Windows.Forms.Padding(2);
			this.UpdateBtn.Name = "UpdateBtn";
			this.UpdateBtn.Size = new System.Drawing.Size(113, 35);
			this.UpdateBtn.TabIndex = 13;
			this.UpdateBtn.Text = "Update";
			this.UpdateBtn.UseVisualStyleBackColor = false;
			this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtnClick);
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(8, 305);
			this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(643, 251);
			this.dataGridView1.TabIndex = 14;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1CellContentClick);
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1CellContentClick);
			// 
			// HapusbtnClick
			// 
			this.HapusbtnClick.BackColor = System.Drawing.SystemColors.Info;
			this.HapusbtnClick.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.HapusbtnClick.Location = new System.Drawing.Point(395, 156);
			this.HapusbtnClick.Name = "HapusbtnClick";
			this.HapusbtnClick.Size = new System.Drawing.Size(116, 34);
			this.HapusbtnClick.TabIndex = 15;
			this.HapusbtnClick.Text = "Hapus";
			this.HapusbtnClick.UseVisualStyleBackColor = false;
			this.HapusbtnClick.Click += new System.EventHandler(this.HapusbtnClickClick);
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(0, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(100, 23);
			this.label7.TabIndex = 20;
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(207, 19);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(304, 23);
			this.label8.TabIndex = 18;
			this.label8.Text = "Kasir Pemrograman Visual";
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(344, 273);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(100, 23);
			this.label9.TabIndex = 21;
			this.label9.Text = "Cari Barang";
			// 
			// searchBox
			// 
			this.searchBox.Location = new System.Drawing.Point(422, 270);
			this.searchBox.Name = "searchBox";
			this.searchBox.Size = new System.Drawing.Size(229, 20);
			this.searchBox.TabIndex = 22;
			this.searchBox.TextChanged += new System.EventHandler(this.SearchBoxTextChanged);
			// 
			// refresh
			// 
			this.refresh.BackColor = System.Drawing.SystemColors.Info;
			this.refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.refresh.Location = new System.Drawing.Point(517, 156);
			this.refresh.Name = "refresh";
			this.refresh.Size = new System.Drawing.Size(112, 34);
			this.refresh.TabIndex = 23;
			this.refresh.Text = "Refresh";
			this.refresh.UseVisualStyleBackColor = false;
			this.refresh.Click += new System.EventHandler(this.RefreshClick);
			// 
			// Satuan
			// 
			this.Satuan.FormattingEnabled = true;
			this.Satuan.Items.AddRange(new object[] {
									"unit",
									"pcs",
									"kg",
									"gram"});
			this.Satuan.Location = new System.Drawing.Point(87, 226);
			this.Satuan.Name = "Satuan";
			this.Satuan.Size = new System.Drawing.Size(238, 21);
			this.Satuan.TabIndex = 24;
			this.Satuan.SelectedIndexChanged += new System.EventHandler(this.SatuanSelectedIndexChanged);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.ClientSize = new System.Drawing.Size(662, 576);
			this.Controls.Add(this.Satuan);
			this.Controls.Add(this.refresh);
			this.Controls.Add(this.searchBox);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.HapusbtnClick);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.UpdateBtn);
			this.Controls.Add(this.SimpanBtn);
			this.Controls.Add(this.Jumlah);
			this.Controls.Add(this.HargaBeli);
			this.Controls.Add(this.HargaJual);
			this.Controls.Add(this.Nama);
			this.Controls.Add(this.Kode);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "MainForm";
			this.Text = "Kasir";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ComboBox Satuan;
		private System.Windows.Forms.Button refresh;
		private System.Windows.Forms.TextBox searchBox;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button HapusbtnClick;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button UpdateBtn;
		private System.Windows.Forms.Button SimpanBtn;
		private System.Windows.Forms.TextBox Jumlah;
		private System.Windows.Forms.TextBox HargaBeli;
		private System.Windows.Forms.TextBox HargaJual;
		private System.Windows.Forms.TextBox Nama;
		private System.Windows.Forms.TextBox Kode;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		
	
	}
}
