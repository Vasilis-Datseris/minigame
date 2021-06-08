using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace minigame
{
    class Details : Button
    {
        protected override void OnPaint(PaintEventArgs e)
        {
            GraphicsPath gPath = new GraphicsPath();
            gPath.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
            Region = new System.Drawing.Region(gPath);
            base.OnPaint(e);
        }
    }
}
