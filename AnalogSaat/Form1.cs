using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnalogSaat
{
    public partial class Form1 : Form
    {
        Bitmap akrepResim,yelkovanResim,saniyeResim,miliResim;
        int saat, dakika, saniye, mili;
        DateTime zaman;


        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            //parent
            pictureBoxAkrep.Parent = pictureBoxSaat;
            pictureBoxYelkovan.Parent = pictureBoxAkrep;
            pictureBoxSaniye.Parent = pictureBoxYelkovan;
            pictureBoxMili.Parent = pictureBoxSaniye;

            //location
            pictureBoxAkrep.Location = new Point(0, 0);
            pictureBoxYelkovan.Location = new Point(0, 0);
            pictureBoxSaniye.Location = new Point(0, 0);
            pictureBoxMili.Location = new Point(0, 0);

            //Images
            akrepResim = new Bitmap(AnalogSaat.Properties.Resources.akrep);
            yelkovanResim = new Bitmap(AnalogSaat.Properties.Resources.yelkovan);
            saniyeResim = new Bitmap(AnalogSaat.Properties.Resources.saniye);
            miliResim = new Bitmap(AnalogSaat.Properties.Resources.mili);
        }

        private void buttonDakika_Click(object sender, EventArgs e)
        {
            dakika = Convert.ToInt32(textBoxDakika.Text);
            labelDakika.Text = dakika.ToString();
        }

        private void buttonSaat_Click(object sender, EventArgs e)
        {
            saat = Convert.ToInt32(textBoxSaat.Text);
            labelSaat.Text = saat.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timerSaat.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timerSaat.Stop();
        }

        private void timerSaat_Tick(object sender, EventArgs e)
        {
            zaman = DateTime.Now;
            saat = Convert.ToInt32(textBoxSaat.Text);
            dakika = Convert.ToInt32(textBoxDakika.Text);
            saniye = zaman.Second;
            mili = zaman.Millisecond;

            Single miliAci = mili * (float)(360) / (float)(1000);
            Single saniyeAci = saniye * 6 + miliAci / 1000;
            Single dakikaAci = dakika * 6 + saniyeAci / 60;
            Single saatAci = saat * 30 + dakikaAci / 12;

            pictureBoxAkrep.Image = resimCevir(akrepResim, saatAci);
            pictureBoxYelkovan.Image = resimCevir(yelkovanResim, dakikaAci);
            pictureBoxSaniye.Image = resimCevir(saniyeResim, saniyeAci);
            pictureBoxMili.Image = resimCevir(miliResim, miliAci);
        }

        private Bitmap resimCevir(Bitmap eskiResim, float aci)
        {
            Bitmap yeniResim = new Bitmap(eskiResim.Width, eskiResim.Height);
            using(Graphics g = Graphics.FromImage(yeniResim))
            {
                g.TranslateTransform(eskiResim.Width / 2, eskiResim.Height / 2);
                g.RotateTransform(aci);
                g.TranslateTransform(-eskiResim.Width/2, -eskiResim.Height/2);
                g.DrawImage(eskiResim, new Point(0,0));
            }
            return yeniResim;
        }

    }
}
