using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VtoraAplikacijaIgraSoTopcinja
{
    [Serializable]
    public class Ball
    {
        public Point Center { get; set; }
        public int Radius { get; set; }
        public string Direction { get; set; }
        public int Speed { get; set; }
        public Color Color { get; set; }

        public Ball(Point Center,
            Color Color,
            int Radius=20,
            string Direction="Up",
            int Speed=10)
        {
            this.Center = Center;
            this.Radius = Radius;
            this.Direction = Direction;
            this.Color = Color;
            this.Speed = Speed;
        }

        public void Draw(Graphics g)
        {
            Brush b = new SolidBrush(Color.Red);
            g.FillEllipse(b, Center.X-Radius, Center.Y-Radius, Radius*2, Radius*2);
            b.Dispose();
        }

        public void Move()
        {
            if(Direction == "Up")
            {
                this.Center = new Point(this.Center.X, this.Center.Y - Speed);
            }
            else if (Direction == "Down")
            {
                this.Center = new Point(this.Center.X, this.Center.Y + Speed);
            }
            else if (Direction == "Right")
            {
                this.Center = new Point(this.Center.X + Speed, this.Center.Y);
            }
            else if (Direction == "Left")
            {
                this.Center = new Point(this.Center.X - Speed, this.Center.Y);
            }
        }
    }
}
