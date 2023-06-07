namespace MovingBalls
{
    public partial class Form1 : Form
    {
        Scene scene;
        int timerCounter = 0;
        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            scene = new Scene(this.Width);
            timer1.Start();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timerCounter++;
            if (timerCounter % 8 == 0)
            {
                Random random = new Random();
                int randInt = random.Next(0, 3);
                Color newColor;
                if (randInt == 0)
                {
                    newColor = Color.Red;
                }
                else if (randInt == 1)
                {
                    newColor = Color.Yellow;
                }
                else
                {
                    newColor = Color.Green;
                }
                Ball newBall = new Ball(new Point(-Ball.Radius * 2, random.Next(Ball.Radius * 2, this.Height - Ball.Radius * 2)), newColor);
                scene.AddBall(newBall);
            }
            scene.Move();
            tHitsMisses.Text = $"Hits: {scene.Hits} Misses: {scene.Misses} Number of Balls on Scene: {scene.Balls.Count()}";
            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            scene.Draw(e.Graphics);
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            scene.FormWidth = this.Width;
        }

        private void Form1_Click(object sender, EventArgs e)
        { 
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            scene.IsHit(new Point(e.X, e.Y));
        }
    }
}