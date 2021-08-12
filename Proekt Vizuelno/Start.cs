using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Runtime.InteropServices;

namespace Proekt_Vizuelno
{
    public partial class Start : Form
    {
      

        public Start()
        {
            InitializeComponent();
        }

 
     
        private void button1_Click(object sender, EventArgs e)
        {
         
            Game igra = new Game();
            igra.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {

            Instruction upatstvo = new Instruction();
            upatstvo.Show();
        }

        int counter = 0;
        int counter2 = 0;

        int len = 0;
        int len2 = 0;

        string text;
        string text2;

        private void Pochetok_Load(object sender, EventArgs e)
        {
            label1.Hide();
            label2.Hide();

            text = label1.Text;
            text2 = label2.Text;

            len = text.Length;
            len2 = text2.Length;

            label1.Text = "";
            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = text.Substring(0, counter);
            label1.Show();
            ++counter;

            if(counter > len)
            {
                label2.Show();
                timer1.Stop();
            }
        }
    }
  }