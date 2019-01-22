namespace Calendar_NEW
{
    partial class Dialog_DatabaseNotConnected
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dialog_DatabaseNotConnected));
            this.listBox_Duplicate = new System.Windows.Forms.ListBox();
            this.label_DuplicateDatabaseLink = new System.Windows.Forms.Label();
            this.label_DuplicateSelectName = new System.Windows.Forms.Label();
            this.label_DuplicateDB_OR = new System.Windows.Forms.Label();
            this.DatabaseNotFound_Button_Next = new System.Windows.Forms.Button();
            this.DatabaseNotFound_RecreateDatabase = new System.Windows.Forms.Button();
            this.labelDuplicate_FormTitle = new System.Windows.Forms.Label();
            this.label_DuplicateDB = new System.Windows.Forms.Label();
            this.openFileDialog_DatabaseNotFound = new System.Windows.Forms.OpenFileDialog();
            this.DatabaseNotFound_NewLocation = new System.Windows.Forms.Button();
            this.DatabaseNotFound_Button_Back = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox_Duplicate
            // 
            this.listBox_Duplicate.FormattingEnabled = true;
            this.listBox_Duplicate.Location = new System.Drawing.Point(399, 138);
            this.listBox_Duplicate.Name = "listBox_Duplicate";
            this.listBox_Duplicate.Size = new System.Drawing.Size(142, 134);
            this.listBox_Duplicate.TabIndex = 101;
            // 
            // label_DuplicateDatabaseLink
            // 
            this.label_DuplicateDatabaseLink.AutoSize = true;
            this.label_DuplicateDatabaseLink.Location = new System.Drawing.Point(396, 280);
            this.label_DuplicateDatabaseLink.Name = "label_DuplicateDatabaseLink";
            this.label_DuplicateDatabaseLink.Size = new System.Drawing.Size(59, 13);
            this.label_DuplicateDatabaseLink.TabIndex = 100;
            this.label_DuplicateDatabaseLink.Text = "Database: ";
            // 
            // label_DuplicateSelectName
            // 
            this.label_DuplicateSelectName.AutoSize = true;
            this.label_DuplicateSelectName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_DuplicateSelectName.Location = new System.Drawing.Point(396, 117);
            this.label_DuplicateSelectName.Name = "label_DuplicateSelectName";
            this.label_DuplicateSelectName.Size = new System.Drawing.Size(129, 18);
            this.label_DuplicateSelectName.TabIndex = 99;
            this.label_DuplicateSelectName.Text = "Select a database.";
            // 
            // label_DuplicateDB_OR
            // 
            this.label_DuplicateDB_OR.AutoSize = true;
            this.label_DuplicateDB_OR.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_DuplicateDB_OR.Location = new System.Drawing.Point(351, 186);
            this.label_DuplicateDB_OR.Name = "label_DuplicateDB_OR";
            this.label_DuplicateDB_OR.Size = new System.Drawing.Size(40, 18);
            this.label_DuplicateDB_OR.TabIndex = 98;
            this.label_DuplicateDB_OR.Text = "- or -";
            // 
            // DatabaseNotFound_Button_Next
            // 
            this.DatabaseNotFound_Button_Next.BackColor = System.Drawing.Color.Gainsboro;
            this.DatabaseNotFound_Button_Next.Location = new System.Drawing.Point(465, 330);
            this.DatabaseNotFound_Button_Next.Name = "DatabaseNotFound_Button_Next";
            this.DatabaseNotFound_Button_Next.Size = new System.Drawing.Size(75, 23);
            this.DatabaseNotFound_Button_Next.TabIndex = 95;
            this.DatabaseNotFound_Button_Next.Text = "OK";
            this.DatabaseNotFound_Button_Next.UseVisualStyleBackColor = false;
            // 
            // DatabaseNotFound_RecreateDatabase
            // 
            this.DatabaseNotFound_RecreateDatabase.Location = new System.Drawing.Point(42, 184);
            this.DatabaseNotFound_RecreateDatabase.Name = "DatabaseNotFound_RecreateDatabase";
            this.DatabaseNotFound_RecreateDatabase.Size = new System.Drawing.Size(121, 23);
            this.DatabaseNotFound_RecreateDatabase.TabIndex = 94;
            this.DatabaseNotFound_RecreateDatabase.Text = "Recreate Database";
            this.DatabaseNotFound_RecreateDatabase.UseVisualStyleBackColor = true;
            // 
            // labelDuplicate_FormTitle
            // 
            this.labelDuplicate_FormTitle.AutoSize = true;
            this.labelDuplicate_FormTitle.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDuplicate_FormTitle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelDuplicate_FormTitle.Location = new System.Drawing.Point(37, 10);
            this.labelDuplicate_FormTitle.Name = "labelDuplicate_FormTitle";
            this.labelDuplicate_FormTitle.Size = new System.Drawing.Size(312, 36);
            this.labelDuplicate_FormTitle.TabIndex = 93;
            this.labelDuplicate_FormTitle.Text = "Database Not Found";
            // 
            // label_DuplicateDB
            // 
            this.label_DuplicateDB.AutoSize = true;
            this.label_DuplicateDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_DuplicateDB.Location = new System.Drawing.Point(40, 63);
            this.label_DuplicateDB.Name = "label_DuplicateDB";
            this.label_DuplicateDB.Size = new System.Drawing.Size(432, 36);
            this.label_DuplicateDB.TabIndex = 92;
            this.label_DuplicateDB.Text = "The database --- is not connected. Please select a new location, \r\nconnect to a c" +
    "urrent database or recreate ----";
            // 
            // openFileDialog_DatabaseNotFound
            // 
            this.openFileDialog_DatabaseNotFound.FileName = "openFileDialog_DatabaseNotFound";
            // 
            // DatabaseNotFound_NewLocation
            // 
            this.DatabaseNotFound_NewLocation.Location = new System.Drawing.Point(221, 184);
            this.DatabaseNotFound_NewLocation.Name = "DatabaseNotFound_NewLocation";
            this.DatabaseNotFound_NewLocation.Size = new System.Drawing.Size(121, 23);
            this.DatabaseNotFound_NewLocation.TabIndex = 102;
            this.DatabaseNotFound_NewLocation.Text = "New Location";
            this.DatabaseNotFound_NewLocation.UseVisualStyleBackColor = true;
            // 
            // DatabaseNotFound_Button_Back
            // 
            this.DatabaseNotFound_Button_Back.BackColor = System.Drawing.Color.Gainsboro;
            this.DatabaseNotFound_Button_Back.Location = new System.Drawing.Point(384, 330);
            this.DatabaseNotFound_Button_Back.Name = "DatabaseNotFound_Button_Back";
            this.DatabaseNotFound_Button_Back.Size = new System.Drawing.Size(75, 23);
            this.DatabaseNotFound_Button_Back.TabIndex = 97;
            this.DatabaseNotFound_Button_Back.Text = "Cancel";
            this.DatabaseNotFound_Button_Back.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(172, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 18);
            this.label1.TabIndex = 103;
            this.label1.Text = "- or -";
            // 
            // Dialog_DatabaseNotConnected
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 362);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DatabaseNotFound_NewLocation);
            this.Controls.Add(this.listBox_Duplicate);
            this.Controls.Add(this.label_DuplicateDatabaseLink);
            this.Controls.Add(this.label_DuplicateSelectName);
            this.Controls.Add(this.label_DuplicateDB_OR);
            this.Controls.Add(this.DatabaseNotFound_Button_Back);
            this.Controls.Add(this.DatabaseNotFound_Button_Next);
            this.Controls.Add(this.DatabaseNotFound_RecreateDatabase);
            this.Controls.Add(this.labelDuplicate_FormTitle);
            this.Controls.Add(this.label_DuplicateDB);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(600, 400);
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "Dialog_DatabaseNotConnected";
            this.Text = "Monolith Calendar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ListBox listBox_Duplicate;
        private System.Windows.Forms.Label label_DuplicateDatabaseLink;
        private System.Windows.Forms.Label label_DuplicateSelectName;
        private System.Windows.Forms.Label label_DuplicateDB_OR;
        public System.Windows.Forms.Button DatabaseNotFound_Button_Next;
        private System.Windows.Forms.Button DatabaseNotFound_RecreateDatabase;
        private System.Windows.Forms.Label labelDuplicate_FormTitle;
        private System.Windows.Forms.Label label_DuplicateDB;
        private System.Windows.Forms.OpenFileDialog openFileDialog_DatabaseNotFound;
        private System.Windows.Forms.Button DatabaseNotFound_NewLocation;
        private System.Windows.Forms.Button DatabaseNotFound_Button_Back;
        private System.Windows.Forms.Label label1;
    }
}