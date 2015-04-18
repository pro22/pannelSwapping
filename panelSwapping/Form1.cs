using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace panelSwapping
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool panel1_Selected = false;
        bool panel2_Selected = false;
        bool panel3_Selected = false;
        bool panel4_Selected = false;

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            panel1_Selected = true;
        }
        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            panel2_Selected = true;
        }
        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            panel3_Selected = true;
        }
        private void panel4_MouseDown(object sender, MouseEventArgs e)
        {
            panel4_Selected = true;
        }



        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            panel1_Selected = false;
        }
        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            panel2_Selected = false;
        }
        private void panel3_MouseUp(object sender, MouseEventArgs e)
        {
            panel3_Selected = false;
        }
        private void panel4_MouseUp(object sender, MouseEventArgs e)
        {
            panel4_Selected = false;
        }



        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (panel1_Selected)
            {
                int x = (Cursor.Position.X - 50);
                int y = (Cursor.Position.Y - 50);
                panel1.Location = new Point(x, y);
            }
        }        
        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (panel2_Selected)
            {
                int x = (Cursor.Position.X - 50);
                int y = (Cursor.Position.Y - 50);
                panel2.Location = new Point(x, y);
            }
        }
        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            if (panel3_Selected)
            {
                int x = (Cursor.Position.X - 50);
                int y = (Cursor.Position.Y - 50);
                panel3.Location = new Point(x, y);
            }
        }
        private void panel4_MouseMove(object sender, MouseEventArgs e)
        {
            if (panel4_Selected)
            {
                int x = (Cursor.Position.X - 50);
                int y = (Cursor.Position.Y - 50);
                panel4.Location = new Point(x, y);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        
    }
}
