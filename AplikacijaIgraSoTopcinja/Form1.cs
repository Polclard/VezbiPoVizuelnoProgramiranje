using System.Drawing.Drawing2D;
using System.Globalization;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;


namespace AplikacijaIgraSoTopcinja
{
    public partial class Form1 : Form
    {
        Scene scene;
        Ball firstBall;
        Ball secondBall;
        Ball thirdBall;
        int counter;
        int BlackBallRadius;
        Random Random = new Random();
        bool IS_SCENE_STOPPED = false;

        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            scene = new Scene(this.Width, this.Height);
            timer1.Start();
            int randX = Random.Next(100, this.Width - 100);
            int randY = Random.Next(100, this.Height - 100);
            Ball firstBall = new Ball(new Point(randX, randY), Color.Red, 15, 4);
            randX = Random.Next(100, this.Width - 100);
            randY = Random.Next(100, this.Height - 100);
            Ball secondBall = new Ball(new Point(randX, randY), Color.Red, 15, 4);
            randX = Random.Next(100, this.Width - 100);
            randY = Random.Next(100, this.Height - 100);
            Ball thirdBall = new Ball(new Point(randX, randY), Color.Red, 15, 4);
            scene.addBall(firstBall);
            scene.addBall(secondBall);
            scene.addBall(thirdBall);
            scene.InitializeMove();
            counter = 0;
            BlackBallRadius = 25;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            Random random = new Random();
            int x = random.Next(100, this.Width - 100);
            int y = random.Next(100, this.Height - 100);
            counter++;
            if (counter == 100)
            {
                counter = 0;

                if (IS_SCENE_STOPPED)
                {
                    //scene.addBall(new Ball(new Point(x, y), Color.Red, 15, 0));
                }
                else
                {
                    scene.addBall(new Ball(new Point(x, y), Color.Red, 15, 4));
                }
                scene.InitializeMove();
            }
            scene.Move();

            Ball theBlackBall = null;
            for (int i = 0; i < scene.Balls.Count(); i++)
            {
                if (scene.Balls[i].Color == Color.Black)
                {
                    theBlackBall = scene.Balls[i];
                }
            }

            if (theBlackBall != null)
            {
                for (int i = 0; i < scene.Balls.Count(); i++)
                {
                    if (theBlackBall != scene.Balls[i])
                    {
                        float x1 = theBlackBall.Center.X;
                        float y1 = theBlackBall.Center.Y;

                        float x2 = scene.Balls[i].Center.X;
                        float y2 = scene.Balls[i].Center.Y;

                        float deltaX = x2 - x1;
                        float deltaY = y2 - y1;

                        double distance = Math.Sqrt(deltaX * deltaX + deltaY * deltaY);

                        if (distance < theBlackBall.Radius + scene.Balls[i].Radius)
                        {
                            scene.Balls.Remove(scene.Balls[i]);
                            if (BlackBallRadius + 5 > 70)
                            {
                                scene.Balls.Remove(theBlackBall);
                                BlackBallRadius = 15;
                            }
                            else
                            {
                                BlackBallRadius += 5;
                            }
                        }
                    }
                }
            }

            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            scene.Draw(e.Graphics);
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            int counter = 0;
            for (int i = 0; i < scene.Balls.Count(); i++)
            {
                if (scene.Balls[i].Color == Color.Black)
                {
                    counter++;
                }
            }
            if (counter <= 0)
            {
                Ball blackBall = new Ball(new Point(e.X, e.Y), Color.Black, BlackBallRadius, 0);
                blackBall.Direction = "";
                scene.addBall(blackBall);
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < scene.Balls.Count(); i++)
            {
                if (scene.Balls[i].Color == Color.Black)
                {
                    scene.Balls[i] = new Ball(new Point(e.X, e.Y), Color.Black, BlackBallRadius, 0);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void pauseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (IS_SCENE_STOPPED == false)
            {
                IS_SCENE_STOPPED = true;
                pauseToolStripMenuItem.Text = "Start";
                foreach (Ball ball in scene.Balls)
                {
                    if (ball.Color == Color.Red)
                    {
                        ball.RedBallSpeed = 0;
                    }
                }
            }
            else
            {
                pauseToolStripMenuItem.Text = "Pause";
                IS_SCENE_STOPPED = false;
                foreach (Ball ball in scene.Balls)
                {
                    if (ball.Color == Color.Red)
                    {
                        ball.RedBallSpeed = 4;
                    }
                }
            }

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Opening.";
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(ofd.FileName, FileMode.Open);
                IFormatter formatter = new BinaryFormatter();
                #pragma warning disable SYSLIB0011
                scene = (Scene)formatter.Deserialize(fs);
                #pragma warning restore SYSLIB0011
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "Saving.";
            if(sfd.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(sfd.FileName, FileMode.OpenOrCreate);
                IFormatter formatter = new BinaryFormatter();
                #pragma warning disable SYSLIB0011
                formatter.Serialize(fs, scene);
                #pragma warning restore SYSLIB0011
            }
        }
    }
}