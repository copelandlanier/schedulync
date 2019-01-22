using System;
using System.Windows.Forms;

namespace Calendar_NEW
{
    public partial class Dialog_Repeat : Global_Access
    {
        public Dialog_Repeat()
        {
            InitializeComponent();
            this.Opacity = 1f;
        }

        private void DialogRepeat_ButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

