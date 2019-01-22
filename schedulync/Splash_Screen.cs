using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Calendar_NEW
{
    public partial class Splash_Screen : PerPixelAlphaForm
    {
        private Bitmap bitmap;
        Point Splash_Point = new Point();
        int SplashDelay = 15; // Linked to set delay or variable
        byte num;

        public Splash_Screen()
        {
            InitializeComponent();
            this.Show();
            SetPerPixelBitmapFilename();
            for (int x = 0; x < 256; x++)
            {
                num = (byte)x;
                this.SetBitmap(bitmap, num);
            }
            #region /// These are the mouse moving events
            this.MouseDown += new MouseEventHandler(Splash_MouseDown);
            this.MouseMove += new MouseEventHandler(Splash_MouseMove);
            #endregion
            Splash_Timer.Start();
            Thread.Sleep(2000);

            Console.WriteLine("UserName: {0}", Environment.UserName);

            /*string RegistrationName = FIRST_NAME + " " + LAST_NAME; 
            if(SoftwareRegistration == RegistrationName && FIRSTRUN_SWITCH == 1)
            {

            }
            Console.WriteLine("Access Database");*/
        }

        #region /// This method moves the mouse
        private void Splash_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Splash_Point = e.Location;
            }
        }

        private void Splash_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point start = Point.Empty;
                int nx = this.Location.X - Splash_Point.X + (e.X - start.X);
                int ny = this.Location.Y - Splash_Point.Y + (e.Y - start.Y);
                this.Location = new Point(nx, ny);
            }
        }
        #endregion

        // This is the timer event for the splash screen
        private void Splash_Timer_Tick(object sender, EventArgs e)
        {
            if (SplashDelay > 0)
            {
                SplashDelay = SplashDelay - 1;
            }
            else
            {
                Splash_Timer.Stop();
                this.Hide();
            }
        }

        private void SetPerPixelBitmapFilename()
        {
            Bitmap newBitmap;

            try
            {
                newBitmap = Properties.Resources.splash_screen_trans_B as Bitmap;
            }
            catch (ApplicationException e)
            {
                MessageBox.Show(this, e.Message, "Error with bitmap.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            catch (Exception e)
            {
                MessageBox.Show(this, e.Message, "Could not open image file.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (bitmap != null)
                bitmap.Dispose();
            bitmap = newBitmap;
        }
    }
}
