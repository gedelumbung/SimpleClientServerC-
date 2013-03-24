/*
 * Created by SharpDevelop.
 * User: Gede Lumbung
 * Date: 31/03/2011
 * Time: 20:24
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace ExportDataToXML
{
	/// <summary>
	/// Description of isiData.
	/// </summary>
	public class isiData
	{
		MySqlDataAdapter adapter;
		MySqlCommand komand;
		koneksi classKoneksi;
		DataTable tabel;
		string sql="";
		
		public DataTable tambahData(int no_induk,string nama_siswa, string lahir, string alamat, string pass)
		{
			classKoneksi = new koneksi();
			sql = "insert into tbl_siswa (no_induk,nama_siswa,kelahiran,alamat,password) values ("+no_induk+",'"+nama_siswa+"','"+lahir+"','"+alamat+"','"+pass+"')";
			tabel = new DataTable();
			try {
				classKoneksi.bukaKoneksi();
				komand = new MySqlCommand(sql);
				adapter = new MySqlDataAdapter(sql,classKoneksi.konek);
				adapter.Fill(tabel);
			} catch (Exception) {
				MessageBox.Show("error");
			}
			return tabel;
		}
		
		public DataTable updateData(int no_induk,string nama_siswa, string lahir, string alamat, string pass)
		{
			classKoneksi = new koneksi();
			sql = "update tbl_siswa set nama_siswa='"+nama_siswa+"', kelahiran='"+lahir+"', alamat='"+alamat+"', password='"+pass+"' where no_induk="+no_induk+"";
			tabel = new DataTable();
			try {
				classKoneksi.bukaKoneksi();
				komand = new MySqlCommand(sql);
				adapter = new MySqlDataAdapter(sql,classKoneksi.konek);
				adapter.Fill(tabel);
			} catch (Exception) {
				MessageBox.Show("error");
			}
			return tabel;
		}
	}
}
