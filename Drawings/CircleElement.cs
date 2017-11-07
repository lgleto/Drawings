﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drawings
{
    class CircleElement : DesignElement
    {
        public CircleElement(float x, float y, float width, float height, Pen pen, Graphics g) :
            base(x, y, width, height, pen, g)
        {
            base.X = x;
            base.Y = y;
            base.Width = width;
            base.Height = height;
            base.Pen = pen;
            base.G = g;

        }

        public override void draw()
        {
            G.DrawEllipse(Pen,X,Y,Width-X,Height-Y);
        }
    }
}