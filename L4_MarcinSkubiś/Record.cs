using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;
using System.Drawing;
using System.IO;


namespace L4_MarcinSkubiś
{


    public abstract class Record: IComparable <Record>
    {
        public int id;
        public string PLname;
        public string OriginalName;
        public string country;
        public string media;
        public string category;
        public int length;
        public DateTime premiere;
        public DateTime premierePL;
        public bool blackAndWhite;
        public double pricePerDay;
        public static int RecordNumber = 0;
        public Bitmap poster;

        public int CompareTo(Record record)
        {


            if (record == null)
                return 1;

            if (String.Compare(this.OriginalName, record.OriginalName) == 1)
                return 1;
            else if (String.Compare(this.OriginalName, record.OriginalName) == -1)
                return -1;
            else
            {

                if (this.length > record.length)
                    return 1;
                else if (this.length < record.length)
                    return -1;
                else
                {
                    if (this.premierePL > record.premierePL)
                        return 1;
                    else if (this.premierePL < record.premierePL)
                        return -1;
                    return 0;
                }
            }

        }

        public void WriteS(ListBox lb)
        {
            lb.Items.Add(OriginalName + " " + length + ", " + premierePL.ToString("yyyy’-‘MM’-‘dd’"));
        }

        public Record()
        {
            RecordNumber += 1;
            this.id = RecordNumber;
            this.PLname = "-";
            this.OriginalName = "-";
            this.country = "-";
            this.media= "-";
            this.category= "-";
            this.length = 0;
            this.premiere = DateTime.MinValue;
            this.premierePL = DateTime.MinValue;
            this.blackAndWhite = false;
            this.pricePerDay = 0;
            this.poster = null;
        }

        

        public Record(string PLname,string OriginalName,string country,string media,string category, int length, DateTime premiere,DateTime premierePL,bool blackAndWhite,double pricePerDay, Bitmap poster)
        {
            RecordNumber += 1;
            this.id = RecordNumber;
            this.PLname = PLname;
            this.OriginalName = OriginalName;
            this.country = country;
            this.media = media;
            this.category = category;
            this.length = length;
            this.premiere = premiere;
            this.premierePL = premierePL;
            this.blackAndWhite = blackAndWhite;
            this.pricePerDay = pricePerDay;
            this.poster = poster;
        }

        public Record(Record o)
        {
            RecordNumber += 1;
            this.id = RecordNumber;
            this.PLname = o.PLname;
            this.OriginalName = o.OriginalName;
            this.country = o.country;
            this.media = o.media;
            this.category = o.category;
            this.length = o.length;
            this.premiere = o.premiere;
            this.premierePL = o.premierePL;
            this.blackAndWhite = o.blackAndWhite;
            this.pricePerDay = o.pricePerDay;
            this.poster=o.poster;
        }
        public virtual void WriteCon(ListBox listBox3, PictureBox pictureBox2)
        {
            
            pictureBox2.Image = poster;
            listBox3.Items.Add("id: " + id);
            listBox3.Items.Add("Nazwa polska: " + PLname);
            listBox3.Items.Add("Nazwa oryginalna: " + OriginalName);
            listBox3.Items.Add("Kraj pochodzenia: " + country);
            listBox3.Items.Add("Nośnik: " + media);
            listBox3.Items.Add("Gatunek: " + category);
            listBox3.Items.Add("Długość: " + lengthHour());
            listBox3.Items.Add("Data premiery oryginalna: " + premiere);
            listBox3.Items.Add("Data premiery w polsce: " + premierePL);
            listBox3.Items.Add("Czy nagranie jest czarnobiałe: " + bnw());
            listBox3.Items.Add("Cena wypożyczenia za dzień: " + pricePerDay + "zł");


        }
        public virtual void WriteToFile(StreamWriter sw)
        {
        }

        public virtual void ReadFromFile(StreamReader sr)
        {
        }
        /*public virtual void WriteMov(ListBox listBox1, PictureBox pictureBox1)
        {
            listBox1.Items.Add("id: " + id);
            listBox1.Items.Add("Nazwa polska: " + PLname);
            listBox1.Items.Add("Nazwa oryginalna: " + OriginalName);
            listBox1.Items.Add("Kraj pochodzenia: " + country);
            listBox1.Items.Add("Nośnik: " + media);
            listBox1.Items.Add("Gatunek: " + category);
            listBox1.Items.Add("Długość: " + lengthHour());
            listBox1.Items.Add("Data premiery oryginalna: " + premiere);
            listBox1.Items.Add("Data premiery w polsce: " + premierePL);
            listBox1.Items.Add("Czy nagranie jest czarnobiałe: " + bnw());
            listBox1.Items.Add("Cena wypożyczenia za dzień: " + pricePerDay + "zł");
            pictureBox1.Image = poster;
        }

        public void WriteL(ListBox listBox11, PictureBox pictureBox11)
        {
            listBox11.Items.Add("id: " + id);
            listBox11.Items.Add("Nazwa polska: " + PLname);
            listBox11.Items.Add("Nazwa oryginalna: " + OriginalName);
            listBox11.Items.Add("Kraj pochodzenia: " + country);
            listBox11.Items.Add("Nośnik: " + media);
            listBox11.Items.Add("Gatunek: " + category);
            listBox11.Items.Add("Długość: " + lengthHour());
            listBox11.Items.Add("Data premiery oryginalna: " + premiere);
            listBox11.Items.Add("Data premiery w polsce: " + premierePL);
            listBox11.Items.Add("Czy nagranie jest czarnobiałe: " + bnw());
            listBox11.Items.Add("Cena wypożyczenia za dzień: " + pricePerDay + "zł");
            pictureBox11.Image = poster;
        }*/

        private string lengthHour()//zamiana minut na godziny
        {
            int hours = (length - length % 60) / 60;
            int minutes = (length - hours * 60);
            string result = Convert.ToString(hours) +"h"+" "+Convert.ToString(minutes)+"min";
            return result;
        }

        private string bnw()
        {
            if (blackAndWhite == true)
            {
                return "tak";
            }
            return "nie";
        }

        /*private string Date()
        {
            string date = month + "." + year;
            return date;
        }*/

        ~Record()
        {
            MessageBox.Show("Likwidacja obiektu klasy Record.");
        }
    }



    
}
