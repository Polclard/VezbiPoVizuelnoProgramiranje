using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovingShapes
{
    public abstract class Shape
    {

        public Point point { get; set; }

        public bool Selected { get; set; }

        public Color Color { get; set; }

        public Shape(Point point, Color Color)
        {
            this.point = point;
            this.Color = Color;
        }

        public abstract void Draw(Graphics g);

        public abstract bool isHit(float x, float y);   

        public void Move(float dx, float dy)
        {
            float newX = point.X + dx;
            float newY = point.Y + dy;
            this.point = new Point((int)newX, (int)newY);
        }

        public void MoveUp(float amount)
        {
           float newY = (float)point.Y - amount;
           this.point = new Point(this.point.X, (int)newY);
        }
        public void MoveDown(float amount)
        {
            float newY = (float)point.Y + amount;
            this.point = new Point(this.point.X, (int)newY);
        }
        public void MoveLeft(float amount)
        {
            float newX = (float)point.X - amount;
            this.point = new Point((int)newX, this.point.Y);
        }
        public void MoveRight(float amount)
        {
            float newX = (float)point.X + amount;
            this.point = new Point((int)newX, this.point.Y);
        }


    }
}
