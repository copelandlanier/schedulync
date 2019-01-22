using System;
using System.IO;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;
using LiteDB;
using System.Collections.Generic;

namespace Calendar_NEW
{
    public class Logic_Arrangement : Global_Access
    {
        DATABASE_OPERATIONS data_op = new DATABASE_OPERATIONS();
        List<int> namesList = new List<int>();
        protected Image PersonnelImage;
        protected Color RemoteColor;
        protected Image RemoteBGImage;

        public void ArrangeColumns(int[] NamesArray, string[] FirstNamesArray, string[] LastNameArray)
        {
            string FirstName;
            string LastName;

            for (int x = 0; x < NamesArray.Count(); x++)
            {
                if (NamesArray[x] != 0)
                {
                    namesList.Add(x);
                    FirstName = FirstNamesArray[x];
                    LastName = LastNameArray[x];
                    string SingleConfig = (AppDomain.CurrentDomain.BaseDirectory + "Calendar_Configuration/" + FirstName + "_" + LastName + ".cfg");
                    SetStripFunct(namesList.Count() - 1, FirstName, LastName, SingleConfig);
                }
            }

            // # Layout Resize Function
           // display_Panel1.Panel_DayControlHolder.Width = (display_Panel1.day_Control_1.Width * 2)+ (display_Panel1.day_Control_1.Width * namesList.Count()) + 16;
        }

        private void SetStripFunct(int x, string FirstName, string LastName, string LOCATION)
        {
            var NamesLabel2 = display_Panel1.pib_2.label_PImageName;
            var NamesLabel3 = display_Panel1.pib_3.label_PImageName;
            var NamesLabel4 = display_Panel1.pib_4.label_PImageName;
            var NamesLabel5 = display_Panel1.pib_5.label_PImageName;
            var NamesLabel6 = display_Panel1.pib_6.label_PImageName;
            var NamesLabel7 = display_Panel1.pib_7.label_PImageName;
            var NamesLabel8 = display_Panel1.pib_8.label_PImageName;
            var NamesLabel9 = display_Panel1.pib_9.label_PImageName;
            var NamesLabel10 = display_Panel1.pib_10.label_PImageName;

            if (x == 0)
            {
                display_Panel1.pib_2.Visible = true;
                NamesLabel2.Text = FirstName + " " + LastName;
                display_Panel1.pib_2.AllowDrop = AllowDrop;
                display_Panel1.pib_2.Enabled = Enabled;
                display_Panel1.pib_2.panel_PersonnelImage.BackgroundImage = LoadImageRemote(LOCATION);
                SetThemeRemote(LOCATION);
                display_Panel1.ExpandBGImage2 = RemoteBGImage;
                display_Panel1.DayBackColor_2 = RemoteColor;
                display_Panel1.Panel_DayControlHolder.Controls.Add(display_Panel1.day_Control_2);
            }

            if (x == 1)
            {
                display_Panel1.pib_3.Visible = true;
                NamesLabel3.Text = FirstName + " " + LastName;
                display_Panel1.pib_3.AllowDrop = AllowDrop;
                display_Panel1.pib_3.Enabled = Enabled;
                display_Panel1.pib_3.panel_PersonnelImage.BackgroundImage = LoadImageRemote(LOCATION);
                SetThemeRemote(LOCATION);
                display_Panel1.ExpandBGImage3 = RemoteBGImage;
                display_Panel1.DayBackColor_3 = RemoteColor;
                display_Panel1.Panel_DayControlHolder.Controls.Add(display_Panel1.day_Control_3);
            }

            if (x == 2)
            {
                display_Panel1.pib_4.Visible = true;
                NamesLabel4.Text = FirstName + " " + LastName;
                display_Panel1.pib_4.AllowDrop = AllowDrop;
                display_Panel1.pib_4.Enabled = Enabled;
                display_Panel1.pib_4.panel_PersonnelImage.BackgroundImage = LoadImageRemote(LOCATION);
                SetThemeRemote(LOCATION);
                display_Panel1.ExpandBGImage4 = RemoteBGImage;
                display_Panel1.DayBackColor_4 = RemoteColor;
                display_Panel1.Panel_DayControlHolder.Controls.Add(display_Panel1.day_Control_4);
            }

            if (x == 3)
            {
                display_Panel1.pib_5.Visible = true;
                NamesLabel5.Text = FirstName + " " + LastName;
                display_Panel1.pib_5.AllowDrop = AllowDrop;
                display_Panel1.pib_5.Enabled = Enabled;
                display_Panel1.pib_5.panel_PersonnelImage.BackgroundImage = LoadImageRemote(LOCATION);
                SetThemeRemote(LOCATION);
                display_Panel1.ExpandBGImage5 = RemoteBGImage;
                display_Panel1.DayBackColor_5 = RemoteColor;
                display_Panel1.Panel_DayControlHolder.Controls.Add(display_Panel1.day_Control_5);
            }

            if (x == 4)
            {
                display_Panel1.pib_6.Visible = true;
                NamesLabel6.Text = FirstName + " " + LastName;
                display_Panel1.pib_6.AllowDrop = AllowDrop;
                display_Panel1.pib_6.Enabled = Enabled;
                display_Panel1.pib_6.panel_PersonnelImage.BackgroundImage = LoadImageRemote(LOCATION);
                SetThemeRemote(LOCATION);
                display_Panel1.ExpandBGImage6 = RemoteBGImage;
                display_Panel1.DayBackColor_6 = RemoteColor;
                display_Panel1.Panel_DayControlHolder.Controls.Add(display_Panel1.day_Control_6);
            }

            if (x == 5)
            {
                display_Panel1.pib_7.Visible = true;
                NamesLabel7.Text = FirstName + " " + LastName;
                display_Panel1.pib_7.AllowDrop = AllowDrop;
                display_Panel1.pib_7.Enabled = Enabled;
                display_Panel1.pib_7.panel_PersonnelImage.BackgroundImage = LoadImageRemote(LOCATION);
                SetThemeRemote(LOCATION);
                display_Panel1.ExpandBGImage7 = RemoteBGImage;
                display_Panel1.DayBackColor_7 = RemoteColor;
                display_Panel1.Panel_DayControlHolder.Controls.Add(display_Panel1.day_Control_7);
            }

            if (x == 6)
            {
                display_Panel1.pib_8.Visible = true;
                NamesLabel8.Text = FirstName + " " + LastName;
                display_Panel1.pib_8.AllowDrop = AllowDrop;
                display_Panel1.pib_8.Enabled = Enabled;
                display_Panel1.pib_8.panel_PersonnelImage.BackgroundImage = LoadImageRemote(LOCATION);
                SetThemeRemote(LOCATION);
                display_Panel1.ExpandBGImage8 = RemoteBGImage;
                display_Panel1.DayBackColor_8 = RemoteColor;
                display_Panel1.Panel_DayControlHolder.Controls.Add(display_Panel1.day_Control_8);
            }

            if (x == 7)
            {
                display_Panel1.pib_9.Visible = true;
                NamesLabel9.Text = FirstName + " " + LastName;
                display_Panel1.pib_9.AllowDrop = AllowDrop;
                display_Panel1.pib_9.Enabled = Enabled;
                display_Panel1.pib_9.panel_PersonnelImage.BackgroundImage = LoadImageRemote(LOCATION);
                SetThemeRemote(LOCATION);
                display_Panel1.ExpandBGImage9 = RemoteBGImage;
                display_Panel1.DayBackColor_9 = RemoteColor;
                display_Panel1.Panel_DayControlHolder.Controls.Add(display_Panel1.day_Control_9);
            }

            if (x == 8)
            {
                display_Panel1.pib_10.Visible = true;
                NamesLabel10.Text = FirstName + " " + LastName;
                display_Panel1.pib_10.AllowDrop = AllowDrop;
                display_Panel1.pib_10.Enabled = Enabled;
                display_Panel1.pib_10.panel_PersonnelImage.BackgroundImage = LoadImageRemote(LOCATION);
                SetThemeRemote(LOCATION);
                display_Panel1.ExpandBGImage10 = RemoteBGImage;
                display_Panel1.DayBackColor_10 = RemoteColor;
                display_Panel1.Panel_DayControlHolder.Controls.Add(display_Panel1.day_Control_10);
            }
        }

        protected Image LoadImageRemote(string FileDirectory)
        {
            FileInfo filelocked = new FileInfo(FileDirectory);

            while (data_op.IsFileLocked(filelocked, FileDirectory) == true)
            {
                Console.WriteLine("Wainting for database to unlock: Duplicate NEXT Button");
            }

            //if (data_op.IsFileLocked(filelocked, FileDirectory) == false)
            //{
                MonolithConsole("File is unlocked in Set Strip Function " + data_op.IsFileLocked(filelocked, FileDirectory));

                string[] lines = File.ReadAllLines(FileDirectory);

                if (lines[11] != null)
                {
                    DATABASE_OPERATIONS dbo = new DATABASE_OPERATIONS();
                    string LAST_RETRIEVE = lines[9];
                    string FIRST_RETRIEVE = lines[8];
                    string FULLNAME_RETRIEVE = FIRST_RETRIEVE + "_" + LAST_RETRIEVE;
                    dbo.RETRIEVE_REMOTE_IMAGES(FULLNAME_RETRIEVE);

                    if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + "Calendar_Configuration/" + FIRST_RETRIEVE + "_" + LAST_RETRIEVE + ".avt"))
                    {
                        PersonnelImage = new Bitmap(AppDomain.CurrentDomain.BaseDirectory + "Calendar_Configuration/" + FIRST_RETRIEVE + "_" + LAST_RETRIEVE + ".avt");

                        try
                        {
                            Image imageIn = PersonnelImage;
                            PersonnelImage = resizeImageRemote(PersonnelImage, new Size(80, 80));
                        }

                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }

                else
                {
                    PersonnelImage = new Bitmap(Properties.Resources.avatar_image);
                    try
                    {
                        Image imageIn = PersonnelImage;
                        PersonnelImage = resizeImageRemote(PersonnelImage, new Size(80, 80));
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            //}
            return PersonnelImage;
        }

        public static Image resizeImageRemote(Image imgToResize, Size size)
        {
            return (Image)(new Bitmap(imgToResize, size));
        }

        private void SetThemeRemote(string FileDirectory)
        {
            FileInfo filelocked = new FileInfo(FileDirectory);

            while (data_op.IsFileLocked(filelocked, FileDirectory) == true)
            {
                Console.WriteLine("Wainting for database to unlock: Duplicate NEXT Button");
            }

            //if (data_op.IsFileLocked(filelocked, FileDirectory) == false)
            //{
            MonolithConsole("File is unlocked in resize Image Remote " + data_op.IsFileLocked(filelocked, FileDirectory));
                string[] lines = File.ReadAllLines(FileDirectory);

                if (lines[13] == "ORANGE")
                {
                    RemoteBGImage = Properties.Resources.BG_Orange;
                    RemoteColor = orange;
                }

                if (lines[13] == "MONOLITH")
                {
                    RemoteBGImage = Properties.Resources.BG_Monolith;
                    RemoteColor = monolith;
                }

                if (lines[13] == "BLUE")
                {
                    RemoteBGImage = Properties.Resources.BG_Blue;
                    RemoteColor = blue;
                }

                if (lines[13] == "PINK")
                {
                    RemoteBGImage = Properties.Resources.BG_Pink;
                    RemoteColor = pink;
                }

                if (lines[13] == "AQUA")
                {
                    RemoteBGImage = Properties.Resources.BG_Aqua;
                    RemoteColor = aqua;
                }

                if (lines[13] == "LAVENDAR")
                {
                    RemoteBGImage = Properties.Resources.BG_Lavendar;
                    RemoteColor = lavendar;
                }

                if (lines[13] == "YELLOW")
                {
                    RemoteBGImage = Properties.Resources.BG_Yellow;
                    RemoteColor = yellow;
                }

                if (lines[13] == "GREEN")
                {
                    RemoteBGImage = Properties.Resources.BG_Green;
                    RemoteColor = green;
                }

                if (lines[13] == "GREY")
                {
                    RemoteBGImage = Properties.Resources.BG_Grey;
                    RemoteColor = grey;
                }

                if (lines[13] == "PEACH")
                {
                    RemoteBGImage = Properties.Resources.BG_Peach;
                    RemoteColor = peach;
                }

                if (lines[13] == "DEFAULTCOLOR")
                {
                    RemoteBGImage = Properties.Resources.BG_Default;
                    RemoteColor = defaultColor;
                }
            //}
        }
    }
}

