using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Stoperica stoperica = new Stoperica();
        Timer timer = new Timer();

        private void startbtn_Click(object sender, EventArgs e)
        {
            timer.Interval = 1000;
            timer.Start();
            timer.Tick += Timer_Tick;
            stoperica.KlikStart = DateTimeOffset.Now;
            startlbl.Visible = true;
            startlbl.Text +=stoperica.KlikStart.ToString();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            vrijemelbl.Text ="Vrijeme: " + stoperica.ProtekloVrijeme.ToString() + "s";
            stoperica.ProtekloVrijeme += 1;
            stoperica.RazlikaVremena += 1;
        }

        private void stopbtn_Click(object sender, EventArgs e)
        {
            timer.Stop();
            stoperica.KlikStop = DateTimeOffset.Now;
            stoplbl.Visible = true;
            stoplbl.Text += stoperica.KlikStop.ToString() + "\n";
        }

        private void lapbtn_Click(object sender, EventArgs e)
        {
            stoperica.KlikLap = DateTimeOffset.Now;
            label3.Visible = true;
            label3.Text += stoperica.KlikLap.ToString() + "\n";
            laplbl.Visible = true;
            laplbl.Text ="Lap: " + stoperica.RazlikaVremena.ToString();
            stoperica.RazlikaVremena = 0;
        }
    }
}
