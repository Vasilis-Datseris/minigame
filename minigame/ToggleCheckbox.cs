using System;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace minigame
{
    class ToggleCheckbox : Control
    {
        private float diameter;
        private MyRectangle rect;
        private RectangleF circle;
        private bool isON;
        private float artis;
        private Color borderColor;
        private bool textEnabled;
        private string OnTex = "";
        private string OffTex = "";
        private Color OnCol;
        private Color OffCol;
        private Timer painTicker = new Timer();
        public event SliderChangedEventHandler SliderValueChanged;

        public ToggleCheckbox()
        {
            Cursor = Cursors.Hand;
            DoubleBuffered = true;
            artis = 4f;
            diameter = 30f;
            textEnabled = true;
            rect = new MyRectangle(2f * diameter, diameter + 2f, diameter / 2f, 1f, 1f);
            circle = new RectangleF(1f, 1f, diameter, diameter);
            isON = false;
            borderColor = Color.LightGray;
            painTicker.Tick += new EventHandler(paintTicker_Tick);
            painTicker.Interval = 1;
            OnCol = Color.FromArgb(94, 148, 255);
            OffCol = Color.DarkGray;
            ForeColor = Color.White;
            OnTex = "ON";
            OffTex = "OFF";
        }

        protected override void OnEnabledChanged(EventArgs e)
        {
            base.Invalidate();
            base.OnEnabledChanged(e);
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isON = !isON;
                IsOn = isON;
                base.OnMouseClick(e);
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = (SmoothingMode)SmoothingMode.HighQuality;
            if (base.Enabled)
            {
                Pen pen;
                using (SolidBrush brush = new SolidBrush(isON ? OnCol : OffCol))
                {
                    e.Graphics.FillPath((Brush)brush, rect.Path);
                }
                using (pen = new Pen(borderColor, 2f))
                {
                    e.Graphics.DrawPath(pen, rect.Path);
                }
                if (textEnabled)
                {
                    using (Font font = new Font("Century Gothic", (8.2f * diameter) / 30f, (FontStyle)FontStyle.Bold))
                    {
                        SolidBrush b = new SolidBrush(ForeColor);
                        int height = TextRenderer.MeasureText(OnTex, font).Height;
                        float num2 = (diameter - height) / 2f;
                        e.Graphics.DrawString(OnTex, font, b, 5f, num2 + 1f);
                        height = TextRenderer.MeasureText(OffTex, font).Height;
                        num2 = (diameter - height) / 2f;
                        e.Graphics.DrawString(OffTex, font, b, diameter + 2f, num2 + 1f);
                    }
                    using (SolidBrush brush2 = new SolidBrush("#FFFFFF".FromHex()))
                    {
                        e.Graphics.FillEllipse((Brush)brush2, circle);
                    }
                    using (pen = new Pen(Color.LightGray, 1.2f))
                    {
                        e.Graphics.DrawEllipse(pen, circle);
                    }
                }
                else
                {
                    using (SolidBrush brush3 = new SolidBrush("#FFFFFF".FromHex()))
                    {
                        using (SolidBrush brush4 = new SolidBrush("#FFFFFF".FromHex()))
                        {
                            e.Graphics.FillPath((Brush)brush3, rect.Path);
                            e.Graphics.FillEllipse((Brush)brush4, circle);
                            e.Graphics.DrawEllipse(Pens.DarkGray, circle);
                        }
                    }
                }
            }
            base.OnPaint(e);
        }

        protected override void OnResize(EventArgs e)
        {
            base.Width = (base.Height - 2) * 2;
            diameter = base.Width / 2;
            artis = (4f * diameter) * 30f;
            rect = new MyRectangle(2f * diameter, diameter + 2f, diameter / 2f, 1f, 1f);
            circle = new RectangleF(!isON ? 1f : ((base.Width - this.diameter) - 1f), 1f, this.diameter, this.diameter);
            base.OnResize(e);
        }

        private void paintTicker_Tick(object sender, EventArgs e)
        {
            float x = this.circle.X;
            if (this.isON)
            {
                if ((x + this.artis) <= ((base.Width - this.diameter) - 1f))
                {
                    x += this.artis;
                    this.circle = new RectangleF(x, 1f, this.diameter, this.diameter);
                    base.Invalidate();
                }
                else
                {
                    x = (base.Width - this.diameter) - 1f;
                    this.circle = new RectangleF(x, 1f, this.diameter, this.diameter);
                    base.Invalidate();
                    this.painTicker.Stop();
                }
            }
            else if ((x - this.artis) >= 1f)
            {
                x -= this.artis;
                this.circle = new RectangleF(x, 1f, this.diameter, this.diameter);
            }
            else
            {
                x = 1f;
                this.circle = new RectangleF(x, 1f, this.diameter, this.diameter);
                base.Invalidate();
                this.painTicker.Stop();
            }
        }

        public bool TextEnabled
        {
            get =>
                this.textEnabled;
            set
            {
                this.textEnabled = value;
                base.Invalidate();
            }
        }

        public bool IsOn
        {
            get =>
                this.isON;
            set
            {
                this.painTicker.Stop();
                this.isON = value;
                this.painTicker.Start();
                if (this.SliderValueChanged != null)
                {
                    this.SliderValueChanged(this, EventArgs.Empty);
                }
            }
        }

        public Color BorderColor
        {
            get =>
                this.borderColor;
            set
            {
                this.borderColor = value;
                base.Invalidate();
            }
        }

        protected override Size DefaultSize
            => new Size(60, 35);
        public delegate void SliderChangedEventHandler(object sender, EventArgs e);


        public string OnText
        {
            get =>
                this.OnTex;
            set
            {
                this.OnTex = value;
                base.Invalidate();
            }
        }
        public string OffText
        {
            get =>
                this.OffTex;
            set
            {
                this.OffTex = value;
                base.Invalidate();
            }
        }

        public Color OnColor
        {
            get =>
                this.OnCol;
            set
            {
                this.OnCol = value;
                base.Invalidate();
            }
        }

        public Color OffColor
        {
            get =>
                this.OffCol;
            set
            {
                this.OffCol = value;
                base.Invalidate();
            }
        }
    }
}
