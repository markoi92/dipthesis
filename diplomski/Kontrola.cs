using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diplomski
{
    public partial class Kontrola : Form
    {
        public Kontrola()
        {
            InitializeComponent();
        }

        private void Kontrola_Load(object sender, EventArgs e)
        {
            textBox_tag.Text = LiveControl.control_tag;
        }

        private void but_otpis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}