namespace Calendar_NEW
{
    partial class Dialog_FirstRun_DuplicateEntries
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dialog_FirstRun_DuplicateEntries));
            this.label_DuplicateDB = new System.Windows.Forms.Label();
            this.labelDuplicate_FormTitle = new System.Windows.Forms.Label();
            this.DuplicateButton_ChangeName = new System.Windows.Forms.Button();
            this.DuplicateButton_Back = new System.Windows.Forms.Button();
            this.DuplicateButton_Cancel = new System.Windows.Forms.Button();
            this.DuplicateButton_Next = new System.Windows.Forms.Button();
            this.label_DuplicateDB_OR = new System.Windows.Forms.Label();
            this.label_DuplicateSelectName = new System.Windows.Forms.Label();
            this.label_DuplicateDatabaseLink = new System.Windows.Forms.Label();
            this.listBox_Duplicate = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label_DuplicateDB
            // 
            this.label_DuplicateDB.AutoSize = true;
            this.label_DuplicateDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_DuplicateDB.Location = new System.Drawing.Point(33, 63);
            this.label_DuplicateDB.Name = "label_DuplicateDB";
            this.label_DuplicateDB.Size = new System.Drawing.Size(507, 36);
            this.label_DuplicateDB.TabIndex = 0;
            this.label_DuplicateDB.Text = "There is (are) duplicate names in the database.\r\nWould you like to change the cur" +
    "rent name or connect to another database?";
            // 
            // labelDuplicate_FormTitle
            // 
            this.labelDuplicate_FormTitle.AutoSize = true;
            this.labelDuplicate_FormTitle.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDuplicate_FormTitle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelDuplicate_FormTitle.Location = new System.Drawing.Point(30, 10);
            this.labelDuplicate_FormTitle.Name = "labelDuplicate_FormTitle";
            this.labelDuplicate_FormTitle.Size = new System.Drawing.Size(324, 36);
            this.labelDuplicate_FormTitle.TabIndex = 75;
            this.labelDuplicate_FormTitle.Text = "Duplicate Entries Error";
            // 
            // DuplicateButton_ChangeName
            // 
            this.DuplicateButton_ChangeName.Location = new System.Drawing.Point(85, 189);
            this.DuplicateButton_ChangeName.Name = "DuplicateButton_ChangeName";
            this.DuplicateButton_ChangeName.Size = new System.Drawing.Size(121, 23);
            this.DuplicateButton_ChangeName.TabIndex = 76;
            this.DuplicateButton_ChangeName.Text = "Change Name";
            this.DuplicateButton_ChangeName.UseVisualStyleBackColor = true;
            this.DuplicateButton_ChangeName.Click += new System.EventHandler(this.DuplicateButton_ChangeName_Click);
            // 
            // DuplicateButton_Back
            // 
            this.DuplicateButton_Back.BackColor = System.Drawing.Color.Gainsboro;
            this.DuplicateButton_Back.Location = new System.Drawing.Point(377, 330);
            this.DuplicateButton_Back.Name = "DuplicateButton_Back";
            this.DuplicateButton_Back.Size = new System.Drawing.Size(75, 23);
            this.DuplicateButton_Back.TabIndex = 87;
            this.DuplicateButton_Back.Text = "<  Previous";
            this.DuplicateButton_Back.UseVisualStyleBackColor = false;
            this.DuplicateButton_Back.Click += new System.EventHandler(this.DuplicateButton_Back_Click);
            // 
            // DuplicateButton_Cancel
            // 
            this.DuplicateButton_Cancel.BackColor = System.Drawing.Color.Gainsboro;
            this.DuplicateButton_Cancel.Location = new System.Drawing.Point(297, 330);
            this.DuplicateButton_Cancel.Name = "DuplicateButton_Cancel";
            this.DuplicateButton_Cancel.Size = new System.Drawing.Size(75, 23);
            this.DuplicateButton_Cancel.TabIndex = 85;
            this.DuplicateButton_Cancel.Text = "Cancel";
            this.DuplicateButton_Cancel.UseVisualStyleBackColor = false;
            // 
            // DuplicateButton_Next
            // 
            this.DuplicateButton_Next.BackColor = System.Drawing.Color.Gainsboro;
            this.DuplicateButton_Next.Location = new System.Drawing.Point(458, 330);
            this.DuplicateButton_Next.Name = "DuplicateButton_Next";
            this.DuplicateButton_Next.Size = new System.Drawing.Size(75, 23);
            this.DuplicateButton_Next.TabIndex = 84;
            this.DuplicateButton_Next.Text = "OK";
            this.DuplicateButton_Next.UseVisualStyleBackColor = false;
            this.DuplicateButton_Next.Click += new System.EventHandler(this.DuplicateButton_Next_Click);
            // 
            // label_DuplicateDB_OR
            // 
            this.label_DuplicateDB_OR.AutoSize = true;
            this.label_DuplicateDB_OR.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_DuplicateDB_OR.Location = new System.Drawing.Point(240, 190);
            this.label_DuplicateDB_OR.Name = "label_DuplicateDB_OR";
            this.label_DuplicateDB_OR.Size = new System.Drawing.Size(40, 18);
            this.label_DuplicateDB_OR.TabIndex = 88;
            this.label_DuplicateDB_OR.Text = "- or -";
            // 
            // label_DuplicateSelectName
            // 
            this.label_DuplicateSelectName.AutoSize = true;
            this.label_DuplicateSelectName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_DuplicateSelectName.Location = new System.Drawing.Point(317, 123);
            this.label_DuplicateSelectName.Name = "label_DuplicateSelectName";
            this.label_DuplicateSelectName.Size = new System.Drawing.Size(154, 18);
            this.label_DuplicateSelectName.TabIndex = 89;
            this.label_DuplicateSelectName.Text = "Select name to link to.";
            // 
            // label_DuplicateDatabaseLink
            // 
            this.label_DuplicateDatabaseLink.AutoSize = true;
            this.label_DuplicateDatabaseLink.Location = new System.Drawing.Point(317, 289);
            this.label_DuplicateDatabaseLink.Name = "label_DuplicateDatabaseLink";
            this.label_DuplicateDatabaseLink.Size = new System.Drawing.Size(102, 13);
            this.label_DuplicateDatabaseLink.TabIndex = 90;
            this.label_DuplicateDatabaseLink.Text = "Database linked to: ";
            // 
            // listBox_Duplicate
            // 
            this.listBox_Duplicate.FormattingEnabled = true;
            this.listBox_Duplicate.Location = new System.Drawing.Point(320, 144);
            this.listBox_Duplicate.Name = "listBox_Duplicate";
            this.listBox_Duplicate.Size = new System.Drawing.Size(142, 134);
            this.listBox_Duplicate.TabIndex = 91;
            this.listBox_Duplicate.SelectedIndexChanged += new System.EventHandler(this.listBox_Duplicate_SelectedIndexChanged);
            // 
            // Dialog_FirstRun_DuplicateEntries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 362);
            this.Controls.Add(this.listBox_Duplicate);
            this.Controls.Add(this.label_DuplicateDatabaseLink);
            this.Controls.Add(this.label_DuplicateSelectName);
            this.Controls.Add(this.label_DuplicateDB_OR);
            this.Controls.Add(this.DuplicateButton_Back);
            this.Controls.Add(this.DuplicateButton_Cancel);
            this.Controls.Add(this.DuplicateButton_Next);
            this.Controls.Add(this.DuplicateButton_ChangeName);
            this.Controls.Add(this.labelDuplicate_FormTitle);
            this.Controls.Add(this.label_DuplicateDB);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(600, 400);
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "Dialog_FirstRun_DuplicateEntries";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Monolith Calendar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_DuplicateDB;
        private System.Windows.Forms.Label labelDuplicate_FormTitle;
        private System.Windows.Forms.Button DuplicateButton_ChangeName;
        private System.Windows.Forms.Button DuplicateButton_Back;
        public System.Windows.Forms.Button DuplicateButton_Cancel;
        public System.Windows.Forms.Button DuplicateButton_Next;
        private System.Windows.Forms.Label label_DuplicateDB_OR;
        private System.Windows.Forms.Label label_DuplicateSelectName;
        private System.Windows.Forms.Label label_DuplicateDatabaseLink;
        public System.Windows.Forms.ListBox listBox_Duplicate;
    }
}