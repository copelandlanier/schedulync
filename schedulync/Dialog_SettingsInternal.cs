using System;
using System.Collections.Generic;
using System.ComponentModel;
using LiteDB;
using System.IO;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
using System.Reflection;

namespace Calendar_NEW
{
    public partial class Dialog_SettingsInternal : Global_Access
    {
        protected Image PersonnelImage;
        protected Thread GetImageThread;
        protected bool validData;
        string PersonnelImagePath;
        string ImageTransfer;
        string ThemeTransfer;
        int ErrorTrigger = 1;
        int FoundDuplicateName = 1;

        // Settings for Database Connection

        public Dialog_SettingsInternal()
        {
            InitializeComponent();

            //
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
            System.Windows.Forms.ToolTip ToolTipImp = new System.Windows.Forms.ToolTip();
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
            
            listBox_SettingUsers.SelectionMode = SelectionMode.One;

            panel_CreateDatabase.Hide();
            panel_ExistingDatabase.Hide();
            panel_DatabaseLocation.Hide();
            textBox_DatabaseLocation.Enabled = false;
            button_DatabaseOpen.Location = new Point(384, 32);
            panel_ButtonSelection.Location = new Point(54, 30);
            panel_ExistingDatabase.Location = new Point(40, 62);
            panel_CreateDatabase.Location = new Point(40, 62);
            panel_DatabaseLocation.Location = new Point(40, 130);
            panel_SelectDatabaseNote.Location = new Point(54, 60);
            panel_DatabaseSelectedLocation.Location = new Point(54, 134);
            radio_NewDB.CheckedChanged += Radio_NewDB_CheckedChanged;
            textBox_CreateDBName.MouseDown += TextBox_CreateDBName_MouseDown;
            radio_SelectedDB.CheckedChanged += Radio_SelectedDB_CheckedChanged;
            radio_ExistingDB.CheckedChanged += Radio_ExistingDB_CheckedChanged;
            textBox_DatabaseLocation.MouseDown += TextBox_DatabaseLocation_MouseDown;
            tabControl_Settings.SelectedIndexChanged += TabControl_Settings_SelectedIndexChanged;
            Console.WriteLine("Initialixed");
    }

        private void TabControl_Settings_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(SettingsInternal_OK.Enabled == false)
            {
                tabControl_Settings.SelectedIndex = 1;
                MessageBox.Show("Please connect to a database before continuing...");
            }
        }

        // DATABASE FUNCTIONS
        private void TextBox_CreateDBName_MouseDown(object sender, MouseEventArgs e)
        {
            ChangeTextboxBGToDefault();
        }

        private void TextBox_DatabaseLocation_MouseDown(object sender, MouseEventArgs e)
        {
            ChangeTextboxBGToDefault();
        }

        private void Radio_SelectedDB_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_SelectedDB.Checked == true)
            {
                SelectedDatabase();
            }
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
        }

        public void SelectedDatabase()
        {
            panel_CreateDatabase.Hide();
            panel_ExistingDatabase.Hide();
            panel_DatabaseLocation.Hide();
            panel_SelectDatabaseNote.Hide();
            button_DatabaseOpen.Hide();
            button_DatabaseBrowse.Hide();
            panel_SelectDatabaseNote.Show();
            panel_DatabaseSelectedLocation.Show();
            SettingsInternal_OK.Enabled = true;
            tabControl_Settings.Enabled = true;
        }

        public void NewDatabase()
        {
            textBox_DatabaseLocation.Text = "";
            textBox_CreateDBName.Text = "";
            panel_CreateDatabase.Show();
            panel_ExistingDatabase.Hide();
            panel_DatabaseLocation.Show();
            panel_SelectDatabaseNote.Hide();
            button_DatabaseOpen.Hide();
            button_DatabaseBrowse.Show();
            panel_DatabaseSelectedLocation.Hide();
            DBConnected_LED.BackColor = Color.DarkRed;
            label_DBConnectedStatus.Text = "Database Status: DISCONNECTED";
            ChangeTextboxBGToDefault();
            SettingsInternal_OK.Enabled = false;
        }

        public void ExistingDatabase()
        {
            textBox_DatabaseLocation.Text = "";
            panel_CreateDatabase.Hide();
            panel_ExistingDatabase.Show();
            panel_DatabaseLocation.Show();
            panel_SelectDatabaseNote.Hide();
            button_DatabaseOpen.Show();
            button_DatabaseBrowse.Hide();
            panel_DatabaseSelectedLocation.Hide();
            textBox_CreateDBName.Enabled = true;
            button_DatabaseBrowse.Enabled = true;
            DBConnected_LED.BackColor = Color.DarkRed;
            label_DBConnectedStatus.Text = "Database Status: DISCONNECTED";
            ChangeTextboxBGToDefault();
            SettingsInternal_OK.Enabled = false;
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
            SoftwareRegistration = label_InternalSettings_Registered.Text = textBoxSettings_FirstName.Text + " " + textBoxSettings_LastName.Text;
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
            ApplyThemeColor("PEACH");
        }

        private void Color_grey_MouseDown(object sender, MouseEventArgs e)
        {
            ChangeTextboxBGToDefault();
            ColorTransfer = theme_grey;
            ApplyThemeColor("GREY");
        }

        private void Color_green_MouseDown(object sender, MouseEventArgs e)
        {
            ChangeTextboxBGToDefault();
            ColorTransfer = theme_green;
            ApplyThemeColor("GREEN");
        }

        private void Color_yellow_MouseDown(object sender, MouseEventArgs e)
        {
            ChangeTextboxBGToDefault();
            ColorTransfer = theme_yellow;
            ApplyThemeColor("YELLOW");
        }

        private void Color_lavendar_MouseDown(object sender, MouseEventArgs e)
        {
            ChangeTextboxBGToDefault();
            ColorTransfer = theme_lavendar;
            ApplyThemeColor("LAVENDAR");
        }

        private void Color_aqua_MouseDown(object sender, MouseEventArgs e)
        {
            ChangeTextboxBGToDefault();
            ColorTransfer = theme_aqua;
            ApplyThemeColor("AQUA");
        }

        private void Color_pink_MouseDown(object sender, MouseEventArgs e)
        {
            ChangeTextboxBGToDefault();
            ColorTransfer = theme_pink;
            ApplyThemeColor("PINK");
        }

        private void Color_blue_MouseDown(object sender, MouseEventArgs e)
        {
            ChangeTextboxBGToDefault();
            ColorTransfer = theme_blue;
            ApplyThemeColor("BLUE");
        }

        private void Color_monolith_MouseDown(object sender, MouseEventArgs e)
        {
            ChangeTextboxBGToDefault();
            ColorTransfer = theme_monolith;
            ApplyThemeColor("MONOLITH");
        }

        private void Color_orange_MouseDown(object sender, MouseEventArgs e)
        {
            ChangeTextboxBGToDefault();
            ColorTransfer = theme_orange;
            ApplyThemeColor("ORANGE");
        }
        #endregion

        private void Dialog_SettingsInternal_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        // Check to see if form is filled out correctly.
        private void ErrorFormCheck()
        {
            int ErorrResults = 0;
            bool EmailCheck;
            EmailCheck = IsValidEmail(maskedTextBox_Email.Text);

            if (textBoxSettings_FirstName.Text == "" || textBoxSettings_LastName.Text == "" || textBoxSettings_JobTitle.Text == "" || EmailCheck == false || maskedTextBox_Phone.MaskCompleted == false || ColorTransfer == Color.Empty)
            {
                if (textBoxSettings_FirstName.Text == "")
                {
                    textBoxSettings_FirstName.BackColor = ErrorColor;
                    ErorrResults = ErorrResults + 1;
                }

                if (textBoxSettings_LastName.Text == "")
                {
                    textBoxSettings_LastName.BackColor = ErrorColor;
                    ErorrResults = ErorrResults + 1;
                }

                if (textBoxSettings_JobTitle.Text == "")
                {
                    textBoxSettings_JobTitle.BackColor = ErrorColor;
                    ErorrResults = ErorrResults + 1;
                }

                if (EmailCheck == false)
                {
                    maskedTextBox_Email.BackColor = ErrorColor;
                    ErorrResults = ErorrResults + 1;
                }

                if (maskedTextBox_Phone.MaskCompleted == false)
                {
                    maskedTextBox_Phone.BackColor = ErrorColor;
                    ErorrResults = ErorrResults + 1;
                }

                if (ColorTransfer == Color.Empty)
                {
                    panel_ColorError.BackColor = ErrorColor;
                    ErorrResults = ErorrResults + 1;
                }
            }

            // If there are no errors, then ErrorTrigger will be 0.
            if (ErorrResults == 0)
            {
                ErrorTrigger = 0;
            }
        }

        // Is this a valid email
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

        // Add conditional if item is selected- then mesage box.
        private void button_Settings_RemoveUsers_Click(object sender, EventArgs e)
        {
            string EXTERNAL_DATABASE;
            string INTERNAL_CONFIG = AppDomain.CurrentDomain.BaseDirectory + "Calendar_Configuration/configuration";
            string SelectedName = listBox_SettingUsers.SelectedItem.ToString();
            string[] LinesInternal = File.ReadAllLines(AppDomain.CurrentDomain.BaseDirectory + "Calendar_Configuration/" + SelectedName + ".cfg");
            string FirstName = LinesInternal[8];
            string LastName = LinesInternal[9];
            RemoveControl(FirstName, LastName);

            MonolithConsole(SelectedName);
            if (MessageBox.Show("Would you like to remove the selected user(s)? Note: ALL database information will be permanently deleted if user(s) is removed.", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string[] lines = File.ReadAllLines(INTERNAL_CONFIG);

                EXTERNAL_DATABASE = lines[18] + lines[17] + ".db";
                RemoveMatchingUser(FirstName, LastName);

                /*using (var db = new LiteDatabase(EXTERNAL_DATABASE))
                {
                    File.Delete(AppDomain.CurrentDomain.BaseDirectory + "Calendar_Configuration/" + SelectedName + ".cfg");

                    db.DropCollection(SelectedName);

                    Form.ActiveForm.Refresh();

                    var EmployeeCollection = db.GetCollectionNames();

                    PersonnelList.Clear();
                    for (int x = 3; x < EmployeeCollection.Count(); x++)
                    {
                        PersonnelList.Add(EmployeeCollection.ElementAtOrDefault(x));
                    }

                    listBox_SettingUsers.Refresh();
                    for (int x = 0; x < PersonnelList.Count(); x++)
                    {
                        dialog_internalsettings.listBox_SettingUsers.Items.Add(PersonnelList[x]);
                        MonolithConsole(PersonnelList[x]);
                    }
                }*/
            }
            Config_Load cgLoad = new Config_Load();
            display_Panel1.pib_1.Visible = false;
            display_Panel1.pib_2.Visible = false;
            display_Panel1.pib_3.Visible = false;
            display_Panel1.pib_4.Visible = false;
            display_Panel1.pib_5.Visible = false;
            display_Panel1.pib_6.Visible = false;
            display_Panel1.pib_7.Visible = false;
            display_Panel1.pib_8.Visible = false;
            display_Panel1.pib_9.Visible = false;
            display_Panel1.pib_10.Visible = false;
            display_Panel1.day_Control_1.Dispose();
            display_Panel1.day_Control_2.Dispose();
            display_Panel1.day_Control_3.Dispose();
            display_Panel1.day_Control_4.Dispose();
            display_Panel1.day_Control_5.Dispose();
            display_Panel1.day_Control_6.Dispose();
            display_Panel1.day_Control_7.Dispose();
            display_Panel1.day_Control_8.Dispose();
            display_Panel1.day_Control_9.Dispose();
            display_Panel1.day_Control_10.Dispose();
            cgLoad.ADDRemoteUsers();
        }

        private void RemoveControl(string FirstName, string LastName)
        {
            if (display_Panel1.pib_1.label_PImageName.Text == FirstName + " " + LastName)
            {
                display_Panel1.pib_1.Visible = false;
                display_Panel1.day_Control_1.Visible = false;
            }

            else if (display_Panel1.pib_2.label_PImageName.Text == FirstName + " " + LastName)
            {
                display_Panel1.pib_2.Visible = false;
                display_Panel1.day_Control_2.Visible = false;
            }

            else if (display_Panel1.pib_3.label_PImageName.Text == FirstName + " " + LastName)
            {
                display_Panel1.pib_3.Visible = false;
                display_Panel1.day_Control_3.Visible = false;
            }

            else if (display_Panel1.pib_4.label_PImageName.Text == FirstName + " " + LastName)
            {
                display_Panel1.pib_4.Visible = false;
                display_Panel1.day_Control_4.Visible = false;
            }

            else if (display_Panel1.pib_5.label_PImageName.Text == FirstName + " " + LastName)
            {
                display_Panel1.pib_5.Visible = false;
                display_Panel1.day_Control_5.Visible = false;
            }

            else if (display_Panel1.pib_6.label_PImageName.Text == FirstName + " " + LastName)
            {
                display_Panel1.pib_6.Visible = false;
                display_Panel1.day_Control_6.Visible = false;
            }

            else if (display_Panel1.pib_7.label_PImageName.Text == FirstName + " " + LastName)
            {
                display_Panel1.pib_7.Visible = false;
                display_Panel1.day_Control_7.Visible = false;
            }

            else if (display_Panel1.pib_8.label_PImageName.Text == FirstName + " " + LastName)
            {
                display_Panel1.pib_8.Visible = false;
                display_Panel1.day_Control_8.Visible = false;
            }

            else if (display_Panel1.pib_9.label_PImageName.Text == FirstName + " " + LastName)
            {
                display_Panel1.pib_9.Visible = false;
                display_Panel1.day_Control_9.Visible = false;
            }

            else if (display_Panel1.pib_10.label_PImageName.Text == FirstName + " " + LastName)
            {
                display_Panel1.pib_10.Visible = false;
                display_Panel1.day_Control_10.Visible = false;
            }
        }

        private void RemoveMatchingUser(string FirstName, string LastName)
        {
            int i = 0;
            if (display_Panel1.pib_1.label_PImageName.Text == FirstName + " " + LastName)
            {
                PersonnelImageBox pib = (PersonnelImageBox)this.Controls.Find("pib_" + i, false).FirstOrDefault();
                string threeValue = pib.label_PImageName.Text.ToLower();
            }
        }

        private void Button_ShowConsole_Click(object sender, EventArgs e)
        {
            dialog_console.TopMost = true;
            dialog_console.Show();
        }

        private void SettingsInternal_Cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        public void ApplyThemeColor(string ColorInput)
        {
            Console.WriteLine("DIALOG COLOR");
            if (ColorInput == "ORANGE")
            {
                display_Panel1.ExpandBGImage1 = Properties.Resources.BG_Orange;
                display_Panel1.DayBackColor_1 = orange;
                ColorTransfer = theme_orange;
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
                ThemeTransfer = "ORANGE";
            }

            else if (ColorInput == "MONOLITH")
            {
                display_Panel1.ExpandBGImage1 = Properties.Resources.BG_Monolith;
                display_Panel1.DayBackColor_1 = monolith;
                ColorTransfer = theme_monolith;
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
                ThemeTransfer = "MONOLITH";
            }

            else if (ColorInput == "BLUE")
            {
                display_Panel1.ExpandBGImage1 = Properties.Resources.BG_Blue;
                display_Panel1.DayBackColor_1 = blue;
                ColorTransfer = theme_blue;
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
                ThemeTransfer = "BLUE";
            }

            else if (ColorInput == "PINK")
            {
                display_Panel1.ExpandBGImage1 = Properties.Resources.BG_Pink;
                display_Panel1.DayBackColor_1 = pink;
                Settings_Colorbar.BackColor = theme_pink;
                ColorTransfer = theme_pink;
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
                ThemeTransfer = "PINK";
            }

            else if (ColorInput == "AQUA")
            {
                display_Panel1.ExpandBGImage1 = Properties.Resources.BG_Aqua;
                display_Panel1.DayBackColor_1 = aqua;
                Settings_Colorbar.BackColor = theme_aqua;
                ColorTransfer = theme_aqua;
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
                ThemeTransfer = "AQUA";
            }

            else if (ColorInput == "LAVENDAR")
            {
                display_Panel1.ExpandBGImage1 = Properties.Resources.BG_Lavendar;
                display_Panel1.DayBackColor_1 = lavendar;
                Settings_Colorbar.BackColor = theme_lavendar;
                ColorTransfer = theme_lavendar;
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
                ThemeTransfer = "LAVENDAR";
            }

            else if (ColorInput == "YELLOW")
            {
                display_Panel1.ExpandBGImage1 = Properties.Resources.BG_Yellow;
                display_Panel1.DayBackColor_1 = yellow;
                Settings_Colorbar.BackColor = theme_yellow;
                ColorTransfer = theme_yellow;
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
                ThemeTransfer = "YELLOW";
            }

            else if (ColorInput == "GREEN")
            {
                display_Panel1.ExpandBGImage1 = Properties.Resources.BG_Green;
                display_Panel1.DayBackColor_1 = green;
                Settings_Colorbar.BackColor = theme_green;
                ColorTransfer = theme_green;
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
                ThemeTransfer = "GREEN";
            }

            else if (ColorInput == "GREY")
            {
                display_Panel1.ExpandBGImage1 = Properties.Resources.BG_Grey;
                display_Panel1.DayBackColor_1 = grey;
                Settings_Colorbar.BackColor = theme_grey;
                ColorTransfer = theme_grey;
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
                ThemeTransfer = "GREY";
            }

            else if (ColorInput == "PEACH")
            {
                display_Panel1.ExpandBGImage1 = Properties.Resources.BG_Peach;
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
                ThemeTransfer = "PEACH";
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

        private void SettingsInternal_OK_Click(object sender, EventArgs e)
        {
            // Perform error check on form.
            ErrorFormCheck();

            if (ErrorTrigger == 0)
            {
                MonolithConsole("Trigger is 0");
                string SAVE_INTERNAL = AppDomain.CurrentDomain.BaseDirectory + "database_internal.db";
                this.Hide();
            }
        }

        private void SettingsButton_Image_Click(object sender, EventArgs e)
        {
            panel_PersonnelImage_DoubleClick(sender, e);
        }

        private void label_SelectDBNotes_Click(object sender, EventArgs e)
        {

        }
    }
}
