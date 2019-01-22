using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace Calendar_NEW
{
    public partial class Dialog_FirstRun_FTPSettings : Global_Access
    {
        int testupload_year;
        int testupload_month;
        int testupload_day;
        public string FTP_Host;
        public string FTP_Port;
        public string FTP_User;
        public string FTP_Password;
        public string FTP_Folder;
        public bool FTP_Passive;

        public FTP_PROGRESS ftpProgress1 = new FTP_PROGRESS();

        public Dialog_FirstRun_FTPSettings()
        {
            DateTime CurrentDATE = DateTime.Now;
            testupload_year = CurrentDATE.Year;
            testupload_month = CurrentDATE.Month;
            testupload_day = CurrentDATE.Day;
            
            InitializeComponent();
            panel_ButtonFTP.Location = new System.Drawing.Point(145, 160);

            FTPButton_Next.Enabled = false;
            panel_FTPNoFTP.Hide();
            panel_FTPDefaultFTP.Hide();
            panel_FTPNewFTP.Hide();
            panel_FTPNoFTP.Location = new System.Drawing.Point(36, 94);
            panel_FTPDefaultFTP.Location = new System.Drawing.Point(36, 94);
            panel_FTPNewFTP.Location = new System.Drawing.Point(36, 94);
            radio_DefaultFTP.CheckedChanged += Radio_DefaultFTP_CheckedChanged;
            radio_NewFTP.CheckedChanged += Radio_NewFTP_CheckedChanged;
            radio_NoFTP.CheckedChanged += Radio_NoFTP_CheckedChanged;
        }      

        private void Radio_NoFTP_CheckedChanged(object sender, EventArgs e)
        {
            FTPButton_Next.Enabled = true;
            FTP_DisplayPanels();
        }

        private void Radio_NewFTP_CheckedChanged(object sender, EventArgs e)
        {
            FTPButton_Next.Enabled = false;
            FTP_DisplayPanels();
            button_FTPNewConnect.Enabled = true;
            DBConnected_LEDNEW.BackColor = System.Drawing.Color.DarkRed;
            label_WLConnectedStatusNEW.Text = "Database Status: DISCONNECTED";
        }

        private void Radio_DefaultFTP_CheckedChanged(object sender, EventArgs e)
        {
            FTPButton_Next.Enabled = false;
            FTP_DisplayPanels();
            button_FTPDefaultConnect.Enabled = true;
            DBConnected_LEDDF.BackColor = System.Drawing.Color.DarkRed;
            label_WLConnectedStatusDF.Text = "Database Status: DISCONNECTED";

        }

        private void ftpProgress1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            toolStripStatusLabel1.Text = e.UserState.ToString();   // the message will be something like: 45 Kb / 102.12 Mb
            toolStripProgressBar1.Value = Math.Min(toolStripProgressBar1.Maximum, e.ProgressPercentage);
        }

        private void ftpProgress1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
                MessageBox.Show(e.Error.ToString(), "FTP error");
            else if (e.Cancelled)
                toolStripStatusLabel1.Text = "Upload Cancelled";
            else
                toolStripStatusLabel1.Text = "Upload Complete";
            FTPButton_Next.Enabled = true;
            toolStripProgressBar1.Visible = false;
        }

        private void ftpProgress1_DoWork(object sender, DoWorkEventArgs e)
        {
          
        }

        private void FTP_DisplayPanels()
        {
            panel_ButtonFTP.Location = new System.Drawing.Point(80,55);
            if (radio_NoFTP.Checked == true)
            {
                panel_FTPNoFTP.Show();
                panel_FTPDefaultFTP.Hide();
                panel_FTPNewFTP.Hide();
            }
            else if (radio_DefaultFTP.Checked == true)
            {
                panel_FTPNoFTP.Hide();
                panel_FTPDefaultFTP.Show();
                panel_FTPNewFTP.Hide();
            }
            else if (radio_NewFTP.Checked == true)
            {
                panel_FTPNoFTP.Hide();
                panel_FTPDefaultFTP.Hide();
                panel_FTPNewFTP.Show();
            }
        }

        private void FTPButton_Next_Click(object sender, EventArgs e)
        {
            this.Hide();
            dialog_settings.Show();
        }

        private void FTPButton_Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            dialog_database.Show();
        }

        private void button_FTPDefaultConnect_Click(object sender, EventArgs e)
        {            
            string test_upload_String = testupload_month + "_" + testupload_day + "_" + testupload_year + "_" + Environment.UserName + "_upload_connect" + ".txt";

            FTP_Host = "ecbiz237.inmotionhosting.com";
            FTP_Port = "21";
            FTP_User = "monoli11";
            FTP_Password = "Monolith01";
            FTP_Folder = @"/public_html/webdata";
            FTP_Passive = false;

            StreamWriter swA = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + test_upload_String);
            using (swA)
            {
                swA.WriteLine("ID: Monolith Modular Systems");
                swA.WriteLine("Implementation: Upload Connectivity Test");
                swA.WriteLine("File Type: Text File");
                swA.WriteLine("Machine Name: " + Environment.MachineName);
                swA.WriteLine("User Name: " + Environment.UserName);
                swA.WriteLine("Time: " + DateTime.Now);
            }

            // the upload button is also used as a cancel button, depending on the state of the FtpProgress thread
            if (this.ftpProgress1.IsBusy)
            {
                this.ftpProgress1.CancelAsync();
            }

            else
            {
                // create a new FtpSettings class to store all the paramaters for the FtpProgress thread
                FtpSettings f = new FtpSettings();
                f.Host = FTP_Host;
                f.Username = FTP_User;
                f.Password = FTP_Password;
                f.TargetFolder = FTP_Folder;
                f.SourceFile = AppDomain.CurrentDomain.BaseDirectory + test_upload_String;
                f.Passive = FTP_Passive;

                try
                {
                    f.Port = Int32.Parse(FTP_Port);
                }

                catch
                {
                    MessageBox.Show("FTP is offline. Please reconnect or select 'No FTP.'");
                }
                toolStripProgressBar1.Visible = true;
                this.ftpProgress1.RunWorkerAsync(f);
            }
        }

        private void button_FTPNewConnect_Click(object sender, EventArgs e)
        {
            string test_upload_String = testupload_month + "_" + testupload_day + "_" + testupload_year + "_" + Environment.UserName + "_upload_connect" + ".txt";

            FTP_Host = txtHost.Text;
            FTP_Port = txtPort.Text;
            FTP_User = txtUsername.Text;
            FTP_Password = txtPassword.Text;
            FTP_Folder = txtDir.Text;
            
            if (chkPassive.CheckState == CheckState.Checked || chkPassive.CheckState == CheckState.Unchecked)
            {
                if (chkPassive.CheckState == CheckState.Checked)
                {
                     FTP_Passive = true;
                }
                else if (chkPassive.CheckState == CheckState.Unchecked)
                {
                    FTP_Passive = false;
                }
            }

            string DateShort = DateTime.Now.ToShortDateString();
            StreamWriter swA = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + test_upload_String);
            using (swA)
            {
                swA.WriteLine("ID: Monolith Modular Systems");
                swA.WriteLine("Implementation: Upload Connectivity Test");
                swA.WriteLine("File Type: Text File");
                swA.WriteLine("Machine Name: " + Environment.MachineName);
                swA.WriteLine("User Name: " + Environment.UserName);
                swA.WriteLine("Time: " + DateTime.Now);
            }

            // the upload button is also used as a cancel button, depending on the state of the FtpProgress thread
            if (this.ftpProgress1.IsBusy)
            {
                this.ftpProgress1.CancelAsync();
            }
            else
            {
                // create a new FtpSettings class to store all the paramaters for the FtpProgress thread
                FtpSettings f = new FtpSettings();
                f.Host = FTP_Host;
                f.Username = FTP_User;
                f.Password = FTP_Password;
                f.TargetFolder = FTP_Folder;
                f.Passive = FTP_Passive;
                f.SourceFile = AppDomain.CurrentDomain.BaseDirectory + test_upload_String;                

                try
                {
                    f.Port = Int32.Parse(FTP_Port);
                }
                catch { }
                toolStripProgressBar1.Visible = true;
                this.ftpProgress1.RunWorkerAsync(f);
            }
        }

        /*
        public static bool CheckForInternetConnection()
        {
            try
            {
                using (var client = new WebClient())
                using (var stream = client.OpenRead("http://www.google.com"))
                {
                    return true;
                }
            }

            catch
            {
                return false;
            }
        }
        */
    }
}
