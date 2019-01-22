namespace Calendar_NEW
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            display_Panel1 = new Calendar_NEW.Display_Panel();
            fileSystemWatcher_WebUpload = new System.IO.FileSystemWatcher();
            statusStrip1 = new System.Windows.Forms.StatusStrip();
            toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            fileSystemWatcher_Config = new System.IO.FileSystemWatcher();
            fileSystemWatcher_RemoteDB = new System.IO.FileSystemWatcher();
            backgroundWorker_Listener = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(fileSystemWatcher_WebUpload)).BeginInit();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(fileSystemWatcher_Config)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(fileSystemWatcher_RemoteDB)).BeginInit();
            this.SuspendLayout();
            //
            toolStripProgressBar1.Value = 50;
            
            // 
            // display_Panel1
            // 
            resources.ApplyResources(display_Panel1, "display_Panel1");
            display_Panel1.BackColor = System.Drawing.Color.Transparent;
            display_Panel1.DayBackColor_1 = System.Drawing.Color.Transparent;
            display_Panel1.DayBackColor_10 = System.Drawing.Color.Transparent;
            display_Panel1.DayBackColor_2 = System.Drawing.Color.Transparent;
            display_Panel1.DayBackColor_3 = System.Drawing.Color.Transparent;
            display_Panel1.DayBackColor_4 = System.Drawing.Color.Transparent;
            display_Panel1.DayBackColor_5 = System.Drawing.Color.Transparent;
            display_Panel1.DayBackColor_6 = System.Drawing.Color.Transparent;
            display_Panel1.DayBackColor_7 = System.Drawing.Color.Transparent;
            display_Panel1.DayBackColor_8 = System.Drawing.Color.Transparent;
            display_Panel1.DayBackColor_9 = System.Drawing.Color.Transparent;
            display_Panel1.DayVisible_1 = true;
            display_Panel1.DayVisible_10 = true;
            display_Panel1.DayVisible_2 = true;
            display_Panel1.DayVisible_3 = true;
            display_Panel1.DayVisible_4 = true;
            display_Panel1.DayVisible_5 = true;
            display_Panel1.DayVisible_6 = true;
            display_Panel1.DayVisible_7 = true;
            display_Panel1.DayVisible_8 = true;
            display_Panel1.DayVisible_9 = true;
            display_Panel1.ExpandBGImage1 = null;
            display_Panel1.ExpandBGImage10 = null;
            display_Panel1.ExpandBGImage2 = null;
            display_Panel1.ExpandBGImage3 = null;
            display_Panel1.ExpandBGImage4 = null;
            display_Panel1.ExpandBGImage5 = null;
            display_Panel1.ExpandBGImage6 = null;
            display_Panel1.ExpandBGImage7 = null;
            display_Panel1.ExpandBGImage8 = null;
            display_Panel1.ExpandBGImage9 = null;
            display_Panel1.Name = "display_Panel1";
            // 
            // fileSystemWatcher_WebUpload
            // 
            fileSystemWatcher_WebUpload.EnableRaisingEvents = true;
            fileSystemWatcher_WebUpload.SynchronizingObject = this;
            // 
            // statusStrip1
            // 
            resources.ApplyResources(statusStrip1, "statusStrip1");
            statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            toolStripStatusLabel1,
            toolStripProgressBar1});
            statusStrip1.Name = "statusStrip1";
            statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            statusStrip1.SizingGrip = false;
            // 
            // toolStripStatusLabel1
            // 
            resources.ApplyResources(toolStripStatusLabel1, "toolStripStatusLabel1");
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            // 
            // toolStripProgressBar1
            //
            resources.ApplyResources(toolStripProgressBar1, "toolStripProgressBar1");
            toolStripProgressBar1.ForeColor = System.Drawing.Color.MediumSlateBlue;
            toolStripProgressBar1.Name = "toolStripProgressBar1";
            // 
            // fileSystemWatcher_Config
            // 
            fileSystemWatcher_Config.EnableRaisingEvents = true;
            fileSystemWatcher_Config.SynchronizingObject = this;
            // 
            // fileSystemWatcher_RemoteDB
            // 
            fileSystemWatcher_RemoteDB.EnableRaisingEvents = true;
            fileSystemWatcher_RemoteDB.SynchronizingObject = this;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(statusStrip1);
            this.Controls.Add(display_Panel1);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(fileSystemWatcher_WebUpload)).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(fileSystemWatcher_Config)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(fileSystemWatcher_RemoteDB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        //private System.IO.FileSystemWatcher fileSystemWatcher_WebUpload;
        //private System.IO.FileSystemWatcher fileSystemWatcher_Config;
        //private System.IO.FileSystemWatcher fileSystemWatcher_RemoteDB;
        //private Display_Panel display_Panel1;
        //public System.Windows.Forms.StatusStrip statusStrip1;
        //public System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        //public System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        //private System.ComponentModel.BackgroundWorker backgroundWorker_Listener;
    }
}

