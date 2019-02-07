using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using Dapper;
using System.Data;
using Npgsql;

namespace DatabaseUsingDapperCrud
{
	public partial class Form1 : MetroFramework.Forms.MetroForm
	{
		Entitystate objState = Entitystate.Unchanged; 
		public Form1()
		{
			InitializeComponent();
		}

		private void mbtnbrower_Click(object sender, EventArgs e)
		{
			//using (OpenFileDialog openFileDialog = new OpenFileDialog() { Filter= "JPEG|*.jpg|PNG|*.png", ValidateNames = true })
			//{

			//	if (openFileDialog()== DialogResult.OK)
			//	{
			//		pictureBox1 = Image.FromFile(openFileDialog.FileName);
			//		Teilnehmer obj = teilnehmerBindingSource.Current as Teilnehmer;


			//		if (obj !=null ) imageUrl = openFileDialog.FileName;
					

					
			//	}
			//} Das ist für den picturyBox aber ich habe keine foto in database erstellt deshalbb brauche ich sie nicht°°°°°°°°^^^^^^



		} 
		void CLEARImput()
		{

			txtname.Text = null;
			txtvorname.Text = null;
			txtGebdat.Text = null;
			txtteilid.Text = null;
			txtkurs.Text = null;
			txtGebdat.Text = null;
			

		}

		private void Form1_Load(object sender, EventArgs e)
		{
			
			try
			{
				using (IDbConnection db = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["ConnetionString"].ConnectionString))
				{
					if (db.State == ConnectionState.Closed)
						db.Open();
					teilnehmerBindingSource.DataSource = db.Query<Teilnehmer>("select * from teilnehmer", commandType: CommandType.Text);
					metroPanel1.Enabled = false;
				}

			}
			catch (Exception ex)
			{

				MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void metroButton1_Click(object sender, EventArgs e)
		{
			objState = Entitystate.Added;
			pictureBox1 = null;
			metroPanel1.Enabled = true;
			teilnehmerBindingSource.Add(new Teilnehmer());
			teilnehmerBindingSource.MoveLast();
			txtname.Focus();
		}

		private void metroButton4_Click(object sender, EventArgs e)
		{
			metroPanel1.Enabled = false;
			teilnehmerBindingSource.ResetBindings(false);
			//CLEARImput();

			this.Form1_Load(sender, e);
		}

		private void metroButton3_Click(object sender, EventArgs e)
		{
			objState = Entitystate.Changed;
			metroPanel1.Enabled = true;
			txtname.Focus();
		}

		private void metroGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				Teilnehmer obj = teilnehmerBindingSource.Current as Teilnehmer;
				if (obj != null)
				{
					if (!string.IsNullOrEmpty(obj.imageUrl))
						pictureBox1.Image = Image.FromFile(obj.imageUrl);
				}
			}
			catch(Exception ex)
			{
				MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

			}
		}

		private void metroButton2_Click(object sender, EventArgs e)
		{
			objState = Entitystate.Delected;
			if (MetroFramework.MetroMessageBox.Show(this, "Willst du es Wircklich löschen?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				try
				{

					Teilnehmer obj = teilnehmerBindingSource.Current as Teilnehmer;

					if (obj != null)
					{
						using (IDbConnection db = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString))
						{
							if (db.State == ConnectionState.Closed)
								db.Open();
							int result = db.Execute("delete  from teilnehmer where id_teilnehmer= @id_teilnehmer",new { id_teilnehmer = obj.id_teilnehmer }, commandType: CommandType.Text);
							if (result != 0)
							{
								teilnehmerBindingSource.RemoveCurrent();
								metroPanel1.Enabled = false;
								//pictureBox1.Image = null;
								objState = Entitystate.Unchanged;
							}
						}
					}
				}
				catch (Exception ex)
				{

					MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private void metroButton5_Click(object sender, EventArgs e)
		{
			try
			{
				teilnehmerBindingSource.EndEdit();
				Teilnehmer obj = teilnehmerBindingSource.Current as Teilnehmer;

				if (obj != null)
				{
					using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString))
					{
						if (db.State == ConnectionState.Closed)
							db.Open();
						if (objState == Entitystate.Added)
						{
							DynamicParameters parameters = new DynamicParameters();
							parameters.Add("@id_teilnehmer", dbType: DbType.Int32, direction: ParameterDirection.Output);
							parameters.AddDynamicParams(new { name = obj.name, vorname = obj.vorname, geburtsdatum = obj.geb_dat, kurs = obj.kurs });
							db.Execute("sp_teilnehmer_insert", parameters, commandType: CommandType.StoredProcedure);
							obj.id_teilnehmer = parameters.Get<int>("@id_teilnehmer");
						}
						else if(objState == Entitystate.Changed)
						{
							db.Execute("sp_teilnehmer_update", new { id_teilnehmer = obj.id_teilnehmer, name = obj.name, vorname = obj.vorname, geburtsdatum = obj.geb_dat, kurs = obj.kurs }, commandType: CommandType.StoredProcedure);

						}
						metroGrid1.Refresh();
						metroPanel1.Enabled = false;
						objState = Entitystate.Unchanged;
						
					}
				}
			}
			catch (Exception ex)
			{

				MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
