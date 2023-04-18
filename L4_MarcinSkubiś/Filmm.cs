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
    public partial class Filmm : Form
    {
        public Bitmap bitmap=null;
        public Filmm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void premierePL_TextChanged(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string fileName = openFileDialog1.FileName;
                bitmap = new Bitmap(fileName);
                pictureBoxmaly.Image = bitmap;
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
        private void ClearTextBoxes()
        {
            PLname.Clear();
            ORname.Clear();
            country.Clear();
            price.Text = null;
            edit.Clear();
            lang.Clear();
            media.Clear();
            category.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Movie m1 = new Movie(PLname.Text,ORname.Text,country.Text,media.Text,category.Text,Convert.ToInt32(lngth.Text),orgDate.Value, dataPL.Value,bnw(),Convert.ToDouble(price.Text),(Bitmap)pictureBox1.Image,Convert.ToInt32(budget.Text),edit.Text,lang.Text,Convert.ToInt32(awards.Text));
            m1.WriteCon(listBox2, pictureBox1);
            Form1.listR.Add(m1);
            Form1.listM.Add(m1);
            ClearTextBoxes();

        }

        private bool bnw()
        {
            if (blackandwhite.Checked)
            {
                return true;
            }
            return false;
        }

        private void awards_ValueChanged(object sender, EventArgs e)
        {

        }

        private void budget_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            PLname.Text = "Nienawistna ósemka";
            ORname.Text = "The hateful eight";
            country.Text = "Usa";
            media.Text = "BlueRay";
            category.Text = "Western";
            lngth.Text = "182";
            orgDate.Text = "08.01.2016";
            dataPL.Text = "15.01.2016";
            price.Text = "3,6";
            bitmap = null;
            budget.Text = "44000000";
            edit.Text = "Fred Raskin";
            lang.Text = "Angielski";
            awards.Text = "43";
            pictureBox1.Image = Properties.Resources.TheHatefulEight;
        }

        private void blackandwhite_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PLname_TextChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("Proszę wpisać date w poprawnym formacie");
        }

        private void dataPL_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Proszę wpisać date w poprawnym formacie :)");
        }

        private void budget_Leave(object sender, EventArgs e)
        {
            if(Convert.ToInt32(budget.Text) == 0)
            {
                MessageBox.Show("Budżet nie może wynosić 0$");
            }
        }
    }
}
