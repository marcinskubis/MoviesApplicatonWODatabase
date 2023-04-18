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
    public partial class SortForm : Form
    {
        public SortForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Form1.listR.Count > 0)
            {
                try
                {
                    listBox1.Items.Clear();
                    foreach (Record r in Form1.listR)
                        r.WriteS(listBox1);
                }

                catch (FormatException exe)
                {
                    MessageBox.Show("Wystąpił następujący błąd" + exe.Message);
                }

                catch (Exception exe)
                {
                    MessageBox.Show("Wystąpił następujący błąd" + exe.Message);
                }
            }
            else MessageBox.Show("Lista jest pusta!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Form1.listR.Count > 0)
            {
                try
                {
                    Form1.listR.Sort();
                    listBox1.Items.Clear();
                    foreach (Record r in Form1.listR)
                        r.WriteS(listBox1);
                }

                catch (FormatException exe)
                {
                    MessageBox.Show("Wystąpił następujący błąd" + exe.Message);
                }

                catch (Exception exe)
                {
                    MessageBox.Show("Wystąpił następujący błąd" + exe.Message);
                }
            }
            else MessageBox.Show("Lista jest pusta!");

        }
    }
}
