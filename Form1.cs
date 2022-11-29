using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace TareaFinalSimulacionDigital
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void hueco7_Click(object sender, EventArgs e)
        {

        }

        private void eventoTimer(object sender, ElapsedEventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            moveImage(Dron.Left, Dron.Top);
        }

        private void moveImage(int x, int y)
        {
            if (x < this.Width - Dron.Width)
            {
                Dron.Left = x + 20;
            }
            else if (y < this.Height - Dron.Height)
            {
                Dron.Top = y + 20;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            System.Timers.Timer miTimer = new System.Timers.Timer();
            miTimer.Elapsed += new ElapsedEventHandler(eventoTimer);
            miTimer.Interval = 200;
            miTimer.Enabled = true;
            GC.KeepAlive(miTimer);
        }
    }
}
