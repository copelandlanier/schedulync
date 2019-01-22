using System;
using LiteDB;
using System.Linq;
using System.IO;
using System.Timers;

namespace Calendar_NEW
{
    public partial class Dialog_FirstRun_DuplicateEntries : Global_Access
    {

        public Dialog_FirstRun_DuplicateEntries()
        {
            InitializeComponent();            
         }

        private void listBox_Duplicate_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_Duplicate.SelectedItem != null)
            {
            label_DuplicateDatabaseLink.Text = "Database linked to: " + listBox_Duplicate.SelectedItem.ToString();
                DuplicateButton_Next.Enabled = true;
            }
        }

        private void DuplicateButton_ChangeName_Click(object sender, EventArgs e)
        {
            label_DuplicateDatabaseLink.Text = "Database linked to: ";
            this.Hide();
            dialog_settings.Show();
        }

        private void DuplicateButton_Back_Click(object sender, EventArgs e)
        {
            label_DuplicateDatabaseLink.Text = "Database linked to: ";
            this.Hide();
            dialog_settings.Show();
        }

        private void DuplicateButton_Next_Click(object sender, EventArgs e)
        {
            MonolithConsole("This is the next button being clicked...");
        }
    }
}
