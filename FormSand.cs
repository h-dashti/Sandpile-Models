using System;
using System.Drawing;
using System.Windows.Forms;

namespace SandPile
{
    public partial class FormSand : Form
    {
       
        #region Fields
        Sand sand;
        Bitmap mapSandPile;
        int sandSize;
        Color[] colorArray = { Color.Yellow, Color.Orange, Color.Chocolate, Color.Brown };
        int snapshots = 0;

        #endregion


        #region Methods

        Color FindColor(int value, int scale)
        {
            if (value > scale)
                return Color.Black;
            else if (value == 0)
                return Color.White;
            else if (value < 0)
                return Color.Blue;

            return colorArray[(value-1) * colorArray.Length / scale];
        }

        void SetBitMap()
        {
            if (sandSize == 1)
            {
                for (int i = 0; i < sand.Lx; i++)
                    for (int j = 0; j < sand.Ly; j++)
                        mapSandPile.SetPixel(i, j, FindColor(sand.h[i, j], sand.scale));
            }
            else
            {
                Graphics g = Graphics.FromImage(mapSandPile);
                for (int i = 0; i < sand.Lx; i++)
                    for (int j = 0; j < sand.Ly; j++)
                        g.FillRectangle(new SolidBrush(FindColor(sand.h[i, j], sand.scale)), i * sandSize, j * sandSize, sandSize, sandSize);
                g.Dispose();
            }
        }
        void Reset()
        {
            if (timer1 != null && timer1.Enabled) timer1.Stop();
            buttonAvalanche.Text = "Avalanche";

            int Lx, Ly, e, m;
            try
            {
                Lx = int.Parse(textBox_Lx.Text);
                Ly = int.Parse(textBox_Ly.Text);
                e = int.Parse(textBox_e.Text);
                m = int.Parse(textBox_m.Text);
            }
            catch (FormatException fe)
            {
                return;
            }

           
            if (Lx <= 64) sandSize = 6;
            else if (Lx <= 100) sandSize = 4;
            else if (Lx <= 200) sandSize = 2;
            else if (Lx <= 300) sandSize = 1;
            else sandSize = 1;

            EpsionDis epsilonDis;
            if (radioButtonDirectal.Checked) epsilonDis = EpsionDis.Directed;
            else if (radioButtonEliptic.Checked) epsilonDis = EpsionDis.Elliptical;
            else epsilonDis = EpsionDis.Random;

           mapSandPile = new Bitmap(Lx * sandSize, Ly * sandSize);
            pictureBox1.Size = mapSandPile.Size;
            groupBoxStructure.Left = pictureBox1.Right + 10;

            sand = new Sand(Lx, Ly, e, m, epsilonDis);
            SetBitMap();

            labelEpsilonMethod.Text = sand.epsilonDis.ToString();
            
            ShowLables();

            pictureBox1.Invalidate();
        }

        int CalculateTimerInterval()
        {
            int maxInterval = 1000, minInterval = 10,
                min = trackBar_Latency.Minimum, max = trackBar_Latency.Maximum, value = trackBar_Latency.Value;

            return ((minInterval - maxInterval) * (value - min)) / (max - min) + maxInterval;
        }

        void ShowLables()
        {
            labelNumTopple.Text = sand.numFalledGrains.ToString();
        }

        void Init()
        {
            textBox_Lx.Text = "64";
            textBox_Ly.Text = "64";
            textBox_m.Text = "0";
            textBox_e.Text = "0";
        }

        #endregion


        public FormSand()
        {
            InitializeComponent();
            Init();
            Reset();
        }

       

        private void timer1_Tick(object sender, EventArgs e)
        {
            int step = (int)numericUpDownIt.Value;
            for (int n = 0; n < step; n++ )
                if (sand.isCompleteAvalanche)
                    sand.AddOneGrain();
                else
                    sand.PropagateOneWave();

            SetBitMap();
            ShowLables();

            pictureBox1.Invalidate();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            Reset();
            
        }


        private void trackBar_Latency_Scroll(object sender, EventArgs e)
        {
            timer1.Interval = CalculateTimerInterval();
        }

        private void FormSand_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (timer1 != null && timer1.Enabled)
                timer1.Stop();
        }

        private void buttonAvalanche_Click(object sender, EventArgs e)
        {
            if (buttonAvalanche.Text == "Avalanche")
            {
                timer1.Start();
                buttonAvalanche.Text = "Pause";
            }
            else
            {
                timer1.Stop();
                buttonAvalanche.Text = "Avalanche";
            }

        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawImage(mapSandPile, 0, 0);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string text = "Designed by Hor Dashti (h.dashti2@gmail.com)";
            MessageBox.Show(text);
        }

        private void buttonSnapshot_Click(object sender, EventArgs e)
        {
            string namefile = snapshots.ToString() + ".jpeg";
            mapSandPile.Save(namefile);
            snapshots++;
        }

       
    }
}