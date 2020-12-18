using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Medyaplayerkullanimi
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        Random rastgele = new Random();
        int gspuan = 0;
        int fbpuan = 0;
        int tspuan = 0; 
        int bjkpuan = 0;

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            int a = rastgele.Next(0, 11);
            int b = rastgele.Next(0, 11);
            int c = rastgele.Next(0, 11);
            int d = rastgele.Next(0, 11);
            label4.Text = a.ToString();
            label5.Text = b.ToString();
            label6.Text = c.ToString();
            label7.Text = d.ToString();
            if (a > b)
            {
                gspuan = gspuan + 3;
                labelgspuan.Text = gspuan.ToString();
            }
            else if (b>a)
            {
                fbpuan = fbpuan + 3;
                labelfbpuan.Text = fbpuan.ToString();
            }
            else
            {
                fbpuan = fbpuan + 1;
                gspuan = gspuan + 1;
                labelgspuan.Text = gspuan.ToString();
                labelfbpuan.Text = fbpuan.ToString();
            }

            if (c > d)
            {
                tspuan = tspuan + 3;
                labeltspuan.Text = tspuan.ToString();
            }
            else if (d > c)
            {
                bjkpuan = bjkpuan + 3;
                labelbjkpuan.Text = bjkpuan.ToString();
            }
            else
            {
                tspuan = tspuan + 1;
                bjkpuan = bjkpuan + 1;
                labeltspuan.Text = tspuan.ToString();
                labelbjkpuan.Text = bjkpuan.ToString();
            }

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Visible = false;
            int a = rastgele.Next(0, 11);
            int b = rastgele.Next(0, 11);
            int c = rastgele.Next(0, 11);
            int d = rastgele.Next(0, 11);

            label21.Text = a.ToString();
            label18.Text = b.ToString();
            label12.Text = d.ToString();
            label11.Text = c.ToString();
            if (a > b)
            {
                gspuan = gspuan + 3;
                labelgspuan.Text = gspuan.ToString();
            }
            else if (b > a)
            {
                bjkpuan = bjkpuan + 3;
                labelbjkpuan.Text = bjkpuan.ToString();
            }
            else
            {
                bjkpuan = bjkpuan + 1;
                gspuan = gspuan + 1;
                labelgspuan.Text = gspuan.ToString();
                labelbjkpuan.Text = bjkpuan.ToString();
            }

            if (c > d)
            {
                tspuan = tspuan + 3;
                labeltspuan.Text = tspuan.ToString();
            }
            else if (d > c)
            {
                fbpuan = fbpuan + 3;
                labelfbpuan.Text = fbpuan.ToString();
            }
            else
            {
                tspuan = tspuan + 1;
                fbpuan = fbpuan + 1;
                labeltspuan.Text = tspuan.ToString();
                labelfbpuan.Text = fbpuan.ToString();
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Visible = false;
            button4.Visible = true;
            int a = rastgele.Next(0, 11);
            int b = rastgele.Next(0, 11);
            int c = rastgele.Next(0, 11);
            int d = rastgele.Next(0, 11);

            label31.Text = a.ToString();
            label30.Text = b.ToString();
            label26.Text = d.ToString();
            label25.Text = c.ToString();
            if (a > b)
            {
                gspuan = gspuan + 3;
                labelgspuan.Text = gspuan.ToString();
            }
            else if (b > a)
            {
                tspuan = tspuan + 3;
                labeltspuan.Text = tspuan.ToString();
            }
            else
            {
                tspuan = tspuan + 1;
                gspuan = gspuan + 1;
                labelgspuan.Text = gspuan.ToString();
                labeltspuan.Text = tspuan.ToString();
            }

            if (c > d)
            {
                bjkpuan = bjkpuan + 3;
                labelbjkpuan.Text = bjkpuan.ToString();
            }
            else if (d > c)
            {
                fbpuan = fbpuan + 3;
                labelfbpuan.Text = fbpuan.ToString();
            }
            else
            {
                bjkpuan = bjkpuan + 1;
                fbpuan = fbpuan + 1;
                labelbjkpuan.Text = bjkpuan.ToString();
                labelfbpuan.Text = fbpuan.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(labelgspuan.Text) > Convert.ToInt32(labelfbpuan.Text)&& Convert.ToInt32(labelgspuan.Text) > Convert.ToInt32(labeltspuan.Text)&& Convert.ToInt32(labelgspuan.Text) > Convert.ToInt32(labelbjkpuan.Text))
            {
                Sampiyonluk.Visible = true;
                Sampiyonluk.Text = "Sampiyonluk Galatasaray";
                axWindowsMediaPlayer1.URL = "C:\\Oyun\\Futbol Oyunu\\bin\\muzik\\gs.mp3"; 
                pictureBox1.ImageLocation = "C:\\Oyun\\Futbol Oyunu\\bin\\resim\\gs.jpg";
            }
            else if (Convert.ToInt32(labeltspuan.Text) > Convert.ToInt32(labelfbpuan.Text) && Convert.ToInt32(labeltspuan.Text) > Convert.ToInt32(labelgspuan.Text) && Convert.ToInt32(labeltspuan.Text) > Convert.ToInt32(labelbjkpuan.Text))
            {
                Sampiyonluk.Visible = true;
                Sampiyonluk.Text = "Sampiyonluk Trabzonspor";
                axWindowsMediaPlayer1.URL = "C:\\Oyun\\Futbol Oyunu\\bin\\muzik\\ts.mp3";
                pictureBox1.ImageLocation = "C:\\Oyun\\Futbol Oyunu\\bin\\resim\\ts.jpg";
            }
            else if (Convert.ToInt32(labelbjkpuan.Text) > Convert.ToInt32(labelfbpuan.Text) && Convert.ToInt32(labelbjkpuan.Text) > Convert.ToInt32(labelgspuan.Text) && Convert.ToInt32(labelbjkpuan.Text) > Convert.ToInt32(labeltspuan.Text))
            {
                Sampiyonluk.Visible = true;
                Sampiyonluk.Text = "Sampiyonluk Besiktas";
                axWindowsMediaPlayer1.URL = "C:\\Oyun\\Futbol Oyunu\\bin\\muzik\\bjk.mp3";
                pictureBox1.ImageLocation = "C:\\Oyun\\Futbol Oyunu\\bin\\resim\\bjk.jpg";
            }
            else if(Convert.ToInt32(labelfbpuan.Text) > Convert.ToInt32(labelbjkpuan.Text) && Convert.ToInt32(labelfbpuan.Text) > Convert.ToInt32(labelgspuan.Text) && Convert.ToInt32(labelfbpuan.Text) > Convert.ToInt32(labeltspuan.Text))
            {
                Sampiyonluk.Visible = true;
                Sampiyonluk.Text = "Sampiyonluk Fenerbahce";
                axWindowsMediaPlayer1.URL = "C:\\Oyun\\Futbol Oyunu\\bin\\muzik\\fb.mp3";
                pictureBox1.ImageLocation = "C:\\Oyun\\Futbol Oyunu\\bin\\resim\\fb.jpg";
            }
        }
    }
}
