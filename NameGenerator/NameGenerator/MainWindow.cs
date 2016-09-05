using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Input;
using System.Threading;
using System.IO;

namespace NameGenerator
{

	public partial class MainWindow : Form
	{
		/// <summary>
		/// Just someone in MainWindow
		/// </summary>
		private Person person;

		/// <summary>
		/// Counter that says how many people you clicked in one session
		/// </summary>
		private int personal_count;

		/// <summary>
		/// Constructor. Things you do at the creation of form.
		/// </summary>
		public MainWindow()
		{
			InitializeComponent();
			timer1.Start();			//start system clock
			timeDateStat_lbl.Text = DateTime.Now.ToString();		//show system clock
			setlabelsPos();			//reset all the labels with values
			exportToolStripMenuItem.Enabled = false;				//disable for create empty vcf files
			personal_count = 0;		//reset counter
			personal_count_lbl.Text = personal_count.ToString();	//show me reset counter
		}

		/// <summary>
		/// sets all labels to correct position and fills them with nulls
		/// </summary>
		private void setlabelsPos()
		{
			lblval_name.Left = lbl_NameSur.Right + 1;
			lblval_name.Top = lbl_NameSur.Top;
			lblval_name.Text = null;

			lblval_sex.Left = lbl_sex.Right + 1;
			lblval_sex.Top = lbl_sex.Top;
			lblval_sex.Text = null;

			lblval_age.Left = lbl_age.Right + 1;
			lblval_age.Top = lbl_age.Top;
			lblval_age.Text = null;

			lblval_idnum.Left = lbl_idnum.Right + 1;
			lblval_idnum.Top = lbl_idnum.Top;
			lblval_idnum.Text = null;

			lblval_parnames.Left = lbl_parName.Right + 1;
			lblval_parnames.Top = lbl_parName.Top;
			lblval_parnames.Text = null;

			lblval_phone.Left = lbl_phone.Right + 1;
			lblval_phone.Top = lbl_phone.Top;
			lblval_phone.Text = null;

			lblval_occupy.Left = lbl_occupation.Right + 1;
			lblval_occupy.Top = lbl_occupation.Top;
			lblval_occupy.Text = null;

			lblval_country.Left = lbl_country.Right + 1;
			lblval_country.Top = lbl_country.Top;
			lblval_country.Text = null;

			lblval_str_num.Text = null;
			lblval_zip_city.Text = null;
			lblval_prov_county.Text = null;

			exportToolStripMenuItem.Enabled = false;
			SetProgress(0); //reset progressBar
		}

		/// <summary>
		/// Set app language to polish and reset all labels
		/// </summary>
		private void setLangPolish()
		{
			lbl_NameSur.Text = @"Imię i nazwisko:";
			lbl_sex.Text = @"Płeć:";
			lbl_age.Text = @"Wiek: ";
			lbl_country.Text = @"Kraj pochodzenia:";
			lbl_idnum.Text = @"Numer PESEL:";
			groupBox_Ad.Text = @"Adres zameldowania";
			lbl_parName.Text = @"Imiona rodziców:";
			lbl_occupation.Text = @"Zawód:";
			btn_NewPerson.Text = @"Stwórz nową osobę";
			lbl_phone.Text = @"Numer telefonu:";
			randomToolStripMenuItem.Text = @"Losuj";
			menToolStripMenuItem.Text = "Mężczyźni";
			womenToolStripMenuItem.Text = "Kobiety";
			fileToolStripMenuItem.Text = @"Plik";
			languageToolStripMenuItem.Text = @"Język";
			exportToolStripMenuItem.Text = @"Eksportuj do pliku";
			closeProgramToolStripMenuItem.Text = @"Zamknij";
			aboutToolStripMenuItem.Text = @"O programie";
			authorToolStripMenuItem.Text = @"Autor";
			infoToolStripMenuItem.Text = @"Informacja";
			this.Text = "Generator losowych ludzi";

			setlabelsPos();
		}

		/// <summary>
		/// Set app language to english and reset all labels
		/// </summary>
		private void setLangEnglish()
		{
			lbl_NameSur.Text = @"Name and surname: ";
			lbl_sex.Text = @"Sex: ";
			lbl_age.Text = @"Age: ";
			lbl_country.Text = @"Country of birth:";
			lbl_idnum.Text = @"Identification number:";
			groupBox_Ad.Text = @"Adress";
			lbl_parName.Text = @"Parents names:";
			lbl_occupation.Text = @"Occupation:";
			btn_NewPerson.Text = @"Create New Person";
			lbl_phone.Text = @"Phone number:";
			fileToolStripMenuItem.Text = @"File";
			randomToolStripMenuItem.Text = @"Random";
			menToolStripMenuItem.Text = "Men";
			womenToolStripMenuItem.Text = "Women";
			languageToolStripMenuItem.Text = @"Language";
			exportToolStripMenuItem.Text = @"Export to file";
			closeProgramToolStripMenuItem.Text = @"Close program";
			aboutToolStripMenuItem.Text = @"About";
			authorToolStripMenuItem.Text = @"Author";
			infoToolStripMenuItem.Text = @"Info...";
			this.Text = "Random People Generator";

			setlabelsPos();
		}

		/// <summary>
		/// Set MainWindow progress bar to proper value
		/// </summary>
		/// <param name="progres">precentage of progressbar</param>
		public void SetProgress(int progres)
		{
			this.bar_progress.Value = progres;
		}

		//------------------CLICK BUTTON START-ZONE----------------------
		//Change language to english with proper dialog and change check
		private void englishToolStripMenuItem_Click(object sender, EventArgs e)
		{
			//if english isnt set now
			if(!englishToolStripMenuItem.Checked)
			{
				//and if there isnt genereted person
				if(!string.IsNullOrWhiteSpace(lblval_name.Text))
				{
					//show messagebox with question
					DialogResult dialogResult = MessageBox.Show("Changing language will erase currently created person!\nDo you wish to proceed?", "ATTENTION", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
					if(dialogResult == DialogResult.Yes)
					{
						//if approved change language
						polishToolStripMenuItem.Checked = false;
						englishToolStripMenuItem.Checked = true;
						setLangEnglish();
					}
				}
				else
				{
					//change language without asking
					polishToolStripMenuItem.Checked = false;
					englishToolStripMenuItem.Checked = true;
					setLangEnglish();
				}
			}
		}

		//Change language to polish with proper dialog and change check
		private void polishToolStripMenuItem_Click(object sender, EventArgs e)
		{
			//if polish isnt set now
			if(!polishToolStripMenuItem.Checked)
			{
				//and if there isnt genereted person
				if(!string.IsNullOrWhiteSpace(lblval_name.Text))
				{
					//show messagebox with question
					DialogResult dialogResult = MessageBox.Show("Zmiana języka spowoduje usunięcie aktualnie stworzonej osoby.\nCzy chcesz kontynuować?", "UWAGA!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
					if(dialogResult == DialogResult.Yes)
					{
						//if approved change language
						englishToolStripMenuItem.Checked = false;
						polishToolStripMenuItem.Checked = true;
						setLangPolish();
					}
				}
				else
				{
					//change language without asking
					englishToolStripMenuItem.Checked = false;
					polishToolStripMenuItem.Checked = true;
					setLangPolish();
				}
			}
		}

		//Check men
		private void menToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if(menToolStripMenuItem.Checked == true)
				menToolStripMenuItem.Checked = false;
			else
				menToolStripMenuItem.Checked = true;
		}

		//Check women
		private void womenToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if(womenToolStripMenuItem.Checked == true)
				womenToolStripMenuItem.Checked = false;
			else
				womenToolStripMenuItem.Checked = true;
		}

		//Smoothly exit app
		private void closeProgramToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		//Who's your daddy
		private void authorToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Paweł Kastelik\nwww.github.com/paulkastel\n\nKraków, 08.2016", "About author", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		//Info about program
		private void infoToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Aplikacja pobierająca z bazy danych losowe wartości spajające je w całość i pozwalająca eksportować je do plików .vcf\n\nProgram generuje tylko losowe dane, wszelka zbieżność z prawdziwymi osobami jest przypadkowa i nie zamierzona!\n\nProgram needs SQL Express turned on to work properly.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
		}

		//Clock in app
		private void timer1_Tick(object sender, EventArgs e)
		{
			timeDateStat_lbl.Text = DateTime.Now.ToString();
		}

		//Export vCard of random person, because you can
		private void exportToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				//Create vCard on Desktop
				File.Create(Environment.GetFolderPath(System.Environment.SpecialFolder.DesktopDirectory) + "\\" + lblval_name.Text + ".vcf").Close();
				//script of vCard
				string vCardScript = "BEGIN:VCARD\nN:" + person.surname + ";" + person.name + ";;;\nADR;DOM;PARCEL;HOME:;;" + person.street + ";" + person.city + ";" + person.wojewodztwo_province + ";" + person.ZIP + ";" + person.Panstwo + "\nEMAIL;INTERNET: \nTEL;CELL:" + person.phonenum + "\nTITLE:" + person.occupation + "END:VCARD";
				//save that script in file.
				File.WriteAllText(Environment.GetFolderPath(System.Environment.SpecialFolder.DesktopDirectory) + "\\" + lblval_name.Text + ".vcf", vCardScript);
				MessageBox.Show("File sucessfully exported to: " + Environment.GetFolderPath(System.Environment.SpecialFolder.DesktopDirectory), "vCard saved!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				exportToolStripMenuItem.Enabled = false; //prevent from exporting all over the same vCard
			}
			catch(Exception ex)
			{
				MessageBox.Show("Cannot export file because:\n" + ex, "vCard error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		
		//=====================MOST IMPORTANTE METHODE=================
		private void btn_NewPerson_Click(object sender, EventArgs e)
		{
			//if clicked mouse cursor is waiting
			Cursor.Current = Cursors.WaitCursor;
			try
			{
				SetProgress(0);						//progressbar 0%
				btn_NewPerson.Enabled = false;		//preventing from creating persons like crazy

				//create person (if only men checked only men will be generated. Same to women)
				person = new Person(menToolStripMenuItem.Checked, womenToolStripMenuItem.Checked);

				//Fill labels with personal details
				lblval_age.Text = person.age.ToString();
				lblval_idnum.Text = person.idnum;
				lblval_phone.Text = person.phonenum;
				lblval_name.Text = person.name + " " + person.surname;
				lblval_str_num.Text = person.street;
				lblval_zip_city.Text = person.ZIP + " " + person.city;
				lblval_prov_county.Text = person.wojewodztwo_province + ", " + person.powiat_county;

				SetProgress(90); //progressbar 90%. Well... that escalated quickly.

				//if language is set to english, labels will be in english.
				if(englishToolStripMenuItem.Checked)
				{
					lblval_occupy.Text = person.occupation;
					lblval_country.Text = person.Country;
					lblval_parnames.Text = person.motherName + " and " + person.fatherName;
					if(person.sex == "M")
						lblval_sex.Text = "Male";
					else
						lblval_sex.Text = "Female";
				}
				else //if polish is set, labels will be in polish
				{
					if(person.occupation == "Unemployed")
					{
						if(person.sex == "M")
							lblval_occupy.Text = "Bezrobotny";
						else
							lblval_occupy.Text = "Bezrobotna";
					}
					else if(person.occupation == "Too young for job!")
					{
						if(person.sex == "M")
							lblval_occupy.Text = "Za młody do pracy";
						else
							lblval_occupy.Text = "Za młoda do pracy";
					}
					else //show normal proffession
						lblval_occupy.Text = person.occupation;

					lblval_country.Text = person.Panstwo;
					lblval_parnames.Text = person.motherName + @" oraz " + person.fatherName;

					if(person.sex == "M")
						lblval_sex.Text = "Mężczyzna";
					else
						lblval_sex.Text = "Kobieta";
				}

				exportToolStripMenuItem.Enabled = true; 	//you can create vcf files now, by using proper function
				personal_count++;							//increase counter
				personal_count_lbl.Text = personal_count.ToString();
				btn_NewPerson.Enabled = true;				//you can create another person if you did not like current.

				SetProgress(100); //progressbar 100%. Completed.
			}
			catch(Exception err)
			{
				//Because, nothing will go wrong, right?
				MessageBox.Show("Something went seriously wrong!\n" + err, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				//Whatever happen, change cursor to defalut arrow.
				Cursor.Current = Cursors.Default;
			}
		}

		private void fantasyNameToolStripMenuItem_Click(object sender, EventArgs e)
		{
			DialogResult dialogResult = MessageBox.Show("You fantasy name is: "+setFrantasyName(), "FANTASY NAME", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
			if(dialogResult == DialogResult.Yes)
			{
				fantasyNameToolStripMenuItem_Click(sender, e);
			}
			else
			{
			}
		}
		private string setFrantasyName()
		{
			Random rnd = new Random();
			string[] beg_name = new string[]
			{
				"Ar","Nei","Korn","Go","Zer","Fod","Kas","Pr","Wed","Mod","Hei","Bof", "Cu", "Ci","Zy"
			};
			string[] mid_name = new string[]
			{
				"og","bra","n","o","roj","asa","zz","hon","u","ij","des","yh", "du","kh"
			};
			string[] end_name = new string[]
			{
				"nig","ing","x","a","r","op","s","c","ag","sin","me","us"
			};
			return beg_name[rnd.Next(beg_name.Length)] + mid_name[rnd.Next(mid_name.Length)] + end_name[rnd.Next(end_name.Length)];
		}
		//=============================================================
		
		//---------------------CLICK BUTTON END - ZONE-----------------
	}
}