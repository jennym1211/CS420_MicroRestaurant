using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MicroRestaurantFrontEnd
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            Bartender bt = new Bartender();
            bt.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Hide();
            Waiter wa = new Waiter();
            wa.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Hide();
            Busboy bb = new Busboy();
            bb.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Hostess hs = new Hostess();
            hs.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Hide();
            Kitchen ki = new Kitchen();
            ki.Show();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }
    }
}