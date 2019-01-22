namespace Calendar_NEW
{
    partial class Display_Panel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Panel_MainControlHolder = new System.Windows.Forms.Panel();
            this.panel_Holder = new System.Windows.Forms.Panel();
            this.panel_ColorBar = new System.Windows.Forms.Panel();
            this.button_DayControlSettings = new System.Windows.Forms.Button();
            this.panel_Logo = new System.Windows.Forms.Panel();
            this.Button_DayControl_NextDay = new System.Windows.Forms.Button();
            this.Button_DayControl_PrevDay = new System.Windows.Forms.Button();
            this.Button_DayControl_NextMonth = new System.Windows.Forms.Button();
            this.Button_DayControl_PrevMonth = new System.Windows.Forms.Button();
            this.Button_DayControl_Today = new System.Windows.Forms.Button();
            this.Panel_DayControlHolder = new System.Windows.Forms.Panel();
            this.Panel_MainControlHolder.SuspendLayout();
            this.panel_Holder.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_MainControlHolder
            // 
            this.Panel_MainControlHolder.AutoScroll = true;
            this.Panel_MainControlHolder.BackColor = System.Drawing.Color.Transparent;
            this.Panel_MainControlHolder.Controls.Add(this.panel_Holder);
            this.Panel_MainControlHolder.Controls.Add(this.Button_DayControl_NextDay);
            this.Panel_MainControlHolder.Controls.Add(this.Button_DayControl_PrevDay);
            this.Panel_MainControlHolder.Controls.Add(this.Button_DayControl_NextMonth);
            this.Panel_MainControlHolder.Controls.Add(this.Button_DayControl_PrevMonth);
            this.Panel_MainControlHolder.Controls.Add(this.Button_DayControl_Today);
            this.Panel_MainControlHolder.Controls.Add(this.Panel_DayControlHolder);
            this.Panel_MainControlHolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_MainControlHolder.Location = new System.Drawing.Point(0, 0);
            this.Panel_MainControlHolder.Name = "Panel_MainControlHolder";
            this.Panel_MainControlHolder.Size = new System.Drawing.Size(1469, 908);
            this.Panel_MainControlHolder.TabIndex = 0;
            // 
            // panel_Holder
            // 
            this.panel_Holder.BackColor = System.Drawing.Color.Transparent;
            this.panel_Holder.Controls.Add(this.panel_ColorBar);
            this.panel_Holder.Controls.Add(this.button_DayControlSettings);
            this.panel_Holder.Controls.Add(this.panel_Logo);
            this.panel_Holder.Location = new System.Drawing.Point(6, 88);
            this.panel_Holder.Name = "panel_Holder";
            this.panel_Holder.Size = new System.Drawing.Size(569, 102);
            this.panel_Holder.TabIndex = 7;
            // 
            // panel_ColorBar
            // 
            this.panel_ColorBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.panel_ColorBar.Location = new System.Drawing.Point(108, 86);
            this.panel_ColorBar.Name = "panel_ColorBar";
            this.panel_ColorBar.Size = new System.Drawing.Size(450, 12);
            this.panel_ColorBar.TabIndex = 8;
            // 
            // button_DayControlSettings
            // 
            this.button_DayControlSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.button_DayControlSettings.FlatAppearance.BorderSize = 0;
            this.button_DayControlSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_DayControlSettings.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_DayControlSettings.ForeColor = System.Drawing.Color.White;
            this.button_DayControlSettings.Image = global::Calendar_NEW.Properties.Resources.icon_gear;
            this.button_DayControlSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_DayControlSettings.Location = new System.Drawing.Point(0, 69);
            this.button_DayControlSettings.Name = "button_DayControlSettings";
            this.button_DayControlSettings.Size = new System.Drawing.Size(108, 29);
            this.button_DayControlSettings.TabIndex = 7;
            this.button_DayControlSettings.Text = "SETTINGS";
            this.button_DayControlSettings.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_DayControlSettings.UseVisualStyleBackColor = false;
            this.button_DayControlSettings.Click += new System.EventHandler(this.button_DayControlSettings_Click);
            // 
            // panel_Logo
            // 
            this.panel_Logo.BackColor = System.Drawing.Color.White;
            this.panel_Logo.BackgroundImage = global::Calendar_NEW.Properties.Resources.Monolith_Logo;
            this.panel_Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel_Logo.Location = new System.Drawing.Point(3, 3);
            this.panel_Logo.Name = "panel_Logo";
            this.panel_Logo.Size = new System.Drawing.Size(243, 46);
            this.panel_Logo.TabIndex = 6;
            // 
            // Button_DayControl_NextDay
            // 
            this.Button_DayControl_NextDay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(143)))), ((int)(((byte)(143)))));
            this.Button_DayControl_NextDay.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Button_DayControl_NextDay.FlatAppearance.BorderSize = 0;
            this.Button_DayControl_NextDay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_DayControl_NextDay.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_DayControl_NextDay.ForeColor = System.Drawing.Color.White;
            this.Button_DayControl_NextDay.Location = new System.Drawing.Point(1192, 156);
            this.Button_DayControl_NextDay.Name = "Button_DayControl_NextDay";
            this.Button_DayControl_NextDay.Size = new System.Drawing.Size(74, 23);
            this.Button_DayControl_NextDay.TabIndex = 5;
            this.Button_DayControl_NextDay.Text = ">";
            this.Button_DayControl_NextDay.UseVisualStyleBackColor = false;
            this.Button_DayControl_NextDay.Click += new System.EventHandler(this.Button_DayControl_NextDay_Click);
            // 
            // Button_DayControl_PrevDay
            // 
            this.Button_DayControl_PrevDay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(143)))), ((int)(((byte)(143)))));
            this.Button_DayControl_PrevDay.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Button_DayControl_PrevDay.FlatAppearance.BorderSize = 0;
            this.Button_DayControl_PrevDay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_DayControl_PrevDay.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_DayControl_PrevDay.ForeColor = System.Drawing.Color.White;
            this.Button_DayControl_PrevDay.Location = new System.Drawing.Point(1042, 156);
            this.Button_DayControl_PrevDay.Name = "Button_DayControl_PrevDay";
            this.Button_DayControl_PrevDay.Size = new System.Drawing.Size(74, 23);
            this.Button_DayControl_PrevDay.TabIndex = 4;
            this.Button_DayControl_PrevDay.Text = "<";
            this.Button_DayControl_PrevDay.UseVisualStyleBackColor = false;
            this.Button_DayControl_PrevDay.Click += new System.EventHandler(this.Button_DayControl_PrevDay_Click);
            // 
            // Button_DayControl_NextMonth
            // 
            this.Button_DayControl_NextMonth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(143)))), ((int)(((byte)(143)))));
            this.Button_DayControl_NextMonth.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Button_DayControl_NextMonth.FlatAppearance.BorderSize = 0;
            this.Button_DayControl_NextMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_DayControl_NextMonth.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_DayControl_NextMonth.ForeColor = System.Drawing.Color.White;
            this.Button_DayControl_NextMonth.Location = new System.Drawing.Point(1267, 156);
            this.Button_DayControl_NextMonth.Name = "Button_DayControl_NextMonth";
            this.Button_DayControl_NextMonth.Size = new System.Drawing.Size(74, 23);
            this.Button_DayControl_NextMonth.TabIndex = 3;
            this.Button_DayControl_NextMonth.Text = ">>";
            this.Button_DayControl_NextMonth.UseVisualStyleBackColor = false;
            this.Button_DayControl_NextMonth.Click += new System.EventHandler(this.Button_DayControl_NextMonth_Click);
            // 
            // Button_DayControl_PrevMonth
            // 
            this.Button_DayControl_PrevMonth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(143)))), ((int)(((byte)(143)))));
            this.Button_DayControl_PrevMonth.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Button_DayControl_PrevMonth.FlatAppearance.BorderSize = 0;
            this.Button_DayControl_PrevMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_DayControl_PrevMonth.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_DayControl_PrevMonth.ForeColor = System.Drawing.Color.White;
            this.Button_DayControl_PrevMonth.Location = new System.Drawing.Point(967, 156);
            this.Button_DayControl_PrevMonth.Name = "Button_DayControl_PrevMonth";
            this.Button_DayControl_PrevMonth.Size = new System.Drawing.Size(74, 23);
            this.Button_DayControl_PrevMonth.TabIndex = 2;
            this.Button_DayControl_PrevMonth.Text = "<<";
            this.Button_DayControl_PrevMonth.UseVisualStyleBackColor = false;
            this.Button_DayControl_PrevMonth.Click += new System.EventHandler(this.Button_DayControl_PrevMonth_Click);
            // 
            // Button_DayControl_Today
            // 
            this.Button_DayControl_Today.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(143)))), ((int)(((byte)(143)))));
            this.Button_DayControl_Today.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Button_DayControl_Today.FlatAppearance.BorderSize = 0;
            this.Button_DayControl_Today.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_DayControl_Today.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_DayControl_Today.ForeColor = System.Drawing.Color.White;
            this.Button_DayControl_Today.Location = new System.Drawing.Point(1117, 156);
            this.Button_DayControl_Today.Name = "Button_DayControl_Today";
            this.Button_DayControl_Today.Size = new System.Drawing.Size(74, 23);
            this.Button_DayControl_Today.TabIndex = 1;
            this.Button_DayControl_Today.Text = "TODAY";
            this.Button_DayControl_Today.UseVisualStyleBackColor = false;
            this.Button_DayControl_Today.Click += new System.EventHandler(this.Button_DayControl_Today_Click);
            // 
            // Panel_DayControlHolder
            // 
            this.Panel_DayControlHolder.AutoScroll = true;
            this.Panel_DayControlHolder.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Panel_DayControlHolder.BackgroundImage = global::Calendar_NEW.Properties.Resources.bg_SQUARE_slice_03;
            this.Panel_DayControlHolder.Location = new System.Drawing.Point(3, 196);
            this.Panel_DayControlHolder.Name = "Panel_DayControlHolder";
            this.Panel_DayControlHolder.Size = new System.Drawing.Size(1340, 584);
            this.Panel_DayControlHolder.TabIndex = 0;
            // 
            // Display_Panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.Panel_MainControlHolder);
            this.MinimumSize = new System.Drawing.Size(1469, 908);
            this.Name = "Display_Panel";
            this.Size = new System.Drawing.Size(1469, 908);
            this.Panel_MainControlHolder.ResumeLayout(false);
            this.panel_Holder.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel Panel_MainControlHolder;
        public System.Windows.Forms.Panel Panel_DayControlHolder;
        public System.Windows.Forms.Button Button_DayControl_Today;
        public System.Windows.Forms.Button Button_DayControl_NextDay;
        public System.Windows.Forms.Button Button_DayControl_PrevDay;
        public System.Windows.Forms.Button Button_DayControl_NextMonth;
        public System.Windows.Forms.Button Button_DayControl_PrevMonth;
        private System.Windows.Forms.Panel panel_Logo;
        private System.Windows.Forms.Panel panel_Holder;
        public System.Windows.Forms.Button button_DayControlSettings;
        public System.Windows.Forms.Panel panel_ColorBar;
    }
}
