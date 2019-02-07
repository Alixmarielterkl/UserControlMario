namespace DatabaseUsingDapperCrud
{
	partial class Form1
	{
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Verwendete Ressourcen bereinigen.
		/// </summary>
		/// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Vom Windows Form-Designer generierter Code

		/// <summary>
		/// Erforderliche Methode für die Designerunterstützung.
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
			this.teilnehmerBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
			this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
			this.txtkurs = new MetroFramework.Controls.MetroTextBox();
			this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
			this.txtGebdat = new MetroFramework.Controls.MetroTextBox();
			this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
			this.txtvorname = new MetroFramework.Controls.MetroTextBox();
			this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
			this.txtname = new MetroFramework.Controls.MetroTextBox();
			this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
			this.mbtnbrower = new MetroFramework.Controls.MetroButton();
			this.txtteilid = new MetroFramework.Controls.MetroTextBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.metroButton1 = new MetroFramework.Controls.MetroButton();
			this.metroButton2 = new MetroFramework.Controls.MetroButton();
			this.metroButton3 = new MetroFramework.Controls.MetroButton();
			this.metroButton4 = new MetroFramework.Controls.MetroButton();
			this.metroButton5 = new MetroFramework.Controls.MetroButton();
			this.idteilnehmerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.vornameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.gebdatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.anmeldnumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.kursDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
			this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
			this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
			this.metroTextBox2 = new MetroFramework.Controls.MetroTextBox();
			this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
			this.metroTextBox3 = new MetroFramework.Controls.MetroTextBox();
			((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.teilnehmerBindingSource)).BeginInit();
			this.metroPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// metroGrid1
			// 
			this.metroGrid1.AllowUserToResizeRows = false;
			this.metroGrid1.AutoGenerateColumns = false;
			this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.metroGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idteilnehmerDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.vornameDataGridViewTextBoxColumn,
            this.gebdatDataGridViewTextBoxColumn,
            this.anmeldnumDataGridViewTextBoxColumn,
            this.kursDataGridViewTextBoxColumn});
			this.metroGrid1.DataSource = this.teilnehmerBindingSource;
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle5;
			this.metroGrid1.EnableHeadersVisualStyles = false;
			this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.metroGrid1.Location = new System.Drawing.Point(209, 404);
			this.metroGrid1.Name = "metroGrid1";
			this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
			dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
			this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.metroGrid1.Size = new System.Drawing.Size(889, 227);
			this.metroGrid1.TabIndex = 0;
			this.metroGrid1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGrid1_CellClick);
			// 
			// teilnehmerBindingSource
			// 
			this.teilnehmerBindingSource.DataSource = typeof(DatabaseUsingDapperCrud.Teilnehmer);
			// 
			// metroPanel1
			// 
			this.metroPanel1.Controls.Add(this.metroLabel8);
			this.metroPanel1.Controls.Add(this.metroTextBox3);
			this.metroPanel1.Controls.Add(this.metroLabel7);
			this.metroPanel1.Controls.Add(this.metroTextBox2);
			this.metroPanel1.Controls.Add(this.metroLabel6);
			this.metroPanel1.Controls.Add(this.metroTextBox1);
			this.metroPanel1.Controls.Add(this.metroLabel5);
			this.metroPanel1.Controls.Add(this.txtkurs);
			this.metroPanel1.Controls.Add(this.metroLabel4);
			this.metroPanel1.Controls.Add(this.txtGebdat);
			this.metroPanel1.Controls.Add(this.metroLabel3);
			this.metroPanel1.Controls.Add(this.txtvorname);
			this.metroPanel1.Controls.Add(this.metroLabel2);
			this.metroPanel1.Controls.Add(this.txtname);
			this.metroPanel1.Controls.Add(this.metroLabel1);
			this.metroPanel1.Controls.Add(this.mbtnbrower);
			this.metroPanel1.Controls.Add(this.txtteilid);
			this.metroPanel1.Controls.Add(this.pictureBox1);
			this.metroPanel1.HorizontalScrollbarBarColor = true;
			this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
			this.metroPanel1.HorizontalScrollbarSize = 10;
			this.metroPanel1.Location = new System.Drawing.Point(222, 31);
			this.metroPanel1.Name = "metroPanel1";
			this.metroPanel1.Size = new System.Drawing.Size(442, 354);
			this.metroPanel1.TabIndex = 1;
			this.metroPanel1.VerticalScrollbarBarColor = true;
			this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
			this.metroPanel1.VerticalScrollbarSize = 10;
			// 
			// metroLabel5
			// 
			this.metroLabel5.AutoSize = true;
			this.metroLabel5.Location = new System.Drawing.Point(165, 180);
			this.metroLabel5.Name = "metroLabel5";
			this.metroLabel5.Size = new System.Drawing.Size(33, 19);
			this.metroLabel5.TabIndex = 13;
			this.metroLabel5.Text = "Kurs";
			// 
			// txtkurs
			// 
			// 
			// 
			// 
			this.txtkurs.CustomButton.Image = null;
			this.txtkurs.CustomButton.Location = new System.Drawing.Point(145, 1);
			this.txtkurs.CustomButton.Name = "";
			this.txtkurs.CustomButton.Size = new System.Drawing.Size(21, 21);
			this.txtkurs.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.txtkurs.CustomButton.TabIndex = 1;
			this.txtkurs.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.txtkurs.CustomButton.UseSelectable = true;
			this.txtkurs.CustomButton.Visible = false;
			this.txtkurs.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.teilnehmerBindingSource, "kurs", true));
			this.txtkurs.Lines = new string[0];
			this.txtkurs.Location = new System.Drawing.Point(247, 176);
			this.txtkurs.MaxLength = 32767;
			this.txtkurs.Name = "txtkurs";
			this.txtkurs.PasswordChar = '\0';
			this.txtkurs.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.txtkurs.SelectedText = "";
			this.txtkurs.SelectionLength = 0;
			this.txtkurs.SelectionStart = 0;
			this.txtkurs.ShortcutsEnabled = true;
			this.txtkurs.Size = new System.Drawing.Size(167, 23);
			this.txtkurs.TabIndex = 12;
			this.txtkurs.UseSelectable = true;
			this.txtkurs.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.txtkurs.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// metroLabel4
			// 
			this.metroLabel4.AutoSize = true;
			this.metroLabel4.Location = new System.Drawing.Point(153, 126);
			this.metroLabel4.Name = "metroLabel4";
			this.metroLabel4.Size = new System.Drawing.Size(93, 19);
			this.metroLabel4.TabIndex = 11;
			this.metroLabel4.Text = "Geburtsdatum";
			// 
			// txtGebdat
			// 
			// 
			// 
			// 
			this.txtGebdat.CustomButton.Image = null;
			this.txtGebdat.CustomButton.Location = new System.Drawing.Point(145, 1);
			this.txtGebdat.CustomButton.Name = "";
			this.txtGebdat.CustomButton.Size = new System.Drawing.Size(21, 21);
			this.txtGebdat.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.txtGebdat.CustomButton.TabIndex = 1;
			this.txtGebdat.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.txtGebdat.CustomButton.UseSelectable = true;
			this.txtGebdat.CustomButton.Visible = false;
			this.txtGebdat.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.teilnehmerBindingSource, "geb_dat", true));
			this.txtGebdat.Lines = new string[0];
			this.txtGebdat.Location = new System.Drawing.Point(247, 126);
			this.txtGebdat.MaxLength = 32767;
			this.txtGebdat.Name = "txtGebdat";
			this.txtGebdat.PasswordChar = '\0';
			this.txtGebdat.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.txtGebdat.SelectedText = "";
			this.txtGebdat.SelectionLength = 0;
			this.txtGebdat.SelectionStart = 0;
			this.txtGebdat.ShortcutsEnabled = true;
			this.txtGebdat.Size = new System.Drawing.Size(167, 23);
			this.txtGebdat.TabIndex = 10;
			this.txtGebdat.UseSelectable = true;
			this.txtGebdat.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.txtGebdat.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// metroLabel3
			// 
			this.metroLabel3.AutoSize = true;
			this.metroLabel3.Location = new System.Drawing.Point(153, 50);
			this.metroLabel3.Name = "metroLabel3";
			this.metroLabel3.Size = new System.Drawing.Size(45, 19);
			this.metroLabel3.TabIndex = 9;
			this.metroLabel3.Text = "Name";
			// 
			// txtvorname
			// 
			// 
			// 
			// 
			this.txtvorname.CustomButton.Image = null;
			this.txtvorname.CustomButton.Location = new System.Drawing.Point(145, 1);
			this.txtvorname.CustomButton.Name = "";
			this.txtvorname.CustomButton.Size = new System.Drawing.Size(21, 21);
			this.txtvorname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.txtvorname.CustomButton.TabIndex = 1;
			this.txtvorname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.txtvorname.CustomButton.UseSelectable = true;
			this.txtvorname.CustomButton.Visible = false;
			this.txtvorname.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.teilnehmerBindingSource, "vorname", true));
			this.txtvorname.Lines = new string[0];
			this.txtvorname.Location = new System.Drawing.Point(247, 87);
			this.txtvorname.MaxLength = 32767;
			this.txtvorname.Name = "txtvorname";
			this.txtvorname.PasswordChar = '\0';
			this.txtvorname.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.txtvorname.SelectedText = "";
			this.txtvorname.SelectionLength = 0;
			this.txtvorname.SelectionStart = 0;
			this.txtvorname.ShortcutsEnabled = true;
			this.txtvorname.Size = new System.Drawing.Size(167, 23);
			this.txtvorname.TabIndex = 8;
			this.txtvorname.UseSelectable = true;
			this.txtvorname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.txtvorname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// metroLabel2
			// 
			this.metroLabel2.AutoSize = true;
			this.metroLabel2.Location = new System.Drawing.Point(153, 91);
			this.metroLabel2.Name = "metroLabel2";
			this.metroLabel2.Size = new System.Drawing.Size(62, 19);
			this.metroLabel2.TabIndex = 7;
			this.metroLabel2.Text = "Vorname";
			// 
			// txtname
			// 
			// 
			// 
			// 
			this.txtname.CustomButton.Image = null;
			this.txtname.CustomButton.Location = new System.Drawing.Point(145, 1);
			this.txtname.CustomButton.Name = "";
			this.txtname.CustomButton.Size = new System.Drawing.Size(21, 21);
			this.txtname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.txtname.CustomButton.TabIndex = 1;
			this.txtname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.txtname.CustomButton.UseSelectable = true;
			this.txtname.CustomButton.Visible = false;
			this.txtname.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.teilnehmerBindingSource, "name", true));
			this.txtname.Lines = new string[0];
			this.txtname.Location = new System.Drawing.Point(247, 46);
			this.txtname.MaxLength = 32767;
			this.txtname.Name = "txtname";
			this.txtname.PasswordChar = '\0';
			this.txtname.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.txtname.SelectedText = "";
			this.txtname.SelectionLength = 0;
			this.txtname.SelectionStart = 0;
			this.txtname.ShortcutsEnabled = true;
			this.txtname.Size = new System.Drawing.Size(167, 23);
			this.txtname.TabIndex = 6;
			this.txtname.UseSelectable = true;
			this.txtname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.txtname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// metroLabel1
			// 
			this.metroLabel1.AutoSize = true;
			this.metroLabel1.Location = new System.Drawing.Point(153, 17);
			this.metroLabel1.Name = "metroLabel1";
			this.metroLabel1.Size = new System.Drawing.Size(88, 19);
			this.metroLabel1.TabIndex = 5;
			this.metroLabel1.Text = "Teilnehmer ID";
			// 
			// mbtnbrower
			// 
			this.mbtnbrower.Location = new System.Drawing.Point(3, 151);
			this.mbtnbrower.Name = "mbtnbrower";
			this.mbtnbrower.Size = new System.Drawing.Size(75, 23);
			this.mbtnbrower.TabIndex = 4;
			this.mbtnbrower.Text = "Browser";
			this.mbtnbrower.UseSelectable = true;
			this.mbtnbrower.Click += new System.EventHandler(this.mbtnbrower_Click);
			// 
			// txtteilid
			// 
			// 
			// 
			// 
			this.txtteilid.CustomButton.Image = null;
			this.txtteilid.CustomButton.Location = new System.Drawing.Point(145, 1);
			this.txtteilid.CustomButton.Name = "";
			this.txtteilid.CustomButton.Size = new System.Drawing.Size(21, 21);
			this.txtteilid.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.txtteilid.CustomButton.TabIndex = 1;
			this.txtteilid.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.txtteilid.CustomButton.UseSelectable = true;
			this.txtteilid.CustomButton.Visible = false;
			this.txtteilid.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.teilnehmerBindingSource, "id_teilnehmer", true));
			this.txtteilid.Lines = new string[0];
			this.txtteilid.Location = new System.Drawing.Point(247, 17);
			this.txtteilid.MaxLength = 32767;
			this.txtteilid.Name = "txtteilid";
			this.txtteilid.PasswordChar = '\0';
			this.txtteilid.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.txtteilid.SelectedText = "";
			this.txtteilid.SelectionLength = 0;
			this.txtteilid.SelectionStart = 0;
			this.txtteilid.ShortcutsEnabled = true;
			this.txtteilid.Size = new System.Drawing.Size(167, 23);
			this.txtteilid.TabIndex = 3;
			this.txtteilid.UseSelectable = true;
			this.txtteilid.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.txtteilid.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(3, 3);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(144, 142);
			this.pictureBox1.TabIndex = 2;
			this.pictureBox1.TabStop = false;
			// 
			// metroButton1
			// 
			this.metroButton1.Location = new System.Drawing.Point(758, 31);
			this.metroButton1.Name = "metroButton1";
			this.metroButton1.Size = new System.Drawing.Size(75, 23);
			this.metroButton1.TabIndex = 5;
			this.metroButton1.Text = "Add";
			this.metroButton1.UseSelectable = true;
			this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
			// 
			// metroButton2
			// 
			this.metroButton2.Location = new System.Drawing.Point(846, 31);
			this.metroButton2.Name = "metroButton2";
			this.metroButton2.Size = new System.Drawing.Size(75, 23);
			this.metroButton2.TabIndex = 14;
			this.metroButton2.Text = "Delete";
			this.metroButton2.UseSelectable = true;
			this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
			// 
			// metroButton3
			// 
			this.metroButton3.Location = new System.Drawing.Point(670, 31);
			this.metroButton3.Name = "metroButton3";
			this.metroButton3.Size = new System.Drawing.Size(75, 23);
			this.metroButton3.TabIndex = 15;
			this.metroButton3.Text = "Edit";
			this.metroButton3.UseSelectable = true;
			this.metroButton3.Click += new System.EventHandler(this.metroButton3_Click);
			// 
			// metroButton4
			// 
			this.metroButton4.Location = new System.Drawing.Point(1022, 31);
			this.metroButton4.Name = "metroButton4";
			this.metroButton4.Size = new System.Drawing.Size(75, 23);
			this.metroButton4.TabIndex = 14;
			this.metroButton4.Text = "Cancel";
			this.metroButton4.UseSelectable = true;
			this.metroButton4.Click += new System.EventHandler(this.metroButton4_Click);
			// 
			// metroButton5
			// 
			this.metroButton5.Location = new System.Drawing.Point(934, 31);
			this.metroButton5.Name = "metroButton5";
			this.metroButton5.Size = new System.Drawing.Size(75, 23);
			this.metroButton5.TabIndex = 14;
			this.metroButton5.Text = "Save";
			this.metroButton5.UseSelectable = true;
			this.metroButton5.Click += new System.EventHandler(this.metroButton5_Click);
			// 
			// idteilnehmerDataGridViewTextBoxColumn
			// 
			this.idteilnehmerDataGridViewTextBoxColumn.DataPropertyName = "id_teilnehmer";
			this.idteilnehmerDataGridViewTextBoxColumn.FillWeight = 50F;
			this.idteilnehmerDataGridViewTextBoxColumn.HeaderText = "ID";
			this.idteilnehmerDataGridViewTextBoxColumn.Name = "idteilnehmerDataGridViewTextBoxColumn";
			this.idteilnehmerDataGridViewTextBoxColumn.Width = 50;
			// 
			// nameDataGridViewTextBoxColumn
			// 
			this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
			this.nameDataGridViewTextBoxColumn.HeaderText = "name";
			this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
			this.nameDataGridViewTextBoxColumn.Width = 200;
			// 
			// vornameDataGridViewTextBoxColumn
			// 
			this.vornameDataGridViewTextBoxColumn.DataPropertyName = "vorname";
			this.vornameDataGridViewTextBoxColumn.HeaderText = "vorname";
			this.vornameDataGridViewTextBoxColumn.Name = "vornameDataGridViewTextBoxColumn";
			this.vornameDataGridViewTextBoxColumn.Width = 200;
			// 
			// gebdatDataGridViewTextBoxColumn
			// 
			this.gebdatDataGridViewTextBoxColumn.DataPropertyName = "geb_dat";
			this.gebdatDataGridViewTextBoxColumn.HeaderText = "Geb.D";
			this.gebdatDataGridViewTextBoxColumn.Name = "gebdatDataGridViewTextBoxColumn";
			// 
			// anmeldnumDataGridViewTextBoxColumn
			// 
			this.anmeldnumDataGridViewTextBoxColumn.DataPropertyName = "anmeld_num";
			this.anmeldnumDataGridViewTextBoxColumn.HeaderText = "ANM:NUM";
			this.anmeldnumDataGridViewTextBoxColumn.Name = "anmeldnumDataGridViewTextBoxColumn";
			// 
			// kursDataGridViewTextBoxColumn
			// 
			this.kursDataGridViewTextBoxColumn.DataPropertyName = "kurs";
			this.kursDataGridViewTextBoxColumn.HeaderText = "KURS";
			this.kursDataGridViewTextBoxColumn.Name = "kursDataGridViewTextBoxColumn";
			// 
			// metroLabel6
			// 
			this.metroLabel6.AutoSize = true;
			this.metroLabel6.Location = new System.Drawing.Point(165, 215);
			this.metroLabel6.Name = "metroLabel6";
			this.metroLabel6.Size = new System.Drawing.Size(33, 19);
			this.metroLabel6.TabIndex = 15;
			this.metroLabel6.Text = "Kurs";
			// 
			// metroTextBox1
			// 
			// 
			// 
			// 
			this.metroTextBox1.CustomButton.Image = null;
			this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(145, 1);
			this.metroTextBox1.CustomButton.Name = "";
			this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(21, 21);
			this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.metroTextBox1.CustomButton.TabIndex = 1;
			this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.metroTextBox1.CustomButton.UseSelectable = true;
			this.metroTextBox1.CustomButton.Visible = false;
			this.metroTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.teilnehmerBindingSource, "kurs", true));
			this.metroTextBox1.Lines = new string[0];
			this.metroTextBox1.Location = new System.Drawing.Point(247, 215);
			this.metroTextBox1.MaxLength = 32767;
			this.metroTextBox1.Name = "metroTextBox1";
			this.metroTextBox1.PasswordChar = '\0';
			this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.metroTextBox1.SelectedText = "";
			this.metroTextBox1.SelectionLength = 0;
			this.metroTextBox1.SelectionStart = 0;
			this.metroTextBox1.ShortcutsEnabled = true;
			this.metroTextBox1.Size = new System.Drawing.Size(167, 23);
			this.metroTextBox1.TabIndex = 14;
			this.metroTextBox1.UseSelectable = true;
			this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// metroLabel7
			// 
			this.metroLabel7.AutoSize = true;
			this.metroLabel7.Location = new System.Drawing.Point(165, 261);
			this.metroLabel7.Name = "metroLabel7";
			this.metroLabel7.Size = new System.Drawing.Size(33, 19);
			this.metroLabel7.TabIndex = 17;
			this.metroLabel7.Text = "Kurs";
			// 
			// metroTextBox2
			// 
			// 
			// 
			// 
			this.metroTextBox2.CustomButton.Image = null;
			this.metroTextBox2.CustomButton.Location = new System.Drawing.Point(145, 1);
			this.metroTextBox2.CustomButton.Name = "";
			this.metroTextBox2.CustomButton.Size = new System.Drawing.Size(21, 21);
			this.metroTextBox2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.metroTextBox2.CustomButton.TabIndex = 1;
			this.metroTextBox2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.metroTextBox2.CustomButton.UseSelectable = true;
			this.metroTextBox2.CustomButton.Visible = false;
			this.metroTextBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.teilnehmerBindingSource, "kurs", true));
			this.metroTextBox2.Lines = new string[0];
			this.metroTextBox2.Location = new System.Drawing.Point(247, 257);
			this.metroTextBox2.MaxLength = 32767;
			this.metroTextBox2.Name = "metroTextBox2";
			this.metroTextBox2.PasswordChar = '\0';
			this.metroTextBox2.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.metroTextBox2.SelectedText = "";
			this.metroTextBox2.SelectionLength = 0;
			this.metroTextBox2.SelectionStart = 0;
			this.metroTextBox2.ShortcutsEnabled = true;
			this.metroTextBox2.Size = new System.Drawing.Size(167, 23);
			this.metroTextBox2.TabIndex = 16;
			this.metroTextBox2.UseSelectable = true;
			this.metroTextBox2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.metroTextBox2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// metroLabel8
			// 
			this.metroLabel8.AutoSize = true;
			this.metroLabel8.Location = new System.Drawing.Point(165, 306);
			this.metroLabel8.Name = "metroLabel8";
			this.metroLabel8.Size = new System.Drawing.Size(33, 19);
			this.metroLabel8.TabIndex = 19;
			this.metroLabel8.Text = "Kurs";
			// 
			// metroTextBox3
			// 
			// 
			// 
			// 
			this.metroTextBox3.CustomButton.Image = null;
			this.metroTextBox3.CustomButton.Location = new System.Drawing.Point(145, 1);
			this.metroTextBox3.CustomButton.Name = "";
			this.metroTextBox3.CustomButton.Size = new System.Drawing.Size(21, 21);
			this.metroTextBox3.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.metroTextBox3.CustomButton.TabIndex = 1;
			this.metroTextBox3.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.metroTextBox3.CustomButton.UseSelectable = true;
			this.metroTextBox3.CustomButton.Visible = false;
			this.metroTextBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.teilnehmerBindingSource, "kurs", true));
			this.metroTextBox3.Lines = new string[0];
			this.metroTextBox3.Location = new System.Drawing.Point(247, 302);
			this.metroTextBox3.MaxLength = 32767;
			this.metroTextBox3.Name = "metroTextBox3";
			this.metroTextBox3.PasswordChar = '\0';
			this.metroTextBox3.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.metroTextBox3.SelectedText = "";
			this.metroTextBox3.SelectionLength = 0;
			this.metroTextBox3.SelectionStart = 0;
			this.metroTextBox3.ShortcutsEnabled = true;
			this.metroTextBox3.Size = new System.Drawing.Size(167, 23);
			this.metroTextBox3.TabIndex = 18;
			this.metroTextBox3.UseSelectable = true;
			this.metroTextBox3.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.metroTextBox3.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1130, 678);
			this.Controls.Add(this.metroButton5);
			this.Controls.Add(this.metroButton4);
			this.Controls.Add(this.metroButton2);
			this.Controls.Add(this.metroButton3);
			this.Controls.Add(this.metroButton1);
			this.Controls.Add(this.metroPanel1);
			this.Controls.Add(this.metroGrid1);
			this.Name = "Form1";
			this.Text = "Text";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.teilnehmerBindingSource)).EndInit();
			this.metroPanel1.ResumeLayout(false);
			this.metroPanel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private MetroFramework.Controls.MetroGrid metroGrid1;
		private MetroFramework.Controls.MetroPanel metroPanel1;
		private MetroFramework.Controls.MetroLabel metroLabel5;
		private MetroFramework.Controls.MetroTextBox txtkurs;
		private MetroFramework.Controls.MetroLabel metroLabel4;
		private MetroFramework.Controls.MetroTextBox txtGebdat;
		private MetroFramework.Controls.MetroLabel metroLabel3;
		private MetroFramework.Controls.MetroTextBox txtvorname;
		private MetroFramework.Controls.MetroLabel metroLabel2;
		private MetroFramework.Controls.MetroTextBox txtname;
		private MetroFramework.Controls.MetroLabel metroLabel1;
		private MetroFramework.Controls.MetroButton mbtnbrower;
		private MetroFramework.Controls.MetroTextBox txtteilid;
		private System.Windows.Forms.PictureBox pictureBox1;
		private MetroFramework.Controls.MetroButton metroButton1;
		private MetroFramework.Controls.MetroButton metroButton2;
		private MetroFramework.Controls.MetroButton metroButton3;
		private MetroFramework.Controls.MetroButton metroButton4;
		private MetroFramework.Controls.MetroButton metroButton5;
		private System.Windows.Forms.BindingSource teilnehmerBindingSource;
		private System.Windows.Forms.DataGridViewTextBoxColumn idteilnehmerDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn vornameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn gebdatDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn anmeldnumDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn kursDataGridViewTextBoxColumn;
		private MetroFramework.Controls.MetroLabel metroLabel8;
		private MetroFramework.Controls.MetroTextBox metroTextBox3;
		private MetroFramework.Controls.MetroLabel metroLabel7;
		private MetroFramework.Controls.MetroTextBox metroTextBox2;
		private MetroFramework.Controls.MetroLabel metroLabel6;
		private MetroFramework.Controls.MetroTextBox metroTextBox1;
	}
}

