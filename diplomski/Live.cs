using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Data.SqlClient;

namespace diplomski
{
    public partial class Live : Form
    {
        public Live()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SidePanel.Height = MenuLive.Height;
            SidePanel.Top = MenuLive.Top;
            liveControl1.BringToFront();
        }

        private void MenuLive_Click(object sender, EventArgs e)
        {
            SidePanel.Height = MenuLive.Height;
            SidePanel.Top = MenuLive.Top;
            liveControl1.BringToFront();
        }

        private void MenuSkladiste_Click(object sender, EventArgs e)
        {
            SidePanel.Height = MenuSkladiste.Height;
            SidePanel.Top = MenuSkladiste.Top;
            skladisteControl1.BringToFront();
        }

        private void MenuNeispravni_Click(object sender, EventArgs e)
        {
            SidePanel.Height = MenuNeispravni.Height;
            SidePanel.Top = MenuNeispravni.Top;
        }

    }
}