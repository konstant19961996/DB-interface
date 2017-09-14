using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_interface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void аэропортыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form a = new Airports();
            a.Show();
            a.MdiParent = this;
        }

        private void списокСамолётовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form b = new Planes();
            b.Show();
            b.MdiParent = this;
        }

        private void типыСамолётовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form c = new Plane_Types();
            c.Show();
            c.MdiParent = this;
        }

        private void маршрутыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form d = new Routes();
            d.Show();
            d.MdiParent = this;

        }

        private void списокРейсовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new Flight_From_List();
            f.Show();
            f.MdiParent = this;
        }

        private void рейсыНаКонкретнуюДатуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form g = new Date_Flight();
            g.Show();
            g.MdiParent = this;
        }

        private void тОКонкретногоСамолётаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form h = new Plane_Service();
            h.Show();
            h.MdiParent = this;

        }

        private void плановыеТОДляМоделиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form i = new Plane_Service_Plan();
            i.Show();
            i.MdiParent = this;

        }

    }
}
