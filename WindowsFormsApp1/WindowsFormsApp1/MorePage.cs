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
    public partial class MorePage : Form
    {

        bool drag = false;
        Point start_point = new Point(0, 0);

        public MorePage()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Welcome main_frm1 = new Welcome();
            main_frm1.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            AboutUs AB = new AboutUs();
            AB.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("This will redirect you to the application store/website to share the application information.", "Share This App", MessageBoxButtons.OK) == DialogResult.OK)
            {
                return;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("This will redirect you to the application rating.", "Rate This App", MessageBoxButtons.OK) == DialogResult.OK)
            {
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("This will redirect you to the application Feedback.", "Feedback", MessageBoxButtons.OK) == DialogResult.OK)
            {
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("This will redirect you to the application store/website to purchase\nthe Premium Version of this application.", "Purchase App", MessageBoxButtons.OK) == DialogResult.OK)
            {
                return;
            }
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
