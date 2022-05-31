using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;
using System.Data.OleDb;

namespace CRUD_PV
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		MySqlConnection co = new MySqlConnection("Server=localhost; Database=dbkasir; Uid=root");
		MySqlCommand mycommand = new MySqlCommand();
		MySqlDataAdapter myadapter = new MySqlDataAdapter();
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			readData();
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		
		public void readData(){
			try{
				mycommand.Connection = co;
				myadapter.SelectCommand = mycommand;
				mycommand.CommandText = "select * from kasirpv";
				DataSet ds = new DataSet();
				
				if (myadapter.Fill(ds,"dftpesan")>0){
				dataGridView1.DataSource = ds;
				dataGridView1.DataMember = "dftpesan";
				}
			}
			catch (Exception ex){
				 MessageBox.Show(ex.ToString());
			}
		}
		
		
		public void insertData(){
			try{
				co.Open();
				mycommand.Connection=co;
				mycommand.CommandText="insert into kasirpv values('"+Kode.Text+"','"+Nama.Text+"','"+HargaJual.Text+"','"+HargaBeli.Text+"','"+Jumlah.Text+"','"+Satuan.Text+"')";
				myadapter.SelectCommand= mycommand;
				if (mycommand.ExecuteNonQuery()==1){
					MessageBox.Show("Data berhasil dimasukkan", "Informasi", MessageBoxButtons.OK,MessageBoxIcon.Information);
					readData();
				}
				co.Close();
			}
			catch (Exception ex){
				MessageBox.Show(ex.ToString());
 			}
		}
		
		
		public void updateData(){
			try{
				co.Open();
				mycommand.CommandText = "update kasirpv set kodebarang='"+Kode.Text+"',namabarang='"+Nama.Text+"',hargajual='"+HargaJual.Text+"',hargabeli='"+HargaBeli.Text+"',jumlahbarang='"+Jumlah.Text+"',satuanbarang='"+"' where kodebarang ='"+Kode.Text+"'";
				myadapter.SelectCommand = mycommand;
				if (mycommand.ExecuteNonQuery()==1){
					MessageBox.Show("Data berhasil diupdate","Informasi",MessageBoxButtons.OK,MessageBoxIcon.Information);
					readData();
				}
				co.Close();
			}
			catch (Exception ex){
				MessageBox.Show(ex.ToString());
 			}
		}
		
		public void deleteData(){
			try{
				co.Open();
				mycommand.CommandText="delete from kasirpv where KodeBarang='"+Kode.Text+"'";
				myadapter.SelectCommand = mycommand;
				if (mycommand.ExecuteNonQuery()==1){
					MessageBox.Show("Data berhasil dihapus","Informasi",MessageBoxButtons.OK,MessageBoxIcon.Information);
					readData();
				}
				co.Close();
			}
			catch(Exception ex){
				MessageBox.Show(ex.ToString());
			}
		}
		
		
		public void kosongkan(){
			Kode.Text =  "";
			Nama.Text =  "";
			HargaJual.Text =  "";
			HargaBeli.Text =  "";
			Jumlah.Text =  "";
			Satuan.Text = "";
			readData();
		}
		
		public void cariData(){
			try{
				mycommand.Connection = co;
				myadapter.SelectCommand = mycommand;
				mycommand.CommandText = "select * from kasirpv where KodeBarang like '%"+searchBox.Text+"%' or NamaBarang like '%"+searchBox.Text+"%' ";
				DataSet ds = new DataSet();

				if (myadapter.Fill(ds,"dftpesan") > 0){
					dataGridView1.DataSource = ds;
					dataGridView1.DataMember = "dftpesan";
				}
				co.Close();
			}
			catch (Exception ex){
				MessageBox.Show(ex.ToString());
			}
		}
		
		
		void DataGridView1CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			Kode.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
			Nama.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
			HargaJual.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
			HargaBeli.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
			Jumlah.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
			Satuan.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
		}
		
		void UpdateBtnClick(object sender, EventArgs e)
		{
			updateData();
			kosongkan();
		}
		
		void SimpanBtnClick(object sender, EventArgs e)
		{
			insertData();
			kosongkan();
		}
		
		void HapusbtnClickClick(object sender, EventArgs e)
		{
			deleteData();
			kosongkan();
		}
		
		void SearchBoxTextChanged(object sender, EventArgs e)
		{
			cariData();
		}
		
		void RefreshClick(object sender, EventArgs e)
		{
			kosongkan();
		}
		
		
		void SatuanSelectedIndexChanged(object sender, EventArgs e)
		{
			Satuan.Items.Add("unit");
			Satuan.Items.Add("pcs");
			Satuan.Items.Add("kg");
			Satuan.Items.Add("gram");			
		}
		
		
		private void HargaJual_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled= !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
		}
		
		void HargaBeli_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled= !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
		}
		
		void Jumlah_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled= !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;			
		}
		
	}
}
