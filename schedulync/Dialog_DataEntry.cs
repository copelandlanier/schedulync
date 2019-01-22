using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using LiteDB;
using System.Windows.Forms;
using System.Globalization;

namespace Calendar_NEW
{
    public partial class Dialog_DataEntry : Global_Access
    {
        public static int FormReady = 0;
        string EXTERNAL_DATABASE;
        Dialog_Repeat dialog_repeat = new Dialog_Repeat();
        Dialog_Alarm dialog_alert = new Dialog_Alarm();

        public Dialog_DataEntry()
        {
            InitializeComponent();
            this.Paint += Dialog_DataEntry_Paint;
            this.Opacity = 1f;

            checkedListBox_DataEntry.SelectedValueChanged += CheckedListBox_DataEntry_SelectedValueChanged;
            checkedListBox_DataEntry.CheckOnClick = true;
                
            comboBox_HourFrom.MouseClick += ComboBox_HourFrom_MouseClick;
            comboBox_MinuteFrom.MouseClick += ComboBox_MinuteFrom_MouseClick;
            comboBox_DayFrom.MouseClick += ComboBox_DayFrom_MouseClick;
            comboBox_HourTo.MouseClick += ComboBox_HourTo_MouseClick;
            comboBox_MinuteTo.MouseClick += ComboBox_MinuteTo_MouseClick;
            comboBox_DayTo.MouseClick += ComboBox_DayTo_MouseClick;

            comboBox_HourFrom.SelectionChangeCommitted += ComboBox_HourFrom_SelectionChangeCommitted;
            comboBox_MinuteFrom.SelectionChangeCommitted += ComboBox_MinuteFrom_SelectionChangeCommitted;
            comboBox_DayFrom.SelectionChangeCommitted += ComboBox_DayFrom_SelectionChangeCommitted;
            comboBox_HourTo.SelectionChangeCommitted += ComboBox_HourTo_SelectionChangeCommitted;
            comboBox_MinuteTo.SelectionChangeCommitted += ComboBox_MinuteTo_SelectionChangeCommitted;
            comboBox_DayTo.SelectionChangeCommitted += ComboBox_DayTo_SelectionChangeCommitted;

            Title_DataEntry.MouseClick += Title_DataEntry_MouseClick;

            string[] TimeRange = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" };
            string[] MinuteRange = { "00", "30" };  

            comboBox_HourTo.Items.AddRange(TimeRange);
            comboBox_MinuteTo.Items.AddRange(MinuteRange);
            comboBox_HourFrom.Items.AddRange(TimeRange);
            comboBox_MinuteFrom.Items.AddRange(MinuteRange);

            comboBox_DayFrom.Text = "AM";
            comboBox_DayTo.Text = "AM";


            if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + "Calendar_Configuration/configuration"))
            {
            string INTERNAL_CONFIG = AppDomain.CurrentDomain.BaseDirectory + "Calendar_Configuration/configuration";
            string[] lines = File.ReadAllLines(INTERNAL_CONFIG);
            string FirstName = lines[8];
            string LastName = lines[9];
            EXTERNAL_DATABASE = lines[18] + lines[17] + ".db";

            using (var db = new LiteDatabase(EXTERNAL_DATABASE))
            {
                var EmployeeCollection = db.GetCollectionNames();

                PersonnelList.Clear();
                for (int x = 3; x < EmployeeCollection.Count(); x++)
                {
                    PersonnelList.Add(EmployeeCollection.ElementAtOrDefault(x));
                }

                checkedListBox_DataEntry.Refresh();
                for (int x = 0; x < PersonnelList.Count; x++)
                {
                    checkedListBox_DataEntry.Items.Add(PersonnelList[x].Replace("_", " "));
                }
            }
        }
            comboBox_HourFrom.SelectedItem = "9";
            comboBox_MinuteFrom.SelectedItem = "00";
            comboBox_DayFrom.SelectedItem = "AM";
            comboBox_HourTo.SelectedItem = "5";
            comboBox_MinuteTo.SelectedItem = "00";
            comboBox_DayTo.SelectedItem = "PM";
        }

        private void ComboBox_DayTo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CheckSpan();
        }

        private void ComboBox_MinuteTo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CheckSpan();
        }

        private void ComboBox_HourTo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CheckSpan();
        }

        private void ComboBox_DayFrom_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CheckSpan();
        }

        private void ComboBox_MinuteFrom_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CheckSpan();
        }

        private void ComboBox_HourFrom_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CheckSpan();
        }

        private void Title_DataEntry_MouseClick(object sender, MouseEventArgs e)
        {
            ResetErrorColors();            
        }

        private void ComboBox_HourFrom_MouseClick(object sender, MouseEventArgs e)
        {
            ResetErrorColors();
        }

        private void ComboBox_MinuteFrom_MouseClick(object sender, MouseEventArgs e)
        {
            ResetErrorColors();
        }

        private void ComboBox_DayFrom_MouseClick(object sender, MouseEventArgs e)
        {
            ResetErrorColors();
        }

        private void ComboBox_HourTo_MouseClick(object sender, MouseEventArgs e)
        {
            ResetErrorColors();
        }

        private void ComboBox_MinuteTo_MouseClick(object sender, MouseEventArgs e)
        {
            ResetErrorColors();
        }

        private void ComboBox_DayTo_MouseClick(object sender, MouseEventArgs e)
        {
            ResetErrorColors();
        }

        private void CheckedListBox_DataEntry_SelectedValueChanged(object sender, EventArgs e)
        {
            checkedListBox_DataEntry.Refresh();
            label_DataEntry_Personnel.Text = "INCLUDED PERSONNEL: " + checkedListBox_DataEntry.CheckedItems.Count;
        }

        private void Dialog_DataEntry_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(Color.FromArgb(30, 0, 0, 0), 5), this.DisplayRectangle);
        }

        private void DialogAlarm_ButtonCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Button_DataEntry_OK_Click(object sender, EventArgs e)
        {
            if(ErrorFormCheck() == false)
            {
                FormReady = 1;              
                this.Hide();
            }
        }
        
        public bool ErrorFormCheck()
        {
            bool ValidateForm;
            int ErrorResults = 0;

            if (Title_DataEntry.Text == "")
            {
                Title_DataEntry.BackColor = ErrorColor;
                ErrorResults = ErrorResults + 1;
            }

            if (comboBox_HourFrom.Text == "")
            {
                comboBox_HourFrom.BackColor = ErrorColor;
                ErrorResults = ErrorResults + 1;
            }

            if (comboBox_MinuteFrom.Text == "")
            {
                comboBox_MinuteFrom.BackColor = ErrorColor;
                ErrorResults = ErrorResults + 1;
            }

            if (comboBox_DayFrom.Text == "")
            {
                comboBox_DayFrom.BackColor = ErrorColor;
                ErrorResults = ErrorResults + 1;
            }

            if (comboBox_HourTo.Text == "")
            {
                comboBox_HourTo.BackColor = ErrorColor;
                ErrorResults = ErrorResults + 1;
            }

            if (comboBox_MinuteTo.Text == "")
            {
                comboBox_MinuteTo.BackColor = ErrorColor;
                ErrorResults = ErrorResults + 1;
            }

            if (comboBox_DayTo.Text == "")
            {
                comboBox_DayTo.BackColor = ErrorColor;
                ErrorResults = ErrorResults + 1;
            }

            // If there are no errors, then ErrorTrigger will be 0.
            if (ErrorResults == 0)
            {
                ValidateForm = false;                
                return ValidateForm;
            }

            else
            {
                ValidateForm = true;
                return ValidateForm;
            }
        }

        // ^
        private void ShowEvent()
        {
//                Console.WriteLine("This is a click from the data entry form");
               /* 
                * Event_Location
                    (
                    Int32.Parse(comboBox_HourFrom.SelectedItem.ToString()),
                    Int32.Parse(comboBox_MinuteFrom.SelectedItem.ToString()),
                    comboBox_DayFrom.SelectedItem.ToString(),
                    Int32.Parse(comboBox_HourTo.SelectedItem.ToString()),
                    Int32.Parse(comboBox_MinuteTo.SelectedItem.ToString()),
                    comboBox_DayTo.SelectedItem.ToString()
                    );
              */
        }
        
        public void CheckSpan()
        {   
            Console.WriteLine("Checking Span");
            int TOPM = 0;
            int FROMPM = 0;

            if (comboBox_DayFrom.SelectedItem.ToString() == "PM")
            {
                if(comboBox_HourFrom.SelectedItem.ToString() != "12")
                {
                    FROMPM = 12;
                }

                else
                {
                    FROMPM = 0;
                }
            }

            if (comboBox_DayTo.SelectedItem.ToString() == "PM")
            {
                if(comboBox_HourTo.SelectedItem.ToString() != "12")
                {
                    TOPM = 12;
                }

                else
                {
                    TOPM = 0;
                }
            }

            if (comboBox_DayFrom.SelectedItem.ToString() == "AM")
            {
                if (comboBox_HourFrom.SelectedItem.ToString() == "12")
                {
                    FROMPM = -12;
                }

                else
                {
                    FROMPM = 0;
                }
            }

            if (comboBox_DayTo.SelectedItem.ToString() == "AM")
            {
                if (comboBox_HourTo.SelectedItem.ToString() == "12")
                {
                    TOPM = -12;
                }

                else
                {
                    TOPM = 0;
                }
            }

            DateTime dtFROM = new DateTime(DateTime.Now.Year,
                DateTime.Now.Month, DateTime.Now.Day,
                Int32.Parse(comboBox_HourFrom.SelectedItem.ToString()) + FROMPM,
                Int32.Parse(comboBox_MinuteFrom.SelectedItem.ToString()), 0);
            DateTime dtTO = new DateTime(DateTime.Now.Year,
                DateTime.Now.Month,
                DateTime.Now.Day,
                Int32.Parse(comboBox_HourTo.SelectedItem.ToString()) + TOPM,
                Int32.Parse(comboBox_MinuteTo.SelectedItem.ToString()), 0);

            int ResultCompare = DateTime.Compare(dtFROM, dtTO);

            if (ResultCompare == 1 || ResultCompare == 0)
            {
                DateTime TimeConversion = dtFROM;

                if (dtFROM.Hour > 12)
                {
                    if(dtFROM.Hour > 22)
                    {
                        dtTO = new DateTime( dtFROM.Year, dtFROM.Month, dtFROM.Day, 23, 30, 0 );
                        dtFROM = new DateTime( dtFROM.Year, dtFROM.Month, dtFROM.Day, 23, 0, 0 );
                        comboBox_HourTo.SelectedItem = "11";
                        comboBox_MinuteTo.SelectedItem = "30";
                        comboBox_DayTo.SelectedItem = dtTO.ToString("tt", CultureInfo.InvariantCulture);
                        comboBox_HourFrom.SelectedItem = "11";
                        comboBox_MinuteFrom.SelectedItem = "00";
                        comboBox_DayFrom.SelectedItem = dtFROM.ToString("tt", CultureInfo.InvariantCulture);
                    }

                    else
                    {
                        TimeConversion = dtFROM.AddHours(-12);
                        comboBox_HourTo.SelectedItem = (TimeConversion.Hour + 1).ToString();
                        dtTO = new DateTime( dtFROM.Year, dtFROM.Month, dtFROM.Day, (dtFROM.Hour + 1), dtFROM.Minute,  0 );
                        comboBox_MinuteTo.SelectedItem = dtTO.Minute.ToString();
                        comboBox_DayTo.SelectedItem = dtTO.ToString("tt", CultureInfo.InvariantCulture);
                    }
                }

                else
                {
                    dtTO = new DateTime(dtFROM.Year, dtFROM.Month, dtFROM.Day, (dtFROM.Hour + 1), dtFROM.Minute, 0);
                    comboBox_HourTo.SelectedItem = dtTO.Hour.ToString();
                    comboBox_MinuteTo.SelectedItem = dtTO.Minute.ToString();
                    comboBox_DayTo.SelectedItem = dtTO.ToString("tt", CultureInfo.InvariantCulture);
                }                
            }
            TimeSpan span = dtTO.Subtract(dtFROM);
            label_DataEntry_Hours.Text =  ("TOTAL HOURS: " + span.ToString()
                .Replace("01","1")
                .Replace("02", "2")
                .Replace("03", "3")
                .Replace("04", "4")
                .Replace("05", "5")
                .Replace("06", "6")
                .Replace("07", "7")
                .Replace("08", "8")
                .Replace("09", "9")
                .Replace(":", "")
                .Replace("00", "")
                .Replace("30", ".5"));

            //
            /*
            if (label_DataEntry_Hours.Text == ".5")
            {
                label_DataEntry_Hours.Text = "0.5";
            }*/
        }

        // ^
        private void ResetErrorColors()
        {
            Color whiteBG = Color.White;
            comboBox_HourFrom.BackColor = whiteBG;
            comboBox_MinuteFrom.BackColor = whiteBG;
            comboBox_DayFrom.BackColor = whiteBG;
            comboBox_HourTo.BackColor = whiteBG;
            comboBox_MinuteTo.BackColor = whiteBG;
            comboBox_DayTo.BackColor = whiteBG;
            Title_DataEntry.BackColor = whiteBG;
        }

        private void button_DataEntry_Alarm_Click(object sender, EventArgs e)
        {
            if (dialog_repeat.Visible == false)
            {
                dialog_repeat.TopMost = true;
                dialog_repeat.Show();
            }
            else
            {
                dialog_repeat.Hide();
            }
        }

        private void button_DataEntry_Repeat_Click(object sender, EventArgs e)
        {
           if(dialog_repeat.Visible == false)
            {           
                dialog_repeat.TopMost = true;
                dialog_repeat.Show();
            }
           else
            {
                dialog_repeat.Hide();
            }
        }

        private void Button_DataEntry_Cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        /*
        public void Event_Location(int FROMhour, int FROMminute, string FROMday, int TOhour, int TOminute, string TOday)
        {
            int FROMminutetrans = 0;
            int FROMposttwelve = 0;
            int TOminutetrans = 0;
            int TOposttwelve = 0;

            if (FROMminute == 30)
            {
                FROMminutetrans = 20;
            }

            if (TOminute == 30)
            {
                TOminutetrans = 20;
            }

            // AM

            if (FROMday == "AM")
            {
                if (FROMhour == 12)
                {
                    event_location = 20 + FROMminutetrans;
                }

                else
                {
                    FROMposttwelve = 60;
                    for (int x = 0; x < FROMhour; x++)
                    {
                        event_location = FROMposttwelve + (x * 40) + (FROMminutetrans);
                    }
                }
            }
            
            if (FROMday == "PM")
            {
                if (FROMhour == 12)
                {
                    event_location = 500 + FROMminutetrans;
                }

                else
                {
                    FROMposttwelve = 540;
                    for (int x = 0; x < FROMhour; x++)
                    {
                        event_location = FROMposttwelve + (x * 40) + (FROMminutetrans);
                    }
                }

            // PM

            }

            if (TOday == "AM")
                {
                    if (TOhour == 12)
                    {
                        event_height_holder = 20 + TOminutetrans;
                    }

                    else
                    {
                        TOposttwelve = 60;
                        for (int x = 0; x < TOhour; x++)
                        {
                            event_height_holder = TOposttwelve + (x * 40) + (TOminutetrans);
                        }
                    }
                }

            if (TOday == "PM")
                {
                    if (TOhour == 12)
                    {
                        event_height_holder = 500 + TOminutetrans;
                    }

                    else
                    {
                        TOposttwelve = 540;
                        for (int x = 0; x < TOhour; x++)
                        {
                            event_height_holder = TOposttwelve + (x * 40) + (TOminutetrans);
                        }
                    }
                }

            if (TOday == FROMday && TOhour == FROMhour)
            {
                //
            }

            if (display_Panel1.day_Control_1 == true)
            {
                if (Day_Control.dataform_eventlive == 1)
                {
                    display_Panel1.day_Control_1.Day_Expanding_Panel_01.Location = new Point(0, event_location);
                    display_Panel1.day_Control_1.Day_Expanding_Panel_01.Height = event_height_holder - event_location;
                }

                if (Day_Control.dataform_eventlive == 2)
                {
                    display_Panel1.day_Control_1.Day_Expanding_Panel_02.Location = new Point(0, event_location);
                    display_Panel1.day_Control_1.Day_Expanding_Panel_02.Height = event_height_holder - event_location;
                }

                if (Day_Control.dataform_eventlive == 3)
                {
                    display_Panel1.day_Control_1.Day_Expanding_Panel_03.Location = new Point(0, event_location);
                    display_Panel1.day_Control_1.Day_Expanding_Panel_03.Height = event_height_holder - event_location;
                }

                if (Day_Control.dataform_eventlive == 4)
                {
                    display_Panel1.day_Control_1.Day_Expanding_Panel_04.Location = new Point(0, event_location);
                    display_Panel1.day_Control_1.Day_Expanding_Panel_04.Height = event_height_holder - event_location;
                }

                if (Day_Control.dataform_eventlive == 5)
                {
                    display_Panel1.day_Control_1.Day_Expanding_Panel_05.Location = new Point(0, event_location);
                    display_Panel1.day_Control_1.Day_Expanding_Panel_05.Height = event_height_holder - event_location;
                }
            }
        }
        
        CalculateHours()
        {
            DateTime FirstNumber = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, Int32.Parse(comboBox_HourFrom.Text), Int32.Parse(comboBox_MinuteFrom.Text), 0);
            DateTime SecondNumber = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, Int32.Parse(comboBox_HourTo.Text), Int32.Parse(comboBox_MinuteTo.Text), 0);
        }*/
    }
}