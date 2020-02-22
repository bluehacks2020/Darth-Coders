using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class AboutUs : Form
    {

        bool drag = false;
        Point start_point = new Point(0, 0);

        public AboutUs()
        {
            InitializeComponent();
            InfoDes.Text = "TransLek is a computer-based application that\ntranslates the Philippine words into all the available\ndialects and other languages that are spread out\nthrough our country. This application caters and\nopens the opportunity of the Filipino people to learn\nand appreciate the profound and rich culture of our\nlanguages and dialects that the people are using\nacross our country.";
            Dev.Text = "Developers:\n\nTeam Darth Coders\n\nFrancisco, Isiah\nMaico, Bryan\nMenchate, Arvi\nSee, Jan Wilbert";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            MorePage main_frm1 = new MorePage();
            main_frm1.Show();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            start_point = new Point(e.X, e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - start_point.X, p.Y - start_point.Y);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }
    }
}
