using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplikacijaIgraSoTopcinja
{
    [Serializable]
    public class Ball
    {
        public Point Center { get; set; }
        public int Radius { get; set; } = 15;
        public string Direction { get; set; }
        public Color Color { get; set; }
        public int RedBallSpeed { get; set; }

        public Ball(Point point, Color color, int radius, int BallSpeed)
        {
            Center = point;
            Direction = "";
            Color = color;
            Radius = radius;
            RedBallSpeed = BallSpeed;
        }

        public void Draw(Graphics g)
        {
            Brush b = new SolidBrush(Color);

            g.FillEllipse(b, Center.X -Radius, Center.Y - Radius, Radius * 2, Radius * 2);

            b.Dispose();
        }
        public bool isHit(Point mousePoint)
        {
            double distance = Math.Sqrt(Math.Pow((mousePoint.X - Center.X), 2) + Math.Pow((mousePoint.Y - Center.Y), 2));
            return distance <= Radius;
        }

        public void Move()
        {
            if(Color != Color.Black && RedBallSpeed != 0)
            {
                if (Direction == "Up")
                {
                    this.Center = new Point(Center.X, Center.Y + RedBallSpeed);
                }
                else if(Direction == "Down")
                {
                    this.Center = new Point(Center.X, Center.Y - RedBallSpeed);
                }
                else if (Direction == "Left")
                {
                    this.Center = new Point(Center.X - 4, Center.Y);
                }
                else if (Direction == "Right")
                {
                    this.Center = new Point(Center.X + 4, Center.Y);
                }
            }
        }
    }


}
