using System;
using System.IO;
using System.Drawing;
using System.Linq;
using LiteDB;
using System.Windows.Forms;

namespace Calendar_NEW
{
    public class Config_Load : Global_Access
    {
        string FIRST_NAME_ROB;
        string LAST_NAME_ROB;
        string FIRST_NAME_LOU;
        string LAST_NAME_LOU;
        string FIRST_NAME_KEV;
        string LAST_NAME_KEV;
        string FIRST_NAME_COP;
        string LAST_NAME_COP;
        string FIRST_NAME_JEF;
        string LAST_NAME_JEF;
        string FIRST_NAME_TIM;
        string LAST_NAME_TIM;
        string FIRST_NAME_ANT;
        string LAST_NAME_ANT;
        string FIRST_NAME_CHR;
        string LAST_NAME_CHR;
        string FIRST_NAME_USER;
        string LAST_NAME_USER;
        protected Image PersonnelImage;
        protected Color RemoteColor;
        protected Image RemoteBGImage;
        protected int User;

        public Config_Load()
        {
            // Configuration Entrance
        }

        public void MainLoad()
        {
            string[] lines = File.ReadAllLines(AppDomain.CurrentDomain.BaseDirectory + "Calendar_Configuration/configuration");
            
            /*
            if (Loading remoteUsers Fails)
            {
                Pull information from local database
            }
            */

            // Check to see if the local database is the most recent copy of the remote database. If not, copy it to the local database.
            FileInfo localDB = new FileInfo(AppDomain.CurrentDomain.BaseDirectory + "database_internal.db");
            FileInfo remoteDB = new FileInfo(lines[18] + lines[17] + ".db");

            if (File.Equals(localDB.LastWriteTime, remoteDB.LastWriteTime) == false)
            {
                if (File.Exists(lines[18] + lines[17] + ".db") == true)
                {
                    File.Copy(lines[18] + lines[17] + ".db", AppDomain.CurrentDomain.BaseDirectory + "database_internal.db", true);
                }
                else
                {
                    //Dialog_DatabaseNotConnected notConnected = new Dialog_DatabaseNotConnected();
                    //notConnected.Show();
                    MessageBox.Show("The remote database " + (lines[18] + lines[17] + ".db") + " is offline. An empty database will be recreated. Please check database connection.");
                }
            }

            // Set default user.
            SetTheme();
            LoadImage();
            display_Panel1.pib_1.panel_PersonnelImage.BackgroundImage = PersonnelImage;
            display_Panel1.pib_1.label_PImageName.Text = lines[8] + " " + lines[9];
            display_Panel1.Panel_DayControlHolder.Controls.Add(display_Panel1.day_Control_1);

            // Load Settings Menu
            dialog_internalsettings.label_SelectDBDatabase.Text = "CURRENT DATABASE: " + lines[18] + lines[17] + ".db";
            dialog_internalsettings.textBoxSettings_FirstName.Text = lines[8];
            dialog_internalsettings.textBoxSettings_LastName.Text = lines[9];
            dialog_internalsettings.maskedTextBox_Email.Text = lines[10];
            dialog_internalsettings.maskedTextBox_Phone.Text = lines[11];
            dialog_internalsettings.textBoxSettings_JobTitle.Text = lines[12];
            dialog_internalsettings.textBoxSettings_Host.Text = lines[20];
            dialog_internalsettings.textBoxSettings_UserName.Text = lines[21];
            dialog_internalsettings.textBoxSettings_Password.Text = lines[22];
            dialog_internalsettings.textBoxSettings_Port.Text = lines[23];
            dialog_internalsettings.textBoxSettings_Folder.Text = lines[25];
            if(lines[24] == "False")
            {
                dialog_internalsettings.checkBox_Passive.CheckState = CheckState.Unchecked;
            }
            else if (lines[24] == "True")
            {
                dialog_internalsettings.checkBox_Passive.CheckState = CheckState.Checked;
            }

            string EXTERNAL_DATABASE = lines[18] + lines[17] + ".db";
            string DATABASE_EXTERNAL = EXTERNAL_DATABASE;

            using (var db = new LiteDatabase(EXTERNAL_DATABASE))
            {
                var EmployeeCollection = db.GetCollectionNames();
                var NumberCollect = db.CollectionExists("Copeland Lanier");
                Console.WriteLine("" + NumberCollect);
                for (int x = 3; x < EmployeeCollection.Count(); x++)
                {                    
                    PersonnelList.Add(EmployeeCollection.ElementAtOrDefault(x));
                Console.WriteLine("USING: " + EmployeeCollection.Count());
                }
            }

            for (int x = 0; x < PersonnelList.Count(); x++)
            {
                dialog_internalsettings.listBox_SettingUsers.Items.Add(PersonnelList[x]);
                MonolithConsole(PersonnelList[x]);
            }

            dialog_internalsettings.label_InternalSettings_Registered.Text = lines[8] + " " + lines[9];
            dialog_internalsettings.panelSettings_ImageBox.BackgroundImage = resizeImage(PersonnelImage, new Size(dialog_internalsettings.panelSettings_ImageBox.Width, dialog_internalsettings.panelSettings_ImageBox.Height));


            if (lines[18] != null)
            {
                DATABASE_EXTERNAL = lines[18];

                // File watcher ON REMOTE DATABASE.
                fileSystemWatcher_RemoteDB.Path = DATABASE_EXTERNAL;
                MonolithConsole("Remote Database Path: " + DATABASE_EXTERNAL);
            }
            
            // Add in remote users.
            ADDRemoteUsers();

            // Set Internal Settings Menu
            dialog_internalsettings.ApplyThemeColor(lines[13]);

            // Add file watchers
            fileSystemWatcher_WebUpload.Path = AppDomain.CurrentDomain.BaseDirectory + "Web_Upload";
            fileSystemWatcher_Config.Path = AppDomain.CurrentDomain.BaseDirectory + "Calendar_Configuration";

            fileSystemWatcher_Config.EnableRaisingEvents = true;
            fileSystemWatcher_RemoteDB.EnableRaisingEvents = true;
            fileSystemWatcher_WebUpload.EnableRaisingEvents = true;
            backgroundWorker_Listener.WorkerReportsProgress = true;
            backgroundWorker_Listener.WorkerSupportsCancellation = true;
        }

        // Load default user's image.
        protected void LoadImage()
        {
            string[] lines = File.ReadAllLines(AppDomain.CurrentDomain.BaseDirectory + "Calendar_Configuration/configuration");

            if (lines[14] != null)
            {
                DATABASE_OPERATIONS dbo = new DATABASE_OPERATIONS();
                string LAST_RETRIEVE = lines[9];
                string FIRST_RETRIEVE = lines[8];
                string FULLNAME_RETRIEVE = FIRST_RETRIEVE + "_" + LAST_RETRIEVE;
                dbo.RETRIEVE_IMAGE_FILE(FULLNAME_RETRIEVE);

                if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + "Calendar_Configuration/" + "avatar"))
                {
                    PersonnelImage = new Bitmap(AppDomain.CurrentDomain.BaseDirectory + "Calendar_Configuration/" + "avatar");
                    try
                    {
                        Image imageIn = PersonnelImage;
                        PersonnelImage = resizeImage(PersonnelImage, new Size(display_Panel1.pib_1.panel_PersonnelImage.Width, display_Panel1.pib_1.panel_PersonnelImage.Height));
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

                else
                {
                    PersonnelImage = new Bitmap(Properties.Resources.avatar_image);
                    try
                    {
                        Image imageIn = PersonnelImage;
                        PersonnelImage = resizeImage(PersonnelImage, new Size(display_Panel1.pib_1.panel_PersonnelImage.Width, display_Panel1.pib_1.panel_PersonnelImage.Height));
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        public static Image resizeImage(Image imgToResize, Size size)
        {
            return (Image)(new Bitmap(imgToResize, size));
        }

        // Set default user's theme.
        private void SetTheme()
        {
            string[] lines = File.ReadAllLines(AppDomain.CurrentDomain.BaseDirectory + "Calendar_Configuration/configuration");

            if (lines[13] == "ORANGE")
            {
                display_Panel1.ExpandBGImage1 = Properties.Resources.BG_Orange;
                display_Panel1.DayBackColor_1 = orange;
                ColorTransfer = theme_orange;
            }

            if (lines[13] == "MONOLITH")
            {
                display_Panel1.ExpandBGImage1 = Properties.Resources.BG_Monolith;
                display_Panel1.DayBackColor_1 = monolith;
                ColorTransfer = theme_monolith;
            }

            if (lines[13] == "BLUE")
            {
                display_Panel1.ExpandBGImage1 = Properties.Resources.BG_Blue;
                display_Panel1.DayBackColor_1 = blue;
                ColorTransfer = theme_blue;
            }

            if (lines[13] == "PINK")
            {
                display_Panel1.ExpandBGImage1 = Properties.Resources.BG_Pink;
                display_Panel1.DayBackColor_1 = pink;
                ColorTransfer = theme_pink;
            }

            if (lines[13] == "AQUA")
            {
                display_Panel1.ExpandBGImage1 = Properties.Resources.BG_Aqua;
                display_Panel1.DayBackColor_1 = aqua;
                ColorTransfer = theme_aqua;
            }

            if (lines[13] == "LAVENDAR")
            {
                display_Panel1.ExpandBGImage1 = Properties.Resources.BG_Lavendar;
                display_Panel1.DayBackColor_1 = lavendar;
                ColorTransfer = theme_lavendar;
            }

            if (lines[13] == "YELLOW")
            {
                display_Panel1.ExpandBGImage1 = Properties.Resources.BG_Yellow;
                display_Panel1.DayBackColor_1 = yellow;
                ColorTransfer = theme_yellow;
            }

            if (lines[13] == "GREEN")
            {
                display_Panel1.ExpandBGImage1 = Properties.Resources.BG_Green;
                display_Panel1.DayBackColor_1 = green;
                ColorTransfer = theme_green;
            }

            if (lines[13] == "GREY")
            {
                display_Panel1.ExpandBGImage1 = Properties.Resources.BG_Grey;
                display_Panel1.DayBackColor_1 = grey;
                ColorTransfer = theme_grey;
            }

            if (lines[13] == "PEACH")
            {
                display_Panel1.ExpandBGImage1 = Properties.Resources.BG_Peach;
                display_Panel1.DayBackColor_1 = peach;
                ColorTransfer = theme_peach;
            }

            if (lines[13] == "DEFAULTCOLOR")
            {
                display_Panel1.ExpandBGImage1 = Properties.Resources.BG_Default;
                display_Panel1.DayBackColor_1 = defaultColor;
                ColorTransfer = theme_defaultColor;
            }

            display_Panel1.button_DayControlSettings.FlatAppearance.BorderColor = ColorTransfer;
            display_Panel1.Button_DayControl_PrevMonth.BackColor = ColorTransfer;
            display_Panel1.Button_DayControl_NextMonth.BackColor = ColorTransfer;
            display_Panel1.Button_DayControl_PrevDay.BackColor = ColorTransfer;
            display_Panel1.Button_DayControl_NextDay.BackColor = ColorTransfer;
            display_Panel1.Button_DayControl_Today.BackColor = ColorTransfer;
            display_Panel1.button_DayControlSettings.BackColor = ColorTransfer;
            display_Panel1.panel_ColorBar.BackColor = ColorTransfer;
        }
       
        public void ADDRemoteUsers()
        {            
            MonolithConsole("Add Remote Users");
            int User2 = 0;
            int User3 = 0;
            int User4 = 0;
            int User5 = 0;
            int User6 = 0;
            int User7 = 0;
            int User8 = 0;
            int User9 = 0;
            int User10 = 0;

            int[] NameArrayInt;
            string[] FirstNamesArrayString;
            string[] LastNamesArrayString;

            //Copy all user information from remote database to local database.
            DATABASE_OPERATIONS dbo = new DATABASE_OPERATIONS();
            dbo.RETRIEVE_REMOTE_USERS();

            int fileCount = Directory.GetFiles(AppDomain.CurrentDomain.BaseDirectory + "Calendar_Configuration", "*.cfg").Length;
            string[] DirectoryFiles = Directory.GetFiles(AppDomain.CurrentDomain.BaseDirectory + "Calendar_Configuration", "*.cfg");


            for (int x = 0; x < fileCount; x++)
            {
                string SingleConfig = DirectoryFiles[x];
                string[] lines = File.ReadAllLines(SingleConfig);

                    using (StreamReader reader = File.OpenText(SingleConfig))
                    {
                    if (SingleConfig != AppDomain.CurrentDomain.BaseDirectory + "Calendar_Configuration/avatar" )
                    {
                        string FUllName = lines[8] + " " + lines[9];
                        if ((lines[8] == "Rob" || lines[8] == "Robert" || lines[8] == "R") && lines[9] == "Fleischacker")
                        {
                            if (lines[8] + " " + lines[9] != display_Panel1.pib_1.label_PImageName.Text)
                            {
                                User2 = 2;
                                FIRST_NAME_ROB = lines[8];
                                LAST_NAME_ROB = lines[9];
                            }
                        }

                        else if ((lines[8] == "Lou" || lines[8] == "Louis" || lines[8] == "L") && lines[9] == "Vicente")
                        {
                            if (lines[8] + " " + lines[9] != display_Panel1.pib_1.label_PImageName.Text)
                            {
                                User3 = 3;
                                FIRST_NAME_LOU = lines[8];
                                LAST_NAME_LOU = lines[9];
                            }
                        }

                        else if ((lines[8] == "Kevin" || lines[8] == "Kev" || lines[8] == "K") && lines[9] == "Keller")
                        {
                            if (lines[8] + " " + lines[9] != display_Panel1.pib_1.label_PImageName.Text)
                            {
                                User4 = 4;
                                FIRST_NAME_KEV = lines[8];
                                LAST_NAME_KEV = lines[9];
                            }
                        }

                        else if ((lines[8] == "Copeland" || lines[8] == "Cope" || lines[8] == "C") && lines[9] == "Lanier")
                        {
                            if (lines[8] + " " + lines[9] != display_Panel1.pib_1.label_PImageName.Text)
                            {
                                User5 = 5;
                                FIRST_NAME_COP = lines[8];
                                LAST_NAME_COP = lines[9];
                            }
                        }

                        else if ((lines[8] == "Jeff" || lines[8] == "Jeffrey" || lines[8] == "J") && lines[9] == "Friedman")
                        {
                            if (lines[8] + " " + lines[9] != display_Panel1.pib_1.label_PImageName.Text)
                            {
                                User6 = 6;
                                FIRST_NAME_JEF = lines[8];
                                LAST_NAME_JEF = lines[9];
                            }
                        }

                        else if ((lines[8] == "Tim" || lines[8] == "Timothy" || lines[8] == "T") && lines[9] == "Mocilan")
                        {
                            if (lines[8] + " " + lines[9] != display_Panel1.pib_1.label_PImageName.Text)
                            {
                                User7 = 7;
                                FIRST_NAME_TIM = lines[8];
                                LAST_NAME_TIM = lines[9];
                            }
                        }

                        else if ((lines[8] == "Anthony" || lines[8] == "Tony" || lines[8] == "A") && lines[9] == "Martano")
                        {
                            if (lines[8] + " " + lines[9] != display_Panel1.pib_1.label_PImageName.Text)
                            {
                                User8 = 8;
                                FIRST_NAME_ANT = lines[8];
                                LAST_NAME_ANT = lines[9];
                            }
                        }

                        else if ((lines[8] == "Christine" || lines[8] == "Christina" || lines[8] == "C") && lines[9] == "Bautista")
                        {
                            if (lines[8] + " " + lines[9] != display_Panel1.pib_1.label_PImageName.Text)
                            {
                                User9 = 9;
                                FIRST_NAME_CHR = lines[8];
                                LAST_NAME_CHR = lines[9];
                            }
                        }

                        else
                        {
                            if (lines[8] + " " + lines[9] != display_Panel1.pib_1.label_PImageName.Text)
                            {
                                User10 = 10;
                                FIRST_NAME_USER = lines[8];
                                LAST_NAME_USER = lines[9];
                            }
                        }
                    }
                }
            }
            
            FirstNamesArrayString = new string[] { FIRST_NAME_ROB, FIRST_NAME_LOU, FIRST_NAME_KEV, FIRST_NAME_COP, FIRST_NAME_JEF, FIRST_NAME_TIM, FIRST_NAME_ANT, FIRST_NAME_CHR, FIRST_NAME_USER };

            LastNamesArrayString = new string[] { LAST_NAME_ROB, LAST_NAME_LOU, LAST_NAME_KEV, LAST_NAME_COP, LAST_NAME_JEF, LAST_NAME_TIM, LAST_NAME_ANT, LAST_NAME_CHR, LAST_NAME_USER };

            NameArrayInt = new int[] { User2, User3, User4, User5, User6, User7, User8, User9, User10 };

            Logic_Arrangement la = new Logic_Arrangement();
            la.ArrangeColumns(NameArrayInt, FirstNamesArrayString, LastNamesArrayString);        
        }      
    }
}

