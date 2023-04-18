using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;

namespace L4_MarcinSkubiś
{
    class Concert: Record
    {
        string town;
        string facility;
        string artist;
        string distributor;
        public Concert() : base()
        {
            town = "";
            facility = "";
            artist = "";
            distributor = "";

        }
        public Concert(string PLname, string OriginalName, string country, string media, string category, int length, DateTime premiere
            , DateTime premierePL, bool blackAndWhite, double pricePerDay, Bitmap poster, string town, string facility, string artist, string distributor)
            : base(PLname, OriginalName, country, media, category, length, premiere, premierePL, blackAndWhite, pricePerDay, poster)
        {
            this.town = town;
            this.facility = facility;   
            this.artist = artist;
            this.distributor = distributor;
        }

        public Concert(Concert c): base(c)
        {
            this.town = c.town; 
            this.facility = c.facility;
            this.artist = c.artist;
            this.distributor = c.distributor;
        }

        

        public override void WriteCon(ListBox listBox3, PictureBox pictureBox2)
        {
            base.WriteCon(listBox3, pictureBox2);
            listBox3.Items.Add("Cena wypożyczenia za tydzień(po uzwględnieniu rabatu 30%): " + PricePerWeek() + "zł");
            listBox3.Items.Add("Miasto: "+town);
            listBox3.Items.Add("Obiekt: "+ facility);
            listBox3.Items.Add("Artysta/zespół: "+artist);
            listBox3.Items.Add("Dystrubutor: "+distributor);
            listBox3.Items.Add("Dni od premiery: "+Time());
        }

        public override void WriteToFile(StreamWriter sw)
        {
            sw.WriteLine("~KONCERT~");
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
            sw.WriteLine(town);
            sw.WriteLine(facility);
            sw.WriteLine(artist);
            sw.WriteLine(distributor);
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
            town = sr.ReadLine();
            facility = sr.ReadLine();
            artist = sr.ReadLine();
            distributor = sr.ReadLine();
            poster = LoadBmp(sr);

        }

        public int Time()
        {
            TimeSpan result = premierePL.Subtract(DateTime.Now);
            return result.Days;
        }

        public double PricePerWeek()
        {
            return pricePerDay * 7 * 0.7;
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
