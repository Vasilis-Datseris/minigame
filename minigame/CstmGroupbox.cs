using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace minigame
{
    class CstmGroupbox : GroupBox
    {
        private string myText = "";
        public CstmGroupbox()
        {
            base.Text = "";
        }

        [Browsable(true)]
        [Category("Appearance")]
        [DefaultValue("MyGroupboxText")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public new string Text
        {
            get => myText; 
            set 
            {
                myText = value; 
                Invalidate(); 
            }
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            SolidBrush foreColor = new SolidBrush(ForeColor);
            var backColor = new SolidBrush(BackColor);
            var size = TextRenderer.MeasureText(Text, Font);
            int left = (Width - size.Width) / 2;
            e.Graphics.FillRectangle(backColor, new Rectangle(left, 0, size.Width, size.Width));
            e.Graphics.DrawString(Text, Font, foreColor, new PointF(left, 0));
        }
    }
}
