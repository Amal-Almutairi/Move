using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Right_Click(object sender, EventArgs e)
        {
            Point p = new Point(label.Location.X + 3, label.Location.Y);
            label.Location = p;
        }

        private void Left_Click(object sender, EventArgs e)
        {
            Point p = new Point(label.Location.X -3, label.Location.Y);
            label.Location = p;
            
        }

        private void Up_Click(object sender, EventArgs e)
        {
            Point p = new Point(label.Location.X,label.Location.Y-3);
            label.Location = p;
        }

        private void down_Click(object sender, EventArgs e)
        {
            Point p = new Point(label.Location.X, label.Location.Y+3);
            label.Location = p;
        }

        private void label_Click(object sender, EventArgs e)
        {

        }
    }
}
