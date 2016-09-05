using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;
using System.Threading;

namespace NameGenerator
{
	/// <summary>
	/// Personal details
	/// </summary>
	class Person
	{
		//========BASIC INFO=======================
		/// <summary>
		/// Someones first name
		/// </summary>
		public string name
		{
			get;
			set;
		}
		/// <summary>
		/// Someones first lastname
		/// </summary>
		public string surname
		{
			get;
			set;
		}
		/// <summary>
		/// Defines someones sex. K for woman, M for man
		/// </summary>
		public string sex
		{
			get;
			set;
		}
		/// <summary>
		/// Defines how old is someone
		/// </summary>
		public int age
		{
			get;
			set;
		}
		/// <summary>
		/// Defines from someone is
		/// </summary>
		public string Country
		{
			get;
			set;
		}
		/// <summary>
		/// Defines from omeone is in polish
		/// </summary>
		public string Panstwo
		{
			get;
			set;
		}
		/// <summary>
		/// Someones identification number
		/// </summary>
		public string idnum
		{
			get;
			set;
		}
		/// <summary>
		/// Someone mother name
		/// </summary>
		public string motherName
		{
			get;
			set;
		}
		/// <summary>
		/// Someone father name
		/// </summary>
		public string fatherName
		{
			get;
			set;
		}
		/// <summary>
		/// Someone mobile phone number
		/// </summary>
		public string phonenum
		{
			get;
			set;
		}
		/// <summary>
		/// Defines what someone do for living
		/// </summary>
		public string occupation
		{
			get;
			set;
		}

		//=============ADRESS DATA=========
		public string street
		{
			get;
			set;
		}
		public string ZIP
		{
			get;
			set;
		}
		public string city
		{
			get;
			set;
		}
		public string wojewodztwo_province
		{
			get;
			set;
		}
		public string powiat_county
		{
			get;
			set;
		}
		//====================================

		/// <summary>
		/// Just random generator
		/// </summary>
		private Random rnd = new Random();

		/// <summary>
		/// Connector necessary to connect with SQL db
		/// </summary>
		private SqlConnection Conn;

		/// <summary>
		/// Constructor of class Person. Calls for methods that defines basic info and adress
		/// </summary>
		/// <param name="men">if true creates mens</param>
		/// <param name="women">if true creates womens</param>
		public Person(bool men, bool women)
		{
			//Necessary to update progressbar in MainWindow
			MainWindow tmp_form = new MainWindow();

			//Create connection with MSSQL database
			Conn = new SqlConnection(@"Data Source=.\SQLEXPRESS; AttachDbFilename = http://www.pkastelik.beep.pl/database.mdf ;Integrated Security=True;Connect Timeout=30;User Instance=True");

			//Updates progress of progressbar
			tmp_form.SetProgress(15);

			whatsYourSurname();
			age = drawAge();

			tmp_form.SetProgress(30);

			idnum = generateID();
			whatsYourName(men, women);
			phonenum = whatsYourNumber();
			whatsYourparents_names();

			tmp_form.SetProgress(70);

			whatsYourCountry();
			whatsYourOccupation();
			whereYouLive();

			tmp_form.SetProgress(80);

			deleteSpaces();
			//delete temporary instace of MainWindow
			tmp_form.Dispose();
		}

		/// <summary>
		/// Download from SQL database rows with adress
		/// </summary>
		private void whereYouLive()
		{
			try
			{
				Conn.Open(); //Open
				//SQL Query, randomly selected Adress
				SqlCommand oCmd = new SqlCommand(@"SELECT TOP (1) ZIP_Code, City, Province, Street, County FROM adressTable ORDER BY NEWID()", Conn);
				SqlDataReader oReader = oCmd.ExecuteReader();
				while(oReader.Read())
				{
					//Parse data from datatable to person variables
					this.ZIP = oReader["ZIP_Code"].ToString();
					this.city = oReader["City"].ToString();
					this.wojewodztwo_province = oReader["Province"].ToString();

					//if someone live in villages with no street, village name with number create Adress
					if(oReader["Street"].ToString() == "")
						this.street = this.city + " " + rnd.Next(1, 150).ToString();
					else
						this.street = oReader["Street"].ToString() + " " + rnd.Next(1, 150).ToString();

					this.powiat_county = oReader["County"].ToString();
				}
				Conn.Close(); //Close connectrion with SQL
			}
			catch(Exception se)
			{
				//throw exeption if something is wrong with database
				System.Windows.Forms.MessageBox.Show("Something went wrong with database at retriving adress!\nPlease check if you have  SQL Server turned on and database is on place.\n\n" + se.ToString(), "SQL Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
			}
		}

		/// <summary>
		/// Deletes whitespaces from retrived data, because there is a lot of it in SQL
		/// </summary>
		private void deleteSpaces()
		{
			//string.Replace();
			name = name.Replace(" ", string.Empty);
			surname = surname.Replace(" ", string.Empty);
			motherName = motherName.Replace(" ", string.Empty);
			fatherName = fatherName.Replace(" ", string.Empty);
		}

		/// <summary>
		/// Download from SQL database rows with Coutries and theirs Alfa codes and polish names
		/// </summary>
		private void whatsYourCountry()
		{
			try
			{
				Conn.Open();

				//SQL Query, randomly selected Adress
				SqlCommand oCmd = new SqlCommand(@"SELECT TOP (1) Country, Panstwo, Alfa2 FROM ISO_CountriesTable ORDER BY NEWID()", Conn);
				SqlDataReader oReader = oCmd.ExecuteReader();
				while(oReader.Read())
				{
					//Parse data from datatable to person variables
					this.Country = oReader["Country"].ToString() + ", " + oReader["Alfa2"].ToString();
					this.Panstwo = oReader["Panstwo"].ToString() + ", " + oReader["Alfa2"].ToString();
				}
				Conn.Close();
			}
			catch(Exception se)
			{
				//throw exeption if something is wrong with database
				System.Windows.Forms.MessageBox.Show("Something went wrong with database at retriving country!\nPlease check if you have  SQL Server turned on and database is on place.\n\n" + se.ToString(), "SQL Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
			}
		}

		/// <summary>
		/// Download from SQL database rows with names
		/// </summary>
		private void whatsYourparents_names()
		{
			try
			{
				Conn.Open();
				//SQL Query that randomly pick only females names
				SqlCommand oCmd = new SqlCommand(@"SELECT TOP (1) Name FROM namesTable WHERE (Sex = 'K') ORDER BY NEWID()", Conn);
				SqlDataReader oReader = oCmd.ExecuteReader();
				while(oReader.Read())
				{
					this.motherName = oReader["Name"].ToString();
				}
				Conn.Close();
				//Reconnect to use again oCmd, and oReader
				Conn.Open();
				//SQL Query that randomly pick only manly names
				oCmd = new SqlCommand(@"SELECT TOP (1) Name FROM namesTable WHERE (Sex = 'M') ORDER BY NEWID()", Conn);
				oReader = oCmd.ExecuteReader();
				while(oReader.Read())
				{
					this.fatherName = oReader["Name"].ToString();
				}
				Conn.Close();
			}
			catch(Exception se)
			{
				System.Windows.Forms.MessageBox.Show("Something went wrong with database at retriving adress!\nPlease check if you have SQL Server turned on and database is on place.\n\n" + se.ToString(), "SQL Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
			}
		}

		/// <summary>
		/// Checked items in MainWindow menu determines if created name will be female or male
		/// </summary>
		/// <param name="men">if true only manly names</param>
		/// <param name="women">if true only female names</param>
		private void whatsYourName(bool men, bool women)
		{
			try
			{
				Conn.Open();
				SqlCommand oCmd;
				if(men && !women) //just men
					oCmd = new SqlCommand(@"SELECT TOP (1) Name, Sex FROM namesTable WHERE (Sex = 'M') ORDER BY NEWID()", Conn);
				else if(!men && women) //just women
					oCmd = new SqlCommand(@"SELECT TOP (1) Name, Sex FROM namesTable WHERE (Sex = 'K') ORDER BY NEWID()", Conn);
				else //take randomly both
					oCmd = new SqlCommand(@"SELECT TOP (1) Name, Sex FROM namesTable ORDER BY NEWID()", Conn);

				SqlDataReader oReader = oCmd.ExecuteReader();
				while(oReader.Read())
				{
					this.name = oReader["Name"].ToString();
					this.sex = oReader["Sex"].ToString();
				}
				Conn.Close();
			}
			catch(Exception se)
			{
				System.Windows.Forms.MessageBox.Show("Something went wrong with database at retriving name!\nPlease check if you have SQL Server turned on and database is on place.\n\n" + se.ToString(), "SQL Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
			}
		}

		/// <summary>
		/// Picks last name from database with 400 000 surnames
		/// </summary>
		private void whatsYourSurname()
		{
			try
			{
				Conn.Open();
				SqlCommand oCmd = new SqlCommand(@"SELECT TOP (1) Surname FROM surnamesTable ORDER BY NEWID()", Conn);
				SqlDataReader oReader = oCmd.ExecuteReader();
				while(oReader.Read())
				{

					this.surname = oReader["Surname"].ToString();
				}
				Conn.Close();
			}
			catch(Exception se)
			{
				System.Windows.Forms.MessageBox.Show("Something went wrong with database at retriving surname!\nPlease check if you have SQL Server turned on and database is on place.\n\n" + se.ToString(), "SQL Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
			}
		}

		/// <summary>
		/// Create and return phone number
		/// </summary>
		/// <returns>formatted 000 000 000 number</returns>
		private string whatsYourNumber()
		{
			if(rnd.Next(6) == rnd.Next(6))
				return null;
			else
				return rnd.Next(490, 850).ToString("000") + " " + rnd.Next(0, 999).ToString("000") + " " + rnd.Next(0, 999).ToString("000");
		}

		/// <summary>
		/// Generates PESEL number (Personal ID number) based on current year and randomly picked datetime
		/// </summary>
		/// <returns>11-digit number as string</returns>
		private string generateID()
		{
			string year = (Int32.Parse(DateTime.Now.ToString("yyyy")) - age).ToString();
			year = year.Substring(2, year.Length - 2); //format date from example: 2016 to 16, or 1987 to 87
			int month = rnd.Next(1, 12); //12 months
			int day = 0;
			if(month == 2) //if febuary pick random from 1 to 28
			{
				day = rnd.Next(1, 28);
			}
			else
				day = rnd.Next(1, 30); //else pick random from 1 to 30
			int id = rnd.Next(0, 99999); //randomID

			//return formatted PESEL number
			return year.ToString() + month.ToString("00") + day.ToString("00") + id.ToString("00000");
			;
		}

		/// <summary>
		/// Generates age of person from 1 to 120.
		/// </summary>
		/// <returns>Personal age as int</returns>
		private int drawAge()
		{
			//you dont have equal chance to live 120
			int generatedAge = rnd.Next(1, 120);
			if(generatedAge > 90 || generatedAge < 10)
			{
				generatedAge = rnd.Next(5, 120);
				if(generatedAge > 100)
				{
					generatedAge = rnd.Next(1, 120);
				}
			}
			return generatedAge;
		}

		/// <summary>
		/// Download from SQL database rows with professions
		/// </summary>
		private void whatsYourOccupation()
		{
			//kids cant do work
			if(this.age > 19)
			{
				//if rnd == rnd you are without job. Sorry.
				if(rnd.Next(15) == rnd.Next(15))
				{
					this.occupation = "Unemployed";
				}
				else
				{
					//Download your job from MSSQL. You can be anyone.
					try
					{
						Conn.Open();

						//SQL Query
						SqlCommand oCmd = new SqlCommand(@"SELECT TOP (1) Profession FROM ISCO_occupationTable ORDER BY NEWID()", Conn);
						SqlDataReader oReader = oCmd.ExecuteReader();
						while(oReader.Read())
						{
							this.occupation = oReader["Profession"].ToString();
							occupation = occupation.TrimEnd(' ');
						}
						Conn.Close();
					}
					catch(Exception se)
					{
						System.Windows.Forms.MessageBox.Show("Something went wrong with database at retriving occupation!\nPlease check if you have SQL Server turned on and database is on place.\n\n" + se.ToString(), "SQL Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
					}
					if(this.age > 65) //if you are older than 65 you are retired employee
						this.occupation = this.occupation + " RETIRED";
				}
			}
			else //job status for kids.
				this.occupation = "Too young for job!";
		}
	}
}
