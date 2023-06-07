using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovingShapes
{
    internal class Circle : Shape
    {

        public float Radius { get; set; }

        public Circle(float X, float Y, Color Color, float Radius) : base(new Point((int)X, (int)Y), Color)
        {
            this.Radius = Radius;
        }

        public override void Draw(Graphics g)
        {
            Brush brush = new SolidBrush(Color);
            g.FillEllipse(brush, point.X - Radius / 2, point.Y - Radius / 2, Radius, Radius);
            if (Selected == true)
            {
                Pen pen = new Pen(Color.Red, 4);
                g.DrawEllipse(pen, point.X - Radius / 2, point.Y - Radius / 2, Radius, Radius);
                pen.Dispose();
            }
            brush.Dispose();
        }
        

        public override bool isHit(float x, float y)
        {
            double distance = Math.Sqrt(((point.X-x) * (point.X-x)) + ((point.Y-y) * (point.Y-y)));
            return distance < Radius;
        }
    }
}
