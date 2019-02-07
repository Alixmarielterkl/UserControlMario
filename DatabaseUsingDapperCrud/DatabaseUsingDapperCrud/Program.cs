using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using System.Configuration;

namespace DatabaseUsingDapperCrud
{
	static class Program
	{
		/// <summary>
		/// Der Haupteinstiegspunkt für die Anwendung.
		/// </summary>
		[STAThread]
		static void Main()
		{

			NpgsqlConnection connection = new NpgsqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
			try
			{

				connection.Open();

				Application.EnableVisualStyles();
				Application.SetCompatibleTextRenderingDefault(false);
				Application.Run(new Form1());


			}catch (NpgsqlException ex)
			{
				MessageBox.Show($"Test:{ ex.Message}");
			}catch(Exception ex)
			{
				MessageBox.Show("Test",ex.Message);
				return;
			}
			finally
			{
				connection.Close();
			}
		}
	}
}
