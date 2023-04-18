using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace L4_MarcinSkubiś
{
    public partial class Lista : Form
    {
        int currentIndex = -1;
        public Lista()
        {
            InitializeComponent();
            //label1.Text = "";
            currentIndex = -1;
            UpdateButtons();
            if(Form1.listR.Count > 0)
            {
                label2.Text="Średnia długość nagrań na liście:"+Average_Length();
            }
        }


        private void UpdateButtons()
        {
            if (currentIndex == 0) 
                button1.Enabled = false;
            else
                button1.Enabled = true;
            if (currentIndex >= Form1.listR.Count - 1) 
                button2.Enabled = false;
            else
                button2.Enabled = true;
            if (currentIndex < 0) 
            {
                button2.Enabled = false;
                button1.Enabled = false;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            currentIndex--;
            listBox11.Items.Clear();
            Form1.listR[currentIndex].WriteCon(listBox11, pictureBox11);
            UpdateButtons();

        }
        private void button2_Click(object sender, EventArgs e)
        {
            currentIndex++;
            listBox11.Items.Clear();
            Form1.listR[currentIndex].WriteCon(listBox11, pictureBox11);
            UpdateButtons();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UpdateButtons();

            if (Form1.listR.Count > 0) 
            {
                currentIndex = 0; 
                listBox11.Items.Clear();
                Form1.listR[currentIndex].WriteCon(listBox11, pictureBox11);
                UpdateButtons();
            }
            else
                MessageBox.Show("Lista jest pusta!");
        }

        private void listBox11_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Plik tekstowy|*.txt";
                sfd.Title = "Podaj nazwę pliku do zapisu danych osób";
                sfd.ShowDialog();
                if (sfd.FileName != "")
                {
                    StreamWriter sw = new StreamWriter(sfd.FileName);
                    foreach (Record r in Form1.listR)
                        r.WriteToFile(sw);
                    sw.Close();
                }
            }

            catch(FormatException exe)
            {
                MessageBox.Show("Wystąpił wyjątek: " + exe.Message);
            }

            catch(Exception exe)
            {
                MessageBox.Show("Wystąpił wyjątek: " + exe.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog(); //okno dialogowe do wyboru pliku do odczytu danych
                ofd.Filter = "Plik tekstowy|*.txt";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    StreamReader sr = new StreamReader(ofd.FileName); //otwarcie pliku do odczytu
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        if (line == "~FILM~")
                        {
                            Movie m = new Movie();
                            m.ReadFromFile(sr);
                            Form1.listR.Add(m);
                        }
                        else if (line == "~KONCERT~")
                        {
                            Concert r = new Concert();
                            r.ReadFromFile(sr);
                            Form1.listR.Add(r);
                        }
                    }
                    sr.Close();
                    //Form1.listR[0].WriteCon(listBox11, pictureBox11);
                }
            }

            catch(FormatException exe)
            {
                MessageBox.Show("Wystąpił wyjątek: " + exe.Message);
            }

            catch (Exception exe)
            {
                MessageBox.Show("Wystąpił wyjątek: " + exe.Message);
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                if (Form1.listR.Count > 0)
                {
                    Form1.listR.Remove(Form1.listR[currentIndex]);
                    currentIndex--;
                    //Obiekt.Items.Remove(Obiekt.Items[Obiekt.SelectedIndex]);
                }
                else if (Form1.listR.Count == 0)
                {
                    MessageBox.Show("Brak obiektów do usunięcia");
                }
                UpdateButtons();
            }

            catch(FormatException exe)
            {
                MessageBox.Show("Wystąpił następujący błąd" + exe.Message);
            }

            catch(Exception exe)
            {
                MessageBox.Show("Wystąpił następujący błąd" + exe.Message);
            }
        }

        private void Lista_Load(object sender, EventArgs e)
        {

        }

        private int Average_Length()
        {
            int suma = 0;
            for(int i=0; i < Form1.listR.Count; i++)
            {
                suma += Form1.listR[i].length;
            }
            return suma / Form1.listR.Count();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void DeleteObejct_MouseHover(object sender, System.EventArgs e)
        {
            MessageBox.Show("yourmessage");

        }

        private void DeleteObejct_MouseHover_1(object sender, EventArgs e)
        {
            toolTip1.Show("Usuwa aktualnie oglądany obiekt", DeleteObejct);
        }
    }
}
