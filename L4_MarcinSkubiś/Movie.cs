using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using System.Drawing.Imaging;

namespace L4_MarcinSkubiś
{
    public class Movie: Record
    {
        int budget;
        string editing;
        string language;
        int wonAwardAmount;

        public Movie(): base()
        {
            budget = 0;
            editing = "";
            language = "";
            wonAwardAmount = 0;
        }

        public Movie(string PLname, string OriginalName, string country,string media,string category, int length,DateTime premiere
            ,DateTime premierePL,bool blackAndWhite, double pricePerDay,Bitmap poster, int budget, string editing, string language, int wonAwardAmount)
            : base(PLname, OriginalName, country,media,category,length,premiere, premierePL,blackAndWhite, pricePerDay, poster)
        {
            this.budget = budget;
            this.language = language;
            this.wonAwardAmount = wonAwardAmount;
            this.editing = editing;
        }

        public Movie(Movie m) : base(m)
        {
            this.budget = m.budget;
            this.language = m.language;
            this.wonAwardAmount = m.wonAwardAmount;
            this.editing=m.editing;
        }

        public override void WriteCon(ListBox listBox2,PictureBox pictureBox1)
        {
            base.WriteCon(listBox2, pictureBox1);
            listBox2.Items.Add("Cena wypożyczenia za tydzień(po uzwględnieniu rabatu 30%): " + PricePerWeek() + "zł");
            listBox2.Items.Add("Budżet: "+budget+"$");
            listBox2.Items.Add("Budżet w PLN: "+BudgetPLN()+"zł");
            listBox2.Items.Add("Montaż: "+editing);
            listBox2.Items.Add("Język: "+language);
            listBox2.Items.Add("Liczba wygranych nagród: "+wonAwardAmount);
            listBox2.Items.Add("Dni od premiery: "+Time());

        }
        public override void WriteToFile(StreamWriter sw)
        {
            sw.WriteLine("~FILM~");
            sw.WriteLine(id);
            sw.WriteLine(PLname);
            sw.WriteLine(OriginalName);
            sw.WriteLine(country);
            sw.WriteLine(media);
            sw.WriteLine(category);
            sw.WriteLine(length);
            sw.WriteLine(premiere);
            sw.WriteLine(premierePL);
            sw.WriteLine(blackAndWhite);
            sw.WriteLine(pricePerDay);
            sw.WriteLine(budget);
            sw.WriteLine(editing);
            sw.WriteLine(language);
            sw.WriteLine(wonAwardAmount);
            SaveBmp(sw);
        }
        public override void ReadFromFile(StreamReader sr)
        {
            id = Convert.ToInt32(sr.ReadLine());
            PLname = sr.ReadLine();
            OriginalName = sr.ReadLine();
            country = sr.ReadLine();
            media = sr.ReadLine();
            category = sr.ReadLine();
            length = Convert.ToInt32(sr.ReadLine());
            premiere = Convert.ToDateTime(sr.ReadLine());
            premierePL = Convert.ToDateTime(sr.ReadLine());
            blackAndWhite = Convert.ToBoolean(sr.ReadLine());
            pricePerDay = Convert.ToDouble(sr.ReadLine());
            budget = Convert.ToInt32(sr.ReadLine());
            editing = sr.ReadLine();
            language = sr.ReadLine();
            wonAwardAmount = Convert.ToInt32(sr.ReadLine());
            poster = LoadBmp(sr);

        }

        public int Time()
        {
            TimeSpan result = DateTime.Now.Subtract(premiere);
            return result.Days;
        }

        public double BudgetPLN()
        {
            return budget * 4.41;
        }

        public double PricePerWeek()
        {
            return pricePerDay*7*0.7;
        }

        public static string operator ==(Movie m1, Movie m2)
        {
            if (m1.country == m2.country)
            {
                return "Prawda";
            }
            else
            {
                return "Fałsz";
            }
        }

        public static string operator !=(Movie m1, Movie m2)
        {
            if (m1.country != m2.country)
            {
                return "Prawda";
            }
            else
            {
                return "Fałsz";
            }
        }

        public static string operator >(Movie m1, Movie m2)
        {
            if(m1.length > m2.length){
                return m1.OriginalName;
            }
            return m2.OriginalName;
        }

        public static string operator <(Movie m1, Movie m2)
        {
            if(m1.length > m2.length)
            {
                return m1.OriginalName;
            }
            return m2.OriginalName;
        }

        public static int operator +(Movie m1, Movie m2)
        {
            return m1.length+m2.length;
        }


        private void SaveBmp(StreamWriter sw)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                poster.Save(ms, ImageFormat.Bmp);
                byte[] bytes = ms.ToArray();
                sw.WriteLine(Convert.ToBase64String(bytes, 0, bytes.Length));
            }
        }

        private Bitmap LoadBmp(StreamReader sr)
        {
            byte[] bytes = Convert.FromBase64String(sr.ReadLine());
            using (MemoryStream ms = new MemoryStream(bytes))
                return new Bitmap(ms);
        }
    }
}
