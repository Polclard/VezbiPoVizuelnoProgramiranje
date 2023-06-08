using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace VtoraAplikacijaIgraSoTopcinja
{

    public partial class Form1 : Form
    {
        Scene scene;
        Random randomVar = new Random();
        int counter = 0;
        int seconds = 0;
        public Form1()
        {
            InitializeComponent();
            scene = new Scene(this.Width, this.Height);
            this.DoubleBuffered = true;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            scene.Draw(e.Graphics);
        }

        private void Form1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            counter++;
            if (counter == 10)
            {
                seconds++;
                counter = 0;
            }
            scene.FormWidth = this.Width;
            scene.FormHeight = this.Height;
            scene.Move();
            for (int i = 0; i < scene.Balls.Count(); i++)
            {
                for (int j = 0; j < scene.Balls.Count(); j++)
                {
                    if (scene.Balls[i] != scene.Balls[j])
                    {
                        if (i < scene.Balls.Count())
                        {
                            if (AreColliding(scene.Balls[i], scene.Balls[j]))
                            {
                                double middle = (scene.Balls[i].Radius + scene.Balls[j].Radius) / 2;
                                Point newBallPoint = new Point(
                                    (Math.Abs(scene.Balls[i].Center.X - scene.Balls[j].Center.X)) / 2 + Math.Min(scene.Balls[i].Center.X, scene.Balls[j].Center.X),
                                    (Math.Abs(scene.Balls[i].Center.Y - scene.Balls[j].Center.Y)) / 2 + Math.Min(scene.Balls[i].Center.Y, scene.Balls[j].Center.Y)
                                    );
                                Ball newBall = new Ball(Center: newBallPoint,
                                    Color: Color.Red,
                                    Radius: randomVar.Next(20, 40),
                                    Direction: "Up",
                                    Speed: 10
                                    );
                                scene.Balls.Add(newBall);
                                scene.Balls.Remove(scene.Balls[j]);
                                scene.Balls.Remove(scene.Balls[i]);
                            }
                        }

                    }
                }
            }
            toolStripStatusLabel1.Text = $"Balls: {scene.Balls.Count()}; Time Passed: {seconds}s";
            Invalidate();
        }

        public bool AreColliding(Ball Ball1, Ball Ball2)
        {
            double distance = Math.Sqrt(((Ball1.Center.X - Ball2.Center.X) * (Ball1.Center.X - Ball2.Center.X)) + ((Ball1.Center.Y - Ball2.Center.Y) * (Ball1.Center.Y - Ball2.Center.Y)));
            if (distance < Ball1.Radius + Ball2.Radius)
            {
                return true;
            }
            return false;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            Random random = new Random();
            string Direction = "";
            int randomNumber = random.Next(0, 2);
            if (randomNumber == 0)
            {
                Direction = "Up";
            }
            else if (randomNumber == 1)
            {
                Direction = "Right";
            }
            Ball newBall = new Ball(Center: new Point(e.X, e.Y),
                Color: Color.Red,
                Radius: random.Next(20, 40),
                Direction: Direction,
                Speed: 10);
            scene.AddBall(newBall);
            Invalidate();
        }



        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                startToolStripMenuItem.Text = "Start";
                timer1.Stop();
            }
            else if (!timer1.Enabled)
            {
                startToolStripMenuItem.Text = "Pause";
                timer1.Start();
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {


            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "Saving.";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(sfd.FileName, FileMode.OpenOrCreate);
                IFormatter formatter = new BinaryFormatter();
#pragma warning disable SYSLIB0011
                formatter.Serialize(fs, scene);
#pragma warning restore SYSLIB0011
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Opening.";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(ofd.FileName, FileMode.Open);
                IFormatter formatter = new BinaryFormatter();
#pragma warning disable SYSLIB0011
                scene = (Scene)formatter.Deserialize(fs);
#pragma warning restore SYSLIB0011
            }
        }
    }
}