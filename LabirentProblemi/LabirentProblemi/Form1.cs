using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabirentProblemi
{
    public partial class FormLabirent : Form
    {
        Color anlikRenk = Color.White;
        private int xBoyut = 10;
        private int yBoyut = 10;
        private int boyutDeger = 30;
        private int xP = 0, yP = 0;
        public static int temp = 0, sag = 0, alt = 0, sayac = 100;

        

        private PictureBox[,] labirentBoyut;

        public FormLabirent()
        {
            InitializeComponent();
            yeniLabOlustur();
            labelHamle.Text = ("Hamle: " + temp);
            buttonUst.Visible = false;
            buttonSol.Visible = false;
            buttonSag.Visible = false;
            buttonAlt.Visible = false;
            labelZaman.Text = ("0");
            timerOyun.Interval = 100;
            progressBarZaman.Value = sayac;
            labelZaman.Text = sayac.ToString();
        }


        private void yeniLabOlustur()
        {

            labirentBoyut = new PictureBox[xBoyut, yBoyut];

            for (int i = 0; i < xBoyut; i++)
            {
                for (int j = 0; j < yBoyut; j++)
                {
                    labirentBoyut[i, j] = new PictureBox();

                    int xPosition = (i * boyutDeger) + 13;
                    int yPosition = (j * boyutDeger) + 45;
                    labirentBoyut[i, j].SetBounds(xPosition, yPosition, boyutDeger, boyutDeger);
                    
                    if ((i == 0 && j == 0) || (i == xBoyut - 1 && j == yBoyut - 1))
                        labirentBoyut[i, j].BackColor = Color.LightBlue;
                    else
                    {
                        labirentBoyut[i, j].BackColor = Color.White;
                        EventHandler clickEvent = new EventHandler(PictureBox_Click);
                        labirentBoyut[i, j].Click += clickEvent;
                    }

                    this.Controls.Add(labirentBoyut[i, j]);
                }
            }
        }

        private void pictureBoxYol_Click(object sender, EventArgs e)
        {
            anlikRenk = Color.White;
        }

        private void pictureBoxDuvar_Click(object sender, EventArgs e)
        {
            anlikRenk = Color.Black;
        }

        private void PictureBox_Click(object sender, EventArgs e)
        {
            ((PictureBox)sender).BackColor = anlikRenk;
        }

       

        private void buttonBilgisayar_Click(object sender, EventArgs e)
        {
            buttonTekOyuncu.Visible = false;

            bool[,] bakilmisYol = new bool[xBoyut, yBoyut];

            if (!labirentCoz(0, 0, bakilmisYol))
                MessageBox.Show("Labirent Çözülemez.");
        }

        private void buttonTekOyuncu_Click(object sender, EventArgs e)
        {
            buttonBilgisayar.Visible = false;
            buttonSag.Visible = true;
            buttonAlt.Visible = true;
            labirentBoyut[0, 0].BackColor = Color.Gray;
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            xP = 0; yP = 0; sag = 0; alt = 0;

            buttonBilgisayar.Visible = true;
            buttonTekOyuncu.Visible = true;
            buttonUst.Visible = false;
            buttonSol.Visible = false;
            buttonSag.Visible = false;
            buttonAlt.Visible = false;

            timerOyun.Stop();
            sayac = 100;
            progressBarZaman.Value = sayac;
            labelZaman.Text = sayac.ToString();

            temp = 0;
            labelHamle.Text = ("Hamle: " + temp);

            for (int i = 0; i < xBoyut; i++)
            {
                for (int j = 0; j < yBoyut; j++)
                {
                    if (labirentBoyut[i, j].BackColor == Color.Gray)
                        labirentBoyut[i, j].BackColor = Color.White;
                    if (labirentBoyut[i, j].BackColor == Color.Red)
                        labirentBoyut[i, j].BackColor = Color.White;
                }
            }

            labirentBoyut[0, 0].BackColor = Color.LightBlue;
            labirentBoyut[xBoyut - 1, yBoyut - 1].BackColor = Color.LightBlue;
        }

        private bool labirentCoz(int xPos, int yPos, bool[,] bakilmisYol)
        {
            bool dogruYol = false;

            bool yolDogruMu = true;

            if (xPos >= xBoyut || xPos < 0 || yPos >= yBoyut || yPos < 0)
                yolDogruMu = false;
            else
            {
                if (labirentBoyut[xPos, yPos].BackColor == Color.LightBlue && (xPos != 0 && yPos != 0))
                {
                    dogruYol = true;
                    yolDogruMu = false;
                }

                if (labirentBoyut[xPos, yPos].BackColor == Color.Black)
                    yolDogruMu = false;

                if (bakilmisYol[xPos, yPos])
                    yolDogruMu = false;
            }

            if (yolDogruMu)
            {

                bakilmisYol[xPos, yPos] = true;

                dogruYol = dogruYol || labirentCoz(xPos + 1, yPos, bakilmisYol);
                dogruYol = dogruYol || labirentCoz(xPos, yPos + 1, bakilmisYol);
                dogruYol = dogruYol || labirentCoz(xPos - 1, yPos, bakilmisYol);
                dogruYol = dogruYol || labirentCoz(xPos, yPos - 1, bakilmisYol);

                temp++;
            }

            if (dogruYol)
                labirentBoyut[xPos, yPos].BackColor = Color.Gray;
            labelHamle.Text = ("Hamle: " + temp);
            return dogruYol;
        }

       

        private void buttonUst_Click(object sender, EventArgs e)
        {
            --alt;
            Control(sag, alt);
            ++temp;
            labelHamle.Text = ("Hamle: " + temp);
            bool dogruYol = false;
            bool yolDogruMu = true;

            if (xP >= xBoyut || xP < 0 || yP >= yBoyut || yP < 0)
                yolDogruMu = false;
            else
            {
                if (labirentBoyut[xP, yP].BackColor == Color.LightBlue && (xP != 0 && yP != 0))
                {
                    dogruYol = true;
                    yolDogruMu = false;
                }

                if (yP != 0)
                {
                    if (labirentBoyut[xP, yP - 1].BackColor == Color.Black)
                        yolDogruMu = false;

                }
            }

            if (yolDogruMu)
            {

                yP = yP - 1;
                dogruYol = true;
                yolDogruMu = false;

            }

            if (dogruYol)
            {
                if (yP == yBoyut - 1)
                {

                }
                else
                {
                    labirentBoyut[xP, yP + 1].BackColor = Color.Gray;
                    labirentBoyut[xP, yP].BackColor = Color.Red;

                }
            }
        }

        private void buttonSol_Click(object sender, EventArgs e)
        {
            --sag;
            Control(sag, alt);
            ++temp;
            labelHamle.Text = ("Hamle: " + temp);
            bool dogruYol = false;
            bool yolDogruMu = true;

            if (xP >= xBoyut || xP < 0 || yP >= yBoyut || yP < 0)
                yolDogruMu = false;
            else
            {
                if (labirentBoyut[xP, yP].BackColor == Color.LightBlue && (xP != 0 && yP != 0))
                {
                    dogruYol = true;
                    yolDogruMu = false;
                }


                if (xP != 0)
                {
                    if (labirentBoyut[xP - 1, yP].BackColor == Color.Black)
                        yolDogruMu = false;

                }

            }

            if (yolDogruMu)
            {

                xP = xP - 1;
                dogruYol = true;
                yolDogruMu = false;

            }

            if (dogruYol)
            {
                if (xP == xBoyut - 1)
                {

                }
                else
                {
                    labirentBoyut[xP + 1, yP].BackColor = Color.Gray;
                    labirentBoyut[xP, yP].BackColor = Color.Red;
                }
            }
        }

        private void buttonSag_Click(object sender, EventArgs e)
        {
            ++sag;
            Control(sag, alt);
            ++temp;
            labelHamle.Text = ("Hamle: " + temp);
            bool dogruYol = false;
            bool yolDogruMu = true;

            if (xP >= xBoyut || xP < 0 || yP >= yBoyut || yP < 0)
                yolDogruMu = false;
            else
            {
                if (labirentBoyut[xP, yP].BackColor == Color.LightBlue && (xP != 0 && yP != 0))
                {
                    dogruYol = true;
                    yolDogruMu = false;
                }


                if (xP != xBoyut - 1)
                {
                    if (labirentBoyut[xP + 1, yP].BackColor == Color.Black)
                        yolDogruMu = false;

                }


            }

            if (yolDogruMu)
            {

                xP = xP + 1;
                dogruYol = true;
                yolDogruMu = false;

            }

            if (dogruYol)
            {
                if (xP == 0)
                {

                }
                else
                {
                    labirentBoyut[xP - 1, yP].BackColor = Color.Gray;
                    labirentBoyut[xP, yP].BackColor = Color.Red;
                }
            }
        }

        private void buttonAlt_Click(object sender, EventArgs e)
        {
            ++alt;
            Control(sag, alt);
            ++temp;
            labelHamle.Text = ("Hamle: " + temp);
            bool dogruYol = false;
            bool yolDogruMu = true;

            if (xP >= xBoyut || xP < 0 || yP >= yBoyut || yP < 0)
                yolDogruMu = false;
            else
            {
                if (labirentBoyut[xP, yP].BackColor == Color.LightBlue && (xP != 0 && yP != 0))
                {
                    dogruYol = true;
                    yolDogruMu = false;
                }


                if (yP != yBoyut - 1)
                {
                    if (labirentBoyut[xP, yP + 1].BackColor == Color.Black)
                        yolDogruMu = false;

                }


            }

            if (yolDogruMu)
            {

                yP = yP + 1;
                dogruYol = true;
                yolDogruMu = false;

            }

            if (dogruYol)
            {
                if (yP == 0)
                {

                }
                else
                {
                    labirentBoyut[xP, yP - 1].BackColor = Color.Gray;
                    labirentBoyut[xP, yP].BackColor = Color.Red;
                }
            }
        }

        private void timerOyun_Tick(object sender, EventArgs e)
        {
            progressBarZaman.Value = sayac;
            labelZaman.Text = sayac.ToString();
            if (sayac == 0)
            {
                timerOyun.Stop();
                MessageBox.Show("Oyun Bitti");
            }
            sayac--;
        }

        public void Control(int S, int A)
        {
            if (A == 0) { buttonUst.Visible = false; } else { buttonUst.Visible = true; }
            if (A == 9) { buttonAlt.Visible = false; } else { buttonAlt.Visible = true; }
            if (S == 0) { buttonSol.Visible = false; } else { buttonSol.Visible = true; }
            if (S == 9) { buttonSag.Visible = false; } else { buttonSag.Visible = true; }

            if (S == 1 || A == 1) { timerOyun.Start(); }
            if (S == 9 && A == 9)
            {
                timerOyun.Stop();
                MessageBox.Show("Oyun Bitti");
            }
        }

    }
}
