using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diplomski
{
    public partial class SkladisteControl : UserControl
    {
        public SkladisteControl()
        {
            InitializeComponent();
        }

        private void SkladisteControl_Load(object sender, EventArgs e)
        {
            using (DiplomskiEntities entity = new DiplomskiEntities()) // (entity framework)
            {
                List<Tag> tagovi = new List<Tag>();
                var stanje;
                var available = entity.Events.Where(p => p.place == "4").Where(d => d.date_out == null);
                foreach(var tag in available)
                {
                    var tags = entity.Tags.Where(t => t.ID_tag == tag.tag_ID);
                    tagovi += tags;

                }
                dgv.DataSource = tagovi.ToList();

            }
            
        }
    }
}
