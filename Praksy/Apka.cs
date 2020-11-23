using System;
using System.Windows.Forms;

namespace Praksy
{
    public partial class Apka : Form
    {
        Timer t = new Timer();
        DateTime koniecPraktyk = new DateTime(2020, 12, 11,15,0,0);
        //rrrr,mm,dd,hh,mm,ss
        public Apka()
        {
            InitializeComponent();

        }
        private void Apka_Load(object sender, EventArgs e)
        {
            //co sekunde
            t.Interval = 1000;
            t.Tick += new EventHandler(this.t_Tick);
            t.Start();
        }
        private void t_Tick(object sender, EventArgs e)
        {
            //aktualny czas
            aktualnyCzas.Text = "Aktualny czas: " + DateTime.Now.ToLongTimeString();
            aktualnaData.Text = "Aktualna data: " + DateTime.Now.ToLongDateString(); 
            //czas do końca praktyk 
            doKoncaPraktyk.Text = "Do końca praktyk: " + koniecPraktyk.Subtract(DateTime.Now).Days +" dni " + koniecPraktyk.Subtract(DateTime.Now).Hours + " godzin " + koniecPraktyk.Subtract(DateTime.Now).Minutes + " minut "+ koniecPraktyk.Subtract(DateTime.Now).Seconds + " sekund.";
        }
    }
}
