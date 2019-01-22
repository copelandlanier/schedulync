namespace Calendar_NEW
{
    partial class Dialog_FirstRun_Database
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dialog_FirstRun_Database));
            this.labelWelcome_FormTitle = new System.Windows.Forms.Label();
            this.label_DatabaseLocation = new System.Windows.Forms.Label();
            this.textBox_DatabaseLocation = new System.Windows.Forms.TextBox();
            this.CancelButton_Cancel = new System.Windows.Forms.Button();
            this.WelcomeButton_Next = new System.Windows.Forms.Button();
            this.button_DatabaseBrowse = new System.Windows.Forms.Button();
            this.label_DBConnectedStatus = new System.Windows.Forms.Label();
            this.DBConnected_LED = new System.Windows.Forms.Panel();
            this.label_ExistingDBNotes = new System.Windows.Forms.Label();
            this.radio_NewDB = new System.Windows.Forms.RadioButton();
            this.radio_ExistingDB = new System.Windows.Forms.RadioButton();
            this.label_CreateDBName = new System.Windows.Forms.Label();
            this.textBox_CreateDBName = new System.Windows.Forms.TextBox();
            this.panel_CreateDatabase = new System.Windows.Forms.Panel();
            this.panel_ExistingDatabase = new System.Windows.Forms.Panel();
            this.panel_DatabaseLocation = new System.Windows.Forms.Panel();
            this.button_DatabaseOpen = new System.Windows.Forms.Button();
            this.button_DatabaseConnect = new System.Windows.Forms.Button();
            this.panel_ButtonSelection = new System.Windows.Forms.Panel();
            this.folderBrowserDialog_Welcome = new System.Windows.Forms.FolderBrowserDialog();
            this.panel_SelectDatabaseNote = new System.Windows.Forms.Panel();
            this.label_SelectDBNotes = new System.Windows.Forms.Label();
            this.openFileDialog_Welcome = new System.Windows.Forms.OpenFileDialog();
            this.panel_CreateDatabase.SuspendLayout();
            this.panel_ExistingDatabase.SuspendLayout();
            this.panel_DatabaseLocation.SuspendLayout();
            this.panel_ButtonSelection.SuspendLayout();
            this.panel_SelectDatabaseNote.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelWelcome_FormTitle
            // 
            this.labelWelcome_FormTitle.AutoSize = true;
            this.labelWelcome_FormTitle.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelcome_FormTitle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelWelcome_FormTitle.Location = new System.Drawing.Point(30, 10);
            this.labelWelcome_FormTitle.Name = "labelWelcome_FormTitle";
            this.labelWelcome_FormTitle.Size = new System.Drawing.Size(152, 36);
            this.labelWelcome_FormTitle.TabIndex = 79;
            this.labelWelcome_FormTitle.Text = "Welcome";
            // 
            // label_DatabaseLocation
            // 
            this.label_DatabaseLocation.AutoSize = true;
            this.label_DatabaseLocation.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_DatabaseLocation.Location = new System.Drawing.Point(15, 13);
            this.label_DatabaseLocation.Name = "label_DatabaseLocation";
            this.label_DatabaseLocation.Size = new System.Drawing.Size(133, 17);
            this.label_DatabaseLocation.TabIndex = 76;
            this.label_DatabaseLocation.Text = "Database Location";
            // 
            // textBox_DatabaseLocation
            // 
            this.textBox_DatabaseLocation.BackColor = System.Drawing.Color.White;
            this.textBox_DatabaseLocation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_DatabaseLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_DatabaseLocation.Location = new System.Drawing.Point(18, 33);
            this.textBox_DatabaseLocation.Name = "textBox_DatabaseLocation";
            this.textBox_DatabaseLocation.Size = new System.Drawing.Size(360, 22);
            this.textBox_DatabaseLocation.TabIndex = 75;
            // 
            // CancelButton_Cancel
            // 
            this.CancelButton_Cancel.BackColor = System.Drawing.Color.Gainsboro;
            this.CancelButton_Cancel.Location = new System.Drawing.Point(377, 330);
            this.CancelButton_Cancel.Name = "CancelButton_Cancel";
            this.CancelButton_Cancel.Size = new System.Drawing.Size(75, 23);
            this.CancelButton_Cancel.TabIndex = 85;
            this.CancelButton_Cancel.Text = "Cancel";
            this.CancelButton_Cancel.UseVisualStyleBackColor = false;
            // 
            // WelcomeButton_Next
            // 
            this.WelcomeButton_Next.BackColor = System.Drawing.Color.Gainsboro;
            this.WelcomeButton_Next.Location = new System.Drawing.Point(458, 330);
            this.WelcomeButton_Next.Name = "WelcomeButton_Next";
            this.WelcomeButton_Next.Size = new System.Drawing.Size(75, 23);
            this.WelcomeButton_Next.TabIndex = 84;
            this.WelcomeButton_Next.Text = "Next  >";
            this.WelcomeButton_Next.UseVisualStyleBackColor = false;
            this.WelcomeButton_Next.Click += new System.EventHandler(this.WelcomeButton_Next_Click);
            // 
            // button_DatabaseBrowse
            // 
            this.button_DatabaseBrowse.Location = new System.Drawing.Point(384, 32);
            this.button_DatabaseBrowse.Name = "button_DatabaseBrowse";
            this.button_DatabaseBrowse.Size = new System.Drawing.Size(75, 23);
            this.button_DatabaseBrowse.TabIndex = 87;
            this.button_DatabaseBrowse.Text = "Browse";
            this.button_DatabaseBrowse.UseVisualStyleBackColor = true;
            this.button_DatabaseBrowse.Click += new System.EventHandler(this.button_DatabaseBrowse_Click);
            // 
            // label_DBConnectedStatus
            // 
            this.label_DBConnectedStatus.AutoSize = true;
            this.label_DBConnectedStatus.Location = new System.Drawing.Point(50, 65);
            this.label_DBConnectedStatus.Name = "label_DBConnectedStatus";
            this.label_DBConnectedStatus.Size = new System.Drawing.Size(177, 13);
            this.label_DBConnectedStatus.TabIndex = 88;
            this.label_DBConnectedStatus.Text = "Database Status: DISCONNECTED";
            // 
            // DBConnected_LED
            // 
            this.DBConnected_LED.BackColor = System.Drawing.Color.DarkRed;
            this.DBConnected_LED.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DBConnected_LED.Location = new System.Drawing.Point(18, 68);
            this.DBConnected_LED.Name = "DBConnected_LED";
            this.DBConnected_LED.Size = new System.Drawing.Size(28, 8);
            this.DBConnected_LED.TabIndex = 89;
            // 
            // label_ExistingDBNotes
            // 
            this.label_ExistingDBNotes.Location = new System.Drawing.Point(15, 5);
            this.label_ExistingDBNotes.Name = "label_ExistingDBNotes";
            this.label_ExistingDBNotes.Size = new System.Drawing.Size(384, 59);
            this.label_ExistingDBNotes.TabIndex = 90;
            this.label_ExistingDBNotes.Text = "NOTE:\r\nThe database will have the extension: .db\r\nPlease connect to the database " +
    "before selecting \"Next.\" \r\nThe database status will display \"Connected\" when the" +
    " database is connected.";
            // 
            // radio_NewDB
            // 
            this.radio_NewDB.Appearance = System.Windows.Forms.Appearance.Button;
            this.radio_NewDB.AutoSize = true;
            this.radio_NewDB.Location = new System.Drawing.Point(18, 0);
            this.radio_NewDB.Name = "radio_NewDB";
            this.radio_NewDB.Size = new System.Drawing.Size(88, 23);
            this.radio_NewDB.TabIndex = 91;
            this.radio_NewDB.TabStop = true;
            this.radio_NewDB.Text = "New Database";
            this.radio_NewDB.UseVisualStyleBackColor = true;
            // 
            // radio_ExistingDB
            // 
            this.radio_ExistingDB.Appearance = System.Windows.Forms.Appearance.Button;
            this.radio_ExistingDB.AutoSize = true;
            this.radio_ExistingDB.Location = new System.Drawing.Point(112, 0);
            this.radio_ExistingDB.Name = "radio_ExistingDB";
            this.radio_ExistingDB.Size = new System.Drawing.Size(102, 23);
            this.radio_ExistingDB.TabIndex = 92;
            this.radio_ExistingDB.TabStop = true;
            this.radio_ExistingDB.Text = "Existing Database";
            this.radio_ExistingDB.UseVisualStyleBackColor = true;
            // 
            // label_CreateDBName
            // 
            this.label_CreateDBName.AutoSize = true;
            this.label_CreateDBName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_CreateDBName.Location = new System.Drawing.Point(15, 13);
            this.label_CreateDBName.Name = "label_CreateDBName";
            this.label_CreateDBName.Size = new System.Drawing.Size(116, 17);
            this.label_CreateDBName.TabIndex = 94;
            this.label_CreateDBName.Text = "Database Name";
            // 
            // textBox_CreateDBName
            // 
            this.textBox_CreateDBName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_CreateDBName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CreateDBName.Location = new System.Drawing.Point(18, 33);
            this.textBox_CreateDBName.Name = "textBox_CreateDBName";
            this.textBox_CreateDBName.Size = new System.Drawing.Size(360, 22);
            this.textBox_CreateDBName.TabIndex = 93;
            // 
            // panel_CreateDatabase
            // 
            this.panel_CreateDatabase.Controls.Add(this.label_CreateDBName);
            this.panel_CreateDatabase.Controls.Add(this.textBox_CreateDBName);
            this.panel_CreateDatabase.Location = new System.Drawing.Point(54, 155);
            this.panel_CreateDatabase.Name = "panel_CreateDatabase";
            this.panel_CreateDatabase.Size = new System.Drawing.Size(476, 75);
            this.panel_CreateDatabase.TabIndex = 95;
            // 
            // panel_ExistingDatabase
            // 
            this.panel_ExistingDatabase.Controls.Add(this.label_ExistingDBNotes);
            this.panel_ExistingDatabase.Location = new System.Drawing.Point(54, 81);
            this.panel_ExistingDatabase.Name = "panel_ExistingDatabase";
            this.panel_ExistingDatabase.Size = new System.Drawing.Size(400, 75);
            this.panel_ExistingDatabase.TabIndex = 96;
            // 
            // panel_DatabaseLocation
            // 
            this.panel_DatabaseLocation.Controls.Add(this.button_DatabaseOpen);
            this.panel_DatabaseLocation.Controls.Add(this.button_DatabaseConnect);
            this.panel_DatabaseLocation.Controls.Add(this.label_DatabaseLocation);
            this.panel_DatabaseLocation.Controls.Add(this.textBox_DatabaseLocation);
            this.panel_DatabaseLocation.Controls.Add(this.DBConnected_LED);
            this.panel_DatabaseLocation.Controls.Add(this.button_DatabaseBrowse);
            this.panel_DatabaseLocation.Controls.Add(this.label_DBConnectedStatus);
            this.panel_DatabaseLocation.Location = new System.Drawing.Point(54, 234);
            this.panel_DatabaseLocation.Name = "panel_DatabaseLocation";
            this.panel_DatabaseLocation.Size = new System.Drawing.Size(479, 114);
            this.panel_DatabaseLocation.TabIndex = 97;
            // 
            // button_DatabaseOpen
            // 
            this.button_DatabaseOpen.Location = new System.Drawing.Point(384, 61);
            this.button_DatabaseOpen.Name = "button_DatabaseOpen";
            this.button_DatabaseOpen.Size = new System.Drawing.Size(75, 23);
            this.button_DatabaseOpen.TabIndex = 91;
            this.button_DatabaseOpen.Text = "Open";
            this.button_DatabaseOpen.UseVisualStyleBackColor = true;
            this.button_DatabaseOpen.Click += new System.EventHandler(this.button_DatabaseOpen_Click);
            // 
            // button_DatabaseConnect
            // 
            this.button_DatabaseConnect.Location = new System.Drawing.Point(18, 87);
            this.button_DatabaseConnect.Name = "button_DatabaseConnect";
            this.button_DatabaseConnect.Size = new System.Drawing.Size(75, 23);
            this.button_DatabaseConnect.TabIndex = 90;
            this.button_DatabaseConnect.Text = "Connect";
            this.button_DatabaseConnect.UseVisualStyleBackColor = true;
            this.button_DatabaseConnect.Click += new System.EventHandler(this.button_DatabaseConnect_Click);
            // 
            // panel_ButtonSelection
            // 
            this.panel_ButtonSelection.Controls.Add(this.radio_NewDB);
            this.panel_ButtonSelection.Controls.Add(this.radio_ExistingDB);
            this.panel_ButtonSelection.Location = new System.Drawing.Point(54, 49);
            this.panel_ButtonSelection.Name = "panel_ButtonSelection";
            this.panel_ButtonSelection.Size = new System.Drawing.Size(239, 26);
            this.panel_ButtonSelection.TabIndex = 98;
            // 
            // folderBrowserDialog_Welcome
            // 
            this.folderBrowserDialog_Welcome.SelectedPath = "C:\\";
            // 
            // panel_SelectDatabaseNote
            // 
            this.panel_SelectDatabaseNote.Controls.Add(this.label_SelectDBNotes);
            this.panel_SelectDatabaseNote.Location = new System.Drawing.Point(54, 354);
            this.panel_SelectDatabaseNote.Name = "panel_SelectDatabaseNote";
            this.panel_SelectDatabaseNote.Size = new System.Drawing.Size(310, 32);
            this.panel_SelectDatabaseNote.TabIndex = 97;
            // 
            // label_SelectDBNotes
            // 
            this.label_SelectDBNotes.Location = new System.Drawing.Point(1, 1);
            this.label_SelectDBNotes.Name = "label_SelectDBNotes";
            this.label_SelectDBNotes.Size = new System.Drawing.Size(303, 18);
            this.label_SelectDBNotes.TabIndex = 90;
            this.label_SelectDBNotes.Text = "Please select either a new database or an existing database.";
            this.label_SelectDBNotes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // openFileDialog_Welcome
            // 
            this.openFileDialog_Welcome.FileName = "openFileDialog_Welcome";
            // 
            // Dialog_FirstRun_Database
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 362);
            this.Controls.Add(this.panel_SelectDatabaseNote);
            this.Controls.Add(this.panel_ExistingDatabase);
            this.Controls.Add(this.panel_ButtonSelection);
            this.Controls.Add(this.CancelButton_Cancel);
            this.Controls.Add(this.WelcomeButton_Next);
            this.Controls.Add(this.labelWelcome_FormTitle);
            this.Controls.Add(this.panel_CreateDatabase);
            this.Controls.Add(this.panel_DatabaseLocation);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(600, 400);
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "Dialog_FirstRun_Database";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Monolith Calendar";
            this.panel_CreateDatabase.ResumeLayout(false);
            this.panel_CreateDatabase.PerformLayout();
            this.panel_ExistingDatabase.ResumeLayout(false);
            this.panel_DatabaseLocation.ResumeLayout(false);
            this.panel_DatabaseLocation.PerformLayout();
            this.panel_ButtonSelection.ResumeLayout(false);
            this.panel_ButtonSelection.PerformLayout();
            this.panel_SelectDatabaseNote.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.RadioButton radio_NewDB;
        public System.Windows.Forms.RadioButton radio_ExistingDB;
        public System.Windows.Forms.TextBox textBox_DatabaseLocation;
        public System.Windows.Forms.TextBox textBox_CreateDBName;
        public System.Windows.Forms.Button CancelButton_Cancel;
        private System.Windows.Forms.Button WelcomeButton_Next;
        private System.Windows.Forms.Button button_DatabaseBrowse;
        private System.Windows.Forms.Button button_DatabaseConnect;
        private System.Windows.Forms.Label labelWelcome_FormTitle;
        private System.Windows.Forms.Label label_DatabaseLocation;
        private System.Windows.Forms.Label label_DBConnectedStatus;
        private System.Windows.Forms.Label label_ExistingDBNotes;
        private System.Windows.Forms.Label label_SelectDBNotes;
        private System.Windows.Forms.Label label_CreateDBName;
        private System.Windows.Forms.Panel panel_SelectDatabaseNote;
        private System.Windows.Forms.Panel DBConnected_LED;
        private System.Windows.Forms.Panel panel_CreateDatabase;
        private System.Windows.Forms.Panel panel_ExistingDatabase;
        private System.Windows.Forms.Panel panel_DatabaseLocation;
        private System.Windows.Forms.Panel panel_ButtonSelection;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog_Welcome;
        private System.Windows.Forms.Button button_DatabaseOpen;
        public System.Windows.Forms.OpenFileDialog openFileDialog_Welcome;
    }
}