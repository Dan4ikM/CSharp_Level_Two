using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asteroid.BaseObjects
{
    class Star : BaseObject
    {
        System.Drawing.Brush Brush = Brushes.Red;
        static System.Drawing.Image Image { get; } = Image.FromFile("Images/star.png");

        public Star() : base(pos: new Point(), size: new Size(), dir: new Point())
        {

        }

        public Star(Point pos, Point dir, Size size, Brush brush = null) : base(pos, dir, size)
        {
            Pos = pos;
            Dir = dir;
            Size = size;
            if (brush != null)
                Brush = brush;
        }

        public override void Update()
        {
            Pos.X = Pos.X + Dir.X;
            Pos.Y = Pos.Y + Dir.Y;
            if (Pos.X < 0) { Pos.X = Game.Width; Pos.Y = Game.Random.Next(0, Game.Height); }
        }

        public override void Draw()
        {
            //Game.Buffer.Graphics.FillEllipse(Brush, Pos.X, Pos.Y, Size.Width, Size.Height);
            Game.Buffer.Graphics.DrawImage(Image, Pos);
        }
    }
}
