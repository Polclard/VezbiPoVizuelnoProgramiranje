using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplikacijaIgraSoTopcinja
{
    [Serializable]
    public class Scene
    {
        public List<Ball> Balls { get; set; }
        public Ball BlackBall { get; set; }
        public int FormWidth { get; set; }
        public int FormHeight { get; set; }

        public Scene(int Width, int Height) 
        {
            Balls = new List<Ball>();
            FormWidth=Width;
            FormHeight=Height;
        }

        public void Draw(Graphics g)
        {
            foreach (Ball ball in Balls)
            {
                ball.Draw(g);
            }
            for(int j=Balls.Count-1; j>=0; j--)
            {
                if (Balls[j].Center.X > FormWidth-30 ||
                    Balls[j].Center.X < 30 ||
                    Balls[j].Center.Y > FormHeight-30 ||
                    Balls[j].Center.Y < 30)
                {
                    if (Balls[j].Direction == "Right")
                    {
                        Balls[j].Direction = "Left";
                    }
                    else if (Balls[j].Direction == "Left")
                    {
                        Balls[j].Direction = "Right";
                    }
                    else if (Balls[j].Direction == "Up")
                    {
                        Balls[j].Direction = "Down";
                    }
                    else if (Balls[j].Direction == "Down")
                    {
                        Balls[j].Direction = "Up";
                    }
                }
            }
        }

        public void addBall(Ball ball)
        {
            Balls.Add(ball);
        }

        public void InitializeMove()
        {
            Random random = new Random();
            
            foreach(Ball ball in Balls)
            {
                if(ball.Direction == " " || ball.Direction == "")
                {
                    int randomValue = random.Next(0,3);
                    if (randomValue == 0)
                    {
                        ball.Direction = "Up";
                    }
                    else if (randomValue == 1)
                    {
                        ball.Direction = "Down";
                    }
                    else if (randomValue == 2)
                    {
                        ball.Direction = "Left";
                    }
                    else if (randomValue == 3)
                    {
                        ball.Direction = "Right";
                    }
                }
            }
            
        }

        public void Move()
        {
            foreach (Ball ball in Balls)
            {
                ball.Move();
            }
        }
    }
}
