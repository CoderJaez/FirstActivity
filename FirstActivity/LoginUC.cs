using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstActivity
{
    public partial class LoginUC : UserControl
    {
        private MainForm main;
        public LoginUC(MainForm _main)
        {
            InitializeComponent();
            main = _main;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            main.MainPanel.Controls["AdminUC"].BringToFront();
        }
    }
}
