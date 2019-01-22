using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Calendar_NEW
{
    partial class Day_Control
    {
        Color HighlightColor = Color.FromArgb(50, 255, 255, 255);
        Color InactiveAreaColor = Color.FromArgb(50, 0, 0, 0);
        Color Transparent= Color.Transparent;
        Point DropDownMenuLocation = new Point();
        Label inactiveAreaLabel_Top = new Label();
        Label inactiveAreaLabel_Bottom = new Label();
        Font fnt = new Font(new FontFamily ("Century Gothic"), 8.5f, FontStyle.Regular);
        int Thrower = 0;
        private void Label_Events()
        {
            #region // Click Events
           
            Label_12AM.MouseMove += Label_12AM_MouseMove;
            Label_12AM.MouseDown += Label_12AM_MouseDown;
            Label_12AM.MouseEnter += Label_12AM_MouseEnter;
            Label_12AM.MouseLeave += Label_12AM_MouseLeave;
            Label_12AM.MouseClick += Label_12AM_MouseClick;
            Label_12AM.MouseDoubleClick += Label_12AM_MouseDoubleClick;
            Label_12_30AM.MouseEnter += Label_12_30AM_MouseEnter;
            Label_12_30AM.MouseLeave += Label_12_30AM_MouseLeave;
            Label_12_30AM.MouseClick += Label_12_30AM_MouseClick;
            Label_12_30AM.MouseDoubleClick += Label_12_30AM_MouseDoubleClick;
            Label_1AM.MouseEnter += Label_1AM_MouseEnter;
            Label_1AM.MouseLeave += Label_1AM_MouseLeave;
            Label_1AM.MouseClick += Label_1AM_MouseClick;
            Label_1AM.MouseDoubleClick += Label_1AM_MouseDoubleClick;
            Label_1_30AM.MouseEnter += Label_1_30AM_MouseEnter;
            Label_1_30AM.MouseLeave += Label_1_30AM_MouseLeave;
            Label_1_30AM.MouseClick += Label_1_30AM_MouseClick;
            Label_1_30AM.MouseDoubleClick += Label_1_30AM_MouseDoubleClick;
            Label_2AM.MouseEnter += Label_2AM_MouseEnter;
            Label_2AM.MouseLeave += Label_2AM_MouseLeave;
            Label_2AM.MouseClick += Label_2AM_MouseClick;
            Label_2AM.MouseDoubleClick += Label_2AM_MouseDoubleClick;
            Label_2_30AM.MouseEnter += Label_2_30AM_MouseEnter;
            Label_2_30AM.MouseLeave += Label_2_30AM_MouseLeave;
            Label_2_30AM.MouseClick += Label_2_30AM_MouseClick;
            Label_2_30AM.MouseDoubleClick += Label_2_30AM_MouseDoubleClick;
            Label_3AM.MouseEnter += Label_3AM_MouseEnter;
            Label_3AM.MouseLeave += Label_3AM_MouseLeave;
            Label_3AM.MouseClick += Label_3AM_MouseClick;
            Label_3AM.MouseDoubleClick += Label_3AM_MouseDoubleClick;
            Label_3_30AM.MouseEnter += Label_3_30AM_MouseEnter;
            Label_3_30AM.MouseLeave += Label_3_30AM_MouseLeave;
            Label_3_30AM.MouseClick += Label_3_30AM_MouseClick;
            Label_3_30AM.MouseDoubleClick += Label_3_30AM_MouseDoubleClick;

            Label_4AM.DragEnter += Label_4AM_DragEnter;
            Label_4AM.MouseEnter += Label_4AM_MouseEnter;
            Label_4AM.MouseLeave += Label_4AM_MouseLeave;
            Label_4AM.MouseClick += Label_4AM_MouseClick;
            Label_4AM.MouseDoubleClick += Label_4AM_MouseDoubleClick;
            Label_4_30AM.MouseEnter += Label_4_30AM_MouseEnter;
            Label_4_30AM.MouseLeave += Label_4_30AM_MouseLeave;
            Label_4_30AM.MouseClick += Label_4_30AM_MouseClick;
            Label_4_30AM.MouseDoubleClick += Label_4_30AM_MouseDoubleClick;
            Label_5AM.MouseEnter += Label_5AM_MouseEnter;
            Label_5AM.MouseLeave += Label_5AM_MouseLeave;
            Label_5AM.MouseClick += Label_5AM_MouseClick;
            Label_5AM.MouseDoubleClick += Label_5AM_MouseDoubleClick;
            Label_5_30AM.MouseEnter += Label_5_30AM_MouseEnter;
            Label_5_30AM.MouseLeave += Label_5_30AM_MouseLeave;
            Label_5_30AM.MouseClick += Label_5_30AM_MouseClick;
            Label_5_30AM.MouseDoubleClick += Label_5_30AM_MouseDoubleClick;
            Label_6AM.MouseEnter += Label_6AM_MouseEnter;
            Label_6AM.MouseLeave += Label_6AM_MouseLeave;
            Label_6AM.MouseClick += Label_6AM_MouseClick;
            Label_6AM.MouseDoubleClick += Label_6AM_MouseDoubleClick;
            Label_6_30AM.MouseEnter += Label_6_30AM_MouseEnter;
            Label_6_30AM.MouseLeave += Label_6_30AM_MouseLeave;
            Label_6_30AM.MouseClick += Label_6_30AM_MouseClick;
            Label_6_30AM.MouseDoubleClick += Label_2_30AM_MouseDoubleClick;
            Label_7AM.MouseEnter += Label_7AM_MouseEnter;
            Label_7AM.MouseLeave += Label_7AM_MouseLeave;
            Label_7AM.MouseClick += Label_7AM_MouseClick;
            Label_7AM.MouseDoubleClick += Label_7AM_MouseDoubleClick;
            Label_7_30AM.MouseEnter += Label_7_30AM_MouseEnter;
            Label_7_30AM.MouseLeave += Label_7_30AM_MouseLeave;
            Label_7_30AM.MouseClick += Label_7_30AM_MouseClick;
            Label_7_30AM.MouseDoubleClick += Label_7_30AM_MouseDoubleClick;

            Label_8AM.MouseEnter += Label_8AM_MouseEnter;
            Label_8AM.MouseLeave += Label_8AM_MouseLeave;
            Label_8AM.MouseClick += Label_8AM_MouseClick;
            Label_8AM.MouseDoubleClick += Label_8AM_MouseDoubleClick;
            Label_8_30AM.MouseEnter += Label_8_30AM_MouseEnter;
            Label_8_30AM.MouseLeave += Label_8_30AM_MouseLeave;
            Label_8_30AM.MouseClick += Label_8_30AM_MouseClick;
            Label_8_30AM.MouseDoubleClick += Label_8_30AM_MouseDoubleClick;
            Label_9AM.MouseEnter += Label_9AM_MouseEnter;
            Label_9AM.MouseLeave += Label_9AM_MouseLeave;
            Label_9AM.MouseClick += Label_9AM_MouseClick;
            Label_9AM.MouseDoubleClick += Label_9AM_MouseDoubleClick;
            Label_9_30AM.MouseEnter += Label_9_30AM_MouseEnter;
            Label_9_30AM.MouseLeave += Label_9_30AM_MouseLeave;
            Label_9_30AM.MouseClick += Label_9_30AM_MouseClick;
            Label_9_30AM.MouseDoubleClick += Label_9_30AM_MouseDoubleClick;
            Label_10AM.MouseEnter += Label_10AM_MouseEnter;
            Label_10AM.MouseLeave += Label_10AM_MouseLeave;
            Label_10AM.MouseClick += Label_10AM_MouseClick;
            Label_10AM.MouseDoubleClick += Label_10AM_MouseDoubleClick;
            Label_10_30AM.MouseEnter += Label_10_30AM_MouseEnter;
            Label_10_30AM.MouseLeave += Label_10_30AM_MouseLeave;
            Label_10_30AM.MouseClick += Label_10_30AM_MouseClick;
            Label_10_30AM.MouseDoubleClick += Label_10_30AM_MouseDoubleClick;
            Label_11AM.MouseEnter += Label_11AM_MouseEnter;
            Label_11AM.MouseLeave += Label_11AM_MouseLeave;
            Label_11AM.MouseClick += Label_11AM_MouseClick;
            Label_11AM.MouseDoubleClick += Label_11AM_MouseDoubleClick;
            Label_11_30AM.MouseEnter += Label_11_30AM_MouseEnter;
            Label_11_30AM.MouseLeave += Label_11_30AM_MouseLeave;
            Label_11_30AM.MouseClick += Label_11_30AM_MouseClick;
            Label_11_30AM.MouseDoubleClick += Label_11_30AM_MouseDoubleClick;

            Label_12PM.MouseEnter += Label_12PM_MouseEnter;
            Label_12PM.MouseLeave += Label_12PM_MouseLeave;
            Label_12PM.MouseClick += Label_12PM_MouseClick;
            Label_12PM.MouseDoubleClick += Label_12PM_MouseDoubleClick;
            Label_12_30PM.MouseEnter += Label_12_30PM_MouseEnter;
            Label_12_30PM.MouseLeave += Label_12_30PM_MouseLeave;
            Label_12_30PM.MouseClick += Label_12_30PM_MouseClick;
            Label_12_30PM.MouseDoubleClick += Label_12_30PM_MouseDoubleClick;
            Label_1PM.MouseEnter += Label_1PM_MouseEnter;
            Label_1PM.MouseLeave += Label_1PM_MouseLeave;
            Label_1PM.MouseClick += Label_1PM_MouseClick;
            Label_1PM.MouseDoubleClick += Label_1PM_MouseDoubleClick;
            Label_1_30PM.MouseEnter += Label_1_30PM_MouseEnter;
            Label_1_30PM.MouseLeave += Label_1_30PM_MouseLeave;
            Label_1_30PM.MouseClick += Label_1_30PM_MouseClick;
            Label_1_30PM.MouseDoubleClick += Label_1_30PM_MouseDoubleClick;
            Label_2PM.MouseEnter += Label_2PM_MouseEnter;
            Label_2PM.MouseLeave += Label_2PM_MouseLeave;
            Label_2PM.MouseClick += Label_2PM_MouseClick;
            Label_2PM.MouseDoubleClick += Label_2PM_MouseDoubleClick;
            Label_2_30PM.MouseEnter += Label_2_30PM_MouseEnter;
            Label_2_30PM.MouseLeave += Label_2_30PM_MouseLeave;
            Label_2_30PM.MouseClick += Label_2_30PM_MouseClick;
            Label_2_30PM.MouseDoubleClick += Label_2_30PM_MouseDoubleClick;
            Label_3PM.MouseEnter += Label_3PM_MouseEnter;
            Label_3PM.MouseLeave += Label_3PM_MouseLeave;
            Label_3PM.MouseClick += Label_3PM_MouseClick;
            Label_3PM.MouseDoubleClick += Label_3PM_MouseDoubleClick;
            Label_3_30PM.MouseEnter += Label_3_30PM_MouseEnter;
            Label_3_30PM.MouseLeave += Label_3_30PM_MouseLeave;
            Label_3_30PM.MouseClick += Label_3_30PM_MouseClick;
            Label_3_30PM.MouseDoubleClick += Label_3_30PM_MouseDoubleClick;

            Label_4PM.MouseEnter += Label_4PM_MouseEnter;
            Label_4PM.MouseLeave += Label_4PM_MouseLeave;
            Label_4PM.MouseClick += Label_4PM_MouseClick;
            Label_4PM.MouseDoubleClick += Label_4PM_MouseDoubleClick;
            Label_4_30PM.MouseEnter += Label_4_30PM_MouseEnter;
            Label_4_30PM.MouseLeave += Label_4_30PM_MouseLeave;
            Label_4_30PM.MouseClick += Label_4_30PM_MouseClick;
            Label_4_30PM.MouseDoubleClick += Label_4_30PM_MouseDoubleClick;
            Label_5PM.MouseEnter += Label_5PM_MouseEnter;
            Label_5PM.MouseLeave += Label_5PM_MouseLeave;
            Label_5PM.MouseClick += Label_5PM_MouseClick;
            Label_5PM.MouseDoubleClick += Label_5PM_MouseDoubleClick;
            Label_5_30PM.MouseEnter += Label_5_30PM_MouseEnter;
            Label_5_30PM.MouseLeave += Label_5_30PM_MouseLeave;
            Label_5_30PM.MouseClick += Label_5_30PM_MouseClick;
            Label_5_30PM.MouseDoubleClick += Label_5_30PM_MouseDoubleClick;
            Label_6PM.MouseEnter += Label_6PM_MouseEnter;
            Label_6PM.MouseLeave += Label_6PM_MouseLeave;
            Label_6PM.MouseClick += Label_6PM_MouseClick;
            Label_6PM.MouseDoubleClick += Label_6PM_MouseDoubleClick;
            Label_6_30PM.MouseEnter += Label_6_30PM_MouseEnter;
            Label_6_30PM.MouseLeave += Label_6_30PM_MouseLeave;
            Label_6_30PM.MouseClick += Label_6_30PM_MouseClick;
            Label_6_30PM.MouseDoubleClick += Label_2_30PM_MouseDoubleClick;
            Label_7PM.MouseEnter += Label_7PM_MouseEnter;
            Label_7PM.MouseLeave += Label_7PM_MouseLeave;
            Label_7PM.MouseClick += Label_7PM_MouseClick;
            Label_7PM.MouseDoubleClick += Label_7PM_MouseDoubleClick;
            Label_7_30PM.MouseEnter += Label_7_30PM_MouseEnter;
            Label_7_30PM.MouseLeave += Label_7_30PM_MouseLeave;
            Label_7_30PM.MouseClick += Label_7_30PM_MouseClick;
            Label_7_30PM.MouseDoubleClick += Label_7_30PM_MouseDoubleClick;

            Label_8PM.MouseEnter += Label_8PM_MouseEnter;
            Label_8PM.MouseLeave += Label_8PM_MouseLeave;
            Label_8PM.MouseClick += Label_8PM_MouseClick;
            Label_8PM.MouseDoubleClick += Label_8PM_MouseDoubleClick;
            Label_8_30PM.MouseEnter += Label_8_30PM_MouseEnter;
            Label_8_30PM.MouseLeave += Label_8_30PM_MouseLeave;
            Label_8_30PM.MouseClick += Label_8_30PM_MouseClick;
            Label_8_30PM.MouseDoubleClick += Label_8_30PM_MouseDoubleClick;
            Label_9PM.MouseEnter += Label_9PM_MouseEnter;
            Label_9PM.MouseLeave += Label_9PM_MouseLeave;
            Label_9PM.MouseClick += Label_9PM_MouseClick;
            Label_9PM.MouseDoubleClick += Label_9PM_MouseDoubleClick;
            Label_9_30PM.MouseEnter += Label_9_30PM_MouseEnter;
            Label_9_30PM.MouseLeave += Label_9_30PM_MouseLeave;
            Label_9_30PM.MouseClick += Label_9_30PM_MouseClick;
            Label_9_30PM.MouseDoubleClick += Label_9_30PM_MouseDoubleClick;
            Label_10PM.MouseEnter += Label_10PM_MouseEnter;
            Label_10PM.MouseLeave += Label_10PM_MouseLeave;
            Label_10PM.MouseClick += Label_10PM_MouseClick;
            Label_10PM.MouseDoubleClick += Label_10PM_MouseDoubleClick;
            Label_10_30PM.MouseEnter += Label_10_30PM_MouseEnter;
            Label_10_30PM.MouseLeave += Label_10_30PM_MouseLeave;
            Label_10_30PM.MouseClick += Label_10_30PM_MouseClick;
            Label_10_30PM.MouseDoubleClick += Label_10_30PM_MouseDoubleClick;
            Label_11PM.MouseEnter += Label_11PM_MouseEnter;
            Label_11PM.MouseLeave += Label_11PM_MouseLeave;
            Label_11PM.MouseClick += Label_11PM_MouseClick;
            Label_11PM.MouseDoubleClick += Label_11PM_MouseDoubleClick;
            Label_11_30PM.MouseEnter += Label_11_30PM_MouseEnter;
            Label_11_30PM.MouseLeave += Label_11_30PM_MouseLeave;
            Label_11_30PM.MouseClick += Label_11_30PM_MouseClick;
            Label_11_30PM.MouseDoubleClick += Label_11_30PM_MouseDoubleClick;

            #endregion

            inactiveAreaLabel_Top.BackColor = InactiveAreaColor;
            inactiveAreaLabel_Top.Location = new Point(0, 0);
            inactiveAreaLabel_Top.Size = new Size(120, 20);
            inactiveAreaLabel_Top.Location = new Point(0,0);
            this.Controls.Add(inactiveAreaLabel_Top);
            inactiveAreaLabel_Top.BringToFront();

            inactiveAreaLabel_Bottom.BackColor = InactiveAreaColor;
            inactiveAreaLabel_Bottom.Location = new Point(0, 0);
            inactiveAreaLabel_Bottom.Size = new Size(120, 40);
            inactiveAreaLabel_Bottom.Location = new Point(0, 960);
            this.Controls.Add(inactiveAreaLabel_Bottom);
            inactiveAreaLabel_Bottom.BringToFront();
        }

        private void Label_4AM_DragEnter(object sender, DragEventArgs e)
        {
            Global_Access.MonolithConsole("Control Entered");
        }

        private void LabelShow()
        {
            Outer_Panel.BackColor = Color.White;
            Outer_Panel.Location = DropDownMenuLocation;
            Outer_Panel.Visible = true;
            Outer_Panel.BringToFront();

            Color MouseOverHighlight = Color.FromArgb(255, 190, 190, 190);
            Graphics textGraphics = Outer_Panel.CreateGraphics();
            SolidBrush SolidBrushHL = new SolidBrush(MouseOverHighlight);
            SolidBrush SolidBrushNO = new SolidBrush(MouseOverNormal);
            textGraphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            int TextMarginLeft = 10;
            int TextMarginTop = 2;

            // Button Add Event
            Graphics formGraphics1 = Outer_Panel.CreateGraphics();
            formGraphics1.FillRectangle(SolidBrushNO, new Rectangle(Outer_Panel.Left, 0, Outer_Panel.Width, Outer_Panel.Height / 6));
            textGraphics.DrawString("Add Event", fnt, textBrush, new PointF(TextMarginLeft, TextMarginTop));

            Graphics formGraphics2 = Outer_Panel.CreateGraphics();
            formGraphics2.FillRectangle(SolidBrushNO, new Rectangle(Outer_Panel.Left, 20, Outer_Panel.Width, Outer_Panel.Height / 6));
            textGraphics.DrawString("Delete Event", fnt, textBrush, new PointF(TextMarginLeft, 20 + TextMarginTop));

            Graphics formGraphics3 = Outer_Panel.CreateGraphics();
            formGraphics3.FillRectangle(SolidBrushNO, new Rectangle(Outer_Panel.Left, 40, Outer_Panel.Width, Outer_Panel.Height / 6));
            textGraphics.DrawString("Properties", fnt, textBrush, new PointF(TextMarginLeft, 40 + TextMarginTop));

            Graphics formGraphics4 = Outer_Panel.CreateGraphics();
            formGraphics4.FillRectangle(SolidBrushNO, new Rectangle(Outer_Panel.Left, 60, Outer_Panel.Width, Outer_Panel.Height / 6));
            textGraphics.DrawString("Copy", fnt, textBrush, new PointF(TextMarginLeft, 60 + TextMarginTop));

            Graphics formGraphics5 = Outer_Panel.CreateGraphics();
            formGraphics5.FillRectangle(SolidBrushNO, new Rectangle(Outer_Panel.Left, 80, Outer_Panel.Width, Outer_Panel.Height / 6));
            textGraphics.DrawString("Paste", fnt, textBrush, new PointF(TextMarginLeft, 80 + TextMarginTop));

            Graphics formGraphics6 = Outer_Panel.CreateGraphics();
            formGraphics6.FillRectangle(SolidBrushNO, new Rectangle(Outer_Panel.Left, 100, Outer_Panel.Width, Outer_Panel.Height / 6));
            textGraphics.DrawString("Cancel", fnt, textBrush, new PointF(TextMarginLeft, 100 + TextMarginTop));

        }

        //AM

        #region //12AM
        private void Label_12AM_MouseDown(object sender, MouseEventArgs e)
        {
   
        }

        private void Label_12AM_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void Label_12AM_MouseLeave(object sender, EventArgs e)
        {
            Label_12AM.BackColor = Transparent;
        }

        private void Label_12AM_MouseEnter(object sender, EventArgs e)
        {            
            Label_12AM.BackColor = HighlightColor;
        }

        private void Label_12AM_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                DropDownMenuLocation = Label_12AM.Location;
                LabelShow();
            }
        }

        private void Label_12AM_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (Thrower == 1)
            {
                Thrower = 0;
            }

            else
            {
                Thrower = 1;
            }
            SwitchCase();
        }

        private void SwitchCase()
        {
            if (Thrower == 1)
            {
                if (Day_Expanding_Panel_01.Visible == true)
                { }
            }

            if (Thrower == 0)
            {
                Day_Expanding_Panel_01.Visible = false;
            }
        }

        private void Label_12_30AM_MouseLeave(object sender, EventArgs e)
        {
            Label_12_30AM.BackColor = Transparent;
        }

        private void Label_12_30AM_MouseEnter(object sender, EventArgs e)
        {
            Label_12_30AM.BackColor = HighlightColor;
        }

        private void Label_12_30AM_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                DropDownMenuLocation = Label_12_30AM.Location;
                LabelShow();
            }
        }

        private void Label_12_30AM_MouseDoubleClick(object sender, MouseEventArgs e)
        {
        }
        #endregion

        #region //1AM
        private void Label_1AM_MouseLeave(object sender, EventArgs e)
        {
            Label_1AM.BackColor = Transparent;
        }

        private void Label_1AM_MouseEnter(object sender, EventArgs e)
        {
            
            Label_1AM.BackColor = HighlightColor;
        }

        private void Label_1AM_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                DropDownMenuLocation = Label_1AM.Location;
                LabelShow();
            }
        }

        private void Label_1AM_MouseDoubleClick(object sender, MouseEventArgs e)
        {
        }

        private void Label_1_30AM_MouseLeave(object sender, EventArgs e)
        {
            Label_1_30AM.BackColor = Transparent;
        }

        private void Label_1_30AM_MouseEnter(object sender, EventArgs e)
        {
            
            Label_1_30AM.BackColor = HighlightColor;
        }

        private void Label_1_30AM_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                DropDownMenuLocation = Label_1_30AM.Location;
                LabelShow();
            }
        }

        private void Label_1_30AM_MouseDoubleClick(object sender, MouseEventArgs e)
        {
        }
        #endregion

        #region //2AM
        private void Label_2AM_MouseLeave(object sender, EventArgs e)
        {
            Label_2AM.BackColor = Transparent;
        }

        private void Label_2AM_MouseEnter(object sender, EventArgs e)
        {          
            Label_2AM.BackColor = HighlightColor;
        }

        private void Label_2AM_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                DropDownMenuLocation = Label_2AM.Location;
                LabelShow();
            }
        }

        private void Label_2AM_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Global_Access.MonolithConsole("Double Click");
        }

        private void Label_2_30AM_MouseLeave(object sender, EventArgs e)
        {
            Label_2_30AM.BackColor = Transparent;
        }

        private void Label_2_30AM_MouseEnter(object sender, EventArgs e)
        {
            
            Label_2_30AM.BackColor = HighlightColor;
        }

        private void Label_2_30AM_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                DropDownMenuLocation = Label_2_30AM.Location;
                LabelShow();
            }
        }

        private void Label_2_30AM_MouseDoubleClick(object sender, MouseEventArgs e)
        {
        }
        #endregion

        #region //3AM
        private void Label_3AM_MouseLeave(object sender, EventArgs e)
        {
            Label_3AM.BackColor = Transparent;
        }

        private void Label_3AM_MouseEnter(object sender, EventArgs e)
        {
            
            Label_3AM.BackColor = HighlightColor;
        }

        private void Label_3AM_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                DropDownMenuLocation = Label_3AM.Location;
                LabelShow();
            }
        }

        private void Label_3AM_MouseDoubleClick(object sender, MouseEventArgs e)
        {
        }

        private void Label_3_30AM_MouseLeave(object sender, EventArgs e)
        {
            Label_3_30AM.BackColor = Transparent;
        }

        private void Label_3_30AM_MouseEnter(object sender, EventArgs e)
        {
            
            Label_3_30AM.BackColor = HighlightColor;
        }

        private void Label_3_30AM_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                DropDownMenuLocation = Label_3_30AM.Location;
                LabelShow();
            }
        }

        private void Label_3_30AM_MouseDoubleClick(object sender, MouseEventArgs e)
        {
        }
        #endregion

        #region //4AM
        private void Label_4AM_MouseLeave(object sender, EventArgs e)
        {
            Label_4AM.BackColor = Transparent;
        }

        private void Label_4AM_MouseEnter(object sender, EventArgs e)
        {

            Label_4AM.BackColor = HighlightColor;
        }

        private void Label_4AM_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                DropDownMenuLocation = Label_4AM.Location;
                LabelShow();
            }
        }

        private void Label_4AM_MouseDoubleClick(object sender, MouseEventArgs e)
        {
        }

        private void Label_4_30AM_MouseLeave(object sender, EventArgs e)
        {
            Label_4_30AM.BackColor = Transparent;
        }

        private void Label_4_30AM_MouseEnter(object sender, EventArgs e)
        {
            Label_4_30AM.BackColor = HighlightColor;
        }

        private void Label_4_30AM_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                DropDownMenuLocation = Label_4_30AM.Location;
                LabelShow();
            }
        }

        private void Label_4_30AM_MouseDoubleClick(object sender, MouseEventArgs e)
        {
        }
        #endregion

        #region //5AM
        private void Label_5AM_MouseLeave(object sender, EventArgs e)
        {
            Label_5AM.BackColor = Transparent;
        }

        private void Label_5AM_MouseEnter(object sender, EventArgs e)
        {

            Label_5AM.BackColor = HighlightColor;
        }

        private void Label_5AM_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                DropDownMenuLocation = Label_5AM.Location;
                LabelShow();
            }
        }

        private void Label_5AM_MouseDoubleClick(object sender, MouseEventArgs e)
        {
        }

        private void Label_5_30AM_MouseLeave(object sender, EventArgs e)
        {
            Label_5_30AM.BackColor = Transparent;
        }

        private void Label_5_30AM_MouseEnter(object sender, EventArgs e)
        {

            Label_5_30AM.BackColor = HighlightColor;
        }

        private void Label_5_30AM_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                DropDownMenuLocation = Label_5_30AM.Location;
                LabelShow();
            }
        }

        private void Label_5_30AM_MouseDoubleClick(object sender, MouseEventArgs e)
        {
        }
        #endregion

        #region //6AM
        private void Label_6AM_MouseLeave(object sender, EventArgs e)
        {
            Label_6AM.BackColor = Transparent;
        }

        private void Label_6AM_MouseEnter(object sender, EventArgs e)
        {

            Label_6AM.BackColor = HighlightColor;
        }

        private void Label_6AM_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                DropDownMenuLocation = Label_6AM.Location;
                LabelShow();
            }
        }

        private void Label_6AM_MouseDoubleClick(object sender, MouseEventArgs e)
        {
        }

        private void Label_6_30AM_MouseLeave(object sender, EventArgs e)
        {
            Label_6_30AM.BackColor = Transparent;
        }

        private void Label_6_30AM_MouseEnter(object sender, EventArgs e)
        {

            Label_6_30AM.BackColor = HighlightColor;
        }

        private void Label_6_30AM_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                DropDownMenuLocation = Label_6_30AM.Location;
                LabelShow();
            }
        }

        private void Label_6_30AM_MouseDoubleClick(object sender, MouseEventArgs e)
        {
        }
        #endregion

        #region //7AM
        private void Label_7AM_MouseLeave(object sender, EventArgs e)
        {
            Label_7AM.BackColor = Transparent;
        }

        private void Label_7AM_MouseEnter(object sender, EventArgs e)
        {           
            Label_7AM.BackColor = HighlightColor;
        }

        private void Label_7AM_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                DropDownMenuLocation = Label_7AM.Location;
                LabelShow();
            }
        }

        private void Label_7AM_MouseDoubleClick(object sender, MouseEventArgs e)
        {
        }

        private void Label_7_30AM_MouseLeave(object sender, EventArgs e)
        {
            Label_7_30AM.BackColor = Transparent;
        }

        private void Label_7_30AM_MouseEnter(object sender, EventArgs e)
        {

            Label_7_30AM.BackColor = HighlightColor;
        }

        private void Label_7_30AM_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                DropDownMenuLocation = Label_7_30AM.Location;
                LabelShow();
            }
        }

        private void Label_7_30AM_MouseDoubleClick(object sender, MouseEventArgs e)
        {
        }
        #endregion

        #region //8AM
        private void Label_8AM_MouseLeave(object sender, EventArgs e)
        {
            Label_8AM.BackColor = Transparent;
        }

        private void Label_8AM_MouseEnter(object sender, EventArgs e)
        {

            Label_8AM.BackColor = HighlightColor;
        }

        private void Label_8AM_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                DropDownMenuLocation = Label_8AM.Location;
                LabelShow();
            }
        }

        private void Label_8AM_MouseDoubleClick(object sender, MouseEventArgs e)
        {
        }

        private void Label_8_30AM_MouseLeave(object sender, EventArgs e)
        {
            Label_8_30AM.BackColor = Transparent;
        }

        private void Label_8_30AM_MouseEnter(object sender, EventArgs e)
        {
            Label_8_30AM.BackColor = HighlightColor;
        }

        private void Label_8_30AM_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                DropDownMenuLocation = Label_8_30AM.Location;
                LabelShow();
            }
        }

        private void Label_8_30AM_MouseDoubleClick(object sender, MouseEventArgs e)
        {
        }
        #endregion

        #region //9AM
        private void Label_9AM_MouseLeave(object sender, EventArgs e)
        {
            Label_9AM.BackColor = Transparent;
        }

        private void Label_9AM_MouseEnter(object sender, EventArgs e)
        {

            Label_9AM.BackColor = HighlightColor;
        }

        private void Label_9AM_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                DropDownMenuLocation = Label_9AM.Location;
                LabelShow();
            }
        }

        private void Label_9AM_MouseDoubleClick(object sender, MouseEventArgs e)
        {
        }

        private void Label_9_30AM_MouseLeave(object sender, EventArgs e)
        {
            Label_9_30AM.BackColor = Transparent;
        }

        private void Label_9_30AM_MouseEnter(object sender, EventArgs e)
        {

            Label_9_30AM.BackColor = HighlightColor;
        }

        private void Label_9_30AM_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                DropDownMenuLocation = Label_9_30AM.Location;
                LabelShow();
            }
        }

        private void Label_9_30AM_MouseDoubleClick(object sender, MouseEventArgs e)
        {
        }
        #endregion

        #region //10AM
        private void Label_10AM_MouseLeave(object sender, EventArgs e)
        {
            Label_10AM.BackColor = Transparent;
        }

        private void Label_10AM_MouseEnter(object sender, EventArgs e)
        {

            Label_10AM.BackColor = HighlightColor;
        }

        private void Label_10AM_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                DropDownMenuLocation = Label_10AM.Location;
                LabelShow();
            }
        }

        private void Label_10AM_MouseDoubleClick(object sender, MouseEventArgs e)
        {
        }

        private void Label_10_30AM_MouseLeave(object sender, EventArgs e)
        {
            Label_10_30AM.BackColor = Transparent;
        }

        private void Label_10_30AM_MouseEnter(object sender, EventArgs e)
        {

            Label_10_30AM.BackColor = HighlightColor;
        }

        private void Label_10_30AM_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                DropDownMenuLocation = Label_10_30AM.Location;
                LabelShow();
            }
        }

        private void Label_10_30AM_MouseDoubleClick(object sender, MouseEventArgs e)
        {
        }
        #endregion

        #region //11AM
        private void Label_11AM_MouseLeave(object sender, EventArgs e)
        {
            Label_11AM.BackColor = Transparent;
        }

        private void Label_11AM_MouseEnter(object sender, EventArgs e)
        {

            Label_11AM.BackColor = HighlightColor;
        }

        private void Label_11AM_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                DropDownMenuLocation = Label_11AM.Location;
                LabelShow();
            }
        }

        private void Label_11AM_MouseDoubleClick(object sender, MouseEventArgs e)
        {
        }

        private void Label_11_30AM_MouseLeave(object sender, EventArgs e)
        {
            Label_11_30AM.BackColor = Transparent;
        }

        private void Label_11_30AM_MouseEnter(object sender, EventArgs e)
        {

            Label_11_30AM.BackColor = HighlightColor;
        }

        private void Label_11_30AM_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                DropDownMenuLocation = Label_11_30AM.Location;
                LabelShow();
            }
        }

        private void Label_11_30AM_MouseDoubleClick(object sender, MouseEventArgs e)
        {
        }
        #endregion

        //PM

        #region //12PM
        private void Label_12PM_MouseLeave(object sender, EventArgs e)
        {
            Label_12PM.BackColor = Transparent;
        }

        private void Label_12PM_MouseEnter(object sender, EventArgs e)
        {

            Label_12PM.BackColor = HighlightColor;
        }

        private void Label_12PM_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                DropDownMenuLocation = Label_12PM.Location;
                LabelShow();
            }
        }

        private void Label_12PM_MouseDoubleClick(object sender, MouseEventArgs e)
        {
        }

        private void Label_12_30PM_MouseLeave(object sender, EventArgs e)
        {
            Label_12_30PM.BackColor = Transparent;
        }

        private void Label_12_30PM_MouseEnter(object sender, EventArgs e)
        {
            Label_12_30PM.BackColor = HighlightColor;
        }

        private void Label_12_30PM_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                DropDownMenuLocation = Label_12_30PM.Location;
                LabelShow();
            }
        }

        private void Label_12_30PM_MouseDoubleClick(object sender, MouseEventArgs e)
        {
        }
        #endregion

        #region //1PM
        private void Label_1PM_MouseLeave(object sender, EventArgs e)
        {
            Label_1PM.BackColor = Transparent;
        }

        private void Label_1PM_MouseEnter(object sender, EventArgs e)
        {

            Label_1PM.BackColor = HighlightColor;
        }

        private void Label_1PM_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                DropDownMenuLocation = Label_1PM.Location;
                LabelShow();
            }
        }

        private void Label_1PM_MouseDoubleClick(object sender, MouseEventArgs e)
        {
        }

        private void Label_1_30PM_MouseLeave(object sender, EventArgs e)
        {
            Label_1_30PM.BackColor = Transparent;
        }

        private void Label_1_30PM_MouseEnter(object sender, EventArgs e)
        {

            Label_1_30PM.BackColor = HighlightColor;
        }

        private void Label_1_30PM_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                DropDownMenuLocation = Label_1_30PM.Location;
                LabelShow();
            }
        }

        private void Label_1_30PM_MouseDoubleClick(object sender, MouseEventArgs e)
        {
        }
        #endregion

        #region //2PM
        private void Label_2PM_MouseLeave(object sender, EventArgs e)
        {
            Label_2PM.BackColor = Transparent;
        }

        private void Label_2PM_MouseEnter(object sender, EventArgs e)
        {

            Label_2PM.BackColor = HighlightColor;
        }

        private void Label_2PM_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                DropDownMenuLocation = Label_2PM.Location;
                LabelShow();
            }
        }

        private void Label_2PM_MouseDoubleClick(object sender, MouseEventArgs e)
        {
        }

        private void Label_2_30PM_MouseLeave(object sender, EventArgs e)
        {
            Label_2_30PM.BackColor = Transparent;
        }

        private void Label_2_30PM_MouseEnter(object sender, EventArgs e)
        {

            Label_2_30PM.BackColor = HighlightColor;
        }

        private void Label_2_30PM_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                DropDownMenuLocation = Label_2_30PM.Location;
                LabelShow();
            }
        }

        private void Label_2_30PM_MouseDoubleClick(object sender, MouseEventArgs e)
        {
        }
        #endregion

        #region //3PM
        private void Label_3PM_MouseLeave(object sender, EventArgs e)
        {
            Label_3PM.BackColor = Transparent;
        }

        private void Label_3PM_MouseEnter(object sender, EventArgs e)
        {

            Label_3PM.BackColor = HighlightColor;
        }

        private void Label_3PM_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                DropDownMenuLocation = Label_3PM.Location;
                LabelShow();
            }
        }

        private void Label_3PM_MouseDoubleClick(object sender, MouseEventArgs e)
        {
        }

        private void Label_3_30PM_MouseLeave(object sender, EventArgs e)
        {
            Label_3_30PM.BackColor = Transparent;
        }

        private void Label_3_30PM_MouseEnter(object sender, EventArgs e)
        {

            Label_3_30PM.BackColor = HighlightColor;
        }

        private void Label_3_30PM_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                DropDownMenuLocation = Label_3_30PM.Location;
                LabelShow();
            }
        }

        private void Label_3_30PM_MouseDoubleClick(object sender, MouseEventArgs e)
        {
        }
        #endregion

        #region //4PM
        private void Label_4PM_MouseLeave(object sender, EventArgs e)
        {
            Label_4PM.BackColor = Transparent;
        }

        private void Label_4PM_MouseEnter(object sender, EventArgs e)
        {

            Label_4PM.BackColor = HighlightColor;
        }

        private void Label_4PM_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                DropDownMenuLocation = Label_4PM.Location;
                LabelShow();
            }
        }

        private void Label_4PM_MouseDoubleClick(object sender, MouseEventArgs e)
        {
        }

        private void Label_4_30PM_MouseLeave(object sender, EventArgs e)
        {
            Label_4_30PM.BackColor = Transparent;
        }

        private void Label_4_30PM_MouseEnter(object sender, EventArgs e)
        {
            Label_4_30PM.BackColor = HighlightColor;
        }

        private void Label_4_30PM_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                DropDownMenuLocation = Label_4_30PM.Location;
                LabelShow();
            }
        }

        private void Label_4_30PM_MouseDoubleClick(object sender, MouseEventArgs e)
        {
        }
        #endregion

        #region //5PM
        private void Label_5PM_MouseLeave(object sender, EventArgs e)
        {
            Label_5PM.BackColor = Transparent;
        }

        private void Label_5PM_MouseEnter(object sender, EventArgs e)
        {

            Label_5PM.BackColor = HighlightColor;
        }

        private void Label_5PM_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                DropDownMenuLocation = Label_5PM.Location;
                LabelShow();
            }
        }

        private void Label_5PM_MouseDoubleClick(object sender, MouseEventArgs e)
        {
        }

        private void Label_5_30PM_MouseLeave(object sender, EventArgs e)
        {
            Label_5_30PM.BackColor = Transparent;
        }

        private void Label_5_30PM_MouseEnter(object sender, EventArgs e)
        {

            Label_5_30PM.BackColor = HighlightColor;
        }

        private void Label_5_30PM_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                DropDownMenuLocation = Label_5_30PM.Location;
                LabelShow();
            }
        }

        private void Label_5_30PM_MouseDoubleClick(object sender, MouseEventArgs e)
        {
        }
        #endregion

        #region //6PM
        private void Label_6PM_MouseLeave(object sender, EventArgs e)
        {
            Label_6PM.BackColor = Transparent;
        }

        private void Label_6PM_MouseEnter(object sender, EventArgs e)
        {

            Label_6PM.BackColor = HighlightColor;
        }

        private void Label_6PM_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Global_Access.MonolithConsole("Right Mouse Click at 6PM");
                DropDownMenuLocation = Label_6PM.Location;
                LabelShow();
            }
        }

        private void Label_6PM_MouseDoubleClick(object sender, MouseEventArgs e)
        {
        }

        private void Label_6_30PM_MouseLeave(object sender, EventArgs e)
        {
            Label_6_30PM.BackColor = Transparent;
        }

        private void Label_6_30PM_MouseEnter(object sender, EventArgs e)
        {

            Label_6_30PM.BackColor = HighlightColor;
        }

        private void Label_6_30PM_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                DropDownMenuLocation = Label_6_30PM.Location;
                LabelShow();
            }
        }

        private void Label_6_30PM_MouseDoubleClick(object sender, MouseEventArgs e)
        {
        }
        #endregion

        #region //7PM
        private void Label_7PM_MouseLeave(object sender, EventArgs e)
        {
            Label_7PM.BackColor = Transparent;
        }

        private void Label_7PM_MouseEnter(object sender, EventArgs e)
        {

            Label_7PM.BackColor = HighlightColor;
        }

        private void Label_7PM_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                DropDownMenuLocation = Label_7PM.Location;
                LabelShow();
            }
        }

        private void Label_7PM_MouseDoubleClick(object sender, MouseEventArgs e)
        {
        }

        private void Label_7_30PM_MouseLeave(object sender, EventArgs e)
        {
            Label_7_30PM.BackColor = Transparent;
        }

        private void Label_7_30PM_MouseEnter(object sender, EventArgs e)
        {

            Label_7_30PM.BackColor = HighlightColor;
        }

        private void Label_7_30PM_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                DropDownMenuLocation = Label_7_30PM.Location;
                LabelShow();
            }
        }

        private void Label_7_30PM_MouseDoubleClick(object sender, MouseEventArgs e)
        {
        }
        #endregion

        #region //8PM
        private void Label_8PM_MouseLeave(object sender, EventArgs e)
        {
            Label_8PM.BackColor = Transparent;
        }

        private void Label_8PM_MouseEnter(object sender, EventArgs e)
        {

            Label_8PM.BackColor = HighlightColor;
        }

        private void Label_8PM_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                DropDownMenuLocation = Label_8PM.Location;
                LabelShow();
            }
        }

        private void Label_8PM_MouseDoubleClick(object sender, MouseEventArgs e)
        {
        }

        private void Label_8_30PM_MouseLeave(object sender, EventArgs e)
        {
            Label_8_30PM.BackColor = Transparent;
        }

        private void Label_8_30PM_MouseEnter(object sender, EventArgs e)
        {
            Label_8_30PM.BackColor = HighlightColor;
        }

        private void Label_8_30PM_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                DropDownMenuLocation = Label_8_30PM.Location;
                LabelShow();
            }
        }

        private void Label_8_30PM_MouseDoubleClick(object sender, MouseEventArgs e)
        {
        }
        #endregion

        #region //9PM
        private void Label_9PM_MouseLeave(object sender, EventArgs e)
        {
            Label_9PM.BackColor = Transparent;
        }

        private void Label_9PM_MouseEnter(object sender, EventArgs e)
        {

            Label_9PM.BackColor = HighlightColor;
        }

        private void Label_9PM_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                DropDownMenuLocation = Label_9PM.Location;
                LabelShow();
            }
        }

        private void Label_9PM_MouseDoubleClick(object sender, MouseEventArgs e)
        {
        }

        private void Label_9_30PM_MouseLeave(object sender, EventArgs e)
        {
            Label_9_30PM.BackColor = Transparent;
        }

        private void Label_9_30PM_MouseEnter(object sender, EventArgs e)
        {

            Label_9_30PM.BackColor = HighlightColor;
        }

        private void Label_9_30PM_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                DropDownMenuLocation.Y = Label_9_30PM.Location.Y - 20;
                LabelShow();
            }
        }

        private void Label_9_30PM_MouseDoubleClick(object sender, MouseEventArgs e)
        {
        }
        #endregion

        #region //10PM
        private void Label_10PM_MouseLeave(object sender, EventArgs e)
        {
            Label_10PM.BackColor = Transparent;
        }

        private void Label_10PM_MouseEnter(object sender, EventArgs e)
        {

            Label_10PM.BackColor = HighlightColor;
        }

        private void Label_10PM_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                DropDownMenuLocation.Y = Label_10PM.Location.Y - 40;
                LabelShow();
            }
        }

        private void Label_10PM_MouseDoubleClick(object sender, MouseEventArgs e)
        {
        }

        private void Label_10_30PM_MouseLeave(object sender, EventArgs e)
        {
            Label_10_30PM.BackColor = Transparent;
        }

        private void Label_10_30PM_MouseEnter(object sender, EventArgs e)
        {

            Label_10_30PM.BackColor = HighlightColor;
        }

        private void Label_10_30PM_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                DropDownMenuLocation.Y = Label_10_30PM.Location.Y - 60;
                LabelShow();
            }
        }

        private void Label_10_30PM_MouseDoubleClick(object sender, MouseEventArgs e)
        {
        }
        #endregion

        #region //11PM
        private void Label_11PM_MouseLeave(object sender, EventArgs e)
        {
            Label_11PM.BackColor = Transparent;
        }

        private void Label_11PM_MouseEnter(object sender, EventArgs e)
        {

            Label_11PM.BackColor = HighlightColor;
        }

        private void Label_11PM_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                DropDownMenuLocation.Y = Label_11PM.Location.Y - 80;
                LabelShow();
            }
        }

        private void Label_11PM_MouseDoubleClick(object sender, MouseEventArgs e)
        {
        }

        private void Label_11_30PM_MouseLeave(object sender, EventArgs e)
        {
            Label_11_30PM.BackColor = Transparent;
        }

        private void Label_11_30PM_MouseEnter(object sender, EventArgs e)
        {

            Label_11_30PM.BackColor = HighlightColor;
        }

        private void Label_11_30PM_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                DropDownMenuLocation.Y = Label_11_30PM.Location.Y - 100;
                LabelShow();
            }
        }

        private void Label_11_30PM_MouseDoubleClick(object sender, MouseEventArgs e)
        {
        }
        #endregion
    }
}
