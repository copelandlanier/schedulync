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
    public partial class Dialog_Console : Global_Access
    {
        public Dialog_Console()
        {
            InitializeComponent();
            textBox_Dialog_Console.KeyDown += TextBox_Dialog_Console_Press;
            this.FormClosing += Dialog_Console_FormClosing;
        }

        private void Dialog_Console_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            dialog_console.Hide();
            Console.WriteLine("Form Closing");
        }

        private void TextBox_Dialog_Console_Press(object sender, KeyEventArgs e)
        {          
            if(e.Alt == true && e.KeyCode == Keys.C)
            {
                textBox_Dialog_Console.Clear();
                StringHolder.Clear();
            }
        }
    }
}
