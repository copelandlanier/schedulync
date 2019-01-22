namespace Calendar_NEW
{
    partial class Dialog_Repeat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dialog_Repeat));
            this.DialogRepeat_Label_Title = new System.Windows.Forms.Label();
            this.DialogRepeat_RadioEndsNever = new System.Windows.Forms.RadioButton();
            this.DialogRepeat_RadioEndsOn = new System.Windows.Forms.RadioButton();
            this.DialogRepeat_LabelEnds = new System.Windows.Forms.Label();
            this.DialogRepeat_LabelRepeats = new System.Windows.Forms.Label();
            this.DialogRepeat_RepeatEvery = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.Button_DataEntry_Cancel = new System.Windows.Forms.Button();
            this.Button_DataEntry_OK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            this.SuspendLayout();
            // 
            // DialogRepeat_Label_Title
            // 
            this.DialogRepeat_Label_Title.AutoSize = true;
            this.DialogRepeat_Label_Title.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DialogRepeat_Label_Title.Location = new System.Drawing.Point(30, 10);
            this.DialogRepeat_Label_Title.Name = "DialogRepeat_Label_Title";
            this.DialogRepeat_Label_Title.Size = new System.Drawing.Size(121, 36);
            this.DialogRepeat_Label_Title.TabIndex = 0;
            this.DialogRepeat_Label_Title.Text = "Repeat";
            // 
            // DialogRepeat_RadioEndsNever
            // 
            this.DialogRepeat_RadioEndsNever.AutoSize = true;
            this.DialogRepeat_RadioEndsNever.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DialogRepeat_RadioEndsNever.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DialogRepeat_RadioEndsNever.Location = new System.Drawing.Point(239, 179);
            this.DialogRepeat_RadioEndsNever.Name = "DialogRepeat_RadioEndsNever";
            this.DialogRepeat_RadioEndsNever.Size = new System.Drawing.Size(63, 21);
            this.DialogRepeat_RadioEndsNever.TabIndex = 5;
            this.DialogRepeat_RadioEndsNever.TabStop = true;
            this.DialogRepeat_RadioEndsNever.Text = "Never";
            this.DialogRepeat_RadioEndsNever.UseVisualStyleBackColor = true;
            // 
            // DialogRepeat_RadioEndsOn
            // 
            this.DialogRepeat_RadioEndsOn.AutoSize = true;
            this.DialogRepeat_RadioEndsOn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DialogRepeat_RadioEndsOn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DialogRepeat_RadioEndsOn.Location = new System.Drawing.Point(239, 202);
            this.DialogRepeat_RadioEndsOn.Name = "DialogRepeat_RadioEndsOn";
            this.DialogRepeat_RadioEndsOn.Size = new System.Drawing.Size(44, 21);
            this.DialogRepeat_RadioEndsOn.TabIndex = 14;
            this.DialogRepeat_RadioEndsOn.TabStop = true;
            this.DialogRepeat_RadioEndsOn.Text = "On";
            this.DialogRepeat_RadioEndsOn.UseVisualStyleBackColor = true;
            // 
            // DialogRepeat_LabelEnds
            // 
            this.DialogRepeat_LabelEnds.AutoSize = true;
            this.DialogRepeat_LabelEnds.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DialogRepeat_LabelEnds.Location = new System.Drawing.Point(188, 181);
            this.DialogRepeat_LabelEnds.Name = "DialogRepeat_LabelEnds";
            this.DialogRepeat_LabelEnds.Size = new System.Drawing.Size(45, 17);
            this.DialogRepeat_LabelEnds.TabIndex = 20;
            this.DialogRepeat_LabelEnds.Text = "ENDS:";
            // 
            // DialogRepeat_LabelRepeats
            // 
            this.DialogRepeat_LabelRepeats.AutoSize = true;
            this.DialogRepeat_LabelRepeats.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DialogRepeat_LabelRepeats.Location = new System.Drawing.Point(171, 96);
            this.DialogRepeat_LabelRepeats.Name = "DialogRepeat_LabelRepeats";
            this.DialogRepeat_LabelRepeats.Size = new System.Drawing.Size(62, 17);
            this.DialogRepeat_LabelRepeats.TabIndex = 21;
            this.DialogRepeat_LabelRepeats.Text = "REPEATS:";
            // 
            // DialogRepeat_RepeatEvery
            // 
            this.DialogRepeat_RepeatEvery.AutoSize = true;
            this.DialogRepeat_RepeatEvery.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DialogRepeat_RepeatEvery.Location = new System.Drawing.Point(135, 124);
            this.DialogRepeat_RepeatEvery.Name = "DialogRepeat_RepeatEvery";
            this.DialogRepeat_RepeatEvery.Size = new System.Drawing.Size(98, 17);
            this.DialogRepeat_RepeatEvery.TabIndex = 22;
            this.DialogRepeat_RepeatEvery.Text = "REPEAT EVERY:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(282, 203);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(112, 20);
            this.dateTimePicker1.TabIndex = 78;
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(239, 95);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(62, 20);
            this.numericUpDown3.TabIndex = 81;
            this.numericUpDown3.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Day",
            "Week",
            "Month",
            "Year"});
            this.comboBox1.Location = new System.Drawing.Point(239, 122);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(63, 21);
            this.comboBox1.TabIndex = 82;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(239, 268);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(119, 17);
            this.checkBox1.TabIndex = 83;
            this.checkBox1.Text = "Exclude Weekends";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Button_DataEntry_Cancel
            // 
            this.Button_DataEntry_Cancel.BackColor = System.Drawing.Color.Gainsboro;
            this.Button_DataEntry_Cancel.Location = new System.Drawing.Point(377, 330);
            this.Button_DataEntry_Cancel.Name = "Button_DataEntry_Cancel";
            this.Button_DataEntry_Cancel.Size = new System.Drawing.Size(75, 23);
            this.Button_DataEntry_Cancel.TabIndex = 87;
            this.Button_DataEntry_Cancel.Text = "Cancel";
            this.Button_DataEntry_Cancel.UseVisualStyleBackColor = false;
            // 
            // Button_DataEntry_OK
            // 
            this.Button_DataEntry_OK.BackColor = System.Drawing.Color.Gainsboro;
            this.Button_DataEntry_OK.Location = new System.Drawing.Point(458, 330);
            this.Button_DataEntry_OK.Name = "Button_DataEntry_OK";
            this.Button_DataEntry_OK.Size = new System.Drawing.Size(75, 23);
            this.Button_DataEntry_OK.TabIndex = 88;
            this.Button_DataEntry_OK.Text = "OK";
            this.Button_DataEntry_OK.UseVisualStyleBackColor = false;
            // 
            // Dialog_Repeat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(584, 366);
            this.Controls.Add(this.Button_DataEntry_Cancel);
            this.Controls.Add(this.Button_DataEntry_OK);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.DialogRepeat_Label_Title);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.numericUpDown3);
            this.Controls.Add(this.DialogRepeat_RepeatEvery);
            this.Controls.Add(this.DialogRepeat_LabelRepeats);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.DialogRepeat_LabelEnds);
            this.Controls.Add(this.DialogRepeat_RadioEndsOn);
            this.Controls.Add(this.DialogRepeat_RadioEndsNever);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(600, 400);
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "Dialog_Repeat";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Monolith Calendar";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DialogRepeat_Label_Title;
        private System.Windows.Forms.RadioButton DialogRepeat_RadioEndsNever;
        private System.Windows.Forms.RadioButton DialogRepeat_RadioEndsOn;
        private System.Windows.Forms.Label DialogRepeat_LabelEnds;
        private System.Windows.Forms.Label DialogRepeat_LabelRepeats;
        private System.Windows.Forms.Label DialogRepeat_RepeatEvery;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button Button_DataEntry_Cancel;
        public System.Windows.Forms.Button Button_DataEntry_OK;
    }
}