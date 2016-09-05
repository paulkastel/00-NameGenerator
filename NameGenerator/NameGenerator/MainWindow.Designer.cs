namespace NameGenerator
{
	partial class MainWindow
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if(disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.menuStrip = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.randomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.womenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.languageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.polishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.closeProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.authorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.lbl_NameSur = new System.Windows.Forms.Label();
			this.lbl_sex = new System.Windows.Forms.Label();
			this.lbl_age = new System.Windows.Forms.Label();
			this.lbl_phone = new System.Windows.Forms.Label();
			this.lbl_idnum = new System.Windows.Forms.Label();
			this.lbl_country = new System.Windows.Forms.Label();
			this.lbl_occupation = new System.Windows.Forms.Label();
			this.statusStrip = new System.Windows.Forms.StatusStrip();
			this.timeDateStat_lbl = new System.Windows.Forms.ToolStripStatusLabel();
			this.bar_progress = new System.Windows.Forms.ToolStripProgressBar();
			this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
			this.personal_count_lbl = new System.Windows.Forms.ToolStripStatusLabel();
			this.groupBox_Ad = new System.Windows.Forms.GroupBox();
			this.lblval_prov_county = new System.Windows.Forms.Label();
			this.lblval_zip_city = new System.Windows.Forms.Label();
			this.lblval_str_num = new System.Windows.Forms.Label();
			this.lbl_parName = new System.Windows.Forms.Label();
			this.btn_NewPerson = new System.Windows.Forms.Button();
			this.lblval_name = new System.Windows.Forms.Label();
			this.lblval_sex = new System.Windows.Forms.Label();
			this.lblval_country = new System.Windows.Forms.Label();
			this.lblval_idnum = new System.Windows.Forms.Label();
			this.lblval_age = new System.Windows.Forms.Label();
			this.lblval_parnames = new System.Windows.Forms.Label();
			this.lblval_occupy = new System.Windows.Forms.Label();
			this.lblval_phone = new System.Windows.Forms.Label();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.fantasyNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip.SuspendLayout();
			this.statusStrip.SuspendLayout();
			this.groupBox_Ad.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip
			// 
			this.menuStrip.BackColor = System.Drawing.Color.LightSteelBlue;
			this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.fantasyNameToolStripMenuItem});
			this.menuStrip.Location = new System.Drawing.Point(0, 0);
			this.menuStrip.Name = "menuStrip";
			this.menuStrip.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
			this.menuStrip.Size = new System.Drawing.Size(391, 24);
			this.menuStrip.TabIndex = 0;
			this.menuStrip.Text = "menuStrip";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.randomToolStripMenuItem,
            this.languageToolStripMenuItem,
            this.toolStripSeparator1,
            this.exportToolStripMenuItem,
            this.toolStripSeparator2,
            this.closeProgramToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// randomToolStripMenuItem
			// 
			this.randomToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menToolStripMenuItem,
            this.womenToolStripMenuItem});
			this.randomToolStripMenuItem.Name = "randomToolStripMenuItem";
			this.randomToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.randomToolStripMenuItem.Text = "Random";
			// 
			// menToolStripMenuItem
			// 
			this.menToolStripMenuItem.Name = "menToolStripMenuItem";
			this.menToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
			this.menToolStripMenuItem.Text = "Men";
			this.menToolStripMenuItem.Click += new System.EventHandler(this.menToolStripMenuItem_Click);
			// 
			// womenToolStripMenuItem
			// 
			this.womenToolStripMenuItem.Name = "womenToolStripMenuItem";
			this.womenToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
			this.womenToolStripMenuItem.Text = "Women";
			this.womenToolStripMenuItem.Click += new System.EventHandler(this.womenToolStripMenuItem_Click);
			// 
			// languageToolStripMenuItem
			// 
			this.languageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.englishToolStripMenuItem,
            this.polishToolStripMenuItem});
			this.languageToolStripMenuItem.Name = "languageToolStripMenuItem";
			this.languageToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.languageToolStripMenuItem.Text = "Language";
			// 
			// englishToolStripMenuItem
			// 
			this.englishToolStripMenuItem.Checked = true;
			this.englishToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
			this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
			this.englishToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
			this.englishToolStripMenuItem.Text = "English";
			this.englishToolStripMenuItem.Click += new System.EventHandler(this.englishToolStripMenuItem_Click);
			// 
			// polishToolStripMenuItem
			// 
			this.polishToolStripMenuItem.Name = "polishToolStripMenuItem";
			this.polishToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
			this.polishToolStripMenuItem.Text = "Polski";
			this.polishToolStripMenuItem.Click += new System.EventHandler(this.polishToolStripMenuItem_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
			// 
			// exportToolStripMenuItem
			// 
			this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
			this.exportToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.exportToolStripMenuItem.Text = "Export to file";
			this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(149, 6);
			// 
			// closeProgramToolStripMenuItem
			// 
			this.closeProgramToolStripMenuItem.Name = "closeProgramToolStripMenuItem";
			this.closeProgramToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.closeProgramToolStripMenuItem.Text = "Close program";
			this.closeProgramToolStripMenuItem.Click += new System.EventHandler(this.closeProgramToolStripMenuItem_Click);
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.authorToolStripMenuItem,
            this.infoToolStripMenuItem});
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
			this.aboutToolStripMenuItem.Text = "About";
			// 
			// authorToolStripMenuItem
			// 
			this.authorToolStripMenuItem.Name = "authorToolStripMenuItem";
			this.authorToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.authorToolStripMenuItem.Text = "Author";
			this.authorToolStripMenuItem.Click += new System.EventHandler(this.authorToolStripMenuItem_Click);
			// 
			// infoToolStripMenuItem
			// 
			this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
			this.infoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.infoToolStripMenuItem.Text = "Info...";
			this.infoToolStripMenuItem.Click += new System.EventHandler(this.infoToolStripMenuItem_Click);
			// 
			// lbl_NameSur
			// 
			this.lbl_NameSur.AutoSize = true;
			this.lbl_NameSur.Font = new System.Drawing.Font("Lucida Fax", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.lbl_NameSur.Location = new System.Drawing.Point(14, 42);
			this.lbl_NameSur.Name = "lbl_NameSur";
			this.lbl_NameSur.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lbl_NameSur.Size = new System.Drawing.Size(103, 14);
			this.lbl_NameSur.TabIndex = 1;
			this.lbl_NameSur.Text = "Name and surname:";
			this.lbl_NameSur.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lbl_sex
			// 
			this.lbl_sex.AutoSize = true;
			this.lbl_sex.Font = new System.Drawing.Font("Lucida Fax", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.lbl_sex.Location = new System.Drawing.Point(14, 68);
			this.lbl_sex.Name = "lbl_sex";
			this.lbl_sex.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lbl_sex.Size = new System.Drawing.Size(29, 14);
			this.lbl_sex.TabIndex = 2;
			this.lbl_sex.Text = "Sex:";
			this.lbl_sex.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lbl_age
			// 
			this.lbl_age.AutoSize = true;
			this.lbl_age.Font = new System.Drawing.Font("Lucida Fax", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.lbl_age.Location = new System.Drawing.Point(223, 68);
			this.lbl_age.Name = "lbl_age";
			this.lbl_age.Size = new System.Drawing.Size(30, 14);
			this.lbl_age.TabIndex = 3;
			this.lbl_age.Text = "Age:";
			this.lbl_age.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lbl_phone
			// 
			this.lbl_phone.AutoSize = true;
			this.lbl_phone.Font = new System.Drawing.Font("Lucida Fax", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.lbl_phone.Location = new System.Drawing.Point(14, 318);
			this.lbl_phone.Name = "lbl_phone";
			this.lbl_phone.Size = new System.Drawing.Size(79, 14);
			this.lbl_phone.TabIndex = 4;
			this.lbl_phone.Text = "Phone number:";
			// 
			// lbl_idnum
			// 
			this.lbl_idnum.AutoSize = true;
			this.lbl_idnum.Font = new System.Drawing.Font("Lucida Fax", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.lbl_idnum.Location = new System.Drawing.Point(14, 123);
			this.lbl_idnum.Name = "lbl_idnum";
			this.lbl_idnum.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lbl_idnum.Size = new System.Drawing.Size(109, 14);
			this.lbl_idnum.TabIndex = 5;
			this.lbl_idnum.Text = "Identification number:";
			this.lbl_idnum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lbl_country
			// 
			this.lbl_country.AutoSize = true;
			this.lbl_country.Font = new System.Drawing.Font("Lucida Fax", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.lbl_country.Location = new System.Drawing.Point(14, 93);
			this.lbl_country.Name = "lbl_country";
			this.lbl_country.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lbl_country.Size = new System.Drawing.Size(85, 14);
			this.lbl_country.TabIndex = 7;
			this.lbl_country.Text = "Country of birth:";
			this.lbl_country.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lbl_occupation
			// 
			this.lbl_occupation.AutoSize = true;
			this.lbl_occupation.Font = new System.Drawing.Font("Lucida Fax", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.lbl_occupation.Location = new System.Drawing.Point(14, 344);
			this.lbl_occupation.Name = "lbl_occupation";
			this.lbl_occupation.Size = new System.Drawing.Size(65, 14);
			this.lbl_occupation.TabIndex = 8;
			this.lbl_occupation.Text = "Occupation:";
			// 
			// statusStrip
			// 
			this.statusStrip.BackColor = System.Drawing.Color.LightSteelBlue;
			this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.timeDateStat_lbl,
            this.bar_progress,
            this.toolStripStatusLabel2,
            this.personal_count_lbl});
			this.statusStrip.Location = new System.Drawing.Point(0, 450);
			this.statusStrip.Name = "statusStrip";
			this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
			this.statusStrip.Size = new System.Drawing.Size(391, 24);
			this.statusStrip.SizingGrip = false;
			this.statusStrip.TabIndex = 9;
			// 
			// timeDateStat_lbl
			// 
			this.timeDateStat_lbl.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.timeDateStat_lbl.Name = "timeDateStat_lbl";
			this.timeDateStat_lbl.Size = new System.Drawing.Size(112, 19);
			this.timeDateStat_lbl.Text = "                                   ";
			// 
			// bar_progress
			// 
			this.bar_progress.BackColor = System.Drawing.Color.Azure;
			this.bar_progress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.bar_progress.Name = "bar_progress";
			this.bar_progress.Size = new System.Drawing.Size(250, 18);
			// 
			// toolStripStatusLabel2
			// 
			this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
			this.toolStripStatusLabel2.Size = new System.Drawing.Size(0, 19);
			// 
			// personal_count_lbl
			// 
			this.personal_count_lbl.Name = "personal_count_lbl";
			this.personal_count_lbl.Size = new System.Drawing.Size(0, 19);
			// 
			// groupBox_Ad
			// 
			this.groupBox_Ad.Controls.Add(this.lblval_prov_county);
			this.groupBox_Ad.Controls.Add(this.lblval_zip_city);
			this.groupBox_Ad.Controls.Add(this.lblval_str_num);
			this.groupBox_Ad.Font = new System.Drawing.Font("Lucida Fax", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.groupBox_Ad.Location = new System.Drawing.Point(17, 158);
			this.groupBox_Ad.Name = "groupBox_Ad";
			this.groupBox_Ad.Size = new System.Drawing.Size(359, 122);
			this.groupBox_Ad.TabIndex = 10;
			this.groupBox_Ad.TabStop = false;
			this.groupBox_Ad.Text = "Adress";
			// 
			// lblval_prov_county
			// 
			this.lblval_prov_county.AutoSize = true;
			this.lblval_prov_county.Font = new System.Drawing.Font("Lucida Fax", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.lblval_prov_county.Location = new System.Drawing.Point(7, 82);
			this.lblval_prov_county.Name = "lblval_prov_county";
			this.lblval_prov_county.Size = new System.Drawing.Size(0, 14);
			this.lblval_prov_county.TabIndex = 21;
			this.lblval_prov_county.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblval_zip_city
			// 
			this.lblval_zip_city.AutoSize = true;
			this.lblval_zip_city.Font = new System.Drawing.Font("Lucida Fax", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.lblval_zip_city.Location = new System.Drawing.Point(7, 54);
			this.lblval_zip_city.Name = "lblval_zip_city";
			this.lblval_zip_city.Size = new System.Drawing.Size(0, 14);
			this.lblval_zip_city.TabIndex = 20;
			this.lblval_zip_city.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblval_str_num
			// 
			this.lblval_str_num.AutoSize = true;
			this.lblval_str_num.Font = new System.Drawing.Font("Lucida Fax", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.lblval_str_num.Location = new System.Drawing.Point(7, 29);
			this.lblval_str_num.Name = "lblval_str_num";
			this.lblval_str_num.Size = new System.Drawing.Size(0, 14);
			this.lblval_str_num.TabIndex = 19;
			this.lblval_str_num.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lbl_parName
			// 
			this.lbl_parName.AutoSize = true;
			this.lbl_parName.Font = new System.Drawing.Font("Lucida Fax", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.lbl_parName.Location = new System.Drawing.Point(14, 292);
			this.lbl_parName.Name = "lbl_parName";
			this.lbl_parName.Size = new System.Drawing.Size(82, 14);
			this.lbl_parName.TabIndex = 11;
			this.lbl_parName.Text = "Parents names:";
			// 
			// btn_NewPerson
			// 
			this.btn_NewPerson.BackColor = System.Drawing.Color.LightSteelBlue;
			this.btn_NewPerson.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_NewPerson.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btn_NewPerson.Location = new System.Drawing.Point(15, 377);
			this.btn_NewPerson.Name = "btn_NewPerson";
			this.btn_NewPerson.Size = new System.Drawing.Size(362, 68);
			this.btn_NewPerson.TabIndex = 12;
			this.btn_NewPerson.Text = "Create New Person";
			this.btn_NewPerson.UseVisualStyleBackColor = false;
			this.btn_NewPerson.Click += new System.EventHandler(this.btn_NewPerson_Click);
			// 
			// lblval_name
			// 
			this.lblval_name.AutoSize = true;
			this.lblval_name.Font = new System.Drawing.Font("Lucida Fax", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.lblval_name.Location = new System.Drawing.Point(140, 42);
			this.lblval_name.Name = "lblval_name";
			this.lblval_name.Size = new System.Drawing.Size(0, 14);
			this.lblval_name.TabIndex = 13;
			this.lblval_name.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblval_sex
			// 
			this.lblval_sex.AutoSize = true;
			this.lblval_sex.Font = new System.Drawing.Font("Lucida Fax", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.lblval_sex.Location = new System.Drawing.Point(54, 68);
			this.lblval_sex.Name = "lblval_sex";
			this.lblval_sex.Size = new System.Drawing.Size(0, 14);
			this.lblval_sex.TabIndex = 14;
			this.lblval_sex.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblval_country
			// 
			this.lblval_country.AutoSize = true;
			this.lblval_country.Font = new System.Drawing.Font("Lucida Fax", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.lblval_country.Location = new System.Drawing.Point(115, 93);
			this.lblval_country.Name = "lblval_country";
			this.lblval_country.Size = new System.Drawing.Size(0, 14);
			this.lblval_country.TabIndex = 15;
			this.lblval_country.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblval_idnum
			// 
			this.lblval_idnum.AutoSize = true;
			this.lblval_idnum.Font = new System.Drawing.Font("Lucida Fax", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.lblval_idnum.Location = new System.Drawing.Point(150, 123);
			this.lblval_idnum.Name = "lblval_idnum";
			this.lblval_idnum.Size = new System.Drawing.Size(0, 14);
			this.lblval_idnum.TabIndex = 16;
			this.lblval_idnum.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblval_age
			// 
			this.lblval_age.AutoSize = true;
			this.lblval_age.Font = new System.Drawing.Font("Lucida Fax", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.lblval_age.Location = new System.Drawing.Point(264, 68);
			this.lblval_age.Name = "lblval_age";
			this.lblval_age.Size = new System.Drawing.Size(0, 14);
			this.lblval_age.TabIndex = 17;
			this.lblval_age.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblval_parnames
			// 
			this.lblval_parnames.AutoSize = true;
			this.lblval_parnames.Font = new System.Drawing.Font("Lucida Fax", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.lblval_parnames.Location = new System.Drawing.Point(114, 292);
			this.lblval_parnames.Name = "lblval_parnames";
			this.lblval_parnames.Size = new System.Drawing.Size(0, 14);
			this.lblval_parnames.TabIndex = 18;
			this.lblval_parnames.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblval_occupy
			// 
			this.lblval_occupy.AutoSize = true;
			this.lblval_occupy.Font = new System.Drawing.Font("Lucida Fax", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.lblval_occupy.Location = new System.Drawing.Point(97, 344);
			this.lblval_occupy.Name = "lblval_occupy";
			this.lblval_occupy.Size = new System.Drawing.Size(0, 14);
			this.lblval_occupy.TabIndex = 20;
			this.lblval_occupy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblval_phone
			// 
			this.lblval_phone.AutoSize = true;
			this.lblval_phone.Font = new System.Drawing.Font("Lucida Fax", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.lblval_phone.Location = new System.Drawing.Point(113, 318);
			this.lblval_phone.Name = "lblval_phone";
			this.lblval_phone.Size = new System.Drawing.Size(0, 14);
			this.lblval_phone.TabIndex = 21;
			this.lblval_phone.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Interval = 1000;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// fantasyNameToolStripMenuItem
			// 
			this.fantasyNameToolStripMenuItem.Name = "fantasyNameToolStripMenuItem";
			this.fantasyNameToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
			this.fantasyNameToolStripMenuItem.Text = "Fantasy name";
			this.fantasyNameToolStripMenuItem.Click += new System.EventHandler(this.fantasyNameToolStripMenuItem_Click);
			// 
			// MainWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Lavender;
			this.ClientSize = new System.Drawing.Size(391, 474);
			this.Controls.Add(this.lblval_phone);
			this.Controls.Add(this.lblval_occupy);
			this.Controls.Add(this.lblval_parnames);
			this.Controls.Add(this.lblval_age);
			this.Controls.Add(this.lblval_idnum);
			this.Controls.Add(this.lblval_country);
			this.Controls.Add(this.lblval_sex);
			this.Controls.Add(this.lblval_name);
			this.Controls.Add(this.btn_NewPerson);
			this.Controls.Add(this.lbl_parName);
			this.Controls.Add(this.groupBox_Ad);
			this.Controls.Add(this.statusStrip);
			this.Controls.Add(this.lbl_occupation);
			this.Controls.Add(this.lbl_country);
			this.Controls.Add(this.lbl_idnum);
			this.Controls.Add(this.lbl_phone);
			this.Controls.Add(this.lbl_age);
			this.Controls.Add(this.lbl_sex);
			this.Controls.Add(this.lbl_NameSur);
			this.Controls.Add(this.menuStrip);
			this.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MainMenuStrip = this.menuStrip;
			this.Name = "MainWindow";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Random People Generator";
			this.menuStrip.ResumeLayout(false);
			this.menuStrip.PerformLayout();
			this.statusStrip.ResumeLayout(false);
			this.statusStrip.PerformLayout();
			this.groupBox_Ad.ResumeLayout(false);
			this.groupBox_Ad.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem randomToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem languageToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem closeProgramToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem authorToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
		private System.Windows.Forms.Label lbl_NameSur;
		private System.Windows.Forms.Label lbl_sex;
		private System.Windows.Forms.Label lbl_age;
		private System.Windows.Forms.Label lbl_phone;
		private System.Windows.Forms.Label lbl_idnum;
		private System.Windows.Forms.Label lbl_country;
		private System.Windows.Forms.Label lbl_occupation;
		private System.Windows.Forms.StatusStrip statusStrip;
		private System.Windows.Forms.ToolStripStatusLabel timeDateStat_lbl;
		private System.Windows.Forms.GroupBox groupBox_Ad;
		private System.Windows.Forms.Label lbl_parName;
		private System.Windows.Forms.Button btn_NewPerson;
		private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem polishToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
		public System.Windows.Forms.Label lblval_str_num;
		private System.Windows.Forms.Label lblval_name;
		private System.Windows.Forms.Label lblval_sex;
		private System.Windows.Forms.Label lblval_country;
		private System.Windows.Forms.Label lblval_idnum;
		private System.Windows.Forms.Label lblval_age;
		private System.Windows.Forms.Label lblval_parnames;
		private System.Windows.Forms.Label lblval_occupy;
		private System.Windows.Forms.Label lblval_phone;
		public System.Windows.Forms.Label lblval_prov_county;
		public System.Windows.Forms.Label lblval_zip_city;
		private System.Windows.Forms.ToolStripMenuItem menToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem womenToolStripMenuItem;
		private System.Windows.Forms.Timer timer1;
		public System.Windows.Forms.ToolStripProgressBar bar_progress;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
		private System.Windows.Forms.ToolStripStatusLabel personal_count_lbl;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripMenuItem fantasyNameToolStripMenuItem;
	}
}

