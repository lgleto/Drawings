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
        Pen pen;
        List<DesignElement> elements;
        int xStart, yStart;
        enum ElementType { Circle, Rectangle, Line };
        Boolean mouseDown = false;

        ElementType type;

        public Form1()
        {
            InitializeComponent();

            elements = new List<DesignElement>();
            g = panelDrawing.CreateGraphics();
            pen = new Pen(Color.Black);
           
        }

        private void panelDrawing_Paint(object sender, PaintEventArgs e)
        {
            /*
            for(int i=0; i<elements.Count; i++)
            {
                elements[i].draw();
            }
            */

            foreach (DesignElement element in elements)
            {
                element.draw();
            }

        }

        private void panelDrawing_MouseDown(object sender, MouseEventArgs e)
        {
            xStart = e.X;
            yStart = e.Y;

            mouseDown = true;
        }

        private void buttonElement_Click(object sender, EventArgs e)
        {
            switch (((Button)sender).Text)
            {
                case "Rect":
                    type = ElementType.Rectangle;
                    break;
                case "Circ":
                    type = ElementType.Circle;
                    break;
                case "Line":
                    type = ElementType.Line;
                    break;
            }
        }

        private void panelSelectColor(object sender, EventArgs e)
        {
            Panel panel = (Panel)sender;
            pen = new Pen(panel.BackColor);
            panelSelectedColor.BackColor = panel.BackColor;
        }

        private void panelDrawing_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                panelDrawing.Refresh();
                System.Console.WriteLine("mouse move {0} {1}", e.X, e.Y);
                DesignElement element;
                switch (type)
                {
                    case ElementType.Circle:
                        element=new CircleElement(xStart, yStart, e.X, e.Y, pen, g);
                        break;
                    case ElementType.Rectangle:
                        element = new RectangleElement(xStart, yStart, e.X, e.Y, pen, g);
                        break;
                    case ElementType.Line:
                        element = new LineElement(xStart, yStart, e.X, e.Y, pen, g);
                        break;
                    default:
                        element = new CircleElement(xStart, yStart, e.X, e.Y, pen, g);
                        break;
                }
                element.draw();
            }
        }

        private void panelDrawing_MouseUp(object sender, MouseEventArgs e)
        {

            mouseDown = false;
            switch (type)
            {
                case ElementType.Circle:
                    elements.Add(new CircleElement(xStart, yStart, e.X, e.Y, pen, g));
                    break;
                case ElementType.Rectangle:
                    elements.Add(new RectangleElement(xStart, yStart, e.X, e.Y, pen, g));
                    break;
                case ElementType.Line:
                    elements.Add(new LineElement(xStart, yStart, e.X, e.Y, pen, g));
                    break;
            }
            panelDrawing.Refresh();
        }
    }
}
