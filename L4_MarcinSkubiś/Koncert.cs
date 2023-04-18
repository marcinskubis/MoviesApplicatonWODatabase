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
    public partial class Koncert : Form
    {
        public Bitmap posterr = null;
        public Koncert()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                string fileName = openFileDialog2.FileName;
                posterr = new Bitmap(fileName);
                pictureBox3.Image = posterr;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Concert c1 = new Concert(namePL.Text, name.Text, cntry.Text, media.Text, genre.Text, Convert.ToInt32(length.Text), Convert.ToDateTime(data.Text), Convert.ToDateTime(dataPL.Text), bnw(), Convert.ToDouble(price.Text), (Bitmap)pictureBox2.Image, town.Text, facility.Text, artist.Text, distributor.Text);
            c1.WriteCon(listBox3, pictureBox2);
            Form1.listR.Add(c1);
           
        }
        private bool bnw()
        {
            if (bnww.Checked)
            {
                return true;
            }
            return false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            namePL.Text = "KULT MTV UNPLUGGED";
            name.Text = "KULT MTV UNPLUGGED";
            cntry.Text = "Polska";
            media.Text = "DVD";
            genre.Text = "Rock";
            length.Text = "65";
            price.Text = "3,50";
            data.Text = "29.11.2010";
            dataPL.Text = "29.11.2010";
            town.Text = "Warszawa";
            facility.Text = "Och Teatr";
            artist.Text = "KULT";
            distributor.Text = "S.P Records";
            pictureBox2.Image = Properties.Resources.KultMTVUnplugged;


        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Koncert_Load(object sender, EventArgs e)
        {

        }

        private void length_KeyDown(object sender, KeyEventArgs e)
        {
            //Convert.ToInt32(length.Text)--;
        }

        private void namePL_Leave(object sender, EventArgs e)
        {
            if(namePL.Text.Length == 0)
            {
                MessageBox.Show("Brak danych w poprzednim polu");
            }
        }

        private void dataPL_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void openFileDialog2_FileOk(object sender, CancelEventArgs e)
        {

        }
        /*private void ClearTextBoxes()
{
namePL.Clear();
name.Clear();
cntry.Clear();
media.Clear();
genre.Clear();
length = null;
price.Clear();
data.Clear();
dataPL.Clear();
town.Clear();
facility.Clear();
artist.Clear();
distributor.Clear();
pictureBox2.Image = null;

}*/
    }
}
