using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Calendar_NEW
{
    public partial class Display_Panel : UserControl
    {
        int DayControl_Loc_Move = 120;
        Time_Panel time_panel = new Time_Panel();
        //Point TimePanelLocation = new Point();
        public Day_Control day_Control_1 = new Day_Control();
        public Day_Control day_Control_2 = new Day_Control();
        public Day_Control day_Control_3 = new Day_Control();
        public Day_Control day_Control_4 = new Day_Control();
        public Day_Control day_Control_5 = new Day_Control();
        public Day_Control day_Control_6 = new Day_Control();
        public Day_Control day_Control_7 = new Day_Control();
        public Day_Control day_Control_8 = new Day_Control();
        public Day_Control day_Control_9 = new Day_Control();
        public Day_Control day_Control_10 = new Day_Control();
        public PersonnelImageBox pib_1 = new PersonnelImageBox();
        public PersonnelImageBox pib_2 = new PersonnelImageBox();
        public PersonnelImageBox pib_3 = new PersonnelImageBox();
        public PersonnelImageBox pib_4 = new PersonnelImageBox();
        public PersonnelImageBox pib_5 = new PersonnelImageBox();
        public PersonnelImageBox pib_6 = new PersonnelImageBox();
        public PersonnelImageBox pib_7 = new PersonnelImageBox();
        public PersonnelImageBox pib_8 = new PersonnelImageBox();
        public PersonnelImageBox pib_9 = new PersonnelImageBox();
        public PersonnelImageBox pib_10 = new PersonnelImageBox();
        public Month_Control month_Control_1 = new Month_Control();
        Button Button_Month_Display = new Button();
        Button Button_Month_Display_B = new Button();
        Button Button_Day_Display = new Button();
        Button Button_Exit = new Button();
        Label DateTimeLabelDay = new Label();
        Font DateTimeLabelFont = new Font("Century Gothic", 24, FontStyle.Bold);
        Label AMOverlay = new Label();
        Label PMOverlay = new Label();       
        MonthCalendar DaySideMonthCalendar = new MonthCalendar();
        DateTime DateTimeMemory;
        //int pb_VisTest_01 = 0;
        int pb_VisTest_02 = 0;
        int pb_VisTest_03 = 0;
        int pb_VisTest_04 = 0;
        int pb_VisTest_05 = 0;
        int pb_VisTest_06 = 0;
        int pb_VisTest_07 = 0;
        int pb_VisTest_08 = 0;
        int pb_VisTest_09 = 0;
        int pb_VisTest_10 = 0;

        public Display_Panel()
        {
            InitializeComponent();
            this.MouseDoubleClick += Display_Panel_MouseDoubleClick;
            this.SizeChanged += Display_Panel_SizeChanged;
            DateTimeMemory = month_Control_1.MonthCalendarExport.SelectionStart;

            #region
            // Possible Mouse Move implementartion on Time Scale Events
            /*time_panel.MouseDown += Time_panel_MouseDown;
            time_panel.MouseUp += Time_panel_MouseUp;
            time_panel.MouseMove += Time_panel_MouseMove;*/
            #endregion

            AMOverlay.Text = "AM";
            AMOverlay.Font = new Font("Century Gothic", 15, FontStyle.Bold);
            AMOverlay.Height = 30;
            AMOverlay.Width = 50;
            AMOverlay.ForeColor = Color.FromArgb(255, 90,90,90);
            AMOverlay.BackColor = Color.FromArgb(255, 195, 195, 195);

            PMOverlay.Text = "PM";
            PMOverlay.Font = new Font("Century Gothic", 15, FontStyle.Bold);
            PMOverlay.Height = 30;
            PMOverlay.Width = 50;
            PMOverlay.ForeColor = Color.FromArgb(255, 90, 90, 90);
            PMOverlay.BackColor = Color.FromArgb(255, 195, 195, 195);

            Panel_MainControlHolder.Controls.Add(AMOverlay);
            time_panel.Controls.Add(PMOverlay);

            DateTime dateLabelText = DateTime.Now;
            Panel_DayControlHolder.Controls.Add(time_panel);
            time_panel.Location = new Point(0,0);
            DateTimeLabelDay.ForeColor = Color.FromArgb(255, 100, 100, 100);
            DateTimeLabelDay.Height = 50;
            DateTimeLabelDay.Width = 560;
            DateTimeLabelDay.Font = DateTimeLabelFont;
            DateTimeLabelDay.Text = (dateLabelText.DayOfWeek.ToString() + "," + " " + dateLabelText.ToString("MMMM")  + " " + dateLabelText.Day.ToString() + "," + " " + dateLabelText.Year.ToString());
            DateTimeLabelDay.BringToFront();
            DateTimeLabelDay.Top = Panel_DayControlHolder.Top - 110;
            DateTimeLabelDay.Left = Panel_DayControlHolder.Left;
            Panel_MainControlHolder.Controls.Add(DateTimeLabelDay);
            Panel_MainControlHolder.Controls.Add(pib_1);
            Panel_MainControlHolder.Controls.Add(pib_2);
            Panel_MainControlHolder.Controls.Add(pib_3);
            Panel_MainControlHolder.Controls.Add(pib_4);
            Panel_MainControlHolder.Controls.Add(pib_5);
            Panel_MainControlHolder.Controls.Add(pib_6);
            Panel_MainControlHolder.Controls.Add(pib_7);
            Panel_MainControlHolder.Controls.Add(pib_8);
            Panel_MainControlHolder.Controls.Add(pib_9);
            Panel_MainControlHolder.Controls.Add(pib_10);
            ///
            /// Button Month B
            /// 
            // Line up button for 
            Button_Month_Display_B.Size = new Size(120, 150);
            Button_Month_Display_B.FlatStyle = FlatStyle.Flat;
            Button_Month_Display_B.BackgroundImage = Properties.Resources.view_calendar_up_large;
            Button_Month_Display_B.BackColor = Color.FromArgb(255, 170,170,170);
            Button_Month_Display_B.FlatAppearance.BorderColor = Color.FromArgb(255, 130, 130, 130);
            Button_Month_Display_B.BackgroundImageLayout = ImageLayout.Center;
            Button_Month_Display_B.BringToFront();           
            Panel_MainControlHolder.Controls.Add(Button_Month_Display_B);
            ///
            /// Button Day
            ///             
            Button_Day_Display.Location = new Point(month_Control_1.Left + (month_Control_1.Width / 2 - Button_Day_Display.Width), 20);
            Button_Day_Display.Size = new Size(70, 70);
            Button_Day_Display.FlatStyle = FlatStyle.Flat;
            Button_Day_Display.BackgroundImage = Properties.Resources.view_personnel_up;
            Button_Day_Display.FlatAppearance.BorderColor = Color.FromArgb(255, 130, 130, 130);
            Button_Day_Display.BringToFront();
            Panel_MainControlHolder.Controls.Add(Button_Day_Display);
            ///
            /// Button Month
            ///
            Button_Month_Display.Location = new Point(Button_Day_Display.Right + 5, Button_Day_Display.Top);
            Button_Month_Display.Size = new Size(70, 70);
            Button_Month_Display.FlatStyle = FlatStyle.Flat;
            Button_Month_Display.FlatAppearance.BorderColor = Color.FromArgb(255, 130, 130, 130);
            Button_Month_Display.BackgroundImage = Properties.Resources.view_calendar_up;
            Button_Month_Display.BringToFront();
            Panel_MainControlHolder.Controls.Add(Button_Month_Display);
            ///
            /// Button Exit
            ///
            Button_Exit.Size = new Size(100, 50);
            Button_Exit.FlatStyle = FlatStyle.Flat;
            Button_Exit.Text = "EXIT";
            Button_Exit.BringToFront();
            Button_Exit.FlatAppearance.BorderColor = Color.FromArgb(255, 100, 100, 100);
            Button_Exit.ForeColor = Color.White;
            Button_Exit.BackColor = Color.FromArgb(255, 170, 170, 170);
            Panel_MainControlHolder.Controls.Add(Button_Exit);
            Font Exit_Font = new Font("Century Gothic", 20, FontStyle.Bold);
            Button_Exit.Font = Exit_Font;
            // 
            // month_Control_1
            //
            month_Control_1.Name = "month_Control_1";
            month_Control_1.TabIndex = 0;
            Panel_MainControlHolder.Controls.Add(month_Control_1);
            month_Control_1.Hide();
            // 
            // day_Control_1
            //
            day_Control_1.Location = new Point(DayControl_Loc_Move, 0);
            day_Control_1.Name = "day_Control_1";
            day_Control_1.Size = new Size(120, 1000);
            day_Control_1.TabIndex = 0;
            //Panel_DayControlHolder.Controls.Add(day_Control_1);
            // 
            // day_Control_2
            //             
            day_Control_2.Location = new Point(DayControl_Loc_Move * 2, 0);
            day_Control_2.Name = "day_Control_2";
            day_Control_2.Size = new Size(120, 1000);
            day_Control_2.TabIndex = 0;
            //Panel_DayControlHolder.Controls.Add(day_Control_2);
            // 
            // day_Control_3
            //
            day_Control_3.Location = new Point(DayControl_Loc_Move * 3, 0);
            day_Control_3.Name = "day_Control_3";
            day_Control_3.Size = new Size(120, 1000);
            day_Control_3.TabIndex = 0;
            //Panel_DayControlHolder.Controls.Add(day_Control_3);
            // 
            // day_Control_4
            //             
            day_Control_4.Location = new Point(DayControl_Loc_Move * 4, 0);
            day_Control_4.Name = "day_Control_4";
            day_Control_4.Size = new Size(120, 1000);
            day_Control_4.TabIndex = 0;
            //Panel_DayControlHolder.Controls.Add(day_Control_4);
            // 
            // day_Control_5
            //
            day_Control_5.Location = new Point(DayControl_Loc_Move * 5, 0);
            day_Control_5.Name = "day_Control_5";
            day_Control_5.Size = new Size(120, 1000);
            day_Control_5.TabIndex = 0;
            //Panel_DayControlHolder.Controls.Add(day_Control_5);
            // 
            // day_Control_6
            //             
            day_Control_6.Location = new Point(DayControl_Loc_Move * 6, 0);
            day_Control_6.Name = "day_Control_6";
            day_Control_6.Size = new Size(120, 1000);
            day_Control_6.TabIndex = 0;
            //Panel_DayControlHolder.Controls.Add(day_Control_6);
            // 
            // day_Control_7
            //
            day_Control_7.Location = new Point(DayControl_Loc_Move * 7, 0);
            day_Control_7.Name = "day_Control_7";
            day_Control_7.Size = new Size(120, 1000);
            day_Control_7.TabIndex = 0;
            //Panel_DayControlHolder.Controls.Add(day_Control_7);
            // 
            // day_Control_8
            //             
            day_Control_8.Location = new Point(DayControl_Loc_Move * 8, 0);
            day_Control_8.Name = "day_Control_8";
            day_Control_8.Size = new Size(120, 1000);
            day_Control_8.TabIndex = 0;
            //Panel_DayControlHolder.Controls.Add(day_Control_8);
            // 
            // day_Control_9
            //
            day_Control_9.Location = new Point(DayControl_Loc_Move * 9, 0);
            day_Control_9.Name = "day_Control_9";
            day_Control_9.Size = new Size(120, 1000);
            day_Control_9.TabIndex = 0;
            //Panel_DayControlHolder.Controls.Add(day_Control_9);
            // 
            // day_Control_10
            //             
            day_Control_10.Location = new Point(DayControl_Loc_Move * 10, 0);
            day_Control_10.Name = "day_Control_10";
            day_Control_10.Size = new Size(120, 1000);
            day_Control_10.TabIndex = 0;
            //Panel_DayControlHolder.Controls.Add(day_Control_10);
            ///
            Panel_DayControlHolder.Width = month_Control_1.Width;
            Button_Day_Display.MouseUp += Button_Day_Display_MouseUp;
            Button_Month_Display.MouseUp += Button_Month_Display_MouseUp;
            Button_Month_Display_B.MouseUp += Button_Month_Display_B_MouseUp;
            time_panel.MouseEnter += Time_panel_MouseEnter;
            Button_DayControl_NextDay.MouseLeave += Button_DayControl_NextDay_MouseLeave;
            Button_DayControl_NextMonth.MouseLeave += Button_DayControl_NextMonth_MouseLeave;
            Button_DayControl_PrevDay.MouseLeave += Button_DayControl_PrevDay_MouseLeave;
            Button_DayControl_PrevMonth.MouseLeave += Button_DayControl_PrevMonth_MouseLeave;
            Button_DayControl_Today.MouseLeave += Button_DayControl_Today_MouseLeave;
            Button_Exit.MouseDown += Button_Exit_MouseDown;

            AMOverlay.BringToFront();
            PMOverlay.BringToFront();
            DaySideMonthCalendar.SelectionStart = month_Control_1.MonthCalendarExport.SelectionStart;
            TodayDate();
        }

        private void Button_Exit_MouseDown(object sender, MouseEventArgs e)
        {
            if (Global_Access.dialog_exit.ParentForm != this.ParentForm)
            {
                Global_Access.dialog_exit.Owner = this.ParentForm;
                Global_Access.dialog_exit.Show();
            }

            Global_Access.dialog_exit.Show();
        }

        private void Display_Panel_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Display_Panel_SizeChanged(sender, e);
        }

        private void Button_DayControl_Today_MouseLeave(object sender, EventArgs e)
        {
            time_panel.Focus();
        }

        private void Button_DayControl_PrevMonth_MouseLeave(object sender, EventArgs e)
        {
            time_panel.Focus();
        }

        private void Button_DayControl_PrevDay_MouseLeave(object sender, EventArgs e)
        {
            time_panel.Focus();
        }

        private void Button_DayControl_NextMonth_MouseLeave(object sender, EventArgs e)
        {
            time_panel.Focus();
        }

        private void Button_DayControl_NextDay_MouseLeave(object sender, EventArgs e)
        {
            time_panel.Focus();
        }

        #region // Possible Implemenantation
        // Possible Mouse Move implementartion on Time Scale Functions
        /*private void Time_panel_MouseUp(object sender, MouseEventArgs e)
        {
            //throw new NotImplementedException();
        }

        private void Time_panel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                TimePanelLocation = e.Location;
            }
            Console.WriteLine(time_panel.Location.Y);
        }

        private void Time_panel_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                if (time_panel.Top == 0 || time_panel.Top > -416 )
                {
                    Point start = Point.Empty;
                    //int timePanely = Math.Min(Math.Max(time_panel.Top - TimePanelLocation.Y  + (e.Y - start.Y), 100), time_panel.Height - 300);
                    //int timePanely = Math.Min(Math.Max(e.Y - start.Y, 0), time_panel.Top - TimePanelLocation.Y + (e.Y - start.Y));
                    int timePanely = time_panel.Top - TimePanelLocation.Y + (e.Y - start.Y);
                    time_panel.Location = new Point(0, timePanely);
                }
            }
            day_Control_1.Top = time_panel.Top;
            day_Control_2.Top = time_panel.Top;
            day_Control_3.Top = time_panel.Top;
            day_Control_4.Top = time_panel.Top;
            day_Control_5.Top = time_panel.Top;
            day_Control_6.Top = time_panel.Top;
            day_Control_7.Top = time_panel.Top;
            day_Control_8.Top = time_panel.Top;
            day_Control_9.Top = time_panel.Top;
            day_Control_10.Top = time_panel.Top;
        }*/
        #endregion

        private void Display_Panel_SizeChanged(object sender, EventArgs e)
        {  
            month_Control_1.Left = this.Width / 2 - month_Control_1.Width / 2;
            month_Control_1.Top = (this.Height / 2 - month_Control_1.Height / 2) + 60;
            Panel_DayControlHolder.Left = this.Width / 2 - Panel_DayControlHolder.Width / 2;
            Panel_DayControlHolder.Top = (this.Height / 2 - Panel_DayControlHolder.Height / 2) + 130;            
            pib_1.Top = Panel_DayControlHolder.Top - pib_1.Height;
            pib_1.Left = Panel_DayControlHolder.Left + DayControl_Loc_Move;
            pib_2.Top = pib_1.Top;
            pib_2.Left = pib_1.Left + pib_2.Width;
            pib_3.Top = pib_1.Top;
            pib_3.Left = pib_2.Left + pib_3.Width;
            pib_4.Top = pib_1.Top;
            pib_4.Left = pib_3.Left + pib_4.Width;
            pib_5.Top = pib_1.Top;
            pib_5.Left = pib_4.Left + pib_5.Width;
            pib_6.Top = pib_1.Top;
            pib_6.Left = pib_5.Left + pib_6.Width;
            pib_7.Top = pib_1.Top;
            pib_7.Left = pib_6.Left + pib_7.Width;
            pib_8.Top = pib_1.Top;
            pib_8.Left = pib_7.Left + pib_6.Width;
            pib_9.Top = pib_1.Top;
            pib_9.Left = pib_8.Left + pib_7.Width;
            pib_10.Top = pib_1.Top;
            pib_10.Left = pib_9.Left + pib_8.Width;

            Button_DayControl_NextMonth.Top = pib_1.Top - 40;
            Button_DayControl_NextMonth.Left = pib_10.Right - Button_DayControl_NextMonth.Width;
            Button_DayControl_NextDay.Top = pib_1.Top - 40;
            Button_DayControl_NextDay.Left = Button_DayControl_NextMonth.Left - Button_DayControl_NextMonth.Width - 1;
            Button_DayControl_Today.Top = pib_1.Top - 40;
            Button_DayControl_Today.Left = Button_DayControl_NextDay.Left - Button_DayControl_NextDay.Width - 1;
            Button_DayControl_PrevDay.Top = pib_1.Top - 40;
            Button_DayControl_PrevDay.Left = Button_DayControl_Today.Left - Button_DayControl_Today.Width - 1;
            Button_DayControl_PrevMonth.Top = pib_1.Top - 40;
            Button_DayControl_PrevMonth.Left = Button_DayControl_PrevDay.Left - Button_DayControl_PrevDay.Width - 1;

            Button_Month_Display_B.Top = pib_1.Top;
            Button_Month_Display_B.Left = Panel_DayControlHolder.Left;
            Button_Day_Display.Location = new Point(month_Control_1.Left + (month_Control_1.Width / 2 - Button_Day_Display.Width), 20);            
            Button_Month_Display.Location = new Point(Button_Day_Display.Right + 5, Button_Day_Display.Top);
            DateTimeLabelDay.Top = Panel_DayControlHolder.Top - pib_1.Height - 50;
            DateTimeLabelDay.Left = Panel_DayControlHolder.Left;
            AMOverlay.Location = new Point(Panel_DayControlHolder.Left + 25, Panel_MainControlHolder.Height / 2 - 153);
            PMOverlay.Location = new Point(time_panel.Left + 25, time_panel.Height / 2 - 10);
            button_DayControlSettings.FlatAppearance.BorderColor = Global_Access.ColorTransfer;            
            panel_Holder.Top = DateTimeLabelDay.Top - panel_Holder.Height;
            Button_Exit.Location = new Point(month_Control_1.Right - 120, Button_Month_Display.Top + (Button_Month_Display.Height / 4));
            panel_Holder.Left = month_Control_1.Left;
            DaySideMonthCalendar.SelectionStart = month_Control_1.MonthCalendarExport.SelectionStart;
        }

        private void Time_panel_MouseEnter(object sender, EventArgs e)
        {
            time_panel.Focus();
        }

        private void Button_Month_Display_B_MouseUp(object sender, MouseEventArgs e)
        {
            Button_Month_Display_MouseUp(sender, e);
        }

        private void Button_Month_Display_MouseUp(object sender, MouseEventArgs e)
        {
            Panel_DayControlHolder.Hide();
            DateTimeLabelDay.Hide();
            pib_1.Hide();

            if (pib_2.Visible == true)
            {
                pb_VisTest_02 = 1;
                pib_2.Hide();
            }
            if (pib_3.Visible == true)
            {
                pb_VisTest_03 = 1;
                pib_3.Hide();
            }
            if (pib_4.Visible == true)
            {
                pb_VisTest_04 = 1;
                pib_4.Hide();
            }
            if (pib_5.Visible == true)
            {
                pb_VisTest_05 = 1;
                pib_5.Hide();
            }
            if (pib_6.Visible == true)
            {
                pb_VisTest_06 = 1;
                pib_6.Hide();
            }
            if (pib_7.Visible == true)
            {
                pb_VisTest_07 = 1;
                pib_7.Hide();
            }
            if (pib_8.Visible == true)
            {
                pb_VisTest_08 = 1;
                pib_8.Hide();
            }
            if (pib_9.Visible == true)
            {
                pb_VisTest_09 = 1;
                pib_9.Hide();
            }
            if (pib_10.Visible == true)
            {
                pb_VisTest_10 = 1;
                pib_10.Hide();
            }

            Button_DayControl_NextDay.Hide();
            Button_DayControl_NextMonth.Hide();
            Button_DayControl_PrevDay.Hide();
            Button_DayControl_PrevMonth.Hide();
            Button_DayControl_Today.Hide();
            Button_Month_Display_B.Hide();
            AMOverlay.Hide();
            month_Control_1.Show();
            month_Control_1.SendToBack();
            DateTimeLabelDay.BringToFront();
            DaySideMonthCalendar.SelectionStart = month_Control_1.MonthCalendarExport.SelectionStart;
            DateTimeLabelDay.Text = (DaySideMonthCalendar.SelectionStart.DayOfWeek.ToString() + "," + " " + DaySideMonthCalendar.SelectionStart.ToString("MMMM") + " " + DaySideMonthCalendar.SelectionStart.Day.ToString() + "," + " " + DaySideMonthCalendar.SelectionStart.Year.ToString());
            month_Control_1.MonthCalendarExport.Focus();
        }

        private void Button_Day_Display_MouseUp(object sender, MouseEventArgs e)
        {
            DateTimeLabelDay.Show();
            Panel_DayControlHolder.Show();
            pib_1.Show();

            pib_2.Show();
            if (pb_VisTest_02 == 1)
            {
                pib_2.Show();
                pb_VisTest_02 = 0;
            }
            if (pb_VisTest_03 == 1)
            {
                pib_3.Show();
                pb_VisTest_03 = 0;
            }
            if (pb_VisTest_04 == 1)
            {
                pib_4.Show();
                pb_VisTest_04 = 0;
            }
            if (pb_VisTest_05 == 1)
            {
                pib_5.Show();
                pb_VisTest_05 = 0;
            }
            if (pb_VisTest_06 == 1)
            {
                pib_6.Show();
                pb_VisTest_06 = 0;
            }
            if (pb_VisTest_07 == 1)
            {
                pib_7.Show();
                pb_VisTest_07 = 0;
            }
            if (pb_VisTest_08 == 1)
            {
                pib_8.Show();
                pb_VisTest_08 = 0;
            }
            if (pb_VisTest_09 == 1)
            {
                pib_9.Show();
                pb_VisTest_09 = 0;
            }
            if (pb_VisTest_10 == 1)
            {
                pib_10.Show();
                pb_VisTest_10 = 0;
            }

            Button_DayControl_NextDay.Show();
            Button_DayControl_NextMonth.Show();
            Button_DayControl_PrevDay.Show();
            Button_DayControl_PrevMonth.Show();
            Button_DayControl_Today.Show();
            Button_Month_Display_B.Show();
            AMOverlay.Show();
            time_panel.Focus();
            month_Control_1.Hide();
            DaySideMonthCalendar.SelectionStart = month_Control_1.MonthCalendarExport.SelectionStart;
            DateTimeLabelDay.Text = (DaySideMonthCalendar.SelectionStart.DayOfWeek.ToString() + "," + " " + DaySideMonthCalendar.SelectionStart.ToString("MMMM") + " " + DaySideMonthCalendar.SelectionStart.Day.ToString() + "," + " " + DaySideMonthCalendar.SelectionStart.Year.ToString());
        }

        #region // Interfaces
        public Image ExpandBGImage1
        {
            get { return day_Control_1.ExpandBGImage; }
            set { day_Control_1.ExpandBGImage = value; }
        }

        public Image ExpandBGImage2
        {
            get { return day_Control_2.ExpandBGImage; }
            set { day_Control_2.ExpandBGImage = value; }
        }

        public Image ExpandBGImage3
        {
            get { return day_Control_3.ExpandBGImage; }
            set { day_Control_3.ExpandBGImage = value; }
        }

        public Image ExpandBGImage4
        {
            get { return day_Control_4.ExpandBGImage; }
            set { day_Control_4.ExpandBGImage = value; }
        }

        public Image ExpandBGImage5
        {
            get { return day_Control_5.ExpandBGImage; }
            set { day_Control_5.ExpandBGImage = value; }
        }

        public Image ExpandBGImage6
        {
            get { return day_Control_6.ExpandBGImage; }
            set { day_Control_6.ExpandBGImage = value; }
        }

        public Image ExpandBGImage7
        {
            get { return day_Control_7.ExpandBGImage; }
            set { day_Control_7.ExpandBGImage = value; }
        }

        public Image ExpandBGImage8
        {
            get { return day_Control_8.ExpandBGImage; }
            set { day_Control_8.ExpandBGImage = value; }
        }

        public Image ExpandBGImage9
        {
            get { return day_Control_9.ExpandBGImage; }
            set { day_Control_9.ExpandBGImage = value; }
        }

        public Image ExpandBGImage10
        {
            get { return day_Control_10.ExpandBGImage; }
            set { day_Control_10.ExpandBGImage = value; }
        }

        public bool DayVisible_1
        {
            get { return day_Control_1.Visible; }
            set { day_Control_1.Visible = value; Refresh(); }
        }

        public bool DayVisible_2
        {
            get { return day_Control_2.Visible; }
            set { day_Control_2.Visible = value; Refresh(); }
        }

        public bool DayVisible_3
        {
            get { return day_Control_3.Visible; }
            set { day_Control_3.Visible = value; Refresh(); }
        }

        public bool DayVisible_4
        {
            get { return day_Control_4.Visible; }
            set { day_Control_4.Visible = value; Refresh(); }
        }

        public bool DayVisible_5
        {
            get { return day_Control_5.Visible; }
            set { day_Control_5.Visible = value; Refresh(); }
        }

        public bool DayVisible_6
        {
            get { return day_Control_6.Visible; }
            set { day_Control_6.Visible = value; Refresh(); }
        }

        public bool DayVisible_7
        {
            get { return day_Control_7.Visible; }
            set { day_Control_7.Visible = value; Refresh(); }
        }

        public bool DayVisible_8
        {
            get { return day_Control_8.Visible; }
            set { day_Control_8.Visible = value; Refresh(); }
        }

        public bool DayVisible_9
        {
            get { return day_Control_9.Visible; }
            set { day_Control_9.Visible = value; Refresh(); }
        }

        public bool DayVisible_10
        {
            get { return day_Control_10.Visible; }
            set { day_Control_10.Visible = value; Refresh(); }
        }

        public Color DayBackColor_1
        {
            get { return day_Control_1.DayBackColor; }
            set { day_Control_1.DayBackColor = value; }
        }

        public Color DayBackColor_2
        {
            get { return day_Control_2.DayBackColor; }
            set { day_Control_2.DayBackColor = value; }
        }

        public Color DayBackColor_3
        {
            get { return day_Control_3.DayBackColor; }
            set { day_Control_3.DayBackColor = value; }
        }

        public Color DayBackColor_4
        {
            get { return day_Control_4.DayBackColor; }
            set { day_Control_4.DayBackColor = value; }
        }

        public Color DayBackColor_5
        {
            get { return day_Control_5.DayBackColor; }
            set { day_Control_5.DayBackColor = value; }
        }

        public Color DayBackColor_6
        {
            get { return day_Control_6.DayBackColor; }
            set { day_Control_6.DayBackColor = value; }
        }

        public Color DayBackColor_7
        {
            get { return day_Control_7.DayBackColor; }
            set { day_Control_7.DayBackColor = value; }
        }

        public Color DayBackColor_8
        {
            get { return day_Control_8.DayBackColor; }
            set { day_Control_8.DayBackColor = value; }
        }

        public Color DayBackColor_9
        {
            get { return day_Control_9.DayBackColor; }
            set { day_Control_9.DayBackColor = value; }
        }

        public Color DayBackColor_10
        {
            get { return day_Control_10.DayBackColor; }
            set { day_Control_10.DayBackColor = value; }
        }

        #endregion

        private void Button_DayControl_Today_Click(object sender, EventArgs e)
        {
            TodayDate();
        }

        private void Button_DayControl_PrevMonth_Click(object sender, EventArgs e)
        {
            PreviousMonth();
        }

        private void Button_DayControl_PrevDay_Click(object sender, EventArgs e)
        {
            PreviousDay();
        }

        private void Button_DayControl_NextDay_Click(object sender, EventArgs e)
        {
            NextDay();
        }

        private void Button_DayControl_NextMonth_Click(object sender, EventArgs e)
        {
            NextMonth();
        }
       
        private void TodayDate()
        {
            DateTimeMemory = DateTime.Now;
            DaySideMonthCalendar.SelectionStart = DateTimeMemory;
            DateTimeLabelDay.Text = DateTimeMemory.DayOfWeek.ToString() + "," + " " + DateTimeMemory.ToString("MMMM") + " " + DateTimeMemory.Day.ToString() + "," + " " + DateTimeMemory.Year.ToString();
            month_Control_1.MonthCalendarExport.SelectionStart = DaySideMonthCalendar.SelectionStart;
        }

        private void PreviousMonth()
        {
            DateTimeMemory = DaySideMonthCalendar.SelectionStart.AddMonths(-1);
            DaySideMonthCalendar.SelectionStart = DateTimeMemory;
            DateTimeLabelDay.Text = DateTimeMemory.DayOfWeek.ToString() + "," + " " + DateTimeMemory.ToString("MMMM") + " " + DateTimeMemory.Day.ToString() + "," + " " + DateTimeMemory.Year.ToString();
            month_Control_1.MonthCalendarExport.SelectionStart = DaySideMonthCalendar.SelectionStart;
        }

        private void PreviousDay()
        {
            DateTimeMemory = DaySideMonthCalendar.SelectionStart.AddDays(-1);
            DaySideMonthCalendar.SelectionStart = DateTimeMemory;
            DateTimeLabelDay.Text = DateTimeMemory.DayOfWeek.ToString() + "," + " " + DateTimeMemory.ToString("MMMM") + " " + DateTimeMemory.Day.ToString() + "," + " " + DateTimeMemory.Year.ToString();
            month_Control_1.MonthCalendarExport.SelectionStart = DaySideMonthCalendar.SelectionStart;
        }

        private void NextDay()
        {
            DateTimeMemory = DaySideMonthCalendar.SelectionStart.AddDays(1);
            DaySideMonthCalendar.SelectionStart = DateTimeMemory;
            DateTimeLabelDay.Text = DateTimeMemory.DayOfWeek.ToString() + "," + " " + DateTimeMemory.ToString("MMMM") + " " + DateTimeMemory.Day.ToString() + "," + " " + DateTimeMemory.Year.ToString();
            month_Control_1.MonthCalendarExport.SelectionStart = DaySideMonthCalendar.SelectionStart;
        }

        private void NextMonth()
        {
            DateTimeMemory = DaySideMonthCalendar.SelectionStart.AddMonths(1);
            DaySideMonthCalendar.SelectionStart = DateTimeMemory;
            DateTimeLabelDay.Text = DateTimeMemory.DayOfWeek.ToString() + "," + " " + DateTimeMemory.ToString("MMMM") + " " + DateTimeMemory.Day.ToString() + "," + " " + DateTimeMemory.Year.ToString();
            month_Control_1.MonthCalendarExport.SelectionStart = DaySideMonthCalendar.SelectionStart;
        }

        private void button_DayControlSettings_Click(object sender, EventArgs e)
        {
            Global_Access.dialog_internalsettings.TopMost = true;
            Global_Access.dialog_internalsettings.Show();
        }
    }
}
