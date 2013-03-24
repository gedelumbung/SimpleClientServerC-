/*
 * Created by SharpDevelop.
 * User: Gede Lumbung
 * Date: 20/03/2011
 * Time: 13:14
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Xml;

namespace ExportDataToXML
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public DataTable tabel;
		public DataGridViewButtonColumn editData,hapusData;
		public MainForm()
		{
			InitializeComponent();
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			bacaData bc = new bacaData();
			tabel = bc.bacaDataSemua();
			TampilSemua(tabel);
		}
		public void TampilSemua(DataTable tabel)
		{
			tampil.DataSource = null;
			tampil.Columns.Clear();
			tampil.DataSource = tabel;
			tampil.AllowUserToAddRows = false;
			tampil.ReadOnly = true;
            tampil.Columns[0].Visible = false;
            tampil.Columns[1].HeaderText = "Nama Siswa";
            tampil.Columns[1].Width = 120; //tipe cd
            tampil.Columns[2].HeaderText = "Kelahiran";
            tampil.Columns[2].Width = 150; //nama cd
            tampil.Columns[3].HeaderText = "ALamat";
            tampil.Columns[3].Width = 120; //tipe cd
            tampil.Columns[4].Visible = false;
			editData = new DataGridViewButtonColumn();
			editData.UseColumnTextForButtonValue = true;
			editData.Width = 65;
			editData.Text = "Edit";
			tampil.Columns.Add(editData);
			hapusData = new DataGridViewButtonColumn();
			hapusData.UseColumnTextForButtonValue = true;
			hapusData.Width = 65;
			hapusData.Text = "Hapus";
			tampil.Columns.Add(hapusData);
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			XmlWriterSettings setting = new XmlWriterSettings();
			setting.Indent = true;
				
			XmlWriter writter =  XmlWriter.Create("D://Data Export.html",setting);
			writter.WriteStartDocument();
			writter.WriteStartElement("table");
			for (int i=0;i<tampil.Rows.Count ;i++ ) {
				writter.WriteStartElement("tr");
				for (int j=0;j<tampil.Columns.Count ;j++ ) {
					//(tampilNilai[0,j].Value.ToString(),tampilNilai[i,j].Value.ToString());
					writter.WriteElementString("td",tampil[j,i].Value.ToString());
				}
				writter.WriteEndElement();
			}
			writter.WriteEndElement();
			writter.WriteEndDocument();
			writter.Flush();
			writter.Close();
			MessageBox.Show("Data berhasil di export ke D://Data Export.html");
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			bacaData bc = new bacaData();
			tabel = bc.bacaDataSemua();
			TampilSemua(tabel);
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			frmTambahData f1 = new frmTambahData();
			f1.status = "tambah";
			f1.ShowDialog();
		}
		
		void TampilCellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			int baris = int.Parse(e.RowIndex.ToString());
			int no_induk= int.Parse(tampil[0,baris].Value.ToString());
			string nama_siswa = tampil[1,baris].Value.ToString();
			string kelahiran = tampil[2,baris].Value.ToString();
			string alamat = tampil[3,baris].Value.ToString();
			string pass = tampil[4,baris].Value.ToString();
			if (tampil.Columns[e.ColumnIndex] == editData && baris >=0) {
				frmTambahData f2 = new frmTambahData();
				f2.n_induk = no_induk;
				f2.nama = nama_siswa;
				f2.lhr = kelahiran;
				f2.almt = alamat;
				f2.pwd = pass;
				f2.ShowDialog();
			}
			else if (tampil.Columns[e.ColumnIndex] == hapusData && baris >=0) {
				hapusData hps = new hapusData();
				tabel = hps.hapusDataSiswa(no_induk);
			}
		}
	}
}
