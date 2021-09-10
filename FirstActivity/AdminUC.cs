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
    public partial class AdminUC : UserControl
    {
        private MainForm main;
        public AdminUC(MainForm _main)
        {
            InitializeComponent();
            main = _main;
        }
        private void buttonMenu(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            switch (btn.Text)
            {
                case "Dashboard":
                    if (!adminPanel.Controls.ContainsKey("DashboardUC"))
                    {
                        var uc = new DashboardUC();
                        uc.Dock = DockStyle.Fill;
                        adminPanel.Controls.Add(uc);
                    }
                    adminPanel.Controls["DashboardUC"].BringToFront();
                    break;

                case "User":
                    if (!adminPanel.Controls.ContainsKey("UserUC"))
                    {
                        var uc = new UserUC();
                        uc.Dock = DockStyle.Fill;
                        adminPanel.Controls.Add(uc);
                    }
                    adminPanel.Controls["UserUC"].BringToFront();
                    break;
                case "Logout":
                    if (!main.MainPanel.Controls.ContainsKey("LoginUC"))
                    {
                        var uc = new LoginUC(main);
                        uc.Dock = DockStyle.Fill;
                        main.MainPanel.Controls.Add(uc);
                    }
                    main.MainPanel.Controls["LoginUC"].BringToFront();
                    break;

            }
        }
    }
}
