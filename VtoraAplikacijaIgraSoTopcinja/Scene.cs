using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VtoraAplikacijaIgraSoTopcinja
{
    [Serializable]
    public class Scene
    {
        public List<Ball> Balls { get; set; }
        public int FormWidth { get; set; }
        public int FormHeight { get; set; }


        public Scene(int FormWidth, int FormHeight)
        {
            this.FormWidth = FormWidth;
            this.FormHeight = FormHeight;
            Balls = new List<Ball>();
        }

        public void Draw(Graphics g)
        {
            foreach(Ball ball in Balls)
            {
                ball.Draw(g);
            }
            for (int i = Balls.Count()-1; i >= 0; i--)
            {
                if (Balls[i].Center.X > FormWidth - Balls[i].Radius*2 ||
                    Balls[i].Center.X < 0 + Balls[i].Radius ||
                    Balls[i].Center.Y > FormHeight - Balls[i].Radius*2 ||
                    Balls[i].Center.Y < 0 + Balls[i].Radius)
                {
                    if (Balls[i].Direction == "Up")
                    {
                        Balls[i].Direction = "Down";
                    }
                    else if (Balls[i].Direction == "Down")
                    {
                        Balls[i].Direction = "Up";
                    }
                    else if (Balls[i].Direction == "Left")
                    {
                        Balls[i].Direction = "Right";
                    }
                    else if (Balls[i].Direction == "Right")
                    {
                        Balls[i].Direction = "Left";
                    }
                }
            }
            
        }

        public void AddBall(Ball newBall)
        {
            this.Balls.Add(newBall);
        }

        public void Move()
        {
            foreach(Ball ball in Balls)
            {
                ball.Move();
            }
        }
    }
}
