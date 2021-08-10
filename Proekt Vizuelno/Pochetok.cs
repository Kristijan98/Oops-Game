using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proekt_Vizuelno
{
    public partial class Pochetok : Form
    {

        public Pochetok()
        {
            InitializeComponent();
          
        }
        private void button1_Click(object sender, EventArgs e)
        {
         
            Igra igra = new Igra();
            igra.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {

            Upatstvo upatstvo = new Upatstvo();
            upatstvo.Show();
        }

        
    }
  }