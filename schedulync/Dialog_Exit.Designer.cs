namespace Calendar_NEW
{
    partial class Dialog_Exit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dialog_Exit));
            this.button_ExitNo = new System.Windows.Forms.Button();
            this.button_ExitYES = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_ExitNo
            // 
            this.button_ExitNo.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_ExitNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ExitNo.Location = new System.Drawing.Point(303, 187);
            this.button_ExitNo.Name = "button_ExitNo";
            this.button_ExitNo.Size = new System.Drawing.Size(95, 41);
            this.button_ExitNo.TabIndex = 0;
            this.button_ExitNo.Text = "No";
            this.button_ExitNo.UseVisualStyleBackColor = true;
            this.button_ExitNo.Click += new System.EventHandler(this.button_ExitNo_Click);
            // 
            // button_ExitYES
            // 
            this.button_ExitYES.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ExitYES.Location = new System.Drawing.Point(183, 187);
            this.button_ExitYES.Name = "button_ExitYES";
            this.button_ExitYES.Size = new System.Drawing.Size(95, 41);
            this.button_ExitYES.TabIndex = 1;
            this.button_ExitYES.Text = "Yes";
            this.button_ExitYES.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(198, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Would you like to exit?";
            // 
            // Dialog_Exit
            // 
            this.AcceptButton = this.button_ExitYES;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button_ExitNo;
            this.ClientSize = new System.Drawing.Size(584, 362);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_ExitYES);
            this.Controls.Add(this.button_ExitNo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 400);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "Dialog_Exit";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Monolith Calendar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_ExitNo;
        public System.Windows.Forms.Button button_ExitYES;
        private System.Windows.Forms.Label label1;
    }
}