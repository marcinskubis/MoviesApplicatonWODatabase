using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace L4_MarcinSkubiś
{
    public partial class Form1 : Form
    {
        public static List<Record> listR = new List<Record>();
        public static List<Movie> listM = new List<Movie>();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*Record r1 = new Record();
            r1.Write(listBox1);

            Record r2 = new Record("Nienawistna ósemka", "The Hateful Eight", "Quentin", "Tarantino", "USA", "Robert Richardson", 182, 2001, 01, DateTime.MinValue, 3.6);
            r2.Write(listBox1);

            Record r3 = new Record(r2);
            r3.Write(listBox1);

            /*Movie m1 = new Movie("Nienawistna ósemka", "The Hateful Eight", "Quentin", "Tarantino", "USA", "Robert Richardson", 182, 2001, 01, 1.5.2001, 3.6, 44000000, "Fred Raskin", "english", 43);
            m1.Write(listBox1);*/

        }


        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Filmm f2=new Filmm();
            f2.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Koncert f3=new Koncert();
            f3.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Lista f4 = new Lista();
            f4.ShowDialog();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Overload f5 = new Overload();
            f5.ShowDialog();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            SortForm f6 = new SortForm();
            f6.ShowDialog();
        }
    }
}
