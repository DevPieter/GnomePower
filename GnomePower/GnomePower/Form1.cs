using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace GnomePower
{
    public partial class gnome : Form
    {
        public gnome()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Click on the link below to continue learning how to build a desktop app using WinForms!
            System.Diagnostics.Process.Start("http://aka.ms/dotnet-get-started-desktop");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thanks!");
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void gnome_Load(object sender, EventArgs e)
        {
            MessageBox.Show("WIL JE DOORGAAN?");
            MessageBox.Show("(zet je geluid wat zachter!)");
            MessageBox.Show("WIL JE ECHT DOORGAAN?");
            MessageBox.Show("OK DAN!");
            MessageBox.Show("KLIK OM TE BEGINNEN!");

            play.URL = "GnomePower.mp4";

            play.Ctlcontrols.play();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("OK DAN!"); 

            play.URL = "GnomeCity.mp4";

            play.Ctlcontrols.play();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("OK DAN!"); 

            play.URL = "roomie.mp4";

            play.Ctlcontrols.play();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("OK DAN!");

            play.URL = "google.mp4";

            play.Ctlcontrols.play();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (play.URL.Length > 0)
            {
                play.fullScreen = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("OK DAN!");

            play.URL = "GnomePower.mp4";

            play.Ctlcontrols.play(); 
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("OK DAN!");

            play.URL = "gnomed.mp4";

            play.Ctlcontrols.play();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("OK DAN!");

            play.URL = "NyanCat.mp4";

            play.Ctlcontrols.play();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("OK DAN!");

            play.URL = "russian.mp4";

            play.Ctlcontrols.play();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("OK DAN!");

            play.URL = "CatTranscendence.mp4";

            play.Ctlcontrols.play();
        }
    }
}
