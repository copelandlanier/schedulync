using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calendar_NEW
{
    public partial class Dialog_Exit : Global_Access
    {
        public Dialog_Exit()
        {
            InitializeComponent();
        }

        private void button_ExitNo_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
