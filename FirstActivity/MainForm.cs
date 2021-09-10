using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstActivity
{
    public partial class MainForm : Form
    {

        public Panel MainPanel
        {
            get { return mainPanel; }
        }

        private static MainForm _instance;

        public static MainForm Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new MainForm();
                return _instance;
            }
        }

        public MainForm()
        {
            InitializeComponent();
            if (!mainPanel.Controls.ContainsKey("AdminUC"))
            {
                var uc = new AdminUC(this);
                uc.Dock = DockStyle.Fill;
                mainPanel.Controls.Add(uc);
            }
            mainPanel.Controls["AdminUC"].BringToFront();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

       
    }
}
