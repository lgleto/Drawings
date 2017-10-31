using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drawings
{
    public partial class Form1 : Form
    {
        Graphics g;

        public Form1()
        {
            InitializeComponent();
            g = panelDrawing.CreateGraphics();
        }

        private void panelDrawing_Paint(object sender, PaintEventArgs e)
        {

            Pen penRed = new Pen(Color.Red);
            g.DrawEllipse(penRed, 10, 10, 100, 100);
            g.DrawRectangle(penRed, 10, 20, 50, 50);

            DesignElement d = new DesignElement(10, 10, 100, 100, penRed, g);
            d.

        }
    }
}
