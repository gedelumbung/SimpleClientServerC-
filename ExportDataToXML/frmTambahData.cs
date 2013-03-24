/*
 * Created by SharpDevelop.
 * User: Gede Lumbung
 * Date: 31/03/2011
 * Time: 20:35
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data;

namespace ExportDataToXML
{
	/// <summary>
	/// Description of frmTambahData.
	/// </summary>
	public partial class frmTambahData : Form
	{
		public DataTable tabel;
		public string status="";
		public int n_induk;
		public string nama,lhr,almt,pwd;
		public frmTambahData()
		{
			InitializeComponent();
		}
		
		void NoIndukTextChanged(object sender, EventArgs e)
		{
			try {
				int induk = Convert.ToInt32(noInduk.Text.ToString());
			} catch (Exception) {
				MessageBox.Show("Input harus angka");
				noInduk.Text="";
			}
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			isiData isi = new isiData();
			tabel = isi.tambahData(Convert.ToInt32(noInduk.Text.ToString()),namaSiswa.Text.ToString(),keLahiran.Text.ToString(),aLamat.Text.ToString(),passWord.Text.ToString());
			MessageBox.Show("Berhasil");
			this.Close();
		}
		
		void FrmTambahDataLoad(object sender, EventArgs e)
		{
			if (status=="tambah") {
				button3.Visible=true;
				button1.Visible=false;
			}
			else{
				button3.Visible=false;
				button1.Visible=true;
				noInduk.Text=n_induk.ToString();
				namaSiswa.Text=nama;
				keLahiran.Text=lhr;
				aLamat.Text=almt;
				passWord.Text=pwd;
			}
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			isiData isi = new isiData();
			tabel = isi.updateData(Convert.ToInt32(noInduk.Text.ToString()),namaSiswa.Text.ToString(),keLahiran.Text.ToString(),aLamat.Text.ToString(),passWord.Text.ToString());
			MessageBox.Show("Berhasil");
			this.Close();
		}
	}
}
