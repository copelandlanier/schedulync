using System;
using System.IO;
using LiteDB;
using System.Linq;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Calendar_NEW
{
    public partial class Dialog_FirstRun_Settings : Global_Access
    {
        protected Image PersonnelImage;
        protected Thread GetImageThread;
        protected bool validData;
        string PersonnelImagePath;
        string ThemeTransfer;
        string ImageTransfer;
        Image ThemeImage;
        int ErrorTrigger = 1;
        int FoundDuplicateName = 1;

        public Dialog_FirstRun_Settings()
        {
            InitializeComponent();
            
            /// Theme color buttons events
            color_orange.MouseDown += Color_orange_MouseDown;
            color_monolith.MouseDown += Color_monolith_MouseDown;
            color_blue.MouseDown += Color_blue_MouseDown;
            color_pink.MouseDown += Color_pink_MouseDown;
            color_aqua.MouseDown += Color_aqua_MouseDown;
            color_lavendar.MouseDown += Color_lavendar_MouseDown;
            color_yellow.MouseDown += Color_yellow_MouseDown;
            color_green.MouseDown += Color_green_MouseDown;
            color_grey.MouseDown += Color_grey_MouseDown;
            color_peach.MouseDown += Color_peach_MouseDown;

            /// Tool tips fpr color theme
            ToolTip ToolTipImp = new ToolTip();
            ToolTipImp.ShowAlways = true;
            ToolTipImp.SetToolTip(color_peach, "Peach");
            ToolTipImp.SetToolTip(color_orange, "Orange");
            ToolTipImp.SetToolTip(color_aqua, "Aqua");
            ToolTipImp.SetToolTip(color_blue, "Blue");
            ToolTipImp.SetToolTip(color_green, "Green");
            ToolTipImp.SetToolTip(color_grey, "Grey");
            ToolTipImp.SetToolTip(color_lavendar, "Lavendar");
            ToolTipImp.SetToolTip(color_monolith, "Monolith");
            ToolTipImp.SetToolTip(color_pink, "Pink");
            ToolTipImp.SetToolTip(color_yellow, "Yellow");

            /// Error handling for wrong characters entered into the Phone Number field
            maskedTextBox_Phone.MaskInputRejected += MaskedTextBox_Phone_MaskInputRejected;

            /// Events to reset textboxes upon Mouse Down
            textBoxSettings_FirstName.MouseDown += TextBoxSettings_FirstName_MouseDown;
            textBoxSettings_LastName.MouseDown += TextBoxSettings_LastName_MouseDown;
            textBoxSettings_JobTitle.MouseDown += TextBoxSettings_JobTitle_MouseDown;
            maskedTextBox_Email.MouseDown += MaskedTextBox_Email_MouseDown;
            maskedTextBox_Phone.MouseDown += MaskedTextBox_Phone_MouseDown;

            /// Events to track text being entered into the FIrst and Last Name fields
            textBoxSettings_FirstName.TextChanged += TextBoxSettings_FirstName_TextChanged;
            textBoxSettings_LastName.TextChanged += TextBoxSettings_LastName_TextChanged;

            /// Image Box IMplementation Events
            panelSettings_ImageBox.DragDrop += new DragEventHandler(panel_PersonnelImage_DragDrop);
            panelSettings_ImageBox.DragEnter += new DragEventHandler(panel_PersonnelImage_DragEnter);
            panelSettings_ImageBox.DoubleClick += panel_PersonnelImage_DoubleClick;
            panelSettings_ImageBox.DragLeave += panel_PersonnelImage_DragLeave;

            /// Textbox Keypress Events
            textBoxSettings_FirstName.KeyPress += TextBoxSettings_FirstName_KeyPress;
            textBoxSettings_LastName.KeyPress += TextBoxSettings_LastName_KeyPress;
            textBoxSettings_FirstName.Leave += TextBoxSettings_FirstName_Leave;
            textBoxSettings_LastName.Leave += TextBoxSettings_LastName_Leave;
            textBoxSettings_JobTitle.Leave += TextBoxSettings_JobTitle_Leave;
            maskedTextBox_Email.Leave += MaskedTextBox_Email_Leave;
            textBoxSettings_JobTitle.KeyPress += TextBoxSettings_JobTitle_KeyPress;

        }

        /// FORMATTING TEXTBOX ENTRIES
        private void MaskedTextBox_Email_Leave(object sender, EventArgs e)
        {
            if (maskedTextBox_Email.Text != string.Empty)
            {
                maskedTextBox_Email.Text = maskedTextBox_Email.Text.ToLower();
            }
        }

        private void TextBoxSettings_JobTitle_Leave(object sender, EventArgs e)
        {
            if (textBoxSettings_JobTitle.Text != string.Empty)
            {
                char UpperFirst = char.ToUpper(textBoxSettings_JobTitle.Text.FirstOrDefault());
                string JobTitle = UpperFirst + textBoxSettings_JobTitle.Text.Substring(1).ToLower();
                textBoxSettings_JobTitle.Text = JobTitle;
            }
        }        

        private void TextBoxSettings_FirstName_Leave(object sender, EventArgs e)
        {
            if (textBoxSettings_FirstName.Text != string.Empty)
            {
                char UpperFirst = char.ToUpper(textBoxSettings_FirstName.Text.FirstOrDefault());
                string FirstName = UpperFirst + textBoxSettings_FirstName.Text.Substring(1).ToLower();
                textBoxSettings_FirstName.Text = FirstName;
            }
        }

        private void TextBoxSettings_LastName_Leave(object sender, EventArgs e)
        {
            if (textBoxSettings_LastName.Text != string.Empty)
            {
                char UpperFirst = char.ToUpper(textBoxSettings_LastName.Text.FirstOrDefault());
                string LastName = UpperFirst + textBoxSettings_LastName.Text.Substring(1).ToLower();
                textBoxSettings_LastName.Text = LastName;
            }
        }
        
        private void TextBoxSettings_JobTitle_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 'A' || e.KeyChar > 'Z') && (e.KeyChar < 'a' || e.KeyChar > 'z') && (e.KeyChar != (char)Keys.Back))
                e.Handled = true;
        }

        private void TextBoxSettings_LastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 'A' || e.KeyChar > 'Z') && (e.KeyChar < 'a' || e.KeyChar > 'z') && (e.KeyChar != (char)Keys.Back))
                e.Handled = true;
        }

        private void TextBoxSettings_FirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 'A' || e.KeyChar > 'Z') && (e.KeyChar < 'a' || e.KeyChar > 'z') && (e.KeyChar != (char)Keys.Back))
                e.Handled = true;
        }

        #region Registered Name Implementation
        private void TextBoxSettings_LastName_TextChanged(object sender, EventArgs e)
        {
            RegisteredName();
        }

        private void TextBoxSettings_FirstName_TextChanged(object sender, EventArgs e)
        {
            RegisteredName();
        }

        private void RegisteredName()
        {
            SoftwareRegistration = label_Registered.Text = "This software is registered to: " + textBoxSettings_FirstName.Text + " " + textBoxSettings_LastName.Text;
        }
        #endregion

        #region Clear Text Boxes to default Backcolor
        private void MaskedTextBox_Phone_MouseDown(object sender, MouseEventArgs e)
        {
            ChangeTextboxBGToDefault();
        }

        private void MaskedTextBox_Email_MouseDown(object sender, MouseEventArgs e)
        {
            ChangeTextboxBGToDefault();
        }

        private void TextBoxSettings_JobTitle_MouseDown(object sender, MouseEventArgs e)
        {
            ChangeTextboxBGToDefault();
        }

        private void TextBoxSettings_LastName_MouseDown(object sender, MouseEventArgs e)
        {
            ChangeTextboxBGToDefault();
        }

        private void TextBoxSettings_FirstName_MouseDown(object sender, MouseEventArgs e)
        {
            ChangeTextboxBGToDefault();
        }

        private void ChangeTextboxBGToDefault()
        {
            textBoxSettings_FirstName.BackColor = Color.White;
            textBoxSettings_LastName.BackColor = Color.White;
            textBoxSettings_JobTitle.BackColor = Color.White;
            maskedTextBox_Email.BackColor = Color.White;
            maskedTextBox_Phone.BackColor = Color.White;
            panel_ColorError.BackColor = Color.White;
        }
        #endregion

        private void MaskedTextBox_Phone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            MonolithConsole("Masked textbox error: Too many characters or a wrong character.");
        }

        #region Color Block Mouse Down Events
        private void Color_peach_MouseDown(object sender, MouseEventArgs e)
        {
            ChangeTextboxBGToDefault();
            ColorTransfer = theme_peach;
            ApplyThemeColor();
        }

        private void Color_grey_MouseDown(object sender, MouseEventArgs e)
        {
            ChangeTextboxBGToDefault();
            ColorTransfer = theme_grey;
            ApplyThemeColor();
        }

        private void Color_green_MouseDown(object sender, MouseEventArgs e)
        {
            ChangeTextboxBGToDefault();
            ColorTransfer = theme_green;
            ApplyThemeColor();
        }

        private void Color_yellow_MouseDown(object sender, MouseEventArgs e)
        {
            ChangeTextboxBGToDefault();
            ColorTransfer = theme_yellow;
            ApplyThemeColor();
        }

        private void Color_lavendar_MouseDown(object sender, MouseEventArgs e)
        {
            ChangeTextboxBGToDefault();
            ColorTransfer = theme_lavendar;
            ApplyThemeColor();
        }

        private void Color_aqua_MouseDown(object sender, MouseEventArgs e)
        {
            ChangeTextboxBGToDefault();
            ColorTransfer = theme_aqua;
            ApplyThemeColor();
        }

        private void Color_pink_MouseDown(object sender, MouseEventArgs e)
        {
            ChangeTextboxBGToDefault();
            ColorTransfer = theme_pink;
            ApplyThemeColor();
        }

        private void Color_blue_MouseDown(object sender, MouseEventArgs e)
        {
            ChangeTextboxBGToDefault();
            ColorTransfer = theme_blue;
            ApplyThemeColor();
        }

        private void Color_monolith_MouseDown(object sender, MouseEventArgs e)
        {
            ChangeTextboxBGToDefault();
            ColorTransfer = theme_monolith;
            ApplyThemeColor();
        }

        private void Color_orange_MouseDown(object sender, MouseEventArgs e)
        {
            ChangeTextboxBGToDefault();
            ColorTransfer = theme_orange;
            ApplyThemeColor();
        }
        #endregion

        // Apply theme colors to program GUI
        public void ApplyThemeColor()
        {
            if (ColorTransfer == theme_orange)
            {
                ThemeTransfer = "ORANGE";
                ThemeImage = Properties.Resources.BG_Orange;
                display_Panel1.DayBackColor_1 = orange;
                Settings_Colorbar.BackColor = theme_orange;
                color_orange.BorderStyle = BorderStyle.Fixed3D;
                color_monolith.BorderStyle = BorderStyle.None;
                color_blue.BorderStyle = BorderStyle.None;
                color_pink.BorderStyle = BorderStyle.None;
                color_aqua.BorderStyle = BorderStyle.None;
                color_lavendar.BorderStyle = BorderStyle.None;
                color_yellow.BorderStyle = BorderStyle.None;
                color_green.BorderStyle = BorderStyle.None;
                color_grey.BorderStyle = BorderStyle.None;
                color_peach.BorderStyle = BorderStyle.None;
            }

            else if (ColorTransfer == theme_monolith)
            {
                ThemeTransfer = "MONOLITH";
                ThemeImage = Properties.Resources.BG_Monolith;
                display_Panel1.DayBackColor_1 = monolith;
                Settings_Colorbar.BackColor = theme_monolith;
                color_orange.BorderStyle = BorderStyle.None;
                color_monolith.BorderStyle = BorderStyle.Fixed3D;
                color_blue.BorderStyle = BorderStyle.None;
                color_pink.BorderStyle = BorderStyle.None;
                color_aqua.BorderStyle = BorderStyle.None;
                color_lavendar.BorderStyle = BorderStyle.None;
                color_yellow.BorderStyle = BorderStyle.None;
                color_green.BorderStyle = BorderStyle.None;
                color_grey.BorderStyle = BorderStyle.None;
                color_peach.BorderStyle = BorderStyle.None;
            }

            else if (ColorTransfer == theme_blue)
            {
                ThemeTransfer = "BLUE";
                ThemeImage = Properties.Resources.BG_Blue;
                display_Panel1.DayBackColor_1 = blue;
                Settings_Colorbar.BackColor = theme_blue;
                color_orange.BorderStyle = BorderStyle.None;
                color_monolith.BorderStyle = BorderStyle.None;
                color_blue.BorderStyle = BorderStyle.Fixed3D;
                color_pink.BorderStyle = BorderStyle.None;
                color_aqua.BorderStyle = BorderStyle.None;
                color_lavendar.BorderStyle = BorderStyle.None;
                color_yellow.BorderStyle = BorderStyle.None;
                color_green.BorderStyle = BorderStyle.None;
                color_grey.BorderStyle = BorderStyle.None;
                color_peach.BorderStyle = BorderStyle.None;
            }

            else if (ColorTransfer == theme_pink)
            {
                ThemeTransfer = "PINK";
                ThemeImage = Properties.Resources.BG_Pink;
                display_Panel1.DayBackColor_1 = pink;
                Settings_Colorbar.BackColor = theme_pink;
                color_orange.BorderStyle = BorderStyle.None;
                color_monolith.BorderStyle = BorderStyle.None;
                color_blue.BorderStyle = BorderStyle.None;
                color_pink.BorderStyle = BorderStyle.Fixed3D;
                color_aqua.BorderStyle = BorderStyle.None;
                color_lavendar.BorderStyle = BorderStyle.None;
                color_yellow.BorderStyle = BorderStyle.None;
                color_green.BorderStyle = BorderStyle.None;
                color_grey.BorderStyle = BorderStyle.None;
                color_peach.BorderStyle = BorderStyle.None;
            }

            else if (ColorTransfer == theme_aqua)
            {
                ThemeTransfer = "AQUA";
                ThemeImage = Properties.Resources.BG_Aqua;
                display_Panel1.DayBackColor_1 = aqua;
                Settings_Colorbar.BackColor = theme_aqua;
                color_orange.BorderStyle = BorderStyle.None;
                color_monolith.BorderStyle = BorderStyle.None;
                color_blue.BorderStyle = BorderStyle.None;
                color_pink.BorderStyle = BorderStyle.None;
                color_aqua.BorderStyle = BorderStyle.Fixed3D;
                color_lavendar.BorderStyle = BorderStyle.None;
                color_yellow.BorderStyle = BorderStyle.None;
                color_green.BorderStyle = BorderStyle.None;
                color_grey.BorderStyle = BorderStyle.None;
                color_peach.BorderStyle = BorderStyle.None;
            }

            else if (ColorTransfer == theme_lavendar)
            {
                ThemeTransfer = "LAVENDAR";
                ThemeImage = Properties.Resources.BG_Lavendar;
                display_Panel1.DayBackColor_1 = lavendar;
                Settings_Colorbar.BackColor = theme_lavendar;
                color_orange.BorderStyle = BorderStyle.None;
                color_monolith.BorderStyle = BorderStyle.None;
                color_blue.BorderStyle = BorderStyle.None;
                color_pink.BorderStyle = BorderStyle.None;
                color_aqua.BorderStyle = BorderStyle.None;
                color_lavendar.BorderStyle = BorderStyle.Fixed3D;
                color_yellow.BorderStyle = BorderStyle.None;
                color_green.BorderStyle = BorderStyle.None;
                color_grey.BorderStyle = BorderStyle.None;
                color_peach.BorderStyle = BorderStyle.None;
            }

            else if (ColorTransfer == theme_yellow)
            {
                ThemeTransfer = "YELLOW";
                ThemeImage = Properties.Resources.BG_Yellow;
                display_Panel1.DayBackColor_1 = yellow;
                Settings_Colorbar.BackColor = theme_yellow;
                color_orange.BorderStyle = BorderStyle.None;
                color_monolith.BorderStyle = BorderStyle.None;
                color_blue.BorderStyle = BorderStyle.None;
                color_pink.BorderStyle = BorderStyle.None;
                color_aqua.BorderStyle = BorderStyle.None;
                color_lavendar.BorderStyle = BorderStyle.None;
                color_yellow.BorderStyle = BorderStyle.Fixed3D;
                color_green.BorderStyle = BorderStyle.None;
                color_grey.BorderStyle = BorderStyle.None;
                color_peach.BorderStyle = BorderStyle.None;
            }

            else if (ColorTransfer == theme_green)
            {
                ThemeTransfer = "GREEN";
                ThemeImage = Properties.Resources.BG_Green;
                display_Panel1.DayBackColor_1 = green;
                Settings_Colorbar.BackColor = theme_green;
                color_orange.BorderStyle = BorderStyle.None;
                color_monolith.BorderStyle = BorderStyle.None;
                color_blue.BorderStyle = BorderStyle.None;
                color_pink.BorderStyle = BorderStyle.None;
                color_aqua.BorderStyle = BorderStyle.None;
                color_lavendar.BorderStyle = BorderStyle.None;
                color_yellow.BorderStyle = BorderStyle.None;
                color_green.BorderStyle = BorderStyle.Fixed3D;
                color_grey.BorderStyle = BorderStyle.None;
                color_peach.BorderStyle = BorderStyle.None;
            }

            else if (ColorTransfer == theme_grey)
            {
                ThemeTransfer = "GREY";
                ThemeImage = Properties.Resources.BG_Grey;
                display_Panel1.DayBackColor_1 = grey;
                Settings_Colorbar.BackColor = theme_grey;
                color_orange.BorderStyle = BorderStyle.None;
                color_monolith.BorderStyle = BorderStyle.None;
                color_blue.BorderStyle = BorderStyle.None;
                color_pink.BorderStyle = BorderStyle.None;
                color_aqua.BorderStyle = BorderStyle.None;
                color_lavendar.BorderStyle = BorderStyle.None;
                color_yellow.BorderStyle = BorderStyle.None;
                color_green.BorderStyle = BorderStyle.None;
                color_grey.BorderStyle = BorderStyle.Fixed3D;
                color_peach.BorderStyle = BorderStyle.None;
            }

            else if (ColorTransfer == theme_peach)
            {
                ThemeTransfer = "PEACH";
                ThemeImage = Properties.Resources.BG_Peach;
                display_Panel1.DayBackColor_1 = peach;
                Settings_Colorbar.BackColor = theme_peach;
                color_orange.BorderStyle = BorderStyle.None;
                color_monolith.BorderStyle = BorderStyle.None;
                color_blue.BorderStyle = BorderStyle.None;
                color_pink.BorderStyle = BorderStyle.None;
                color_aqua.BorderStyle = BorderStyle.None;
                color_lavendar.BorderStyle = BorderStyle.None;
                color_yellow.BorderStyle = BorderStyle.None;
                color_green.BorderStyle = BorderStyle.None;
                color_grey.BorderStyle = BorderStyle.None;
                color_peach.BorderStyle = BorderStyle.Fixed3D;
            }

            // UPdate display_panel1
            Invoke(new Action(() =>
            {
                display_Panel1.button_DayControlSettings.FlatAppearance.BorderColor = ColorTransfer;
                display_Panel1.Button_DayControl_PrevMonth.BackColor = ColorTransfer;
                display_Panel1.Button_DayControl_NextMonth.BackColor = ColorTransfer;
                display_Panel1.Button_DayControl_PrevDay.BackColor = ColorTransfer;
                display_Panel1.Button_DayControl_NextDay.BackColor = ColorTransfer;
                display_Panel1.Button_DayControl_Today.BackColor = ColorTransfer;
                display_Panel1.button_DayControlSettings.BackColor = ColorTransfer;
                display_Panel1.panel_ColorBar.BackColor = ColorTransfer;
            }
            ));

            dialog_internalsettings.ApplyThemeColor(ThemeTransfer);
        }

        // Check to see if the email entered is valid.
        bool IsValidEmail(string email)
        {
            string us = ".us";
            string com = ".com";
            string net = ".net";
            string org = ".org";
            string edu = ".edu";
            string info = ".info";
            string at = "@";

            try
            {
                if ((email.Contains(com) || email.Contains(net) || email.Contains(org) || email.Contains(edu) || email.Contains(us) || email.Contains(info)) && email.Contains(at))
                {
                    var mail = new System.Net.Mail.MailAddress(email);
                    return true;
                }
                else
                {
                    return false;
                }
            }

            catch
            {
                return false;
            }
        }

        private void SettingsButton_Next_Click(object sender, EventArgs e)
        {
            // Perform error check on form.
            ErrorFormCheck();

            // If duplicate is found FoundDuplicateTrigger = 1.
            int FoundDuplicateTrigger = 0;
            
            if (ErrorTrigger == 0)
            {
                MonolithConsole("Trigger is 0");
                string SAVE_INTERNAL = AppDomain.CurrentDomain.BaseDirectory + "database_internal.db";

                // Check if there are duplicate names in the external database connected.
                using (var db = new LiteDatabase(SAVE_INTERNAL))
                {
                    var EmployeeCollection = db.GetCollectionNames();
                    dialog_duplicate.listBox_Duplicate.Items.Clear();

                    for (int x = 0; x < EmployeeCollection.Count(); x++)
                    {
                        if (EmployeeCollection.ElementAt(x) == textBoxSettings_FirstName.Text + "_" + textBoxSettings_LastName.Text)
                        {                            
                            FoundDuplicateTrigger = 1;
                            dialog_duplicate.listBox_Duplicate.Items.Add(EmployeeCollection.ElementAt(x));
                            this.Hide();
                            dialog_duplicate.DuplicateButton_Next.Enabled = false;
                            dialog_duplicate.Show();
                            break;
                        }                        
                    }

                    // Trigger if duplicate record not found.
                    if(FoundDuplicateTrigger == 0)
                    {
                        FoundDuplicateName = 0;
                    }
                }
            }

            // Set default background image if no avatar was selected.
            if (FoundDuplicateName == 0)
            {
                if (panelSettings_ImageBox.BackgroundImage == null)
                {
                    PersonnelImage = Properties.Resources.avatar_image_sm;
                    imgResize();
                }               

                // Write to DATABASE Globals
                DATABASE_EXTERNAL = dialog_database.selected_DATABASE_Path;
                DATABASE_NAME = dialog_database.entered_DATABASE_Name;
                FIRST_NAME = textBoxSettings_FirstName.Text;
                LAST_NAME = textBoxSettings_LastName.Text;
                JOB_TITLE = textBoxSettings_JobTitle.Text;
                COMPUTER_USERNAME = Environment.UserName;
                EMAIL = maskedTextBox_Email.Text;
                PHONE = maskedTextBox_Phone.Text;
                AVATAR_LOCAL = ImageTransfer;
                AVATAR_DB = @"images/" + FIRST_NAME + "_" + LAST_NAME + "/" + FIRST_NAME + "_" + LAST_NAME + ".avt";
                THEME = ThemeTransfer;
                display_Panel1.ExpandBGImage1 = ThemeImage;
                display_Panel1.pib_1.panel_PersonnelImage.BackgroundImage = new Bitmap(ImageAvatar, 80, 80);
                display_Panel1.Panel_DayControlHolder.Controls.Add(display_Panel1.day_Control_1);
                display_Panel1.pib_1.label_PImageName.Text = FIRST_NAME + " " + LAST_NAME;
                FIRSTRUN_SWITCH = true;

                // Relay Globals to other forms
                dialog_internalsettings.textBoxSettings_FirstName.Text = FIRST_NAME;
                dialog_internalsettings.textBoxSettings_LastName.Text = LAST_NAME;
                dialog_internalsettings.maskedTextBox_Email.Text = EMAIL;
                dialog_internalsettings.maskedTextBox_Phone.Text = PHONE;
                dialog_internalsettings.textBoxSettings_JobTitle.Text = JOB_TITLE;
                dialog_internalsettings.panelSettings_ImageBox.BackgroundImage = new Bitmap(ImageAvatar, dialog_internalsettings.panelSettings_ImageBox.Width, dialog_internalsettings.panelSettings_ImageBox.Height);
                // 

                // Add file watchers
                fileSystemWatcher_WebUpload.Path = AppDomain.CurrentDomain.BaseDirectory + "Web_Upload";
                fileSystemWatcher_Config.Path = AppDomain.CurrentDomain.BaseDirectory + "Calendar_Configuration";
                fileSystemWatcher_RemoteDB.Path = DATABASE_EXTERNAL;
                fileSystemWatcher_Config.EnableRaisingEvents = true;
                fileSystemWatcher_RemoteDB.EnableRaisingEvents = true;
                fileSystemWatcher_WebUpload.EnableRaisingEvents = true;
                backgroundWorker_Listener.WorkerReportsProgress = true;
                backgroundWorker_Listener.WorkerSupportsCancellation = true;

                // Write to generic configuration file
                using (StreamWriter SW_Config = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + "Calendar_Configuration/configuration"))
                {
                    SW_Config.WriteLine("Normal");
                    SW_Config.WriteLine(FIRSTRUN_SWITCH);
                    SW_Config.WriteLine("*** COMPUTER INFORMATION");
                    SW_Config.WriteLine(Environment.MachineName);
                    SW_Config.WriteLine(Environment.OSVersion);
                    SW_Config.WriteLine(Environment.UserDomainName);
                    SW_Config.WriteLine(COMPUTER_USERNAME);
                    SW_Config.WriteLine("*** ID INFORMATION");
                    SW_Config.WriteLine(FIRST_NAME);
                    SW_Config.WriteLine(LAST_NAME);
                    SW_Config.WriteLine(EMAIL);
                    SW_Config.WriteLine(PHONE);
                    SW_Config.WriteLine(JOB_TITLE);
                    SW_Config.WriteLine(THEME);
                    SW_Config.WriteLine(AVATAR_DB);
                    SW_Config.WriteLine("*** DATABASE INFORMATION");
                    SW_Config.WriteLine(AVATAR_LOCAL);
                    SW_Config.WriteLine(DATABASE_NAME);
                    SW_Config.WriteLine(DATABASE_EXTERNAL);
                    SW_Config.WriteLine("*** FTP INFORMATION");
                    SW_Config.WriteLine(dialog_ftpsettings.FTP_Host);
                    SW_Config.WriteLine(dialog_ftpsettings.FTP_User);
                    SW_Config.WriteLine(dialog_ftpsettings.FTP_Password);
                    SW_Config.WriteLine(dialog_ftpsettings.FTP_Port);
                    SW_Config.WriteLine(dialog_ftpsettings.FTP_Passive);
                    SW_Config.WriteLine(dialog_ftpsettings.FTP_Folder);
                }

                // Write to Web Data (.web) file
                using (StreamWriter SW_WebUpload = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + "Web_Upload/" + FIRST_NAME + "_" + LAST_NAME + ".web"))
                {
                    SW_WebUpload.WriteLine("Normal");
                    SW_WebUpload.WriteLine("***ID INFORMATION");
                    SW_WebUpload.WriteLine(FIRST_NAME);
                    SW_WebUpload.WriteLine(LAST_NAME);
                    SW_WebUpload.WriteLine(JOB_TITLE);
                    SW_WebUpload.WriteLine(THEME);
                }

                DATABASE_OPERATIONS DATABASE_WRITE = new DATABASE_OPERATIONS();
                DATABASE_WRITE.CREATE_DATABASE_LOCAL();
                                
                using (StreamWriter SW_TempX = new StreamWriter(DATABASE_EXTERNAL + "temp.x", true))
                {
                    SW_TempX.WriteLine(FIRST_NAME + " " + LAST_NAME);
                    SW_TempX.Close();
                }

                this.Hide();
            }
        }

        // Check to see if form is filled out correctly.
        private void ErrorFormCheck()
        {
            int ErrorResults = 0;
            bool EmailCheck;
            EmailCheck = IsValidEmail(maskedTextBox_Email.Text);
            
            if (textBoxSettings_FirstName.Text == "" || textBoxSettings_LastName.Text == "" || textBoxSettings_JobTitle.Text == "" || EmailCheck == false || maskedTextBox_Phone.MaskCompleted == false || ColorTransfer == Color.Empty)
            {
                if (textBoxSettings_FirstName.Text == "")
                {
                    textBoxSettings_FirstName.BackColor = ErrorColor;
                    ErrorResults = ErrorResults + 1;
                }

                if (textBoxSettings_LastName.Text == "")
                {
                    textBoxSettings_LastName.BackColor = ErrorColor;
                    ErrorResults = ErrorResults + 1;
                }

                if (textBoxSettings_JobTitle.Text == "")
                {
                    textBoxSettings_JobTitle.BackColor = ErrorColor;
                    ErrorResults = ErrorResults + 1;
                }

                if (EmailCheck == false)
                {
                    maskedTextBox_Email.BackColor = ErrorColor;
                    ErrorResults = ErrorResults + 1;
                }

                if (maskedTextBox_Phone.MaskCompleted == false)
                {
                    maskedTextBox_Phone.BackColor = ErrorColor;
                    ErrorResults = ErrorResults + 1;
                }

                if (ColorTransfer == Color.Empty)
                {
                    panel_ColorError.BackColor = ErrorColor;
                    ErrorResults = ErrorResults + 1;
                }
            }

            // If there are no errors, then ErrorTrigger will be 0.
            if (ErrorResults == 0)
            {
                ErrorTrigger = 0;
            }
        }

        // Link button to DoubleClick event to load image.
        private void SettingsButton_Image_Click(object sender, EventArgs e)
        {
            panel_PersonnelImage_DoubleClick(sender, e);
        }

        #region Image Box Implementation

        /// Image Box Implementation
        private void panel_PersonnelImage_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (openFile_PersonnelImage.ShowDialog() == DialogResult.OK)
                {
                    PersonnelImage = (Bitmap)Image.FromFile(openFile_PersonnelImage.FileName, true);
                    if (PersonnelImage.Width < 401 && PersonnelImage.Height < 401)
                    {
                        ImageTransfer = openFile_PersonnelImage.FileName;
                        imgResize();
                    }
                    else
                    {
                        MessageBox.Show("Please select an image no larger than 400 x 400");
                    }
                }
            }

            catch
            {
                MessageBox.Show("Selection is not an image file. Please select an image file");
                panelSettings_ImageBox.BackgroundImage = null;
            }
        }

        private void panel_PersonnelImage_DragDrop(object sender, DragEventArgs e)
        {
            if (validData)
            {
                while (GetImageThread.IsAlive)
                {
                    Application.DoEvents();
                    Thread.Sleep(0);
                }
                PersonnelImage = (Bitmap)Image.FromFile(openFile_PersonnelImage.FileName, true);
                ImageTransfer = openFile_PersonnelImage.FileName;
                imgResize();
            }
        }

        private void panel_PersonnelImage_DragLeave(object sender, EventArgs e)
        {
            panelSettings_ImageBox.BackgroundImage = null;
        }

        private void panel_PersonnelImage_DragEnter(object sender, DragEventArgs e)
        {
            string filename;
            validData = GetFilename(out filename, e);
            if (validData)
            {
                PersonnelImagePath = filename;
                GetImageThread = new Thread(new ThreadStart(LoadImage));
                GetImageThread.Start();
                e.Effect = DragDropEffects.Copy;
            }

            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private bool GetFilename(out string filename, DragEventArgs e)
        {
            bool ret = false;
            filename = String.Empty;
            if ((e.AllowedEffect & DragDropEffects.Copy) == DragDropEffects.Copy)
            {
                Array data = ((IDataObject)e.Data).GetData("FileDrop") as Array;
                if (data != null)
                {
                    if ((data.Length == 1) && (data.GetValue(0) is String))
                    {
                        filename = ((string[])data)[0];
                        string ext = System.IO.Path.GetExtension(filename).ToLower();
                        if ((ext == ".jpg") || (ext == ".png") || (ext == ".bmp"))
                        {
                            ret = true;
                        }
                    }
                }
            }
            return ret;
        }

        protected void LoadImage()
        {
            PersonnelImage = new Bitmap(PersonnelImagePath);
        }

        public void imgResize()
        {
            try
            {
                Image imageIn = PersonnelImage;
                var postCrop = resizeImage(PersonnelImage, new Size(panelSettings_ImageBox.Width, panelSettings_ImageBox.Height));
                panelSettings_ImageBox.BackgroundImage = postCrop;
                ImageAvatar = postCrop;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static Image resizeImage(Image imgToResize, Size size)
        {
            return (Image)(new Bitmap(imgToResize, size));
        }
        #endregion

        private void SettingsButton_Back_Click(object sender, EventArgs e)
        {
            dialog_database.Show();
            this.Hide();
        }
    }
}
