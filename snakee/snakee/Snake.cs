using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace snakee
{
    public class Snakes
    {
        private PictureBox pb;
        private int length;
        private List<Point> snake = new List<Point>();
        Graphics g;
        enum Direction { RIGHT, LEFT, UP, DOWN};
        Direction dir;


        public Snake(PictureBox pb)
        {
            this.pb = pb;
            length = 3;
            for (int i=0; i < length; i++)
            {
                Point head = new Point(30,30);
                snake.Add(head);
            }
            dir = Direction.RIGHT;
        }

        public int Length
        {
             get
            {
                return length;
            }
             set
            {
                length = value;
            }
        }

        public void Direct (String direct)
        {
            if (direct == "RIGHT")
            {
                dir = Direction.RIGHT;
            }
        }

        public void Move()
        {

        }

        public void Draw()
        {
            g = pb.CreateGraphics();
            Pen p = new Pen(Color.Red);
            g.DrawRectangle(p, 30, 30, 10, 10);
        }
    }
}
