using System.Drawing;
using System.Drawing.Drawing2D;

namespace minigame
{
    class MyRectangle
    {
        private Point location;
        private float radius;
        private GraphicsPath grPath;
        private float x;
        private float y;
        private float width;
        private float height;

        public MyRectangle() { }
        public MyRectangle(float width, float height, float radius, float x = 0f, float y = 0f)
        {

            location = new Point(0, 0);
            this.radius = radius;
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
            grPath = new GraphicsPath();
            if (radius <= 0f)
            {
                grPath.AddRectangle(new RectangleF(x, y, width, height));
            }
            else
            {
                RectangleF ef = new RectangleF(x, y, 2f * radius, 2f * radius);
                RectangleF ef2 = new RectangleF((width - (2f * radius)) - 1f, x, 2f * radius, 2f * radius);
                RectangleF ef3 = new RectangleF(x, (height - (2f * radius)) - 1f, 2f * radius, 2f * radius);
                RectangleF ef4 = new RectangleF((width - (2f * radius)) - 1f,
                    (height - (2f * radius)) - 1f, 2f * radius, 2f * radius);

                grPath.AddArc(ef, 180f, 90f);
                grPath.AddArc(ef2, 270f, 90f);
                grPath.AddArc(ef4, 0f, 90f);
                grPath.AddArc(ef3, 90f, 90f);
                grPath.CloseAllFigures();
            }
        }

        public GraphicsPath Path =>
            grPath;

        public RectangleF Rect =>
            new RectangleF(x, y, width, height);

        public float Radius
        {
            get =>
                radius;
            set =>
                radius = value;
        }
    }
}
