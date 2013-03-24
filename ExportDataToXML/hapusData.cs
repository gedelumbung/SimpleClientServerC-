/*
 * Created by SharpDevelop.
 * User: Gede Lumbung
 * Date: 31/03/2011
 * Time: 21:27
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
	/// Description of hapusData.
	/// </summary>
	public class hapusData
	{
		MySqlDataAdapter adapter;
		MySqlCommand komand;
		koneksi classKoneksi;
		DataTable tabel;
		string sql="";
		
		public DataTable hapusDataSiswa(int no_induk)
		{
			classKoneksi = new koneksi();
			sql = "delete from tbl_siswa where no_induk="+no_induk+"";
			tabel = new DataTable();
			try {
				classKoneksi.bukaKoneksi();
				komand = new MySqlCommand(sql);
				adapter = new MySqlDataAdapter(sql,classKoneksi.konek);
				adapter.Fill(tabel);
				MessageBox.Show("Berhasil");
			} catch (Exception) {
				MessageBox.Show("error");
			}
			return tabel;
		}

	}
}
