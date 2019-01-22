namespace Calendar_NEW
{
    partial class PersonnelImageBox
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
            this.label_PImageName = new System.Windows.Forms.Label();
            this.ImageBox_Left_Border = new System.Windows.Forms.Panel();
            this.ImageBox_Right_Border = new System.Windows.Forms.Panel();
            this.openFile_PersonnelImage = new System.Windows.Forms.OpenFileDialog();
            this.ImageBox_Top_Border = new System.Windows.Forms.Panel();
            this.panel_PersonnelImage = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label_PImageName
            // 
            this.label_PImageName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_PImageName.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_PImageName.ForeColor = System.Drawing.Color.DimGray;
            this.label_PImageName.Location = new System.Drawing.Point(0, 99);
            this.label_PImageName.Name = "label_PImageName";
            this.label_PImageName.Size = new System.Drawing.Size(120, 51);
            this.label_PImageName.TabIndex = 0;
            this.label_PImageName.Text = "Kevin \r\nKeller";
            this.label_PImageName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_PImageName.UseCompatibleTextRendering = true;
            // 
            // ImageBox_Left_Border
            // 
            this.ImageBox_Left_Border.BackColor = System.Drawing.Color.DarkGray;
            this.ImageBox_Left_Border.Location = new System.Drawing.Point(0, 0);
            this.ImageBox_Left_Border.Margin = new System.Windows.Forms.Padding(0);
            this.ImageBox_Left_Border.Name = "ImageBox_Left_Border";
            this.ImageBox_Left_Border.Size = new System.Drawing.Size(1, 150);
            this.ImageBox_Left_Border.TabIndex = 2;
            // 
            // ImageBox_Right_Border
            // 
            this.ImageBox_Right_Border.BackColor = System.Drawing.Color.DarkGray;
            this.ImageBox_Right_Border.Location = new System.Drawing.Point(119, 0);
            this.ImageBox_Right_Border.Margin = new System.Windows.Forms.Padding(0);
            this.ImageBox_Right_Border.Name = "ImageBox_Right_Border";
            this.ImageBox_Right_Border.Size = new System.Drawing.Size(1, 150);
            this.ImageBox_Right_Border.TabIndex = 4;
            // 
            // openFile_PersonnelImage
            // 
            this.openFile_PersonnelImage.FileName = "openFile_PersonnelImage";
            // 
            // ImageBox_Top_Border
            // 
            this.ImageBox_Top_Border.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.ImageBox_Top_Border.Location = new System.Drawing.Point(0, 0);
            this.ImageBox_Top_Border.Name = "ImageBox_Top_Border";
            this.ImageBox_Top_Border.Size = new System.Drawing.Size(120, 1);
            this.ImageBox_Top_Border.TabIndex = 5;
            // 
            // panel_PersonnelImage
            // 
            this.panel_PersonnelImage.AllowDrop = true;
            this.panel_PersonnelImage.BackColor = System.Drawing.Color.White;
            this.panel_PersonnelImage.BackgroundImage = global::Calendar_NEW.Properties.Resources.Empty_Personnel;
            this.panel_PersonnelImage.Location = new System.Drawing.Point(19, 16);
            this.panel_PersonnelImage.Name = "panel_PersonnelImage";
            this.panel_PersonnelImage.Size = new System.Drawing.Size(80, 80);
            this.panel_PersonnelImage.TabIndex = 1;
            // 
            // PersonnelImageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.Controls.Add(this.ImageBox_Top_Border);
            this.Controls.Add(this.ImageBox_Right_Border);
            this.Controls.Add(this.ImageBox_Left_Border);
            this.Controls.Add(this.panel_PersonnelImage);
            this.Controls.Add(this.label_PImageName);
            this.Name = "PersonnelImageBox";
            this.Size = new System.Drawing.Size(120, 150);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label label_PImageName;
        public System.Windows.Forms.Panel panel_PersonnelImage;
        private System.Windows.Forms.Panel ImageBox_Left_Border;
        //private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel ImageBox_Right_Border;
        private System.Windows.Forms.OpenFileDialog openFile_PersonnelImage;
        private System.Windows.Forms.Panel ImageBox_Top_Border;
    }
}
