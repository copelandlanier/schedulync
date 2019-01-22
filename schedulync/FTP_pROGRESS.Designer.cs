namespace Calendar_NEW
{
    partial class FTP_PROGRESS
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            // 
            // FtpProgress
            // 
            this.WorkerReportsProgress = true;
            this.WorkerSupportsCancellation = true;
            this.DoWork += new System.ComponentModel.DoWorkEventHandler(this.FtpProgress_DoWork);
        }

        #endregion
    }
}