using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Calendar_NEW
{
    partial class Month_Control
   
    {
        public Label Month_Expanding_Panel_01 = new Label();
        public Label Month_Expanding_Panel_02 = new Label();
        public Label Month_Expanding_Panel_03 = new Label();
        public Label Month_Expanding_Panel_04 = new Label();
        public Label Month_Expanding_Panel_05 = new Label();
        public Label Month_Expanding_Panel_06 = new Label();
        public Label Month_Expanding_Panel_07 = new Label();
        public Label Month_Expanding_Panel_08 = new Label();
        public Label Month_Expanding_Panel_09 = new Label();
        public Label Month_Expanding_Panel_Overlay_Reocc = new Label();
        public Label Month_Expanding_Panel_Overlay_Alarm = new Label();
        public Point Month_Expanding_Panel_Start_Loc = new Point();
        public Point Month_Expanding_Panel_Start_01 = new Point();
        public Point Month_Expanding_Panel_End_01 = new Point();
        public Point Month_Expanding_Panel_Start_02 = new Point();
        public Point Month_Expanding_Panel_End_02 = new Point();
        public Point Month_Expanding_Panel_Start_03 = new Point();
        public Point Month_Expanding_Panel_End_03 = new Point();
        public Point Month_Expanding_Panel_Start_04 = new Point();
        public Point Month_Expanding_Panel_End_04 = new Point();
        public Point Month_Expanding_Panel_Start_05 = new Point();
        public Point Month_Expanding_Panel_End_05 = new Point();
        public Point Month_Expanding_Panel_Start_06 = new Point();
        public Point Month_Expanding_Panel_End_06 = new Point();
        public Point Month_Expanding_Panel_Start_07 = new Point();
        public Point Month_Expanding_Panel_End_07 = new Point();
        public Point Month_Expanding_Panel_Start_08 = new Point();
        public Point Month_Expanding_Panel_End_08 = new Point();
        public Point Month_Expanding_Panel_Start_09 = new Point();
        public Point Month_Expanding_Panel_End_09 = new Point();
        Point Month_Expanding_Panel_MousePoint_01 = new Point();
        Point Month_Expanding_Panel_MousePoint_02 = new Point();
        Point Month_Expanding_Panel_MousePoint_03 = new Point();
        Point Month_Expanding_Panel_MousePoint_04 = new Point();
        Point Month_Expanding_Panel_MousePoint_05 = new Point();
        Point Month_Expanding_Panel_MousePoint_06 = new Point();
        Point Month_Expanding_Panel_MousePoint_07 = new Point();
        Point Month_Expanding_Panel_MousePoint_08 = new Point();
        Point Month_Expanding_Panel_MousePoint_09 = new Point();
        // MOUSESWITCH - 1 = Top / 2 = Bottom / 3 = Move
        int Month_Expanding_Panel_MouseSwitch_01 = 0;
        int Month_Expanding_Panel_MouseSwitch_02 = 0;
        int Month_Expanding_Panel_MouseSwitch_03 = 0;
        int Month_Expanding_Panel_MouseSwitch_04 = 0;
        int Month_Expanding_Panel_MouseSwitch_05 = 0;
        int Month_Expanding_Panel_MouseSwitch_06 = 0;
        int Month_Expanding_Panel_MouseSwitch_07 = 0;
        int Month_Expanding_Panel_MouseSwitch_08 = 0;
        int Month_Expanding_Panel_MouseSwitch_09 = 0;
        // Get Location and Map to Time
        int Month_Expanding_Panel_LocGet_A_01;
        int Month_Expanding_Panel_LocGet_B_01;
        string Month_Expanding_Panel_String_A_01;
        string Month_Expanding_Panel_String_B_01;
        int Month_Expanding_Panel_LocGet_A_02;
        int Month_Expanding_Panel_LocGet_B_02;
        string Month_Expanding_Panel_String_A_02;
        string Month_Expanding_Panel_String_B_02;
        int Month_Expanding_Panel_LocGet_A_03;
        int Month_Expanding_Panel_LocGet_B_03;
        string Month_Expanding_Panel_String_A_03;
        string Month_Expanding_Panel_String_B_03;
        //
        int Month_Expanding_Panel_LocGet_A_04;
        int Month_Expanding_Panel_LocGet_B_04;
        string Month_Expanding_Panel_String_A_04;
        string Month_Expanding_Panel_String_B_04;
        int Month_Expanding_Panel_LocGet_A_05;
        int Month_Expanding_Panel_LocGet_B_05;
        string Month_Expanding_Panel_String_A_05;
        string Month_Expanding_Panel_String_B_05;
        int Month_Expanding_Panel_LocGet_A_06;
        int Month_Expanding_Panel_LocGet_B_06;
        string Month_Expanding_Panel_String_A_06;
        string Month_Expanding_Panel_String_B_06;
        //
        int Month_Expanding_Panel_LocGet_A_07;
        int Month_Expanding_Panel_LocGet_B_07;
        string Month_Expanding_Panel_String_A_07;
        string Month_Expanding_Panel_String_B_07;
        int Month_Expanding_Panel_LocGet_A_08;
        int Month_Expanding_Panel_LocGet_B_08;
        string Month_Expanding_Panel_String_A_08;
        string Month_Expanding_Panel_String_B_08;
        int Month_Expanding_Panel_LocGet_A_09;
        int Month_Expanding_Panel_LocGet_B_09;
        string Month_Expanding_Panel_String_A_09;
        string Month_Expanding_Panel_String_B_09;

        public void Month_Overlay_Events()
        {
            #region // Month_Expanding Panel Events
            // Month_Expanding Panel 1
            Month_Expanding_Panel_01.Location = new Point(3, 100);
            Month_Expanding_Panel_01.Visible = false;
            Month_Expanding_Panel_01.Height = 23;
            Month_Expanding_Panel_01.Width = 145;
            Month_Expanding_Panel_01.AutoSize = false;
            Month_Expanding_Panel_01.BackColor = Color.Aqua;
            Month_Expanding_Panel_01.ForeColor = Color.Blue;
            Month_Expanding_Panel_01.Padding = new Padding(25, 4, 0, 0);
            Month_Expanding_Panel_01.Text = "01";
            this.Controls.Add(Month_Expanding_Panel_01);
            Month_Expanding_Panel_01.BringToFront();
            Month_Expanding_Panel_01.Show();

            Month_Expanding_Panel_02.Location = new Point(3, 123);
            Month_Expanding_Panel_02.Visible = false;
            Month_Expanding_Panel_02.Height = 23;
            Month_Expanding_Panel_02.Width = 145;
            Month_Expanding_Panel_02.AutoSize = false;
            Month_Expanding_Panel_02.BackColor = Color.Brown;
            Month_Expanding_Panel_02.ForeColor = Color.White;
            Month_Expanding_Panel_02.Padding = new Padding(25, 4, 0, 0);
            Month_Expanding_Panel_02.Text = "02";
            this.Controls.Add(Month_Expanding_Panel_02);
            Month_Expanding_Panel_02.BringToFront();
            Month_Expanding_Panel_02.Show();

            Month_Expanding_Panel_03.Location = new Point(3, 146);
            Month_Expanding_Panel_03.Visible = false;
            Month_Expanding_Panel_03.Height = 23;
            Month_Expanding_Panel_03.Width = 145;
            Month_Expanding_Panel_03.AutoSize = false;
            Month_Expanding_Panel_03.BackColor = Color.Orange;
            Month_Expanding_Panel_03.ForeColor = Color.Black;
            Month_Expanding_Panel_03.Padding = new Padding(25, 4, 0, 0);
            Month_Expanding_Panel_03.Text = "03";
            this.Controls.Add(Month_Expanding_Panel_03);
            Month_Expanding_Panel_03.BringToFront();
            Month_Expanding_Panel_03.Show();

            Month_Expanding_Panel_04.Location = new Point(3, 169);
            Month_Expanding_Panel_04.Visible = false;
            Month_Expanding_Panel_04.Height = 23;
            Month_Expanding_Panel_04.Width = 145;
            Month_Expanding_Panel_04.AutoSize = false;
            Month_Expanding_Panel_04.BackColor = Color.DarkGreen;
            Month_Expanding_Panel_04.ForeColor = Color.White;
            Month_Expanding_Panel_04.Padding = new Padding(25, 4, 0, 0);
            Month_Expanding_Panel_04.Text = "04";
            this.Controls.Add(Month_Expanding_Panel_04);
            Month_Expanding_Panel_04.BringToFront();
            Month_Expanding_Panel_04.Show();

            // Month_Expanding Panel Events
            Month_Expanding_Panel_01.MouseDoubleClick += Month_Expanding_Panel_MouseDoubleClick_01;
            Month_Expanding_Panel_01.MouseDown += Month_Expanding_Panel_MouseDown_01;
            Month_Expanding_Panel_01.MouseUp += Month_Expanding_Panel_MouseUp_01;
            Month_Expanding_Panel_01.MouseMove += Month_Expanding_Panel_MouseMove_01;

            Month_Expanding_Panel_02.MouseDoubleClick += Month_Expanding_Panel_MouseDoubleClick_02;
            Month_Expanding_Panel_02.MouseDown += Month_Expanding_Panel_MouseDown_02;
            Month_Expanding_Panel_02.MouseUp += Month_Expanding_Panel_MouseUp_02;
            Month_Expanding_Panel_02.MouseMove += Month_Expanding_Panel_MouseMove_02;

            Month_Expanding_Panel_03.MouseDoubleClick += Month_Expanding_Panel_MouseDoubleClick_03;
            Month_Expanding_Panel_03.MouseDown += Month_Expanding_Panel_MouseDown_03;
            Month_Expanding_Panel_03.MouseUp += Month_Expanding_Panel_MouseUp_03;
            Month_Expanding_Panel_03.MouseMove += Month_Expanding_Panel_MouseMove_03;

            Month_Expanding_Panel_04.MouseDoubleClick += Month_Expanding_Panel_MouseDoubleClick_04;
            Month_Expanding_Panel_04.MouseDown += Month_Expanding_Panel_MouseDown_04;
            Month_Expanding_Panel_04.MouseUp += Month_Expanding_Panel_MouseUp_04;
            Month_Expanding_Panel_04.MouseMove += Month_Expanding_Panel_MouseMove_04;

            Month_Expanding_Panel_05.MouseDoubleClick += Month_Expanding_Panel_MouseDoubleClick_05;
            Month_Expanding_Panel_05.MouseDown += Month_Expanding_Panel_MouseDown_05;
            Month_Expanding_Panel_05.MouseUp += Month_Expanding_Panel_MouseUp_05;
            Month_Expanding_Panel_05.MouseMove += Month_Expanding_Panel_MouseMove_05;

            Month_Expanding_Panel_06.MouseDoubleClick += Month_Expanding_Panel_MouseDoubleClick_06;
            Month_Expanding_Panel_06.MouseDown += Month_Expanding_Panel_MouseDown_06;
            Month_Expanding_Panel_06.MouseUp += Month_Expanding_Panel_MouseUp_06;
            Month_Expanding_Panel_06.MouseMove += Month_Expanding_Panel_MouseMove_06;

            Month_Expanding_Panel_04.MouseDoubleClick += Month_Expanding_Panel_MouseDoubleClick_07;
            Month_Expanding_Panel_04.MouseDown += Month_Expanding_Panel_MouseDown_07;
            Month_Expanding_Panel_04.MouseUp += Month_Expanding_Panel_MouseUp_07;
            Month_Expanding_Panel_04.MouseMove += Month_Expanding_Panel_MouseMove_07;

            Month_Expanding_Panel_05.MouseDoubleClick += Month_Expanding_Panel_MouseDoubleClick_08;
            Month_Expanding_Panel_05.MouseDown += Month_Expanding_Panel_MouseDown_08;
            Month_Expanding_Panel_05.MouseUp += Month_Expanding_Panel_MouseUp_08;
            Month_Expanding_Panel_05.MouseMove += Month_Expanding_Panel_MouseMove_08;

            Month_Expanding_Panel_06.MouseDoubleClick += Month_Expanding_Panel_MouseDoubleClick_09;
            Month_Expanding_Panel_06.MouseDown += Month_Expanding_Panel_MouseDown_09;
            Month_Expanding_Panel_06.MouseUp += Month_Expanding_Panel_MouseUp_09;
            Month_Expanding_Panel_06.MouseMove += Month_Expanding_Panel_MouseMove_09;
            #endregion
        }

#region // Mouse Function Events
        private void Month_Expanding_Panel_MouseDoubleClick_01(object sender, MouseEventArgs e)
        {

        }

        private void Month_Expanding_Panel_MouseDown_01(object sender, MouseEventArgs e)
        {

        }

        private void Month_Expanding_Panel_MouseUp_01(object sender, MouseEventArgs e)
        {

        }

        private void Month_Expanding_Panel_MouseMove_01(object sender, MouseEventArgs e)
        {

        }
        //
        private void Month_Expanding_Panel_MouseDoubleClick_02(object sender, MouseEventArgs e)
        {

        }

        private void Month_Expanding_Panel_MouseDown_02(object sender, MouseEventArgs e)
        {

        }

        private void Month_Expanding_Panel_MouseUp_02(object sender, MouseEventArgs e)
        {

        }

        private void Month_Expanding_Panel_MouseMove_02(object sender, MouseEventArgs e)
        {

        }
        //
        private void Month_Expanding_Panel_MouseDoubleClick_03(object sender, MouseEventArgs e)
        {

        }

        private void Month_Expanding_Panel_MouseDown_03(object sender, MouseEventArgs e)
        {

        }

        private void Month_Expanding_Panel_MouseUp_03(object sender, MouseEventArgs e)
        {

        }

        private void Month_Expanding_Panel_MouseMove_03(object sender, MouseEventArgs e)
        {

        }
        //
        private void Month_Expanding_Panel_MouseDoubleClick_04(object sender, MouseEventArgs e)
        {

        }

        private void Month_Expanding_Panel_MouseDown_04(object sender, MouseEventArgs e)
        {

        }

        private void Month_Expanding_Panel_MouseUp_04(object sender, MouseEventArgs e)
        {

        }

        private void Month_Expanding_Panel_MouseMove_04(object sender, MouseEventArgs e)
        {

        }
        //
        private void Month_Expanding_Panel_MouseDoubleClick_05(object sender, MouseEventArgs e)
        {

        }

        private void Month_Expanding_Panel_MouseDown_05(object sender, MouseEventArgs e)
        {

        }

        private void Month_Expanding_Panel_MouseUp_05(object sender, MouseEventArgs e)
        {

        }

        private void Month_Expanding_Panel_MouseMove_05(object sender, MouseEventArgs e)
        {

        }
        //
        private void Month_Expanding_Panel_MouseDoubleClick_06(object sender, MouseEventArgs e)
        {

        }

        private void Month_Expanding_Panel_MouseDown_06(object sender, MouseEventArgs e)
        {

        }

        private void Month_Expanding_Panel_MouseUp_06(object sender, MouseEventArgs e)
        {

        }

        private void Month_Expanding_Panel_MouseMove_06(object sender, MouseEventArgs e)
        {

        }
        //
        private void Month_Expanding_Panel_MouseDoubleClick_07(object sender, MouseEventArgs e)
        {

        }

        private void Month_Expanding_Panel_MouseDown_07(object sender, MouseEventArgs e)
        {

        }

        private void Month_Expanding_Panel_MouseUp_07(object sender, MouseEventArgs e)
        {

        }

        private void Month_Expanding_Panel_MouseMove_07(object sender, MouseEventArgs e)
        {

        }
        //
        private void Month_Expanding_Panel_MouseDoubleClick_08(object sender, MouseEventArgs e)
        {

        }

        private void Month_Expanding_Panel_MouseDown_08(object sender, MouseEventArgs e)
        {

        }

        private void Month_Expanding_Panel_MouseUp_08(object sender, MouseEventArgs e)
        {

        }

        private void Month_Expanding_Panel_MouseMove_08(object sender, MouseEventArgs e)
        {

        }
        //
        private void Month_Expanding_Panel_MouseDoubleClick_09(object sender, MouseEventArgs e)
        {

        }

        private void Month_Expanding_Panel_MouseDown_09(object sender, MouseEventArgs e)
        {

        }

        private void Month_Expanding_Panel_MouseUp_09(object sender, MouseEventArgs e)
        {

        }

        private void Month_Expanding_Panel_MouseMove_09(object sender, MouseEventArgs e)
        {

        }
        #endregion
    }
}