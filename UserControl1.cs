using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ControlCuGraphicsImagine
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }
        Graphics g;
        int ismd = 0;
        private void UserControl1_Load(object sender, EventArgs e)
        {
            g = CreateGraphics();

        }

        private void UserControl1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void UserControl1_ControlAdded(object sender, ControlEventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            g.DrawEllipse(new Pen(Color.Red,2), 5, 5, Width-15, Height-15);
        }

        private void UserControl1_MouseDown(object sender, MouseEventArgs e)
        {
            ismd = 1;
            this.BringToFront();
        }

        private void UserControl1_MouseUp(object sender, MouseEventArgs e)
        {
            ismd = 0;
        }

        private void UserControl1_MouseMove(object sender, MouseEventArgs e)
        {
            
            if (ismd == 1)
            {
                Left += e.X;
                Top += e.Y;
            }
        }
    }
}
