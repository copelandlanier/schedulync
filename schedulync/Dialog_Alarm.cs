using System;
using System.Windows.Forms;

namespace Calendar_NEW
{
    public partial class Dialog_Alarm : Form
    {
        public Dialog_Alarm()
        {
            InitializeComponent();
            this.Opacity = 1f;
        }

        private void DialogAlarm_ButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

