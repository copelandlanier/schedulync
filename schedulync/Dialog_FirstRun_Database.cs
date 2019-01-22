using System;
using System.Drawing;
using System.Linq;
using LiteDB;
using System.Windows.Forms;
using System.IO;

namespace Calendar_NEW
{
    public partial class Dialog_FirstRun_Database : Global_Access
    {
        public string selected_DATABASE_Path;
        public string entered_DATABASE_Name;
        public string pathOnly_DATABASE;

        public Dialog_FirstRun_Database()
        {
            InitializeComponent();
            panel_CreateDatabase.Hide();
            panel_ExistingDatabase.Hide();
            panel_DatabaseLocation.Hide();
            WelcomeButton_Next.Enabled = false;
            textBox_DatabaseLocation.Enabled = false;
            button_DatabaseOpen.Location = new Point(384, 32);
            panel_ButtonSelection.Location = new Point(170, 170);
            panel_ExistingDatabase.Location = new Point(54, 120);
            panel_CreateDatabase.Location = new Point(54, 120);
            panel_DatabaseLocation.Location = new Point(54, 180);
            panel_SelectDatabaseNote.Location = new Point(140, 130);
            radio_NewDB.CheckedChanged += Radio_NewDB_CheckedChanged;
            textBox_CreateDBName.MouseDown += TextBox_CreateDBName_MouseDown;
            radio_ExistingDB.CheckedChanged += Radio_ExistingDB_CheckedChanged;
            textBox_DatabaseLocation.MouseDown += TextBox_DatabaseLocation_MouseDown;
        }

        private void TextBox_CreateDBName_MouseDown(object sender, MouseEventArgs e)
        {
            ChangeTextboxBGToDefault();
        }

        private void TextBox_DatabaseLocation_MouseDown(object sender, MouseEventArgs e)
        {
            ChangeTextboxBGToDefault();
        }

        private void Radio_ExistingDB_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_ExistingDB.Checked == true)
            {
                ExistingDatabase();
            }
        }

        private void Radio_NewDB_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_NewDB.Checked == true)
            {
                NewDatabase();
            }
            MonolithConsole("New Button Pressed");
        }

        public void NewDatabase()
        {
            panel_ButtonSelection.Location = new Point(54, 82);
            textBox_DatabaseLocation.Text = "";
            textBox_CreateDBName.Text = "";
            panel_CreateDatabase.Show();
            panel_ExistingDatabase.Hide();
            panel_DatabaseLocation.Show();
            panel_SelectDatabaseNote.Hide();
            button_DatabaseOpen.Hide();
            button_DatabaseBrowse.Show();
            DBConnected_LED.BackColor = Color.DarkRed;
            label_DBConnectedStatus.Text = "Database Status: DISCONNECTED";
            ChangeTextboxBGToDefault();
            WelcomeButton_Next.Enabled = false;
        }

        public void ExistingDatabase()
        {
            panel_ButtonSelection.Location = new Point(54, 82);
            textBox_DatabaseLocation.Text = "";
            panel_CreateDatabase.Hide();
            panel_ExistingDatabase.Show();
            panel_DatabaseLocation.Show();
            panel_SelectDatabaseNote.Hide();
            button_DatabaseOpen.Show();
            button_DatabaseBrowse.Hide();
            textBox_CreateDBName.Enabled = true;
            button_DatabaseBrowse.Enabled = true;
            DBConnected_LED.BackColor = Color.DarkRed;
            label_DBConnectedStatus.Text = "Database Status: DISCONNECTED";
            ChangeTextboxBGToDefault();
            WelcomeButton_Next.Enabled = false;
        }

        private void button_DatabaseBrowse_Click(object sender, EventArgs e)
        {
            WelcomeButton_Next.Enabled = false;
            ChangeTextboxBGToDefault();
            selected_DATABASE_Path = "";
            if (folderBrowserDialog_Welcome.ShowDialog() == DialogResult.OK)
            {
                selected_DATABASE_Path = folderBrowserDialog_Welcome.SelectedPath;
                textBox_DatabaseLocation.Text = selected_DATABASE_Path;
            }
        }

        private void button_DatabaseOpen_Click(object sender, EventArgs e)
        {
            WelcomeButton_Next.Enabled = false;
            ChangeTextboxBGToDefault();
            selected_DATABASE_Path = "";
            openFileDialog_Welcome.Filter = "db files (*.db)|*.db|All files (*.*)|*.*";
            openFileDialog_Welcome.FileName = string.Empty;

            if (openFileDialog_Welcome.ShowDialog() == DialogResult.OK)
            {
                DBConnected_LED.BackColor = Color.DarkRed;
                label_DBConnectedStatus.Text = "Database Status: DISCONNECTED";
                textBox_DatabaseLocation.Text = openFileDialog_Welcome.FileName;
                FileInfo fileinfo = new FileInfo(openFileDialog_Welcome.FileName);
                selected_DATABASE_Path = fileinfo.DirectoryName;
                entered_DATABASE_Name = Path.GetFileNameWithoutExtension(openFileDialog_Welcome.SafeFileName);
                Console.WriteLine("Entered Name: {0}, Selected Path: {1}", entered_DATABASE_Name, selected_DATABASE_Path);
            }
        }

        private void WelcomeButton_Next_Click(object sender, EventArgs e)
        {
            using (var db = new LiteDatabase(selected_DATABASE_Path + entered_DATABASE_Name + ".db"))
            {
                var EmployeeCollection = db.GetCollectionNames();

                if (EmployeeCollection.Count() > 11)
                {
                    MessageBox.Show("The Maximum amount of users (9) has been reached for this database. Please have an authorized user address user data.");
                }
                else
                {
                    dialog_ftpsettings.Show();
                    this.Hide();
                }
            }            
        }

        private void button_DatabaseConnect_Click(object sender, EventArgs e)
        {
            string SAVE_INTERNAL = AppDomain.CurrentDomain.BaseDirectory + "database_internal.db";

            // Perform function if "Existing Database" is selected
            if (radio_ExistingDB.Checked == true)
            {
                selected_DATABASE_Path = selected_DATABASE_Path + "\\";
                if (textBox_DatabaseLocation.Text != "")
                {
                    if (Path.IsPathRooted(textBox_DatabaseLocation.Text) == false)
                    {
                        textBox_DatabaseLocation.BackColor = ErrorColor;
                        MessageBox.Show("Please use a valid directory path. (e.g. C:\\Network\\User\\Desktop)");
                    }

                    else if (Path.IsPathRooted(textBox_DatabaseLocation.Text) == true)
                    {
                        using (var db = new LiteDatabase(selected_DATABASE_Path + entered_DATABASE_Name + ".db"))
                        {
                            if (db.CollectionExists("Empty_Collection"))
                            {
                                DBConnected_LED.BackColor = Color.Green;
                                label_DBConnectedStatus.Text = "Database Status: CONNECTED";
                                WelcomeButton_Next.Enabled = true;
                                DATABASE_EXTERNAL = selected_DATABASE_Path + entered_DATABASE_Name + ".db";
                                File.Copy(DATABASE_EXTERNAL, SAVE_INTERNAL, true);

                                var EmployeeCollection = db.GetCollectionNames();
                            }
                            else
                            {
                                MessageBox.Show("Error connecting. Database is not a Monolith Calendar database or is missing the 'Empty_Collection' document. Please create a new database");
                            }
                        }
                    }
                }

                else
                {
                    textBox_DatabaseLocation.BackColor = ErrorColor;
                }
            }

            // Perform function if "New Database" is selected
            else if (radio_NewDB.Checked == true)
            {
                entered_DATABASE_Name = textBox_CreateDBName.Text;
                selected_DATABASE_Path = folderBrowserDialog_Welcome.SelectedPath + "\\";

                // If Database name or location text fields are empty, display an error state
                if (textBox_CreateDBName.Text == "" || textBox_DatabaseLocation.Text == "")
                {
                    if (textBox_CreateDBName.Text == "")
                    {
                        textBox_CreateDBName.BackColor = ErrorColor;
                    }

                    if (textBox_DatabaseLocation.Text == "")
                    {
                        textBox_DatabaseLocation.BackColor = ErrorColor;
                    }
                }

                // If the file path is an incorrect format, display an error
                else if (Path.IsPathRooted(textBox_DatabaseLocation.Text) == false)
                {
                    textBox_DatabaseLocation.BackColor = ErrorColor;
                    MessageBox.Show("Please use a valid directory path. (e.g. C:\\Network\\User\\Desktop)");
                }

                else if (Directory.GetFiles(selected_DATABASE_Path, "*.db").Length == 0)
                {
                    File.Delete(SAVE_INTERNAL);
                    // Create and test operation of new database
                    using (var db_primary = new LiteDatabase(selected_DATABASE_Path + entered_DATABASE_Name + ".db"))
                    {
                        // Added remote path only
                        pathOnly_DATABASE = selected_DATABASE_Path;

                        using (var db_temp = new LiteDatabase(SAVE_INTERNAL))
                        {
                            var EmployeeCollectionA = db_primary.GetCollection<Calendar>("Empty_Collection");
                            var EmployeeCollectionB = db_temp.GetCollection<Calendar>("Empty_Collection");
                            Calendar addEmptyInfo = new Calendar { Notes = "This is an empty document used as a position flag" };
                            EmployeeCollectionA.Insert(addEmptyInfo);
                            EmployeeCollectionB.Insert(addEmptyInfo);
                        }                          

                        // Test to see if database was created
                        if (File.Exists(selected_DATABASE_Path + entered_DATABASE_Name + ".db"))
                        {
                            DBConnected_LED.BackColor = Color.Green;
                            label_DBConnectedStatus.Text = "Database Status: CONNECTED";
                            WelcomeButton_Next.Enabled = true;
                            DATABASE_EXTERNAL = selected_DATABASE_Path + entered_DATABASE_Name + ".db";
                        }

                        textBox_CreateDBName.Enabled = false;
                        textBox_DatabaseLocation.Enabled = false;
                        button_DatabaseBrowse.Enabled = false;
                    }
                }

                // If Connect button is pressed while test has already been succesful or not- try again
                else
                {
                    if (textBox_CreateDBName.Enabled == false)
                    {
                        if (File.Exists(selected_DATABASE_Path + entered_DATABASE_Name + ".db"))
                        {
                            DBConnected_LED.BackColor = Color.Green;
                            label_DBConnectedStatus.Text = "Database Status: CONNECTED";
                            WelcomeButton_Next.Enabled = true;
                        }
                    }

                    // If a file already exists in the directory, display a message box indicating this
                    else
                    {
                        MessageBox.Show("A database file(s) already exists. Please create another directory.");
                    }
                }
            }
        }

        // Change textboxes to default color
        private void ChangeTextboxBGToDefault()
        {
            textBox_CreateDBName.BackColor = Color.White;
            textBox_DatabaseLocation.BackColor = Color.White;
        }
    }
}
