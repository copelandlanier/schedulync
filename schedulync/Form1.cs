using System;
using System.Drawing;
using System.IO;
using System.Net.NetworkInformation;
using System.Windows.Forms;

namespace Calendar_NEW
{
    public partial class Form1 : Global_Access
    {
        protected Image PersonnelImage;

        public Form1()
        {
            /// Splash Screen Startup
            //Splash_Screen sp = new Splash_Screen();
            //sp.Show();


            InitializeComponent();

            MonolithConsole("Console Started. Press 'Alt' + 'C' to clear.");
            fileSystemWatcher_Config.EnableRaisingEvents = false;
            fileSystemWatcher_RemoteDB.EnableRaisingEvents = false;
            fileSystemWatcher_WebUpload.EnableRaisingEvents = false;
            //fileSystemWatcher_RemoteDB.NotifyFilter = NotifyFilters.LastAccess;
            fileSystemWatcher_RemoteDB.Filter = "*.x";

            /// Assign default Main Background color
            this.BackColor = Color.White;

            /// Assign default event overlay color image for day view at start 
            display_Panel1.ExpandBGImage1 = Properties.Resources.BG_Default;
            display_Panel1.ExpandBGImage2 = Properties.Resources.BG_Default;
            display_Panel1.ExpandBGImage4 = Properties.Resources.BG_Default;
            display_Panel1.ExpandBGImage3 = Properties.Resources.BG_Default;
            display_Panel1.ExpandBGImage5 = Properties.Resources.BG_Default;
            display_Panel1.ExpandBGImage6 = Properties.Resources.BG_Default;
            display_Panel1.ExpandBGImage7 = Properties.Resources.BG_Default;
            display_Panel1.ExpandBGImage8 = Properties.Resources.BG_Default;
            display_Panel1.ExpandBGImage9 = Properties.Resources.BG_Default;
            display_Panel1.ExpandBGImage10 = Properties.Resources.BG_Default;

            /// Assign a default color for day view at start
            display_Panel1.DayBackColor_1 = defaultColor;
            display_Panel1.DayBackColor_2 = defaultColor;
            display_Panel1.DayBackColor_3 = defaultColor;
            display_Panel1.DayBackColor_4 = defaultColor;
            display_Panel1.DayBackColor_5 = defaultColor;
            display_Panel1.DayBackColor_6 = defaultColor;
            display_Panel1.DayBackColor_7 = defaultColor;
            display_Panel1.DayBackColor_8 = defaultColor;
            display_Panel1.DayBackColor_9 = defaultColor;
            display_Panel1.DayBackColor_10 = defaultColor;

            /// Show the day view display panel
            display_Panel1.DayVisible_1 = true;
            display_Panel1.DayVisible_2 = true;
            display_Panel1.DayVisible_3 = true;
            display_Panel1.DayVisible_4 = true;
            display_Panel1.DayVisible_5 = true;
            display_Panel1.DayVisible_6 = true;
            display_Panel1.DayVisible_7 = true;
            display_Panel1.DayVisible_8 = true;
            display_Panel1.DayVisible_9 = true;
            display_Panel1.DayVisible_10 = true;
            
            /// Assign default text for day view at start
            display_Panel1.pib_1.label_PImageName.Text = "---";
            display_Panel1.pib_2.label_PImageName.Text = "---";
            display_Panel1.pib_3.label_PImageName.Text = "---";
            display_Panel1.pib_4.label_PImageName.Text = "---";
            display_Panel1.pib_5.label_PImageName.Text = "---";
            display_Panel1.pib_6.label_PImageName.Text = "---";
            display_Panel1.pib_7.label_PImageName.Text = "---";
            display_Panel1.pib_8.label_PImageName.Text = "---";
            display_Panel1.pib_9.label_PImageName.Text = "---";
            display_Panel1.pib_10.label_PImageName.Text = "---";

            display_Panel1.pib_2.Visible = false;
            display_Panel1.pib_3.Visible = false;
            display_Panel1.pib_4.Visible = false;
            display_Panel1.pib_5.Visible = false;
            display_Panel1.pib_6.Visible = false;
            display_Panel1.pib_7.Visible = false;
            display_Panel1.pib_8.Visible = false;
            display_Panel1.pib_9.Visible = false;
            display_Panel1.pib_10.Visible = false;

            
            // # Layout Resize Function
            //display_Panel1.Panel_DayControlHolder.Width = display_Panel1.day_Control_1.Width + display_Panel1.day_Control_1.Width + 16;

            // File SYstem Watcher Parameters for the web folder.
            if (Directory.Exists(AppDomain.CurrentDomain.BaseDirectory + "Web_Upload"))
            {
                fileSystemWatcher_WebUpload.Path = (AppDomain.CurrentDomain.BaseDirectory + "Web_Upload");
            }

            // Check to see if Web_Upload folder exists. If not, create it.
            else if(Directory.Exists(AppDomain.CurrentDomain.BaseDirectory + "Web_Upload") && (FIRSTRUN_SWITCH != false || FIRSTRUN_SWITCH != false) == false)
            {
                if (FIRSTRUN_SWITCH == true)
                {
                    MessageBox.Show("The directory: (Web_Ulpoad) does not exist, please create it at root/. Schedule will not be uploaded to the web.");
                }
            }

            else if (Directory.Exists(AppDomain.CurrentDomain.BaseDirectory + "Web_Upload") == false)
            {
                Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + "Web_Upload").Attributes = FileAttributes.Hidden;
            }

            // Check to see if Calendar_Configuration folder exists. If not, create it.
            if (Directory.Exists(AppDomain.CurrentDomain.BaseDirectory + "Calendar_Configuration") == false)
            {
                Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + "Calendar_Configuration").Attributes = FileAttributes.Hidden;
            }                       
            
            // Check for Configuration File
            if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + "Calendar_Configuration/configuration") == false)
            {
                dialog_database.Show();
                dialog_database.BringToFront();
                this.SendToBack();
                this.Opacity = 0;
                this.WindowState = FormWindowState.Minimized;
            }

            if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + "Calendar_Configuration/configuration"))
            {
                StreamReader sr = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + "Calendar_Configuration/configuration");
                if (sr.ReadLine() != "Normal")
                {
                    dialog_database.Show();
                    dialog_database.BringToFront();
                    this.SendToBack();
                    this.Opacity = 0;
                    this.WindowState = FormWindowState.Minimized;
                }

                else
                {
                    // Read file information
                    config_load.MainLoad();
                    this.Refresh();
                }                
            }

            /// Assign Events
            NetworkChange.NetworkAvailabilityChanged += new NetworkAvailabilityChangedEventHandler(NetworkChange_NetworkAvailabilityChanged);
            dialog_database.CancelButton_Cancel.Click += CancelButton_Cancel_Click;
            dialog_settings.SettingsButton_Cancel.Click += SettingsButton_Cancel_Click;
            dialog_duplicate.DuplicateButton_Cancel.Click += DuplicateButton_Cancel_Click;
            dialog_duplicate.DuplicateButton_Next.Click += DuplicateButton_Next_Click;
            dialog_ftpsettings.FTPButton_Cancel.Click += FTPButton_Cancel_Click;
            dialog_settings.SettingsButton_Next.Click += SettingsButton_Next_Click;
            dialog_database.FormClosing += Dialog_database_FormClosing;
            dialog_settings.FormClosing += Dialog_settings_FormClosing;
            dialog_ftpsettings.FormClosing += Dialog_ftpsettings_FormClosing;
            dialog_duplicate.FormClosing += Dialog_duplicate_FormClosing;
            //this.FormClosing += Form1_FormClosing;
            dialog_exit.button_ExitYES.MouseDown += Button_ExitYES_MouseDown;
            fileSystemWatcher_WebUpload.Created += FileSystemWatcher_WebUpload_Created;
            fileSystemWatcher_WebUpload.Changed += FileSystemWatcher_WebUpload_Changed;
            fileSystemWatcher_Config.Created += FileSystemWatcher_Config_Created;
            fileSystemWatcher_Config.Changed += FileSystemWatcher_Config_Changed;
            fileSystemWatcher_RemoteDB.Changed += FileSystemWatcher_RemoteDB_Changed;

            //EventWaitHandle eventWait = new EventWaitHandle(true, EventResetMode.AutoReset, "EVENT_WAIT");

        }

        private void NetworkChange_NetworkAvailabilityChanged(object sender, NetworkAvailabilityEventArgs e)
        {
            if (e.IsAvailable)
            {
                MessageBox.Show("Network is connected.");
            }

            else
            {
                MessageBox.Show("Network is not connected.");
            }
        }

        //File Watchers: Remote/ Configuration/ Web Upload folders.
        private void FileSystemWatcher_RemoteDB_Changed(object sender, FileSystemEventArgs e)
        {
            Config_Load data_op = new Config_Load();
            data_op.ADDRemoteUsers();
            this.Refresh();            
        }

        private void FileSystemWatcher_Config_Changed(object sender, FileSystemEventArgs e)
        {
            MonolithConsole("Configuration folder has changes to it....");
        }

        private void FileSystemWatcher_Config_Created(object sender, FileSystemEventArgs e)
        {

        }

        private void FileSystemWatcher_WebUpload_Changed(object sender, FileSystemEventArgs e)
        {
            MonolithConsole("File has been changed: WEB");
        }

        private void FileSystemWatcher_WebUpload_Created(object sender, FileSystemEventArgs e)
        {
            MonolithConsole("File has been created: WEB");
        }        

        // Non local button events that control the main form.
        private void SettingsButton_Next_Click(object sender, EventArgs e)
        {
            string s = null;
            
            if (DATABASE_NAME != s || FIRST_NAME != s || JOB_TITLE != s || LAST_NAME != s || EMAIL != s || PHONE != s || AVATAR_LOCAL != s || THEME != s)
            {
                FormMaximize();
            }
        }

        private void DuplicateButton_Next_Click(object sender, EventArgs e)
        {
            dialog_duplicate.DuplicateButton_Next.Enabled = false;
            string FULL_NAME = dialog_duplicate.listBox_Duplicate.SelectedItem.ToString();
            File.Copy(DATABASE_EXTERNAL = dialog_database.openFileDialog_Welcome.FileName, AppDomain.CurrentDomain.BaseDirectory + "database_internal.db", true);
            FileInfo fi = new FileInfo(AppDomain.CurrentDomain.BaseDirectory + "database_internal.db");
            DATABASE_OPERATIONS database_op = new DATABASE_OPERATIONS();

            while (database_op.IsFileLocked(fi, AppDomain.CurrentDomain.BaseDirectory + "database_internal.db") == true)
            {
                Console.WriteLine("Wainting for database to unlock: Duplicate NEXT Button");
            }

            if (database_op.IsFileLocked(fi, AppDomain.CurrentDomain.BaseDirectory + "database_internal.db") == false)
            {
                DATABASE_OPERATIONS dbo = new DATABASE_OPERATIONS();
                MonolithConsole("File is unlocked in Duplicate NExt Button " + dbo.IsFileLocked(fi, AppDomain.CurrentDomain.BaseDirectory + "database_internal.db"));
                dbo.RETRIEVE_IMAGE_FILE(FULL_NAME);
                dbo.RETRIEVE_CONFIG_FILE(FULL_NAME);
                dialog_duplicate.DuplicateButton_Next.Enabled = true;
                config_load.MainLoad();
                dialog_duplicate.Hide();
                FormMaximize();
            }
            else
            {
                MonolithConsole("File is locked...");
            }
        }

        private void Button_ExitYES_MouseDown(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void Dialog_duplicate_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Close();
        }

        private void Dialog_settings_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Close();
        }

        private void Dialog_database_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Close();
        }

        private void Dialog_ftpsettings_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Close();
        }

        private void DuplicateButton_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SettingsButton_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CancelButton_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FTPButton_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormMaximize()
        {
            backgroundWorker_Listener.WorkerReportsProgress = true;
            backgroundWorker_Listener.WorkerSupportsCancellation = true;
            this.Opacity = 100;
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
