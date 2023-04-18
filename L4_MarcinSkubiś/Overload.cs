using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L4_MarcinSkubiś
{
    public partial class Overload : Form
    {
        public Overload()
        {
            InitializeComponent();
            for(int i = 0; i < Form1.listR.Count; i++)
            {
                object1.Items.Add("Film nr."+(i+1));
                object2.Items.Add("Film nr."+(i+1));
            }
        }

        private void object1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            label6.Text= Convert.ToString(Form1.listM.ElementAt(object1.SelectedIndex) == Form1.listM.ElementAt(object2.SelectedIndex));
            label7.Text= Convert.ToString(Form1.listM.ElementAt(object1.SelectedIndex) != Form1.listM.ElementAt(object2.SelectedIndex));
            label8.Text= Convert.ToString(Form1.listM[object1.SelectedIndex] + Form1.listM[object2.SelectedIndex]);
            
        }

        private void Overload_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void object2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
