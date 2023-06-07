using Microsoft.VisualBasic.Devices;
using System.Collections;

namespace MovingShapes
{
    public partial class Form1 : Form
    {
        Random random = new Random();

        public readonly float amountOfMovement = 10;

        List<Shape> addedShapes = new List<Shape>();

        public readonly float radiusMaxValue = 80;
        public readonly float radiusMinValue = 10;

        public Form1()
        {
            InitializeComponent();
            addedShapes = new List<Shape>();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            bool flag = true;
            foreach (Shape shape in addedShapes)
            {
                shape.Selected = shape.isHit(e.X, e.Y);
                if (shape.Selected) flag = false;
            }
            if (flag)
            {
                Circle circle = new Circle(e.X, e.Y, Color.Green, random.Next((int)radiusMinValue, (int)radiusMaxValue));
                addedShapes.Add(circle);
            }
            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            foreach (Shape shape in addedShapes)
            {
                shape.Draw(e.Graphics);
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.W)
            {
                foreach(Shape shape in addedShapes)
                {
                    if(shape.Selected)
                    {
                        shape.MoveUp(amountOfMovement);
                    }    
                }
            }
            else if (e.KeyCode == Keys.S)
            {
                foreach (Shape shape in addedShapes)
                {
                    if (shape.Selected)
                    {
                        shape.MoveDown(amountOfMovement);
                    }
                }
            }
            else if (e.KeyCode == Keys.A)
            {
                foreach (Shape shape in addedShapes)
                {
                    if (shape.Selected)
                    {
                        shape.MoveLeft(amountOfMovement);
                    }
                }
            }
            else if (e.KeyCode == Keys.D)
            {
                foreach (Shape shape in addedShapes)
                {
                    if (shape.Selected)
                    {
                        shape.MoveRight(amountOfMovement);
                    }
                }
            }
            Invalidate();
        }
    }
}