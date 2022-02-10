using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappyBird
{
    public partial class Form1 : Form
    {
        int yerCekimi = 5;
        int hiz = 5;
        Random rnd = new Random();
        int gelenSecim, scoreArtis, score = 0, rekor = 0;
        string rekorKayit, sonRekor;




        public Form1(int secim)
        {
            InitializeComponent();
            try
            {
                sonRekor = File.ReadAllText("highestscore.txt");
            }
            catch (Exception)
            {

                File.WriteAllText("highestscore.txt", "0");
            }

            VerileriOku();
            rekor = Convert.ToInt32(sonRekor);
            rekorKayit = Convert.ToString(sonRekor);
            gelenSecim = secim;
            if (gelenSecim == 0)
            {
                tmrGame.Interval = 40;
                scoreArtis = 3;
            }
            else if (gelenSecim == 1)
            {
                tmrGame.Interval = 30;
                scoreArtis = 6;
            }
            else if (gelenSecim == 2)
            {
                tmrGame.Interval = 20;
                scoreArtis = 9;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space && tmrGame.Enabled)
            {
                if (pbBird.Top > 0)
                {
                    pbBird.Top -= yerCekimi * 10;
                    pbBird.Top = pbBird.Top < 0 ? 0 : pbBird.Top;   // ekrandan yukarı taşmaması için.

                }
            }

            if (e.KeyCode == Keys.P)
            {
                tmrGame.Stop();
            }

            if (e.KeyCode == Keys.Enter)
            {
                tmrGame.Start();
            }
        }
        private void tmrGame_Tick(object sender, EventArgs e)
        {
            pbBird.Top += yerCekimi;
            pbPipe1.Left -= hiz;
            pbPipe2.Left -= hiz;
            pbPipe3.Left -= hiz;
            pbPipe4.Left -= hiz;
            pbPipe5.Left -= hiz;
            pbPipe6.Left -= hiz;

            // Todo 'height' Random Ayarlanacak

            if (pbPipe1.Right <= 0)
            {

                pbPipe1.Left = ClientSize.Width;
                pbPipe1.Height = rnd.Next(100, 200);
                pbPipe1.Top = pbGround.Top - pbPipe1.Height;
                score += scoreArtis;
                lblScore.Text = "Score: " + score;
            }

            if (pbPipe2.Right <= 0)
            {
                pbPipe2.Left = ClientSize.Width;
                pbPipe2.Height = rnd.Next(100, 150);
            }

            if (pbPipe3.Right <= 0)
            {
                pbPipe3.Left = ClientSize.Width;
                pbPipe3.Height = rnd.Next(50, 100);
                pbPipe3.Top = pbGround.Top - pbPipe3.Height;
                score += scoreArtis;
                lblScore.Text = "Score: " + score;
            }

            if (pbPipe4.Right <= 0)
            {
                pbPipe4.Left = ClientSize.Width;
                pbPipe4.Height = rnd.Next(200, 250);

            }

            if (pbPipe5.Right <= 0)
            {
                pbPipe5.Left = ClientSize.Width;
                pbPipe5.Height = rnd.Next(100, 150);
                pbPipe5.Top = pbGround.Top - pbPipe5.Height;
                score += scoreArtis;
                lblScore.Text = "Score: " + score;
            }

            if (pbPipe6.Right <= 0)
            {
                pbPipe6.Left = ClientSize.Width;
                pbPipe6.Height = rnd.Next(150, 200);

            }



            if (pbPipe1.Bounds.IntersectsWith(pbBird.Bounds) || pbPipe2.Bounds.IntersectsWith(pbBird.Bounds) || pbPipe3.Bounds.IntersectsWith(pbBird.Bounds) || pbPipe4.Bounds.IntersectsWith(pbBird.Bounds) || pbPipe5.Bounds.IntersectsWith(pbBird.Bounds) || pbPipe6.Bounds.IntersectsWith(pbBird.Bounds) || pbGround.Bounds.IntersectsWith(pbBird.Bounds))   // 4 boru ve zemin için
            {



                tmrGame.Stop();
                DialogResult dr = MessageBox.Show("Game Over! Do you want to play a game?", "Flappy Bird", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    tmrGame.Start();
                    pbBird.Left = 50;
                    pbBird.Top = 150;
                    pbPipe1.Left = 300;
                    pbPipe2.Left = 300;
                    pbPipe3.Left = 510;
                    pbPipe4.Left = 510;
                    pbPipe5.Left = 720;
                    pbPipe6.Left = 720;

                    if (score >= rekor)
                    {
                        rekor = score;
                        lblRekor.Text = "Highest Score: " + rekor;
                        rekorKayit = Convert.ToString(rekor);
                    }

                    score = 0;
                    lblScore.Text = "Score: 0";

                }
                else
                {
                    if (score >= rekor)
                    {
                        rekor = score;
                        lblRekor.Text = "Highest Score: " + rekor;
                        rekorKayit = Convert.ToString(rekor);
                    }

                    VerileriKaydet();
                    Close();

                }
            }
            else
            {

            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            VerileriKaydet();
        }

        private void VerileriKaydet()
        {
            if (Convert.ToInt32(rekorKayit) >= Convert.ToInt32(sonRekor))
                File.WriteAllText("highestscore.txt", Convert.ToString(rekorKayit));
            else
                File.WriteAllText("highestscore.txt", Convert.ToString(sonRekor));
        }
        private void VerileriOku()
        {
            string rekorOku = File.ReadAllText("highestscore.txt");
            lblRekor.Text = "Highest Score: " + rekorOku;

        }
    }
}
