/*
 * Created by SharpDevelop.
 * User: Gede Lumbung
 * Date: 20/03/2011
 * Time: 13:16
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace ExportDataToXML
{
	/// <summary>
	/// Description of koneksi.
	/// </summary>
	public class koneksi
	{
		public MySqlConnection konek;
		
		string konfigKoneksi = "server=localhost; database=db_crud; uid=root; pwd=";
		public void bukaKoneksi()
		{
			konek = new MySqlConnection(konfigKoneksi);
			konek.Open();
		}
		public void tutuKoneksi()
		{
			konek = new MySqlConnection(konfigKoneksi);
			konek.Close();
		}
	}
}
