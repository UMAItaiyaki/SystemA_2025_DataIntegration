using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Management
{
    public partial class Top : Form
    {
        public Top()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form next = new SalesData();
            next.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form next = new Transmission();
            next.ShowDialog();
        }
    }
}
