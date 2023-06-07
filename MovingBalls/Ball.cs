using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovingBalls
{
    public class Ball
    {
        public Point Location { get; set; }
        public static int Radius { get; set; } = 27;
        // 0 - Red; 1 - Green; 2 - Blue; -1 - Invalid (Delete)
        public Color Color { get; set; }

        public Ball(Point Location, Color Color)
        {
            this.Location = Location;
            this.Color = Color;
        }

        public void Draw(Graphics g)
        {
            Brush brush = new SolidBrush(Color);
            g.FillEllipse(brush, Location.X - Radius, Location.Y - Radius, Radius * 2, Radius * 2);
            brush.Dispose();
        }

        public bool isHit(Point mousePoint)
        {
            double distance = Math.Sqrt(Math.Pow((mousePoint.X - Location.X), 2) + Math.Pow((mousePoint.Y - Location.Y), 2));
            return distance <= Radius;
        }

        public void Move()
        {
            this.Location = new Point(Location.X + 10, Location.Y);
        }

    }
}
