using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Calendar_NEW
{
    public partial class Day_Control : UserControl
    {
        Panel Outer_Panel = new Panel();
        Pen LinePen = new Pen(Color.FromArgb(30, 0, 0, 0));
        SolidBrush textBrush = new SolidBrush(Color.Black);
        Color MenuLine = Color.FromArgb(220, 255, 255, 255);
        Color MouseOverNormal = Color.White;
        Color MouseOverHighlight = Color.FromArgb(255, 190, 190, 190);

        Dialog_DataEntry dataform_01 = new Dialog_DataEntry();
        Dialog_DataEntry dataform_02 = new Dialog_DataEntry();
        Dialog_DataEntry dataform_03 = new Dialog_DataEntry();
        Dialog_DataEntry dataform_04 = new Dialog_DataEntry();
        Dialog_DataEntry dataform_05 = new Dialog_DataEntry();
        
        ToolTip ToolTip_01 = new ToolTip();

        public static int dataform_eventlive;

        int ExpandingAdd_01;
        int ExpandingAdd_02;
        int ExpandingAdd_03;
        int ExpandingAdd_04;
        int ExpandingAdd_05;
        int HoldLocation_01;
        int HoldLocation_02;
        int HoldLocation_03;
        int HoldLocation_04;
        int HoldLocation_05;
        int ExpandingSumTotal;
        int[] Expanding_MainHold = new int[8];
        Control LabelCtn = new Control();

        public int event_location;
        public int event_height_holder;

        public Day_Control()
        {
            InitializeComponent();
            Label_Events();
            Day_Overlay_Events();

            // Right CLick Menu Draw
            Outer_Panel.Height = 120;
            Outer_Panel.Width = 120;
            Outer_Panel.BackColor = Color.White;
            Outer_Panel.Visible = false;
            this.Controls.Add(Outer_Panel);

            dataform_01.Owner = this.ParentForm;
            dataform_02.Owner = this.ParentForm;
            dataform_03.Owner = this.ParentForm;
            dataform_04.Owner = this.ParentForm;
            dataform_05.Owner = this.ParentForm;

            dataform_01.TopMost = true;
            dataform_02.TopMost = true;
            dataform_03.TopMost = true;
            dataform_04.TopMost = true;
            dataform_05.TopMost = true;

            // Menu Mouse Events
            Outer_Panel.MouseClick += Outer_Panel_MouseClick;
            Outer_Panel.MouseUp += Outer_Panel_MouseUp;
            Outer_Panel.MouseDown += Outer_Panel_MouseDown;
            Outer_Panel.MouseEnter += Outer_Panel_MouseEnter;
            Outer_Panel.MouseLeave += Outer_Panel_MouseLeave;
            Outer_Panel.MouseMove += Outer_Panel_MouseMove;
            Outer_Panel.MouseHover += Outer_Panel_MouseHover;
            Outer_Panel.MouseWheel += Outer_Panel_MouseWheel;
            Outer_Panel.MouseCaptureChanged += Outer_Panel_MouseCaptureChanged;

            dataform_01.Button_DataEntry_OK.Click += Button_DataEntry_OK_Click1;
            dataform_02.Button_DataEntry_OK.Click += Button_DataEntry_OK_Click2;
            dataform_03.Button_DataEntry_OK.Click += Button_DataEntry_OK_Click3;
            dataform_04.Button_DataEntry_OK.Click += Button_DataEntry_OK_Click4;
            dataform_05.Button_DataEntry_OK.Click += Button_DataEntry_OK_Click5;

            //ToolTip_01.Width = 200;

        }

        private void Button_DataEntry_OK_Click5(object sender, EventArgs e)
        {
            if (Dialog_DataEntry.FormReady == 1)
            {
                Console.WriteLine("5");
                Event_Location
                    (
                    Int32.Parse(dataform_05.comboBox_HourFrom.SelectedItem.ToString()),
                    Int32.Parse(dataform_05.comboBox_MinuteFrom.SelectedItem.ToString()),
                    dataform_05.comboBox_DayFrom.SelectedItem.ToString(),
                    Int32.Parse(dataform_05.comboBox_HourTo.SelectedItem.ToString()),
                    Int32.Parse(dataform_05.comboBox_MinuteTo.SelectedItem.ToString()),
                    dataform_05.comboBox_DayTo.SelectedItem.ToString(), 5
                    );
                Dialog_DataEntry.FormReady = 0;
                ShowEvent();
                ExpandingSumFunction();
                DetectEventWidth();
            }
        }

        private void Button_DataEntry_OK_Click4(object sender, EventArgs e)
        {
            if (Dialog_DataEntry.FormReady == 1)
            {
                Console.WriteLine("4");
                Event_Location
                    (
                    Int32.Parse(dataform_04.comboBox_HourFrom.SelectedItem.ToString()),
                    Int32.Parse(dataform_04.comboBox_MinuteFrom.SelectedItem.ToString()),
                    dataform_04.comboBox_DayFrom.SelectedItem.ToString(),
                    Int32.Parse(dataform_04.comboBox_HourTo.SelectedItem.ToString()),
                    Int32.Parse(dataform_04.comboBox_MinuteTo.SelectedItem.ToString()),
                    dataform_04.comboBox_DayTo.SelectedItem.ToString(), 4
                    );
                Dialog_DataEntry.FormReady = 0;
                ShowEvent();
                ExpandingSumFunction();
                DetectEventWidth();
            }
        }

        private void Button_DataEntry_OK_Click3(object sender, EventArgs e)
        {
            if (Dialog_DataEntry.FormReady == 1)
            {
                Console.WriteLine("3");
                Event_Location
                    (
                    Int32.Parse(dataform_03.comboBox_HourFrom.SelectedItem.ToString()),
                    Int32.Parse(dataform_03.comboBox_MinuteFrom.SelectedItem.ToString()),
                    dataform_03.comboBox_DayFrom.SelectedItem.ToString(),
                    Int32.Parse(dataform_03.comboBox_HourTo.SelectedItem.ToString()),
                    Int32.Parse(dataform_03.comboBox_MinuteTo.SelectedItem.ToString()),
                    dataform_03.comboBox_DayTo.SelectedItem.ToString(), 3
                    );
                Dialog_DataEntry.FormReady = 0;
                ShowEvent();
                ExpandingSumFunction();
                DetectEventWidth();
            }
        }

        private void Button_DataEntry_OK_Click2(object sender, EventArgs e)
        {
            if (Dialog_DataEntry.FormReady == 1)
            {
                Console.WriteLine("2");
                Event_Location
                    (
                    Int32.Parse(dataform_02.comboBox_HourFrom.SelectedItem.ToString()),
                    Int32.Parse(dataform_02.comboBox_MinuteFrom.SelectedItem.ToString()),
                    dataform_02.comboBox_DayFrom.SelectedItem.ToString(),
                    Int32.Parse(dataform_02.comboBox_HourTo.SelectedItem.ToString()),
                    Int32.Parse(dataform_02.comboBox_MinuteTo.SelectedItem.ToString()),
                    dataform_02.comboBox_DayTo.SelectedItem.ToString(), 2
                    );
                Dialog_DataEntry.FormReady = 0;
                ShowEvent();
                ExpandingSumFunction();
                DetectEventWidth();
            }
        }

        private void Button_DataEntry_OK_Click1(object sender, EventArgs e)
        {
            if (Dialog_DataEntry.FormReady == 1)
            {
                Console.WriteLine("1");
                Event_Location
                    (
                    Int32.Parse(dataform_01.comboBox_HourFrom.SelectedItem.ToString()),
                    Int32.Parse(dataform_01.comboBox_MinuteFrom.SelectedItem.ToString()),
                    dataform_01.comboBox_DayFrom.SelectedItem.ToString(),
                    Int32.Parse(dataform_01.comboBox_HourTo.SelectedItem.ToString()),
                    Int32.Parse(dataform_01.comboBox_MinuteTo.SelectedItem.ToString()),
                    dataform_01.comboBox_DayTo.SelectedItem.ToString(), 1
                    );
                Dialog_DataEntry.FormReady = 0;
                ShowEvent();
                ExpandingSumFunction();
                DetectEventWidth();
            }
        }

        private void ShowEvent()
        {
            if (dataform_eventlive == 1)
            {
                Console.WriteLine("Live 1");
                Day_Expanding_Panel_01.Visible = true;
            }

            if (dataform_eventlive == 2)
            {
                Console.WriteLine("Live 2");
                Day_Expanding_Panel_02.Visible = true;
            }

            if (dataform_eventlive == 3)
            {
                Console.WriteLine("Live 3");
                Day_Expanding_Panel_03.Visible = true;
            }

            if (dataform_eventlive == 4)
            {
                Day_Expanding_Panel_04.Visible = true;
            }

            if (dataform_eventlive == 5)
            {
                Day_Expanding_Panel_05.Visible = true;
            }
        }

        private void Outer_Panel_MouseLeave(object sender, EventArgs e)
        {
            Outer_Panel.BackgroundImage = null;
            for (int x = 17; x > 0; x--)
            {
                Outer_Panel.BackColor = Color.FromArgb(x * 15, 255, 255, 255);
                Refresh();
                Thread.Sleep(1);
            }
            Outer_Panel.Visible = false;
        }
        
        private void Outer_Panel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                // Add Event
                if (e.X < 120 && e.X > 0 && e.Y > 0 && e.Y < 20)
                {
                    if (Day_Expanding_Panel_01.Visible == false)
                    {
                        dataform_01.Show();
                        dataform_eventlive = 1;
                        //Global_Access.dialog_dataentry.Owner = this.ParentForm;
                        //Global_Access.dialog_dataentry.Show();

                        // Parameters
                        //Day_Expanding_Panel_01.Visible = true;
                        Day_Expanding_Panel_01.Location = DropDownMenuLocation;
                        Day_Expanding_Panel_01.Height = Label_12AM.Height;
                        // +++Odd Width error Fix
                        //Day_Expanding_Panel_01.Width = 120;
                        Expanding_MainHold[0] = 1;
                        ExpandingAdd_01 = 1;                        
                    }

                    else if(Day_Expanding_Panel_02.Visible == false)
                    {
                        dataform_02.Show();
                        dataform_eventlive = 2;
                        //Day_Expanding_Panel_02.Visible = true;
                        Day_Expanding_Panel_02.Location = DropDownMenuLocation;
                        Day_Expanding_Panel_02.Height = Label_12AM.Height;
                        Expanding_MainHold[1] = 2;
                        ExpandingAdd_02 = 1;
                    }

                    else if (Day_Expanding_Panel_03.Visible == false)
                    {
                        dataform_03.Show();
                        dataform_eventlive = 3;
                        //Day_Expanding_Panel_03.Visible = true;
                        Day_Expanding_Panel_03.Location = DropDownMenuLocation;
                        Day_Expanding_Panel_03.Height = Label_12AM.Height;
                        Expanding_MainHold[2] = 3;
                        ExpandingAdd_03 = 1;
                    }

                    else if (Day_Expanding_Panel_04.Visible == false)
                    {
                        dataform_04.Show();
                        dataform_eventlive = 4;
                        //Day_Expanding_Panel_04.Visible = true;
                        Day_Expanding_Panel_04.Location = DropDownMenuLocation;
                        Day_Expanding_Panel_04.Height = Label_12AM.Height;
                        Expanding_MainHold[3] = 4;
                        ExpandingAdd_04 = 1;
                    }

                    else if (Day_Expanding_Panel_05.Visible == false)
                    {
                        dataform_05.Show();
                        dataform_eventlive = 5;
                        //Day_Expanding_Panel_05.Visible = true;
                        Day_Expanding_Panel_05.Location = DropDownMenuLocation;
                        Day_Expanding_Panel_05.Height = Label_12AM.Height;
                        Expanding_MainHold[4] = 5;
                        ExpandingAdd_05 = 1;
                    }
                    // +++ Non-imperative/ Remove "Day_Expanding_Panel_01.Width = 120 / ExpandingSumTotal;" to view Odd Width error on 01
                    ExpandingSumFunction();
                    Day_Expanding_Panel_01.Width = 120 / ExpandingSumTotal;
                    Day_Expanding_Panel_02.Width = 120 / ExpandingSumTotal;
                    Day_Expanding_Panel_03.Width = 120 / ExpandingSumTotal;
                    Day_Expanding_Panel_04.Width = 120 / ExpandingSumTotal;
                    Day_Expanding_Panel_05.Width = 120 / ExpandingSumTotal;
                    DetectEventWidth();
                    Outer_Panel_MouseLeave(sender, e);
                }

                // Remove Event
                if (e.X < 120 && e.X > 0 && e.Y > 20 && e.Y < 40)
                {
                    if (WhichControlUnderMouse == 1)
                    {
                        Day_Expanding_Panel_01.Visible = false;
                        Day_Expanding_Panel_01.Location = new Point(-100, -100);
                        Day_Expanding_Panel_01.Height = 20;
                        ExpandingAdd_01 = 0;
                        Expanding_MainHold[0] = 0;
                        Outer_Panel_MouseLeave(sender, e);
                    }

                    if (WhichControlUnderMouse == 2)
                    {
                        Day_Expanding_Panel_02.Visible = false;
                        Day_Expanding_Panel_02.Location = new Point(-100, -100);
                        Day_Expanding_Panel_02.Height = 20;
                        ExpandingAdd_02 = 0;
                        Expanding_MainHold[1] = 0;
                        Outer_Panel_MouseLeave(sender, e);
                    }

                    if (WhichControlUnderMouse == 3)
                    {
                        Day_Expanding_Panel_03.Visible = false;
                        Day_Expanding_Panel_03.Location = new Point(-100, -100);
                        Day_Expanding_Panel_03.Height = 20;
                        ExpandingAdd_03 = 0;
                        Expanding_MainHold[2] = 0;
                        Outer_Panel_MouseLeave(sender, e);
                    }

                    if (WhichControlUnderMouse == 4)
                    {
                        Day_Expanding_Panel_04.Visible = false;
                        Day_Expanding_Panel_04.Location = new Point(-100, -100);
                        Day_Expanding_Panel_04.Height = 20;
                        ExpandingAdd_04 = 0;
                        Expanding_MainHold[3] = 0;
                        Outer_Panel_MouseLeave(sender, e);
                    }

                    if (WhichControlUnderMouse == 5)
                    {
                        Day_Expanding_Panel_05.Visible = false;
                        Day_Expanding_Panel_05.Location = new Point(-100, -100);
                        Day_Expanding_Panel_05.Height = 20;
                        ExpandingAdd_05 = 0;
                        Expanding_MainHold[4] = 0;
                        Outer_Panel_MouseLeave(sender, e);
                    }
                    if (Day_Expanding_Panel_01.Visible != false)
                    {
                        ExpandingSumFunction();
                        DetectEventWidth();
                    }
                }

                // Properties of Event
                if (e.X < 120 && e.X > 0 && e.Y > 40 && e.Y < 60)
                {
                    if (WhichControlUnderMouse == 1)
                    {
                        dataform_01.Show();
                    }

                    if (WhichControlUnderMouse == 2)
                    {
                        dataform_02.Show();
                    }

                    if (WhichControlUnderMouse == 3)
                    {
                        dataform_03.Show();
                    }

                    if (WhichControlUnderMouse == 4)
                    {
                        dataform_04.Show();
                    }

                    if (WhichControlUnderMouse == 5)
                    {
                        dataform_05.Show();
                    }
                }

                if (e.X < 120 && e.X > 0 && e.Y > 60 && e.Y < 80)
                {
                    Global_Access.MonolithConsole("P4");
                }

                if (e.X < 120 && e.X > 0 && e.Y > 80 && e.Y < 100)
                {
                    Global_Access.MonolithConsole("P5");
                }

                if (e.X < 120 && e.X > 0 && e.Y > 100 && e.Y < 120)
                {
                    Outer_Panel_MouseLeave(sender, e);
                }
            }
            Global_Access.MonolithConsole("Menu Mouse Down");
            DetectEventWidth();
        }       

        #region // Menu Mouse Events Arguments
        private void Outer_Panel_MouseMove(object sender, MouseEventArgs e)
        {
            Color MouseOverHighlight = Color.FromArgb(255, 190, 190, 190);
            Graphics textGraphics = Outer_Panel.CreateGraphics();
            SolidBrush SolidBrushHL = new SolidBrush(MouseOverHighlight);
            SolidBrush SolidBrushNO = new SolidBrush(MouseOverNormal);
            textGraphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            int TextMarginLeft = 10;
            int TextMarginTop = 2;

            // Button Add Event
            if (e.X < 120 && e.X > 0 && e.Y > 0 && e.Y < 20)
            {                
                Graphics formGraphics1 = Outer_Panel.CreateGraphics();
                formGraphics1.FillRectangle(SolidBrushHL, new Rectangle(Outer_Panel.Left, 0, Outer_Panel.Width, Outer_Panel.Height / 6));
                textGraphics.DrawString("Add Event", fnt, textBrush, new PointF(TextMarginLeft, TextMarginTop));
            }
            else
            {                
                Graphics formGraphics1 = Outer_Panel.CreateGraphics();
                formGraphics1.FillRectangle(SolidBrushNO, new Rectangle(Outer_Panel.Left, 0, Outer_Panel.Width, Outer_Panel.Height / 6));
                textGraphics.DrawString("Add Event", fnt, textBrush, new PointF(TextMarginLeft, TextMarginTop));
            }

            // Button Delete Event
            if (e.X < 120 && e.X > 0 && e.Y > 20 && e.Y < 40)
            {
                Graphics formGraphics2 = Outer_Panel.CreateGraphics();
                formGraphics2.FillRectangle(SolidBrushHL, new Rectangle(Outer_Panel.Left, 20, Outer_Panel.Width, Outer_Panel.Height / 6));
                textGraphics.DrawString("Delete Event", fnt, textBrush, new PointF(TextMarginLeft, 20 + TextMarginTop));
            }
            else
            {                
                Graphics formGraphics2 = Outer_Panel.CreateGraphics();
                formGraphics2.FillRectangle(SolidBrushNO, new Rectangle(Outer_Panel.Left, 20, Outer_Panel.Width, Outer_Panel.Height / 6));
                textGraphics.DrawString("Delete Event", fnt, textBrush, new PointF(TextMarginLeft, 20 + TextMarginTop));
            }

            // Button Properties
            if (e.X < 120 && e.X > 0 && e.Y > 40 && e.Y < 60)
            {
                Graphics formGraphics3 = Outer_Panel.CreateGraphics();
                formGraphics3.FillRectangle(SolidBrushHL, new Rectangle(Outer_Panel.Left, 40, Outer_Panel.Width, Outer_Panel.Height / 6));
                textGraphics.DrawString("Properties", fnt, textBrush, new PointF(TextMarginLeft, 40 + TextMarginTop));
            }
            else
            {
                Graphics formGraphics3 = Outer_Panel.CreateGraphics();
                formGraphics3.FillRectangle(SolidBrushNO, new Rectangle(Outer_Panel.Left, 40, Outer_Panel.Width, Outer_Panel.Height / 6));
                textGraphics.DrawString("Properties", fnt, textBrush, new PointF(TextMarginLeft, 40 + TextMarginTop));
            }

            // Button Copy
            if (e.X < 120 && e.X > 0 && e.Y > 60 && e.Y < 80)
            {
                Graphics formGraphics4 = Outer_Panel.CreateGraphics();
                formGraphics4.FillRectangle(SolidBrushHL, new Rectangle(Outer_Panel.Left, 60, Outer_Panel.Width, Outer_Panel.Height / 6));
                textGraphics.DrawString("Copy", fnt, textBrush, new PointF(TextMarginLeft, 60 + TextMarginTop));
            }
            else
            {
                Graphics formGraphics4 = Outer_Panel.CreateGraphics();
                formGraphics4.FillRectangle(SolidBrushNO, new Rectangle(Outer_Panel.Left, 60, Outer_Panel.Width, Outer_Panel.Height / 6));
                textGraphics.DrawString("Copy", fnt, textBrush, new PointF(TextMarginLeft, 60 + TextMarginTop));
            }

            // Button Paste
            if (e.X < 120 && e.X > 0 && e.Y > 80 && e.Y < 100)
            {
                Graphics formGraphics5 = Outer_Panel.CreateGraphics();
                formGraphics5.FillRectangle(SolidBrushHL, new Rectangle(Outer_Panel.Left, 80, Outer_Panel.Width, Outer_Panel.Height / 6));
                textGraphics.DrawString("Paste", fnt, textBrush, new PointF(TextMarginLeft, 80 + TextMarginTop));
            }
            else
            {
                Graphics formGraphics5 = Outer_Panel.CreateGraphics();
                formGraphics5.FillRectangle(SolidBrushNO, new Rectangle(Outer_Panel.Left, 80, Outer_Panel.Width, Outer_Panel.Height / 6));
                textGraphics.DrawString("Paste", fnt, textBrush, new PointF(TextMarginLeft, 80 + TextMarginTop));
            }

            // Button Cancel
            if (e.X < 120 && e.X > 0 && e.Y > 100 && e.Y < 120)
            {
                Graphics formGraphics6 = Outer_Panel.CreateGraphics();
                formGraphics6.FillRectangle(SolidBrushHL, new Rectangle(Outer_Panel.Left, 100, Outer_Panel.Width, Outer_Panel.Height / 6));
                textGraphics.DrawString("Cancel", fnt, textBrush, new PointF(TextMarginLeft, 100 + TextMarginTop));
            }
            else
            {
                Graphics formGraphics6 = Outer_Panel.CreateGraphics();
                formGraphics6.FillRectangle(SolidBrushNO, new Rectangle(Outer_Panel.Left, 100, Outer_Panel.Width, Outer_Panel.Height / 6));
                //formGraphics6.DrawLine(LinePen, new Point(0, 100), new Point(120, 100));
                textGraphics.DrawString("Cancel", fnt, textBrush, new PointF(TextMarginLeft, 100 + TextMarginTop));
            }

        }

        private void Outer_Panel_MouseCaptureChanged(object sender, EventArgs e)
        {
            /*
            if (e.X < 120 && e.X > 0 && e.Y > 0 && e.Y < 20)
            {
                Console.WriteLine("P1");
            }
            if (e.X < 120 && e.X > 0 && e.Y > 20 && e.Y < 40)
            {
            }
            if (e.X < 120 && e.X > 0 && e.Y > 40 && e.Y < 60)
            {
                Console.WriteLine("P3");
            }
            if (e.X < 120 && e.X > 0 && e.Y > 60 && e.Y < 80)
            {
                Console.WriteLine("P4");
            }
            if (e.X < 120 && e.X > 0 && e.Y > 80 && e.Y < 100)
            {
                Outer_Panel_MouseLeave(sender, e);
            }
            */
        }

        private void Outer_Panel_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.X < 120 && e.X > 0 && e.Y > 0 && e.Y < 20)
            {
                Global_Access.MonolithConsole("P1");
            }
            if (e.X < 120 && e.X > 0 && e.Y > 20 && e.Y < 40)
            {
                Global_Access.MonolithConsole("P1");
            }
            if (e.X < 120 && e.X > 0 && e.Y > 40 && e.Y < 60)
            {
                Global_Access.MonolithConsole("P3");
            }
            if (e.X < 120 && e.X > 0 && e.Y > 60 && e.Y < 80)
            {
                Global_Access.MonolithConsole("P4");
            }
            if (e.X < 120 && e.X > 0 && e.Y > 80 && e.Y < 100)
            {
                Global_Access.MonolithConsole("P1");
            }
        }

        private void Outer_Panel_MouseHover(object sender, EventArgs e)
        {
            /*
            if (e.X < 120 && e.X > 0 && e.Y > 0 && e.Y < 20)
            {
                Console.WriteLine("P1");
            }
            if (e.X < 120 && e.X > 0 && e.Y > 20 && e.Y < 40)
            {
                Console.WriteLine("P1");
            }
            if (e.X < 120 && e.X > 0 && e.Y > 40 && e.Y < 60)
            {
                Console.WriteLine("P3");
            }
            if (e.X < 120 && e.X > 0 && e.Y > 60 && e.Y < 80)
            {
                Console.WriteLine("P4");
            }
            if (e.X < 120 && e.X > 0 && e.Y > 80 && e.Y < 100)
            {
                Console.WriteLine("P5");
            }*/
        }

        private void Outer_Panel_MouseClick(object sender, MouseEventArgs e)
        {
            /*
            if (e.X < 120 && e.X > 0 && e.Y > 0 && e.Y < 20)
            {
                Console.WriteLine("P1");
            }
            if (e.X < 120 && e.X > 0 && e.Y > 20 && e.Y < 40)
            {
                Console.WriteLine("P1");
            }
            if (e.X < 120 && e.X > 0 && e.Y > 40 && e.Y < 60)
            {
                Console.WriteLine("P3");
            }
            if (e.X < 120 && e.X > 0 && e.Y > 60 && e.Y < 80)
            {
                Console.WriteLine("P4");
            }
            if (e.X < 120 && e.X > 0 && e.Y > 80 && e.Y < 100)
            {
                Console.WriteLine("P5");
            }*/
        }

        private void Outer_Panel_MouseEnter(object sender, EventArgs e)
        {
            /*
            if (e.X < 120 && e.X > 0 && e.Y > 0 && e.Y < 20)
            {
                Console.WriteLine("P1");
            }
            if (e.X < 120 && e.X > 0 && e.Y > 20 && e.Y < 40)
            {
                Console.WriteLine("P1");
            }
            if (e.X < 120 && e.X > 0 && e.Y > 40 && e.Y < 60)
            {
                Console.WriteLine("P3");
            }
            if (e.X < 120 && e.X > 0 && e.Y > 60 && e.Y < 80)
            {
                Console.WriteLine("P4");
            }
            if (e.X < 120 && e.X > 0 && e.Y > 80 && e.Y < 100)
            {
                Console.WriteLine("P5");
            }*/
        }

        private void Outer_Panel_MouseUp(object sender, MouseEventArgs e)
        {
            /*
            if (e.X < 120 && e.X > 0 && e.Y > 0 && e.Y < 20)
            {
                Console.WriteLine("P1");
            }
            if (e.X < 120 && e.X > 0 && e.Y > 20 && e.Y < 40)
            {
                Console.WriteLine("P1");
            }
            if (e.X < 120 && e.X > 0 && e.Y > 40 && e.Y < 60)
            {
                Console.WriteLine("P3");
            }
            if (e.X < 120 && e.X > 0 && e.Y > 60 && e.Y < 80)
            {
                Console.WriteLine("P4");
            }
            if (e.X < 120 && e.X > 0 && e.Y > 80 && e.Y < 100)
            {
                Console.WriteLine("P5");
            }*/
        }

        public Color DayBackColor
        {
            get { return this.BackColor; }
            set { this.BackColor = value; }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Color LightWhite = Color.FromArgb(80, 255,255,255);
            for(int x = 0; x <161; x++)
            {
                int startX = x * 10;
                Graphics g;
                g = e.Graphics;
                Pen myPen = new Pen(LightWhite);
                myPen.Width = 1;
                g.DrawLine(myPen, 0, startX + startX + 20, 120, startX + startX + 20);
            }
        }
        #endregion

        public void ExpandingSumFunction()
        {
            ExpandingSumTotal = ExpandingAdd_01 + ExpandingAdd_02 + ExpandingAdd_03 + ExpandingAdd_04 + ExpandingAdd_05;
            Global_Access.MonolithConsole("_____________________________");
            int EventSpacing = 120 / ExpandingSumTotal;
            int[] Expanding_Locations = new int[] { 0, EventSpacing, EventSpacing * 2, EventSpacing * 3, EventSpacing * 4, EventSpacing * 5 };
            int[] Expanding_Array_Transfer = new int[6];
            int HoldCounter = 0;
            for (int x = 0; x < 6; x++)
            {
                if (Expanding_MainHold[x] != 0)
                {
                    Global_Access.MonolithConsole("Stored Location: " + Expanding_Locations[HoldCounter]);
                    Expanding_Array_Transfer[x] = Expanding_MainHold[x];
                    if(Expanding_Array_Transfer[x] == 1)
                    {
                        Day_Expanding_Panel_01.Left = Expanding_Locations[HoldCounter];
                        HoldLocation_01 = Expanding_Locations[HoldCounter];
                    }

                    if (Expanding_Array_Transfer[x] == 2)
                    {
                        Day_Expanding_Panel_02.Left = Expanding_Locations[HoldCounter];
                        HoldLocation_02 = Expanding_Locations[HoldCounter];
                    }

                    if (Expanding_Array_Transfer[x] == 3)
                    {
                        Day_Expanding_Panel_03.Left = Expanding_Locations[HoldCounter];
                        HoldLocation_03 = Expanding_Locations[HoldCounter];
                    }

                    if (Expanding_Array_Transfer[x] == 4)
                    {
                        Day_Expanding_Panel_04.Left = Expanding_Locations[HoldCounter];
                        HoldLocation_04 = Expanding_Locations[HoldCounter];
                    }

                    if (Expanding_Array_Transfer[x] == 5)
                    {
                        Day_Expanding_Panel_05.Left = Expanding_Locations[HoldCounter];
                        HoldLocation_05 = Expanding_Locations[HoldCounter];
                    }                   

                    HoldCounter = HoldCounter + 1;

                    Global_Access.MonolithConsole("Stored Integers: " + Expanding_Array_Transfer[x]);
                }
            }
        }

        public void Event_Location(int FROMhour, int FROMminute, string FROMday, int TOhour, int TOminute, string TOday, int FormNumber)
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

                if (FormNumber == 1)
                {
                    Day_Expanding_Panel_01.Location = new Point(0, event_location);
                    Day_Expanding_Panel_01.Height = event_height_holder - event_location;
                }

                if (FormNumber == 2)
                {
                    Day_Expanding_Panel_02.Location = new Point(0, event_location);
                    Day_Expanding_Panel_02.Height = event_height_holder - event_location;
                }

                if (FormNumber == 3)
                {
                    Day_Expanding_Panel_03.Location = new Point(0, event_location);
                    Day_Expanding_Panel_03.Height = event_height_holder - event_location;
                }

                if (FormNumber == 4)
                {
                    Day_Expanding_Panel_04.Location = new Point(0, event_location);
                    Day_Expanding_Panel_04.Height = event_height_holder - event_location;
                }

                if (FormNumber == 5)
                {
                    Day_Expanding_Panel_05.Location = new Point(0, event_location);
                    Day_Expanding_Panel_05.Height = event_height_holder - event_location;
                }
           
        }

    }
}