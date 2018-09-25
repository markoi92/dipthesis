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
    public partial class LiveControl : UserControl
    {
        SerialPort port;

        public static string control_tag = "";
        public delegate void UpdateGUI(string data);

        public LiveControl()
        {
            InitializeComponent();
        }
        private void LiveControl_Load(object sender, EventArgs e)
        {
            port = new SerialPort("COM3", 9600, Parity.None, 8, StopBits.One);
            port.Handshake = Handshake.None;
            port.DataReceived += new SerialDataReceivedEventHandler(Datareceived);
            //port.Open();
        }
        public void DisplayReceivedData(string data)
        {
            string StrTag = data.Substring(data.IndexOf("D: ") + 3);
            string StrReaderID = data.Substring(7, 1);
            //StrReaderID = 0 ==> u stroju 1 je
            //StrReaderID = 1 ==> u stroju 2 je
            //StrReaderID = 2 ==> u stroju 3 je
            //StrReaderID = 3 ==> u kontroli je
            //StrReaderID = 4 ==> u skladistu je
            //StrReaderID = 5 ==> izlaz iz skladista

            if (data.Length != 0)
            {
                if (StrReaderID == "4") //dodaje u skladiste na prikazu
                {
                    listBox1.Items.Add(StrTag);

                    using (DiplomskiEntities entity = new DiplomskiEntities()) //upisuje u bazu novi tag ako nije tamo i vrijeme dolaska taga na mjesto (entity framework)
                    {
                        Tag newtag = entity.Tags.FirstOrDefault(t => t.tag1 == StrTag);
                        if (newtag == null)
                        {
                            Tag addtag = new Tag { tag1 = StrTag };
                            entity.Tags.Add(addtag);
                            entity.SaveChanges();
                        }
                        Tag tag = entity.Tags.FirstOrDefault(t => t.tag1 == StrTag);
                        Event arrival = new Event { place = StrReaderID, date_in = DateTime.Now, tag_ID = tag.ID_tag };
                        entity.Events.Add(arrival);
                        entity.SaveChanges();
                    }
                }
                if (StrReaderID == "5") //brise iz skladista na izlazu (samo za live prikaz)
                {
                    listBox1.Items.Remove(StrTag);
                    using (DiplomskiEntities entity = new DiplomskiEntities()) //update date_out u bazi i brise ga iz live prikaza skladista (entity framework)
                    {
                        Tag ThatOne = entity.Tags.FirstOrDefault(t => t.tag1 == StrTag); //pronalazi u bazi tag da bi mogao naci njegov ID
                        Event departure = entity.Events.Where(n => n.tag_ID == ThatOne.ID_tag).Where(m => m.place == "4").OrderByDescending(t => t.date_in).FirstOrDefault();
                        if (departure != null)
                        {
                            departure.date_out = DateTime.Now;
                            entity.SaveChanges();
                        }
                    }
                }

                if (this.Controls.ContainsKey("textBox" + StrReaderID))
                {
                    TextBox txtBox = this.Controls["textBox" + StrReaderID] as TextBox;

                    foreach (Control x in this.Controls.OfType<TextBox>()) //brise iz proslog textbox-a ako je bio i unosi date_out u bazu
                    {
                        if (((TextBox)x).Text == StrTag)
                        {
                            string index = ((TextBox)x).Name.Substring(((TextBox)x).Name.Length - 1); //index textbox-a u koji je bio jer je to ujedno i oznaka readera
                            using (DiplomskiEntities entity = new DiplomskiEntities()) //update date_out u bazi i brise ga iz live prikaza odnosno textbox-a (entity framework)
                            {
                                Tag ThatOne = entity.Tags.FirstOrDefault(t => t.tag1 == ((TextBox)x).Text); //pronalazi u bazi tag da bi mogao naci njegov ID
                                Event departure = entity.Events.Where(n => n.tag_ID == ThatOne.ID_tag).Where(m => m.place == index).OrderByDescending(t => t.date_in).FirstOrDefault();
                                if (departure != null)
                                {
                                    departure.date_out = DateTime.Now;
                                    entity.SaveChanges();
                                }
                            }
                            ((TextBox)x).Text = string.Empty;
                        }
                    }
                    txtBox.Text = StrTag; //upisuje tag sa readera u textbox kojem pripada

                    using (DiplomskiEntities entity = new DiplomskiEntities()) //upisuje u bazu novi tag ako nije tamo i vrijeme dolaska taga na mjesto (entity framework)
                    {
                        Tag newtag = entity.Tags.FirstOrDefault(t => t.tag1 == StrTag);
                        if (newtag == null)
                        {
                            Tag addtag = new Tag { tag1 = StrTag };
                            //evo nesto
                            entity.Tags.Add(addtag);
                            entity.SaveChanges();
                        }
                        Tag tag = entity.Tags.FirstOrDefault(t => t.tag1 == StrTag);
                        Event arrival = new Event { place = StrReaderID, date_in = DateTime.Now, tag_ID = tag.ID_tag };
                        entity.Events.Add(arrival);
                        entity.SaveChanges();
                    }

                    if (txtBox == textBox3) //otvara prozor kontrole
                    {
                        control_tag = StrTag;
                        Form Kontrola = new Kontrola();
                        Kontrola.ShowDialog();
                    }

                }
                //if (int.Parse(StrReaderID) == 5)
                //{
                //    listBox1.Items.Add(StrTagID);
                //}
            }
        }


        public void Datareceived(object sender, SerialDataReceivedEventArgs arg)
        {
            SerialPort sp = (SerialPort)sender;
            string data = sp.ReadLine();
            Invoke(new UpdateGUI(DisplayReceivedData), data);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connetionString = null;
            SqlConnection cnn;
            connetionString = "Server = localhost; Database = Diplomski; Integrated Security = SSPI; ";
            cnn = new SqlConnection(connetionString);
            try
            {
                cnn.Open();
                MessageBox.Show("Connection Open ! ");
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! " + ex);
            }
        }

        //public async void button1_Click(object sender, EventArgs e)
        //{
        //    var doc = await _testCollection.Find(c => c.tag == "glupi_tag").SingleAsync();

        //    if (!(doc == null))
        //    {
        //        textBox1.Text = doc.ID.ToString();
        //        ///MessageBox.Show(doc.ID.ToString());
        //    }
        //}

    }
}
