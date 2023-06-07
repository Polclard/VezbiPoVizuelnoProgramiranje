using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovingBalls
{
    public class Scene
    {
        public List<Ball> Balls { get; set; }
        public int Hits { get; set; }
        public int Misses { get; set; }
        public int FormWidth { get; set; }
        public Scene(int FormWidth)
        {
            Balls = new List<Ball>();
            Hits = 0;
            Misses = 0;
            this.FormWidth = FormWidth;
        }

        public void Draw(Graphics g)
        {
            foreach (Ball b in Balls)
            {
                b.Draw(g);
            }
            for (int i = 0; i < Balls.Count(); i++)
            {
                if (Balls[i].Location.X >= FormWidth)
                {
                    Balls.Remove(Balls[i]);
                    Misses++;
                }
            }
        }

        public void AddBall(Ball ball)
        {
            Balls.Add(ball);
        }

        public void Move()
        {
            foreach (Ball b in Balls)
            {
                b.Move();
            }
        }

        public void IsHit(Point newPoint)
        {
            for (int i = Balls.Count() - 1; i >= 0; i--)
            {
                if (Balls[i].isHit(newPoint))
                {
                    if (Balls[i].Color == Color.Red)
                    {
                        Balls[i].Color = Color.Yellow;
                    }
                    else if (Balls[i].Color == Color.Yellow)
                    {
                        Balls[i].Color = Color.Green;
                    }
                    else if (Balls[i].Color == Color.Green)
                    {
                        Balls.Remove(Balls[i]);
                        Hits++;
                    }
                }
            }
        }

    }
}
