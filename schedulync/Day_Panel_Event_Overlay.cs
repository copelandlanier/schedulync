using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Calendar_NEW
{
    partial class Day_Control
    {
        public Label Day_Expanding_Panel_01 = new Label();
        public Label Day_Expanding_Panel_02 = new Label();
        public Label Day_Expanding_Panel_03 = new Label();
        public Label Day_Expanding_Panel_04 = new Label();
        public Label Day_Expanding_Panel_05 = new Label();
        public Label Day_Expanding_Panel_06 = new Label();
        public Label Day_Expanding_Panel_Overlay_Reocc = new Label();
        public Label Day_Expanding_Panel_Overlay_Alarm = new Label();
        public Point Day_Expanding_Panel_Start_Loc = new Point();
        public Point Day_Expanding_Panel_Start_01 = new Point();
        public Point Day_Expanding_Panel_End_01 = new Point();
        public Point Day_Expanding_Panel_Start_02 = new Point();
        public Point Day_Expanding_Panel_End_02 = new Point();
        public Point Day_Expanding_Panel_Start_03 = new Point();
        public Point Day_Expanding_Panel_End_03 = new Point();
        public Point Day_Expanding_Panel_Start_04 = new Point();
        public Point Day_Expanding_Panel_End_04 = new Point();
        public Point Day_Expanding_Panel_Start_05 = new Point();
        public Point Day_Expanding_Panel_End_05 = new Point();
        public Point Day_Expanding_Panel_Start_06 = new Point();
        public Point Day_Expanding_Panel_End_06 = new Point();
        Point Day_Expanding_Panel_MousePoint_01 = new Point();
        Point Day_Expanding_Panel_MousePoint_02 = new Point();
        Point Day_Expanding_Panel_MousePoint_03 = new Point();
        Point Day_Expanding_Panel_MousePoint_04 = new Point();
        Point Day_Expanding_Panel_MousePoint_05 = new Point();
        Point Day_Expanding_Panel_MousePoint_06 = new Point();
        // MOUSESWITCH - 1 = Top / 2 = Bottom / 3 = Move
        int Day_Expanding_Panel_MouseSwitch_01 = 0;
        int Day_Expanding_Panel_MouseSwitch_02 = 0;
        int Day_Expanding_Panel_MouseSwitch_03 = 0;
        int Day_Expanding_Panel_MouseSwitch_04 = 0;
        int Day_Expanding_Panel_MouseSwitch_05 = 0;
        int Day_Expanding_Panel_MouseSwitch_06 = 0;
        // Get Location and Map to Time
        int Day_Expanding_Panel_LocGet_A_01;
        int Day_Expanding_Panel_LocGet_B_01;
        string Day_Expanding_Panel_String_A_01;
        string Day_Expanding_Panel_String_B_01;
        int Day_Expanding_Panel_LocGet_A_02;
        int Day_Expanding_Panel_LocGet_B_02;
        string Day_Expanding_Panel_String_A_02;
        string Day_Expanding_Panel_String_B_02;
        int Day_Expanding_Panel_LocGet_A_03;
        int Day_Expanding_Panel_LocGet_B_03;
        string Day_Expanding_Panel_String_A_03;
        string Day_Expanding_Panel_String_B_03;
        int Day_Expanding_Panel_LocGet_A_04;
        int Day_Expanding_Panel_LocGet_B_04;
        string Day_Expanding_Panel_String_A_04;
        string Day_Expanding_Panel_String_B_04;
        int Day_Expanding_Panel_LocGet_A_05;
        int Day_Expanding_Panel_LocGet_B_05;
        public string Day_Expanding_Panel_String_A_05;
        public string Day_Expanding_Panel_String_B_05;
        int Day_Expanding_Panel_LocGet_A_06;
        int Day_Expanding_Panel_LocGet_B_06;
        string Day_Expanding_Panel_String_A_06;
        string Day_Expanding_Panel_String_B_06;
        // Hold Height of Expanding Panel
        int Day_Expanding_Panel_Height_Holder_01;
        int Day_Expanding_Panel_Top_Holder_01;
        int Day_Expanding_Panel_Top_Point_01;
        int Day_Expanding_Panel_Height_Holder_02;
        int Day_Expanding_Panel_Top_Holder_02;
        int Day_Expanding_Panel_Top_Point_02;
        int Day_Expanding_Panel_Height_Holder_03;
        int Day_Expanding_Panel_Top_Holder_03;
        int Day_Expanding_Panel_Top_Point_03;
        int Day_Expanding_Panel_Height_Holder_04;
        int Day_Expanding_Panel_Top_Holder_04;
        int Day_Expanding_Panel_Top_Point_04;
        int Day_Expanding_Panel_Height_Holder_05;
        int Day_Expanding_Panel_Top_Holder_05;
        int Day_Expanding_Panel_Top_Point_05;
        int Day_Expanding_Panel_Height_Holder_06;
        int Day_Expanding_Panel_Top_Holder_06;
        int Day_Expanding_Panel_Top_Point_06;
        int WhichControlUnderMouse;
        string x_out;

        Label EventLabel_01 = new Label();
        Label EventLabel_02 = new Label();
        Label EventLabel_03 = new Label();
        Label EventLabel_04 = new Label();
        Label EventLabel_05 = new Label();
        Color ColorVacation = Color.DarkViolet;
        Color ColorConference = Color.DarkRed;
        Color ColorHoliday = Color.DarkOliveGreen;
        Color ColorOnSite = Color.DarkBlue;

        public void Day_Overlay_Events()
        {
            DoubleBuffered = true;
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);        

            // Day_Expanding Panel Creation

            #region // Day_Expanding Panel Creation

            // Day_Expanding Panel 1
            Day_Expanding_Panel_01.Location = new Point();
            Day_Expanding_Panel_01.Location = DropDownMenuLocation;
            Day_Expanding_Panel_01.Visible = false;
            Day_Expanding_Panel_01.AutoSize = false;
            Day_Expanding_Panel_01.ForeColor = Color.White;
            Day_Expanding_Panel_01.Padding = new Padding(10, 4, 0, 0);
            this.Controls.Add(Day_Expanding_Panel_01);
            Day_Expanding_Panel_01.BringToFront();
            
            // Day_Expanding Panel 2
            Day_Expanding_Panel_02.Location = new Point();
            Day_Expanding_Panel_02.Location = DropDownMenuLocation;
            Day_Expanding_Panel_02.Visible = false;
            Day_Expanding_Panel_02.AutoSize = false;
            Day_Expanding_Panel_02.ForeColor = Color.White;
            Day_Expanding_Panel_02.Padding = new Padding(10, 4, 0, 0);
            this.Controls.Add(Day_Expanding_Panel_02);
            Day_Expanding_Panel_02.BringToFront();

            // Day_Expanding Panel 3
            Day_Expanding_Panel_03.Location = new Point();
            Day_Expanding_Panel_03.Location = DropDownMenuLocation;
            Day_Expanding_Panel_03.Visible = false;
            Day_Expanding_Panel_03.AutoSize = false;
            Day_Expanding_Panel_03.ForeColor = Color.White;
            Day_Expanding_Panel_03.Padding = new Padding(10, 4, 0, 0);
            this.Controls.Add(Day_Expanding_Panel_03);
            Day_Expanding_Panel_03.BringToFront();

            // Day_Expanding Panel 4
            Day_Expanding_Panel_04.Location = new Point();
            Day_Expanding_Panel_04.Location = DropDownMenuLocation;
            Day_Expanding_Panel_04.Visible = false;
            Day_Expanding_Panel_04.AutoSize = false;
            Day_Expanding_Panel_04.ForeColor = Color.White;
            Day_Expanding_Panel_04.Padding = new Padding(10, 4, 0, 0);
            this.Controls.Add(Day_Expanding_Panel_04);
            Day_Expanding_Panel_04.BringToFront();

            // Day_Expanding Panel 5
            Day_Expanding_Panel_05.Location = new Point();
            Day_Expanding_Panel_05.Location = DropDownMenuLocation;
            Day_Expanding_Panel_05.Visible = false;
            Day_Expanding_Panel_05.AutoSize = false;
            Day_Expanding_Panel_05.ForeColor = Color.White;
            Day_Expanding_Panel_05.Padding = new Padding(10, 4, 0, 0);
            this.Controls.Add(Day_Expanding_Panel_05);
            Day_Expanding_Panel_05.BringToFront();

            // Day_Expanding Panel 6
            Day_Expanding_Panel_06.Location = new Point();
            Day_Expanding_Panel_06.Location = DropDownMenuLocation;
            Day_Expanding_Panel_06.Visible = false;
            Day_Expanding_Panel_06.AutoSize = false;
            Day_Expanding_Panel_06.ForeColor = Color.White;
            Day_Expanding_Panel_06.Padding = new Padding(10, 4, 0, 0);
            this.Controls.Add(Day_Expanding_Panel_06);
            Day_Expanding_Panel_06.BringToFront();

            #endregion

            #region // Overlay Icons
            // Day_Expanding Panel Overlay Reoccurring      
            Day_Expanding_Panel_Overlay_Reocc.Height = 20;
            Day_Expanding_Panel_Overlay_Reocc.Width = 20;
            Day_Expanding_Panel_Overlay_Reocc.Location = new Point(0, 0);
            Day_Expanding_Panel_Overlay_Reocc.Visible = true;
            Day_Expanding_Panel_Overlay_Reocc.Image = Properties.Resources.icon_reocurring;
            Day_Expanding_Panel_Overlay_Reocc.AutoSize = false;
            Day_Expanding_Panel_Overlay_Reocc.BackColor = Color.FromArgb(0, 0, 0, 0);
            Day_Expanding_Panel_Overlay_Reocc.Padding = new Padding(0, 1, 0, 0);
            Day_Expanding_Panel_01.Controls.Add(Day_Expanding_Panel_Overlay_Reocc);
            Day_Expanding_Panel_02.Controls.Add(Day_Expanding_Panel_Overlay_Reocc);
            Day_Expanding_Panel_03.Controls.Add(Day_Expanding_Panel_Overlay_Reocc);
            Day_Expanding_Panel_04.Controls.Add(Day_Expanding_Panel_Overlay_Reocc);
            Day_Expanding_Panel_05.Controls.Add(Day_Expanding_Panel_Overlay_Reocc);
            //Day_Expanding_Panel_06.Controls.Add(Day_Expanding_Panel_Overlay_Reocc);

            // Day_Expanding Panel Overlay Alarm
            Day_Expanding_Panel_Overlay_Alarm.Height = 20;
            Day_Expanding_Panel_Overlay_Alarm.Width = 20;
            Day_Expanding_Panel_Overlay_Alarm.Location = new Point(0, 8);
            Day_Expanding_Panel_Overlay_Alarm.Visible = true;
            Day_Expanding_Panel_Overlay_Alarm.Image = Properties.Resources.icon_alarm;
            Day_Expanding_Panel_Overlay_Alarm.AutoSize = false;
            Day_Expanding_Panel_Overlay_Alarm.BackColor = Color.FromArgb(0, 0, 0, 0);
            Day_Expanding_Panel_Overlay_Alarm.Padding = new Padding(0, 0, 0, 0);
            Day_Expanding_Panel_01.Controls.Add(Day_Expanding_Panel_Overlay_Alarm);
            Day_Expanding_Panel_02.Controls.Add(Day_Expanding_Panel_Overlay_Alarm);
            Day_Expanding_Panel_03.Controls.Add(Day_Expanding_Panel_Overlay_Alarm);
            Day_Expanding_Panel_04.Controls.Add(Day_Expanding_Panel_Overlay_Alarm);
            Day_Expanding_Panel_05.Controls.Add(Day_Expanding_Panel_Overlay_Alarm);
            //Day_Expanding_Panel_06.Controls.Add(Day_Expanding_Panel_Overlay_Alarm);
            #endregion

            Day_Expanding_Panel_Overlay_Reocc.BringToFront();
            Day_Expanding_Panel_Overlay_Alarm.BringToFront();

            #region // Day_Expanding Panel Events
            // Day_Expanding Panel Events
            Day_Expanding_Panel_01.MouseDoubleClick += Day_Expanding_Panel_MouseDoubleClick_01;
            Day_Expanding_Panel_01.MouseDown += Day_Expanding_Panel_MouseDown_01;
            Day_Expanding_Panel_01.MouseUp += Day_Expanding_Panel_MouseUp_01;
            Day_Expanding_Panel_01.MouseMove += Day_Expanding_Panel_MouseMove_01;

            Day_Expanding_Panel_02.MouseDoubleClick += Day_Expanding_Panel_MouseDoubleClick_02;
            Day_Expanding_Panel_02.MouseDown += Day_Expanding_Panel_MouseDown_02;
            Day_Expanding_Panel_02.MouseUp += Day_Expanding_Panel_MouseUp_02;
            Day_Expanding_Panel_02.MouseMove += Day_Expanding_Panel_MouseMove_02;

            Day_Expanding_Panel_03.MouseDoubleClick += Day_Expanding_Panel_MouseDoubleClick_03;
            Day_Expanding_Panel_03.MouseDown += Day_Expanding_Panel_MouseDown_03;
            Day_Expanding_Panel_03.MouseUp += Day_Expanding_Panel_MouseUp_03;
            Day_Expanding_Panel_03.MouseMove += Day_Expanding_Panel_MouseMove_03;

            Day_Expanding_Panel_04.MouseDoubleClick += Day_Expanding_Panel_MouseDoubleClick_04;
            Day_Expanding_Panel_04.MouseDown += Day_Expanding_Panel_MouseDown_04;
            Day_Expanding_Panel_04.MouseUp += Day_Expanding_Panel_MouseUp_04;
            Day_Expanding_Panel_04.MouseMove += Day_Expanding_Panel_MouseMove_04;

            Day_Expanding_Panel_05.MouseDoubleClick += Day_Expanding_Panel_MouseDoubleClick_05;
            Day_Expanding_Panel_05.MouseDown += Day_Expanding_Panel_MouseDown_05;
            Day_Expanding_Panel_05.MouseUp += Day_Expanding_Panel_MouseUp_05;
            Day_Expanding_Panel_05.MouseMove += Day_Expanding_Panel_MouseMove_05;
            
            #endregion

            Day_Expanding_Panel_Start_01.Y = Day_Expanding_Panel_01.Height;
            Day_Expanding_Panel_End_01.Y = Day_Expanding_Panel_01.Top;
            Day_Expanding_Panel_Start_02.Y = Day_Expanding_Panel_02.Height;
            Day_Expanding_Panel_End_02.Y = Day_Expanding_Panel_02.Top;
            Day_Expanding_Panel_Start_03.Y = Day_Expanding_Panel_03.Height;
            Day_Expanding_Panel_End_03.Y = Day_Expanding_Panel_03.Top;
            Day_Expanding_Panel_Start_04.Y = Day_Expanding_Panel_04.Height;
            Day_Expanding_Panel_End_04.Y = Day_Expanding_Panel_04.Top;
            Day_Expanding_Panel_Start_05.Y = Day_Expanding_Panel_05.Height;
            Day_Expanding_Panel_End_05.Y = Day_Expanding_Panel_05.Top;
            Day_Expanding_Panel_Start_06.Y = Day_Expanding_Panel_06.Height;
            Day_Expanding_Panel_End_06.Y = Day_Expanding_Panel_06.Top;

            EventLabel_01.Width = 120;
            EventLabel_01.Height = 15;
            EventLabel_01.BackColor = Color.White;
            EventLabel_01.Location = new Point(0, 25);
            Day_Expanding_Panel_01.Controls.Add(EventLabel_01);

            EventLabel_02.Width = 120;
            EventLabel_02.Height = 15;
            EventLabel_02.BackColor = Color.White;
            EventLabel_02.Location = new Point(0, 25);
            Day_Expanding_Panel_02.Controls.Add(EventLabel_02);

            EventLabel_03.Width = 120;
            EventLabel_03.Height = 15;
            EventLabel_03.BackColor = Color.White;
            EventLabel_03.Location = new Point(0, 25);
            Day_Expanding_Panel_03.Controls.Add(EventLabel_03);

            EventLabel_04.Width = 120;
            EventLabel_04.Height = 15;
            EventLabel_04.BackColor = Color.White;
            EventLabel_04.Location = new Point(0, 25);
            Day_Expanding_Panel_04.Controls.Add(EventLabel_04);

            EventLabel_05.Width = 120;
            EventLabel_05.Height = 15;
            EventLabel_05.BackColor = Color.White;
            EventLabel_05.Location = new Point(0, 25);
            Day_Expanding_Panel_05.Controls.Add(EventLabel_05);

            EventLabel_01.Hide();
            EventLabel_02.Hide();
            EventLabel_03.Hide();
            EventLabel_04.Hide();
            EventLabel_05.Hide();

            dataform_01.comboBox_EventType.SelectionChangeCommitted += ComboBox_EventType_SelectionChangeCommitted1;
            dataform_02.comboBox_EventType.SelectionChangeCommitted += ComboBox_EventType_SelectionChangeCommitted2;
            dataform_03.comboBox_EventType.SelectionChangeCommitted += ComboBox_EventType_SelectionChangeCommitted3;
            dataform_04.comboBox_EventType.SelectionChangeCommitted += ComboBox_EventType_SelectionChangeCommitted4;
            dataform_05.comboBox_EventType.SelectionChangeCommitted += ComboBox_EventType_SelectionChangeCommitted5;
        }

        private void ComboBox_EventType_SelectionChangeCommitted5(object sender, EventArgs e)
        {
            if (dataform_05.comboBox_EventType.Text != "")
            {
                if (dataform_05.comboBox_EventType.Text == "Vacation")
                {
                    EventLabel_05.BackColor = ColorVacation;
                    EventLabel_05.Text = "    Vacation";
                }
                if (dataform_05.comboBox_EventType.Text == "Holiday")
                {
                    EventLabel_05.BackColor = ColorHoliday;
                    EventLabel_05.Text = "    Holiday";
                }
                if (dataform_05.comboBox_EventType.Text == "Conference")
                {
                    EventLabel_05.BackColor = ColorConference;
                    EventLabel_05.Text = "    Conference";
                }
                if (dataform_05.comboBox_EventType.Text == "On Site")
                {
                    EventLabel_05.BackColor = ColorOnSite;
                    EventLabel_05.Text = "    On Site";
                }
                EventLabel_05.Show();
            }
            else
            {
                EventLabel_05.Hide();
            }
        }

        private void ComboBox_EventType_SelectionChangeCommitted4(object sender, EventArgs e)
        {
            if (dataform_04.comboBox_EventType.Text != "")
            {
                if (dataform_04.comboBox_EventType.Text == "Vacation")
                {
                    EventLabel_04.BackColor = ColorVacation;
                    EventLabel_04.Text = "    Vacation";
                }
                if (dataform_04.comboBox_EventType.Text == "Holiday")
                {
                    EventLabel_04.BackColor = ColorHoliday;
                    EventLabel_04.Text = "    Holiday";
                }
                if (dataform_04.comboBox_EventType.Text == "Conference")
                {
                    EventLabel_04.BackColor = ColorConference;
                    EventLabel_04.Text = "    Conference";
                }
                if (dataform_04.comboBox_EventType.Text == "On Site")
                {
                    EventLabel_04.BackColor = ColorOnSite;
                    EventLabel_04.Text = "    On Site";
                }
                EventLabel_04.Show();
            }
            else
            {
                EventLabel_04.Hide();
            }
        }

        private void ComboBox_EventType_SelectionChangeCommitted3(object sender, EventArgs e)
        {
            if (dataform_03.comboBox_EventType.Text != "")
            {
                if (dataform_03.comboBox_EventType.Text == "Vacation")
                {
                    EventLabel_03.BackColor = ColorVacation;
                    EventLabel_03.Text = "    Vacation";
                }
                if (dataform_03.comboBox_EventType.Text == "Holiday")
                {
                    EventLabel_03.BackColor = ColorHoliday;
                    EventLabel_03.Text = "    Holiday";
                }
                if (dataform_03.comboBox_EventType.Text == "Conference")
                {
                    EventLabel_03.BackColor = ColorConference;
                    EventLabel_03.Text = "    Conference";
                }
                if (dataform_03.comboBox_EventType.Text == "On Site")
                {
                    EventLabel_03.BackColor = ColorOnSite;
                    EventLabel_03.Text = "    On Site";
                }
                EventLabel_03.Show();
            }
            else
            {
                EventLabel_03.Hide();
            }
        }

        private void ComboBox_EventType_SelectionChangeCommitted2(object sender, EventArgs e)
        {
            if (dataform_02.comboBox_EventType.Text != "")
            {
                if (dataform_02.comboBox_EventType.Text == "Vacation")
                {
                    EventLabel_02.BackColor = ColorVacation;
                    EventLabel_02.Text = "    Vacation";
                }
                if (dataform_02.comboBox_EventType.Text == "Holiday")
                {
                    EventLabel_02.BackColor = ColorHoliday;
                    EventLabel_02.Text = "    Holiday";
                }
                if (dataform_02.comboBox_EventType.Text == "Conference")
                {
                    EventLabel_02.BackColor = ColorConference;
                    EventLabel_02.Text = "    Conference";
                }
                if (dataform_02.comboBox_EventType.Text == "On Site")
                {
                    EventLabel_02.BackColor = ColorOnSite;
                    EventLabel_02.Text = "    On Site";
                }
                EventLabel_02.Show();
            }
            else
            {
                EventLabel_02.Hide();
            }
        }

        private void ComboBox_EventType_SelectionChangeCommitted1(object sender, EventArgs e)
        {
            if (dataform_01.comboBox_EventType.Text != "")
            {
                if(dataform_01.comboBox_EventType.Text == "Vacation")
                {
                    EventLabel_01.BackColor = ColorVacation;
                    EventLabel_01.Text = "    Vacation";
                }
                if (dataform_01.comboBox_EventType.Text == "Holiday")
                {
                    EventLabel_01.BackColor = ColorHoliday;
                    EventLabel_01.Text = "    Holiday";
                }
                if (dataform_01.comboBox_EventType.Text == "Conference")
                {
                    EventLabel_01.BackColor = ColorConference;
                    EventLabel_01.Text = "    Conference";
                }
                if (dataform_01.comboBox_EventType.Text == "On Site")
                {
                    EventLabel_01.BackColor = ColorOnSite;
                    EventLabel_01.Text = "    On Site";
                }
                EventLabel_01.Show();
            }
            else
            {
                EventLabel_01.Hide();
            }
        }

        public void DetectEventWidth()
        {
            #region // Expanding Width Event 1
            if (Day_Expanding_Panel_02.Visible == true && Day_Expanding_Panel_01.Bottom > Day_Expanding_Panel_02.Top && Day_Expanding_Panel_01.Top < Day_Expanding_Panel_02.Bottom)
            {
                Day_Expanding_Panel_01.Width = Day_Expanding_Panel_02.Left;
            }

            else if (Day_Expanding_Panel_03.Visible == true && Day_Expanding_Panel_01.Bottom > Day_Expanding_Panel_03.Top && Day_Expanding_Panel_01.Top < Day_Expanding_Panel_03.Bottom)
            {
                Day_Expanding_Panel_01.Width = Day_Expanding_Panel_03.Left;
            }

            else if (Day_Expanding_Panel_04.Visible == true && Day_Expanding_Panel_01.Bottom > Day_Expanding_Panel_04.Top && Day_Expanding_Panel_01.Top < Day_Expanding_Panel_04.Bottom)
            {
                Day_Expanding_Panel_01.Width = Day_Expanding_Panel_04.Left;
            }

            else if (Day_Expanding_Panel_05.Visible == true && Day_Expanding_Panel_01.Bottom > Day_Expanding_Panel_05.Top && Day_Expanding_Panel_01.Top < Day_Expanding_Panel_05.Bottom)
            {
                Day_Expanding_Panel_01.Width = Day_Expanding_Panel_05.Left;
            }

            else if (Day_Expanding_Panel_06.Visible == true && Day_Expanding_Panel_01.Bottom > Day_Expanding_Panel_06.Top && Day_Expanding_Panel_01.Top < Day_Expanding_Panel_06.Bottom)
            {
                Day_Expanding_Panel_01.Width = Day_Expanding_Panel_06.Left;
            }

            else
            {
                Day_Expanding_Panel_01.Width = Label_12AM.Width;
            }
            // End of Expanding Width
            #endregion

            #region // Expanding Width Event 2

            if (Day_Expanding_Panel_03.Visible == true && Day_Expanding_Panel_02.Bottom > Day_Expanding_Panel_03.Top && Day_Expanding_Panel_02.Top < Day_Expanding_Panel_03.Bottom)
            {
                Day_Expanding_Panel_02.Width = Day_Expanding_Panel_03.Left - Day_Expanding_Panel_02.Left;
            }

            else if (Day_Expanding_Panel_04.Visible == true && Day_Expanding_Panel_02.Bottom > Day_Expanding_Panel_04.Top && Day_Expanding_Panel_02.Top < Day_Expanding_Panel_04.Bottom)
            {
                Day_Expanding_Panel_02.Width = Day_Expanding_Panel_04.Left - Day_Expanding_Panel_02.Left;
            }

            else if (Day_Expanding_Panel_05.Visible == true && Day_Expanding_Panel_02.Bottom > Day_Expanding_Panel_05.Top && Day_Expanding_Panel_02.Top < Day_Expanding_Panel_05.Bottom)
            {
                Day_Expanding_Panel_02.Width = Day_Expanding_Panel_05.Left - Day_Expanding_Panel_02.Left;
            }

            else if (Day_Expanding_Panel_06.Visible == true && Day_Expanding_Panel_02.Bottom > Day_Expanding_Panel_06.Top && Day_Expanding_Panel_02.Top < Day_Expanding_Panel_06.Bottom)
            {
                Day_Expanding_Panel_02.Width = Day_Expanding_Panel_06.Left - Day_Expanding_Panel_02.Left;
            }

            else
            {
                Day_Expanding_Panel_02.Width = Label_12AM.Width - Day_Expanding_Panel_02.Left;
            }
            // End of Expanding Width
            #endregion
            
            #region // Expanding Width Event 3
                      
            if (Day_Expanding_Panel_04.Visible == true && Day_Expanding_Panel_03.Bottom > Day_Expanding_Panel_04.Top && Day_Expanding_Panel_03.Top < Day_Expanding_Panel_04.Bottom)
            {
                Day_Expanding_Panel_03.Width = Day_Expanding_Panel_04.Left - Day_Expanding_Panel_03.Left;
            }

            else if (Day_Expanding_Panel_05.Visible == true && Day_Expanding_Panel_03.Bottom > Day_Expanding_Panel_05.Top && Day_Expanding_Panel_03.Top < Day_Expanding_Panel_05.Bottom)
            {
                Day_Expanding_Panel_03.Width = Day_Expanding_Panel_05.Left - Day_Expanding_Panel_03.Left;
            }

            else if (Day_Expanding_Panel_06.Visible == true && Day_Expanding_Panel_03.Bottom > Day_Expanding_Panel_06.Top && Day_Expanding_Panel_03.Top < Day_Expanding_Panel_06.Bottom)
            {
                Day_Expanding_Panel_03.Width = Day_Expanding_Panel_06.Left - Day_Expanding_Panel_03.Left;
            }

            else
            {
                Day_Expanding_Panel_03.Width = Label_12AM.Width - Day_Expanding_Panel_03.Left;
            }
            // End of Expanding Width
            #endregion

            #region // Expanding Width Event 4
            
            if (Day_Expanding_Panel_05.Visible == true && Day_Expanding_Panel_04.Bottom > Day_Expanding_Panel_05.Top && Day_Expanding_Panel_04.Top < Day_Expanding_Panel_05.Bottom)
            {
                Day_Expanding_Panel_04.Width = Day_Expanding_Panel_05.Left - Day_Expanding_Panel_04.Left;
            }

            else if (Day_Expanding_Panel_06.Visible == true && Day_Expanding_Panel_04.Bottom > Day_Expanding_Panel_06.Top && Day_Expanding_Panel_04.Top < Day_Expanding_Panel_06.Bottom)
            {
                Day_Expanding_Panel_04.Width = Day_Expanding_Panel_06.Left - Day_Expanding_Panel_04.Left;
            }

            else
            {
                Day_Expanding_Panel_04.Width = Label_12AM.Width - Day_Expanding_Panel_04.Left;
            }
            // End of Expanding Width
            #endregion

            #region // Expanding Width Event 5
            
            if (Day_Expanding_Panel_06.Visible == true && Day_Expanding_Panel_05.Bottom > Day_Expanding_Panel_06.Top && Day_Expanding_Panel_05.Top < Day_Expanding_Panel_06.Bottom)
            {
                Day_Expanding_Panel_05.Width = Day_Expanding_Panel_06.Left - Day_Expanding_Panel_05.Left;
            }

            else
            {
                Day_Expanding_Panel_05.Width = Label_12AM.Width - Day_Expanding_Panel_05.Left;
            }
            // End of Expanding Width
            #endregion

            #region // Expanding Width Event 6

            if (Day_Expanding_Panel_06.Visible == true)
            {
                Day_Expanding_Panel_06.Width = Label_12AM.Width - Day_Expanding_Panel_05.Left;
            }            
            // End of Expanding Width
            #endregion
        }

        #region // Event Functions 01

        private void Day_Expanding_Panel_MouseUp_01(object sender, MouseEventArgs e)
        {
            DetectEventWidth();

            Day_Expanding_Panel_Top_Holder_01 = Day_Expanding_Panel_01.Top;

            // Control Expanding Panel Height Using Boundaries
            if(Day_Expanding_Panel_01.Top <= 20)
            {
                Day_Expanding_Panel_Top_Holder_01 = Day_Expanding_Panel_01.Top;
            }

            if(Day_Expanding_Panel_01.Top < 20)
            {
                Day_Expanding_Panel_Height_Holder_01 = Day_Expanding_Panel_01.Height;
                Day_Expanding_Panel_01.Top = 20;
                Day_Expanding_Panel_01.Height = Day_Expanding_Panel_Height_Holder_01 + Day_Expanding_Panel_Top_Holder_01 - 20;
            }

            // Mouse Event Top Move
            if (Day_Expanding_Panel_MouseSwitch_01 == 1)
            {
                Day_Expanding_Panel_01.SetBounds(Day_Expanding_Panel_01.Left, RoundEr(e.Location.Y) + RoundEr(Day_Expanding_Panel_01.Location.Y) - RoundEr(Day_Expanding_Panel_MousePoint_01.Y), Day_Expanding_Panel_01.Width, RoundEr(Day_Expanding_Panel_01.Height) - RoundEr(e.Y) + RoundEr(Day_Expanding_Panel_MousePoint_01.Y));
            }

            // Mouse Event Bottom Move
            if (Day_Expanding_Panel_MouseSwitch_01 == 2)
            {
                Day_Expanding_Panel_01.Height = Math.Min(960 - Day_Expanding_Panel_01.Location.Y, RoundEr(e.Y));
                Day_Expanding_Panel_Start_01.Y = Day_Expanding_Panel_01.Height;
            }

            // Mouse Event Grab and Move
            if (Day_Expanding_Panel_MouseSwitch_01 == 3)
            {
                Day_Expanding_Panel_01.Top = RoundEr(Day_Expanding_Panel_01.Top);
                Day_Expanding_Panel_Start_01.Y = Day_Expanding_Panel_01.Height;
            }

            Day_Expanding_Panel_MouseSwitch_01 = 0;

            if (Day_Expanding_Panel_01.Height < 20)
            {
                if (Day_Expanding_Panel_01.Top > Day_Expanding_Panel_Top_Point_01)
                {
                    Day_Expanding_Panel_01.Top = Day_Expanding_Panel_Height_Holder_01 + Day_Expanding_Panel_Top_Point_01 - 20;
                    Day_Expanding_Panel_01.Height = 20;
                }
                else
                {
                    Day_Expanding_Panel_01.Height = 20;
                }
            }
            
            // On Panel Display
            if (Day_Expanding_Panel_01.Visible)
            {
                Day_Expanding_Panel_LocGet_A_01 = RoundEr(Day_Expanding_Panel_01.Top);
                Day_Expanding_Panel_String_A_01 = TimeIntRemap(Day_Expanding_Panel_LocGet_A_01);
                Day_Expanding_Panel_LocGet_B_01 = RoundEr(Day_Expanding_Panel_01.Bottom);
                Day_Expanding_Panel_String_B_01 = TimeIntRemap(Day_Expanding_Panel_LocGet_B_01);
                Day_Expanding_Panel_01.Text = Day_Expanding_Panel_String_A_01 + " " + "to" + " " + Day_Expanding_Panel_String_B_01;
            }

            dataform_01.CheckSpan();
        }

        private void Day_Expanding_Panel_MouseDown_01(object sender, MouseEventArgs e)
        {
            DetectEventWidth();
            Point Day_Expanding_Panel_objPoint = Day_Expanding_Panel_01.PointToScreen(new Point(0, 0));
            Day_Expanding_Panel_Start_01.Y = Day_Expanding_Panel_01.Height;
            Day_Expanding_Panel_End_01.Y = Day_Expanding_Panel_01.Top;

            Day_Expanding_Panel_Height_Holder_01 = Day_Expanding_Panel_01.Height;
            Day_Expanding_Panel_Top_Point_01 = Day_Expanding_Panel_01.Top;

            // Switch Zone
            if (e.Button == MouseButtons.Left)
            {
                Day_Expanding_Panel_MousePoint_01 = e.Location;

                if (e.Y > 0 && e.Y < 4)
                {
                    Cursor.Current = Cursors.SizeNS;
                    Day_Expanding_Panel_MouseSwitch_01 = 1;
                }

                else if (e.Y > Day_Expanding_Panel_01.Height - 4 && e.Y < Day_Expanding_Panel_01.Height)
                {
                    Cursor.Current = Cursors.SizeNS;
                    Day_Expanding_Panel_MouseSwitch_01 = 2;
                }

                else if (e.Y > 4 && e.Y < Day_Expanding_Panel_01.Height - 4)
                {
                    Day_Expanding_Panel_MouseSwitch_01 = 3;
                }
            }

            // Drop Down Menu
            if (e.Button == MouseButtons.Right)
            {
                WhichControlUnderMouse = 1;
                Day_Control.dataform_eventlive = 1;
                DropDownMenuLocation =  new Point(0, RoundEr(e.Y) + (Day_Expanding_Panel_01.Top - 20));
                LabelShow();
            }
        }

        private void Day_Expanding_Panel_MouseMove_01(object sender, MouseEventArgs e)
        {
            Console.WriteLine("Mouse Moving 1");
            DetectEventWidth();
            // Event Shifting Display
            if (Day_Expanding_Panel_01.Visible)
            {
                Day_Expanding_Panel_LocGet_A_01 = RoundEr(Day_Expanding_Panel_01.Top);
                Day_Expanding_Panel_String_A_01 = TimeIntRemap(Day_Expanding_Panel_LocGet_A_01);
                Day_Expanding_Panel_LocGet_B_01 = RoundEr(Day_Expanding_Panel_01.Bottom);
                Day_Expanding_Panel_String_B_01 = TimeIntRemap(Day_Expanding_Panel_LocGet_B_01);
                Day_Expanding_Panel_01.Text = Day_Expanding_Panel_String_A_01 + " " + "to" + " " + Day_Expanding_Panel_String_B_01;

                if(Day_Expanding_Panel_String_A_01.Contains("am"))
                {
                    dataform_01.comboBox_DayFrom.SelectedItem = "AM";
                }
                else if(!Day_Expanding_Panel_String_A_01.Contains("am"))
                {
                    dataform_01.comboBox_DayFrom.SelectedItem = "PM";
                }

                if (Day_Expanding_Panel_String_B_01.Contains("am"))
                {
                    dataform_01.comboBox_DayTo.SelectedItem = "AM";
                }
                else if (!Day_Expanding_Panel_String_B_01.Contains("am"))
                {
                    dataform_01.comboBox_DayTo.SelectedItem = "PM";
                }
                
                if (Day_Expanding_Panel_String_A_01.Contains(":30"))
                {
                    dataform_01.comboBox_MinuteFrom.SelectedItem = "30";
                }
                else
                {
                    dataform_01.comboBox_MinuteFrom.SelectedItem = "00";
                }

                if (Day_Expanding_Panel_String_B_01.Contains(":30"))
                {
                    dataform_01.comboBox_MinuteTo.SelectedItem = "30";
                }
                else
                {
                    dataform_01.comboBox_MinuteTo.SelectedItem = "00";
                }

                dataform_01.comboBox_HourFrom.SelectedItem = Day_Expanding_Panel_String_A_01.
                    Replace("a", "").Replace("m", "").Replace("p", "").Replace(":30", "");
                dataform_01.comboBox_HourTo.SelectedItem = Day_Expanding_Panel_String_B_01.
                    Replace("a", "").Replace("m", "").Replace("p", "").Replace(":30", "");
            }

            // Display Cursor
            if ((e.X < Day_Expanding_Panel_01.Width && e.X > 0 && e.Y > 0 && e.Y < 4) || (e.X < Day_Expanding_Panel_01.Width && e.X > 0 && e.Y > Day_Expanding_Panel_01.Height - 4 && e.Y < Day_Expanding_Panel_01.Height))
            {
                Cursor.Current = Cursors.SizeNS;
            }

            // Mouse Event Top Move
            if (Day_Expanding_Panel_MouseSwitch_01 == 1)
            {
                Day_Expanding_Panel_01.SetBounds(Day_Expanding_Panel_01.Left, e.Location.Y + Day_Expanding_Panel_01.Location.Y - Day_Expanding_Panel_MousePoint_01.Y, Day_Expanding_Panel_01.Width, Day_Expanding_Panel_01.Height - e.Y + Day_Expanding_Panel_MousePoint_01.Y);
            }

            // Mouse Event Bottom Move
            else if (Day_Expanding_Panel_MouseSwitch_01 == 2)
            {
                Day_Expanding_Panel_01.Height = Math.Max(Math.Min(960 - Day_Expanding_Panel_01.Location.Y, e.Location.Y), 20);
            }

            // Mouse Event Grab and Move
            else if (Day_Expanding_Panel_MouseSwitch_01 == 3)
            {
                int ny = Math.Min(Math.Max((Day_Expanding_Panel_01.Location.Y - Day_Expanding_Panel_MousePoint_01.Y + e.Y),20), 960 -Day_Expanding_Panel_01.Height);
                Day_Expanding_Panel_01.Location = new Point(HoldLocation_01, ny);
            }
        }

        private void Day_Expanding_Panel_MouseDoubleClick_01(object sender, MouseEventArgs e)
        {            
            dataform_01.Show();
        }
        #endregion

        #region // Event Functions 02
        private void Day_Expanding_Panel_MouseUp_02(object sender, MouseEventArgs e)
        {
            DetectEventWidth();

            Day_Expanding_Panel_Top_Holder_02 = Day_Expanding_Panel_02.Top;

            // Control Expanding Panel Height Using Boundaries
            if (Day_Expanding_Panel_02.Top <= 20)
            {
                Day_Expanding_Panel_Top_Holder_02 = Day_Expanding_Panel_02.Top;
            }

            if (Day_Expanding_Panel_02.Top < 20)
            {
                Day_Expanding_Panel_Height_Holder_02 = Day_Expanding_Panel_02.Height;
                Day_Expanding_Panel_02.Top = 20;
                Day_Expanding_Panel_02.Height = Day_Expanding_Panel_Height_Holder_02 + Day_Expanding_Panel_Top_Holder_02 - 20;
            }

            // Mouse Event Top Move
            if (Day_Expanding_Panel_MouseSwitch_02 == 1)
            {
                Day_Expanding_Panel_02.SetBounds(Day_Expanding_Panel_02.Left, RoundEr(e.Location.Y) + RoundEr(Day_Expanding_Panel_02.Location.Y) - RoundEr(Day_Expanding_Panel_MousePoint_02.Y), Day_Expanding_Panel_02.Width, RoundEr(Day_Expanding_Panel_02.Height) - RoundEr(e.Y) + RoundEr(Day_Expanding_Panel_MousePoint_02.Y));
            }

            // Mouse Event Bottom Move
            if (Day_Expanding_Panel_MouseSwitch_02 == 2)
            {
                Day_Expanding_Panel_02.Height = Math.Min(960 - Day_Expanding_Panel_02.Location.Y, RoundEr(e.Y));
                Day_Expanding_Panel_Start_02.Y = Day_Expanding_Panel_02.Height;
            }

            // Mouse Event Grab and Move
            if (Day_Expanding_Panel_MouseSwitch_02 == 3)
            {
                Day_Expanding_Panel_02.Top = RoundEr(Day_Expanding_Panel_02.Top);
                Day_Expanding_Panel_Start_02.Y = Day_Expanding_Panel_02.Height;
            }

            Day_Expanding_Panel_MouseSwitch_02 = 0;

            if (Day_Expanding_Panel_02.Height < 20)
            {
                if (Day_Expanding_Panel_02.Top > Day_Expanding_Panel_Top_Point_02)
                {
                    Day_Expanding_Panel_02.Top = Day_Expanding_Panel_Height_Holder_02 + Day_Expanding_Panel_Top_Point_02 - 20;
                    Day_Expanding_Panel_02.Height = 20;
                }
                else
                {
                    Day_Expanding_Panel_02.Height = 20;
                }
            }

            // On Panel Display
            if (Day_Expanding_Panel_02.Visible)
            {
                Day_Expanding_Panel_LocGet_A_02 = RoundEr(Day_Expanding_Panel_01.Top);
                Day_Expanding_Panel_String_A_02 = TimeIntRemap(Day_Expanding_Panel_LocGet_A_02);
                Day_Expanding_Panel_LocGet_B_02 = RoundEr(Day_Expanding_Panel_02.Bottom);
                Day_Expanding_Panel_String_B_02 = TimeIntRemap(Day_Expanding_Panel_LocGet_B_02);
                Day_Expanding_Panel_02.Text = Day_Expanding_Panel_String_A_02 + " " + "to" + " " + Day_Expanding_Panel_String_B_02;
            }
            dataform_02.CheckSpan();
        }

        private void Day_Expanding_Panel_MouseDown_02(object sender, MouseEventArgs e)
        {
            DetectEventWidth();

            Point Day_Expanding_Panel_objPoint = Day_Expanding_Panel_02.PointToScreen(new Point(0, 0));
            Day_Expanding_Panel_Start_02.Y = Day_Expanding_Panel_02.Height;
            Day_Expanding_Panel_End_02.Y = Day_Expanding_Panel_02.Top;

            Day_Expanding_Panel_Height_Holder_02 = Day_Expanding_Panel_02.Height;
            Day_Expanding_Panel_Top_Point_02 = Day_Expanding_Panel_02.Top;

            // Switch Zone
            if (e.Button == MouseButtons.Left)
            {
                Day_Expanding_Panel_MousePoint_02 = e.Location;

                if (e.Y > 0 && e.Y < 4)
                {
                    Cursor.Current = Cursors.SizeNS;
                    Day_Expanding_Panel_MouseSwitch_02 = 1;
                }

                else if (e.Y > Day_Expanding_Panel_02.Height - 4 && e.Y < Day_Expanding_Panel_02.Height)
                {
                    Cursor.Current = Cursors.SizeNS;
                    Day_Expanding_Panel_MouseSwitch_02 = 2;
                }

                else if (e.Y > 4 && e.Y < Day_Expanding_Panel_02.Height - 4)
                {
                    Day_Expanding_Panel_MouseSwitch_02 = 3;
                }
            }

            // Drop Down Menu
            if (e.Button == MouseButtons.Right)
            {
                WhichControlUnderMouse = 2;
                Day_Control.dataform_eventlive = 2;
                DropDownMenuLocation = new Point(0, RoundEr(e.Y) + (Day_Expanding_Panel_02.Top - 20));
                LabelShow();
            }
        }

        private void Day_Expanding_Panel_MouseMove_02(object sender, MouseEventArgs e)
        {
            DetectEventWidth();

            // Event Shifting Disply
            if (Day_Expanding_Panel_02.Visible)
            {
                Day_Expanding_Panel_LocGet_A_02 = RoundEr(Day_Expanding_Panel_02.Top);
                Day_Expanding_Panel_String_A_02 = TimeIntRemap(Day_Expanding_Panel_LocGet_A_02);
                Day_Expanding_Panel_LocGet_B_02 = RoundEr(Day_Expanding_Panel_02.Bottom);
                Day_Expanding_Panel_String_B_02 = TimeIntRemap(Day_Expanding_Panel_LocGet_B_02);
                Day_Expanding_Panel_02.Text = Day_Expanding_Panel_String_A_02 + " " + "to" + " " + Day_Expanding_Panel_String_B_02;

                if (Day_Expanding_Panel_String_A_02.Contains("am"))
                {
                    dataform_02.comboBox_DayFrom.SelectedItem = "AM";
                }
                else if (!Day_Expanding_Panel_String_A_02.Contains("am"))
                {
                    dataform_02.comboBox_DayFrom.SelectedItem = "PM";
                }

                if (Day_Expanding_Panel_String_B_02.Contains("am"))
                {
                    dataform_02.comboBox_DayTo.SelectedItem = "AM";
                }
                else if (!Day_Expanding_Panel_String_B_02.Contains("am"))
                {
                    dataform_02.comboBox_DayTo.SelectedItem = "PM";
                }

                if (Day_Expanding_Panel_String_A_02.Contains(":30"))
                {
                    dataform_02.comboBox_MinuteFrom.SelectedItem = "30";
                }
                else
                {
                    dataform_02.comboBox_MinuteFrom.SelectedItem = "00";
                }

                if (Day_Expanding_Panel_String_B_02.Contains(":30"))
                {
                    dataform_02.comboBox_MinuteTo.SelectedItem = "30";
                }
                else
                {
                    dataform_02.comboBox_MinuteTo.SelectedItem = "00";
                }

                dataform_02.comboBox_HourFrom.SelectedItem = Day_Expanding_Panel_String_A_02.
                    Replace("a", "").Replace("m", "").Replace("p", "").Replace(":30", "");
                dataform_02.comboBox_HourTo.SelectedItem = Day_Expanding_Panel_String_B_02.
                    Replace("a", "").Replace("m", "").Replace("p", "").Replace(":30", "");
            }

            // Display Cursor
            if ((e.X < Day_Expanding_Panel_02.Width && e.X > 0 && e.Y > 0 && e.Y < 4) || (e.X < Day_Expanding_Panel_02.Width && e.X > 0 && e.Y > Day_Expanding_Panel_02.Height - 4 && e.Y < Day_Expanding_Panel_02.Height))
            {
                Cursor.Current = Cursors.SizeNS;
            }

            // Mouse Event Top Move
            if (Day_Expanding_Panel_MouseSwitch_02 == 1)
            {
                Day_Expanding_Panel_02.SetBounds(Day_Expanding_Panel_02.Left, e.Location.Y + Day_Expanding_Panel_02.Location.Y - Day_Expanding_Panel_MousePoint_02.Y, Day_Expanding_Panel_02.Width, Day_Expanding_Panel_02.Height - e.Y + Day_Expanding_Panel_MousePoint_02.Y);
            }

            // Mouse Event Bottom Move
            else if (Day_Expanding_Panel_MouseSwitch_02 == 2)
            {
                Day_Expanding_Panel_02.Height = Math.Max(Math.Min(960 - Day_Expanding_Panel_02.Location.Y, e.Location.Y), 20);
            }

            // Mouse Event Grab and Move
            else if (Day_Expanding_Panel_MouseSwitch_02 == 3)
            {
                 if (Day_Expanding_Panel_01.Bottom > Day_Expanding_Panel_02.Top && Day_Expanding_Panel_01.Top < Day_Expanding_Panel_02.Bottom)
                {
                    int ny = Math.Min(Math.Max((Day_Expanding_Panel_02.Location.Y - Day_Expanding_Panel_MousePoint_02.Y + e.Y), 20), 960 - Day_Expanding_Panel_02.Height);
                    Day_Expanding_Panel_02.Location = new Point(HoldLocation_02, ny);
                }
                else
                {
                    int ny = Math.Min(Math.Max((Day_Expanding_Panel_02.Location.Y - Day_Expanding_Panel_MousePoint_02.Y + e.Y), 20), 960 - Day_Expanding_Panel_02.Height);
                    Day_Expanding_Panel_02.Location = new Point(HoldLocation_02, ny);
                }           
            }
        }

        private void Day_Expanding_Panel_MouseDoubleClick_02(object sender, MouseEventArgs e)
        {
            dataform_02.Show();
        }
        #endregion

        #region // Event Functions 03
        private void Day_Expanding_Panel_MouseUp_03(object sender, MouseEventArgs e)
        {
            DetectEventWidth();

            Day_Expanding_Panel_Top_Holder_03 = Day_Expanding_Panel_03.Top;

            // Control Expanding Panel Height Using Boundaries
            if (Day_Expanding_Panel_03.Top <= 20)
            {
                Day_Expanding_Panel_Top_Holder_03 = Day_Expanding_Panel_03.Top;
            }

            if (Day_Expanding_Panel_03.Top < 20)
            {
                Day_Expanding_Panel_Height_Holder_03 = Day_Expanding_Panel_03.Height;
                Day_Expanding_Panel_03.Top = 20;
                Day_Expanding_Panel_03.Height = Day_Expanding_Panel_Height_Holder_03 + Day_Expanding_Panel_Top_Holder_03 - 20;
            }

            // Mouse Event Top Move
            if (Day_Expanding_Panel_MouseSwitch_03 == 1)
            {
                Day_Expanding_Panel_03.SetBounds(Day_Expanding_Panel_03.Left, RoundEr(e.Location.Y) + RoundEr(Day_Expanding_Panel_03.Location.Y) - RoundEr(Day_Expanding_Panel_MousePoint_03.Y), Day_Expanding_Panel_03.Width, RoundEr(Day_Expanding_Panel_03.Height) - RoundEr(e.Y) + RoundEr(Day_Expanding_Panel_MousePoint_03.Y));
            }

            // Mouse Event Bottom Move
            if (Day_Expanding_Panel_MouseSwitch_03 == 2)
            {
                Day_Expanding_Panel_03.Height = Math.Min(960 - Day_Expanding_Panel_03.Location.Y, RoundEr(e.Y));
                Day_Expanding_Panel_Start_03.Y = Day_Expanding_Panel_03.Height;
            }

            // Mouse Event Grab and Move
            if (Day_Expanding_Panel_MouseSwitch_03 == 3)
            {
                Day_Expanding_Panel_03.Top = RoundEr(Day_Expanding_Panel_03.Top);
                Day_Expanding_Panel_Start_03.Y = Day_Expanding_Panel_03.Height;
            }

            Day_Expanding_Panel_MouseSwitch_03 = 0;

            if (Day_Expanding_Panel_03.Height < 20)
            {
                if (Day_Expanding_Panel_03.Top > Day_Expanding_Panel_Top_Point_03)
                {
                    Day_Expanding_Panel_03.Top = Day_Expanding_Panel_Height_Holder_03 + Day_Expanding_Panel_Top_Point_03 - 20;
                    Day_Expanding_Panel_03.Height = 20;
                }
                else
                {
                    Day_Expanding_Panel_03.Height = 20;
                }
            }

            // On Panel Display
            if (Day_Expanding_Panel_03.Visible)
            {
                Day_Expanding_Panel_LocGet_A_03 = RoundEr(Day_Expanding_Panel_01.Top);
                Day_Expanding_Panel_String_A_03 = TimeIntRemap(Day_Expanding_Panel_LocGet_A_03);
                Day_Expanding_Panel_LocGet_B_03 = RoundEr(Day_Expanding_Panel_03.Bottom);
                Day_Expanding_Panel_String_B_03 = TimeIntRemap(Day_Expanding_Panel_LocGet_B_03);
                Day_Expanding_Panel_03.Text = Day_Expanding_Panel_String_A_03 + " " + "to" + " " + Day_Expanding_Panel_String_B_03;
            }
            dataform_03.CheckSpan();
        }

        private void Day_Expanding_Panel_MouseDown_03(object sender, MouseEventArgs e)
        {
            DetectEventWidth();

            Point Day_Expanding_Panel_objPoint = Day_Expanding_Panel_03.PointToScreen(new Point(0, 0));
            Day_Expanding_Panel_Start_03.Y = Day_Expanding_Panel_03.Height;
            Day_Expanding_Panel_End_03.Y = Day_Expanding_Panel_03.Top;

            Day_Expanding_Panel_Height_Holder_03 = Day_Expanding_Panel_03.Height;
            Day_Expanding_Panel_Top_Point_03 = Day_Expanding_Panel_03.Top;

            // Switch Zone
            if (e.Button == MouseButtons.Left)
            {
                Day_Expanding_Panel_MousePoint_03 = e.Location;

                if (e.Y > 0 && e.Y < 4)
                {
                    Cursor.Current = Cursors.SizeNS;
                    Day_Expanding_Panel_MouseSwitch_03 = 1;
                }

                else if (e.Y > Day_Expanding_Panel_03.Height - 4 && e.Y < Day_Expanding_Panel_03.Height)
                {
                    Cursor.Current = Cursors.SizeNS;
                    Day_Expanding_Panel_MouseSwitch_03 = 2;
                }

                else if (e.Y > 4 && e.Y < Day_Expanding_Panel_03.Height - 4)
                {
                    Day_Expanding_Panel_MouseSwitch_03 = 3;
                }
            }

            // Drop Down Menu
            if (e.Button == MouseButtons.Right)
            {
                WhichControlUnderMouse = 3;
                Day_Control.dataform_eventlive = 3;
                DropDownMenuLocation = new Point(0, RoundEr(e.Y) + (Day_Expanding_Panel_03.Top - 20));
                LabelShow();
            }
        }

        private void Day_Expanding_Panel_MouseMove_03(object sender, MouseEventArgs e)
        {
            DetectEventWidth();

            // Event Shifting Disply
            if (Day_Expanding_Panel_03.Visible)
            {
                Day_Expanding_Panel_LocGet_A_03 = RoundEr(Day_Expanding_Panel_03.Top);
                Day_Expanding_Panel_String_A_03 = TimeIntRemap(Day_Expanding_Panel_LocGet_A_03);
                Day_Expanding_Panel_LocGet_B_03 = RoundEr(Day_Expanding_Panel_03.Bottom);
                Day_Expanding_Panel_String_B_03 = TimeIntRemap(Day_Expanding_Panel_LocGet_B_03);
                Day_Expanding_Panel_03.Text = Day_Expanding_Panel_String_A_03 + " " + "to" + " " + Day_Expanding_Panel_String_B_03;

                if (Day_Expanding_Panel_String_A_03.Contains("am"))
                {
                    dataform_03.comboBox_DayFrom.SelectedItem = "AM";
                }
                else if (!Day_Expanding_Panel_String_A_03.Contains("am"))
                {
                    dataform_03.comboBox_DayFrom.SelectedItem = "PM";
                }

                if (Day_Expanding_Panel_String_B_03.Contains("am"))
                {
                    dataform_03.comboBox_DayTo.SelectedItem = "AM";
                }
                else if (!Day_Expanding_Panel_String_B_03.Contains("am"))
                {
                    dataform_03.comboBox_DayTo.SelectedItem = "PM";
                }

                if (Day_Expanding_Panel_String_A_03.Contains(":30"))
                {
                    dataform_03.comboBox_MinuteFrom.SelectedItem = "30";
                }
                else
                {
                    dataform_03.comboBox_MinuteFrom.SelectedItem = "00";
                }

                if (Day_Expanding_Panel_String_B_03.Contains(":30"))
                {
                    dataform_03.comboBox_MinuteTo.SelectedItem = "30";
                }
                else
                {
                    dataform_03.comboBox_MinuteTo.SelectedItem = "00";
                }

                dataform_03.comboBox_HourFrom.SelectedItem = Day_Expanding_Panel_String_A_03.
                    Replace("a", "").Replace("m", "").Replace("p", "").Replace(":30", "");
                dataform_03.comboBox_HourTo.SelectedItem = Day_Expanding_Panel_String_B_03.
                    Replace("a", "").Replace("m", "").Replace("p", "").Replace(":30", "");
            }

            // Display Cursor
            if ((e.X < Day_Expanding_Panel_03.Width && e.X > 0 && e.Y > 0 && e.Y < 4) || (e.X < Day_Expanding_Panel_03.Width && e.X > 0 && e.Y > Day_Expanding_Panel_03.Height - 4 && e.Y < Day_Expanding_Panel_03.Height))
            {
                Cursor.Current = Cursors.SizeNS;
            }

            // Mouse Event Top Move
            if (Day_Expanding_Panel_MouseSwitch_03 == 1)
            {
                Day_Expanding_Panel_03.SetBounds(Day_Expanding_Panel_03.Left, e.Location.Y + Day_Expanding_Panel_03.Location.Y - Day_Expanding_Panel_MousePoint_03.Y, Day_Expanding_Panel_03.Width, Day_Expanding_Panel_03.Height - e.Y + Day_Expanding_Panel_MousePoint_03.Y);
            }

            // Mouse Event Bottom Move
            else if (Day_Expanding_Panel_MouseSwitch_03 == 2)
            {
                Day_Expanding_Panel_03.Height = Math.Max(Math.Min(960 - Day_Expanding_Panel_03.Location.Y, e.Location.Y), 20);
            }

            // Mouse Event Grab and Move
            else if (Day_Expanding_Panel_MouseSwitch_03 == 3)
            {
                if (Day_Expanding_Panel_01.Bottom > Day_Expanding_Panel_03.Top && Day_Expanding_Panel_01.Top < Day_Expanding_Panel_03.Bottom)
                {
                    int ny = Math.Min(Math.Max((Day_Expanding_Panel_03.Location.Y - Day_Expanding_Panel_MousePoint_03.Y + e.Y), 20), 960 - Day_Expanding_Panel_03.Height);
                    Day_Expanding_Panel_03.Location = new Point(HoldLocation_03, ny);
                }
                else
                {
                    int ny = Math.Min(Math.Max((Day_Expanding_Panel_03.Location.Y - Day_Expanding_Panel_MousePoint_03.Y + e.Y), 20), 960 - Day_Expanding_Panel_03.Height);
                    Day_Expanding_Panel_03.Location = new Point(HoldLocation_03, ny);
                }
            }
        }

        private void Day_Expanding_Panel_MouseDoubleClick_03(object sender, MouseEventArgs e)
        {
            dataform_03.Show();
        }
        #endregion

        #region // Event Functions 04
        private void Day_Expanding_Panel_MouseUp_04(object sender, MouseEventArgs e)
        {
            DetectEventWidth();

            Day_Expanding_Panel_Top_Holder_04 = Day_Expanding_Panel_04.Top;

            // Control Expanding Panel Height Using Boundaries
            if (Day_Expanding_Panel_04.Top <= 20)
            {
                Day_Expanding_Panel_Top_Holder_04 = Day_Expanding_Panel_04.Top;
            }

            if (Day_Expanding_Panel_04.Top < 20)
            {
                Day_Expanding_Panel_Height_Holder_04 = Day_Expanding_Panel_04.Height;
                Day_Expanding_Panel_04.Top = 20;
                Day_Expanding_Panel_04.Height = Day_Expanding_Panel_Height_Holder_04 + Day_Expanding_Panel_Top_Holder_04 - 20;
            }

            // Mouse Event Top Move
            if (Day_Expanding_Panel_MouseSwitch_04 == 1)
            {
                Day_Expanding_Panel_04.SetBounds(Day_Expanding_Panel_04.Left, RoundEr(e.Location.Y) + RoundEr(Day_Expanding_Panel_04.Location.Y) - RoundEr(Day_Expanding_Panel_MousePoint_04.Y), Day_Expanding_Panel_04.Width, RoundEr(Day_Expanding_Panel_04.Height) - RoundEr(e.Y) + RoundEr(Day_Expanding_Panel_MousePoint_04.Y));
            }

            // Mouse Event Bottom Move
            if (Day_Expanding_Panel_MouseSwitch_04 == 2)
            {
                Day_Expanding_Panel_04.Height = Math.Min(960 - Day_Expanding_Panel_04.Location.Y, RoundEr(e.Y));
                Day_Expanding_Panel_Start_04.Y = Day_Expanding_Panel_04.Height;
            }

            // Mouse Event Grab and Move
            if (Day_Expanding_Panel_MouseSwitch_04 == 3)
            {
                Day_Expanding_Panel_04.Top = RoundEr(Day_Expanding_Panel_04.Top);
                Day_Expanding_Panel_Start_04.Y = Day_Expanding_Panel_04.Height;
            }

            Day_Expanding_Panel_MouseSwitch_04 = 0;

            if (Day_Expanding_Panel_04.Height < 20)
            {
                if (Day_Expanding_Panel_04.Top > Day_Expanding_Panel_Top_Point_04)
                {
                    Day_Expanding_Panel_04.Top = Day_Expanding_Panel_Height_Holder_04 + Day_Expanding_Panel_Top_Point_04 - 20;
                    Day_Expanding_Panel_04.Height = 20;
                }
                else
                {
                    Day_Expanding_Panel_04.Height = 20;
                }
            }

            // On Panel Display
            if (Day_Expanding_Panel_04.Visible)
            {
                Day_Expanding_Panel_LocGet_A_04 = RoundEr(Day_Expanding_Panel_01.Top);
                Day_Expanding_Panel_String_A_04 = TimeIntRemap(Day_Expanding_Panel_LocGet_A_04);
                Day_Expanding_Panel_LocGet_B_04 = RoundEr(Day_Expanding_Panel_04.Bottom);
                Day_Expanding_Panel_String_B_04 = TimeIntRemap(Day_Expanding_Panel_LocGet_B_04);
                Day_Expanding_Panel_04.Text = Day_Expanding_Panel_String_A_04 + " " + "to" + " " + Day_Expanding_Panel_String_B_04;
            }
            dataform_04.CheckSpan();
        }

        private void Day_Expanding_Panel_MouseDown_04(object sender, MouseEventArgs e)
        {
            DetectEventWidth();

            Point Day_Expanding_Panel_objPoint = Day_Expanding_Panel_04.PointToScreen(new Point(0, 0));
            Day_Expanding_Panel_Start_04.Y = Day_Expanding_Panel_04.Height;
            Day_Expanding_Panel_End_04.Y = Day_Expanding_Panel_04.Top;

            Day_Expanding_Panel_Height_Holder_04 = Day_Expanding_Panel_04.Height;
            Day_Expanding_Panel_Top_Point_04 = Day_Expanding_Panel_04.Top;

            // Switch Zone
            if (e.Button == MouseButtons.Left)
            {
                Day_Expanding_Panel_MousePoint_04 = e.Location;

                if (e.Y > 0 && e.Y < 4)
                {
                    Cursor.Current = Cursors.SizeNS;
                    Day_Expanding_Panel_MouseSwitch_04 = 1;
                }

                else if (e.Y > Day_Expanding_Panel_04.Height - 4 && e.Y < Day_Expanding_Panel_04.Height)
                {
                    Cursor.Current = Cursors.SizeNS;
                    Day_Expanding_Panel_MouseSwitch_04 = 2;
                }

                else if (e.Y > 4 && e.Y < Day_Expanding_Panel_04.Height - 4)
                {
                    Day_Expanding_Panel_MouseSwitch_04 = 3;
                }
            }

            // Drop Down Menu
            if (e.Button == MouseButtons.Right)
            {
                WhichControlUnderMouse = 4;
                Day_Control.dataform_eventlive = 4;
                DropDownMenuLocation = new Point(0, RoundEr(e.Y) + (Day_Expanding_Panel_04.Top - 20));
                LabelShow();
            }
        }

        private void Day_Expanding_Panel_MouseMove_04(object sender, MouseEventArgs e)
        {
            DetectEventWidth();

            // Event Shifting Disply
            if (Day_Expanding_Panel_04.Visible)
            {
                Day_Expanding_Panel_LocGet_A_04 = RoundEr(Day_Expanding_Panel_04.Top);
                Day_Expanding_Panel_String_A_04 = TimeIntRemap(Day_Expanding_Panel_LocGet_A_04);
                Day_Expanding_Panel_LocGet_B_04 = RoundEr(Day_Expanding_Panel_04.Bottom);
                Day_Expanding_Panel_String_B_04 = TimeIntRemap(Day_Expanding_Panel_LocGet_B_04);
                Day_Expanding_Panel_04.Text = Day_Expanding_Panel_String_A_04 + " " + "to" + " " + Day_Expanding_Panel_String_B_04;

                if (Day_Expanding_Panel_String_A_04.Contains("am"))
                {
                    dataform_04.comboBox_DayFrom.SelectedItem = "AM";
                }
                else if (!Day_Expanding_Panel_String_A_04.Contains("am"))
                {
                    dataform_04.comboBox_DayFrom.SelectedItem = "PM";
                }

                if (Day_Expanding_Panel_String_B_04.Contains("am"))
                {
                    dataform_04.comboBox_DayTo.SelectedItem = "AM";
                }
                else if (!Day_Expanding_Panel_String_B_04.Contains("am"))
                {
                    dataform_04.comboBox_DayTo.SelectedItem = "PM";
                }

                if (Day_Expanding_Panel_String_A_04.Contains(":30"))
                {
                    dataform_04.comboBox_MinuteFrom.SelectedItem = "30";
                }
                else
                {
                    dataform_04.comboBox_MinuteFrom.SelectedItem = "00";
                }

                if (Day_Expanding_Panel_String_B_04.Contains(":30"))
                {
                    dataform_04.comboBox_MinuteTo.SelectedItem = "30";
                }
                else
                {
                    dataform_04.comboBox_MinuteTo.SelectedItem = "00";
                }

                dataform_04.comboBox_HourFrom.SelectedItem = Day_Expanding_Panel_String_A_04.
                    Replace("a", "").Replace("m", "").Replace("p", "").Replace(":30", "");
                dataform_04.comboBox_HourTo.SelectedItem = Day_Expanding_Panel_String_B_04.
                    Replace("a", "").Replace("m", "").Replace("p", "").Replace(":30", "");
            }

            // Display Cursor
            if ((e.X < Day_Expanding_Panel_04.Width && e.X > 0 && e.Y > 0 && e.Y < 4) || (e.X < Day_Expanding_Panel_04.Width && e.X > 0 && e.Y > Day_Expanding_Panel_04.Height - 4 && e.Y < Day_Expanding_Panel_04.Height))
            {
                Cursor.Current = Cursors.SizeNS;
            }

            // Mouse Event Top Move
            if (Day_Expanding_Panel_MouseSwitch_04 == 1)
            {
                Day_Expanding_Panel_04.SetBounds(Day_Expanding_Panel_04.Left, e.Location.Y + Day_Expanding_Panel_04.Location.Y - Day_Expanding_Panel_MousePoint_04.Y, Day_Expanding_Panel_04.Width, Day_Expanding_Panel_04.Height - e.Y + Day_Expanding_Panel_MousePoint_04.Y);
            }

            // Mouse Event Bottom Move
            else if (Day_Expanding_Panel_MouseSwitch_04 == 2)
            {
                Day_Expanding_Panel_04.Height = Math.Max(Math.Min(960 - Day_Expanding_Panel_04.Location.Y, e.Location.Y), 20);
            }

            // Mouse Event Grab and Move
            else if (Day_Expanding_Panel_MouseSwitch_04 == 3)
            {
                if (Day_Expanding_Panel_01.Bottom > Day_Expanding_Panel_04.Top && Day_Expanding_Panel_01.Top < Day_Expanding_Panel_04.Bottom)
                {
                    int ny = Math.Min(Math.Max((Day_Expanding_Panel_04.Location.Y - Day_Expanding_Panel_MousePoint_04.Y + e.Y), 20), 960 - Day_Expanding_Panel_04.Height);
                    Day_Expanding_Panel_04.Location = new Point(HoldLocation_04, ny);
                }
                else
                {
                    int ny = Math.Min(Math.Max((Day_Expanding_Panel_04.Location.Y - Day_Expanding_Panel_MousePoint_04.Y + e.Y), 20), 960 - Day_Expanding_Panel_04.Height);
                    Day_Expanding_Panel_04.Location = new Point(HoldLocation_04, ny);
                }
            }
        }

        private void Day_Expanding_Panel_MouseDoubleClick_04(object sender, MouseEventArgs e)
        {
            dataform_04.Show();
        }
        #endregion

        #region // Event Functions 05
        private void Day_Expanding_Panel_MouseUp_05(object sender, MouseEventArgs e)
        {

            Day_Expanding_Panel_Top_Holder_05 = Day_Expanding_Panel_05.Top;

            // Control Expanding Panel Height Using Boundaries
            if (Day_Expanding_Panel_05.Top <= 20)
            {
                Day_Expanding_Panel_Top_Holder_05 = Day_Expanding_Panel_05.Top;
            }

            if (Day_Expanding_Panel_05.Top < 20)
            {
                Day_Expanding_Panel_Height_Holder_05 = Day_Expanding_Panel_05.Height;
                Day_Expanding_Panel_05.Top = 20;
                Day_Expanding_Panel_05.Height = Day_Expanding_Panel_Height_Holder_05 + Day_Expanding_Panel_Top_Holder_05 - 20;
            }

            // Mouse Event Top Move
            if (Day_Expanding_Panel_MouseSwitch_05 == 1)
            {
                Day_Expanding_Panel_05.SetBounds(Day_Expanding_Panel_05.Left, RoundEr(e.Location.Y) + RoundEr(Day_Expanding_Panel_05.Location.Y) - RoundEr(Day_Expanding_Panel_MousePoint_05.Y), Day_Expanding_Panel_05.Width, RoundEr(Day_Expanding_Panel_05.Height) - RoundEr(e.Y) + RoundEr(Day_Expanding_Panel_MousePoint_05.Y));
            }

            // Mouse Event Bottom Move
            if (Day_Expanding_Panel_MouseSwitch_05 == 2)
            {
                Day_Expanding_Panel_05.Height = Math.Min(960 - Day_Expanding_Panel_05.Location.Y, RoundEr(e.Y));
                Day_Expanding_Panel_Start_05.Y = Day_Expanding_Panel_05.Height;
            }

            // Mouse Event Grab and Move
            if (Day_Expanding_Panel_MouseSwitch_05 == 3)
            {
                Day_Expanding_Panel_05.Top = RoundEr(Day_Expanding_Panel_05.Top);
                Day_Expanding_Panel_Start_05.Y = Day_Expanding_Panel_05.Height;
            }

            Day_Expanding_Panel_MouseSwitch_05 = 0;

            if (Day_Expanding_Panel_05.Height < 20)
            {
                if (Day_Expanding_Panel_05.Top > Day_Expanding_Panel_Top_Point_05)
                {
                    Day_Expanding_Panel_05.Top = Day_Expanding_Panel_Height_Holder_05 + Day_Expanding_Panel_Top_Point_05 - 20;
                    Day_Expanding_Panel_05.Height = 20;
                }
                else
                {
                    Day_Expanding_Panel_05.Height = 20;
                }
            }

            // On Panel Display
            if (Day_Expanding_Panel_05.Visible)
            {
                Day_Expanding_Panel_LocGet_A_05 = RoundEr(Day_Expanding_Panel_01.Top);
                Day_Expanding_Panel_String_A_05 = TimeIntRemap(Day_Expanding_Panel_LocGet_A_05);
                Day_Expanding_Panel_LocGet_B_05 = RoundEr(Day_Expanding_Panel_05.Bottom);
                Day_Expanding_Panel_String_B_05 = TimeIntRemap(Day_Expanding_Panel_LocGet_B_05);
                Day_Expanding_Panel_05.Text = Day_Expanding_Panel_String_A_05 + " " + "to" + " " + Day_Expanding_Panel_String_B_05;
            }
            dataform_01.CheckSpan();
        }

        private void Day_Expanding_Panel_MouseDown_05(object sender, MouseEventArgs e)
        {
            DetectEventWidth();

            Point Day_Expanding_Panel_objPoint = Day_Expanding_Panel_05.PointToScreen(new Point(0, 0));
            Day_Expanding_Panel_Start_05.Y = Day_Expanding_Panel_05.Height;
            Day_Expanding_Panel_End_05.Y = Day_Expanding_Panel_05.Top;

            Day_Expanding_Panel_Height_Holder_05 = Day_Expanding_Panel_05.Height;
            Day_Expanding_Panel_Top_Point_05 = Day_Expanding_Panel_05.Top;

            // Switch Zone
            if (e.Button == MouseButtons.Left)
            {
                Day_Expanding_Panel_MousePoint_05 = e.Location;

                if (e.Y > 0 && e.Y < 4)
                {
                    Cursor.Current = Cursors.SizeNS;
                    Day_Expanding_Panel_MouseSwitch_05 = 1;
                }

                else if (e.Y > Day_Expanding_Panel_05.Height - 4 && e.Y < Day_Expanding_Panel_05.Height)
                {
                    Cursor.Current = Cursors.SizeNS;
                    Day_Expanding_Panel_MouseSwitch_05 = 2;
                }

                else if (e.Y > 4 && e.Y < Day_Expanding_Panel_05.Height - 4)
                {
                    Day_Expanding_Panel_MouseSwitch_05 = 3;
                }
            }

            // Drop Down Menu
            if (e.Button == MouseButtons.Right)
            {
                WhichControlUnderMouse = 5;
                Day_Control.dataform_eventlive = 5;
                DropDownMenuLocation = new Point(0, RoundEr(e.Y) + (Day_Expanding_Panel_05.Top - 20));
                LabelShow();
            }
        }

        private void Day_Expanding_Panel_MouseMove_05(object sender, MouseEventArgs e)
        {
            DetectEventWidth();

            // Event Shifting Disply
            if (Day_Expanding_Panel_05.Visible)
            {
                Day_Expanding_Panel_LocGet_A_05 = RoundEr(Day_Expanding_Panel_05.Top);
                Day_Expanding_Panel_String_A_05 = TimeIntRemap(Day_Expanding_Panel_LocGet_A_05);
                Day_Expanding_Panel_LocGet_B_05 = RoundEr(Day_Expanding_Panel_05.Bottom);
                Day_Expanding_Panel_String_B_05 = TimeIntRemap(Day_Expanding_Panel_LocGet_B_05);
                Day_Expanding_Panel_05.Text = Day_Expanding_Panel_String_A_05 + " " + "to" + " " + Day_Expanding_Panel_String_B_05;

                if (Day_Expanding_Panel_String_A_05.Contains("am"))
                {
                    dataform_05.comboBox_DayFrom.SelectedItem = "AM";
                }
                else if (!Day_Expanding_Panel_String_A_05.Contains("am"))
                {
                    dataform_05.comboBox_DayFrom.SelectedItem = "PM";
                }

                if (Day_Expanding_Panel_String_B_05.Contains("am"))
                {
                    dataform_05.comboBox_DayTo.SelectedItem = "AM";
                }
                else if (!Day_Expanding_Panel_String_B_05.Contains("am"))
                {
                    dataform_05.comboBox_DayTo.SelectedItem = "PM";
                }

                if (Day_Expanding_Panel_String_A_05.Contains(":30"))
                {
                    dataform_05.comboBox_MinuteFrom.SelectedItem = "30";
                }
                else
                {
                    dataform_05.comboBox_MinuteFrom.SelectedItem = "00";
                }

                if (Day_Expanding_Panel_String_B_05.Contains(":30"))
                {
                    dataform_05.comboBox_MinuteTo.SelectedItem = "30";
                }
                else
                {
                    dataform_05.comboBox_MinuteTo.SelectedItem = "00";
                }

                dataform_05.comboBox_HourFrom.SelectedItem = Day_Expanding_Panel_String_A_05.
                    Replace("a", "").Replace("m", "").Replace("p", "").Replace(":30", "");
                dataform_05.comboBox_HourTo.SelectedItem = Day_Expanding_Panel_String_B_05.
                    Replace("a", "").Replace("m", "").Replace("p", "").Replace(":30", "");
            }

            // Display Cursor
            if ((e.X < Day_Expanding_Panel_05.Width && e.X > 0 && e.Y > 0 && e.Y < 4) || (e.X < Day_Expanding_Panel_05.Width && e.X > 0 && e.Y > Day_Expanding_Panel_05.Height - 4 && e.Y < Day_Expanding_Panel_05.Height))
            {
                Cursor.Current = Cursors.SizeNS;
            }

            // Mouse Event Top Move
            if (Day_Expanding_Panel_MouseSwitch_05 == 1)
            {
                Day_Expanding_Panel_05.SetBounds(Day_Expanding_Panel_05.Left, e.Location.Y + Day_Expanding_Panel_05.Location.Y - Day_Expanding_Panel_MousePoint_05.Y, Day_Expanding_Panel_05.Width, Day_Expanding_Panel_05.Height - e.Y + Day_Expanding_Panel_MousePoint_05.Y);
            }

            // Mouse Event Bottom Move
            else if (Day_Expanding_Panel_MouseSwitch_05 == 2)
            {
                Day_Expanding_Panel_05.Height = Math.Max(Math.Min(960 - Day_Expanding_Panel_05.Location.Y, e.Location.Y), 20);
            }

            // Mouse Event Grab and Move
            else if (Day_Expanding_Panel_MouseSwitch_05 == 3)
            {
                if (Day_Expanding_Panel_01.Bottom > Day_Expanding_Panel_05.Top && Day_Expanding_Panel_01.Top < Day_Expanding_Panel_05.Bottom)
                {
                    int ny = Math.Min(Math.Max((Day_Expanding_Panel_05.Location.Y - Day_Expanding_Panel_MousePoint_05.Y + e.Y), 20), 960 - Day_Expanding_Panel_05.Height);
                    Day_Expanding_Panel_05.Location = new Point(HoldLocation_05, ny);
                }
                else
                {
                    int ny = Math.Min(Math.Max((Day_Expanding_Panel_05.Location.Y - Day_Expanding_Panel_MousePoint_05.Y + e.Y), 20), 960 - Day_Expanding_Panel_05.Height);
                    Day_Expanding_Panel_05.Location = new Point(HoldLocation_05, ny);
                }
            }
        }

        private void Day_Expanding_Panel_MouseDoubleClick_05(object sender, MouseEventArgs e)
        {
            dataform_05.Show();
        }
        #endregion

        #region // Event Functions 06
        private void Day_Expanding_Panel_MouseUp_06(object sender, MouseEventArgs e)
        {
            Day_Expanding_Panel_Top_Holder_06 = Day_Expanding_Panel_06.Top;

            // Control Expanding Panel Height Using Boundaries
            if (Day_Expanding_Panel_06.Top <= 20)
            {
                Day_Expanding_Panel_Top_Holder_06 = Day_Expanding_Panel_06.Top;
            }

            if (Day_Expanding_Panel_06.Top < 20)
            {
                Day_Expanding_Panel_Height_Holder_06 = Day_Expanding_Panel_06.Height;
                Day_Expanding_Panel_06.Top = 20;
                Day_Expanding_Panel_06.Height = Day_Expanding_Panel_Height_Holder_06 + Day_Expanding_Panel_Top_Holder_06 - 20;
            }

            // Mouse Event Top Move
            if (Day_Expanding_Panel_MouseSwitch_06 == 1)
            {
                Day_Expanding_Panel_06.SetBounds(Day_Expanding_Panel_06.Left, RoundEr(e.Location.Y) + RoundEr(Day_Expanding_Panel_06.Location.Y) - RoundEr(Day_Expanding_Panel_MousePoint_06.Y), Day_Expanding_Panel_06.Width, RoundEr(Day_Expanding_Panel_06.Height) - RoundEr(e.Y) + RoundEr(Day_Expanding_Panel_MousePoint_06.Y));
            }

            // Mouse Event Bottom Move
            if (Day_Expanding_Panel_MouseSwitch_06 == 2)
            {
                Day_Expanding_Panel_06.Height = Math.Min(960 - Day_Expanding_Panel_06.Location.Y, RoundEr(e.Y));
                Day_Expanding_Panel_Start_06.Y = Day_Expanding_Panel_06.Height;
            }

            // Mouse Event Grab and Move
            if (Day_Expanding_Panel_MouseSwitch_06 == 3)
            {
                Day_Expanding_Panel_06.Top = RoundEr(Day_Expanding_Panel_06.Top);
                Day_Expanding_Panel_Start_06.Y = Day_Expanding_Panel_06.Height;
            }

            Day_Expanding_Panel_MouseSwitch_06 = 0;

            if (Day_Expanding_Panel_06.Height < 20)
            {
                if (Day_Expanding_Panel_06.Top > Day_Expanding_Panel_Top_Point_06)
                {
                    Day_Expanding_Panel_06.Top = Day_Expanding_Panel_Height_Holder_06 + Day_Expanding_Panel_Top_Point_06 - 20;
                    Day_Expanding_Panel_06.Height = 20;
                }
                else
                {
                    Day_Expanding_Panel_06.Height = 20;
                }
            }

            // On Panel Display
            if (Day_Expanding_Panel_06.Visible)
            {
                Day_Expanding_Panel_LocGet_A_06 = RoundEr(Day_Expanding_Panel_01.Top);
                Day_Expanding_Panel_String_A_06 = TimeIntRemap(Day_Expanding_Panel_LocGet_A_06);
                Day_Expanding_Panel_LocGet_B_06 = RoundEr(Day_Expanding_Panel_06.Bottom);
                Day_Expanding_Panel_String_B_06 = TimeIntRemap(Day_Expanding_Panel_LocGet_B_06);
                Day_Expanding_Panel_06.Text = Day_Expanding_Panel_String_A_06 + " " + "to" + " " + Day_Expanding_Panel_String_B_06;
            }
            DetectEventWidth();
        }

        private void Day_Expanding_Panel_MouseDown_06(object sender, MouseEventArgs e)
        {
            DetectEventWidth();

            Point Day_Expanding_Panel_objPoint = Day_Expanding_Panel_06.PointToScreen(new Point(0, 0));
            Day_Expanding_Panel_Start_06.Y = Day_Expanding_Panel_06.Height;
            Day_Expanding_Panel_End_06.Y = Day_Expanding_Panel_06.Top;

            Day_Expanding_Panel_Height_Holder_06 = Day_Expanding_Panel_06.Height;
            Day_Expanding_Panel_Top_Point_06 = Day_Expanding_Panel_06.Top;

            // Switch Zone
            if (e.Button == MouseButtons.Left)
            {
                Day_Expanding_Panel_MousePoint_06 = e.Location;

                if (e.Y > 0 && e.Y < 4)
                {
                    Cursor.Current = Cursors.SizeNS;
                    Day_Expanding_Panel_MouseSwitch_06 = 1;
                }

                else if (e.Y > Day_Expanding_Panel_06.Height - 4 && e.Y < Day_Expanding_Panel_06.Height)
                {
                    Cursor.Current = Cursors.SizeNS;
                    Day_Expanding_Panel_MouseSwitch_06 = 2;
                }

                else if (e.Y > 4 && e.Y < Day_Expanding_Panel_06.Height - 4)
                {
                    Day_Expanding_Panel_MouseSwitch_06 = 3;
                }
            }

            // Drop Down Menu
            if (e.Button == MouseButtons.Right)
            {
                WhichControlUnderMouse = 6;
                Day_Control.dataform_eventlive = 6;
                DropDownMenuLocation = new Point(0, RoundEr(e.Y) + (Day_Expanding_Panel_06.Top - 20));
                LabelShow();
            }
        }

        #endregion

        private string TimeIntRemap(int Day_ExpandingIntInput)
        {          
            int x_in;
            x_in = Day_ExpandingIntInput;
            #region // 12 Hour AM
            if(x_in == null)
            {
                x_out = "";
            }
            if (x_in == 20)
            {
                x_out = "12am";
            }
            if (x_in == 40)
            {
                x_out = "12:30am";
            }
            if (x_in == 60)
            {
                x_out = "1am";
            }
            if (x_in == 80)
            {
                x_out = "1:30am";
            }
            if (x_in == 100)
            {
                x_out = "2am";
            }
            if (x_in == 120)
            {
                x_out = "2:30am";
            }
            if (x_in == 140)
            {
                x_out = "3am";
            }
            if (x_in == 160)
            {
                x_out = "3:30am";
            }
            //
            if (x_in == 180)
            {
                x_out = "4am";
            }
            if (x_in == 200)
            {
                x_out = "4:30am";
            }
            if (x_in == 220)
            {
                x_out = "5am";
            }
            if (x_in == 240)
            {
                x_out = "5:30am";
            }
            if (x_in == 260)
            {
                x_out = "6am";
            }
            if (x_in == 280)
            {
                x_out = "6:30am";
            }
            if (x_in == 300)
            {
                x_out = "7am";
            }
            if (x_in == 320)
            {
                x_out = "7:30am";
            }
            //
            if (x_in == 340)
            {
                x_out = "8am";
            }
            if (x_in == 360)
            {
                x_out = "8:30am";
            }
            if (x_in == 380)
            {
                x_out = "9am";
            }
            if (x_in == 400)
            {
                x_out = "9:30am";
            }
            if (x_in == 420)
            {
                x_out = "10am";
            }
            if (x_in == 440)
            {
                x_out = "10:30am";
            }
            if (x_in == 460)
            {
                x_out = "11am";
            }
            if (x_in == 480)
            {
                x_out = "11:30am";
            }
            #endregion

            #region // 12 Hour PM
            if (x_in == 500)
            {
                x_out = "12pm";
            }
            if (x_in == 520)
            {
                x_out = "12:30pm";
            }
            if (x_in == 540)
            {
                x_out = "1pm";
            }
            if (x_in == 560)
            {
                x_out = "1:30pm";
            }
            if (x_in == 580)
            {
                x_out = "2pm";
            }
            if (x_in == 600)
            {
                x_out = "2:30pm";
            }
            if (x_in == 620)
            {
                x_out = "3pm";
            }
            if (x_in == 640)
            {
                x_out = "3:30pm";
            }
            if (x_in == 660)
            {
                x_out = "4pm";
            }
            if (x_in == 680)
            {
                x_out = "4:30pm";
            }
            if (x_in == 700)
            {
                x_out = "5pm";
            }
            if (x_in == 720)
            {
                x_out = "5:30pm";
            }
            if (x_in == 740)
            {
                x_out = "6pm";
            }
            if (x_in == 760)
            {
                x_out = "6:30pm";
            }
            if (x_in == 780)
            {
                x_out = "7pm";
            }
            if (x_in == 800)
            {
                x_out = "7:30pm";
            }
            if (x_in == 820)
            {
                x_out = "8pm";
            }
            if (x_in == 840)
            {
                x_out = "8:30pm";
            }
            if (x_in == 860)
            {
                x_out = "9pm";
            }
            if (x_in == 880)
            {
                x_out = "9:30pm";
            }
            if (x_in == 900)
            {
                x_out = "10pm";
            }
            if (x_in == 920)
            {
                x_out = "10:30pm";
            }
            if (x_in == 940)
            {
                x_out = "11pm";
            }
            if (x_in == 960)
            {
                x_out = "11:30pm";
            }
            return x_out;
        }
#endregion

        // External Links
        public Image ExpandBGImage
        {
            get
            {
                return Day_Expanding_Panel_01.BackgroundImage;
            }
            set
            {
                Day_Expanding_Panel_01.BackgroundImage = value;
                Day_Expanding_Panel_02.BackgroundImage = value;
                Day_Expanding_Panel_03.BackgroundImage = value;
                Day_Expanding_Panel_04.BackgroundImage = value;
                Day_Expanding_Panel_05.BackgroundImage = value;
                Day_Expanding_Panel_06.BackgroundImage = value;
            }
        }
    }
}
 