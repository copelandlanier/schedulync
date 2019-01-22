namespace Calendar_NEW
{
    partial class Dialog_Console
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
            this.textBox_Dialog_Console = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox_Dialog_Console
            // 
            this.textBox_Dialog_Console.BackColor = System.Drawing.Color.Black;
            this.textBox_Dialog_Console.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_Dialog_Console.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox_Dialog_Console.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_Dialog_Console.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Dialog_Console.ForeColor = System.Drawing.Color.White;
            this.textBox_Dialog_Console.Location = new System.Drawing.Point(0, 0);
            this.textBox_Dialog_Console.Multiline = true;
            this.textBox_Dialog_Console.Name = "textBox_Dialog_Console";
            this.textBox_Dialog_Console.ReadOnly = true;
            this.textBox_Dialog_Console.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_Dialog_Console.Size = new System.Drawing.Size(584, 362);
            this.textBox_Dialog_Console.TabIndex = 0;
            this.textBox_Dialog_Console.Text = "This is a test string";
            // 
            // Dialog_Console
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(584, 362);
            this.Controls.Add(this.textBox_Dialog_Console);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Dialog_Console";
            this.Text = "Monolith Calendar Console";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox textBox_Dialog_Console;
    }
}