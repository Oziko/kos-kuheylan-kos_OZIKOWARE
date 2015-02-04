using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _150203_Win_AtYarisi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rnd = new Random();

        private void timer1_Tick(object sender, EventArgs e)
        {
            BOZOK.Left += rnd.Next(1, 9);
            TOMPAK.Left += rnd.Next(1, 9);
            SAYPAK.Left += rnd.Next(1, 9);
            KOŞKUN.Left += rnd.Next(1, 9);
            SÖĞÜŞ.Left += rnd.Next(1, 9);

            AtKontrol(BOZOK);
            AtKontrol(TOMPAK);
            AtKontrol(SAYPAK);
            AtKontrol(KOŞKUN);
            AtKontrol(SÖĞÜŞ);
        }

        void AtKontrol(PictureBox at)
        {
            if(at.Right >= label1.Left)
            {
                timer1.Stop();
                YarisBitti(false, at);
                MessageBox.Show("KAZANAN AT: " + at.Name);
            }
        }

        void YarisBitti(bool durum, PictureBox kazanan)
        {
            button2.Visible = true;
            sesci.Stop();

            BOZOK.Enabled = TOMPAK.Enabled = SAYPAK.Enabled = KOŞKUN.Enabled = SÖĞÜŞ.Enabled = durum;

            kazanan.Enabled = true;
        }
        SoundPlayer sesci = new SoundPlayer();
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            sesci.SoundLocation = "AE.wav";
                sesci.PlayLooping();
            BOZOK.Enabled = TOMPAK.Enabled = SAYPAK.Enabled = KOŞKUN.Enabled = SÖĞÜŞ.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
