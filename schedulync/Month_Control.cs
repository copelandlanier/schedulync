using System;
using System.Drawing;
using System.Windows.Forms;

namespace Calendar_NEW
{
    public partial class Month_Control : UserControl
    {
        int year = DateTime.Today.Year;
        int month = DateTime.Today.Month;
        int OffsetDay;
        int daysOfmonth;
        string dayOfFirstDay;
        Control LabelCtn = new Control();
        Control PanelCtn = new Control();
        Control TextBoxCtn = new Control();
        Label MenuDropDown = new Label();
        Label MenuDropDownShadow = new Label();
        DateTime dateLabelTextMonth = DateTime.Now;
        Font DateTimeLabelFont = new Font("Century Gothic", 24, FontStyle.Bold);
        Color TextBoxBackColor = Color.Red;
        Color DarkBackColor = Color.Gainsboro;
        Color LightBackColor = Color.FromArgb(255, 255, 255, 255);
        Color SelectionDay = Color.FromArgb(255, 193, 211, 246);
        Color SelectionDayLight = Color.FromArgb(255, 220, 228, 246);
        Color HolidayBackColor = Color.FromArgb(255, 230, 230, 230);
        //
        Label MenuLine1 = new Label();
        Label MenuLine2 = new Label();
        Label MenuLine3 = new Label();
        Label MenuLine4 = new Label();
        Label MenuLine5 = new Label();
        Label MenuLine6 = new Label();
        //
        int HolidayAdditions;
        //
        System.Timers.Timer MenuTimer = new System.Timers.Timer(200);


        public Month_Control()
        {
            InitializeComponent();
            monthCalendar1.Location = new Point(panel_HoldMain.Right + 40, panel_HoldMain.Top - 20);
            monthCalendar1.DateSelected += MonthCalendar1_DateSelected;

            Month_Overlay_Events();
            monthCalendar1.DateChanged += MonthCalendar1_DateChanged;
            monthCalendar1.DateChanged += MonthCalendar1_DateChanged1;
            MenuDropDown.Width = 130;

            #region // Menu Display
            // Menu
            MenuLine1.Height = 20;
            MenuLine2.Height = 20;
            MenuLine3.Height = 20;
            MenuLine4.Height = 20;
            MenuLine5.Height = 20;
            MenuLine6.Height = 20;
            MenuLine1.Width = MenuDropDown.Width;
            MenuLine2.Width = MenuDropDown.Width;
            MenuLine3.Width = MenuDropDown.Width;
            MenuLine4.Width = MenuDropDown.Width;
            MenuLine5.Width = MenuDropDown.Width;
            MenuLine6.Width = MenuDropDown.Width;
            MenuLine1.Location = new Point(0, 0);
            MenuLine2.Location = new Point(0, 20);
            MenuLine3.Location = new Point(0, 40);
            MenuLine4.Location = new Point(0, 60);
            MenuLine5.Location = new Point(0, 80);
            MenuLine6.Location = new Point(0, 100);
            MenuLine1.Padding = new Padding(5, 0, 0, 0);
            MenuLine2.Padding = new Padding(5, 0, 0, 0);
            MenuLine3.Padding = new Padding(5, 0, 0, 0);
            MenuLine4.Padding = new Padding(5, 0, 0, 0);
            MenuLine5.Padding = new Padding(5, 0, 0, 0);
            MenuLine6.Padding = new Padding(5, 0, 0, 0);
            MenuLine1.Text = "Add Event";
            MenuLine2.Text = "Delete Event";
            MenuLine3.Text = "Properties";
            MenuLine4.Text = "Delete Event";
            MenuLine4.Text = "Copy";
            MenuLine5.Text = "Paste";
            MenuLine6.Text = "Cancel";
            Font fnt = new Font(new FontFamily("Century Gothic"), 8.5f, FontStyle.Regular);
            MenuLine1.Font = fnt;
            MenuLine2.Font = fnt;
            MenuLine3.Font = fnt;
            MenuLine4.Font = fnt;
            MenuLine5.Font = fnt;
            MenuLine6.Font = fnt;
            MenuLine1.MouseEnter += MenuLine1_MouseEnter;
            MenuLine1.MouseLeave += MenuLine1_MouseLeave;
            MenuLine2.MouseEnter += MenuLine2_MouseEnter;
            MenuLine2.MouseLeave += MenuLine2_MouseLeave;
            MenuLine3.MouseEnter += MenuLine3_MouseEnter;
            MenuLine3.MouseLeave += MenuLine3_MouseLeave;
            MenuLine4.MouseEnter += MenuLine4_MouseEnter;
            MenuLine4.MouseLeave += MenuLine4_MouseLeave;
            MenuLine5.MouseEnter += MenuLine5_MouseEnter;
            MenuLine5.MouseLeave += MenuLine5_MouseLeave;
            MenuLine6.MouseEnter += MenuLine6_MouseEnter;
            MenuLine6.MouseLeave += MenuLine6_MouseLeave;
            //
            MenuTimer.AutoReset = true;
            MenuTimer.Elapsed += MenuTimer_Elapsed;
            //
            #endregion

            #region // Mouse Click Events
            label1.MouseDoubleClick += Label1_MouseDoubleClick;

            panel2.MouseClick += Panel2_MouseClick;
            panel3.MouseClick += Panel3_MouseClick;
            panel4.MouseClick += Panel4_MouseClick;
            panel5.MouseClick += Panel5_MouseClick;
            panel6.MouseClick += Panel6_MouseClick;
            panel7.MouseClick += Panel7_MouseClick;
            panel8.MouseClick += Panel8_MouseClick;
            panel9.MouseClick += Panel9_MouseClick;
            panel10.MouseClick += Panel10_MouseClick;
            panel11.MouseClick += Panel11_MouseClick;
            panel12.MouseClick += Panel12_MouseClick;
            panel13.MouseClick += Panel13_MouseClick;
            panel14.MouseClick += Panel14_MouseClick;
            panel15.MouseClick += Panel15_MouseClick;
            panel16.MouseClick += Panel16_MouseClick;
            panel17.MouseClick += Panel17_MouseClick;
            panel18.MouseClick += Panel18_MouseClick;
            panel19.MouseClick += Panel19_MouseClick;
            panel20.MouseClick += Panel20_MouseClick;
            panel21.MouseClick += Panel21_MouseClick;
            panel22.MouseClick += Panel22_MouseClick;
            panel23.MouseClick += Panel23_MouseClick;
            panel24.MouseClick += Panel24_MouseClick;
            panel25.MouseClick += Panel25_MouseClick;
            panel26.MouseClick += Panel26_MouseClick;
            panel27.MouseClick += Panel27_MouseClick;
            panel28.MouseClick += Panel28_MouseClick;
            panel29.MouseClick += Panel29_MouseClick;
            panel30.MouseClick += Panel30_MouseClick;
            panel31.MouseClick += Panel31_MouseClick;
            panel32.MouseClick += Panel32_MouseClick;
            panel33.MouseClick += Panel33_MouseClick;
            panel34.MouseClick += Panel34_MouseClick;
            panel35.MouseClick += Panel35_MouseClick;
            panel36.MouseClick += Panel36_MouseClick;
            panel37.MouseClick += Panel37_MouseClick;
            panel38.MouseClick += Panel38_MouseClick;
            panel39.MouseClick += Panel39_MouseClick;
            panel40.MouseClick += Panel40_MouseClick;
            panel41.MouseClick += Panel41_MouseClick;
            panel42.MouseClick += Panel42_MouseClick;

            #endregion

            DateTimeLabelMonth.ForeColor = Color.FromArgb(255, 100, 100, 100);
            DateTimeLabelMonth.Height = 50;
            DateTimeLabelMonth.Width = 500;
            DateTimeLabelMonth.Font = DateTimeLabelFont;
            DateTimeLabelMonth.Text = (dateLabelTextMonth.DayOfWeek.ToString() + "," + " " + dateLabelTextMonth.ToString("MMMM") + " " + dateLabelTextMonth.Month.ToString() + "," + " " + dateLabelTextMonth.Year.ToString());
            DateTimeLabelMonth.BringToFront();

            // Keep property or find another property to track updates for the Month Calendar
            monthCalendar1.Focus();            
        }

        #region // Menu Display
        private void MenuTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate { MenuHide(); });
        }

        private void MenuLine1_MouseLeave(object sender, EventArgs e)
        {
            MenuLine1.BackColor = Color.Transparent;
            MenuTimer.Start();
        }

        private void MenuLine1_MouseEnter(object sender, EventArgs e)
        {
            MenuTimer.Stop();
            MenuLine1.BackColor = Color.FromArgb(255, 190, 190, 190);
        }

        private void MenuLine2_MouseLeave(object sender, EventArgs e)
        {
            MenuTimer.Start();
            MenuLine2.BackColor = Color.Transparent;
        }

        private void MenuLine2_MouseEnter(object sender, EventArgs e)
        {
            MenuTimer.Stop();
            MenuLine2.BackColor = Color.FromArgb(255, 190, 190, 190);
        }


        private void MenuLine3_MouseLeave(object sender, EventArgs e)
        {
            MenuTimer.Start();
            MenuLine3.BackColor = Color.Transparent;
        }

        private void MenuLine3_MouseEnter(object sender, EventArgs e)
        {
            MenuTimer.Stop();
            MenuLine3.BackColor = Color.FromArgb(255, 190, 190, 190);
        }

        private void MenuLine4_MouseLeave(object sender, EventArgs e)
        {
            MenuTimer.Start();
            MenuLine4.BackColor = Color.Transparent;
        }

        private void MenuLine4_MouseEnter(object sender, EventArgs e)
        {
            MenuTimer.Stop();
            MenuLine4.BackColor = Color.FromArgb(255, 190, 190, 190);
        }

        private void MenuLine5_MouseLeave(object sender, EventArgs e)
        {
            MenuTimer.Start();
            MenuLine5.BackColor = Color.Transparent;
        }

        private void MenuLine5_MouseEnter(object sender, EventArgs e)
        {
            MenuTimer.Stop();
            MenuLine5.BackColor = Color.FromArgb(255, 190, 190, 190);
        }

        private void MenuLine6_MouseLeave(object sender, EventArgs e)
        {
            MenuTimer.Start();
            MenuLine6.BackColor = Color.Transparent;
        }

        private void MenuLine6_MouseEnter(object sender, EventArgs e)
        {
            MenuTimer.Stop();
            MenuLine6.BackColor = Color.FromArgb(255, 190, 190, 190);
        }

        private void MenuHide()
        {
            MenuDropDownShadow.Hide();
            MenuDropDown.Hide();
        }

        private void MenuShow(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                MenuDropDownShadow.Width = MenuDropDown.Width + 2;
                MenuDropDownShadow.BackColor = Color.FromArgb(255, 150, 150, 150);
                MenuDropDown.Height = MenuLine6.Location.Y + 20;
                MenuDropDownShadow.Height = MenuDropDown.Height + 2;
                MenuDropDown.BackColor = Color.White;
                MenuDropDownShadow.Left = MenuDropDown.Left - 1;
                MenuDropDownShadow.Top = MenuDropDown.Top - 1;
                MenuDropDown.Controls.Add(MenuLine1);
                MenuDropDown.Controls.Add(MenuLine2);
                MenuDropDown.Controls.Add(MenuLine3);
                MenuDropDown.Controls.Add(MenuLine4);
                MenuDropDown.Controls.Add(MenuLine5);
                MenuDropDown.Controls.Add(MenuLine6);
                this.Controls.Add(MenuDropDownShadow);
                this.Controls.Add(MenuDropDown);
                MenuDropDownShadow.BringToFront();
                MenuDropDown.BringToFront();
                MenuDropDown.Show();
                MenuDropDownShadow.Show();
            }
        }
        #endregion

        private void Panel2_MouseClick(object sender, MouseEventArgs e)
        {
            MenuDropDown.Left = panel2.Left + 10;
            MenuDropDown.Top = panel2.Location.Y + MenuDropDown.Height - 20;

            if (panel2.BackColor == LightBackColor || panel2.BackColor == SelectionDayLight)
            {
                MenuShow(sender, e);
            }
        }

        private void Panel3_MouseClick(object sender, MouseEventArgs e)
        {
            MenuDropDown.Left = panel3.Left + 10;
            MenuDropDown.Top = panel3.Location.Y + MenuDropDown.Height - 20;

            if (panel3.BackColor == LightBackColor || panel3.BackColor == SelectionDayLight)
            {
                MenuShow(sender, e);
            }
        }

        private void Panel4_MouseClick(object sender, MouseEventArgs e)
        {
            MenuDropDown.Left = panel4.Left + 10;
            MenuDropDown.Top = panel4.Location.Y + MenuDropDown.Height - 20;

            if (panel4.BackColor == LightBackColor || panel4.BackColor == SelectionDayLight)
            {
                MenuShow(sender, e);
            }
        }

        private void Panel5_MouseClick(object sender, MouseEventArgs e)
        {
            MenuDropDown.Left = panel5.Left + 10;
            MenuDropDown.Top = panel5.Location.Y + MenuDropDown.Height - 20;

            if (panel5.BackColor == LightBackColor || panel5.BackColor == SelectionDayLight)
            {
                MenuShow(sender, e);
            }
        }

        private void Panel6_MouseClick(object sender, MouseEventArgs e)
        {
            MenuDropDown.Left = panel6.Left + 10;
            MenuDropDown.Top = panel6.Location.Y + MenuDropDown.Height - 20;

            if (panel6.BackColor == LightBackColor || panel6.BackColor == SelectionDayLight)
            {
                MenuShow(sender, e);
            }
        }

        private void Panel7_MouseClick(object sender, MouseEventArgs e)
        {
            MenuDropDown.Left = panel7.Left + 10;
            MenuDropDown.Top = panel7.Location.Y + MenuDropDown.Height - 20;

            if (panel7.BackColor == LightBackColor || panel7.BackColor == SelectionDayLight)
            {
                MenuShow(sender, e);
            }
        }

        private void Panel8_MouseClick(object sender, MouseEventArgs e)
        {
            MenuDropDown.Left = panel8.Left + 10;
            MenuDropDown.Top = panel8.Location.Y + MenuDropDown.Height - 20;

            if (panel8.BackColor == LightBackColor || panel8.BackColor == SelectionDayLight)
            {
                MenuShow(sender, e);
            }
        }

        private void Panel9_MouseClick(object sender, MouseEventArgs e)
        {
            MenuDropDown.Left = panel9.Left + 10;
            MenuDropDown.Top = panel9.Location.Y + MenuDropDown.Height - 20;

            if (panel9.BackColor == LightBackColor || panel9.BackColor == SelectionDayLight)
            {
                MenuShow(sender, e);
            }
        }

        private void Panel10_MouseClick(object sender, MouseEventArgs e)
        {
            MenuDropDown.Left = panel10.Left + 10;
            MenuDropDown.Top = panel10.Location.Y + MenuDropDown.Height - 20;

            if (panel10.BackColor == LightBackColor || panel10.BackColor == SelectionDayLight)
            {
                MenuShow(sender, e);
            }
        }

        private void Panel11_MouseClick(object sender, MouseEventArgs e)
        {
            MenuDropDown.Left = panel11.Left + 10;
            MenuDropDown.Top = panel11.Location.Y + MenuDropDown.Height - 20;

            if (panel11.BackColor == LightBackColor || panel11.BackColor == SelectionDayLight)
            {
                MenuShow(sender, e);
            }
        }

        private void Panel12_MouseClick(object sender, MouseEventArgs e)
        {
            MenuDropDown.Left = panel12.Left + 10;
            MenuDropDown.Top = panel12.Location.Y + MenuDropDown.Height - 20;

            if (panel12.BackColor == LightBackColor || panel12.BackColor == SelectionDayLight)
            {
                MenuShow(sender, e);
            }
        }

        private void Panel13_MouseClick(object sender, MouseEventArgs e)
        {
            MenuDropDown.Left = panel13.Left + 10;
            MenuDropDown.Top = panel13.Location.Y + MenuDropDown.Height - 20;

            if (panel13.BackColor == LightBackColor || panel13.BackColor == SelectionDayLight)
            {
                MenuShow(sender, e);
            }
        }

        private void Panel14_MouseClick(object sender, MouseEventArgs e)
        {
            MenuDropDown.Left = panel14.Left + 10;
            MenuDropDown.Top = panel14.Location.Y + MenuDropDown.Height - 20;

            if (panel14.BackColor == LightBackColor || panel14.BackColor == SelectionDayLight)
            {
                MenuShow(sender, e);
            }
        }

        //
        private void Panel15_MouseClick(object sender, MouseEventArgs e)
        {
            MenuDropDown.Left = panel15.Left + 10;
            MenuDropDown.Top = panel15.Location.Y + MenuDropDown.Height - 20;

            if (panel15.BackColor == LightBackColor || panel15.BackColor == SelectionDayLight)
            {
                MenuShow(sender, e);
            }
        }

        private void Panel16_MouseClick(object sender, MouseEventArgs e)
        {
            MenuDropDown.Left = panel16.Left + 10;
            MenuDropDown.Top = panel16.Location.Y + MenuDropDown.Height - 20;

            if (panel16.BackColor == LightBackColor || panel16.BackColor == SelectionDayLight)
            {
                MenuShow(sender, e);
            }
        }

        private void Panel17_MouseClick(object sender, MouseEventArgs e)
        {
            MenuDropDown.Left = panel17.Left + 10;
            MenuDropDown.Top = panel17.Location.Y + MenuDropDown.Height - 20;

            if (panel17.BackColor == LightBackColor || panel17.BackColor == SelectionDayLight)
            {
                MenuShow(sender, e);
            }
        }

        private void Panel18_MouseClick(object sender, MouseEventArgs e)
        {
            MenuDropDown.Left = panel18.Left + 10;
            MenuDropDown.Top = panel18.Location.Y + MenuDropDown.Height - 20;

            if (panel18.BackColor == LightBackColor || panel18.BackColor == SelectionDayLight)
            {
                MenuShow(sender, e);
            }
        }

        private void Panel19_MouseClick(object sender, MouseEventArgs e)
        {
            MenuDropDown.Left = panel19.Left + 10;
            MenuDropDown.Top = panel19.Location.Y + MenuDropDown.Height - 20;

            if (panel29.BackColor == LightBackColor || panel19.BackColor == SelectionDayLight)
            {
                MenuShow(sender, e);
            }
        }

        private void Panel20_MouseClick(object sender, MouseEventArgs e)
        {
            MenuDropDown.Left = panel20.Left + 10;
            MenuDropDown.Top = panel20.Location.Y + MenuDropDown.Height - 20;

            if (panel20.BackColor == LightBackColor || panel20.BackColor == SelectionDayLight)
            {
                MenuShow(sender, e);
            }
        }

        private void Panel21_MouseClick(object sender, MouseEventArgs e)
        {
            MenuDropDown.Left = panel21.Left + 10;
            MenuDropDown.Top = panel21.Location.Y + MenuDropDown.Height - 20;

            if (panel21.BackColor == LightBackColor || panel21.BackColor == SelectionDayLight)
            {
                MenuShow(sender, e);
            }
        }

        private void Panel22_MouseClick(object sender, MouseEventArgs e)
        {
            MenuDropDown.Left = panel22.Left + 10;
            MenuDropDown.Top = panel22.Location.Y + MenuDropDown.Height - 20;

            if (panel22.BackColor == LightBackColor || panel22.BackColor == SelectionDayLight)
            {
                MenuShow(sender, e);
            }
        }

        private void Panel23_MouseClick(object sender, MouseEventArgs e)
        {
            MenuDropDown.Left = panel23.Left + 10;
            MenuDropDown.Top = panel23.Location.Y + MenuDropDown.Height - 20;

            if (panel23.BackColor == LightBackColor || panel23.BackColor == SelectionDayLight)
            {
                MenuShow(sender, e);
            }
        }

        private void Panel24_MouseClick(object sender, MouseEventArgs e)
        {
            MenuDropDown.Left = panel24.Left + 10;
            MenuDropDown.Top = panel24.Location.Y + MenuDropDown.Height - 20;

            if (panel24.BackColor == LightBackColor || panel24.BackColor == SelectionDayLight)
            {
                MenuShow(sender, e);
            }
        }

        private void Panel25_MouseClick(object sender, MouseEventArgs e)
        {
            MenuDropDown.Left = panel25.Left + 10;
            MenuDropDown.Top = panel25.Location.Y + MenuDropDown.Height - 20;

            if (panel25.BackColor == LightBackColor || panel25.BackColor == SelectionDayLight)
            {
                MenuShow(sender, e);
            }
        }

        private void Panel26_MouseClick(object sender, MouseEventArgs e)
        {
            MenuDropDown.Left = panel26.Left + 10;
            MenuDropDown.Top = panel26.Location.Y + MenuDropDown.Height - 20;

            if (panel26.BackColor == LightBackColor || panel26.BackColor == SelectionDayLight)
            {
                MenuShow(sender, e);
            }
        }

        private void Panel27_MouseClick(object sender, MouseEventArgs e)
        {
            MenuDropDown.Left = panel27.Left + 10;
            MenuDropDown.Top = panel27.Location.Y + MenuDropDown.Height - 20;

            if (panel27.BackColor == LightBackColor || panel27.BackColor == SelectionDayLight)
            {
                MenuShow(sender, e);
            }
        }

        private void Panel28_MouseClick(object sender, MouseEventArgs e)
        {
            MenuDropDown.Left = panel28.Left + 10;
            MenuDropDown.Top = panel28.Location.Y + MenuDropDown.Height - 20;

            if (panel28.BackColor == LightBackColor || panel28.BackColor == SelectionDayLight)
            {
                MenuShow(sender, e);
            }
        }

        private void Panel29_MouseClick(object sender, MouseEventArgs e)
        {
            MenuDropDown.Left = panel29.Left + 10;
            MenuDropDown.Top = panel29.Location.Y + MenuDropDown.Height - 20;

            if (panel29.BackColor == LightBackColor || panel29.BackColor == SelectionDayLight)
            {
                MenuShow(sender, e);
            }
        }

        private void Panel30_MouseClick(object sender, MouseEventArgs e)
        {
            MenuDropDown.Left = panel30.Left + 10;
            MenuDropDown.Top = panel30.Location.Y + MenuDropDown.Height - 20;

            if (panel30.BackColor == LightBackColor || panel30.BackColor == SelectionDayLight)
            {
                MenuShow(sender, e);
            }
        }

        private void Panel31_MouseClick(object sender, MouseEventArgs e)
        {
            MenuDropDown.Left = panel31.Left + 10;
            MenuDropDown.Top = panel31.Location.Y + MenuDropDown.Height - 20;

            if (panel31.BackColor == LightBackColor || panel31.BackColor == SelectionDayLight)
            {
                MenuShow(sender, e);
            }
        }

        private void Panel32_MouseClick(object sender, MouseEventArgs e)
        {
            MenuDropDown.Left = panel32.Left + 10;
            MenuDropDown.Top = panel32.Location.Y + MenuDropDown.Height - 20;

            if (panel32.BackColor == LightBackColor || panel32.BackColor == SelectionDayLight)
            {
                MenuShow(sender, e);
            }
        }
        private void Panel33_MouseClick(object sender, MouseEventArgs e)
        {
            MenuDropDown.Left = panel33.Left + 10;
            MenuDropDown.Top = panel33.Location.Y + MenuDropDown.Height - 20;

            if (panel33.BackColor == LightBackColor || panel33.BackColor == SelectionDayLight)
            {
                MenuShow(sender, e);
            }
        }

        private void Panel34_MouseClick(object sender, MouseEventArgs e)
        {
            MenuDropDown.Left = panel34.Left + 10;
            MenuDropDown.Top = panel34.Location.Y + MenuDropDown.Height - 20;

            if (panel34.BackColor == LightBackColor || panel34.BackColor == SelectionDayLight)
            {
                MenuShow(sender, e);
            }
        }

        private void Panel35_MouseClick(object sender, MouseEventArgs e)
        {
            MenuDropDown.Left = panel35.Left + 10;
            MenuDropDown.Top = panel35.Location.Y + MenuDropDown.Height - 20;

            if (panel35.BackColor == LightBackColor || panel35.BackColor == SelectionDayLight)
            {
                MenuShow(sender, e);
            }
        }

        private void Panel36_MouseClick(object sender, MouseEventArgs e)
        {
            MenuDropDown.Left = panel36.Left + 10;
            MenuDropDown.Top = panel36.Location.Y + MenuDropDown.Height - 20;

            if (panel36.BackColor == LightBackColor || panel36.BackColor == SelectionDayLight)
            {
                MenuShow(sender, e);
            }
        }

        private void Panel37_MouseClick(object sender, MouseEventArgs e)
        {
            MenuDropDown.Left = panel37.Left + 10;
            MenuDropDown.Top = panel37.Location.Y + MenuDropDown.Height - 20;

            if (panel37.BackColor == LightBackColor || panel37.BackColor == SelectionDayLight)
            {
                MenuShow(sender, e);
            }
        }

        private void Panel38_MouseClick(object sender, MouseEventArgs e)
        {
            MenuDropDown.Left = panel38.Left + 10;
            MenuDropDown.Top = panel38.Location.Y + MenuDropDown.Height - 20;

            if (panel38.BackColor == LightBackColor || panel38.BackColor == SelectionDayLight)
            {
                MenuShow(sender, e);
            }
        }

        private void Panel39_MouseClick(object sender, MouseEventArgs e)
        {
            MenuDropDown.Left = panel39.Left + 10;
            MenuDropDown.Top = panel39.Location.Y + MenuDropDown.Height - 20;

            if (panel39.BackColor == LightBackColor || panel39.BackColor == SelectionDayLight)
            {
                MenuShow(sender, e);
            }
        }

        private void Panel40_MouseClick(object sender, MouseEventArgs e)
        {
            MenuDropDown.Left = panel40.Left + 10;
            MenuDropDown.Top = panel40.Location.Y + MenuDropDown.Height - 20;

            if (panel40.BackColor == LightBackColor || panel40.BackColor == SelectionDayLight)
            {
                MenuShow(sender, e);
            }
        }

        private void Panel41_MouseClick(object sender, MouseEventArgs e)
        {
            MenuDropDown.Left = panel41.Left + 10;
            MenuDropDown.Top = panel41.Location.Y + MenuDropDown.Height - 20;

            if (panel41.BackColor == LightBackColor || panel41.BackColor == SelectionDayLight)
            {
                MenuShow(sender, e);
            }
        }

        private void Panel42_MouseClick(object sender, MouseEventArgs e)
        {
            MenuDropDown.Left = panel42.Left + 10;
            MenuDropDown.Top = panel42.Location.Y + MenuDropDown.Height - 20;

            if (panel42.BackColor == LightBackColor || panel42.BackColor == SelectionDayLight)
            {
                MenuShow(sender, e);
            }
        }




        private void MonthCalendar1_DateChanged1(object sender, DateRangeEventArgs e)
        {
            LargeDisplayDate();
        }

        private void MonthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            LargeDisplayDate();
        }

        private void LargeDisplayDate()
        {
            string LabeloutstringSingle;
            string PaneloutstringSingle;
            string TextboxstringSingle;

            string DateTimeSelect_Start;
            int DateIntStart;
            DateTimeSelect_Start = monthCalendar1.SelectionStart.Day.ToString();
            DateIntStart = Convert.ToInt32(DateTimeSelect_Start);
        
            LabeloutstringSingle = "label" + (DateIntStart + OffsetDay).ToString();
            LabelCtn = this.Controls[LabeloutstringSingle];
            LabelCtn.BackColor = SelectionDay;
            LabelCtn.ForeColor = Color.Black;

            PaneloutstringSingle = "panel" + (DateIntStart + OffsetDay).ToString();
            PanelCtn = this.panel_HoldMain.Controls[PaneloutstringSingle];
            PanelCtn.BackColor = SelectionDayLight;

            TextboxstringSingle = "textBox" + (DateIntStart + OffsetDay).ToString();
            TextBoxCtn = this.PanelCtn.Controls[TextboxstringSingle];
            TextBoxCtn.BackColor = SelectionDay;

            DateTimeLabelMonth.Text = (monthCalendar1.SelectionStart.DayOfWeek.ToString() + "," + " " + monthCalendar1.SelectionStart.ToString("MMMM") + " " + monthCalendar1.SelectionStart.Day.ToString() + "," + " " + monthCalendar1.SelectionStart.Year.ToString());
        }

        #region // Mouse Double Click
        private void Label1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            label1.Text = "This is a text double click";
        }
        
        #endregion

        private void MonthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            daysOfmonth = DateTime.DaysInMonth(monthCalendar1.SelectionStart.Year, monthCalendar1.SelectionStart.Month);
            DateTime firstDay = new DateTime(monthCalendar1.SelectionStart.Year, monthCalendar1.SelectionStart.Month, 1);
            dayOfFirstDay = firstDay.DayOfWeek.ToString();
            IntTest(dayOfFirstDay);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            daysOfmonth = DateTime.DaysInMonth(DateTime.Today.Year, DateTime.Today.Month);
            DateTime now = DateTime.Now;
            DateTime firstDay = new DateTime(now.Year, now.Month, 1);
            dayOfFirstDay = firstDay.DayOfWeek.ToString();
            IntTest(dayOfFirstDay);
        }

        #region // Display Functions

        public int IntTest(string Day)
        {
            if (Day == "Monday")
            {
                OffsetDay = 1;
                DisplayCalendar();
            }
            
            else if (Day == "Tuesday")
            {
                OffsetDay = 2;
                DisplayCalendar();
            }

            else if (Day == "Wednesday")
            {
                OffsetDay = 3;
                DisplayCalendar();
            }

            else if (Day == "Thursday")
            {
                OffsetDay = 4;
                DisplayCalendar();
            }

            else if (Day == "Friday")
            {
                OffsetDay = 5;
                DisplayCalendar();
            }

            else if (Day == "Saturday")
            {
                OffsetDay = 6;
                DisplayCalendar();
            }

            else if (Day == "Sunday")
            {
                OffsetDay = 7;
                DisplayCalendar();
            }

            else
            {
                OffsetDay = 0;
                DisplayCalendar();
            }
            return OffsetDay;
        }

        public void DisplayCalendar()
        {
            string LabelString;
            string PanelString;
            string TextBoxString;      

            DisplayClear();
            Font DisplayCalendarFont = new Font("Century Gothic", 9, FontStyle.Regular);
            string IndependanceDay = "Independance Day";
            string ChristmasDay = "Christmas Day";
            string VeteransDay = "Veterans Day";
            string NewYearsDay = "New Years Day";
            string MartinLutherKingDay = "Martin L. King Day";
            string WashingtonBirthday = "Washington Day";
            string MemorialDay = "Memorial Day";
            string LaborDay = "Labor Day";
            string ColumbusDay = "Columbus Day";
            string ThanksgivingDay = "Thanksgiving Day";

            for (int x = OffsetDay; x < daysOfmonth + OffsetDay; x++)
            {
                LabelString = "label" + (x + 1).ToString();
                PanelString = "panel" + (x + 1).ToString();
                TextBoxString = "textBox" + (x + 1).ToString();
                LabelCtn = this.Controls[LabelString];
                LabelCtn.Text = (x + 1 - OffsetDay).ToString();
                LabelCtn.BackColor = LightBackColor;
                PanelCtn = this.panel_HoldMain.Controls[PanelString];
                PanelCtn.BackColor = LightBackColor;
                TextBoxCtn = this.PanelCtn.Controls[TextBoxString];
                TextBoxCtn.BackColor = LightBackColor;

                // #region // Holidays

                // Indepedance Day
                if (LabelCtn.Text == "4" && monthCalendar1.SelectionStart.Month == 7)
                {
                    var NewString = IndependanceDay;
                    TextBoxCtn.Text = (NewString);
                    TextBoxCtn.BackColor = HolidayBackColor;
                    LabelCtn.BackColor = HolidayBackColor;
                }

                // Christmas Day
                else if (LabelCtn.Text == "25" && monthCalendar1.SelectionStart.Month == 12)
                {
                    var NewString = ChristmasDay;
                    TextBoxCtn.Text = (NewString);
                    TextBoxCtn.BackColor = HolidayBackColor;
                    LabelCtn.BackColor = HolidayBackColor;
                }

                // Veterans Day
                else if (LabelCtn.Text == "11" && monthCalendar1.SelectionStart.Month == 11)
                {
                    var NewString = VeteransDay;
                    TextBoxCtn.Text = (NewString);
                    TextBoxCtn.BackColor = HolidayBackColor;
                    LabelCtn.BackColor = HolidayBackColor;
                }

                // New Years Day
                else if (LabelCtn.Text == "1" && monthCalendar1.SelectionStart.Month == 1)
                {
                    var NewString = NewYearsDay;
                    TextBoxCtn.Text = (NewString);
                    TextBoxCtn.BackColor = HolidayBackColor;
                    LabelCtn.BackColor = HolidayBackColor;
                }

                // Labor Day
                else if (monthCalendar1.SelectionStart.Month == 9)
                {
                    var NewString = LaborDay;

                    if (OffsetDay != 1 && x == 8)
                    {
                        TextBoxCtn.Text = NewString;
                        TextBoxCtn.BackColor = HolidayBackColor;
                        LabelCtn.BackColor = HolidayBackColor;
                    }
                    
                    else if (x == 1)
                    {
                        TextBoxCtn.Text = NewString;
                        TextBoxCtn.BackColor = HolidayBackColor;
                        LabelCtn.BackColor = HolidayBackColor;
                    }
                }

                // Martin Luther King Day
                else if (monthCalendar1.SelectionStart.Month == 1)
                {
                    var NewString = MartinLutherKingDay;

                    if (OffsetDay != 1 && x == 22)
                    {                       
                        TextBoxCtn.Text = NewString;
                        TextBoxCtn.BackColor = HolidayBackColor;
                        LabelCtn.BackColor = HolidayBackColor;
                    }

                    else if (OffsetDay == 1 && x == 15)
                    {
                        TextBoxCtn.Text = NewString;
                        TextBoxCtn.BackColor = HolidayBackColor;
                        LabelCtn.BackColor = HolidayBackColor;
                    }
                }

                // Washington Day
                else if (monthCalendar1.SelectionStart.Month == 2)
                {
                    var NewString = WashingtonBirthday;
                    if (OffsetDay != 1 && x == 22)
                    {
                        TextBoxCtn.Text = NewString;
                        TextBoxCtn.BackColor = HolidayBackColor;
                        LabelCtn.BackColor = HolidayBackColor;
                    }

                    else if (OffsetDay == 1 && x == 15)
                    {
                        TextBoxCtn.Text = NewString;
                        TextBoxCtn.BackColor = HolidayBackColor;
                        LabelCtn.BackColor = HolidayBackColor;
                    }
                }

                // Columbus Day
                else if (monthCalendar1.SelectionStart.Month == 10)
                {
                        var NewString = ColumbusDay;

                    if (OffsetDay != 1 && x == 15)
                    {
                        TextBoxCtn.Text = NewString;
                        TextBoxCtn.BackColor = HolidayBackColor;
                        LabelCtn.BackColor = HolidayBackColor;
                    }

                    else if (OffsetDay == 1 && x == 8)
                    {
                        TextBoxCtn.Text = NewString;
                        TextBoxCtn.BackColor = HolidayBackColor;
                        LabelCtn.BackColor = HolidayBackColor;
                    }
                }

                // Thanksgiving Day
                else if (monthCalendar1.SelectionStart.Month == 11)
                {
                    var NewString = ThanksgivingDay;

                    if (OffsetDay > 4 && x == 32)
                    {
                        TextBoxCtn.Text = NewString;
                        TextBoxCtn.BackColor = HolidayBackColor;
                        LabelCtn.BackColor = HolidayBackColor;
                    }

                    else if (OffsetDay <= 4 && x == 25)
                    {
                        TextBoxCtn.Text = NewString;
                        TextBoxCtn.BackColor = HolidayBackColor;
                        LabelCtn.BackColor = HolidayBackColor;
                    }
                }

                // Memorial Day
                else if (monthCalendar1.SelectionStart.Month == 5)
                {
                    var NewString = MemorialDay;

                    if (OffsetDay > 5 && x == 36)
                    {
                        TextBoxCtn.Text = NewString;
                        TextBoxCtn.BackColor = HolidayBackColor;
                        LabelCtn.BackColor = HolidayBackColor;
                    }

                    else if (OffsetDay <= 5 && x == 29)
                    {
                        TextBoxCtn.Text = NewString;
                        TextBoxCtn.BackColor = HolidayBackColor;
                        LabelCtn.BackColor = HolidayBackColor;
                    }
                }
            }
        }

        private void Observances()
        { }

        private void StateHolidays()
        { }    

        private void InclusiveHolidays()
        { }

        public void DisplayClear()
        {
            label1.Text = ""; label2.Text = ""; label3.Text = ""; label4.Text = ""; label5.Text = ""; label6.Text = ""; label7.Text = ""; label8.Text = "";
            label9.Text = ""; label10.Text = ""; label11.Text = ""; label12.Text = ""; label13.Text = ""; label14.Text = ""; label15.Text = ""; label16.Text = "";
            label17.Text = ""; label18.Text = ""; label19.Text = ""; label20.Text = ""; label21.Text = ""; label22.Text = ""; label23.Text = ""; label24.Text = "";
            label25.Text = ""; label26.Text = ""; label27.Text = ""; label28.Text = ""; label29.Text = ""; label30.Text = ""; label31.Text = ""; label32.Text = "";
            label33.Text = ""; label34.Text = ""; label35.Text = ""; label36.Text = ""; label37.Text = ""; label38.Text = ""; label39.Text = ""; label40.Text = "";
            label41.Text = ""; label42.Text = "";
            //
            textBox1.Text = ""; textBox2.Text = ""; textBox3.Text = ""; textBox4.Text = ""; textBox5.Text = ""; textBox6.Text = ""; textBox7.Text = ""; textBox8.Text = "";
            textBox9.Text = ""; textBox10.Text = ""; textBox11.Text = ""; textBox12.Text = ""; textBox13.Text = ""; textBox14.Text = ""; textBox15.Text = ""; textBox16.Text = "";
            textBox17.Text = ""; textBox18.Text = ""; textBox19.Text = ""; textBox20.Text = ""; textBox21.Text = ""; textBox22.Text = ""; textBox23.Text = ""; textBox24.Text = "";
            textBox25.Text = ""; textBox26.Text = ""; textBox27.Text = ""; textBox28.Text = ""; textBox29.Text = ""; textBox30.Text = ""; textBox31.Text = ""; textBox32.Text = "";
            textBox33.Text = ""; textBox34.Text = ""; textBox35.Text = ""; textBox36.Text = ""; textBox37.Text = ""; textBox38.Text = ""; textBox39.Text = ""; textBox40.Text = "";
            textBox41.Text = ""; textBox42.Text = "";
            //
            label1.BackColor = DarkBackColor; label2.BackColor = DarkBackColor; label3.BackColor = DarkBackColor; label4.BackColor = DarkBackColor; label5.BackColor = DarkBackColor; label6.BackColor = DarkBackColor; label7.BackColor = DarkBackColor; label8.BackColor = DarkBackColor;
            label9.BackColor = DarkBackColor; label10.BackColor = DarkBackColor; label11.BackColor = DarkBackColor; label12.BackColor = DarkBackColor; label13.BackColor = DarkBackColor; label14.BackColor = DarkBackColor; label15.BackColor = DarkBackColor; label16.BackColor = DarkBackColor;
            label17.BackColor = DarkBackColor; label18.BackColor = DarkBackColor; label19.BackColor = DarkBackColor; label20.BackColor = DarkBackColor; label21.BackColor = DarkBackColor; label22.BackColor = DarkBackColor; label23.BackColor = DarkBackColor; label24.BackColor = DarkBackColor;
            label25.BackColor = DarkBackColor; label26.BackColor = DarkBackColor; label27.BackColor = DarkBackColor; label28.BackColor = DarkBackColor; label29.BackColor = DarkBackColor; label30.BackColor = DarkBackColor; label31.BackColor = DarkBackColor; label32.BackColor = DarkBackColor;
            label33.BackColor = DarkBackColor; label34.BackColor = DarkBackColor; label35.BackColor = DarkBackColor; label36.BackColor = DarkBackColor; label37.BackColor = DarkBackColor; label38.BackColor = DarkBackColor; label39.BackColor = DarkBackColor; label40.BackColor = DarkBackColor;
            label41.BackColor = DarkBackColor; label42.BackColor = DarkBackColor;
            //
            panel1.BackColor = DarkBackColor; panel2.BackColor = DarkBackColor; panel3.BackColor = DarkBackColor; panel4.BackColor = DarkBackColor; panel5.BackColor = DarkBackColor; panel6.BackColor = DarkBackColor; panel7.BackColor = DarkBackColor; panel8.BackColor = DarkBackColor;
            panel9.BackColor = DarkBackColor; panel10.BackColor = DarkBackColor; panel11.BackColor = DarkBackColor; panel12.BackColor = DarkBackColor; panel13.BackColor = DarkBackColor; panel14.BackColor = DarkBackColor; panel15.BackColor = DarkBackColor; panel16.BackColor = DarkBackColor;
            panel17.BackColor = DarkBackColor; panel18.BackColor = DarkBackColor; panel19.BackColor = DarkBackColor; panel20.BackColor = DarkBackColor; panel21.BackColor = DarkBackColor; panel22.BackColor = DarkBackColor; panel23.BackColor = DarkBackColor; panel24.BackColor = DarkBackColor;
            panel25.BackColor = DarkBackColor; panel26.BackColor = DarkBackColor; panel27.BackColor = DarkBackColor; panel28.BackColor = DarkBackColor; panel29.BackColor = DarkBackColor; panel30.BackColor = DarkBackColor; panel31.BackColor = DarkBackColor; panel32.BackColor = DarkBackColor;
            panel33.BackColor = DarkBackColor; panel34.BackColor = DarkBackColor; panel35.BackColor = DarkBackColor; panel36.BackColor = DarkBackColor; panel37.BackColor = DarkBackColor; panel38.BackColor = DarkBackColor; panel39.BackColor = DarkBackColor; panel40.BackColor = DarkBackColor;
            panel41.BackColor = DarkBackColor; panel42.BackColor = DarkBackColor;
            //
            textBox1.BackColor = DarkBackColor; textBox2.BackColor = DarkBackColor; textBox3.BackColor = DarkBackColor; textBox4.BackColor = DarkBackColor; textBox5.BackColor = DarkBackColor; textBox6.BackColor = DarkBackColor; textBox7.BackColor = DarkBackColor; textBox8.BackColor = DarkBackColor;
            textBox9.BackColor = DarkBackColor; textBox10.BackColor = DarkBackColor; textBox11.BackColor = DarkBackColor; textBox12.BackColor = DarkBackColor; textBox13.BackColor = DarkBackColor; textBox14.BackColor = DarkBackColor; textBox15.BackColor = DarkBackColor; textBox16.BackColor = DarkBackColor;
            textBox17.BackColor = DarkBackColor; textBox18.BackColor = DarkBackColor; textBox19.BackColor = DarkBackColor; textBox20.BackColor = DarkBackColor; textBox21.BackColor = DarkBackColor; textBox22.BackColor = DarkBackColor; textBox23.BackColor = DarkBackColor; textBox24.BackColor = DarkBackColor;
            textBox25.BackColor = DarkBackColor; textBox26.BackColor = DarkBackColor; textBox27.BackColor = DarkBackColor; textBox28.BackColor = DarkBackColor; textBox29.BackColor = DarkBackColor; textBox30.BackColor = DarkBackColor; textBox31.BackColor = DarkBackColor; textBox32.BackColor = DarkBackColor;
            textBox33.BackColor = DarkBackColor; textBox34.BackColor = DarkBackColor; textBox35.BackColor = DarkBackColor; textBox36.BackColor = DarkBackColor; textBox37.BackColor = DarkBackColor; textBox38.BackColor = DarkBackColor; textBox39.BackColor = DarkBackColor; textBox40.BackColor = DarkBackColor;
            textBox41.BackColor = DarkBackColor; textBox42.BackColor = DarkBackColor;
            
        }
        #endregion

        public string LargeDateTime_Display
        {
            get
            {
                return DateTimeLabelMonth.Text;
            }
            set
            {
                DateTimeLabelMonth.Text = null;
            }
        }

        public MonthCalendar MonthCalendarExport
        {
            get
            {
                return monthCalendar1;
            }
            set
            {
                monthCalendar1 = value;
            }
        }

#region // TextBox Changed
        private void textBox42_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox41_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox40_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox39_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox38_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox37_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox36_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox29_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox30_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox31_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox32_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox33_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox34_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox35_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox28_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox27_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox26_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox25_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox24_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox23_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox22_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox21_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }
#endregion

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void label35_Click(object sender, EventArgs e)
        {

        }

        private void label34_Click(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void label33_Click(object sender, EventArgs e)
        {

        }

        private void label40_Click(object sender, EventArgs e)
        {

        }

        private void label41_Click(object sender, EventArgs e)
        {

        }

        private void label42_Click(object sender, EventArgs e)
        {

        }

        private void label39_Click(object sender, EventArgs e)
        {

        }

        private void label32_Click(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void label31_Click(object sender, EventArgs e)
        {

        }

        private void label38_Click(object sender, EventArgs e)
        {

        }

        private void label37_Click(object sender, EventArgs e)
        {

        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void label36_Click(object sender, EventArgs e)
        {

        }
    }
}
