using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drawings
{
    class DesignElement
    {
        private float x, y, width, height;
        Pen pen;
        Graphics g;

        public Graphics G
        {
            get
            {
                return g;
            }

            set
            {
                g = value;
            }
        }

        public Pen Pen
        {
            get
            {
                return pen;
            }

            set
            {
                pen = value;
            }
        }

        public float X
        {
            get
            {
                return x;
            }

            set
            {
                x = value;
            }
        }

        public float Y
        {
            get
            {
                return y;
            }

            set
            {
                y = value;
            }
        }

        public float Width
        {
            get
            {
                return width;
            }

            set
            {
                width = value;
            }
        }

        public float Height
        {
            get
            {
                return height;
            }

            set
            {
                height = value;
            }
        }

        public DesignElement(float x, float y, float width, float height, Pen pen, Graphics g) {
            this.X = x;
            this.Y = y;
            this.Width = width;
            this.Height = height;
            this.Pen = pen;
            this.G = g;
        }

        void draw(){
        }
    }
}
