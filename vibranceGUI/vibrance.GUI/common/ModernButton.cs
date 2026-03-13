using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace vibrance.GUI.common
{
    /// <summary>
    /// Modern button with rounded corners and smooth hover effects
    /// </summary>
    public class ModernButton : Button
    {
        private Color _normalBackColor = Color.FromArgb(30, 30, 30);
        private Color _hoverBackColor = Color.FromArgb(50, 50, 50);
        private Color _borderColor = Color.FromArgb(0, 150, 136);
        private int _cornerRadius = 4;
        private float _animationProgress = 0f;
        private Timer _hoverTimer;

        public ModernButton()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | 
                     ControlStyles.UserPaint | 
                     ControlStyles.OptimizedDoubleBuffer, true);
            
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 1;
            FlatAppearance.BorderColor = _borderColor;
            
            _hoverTimer = new Timer();
            _hoverTimer.Interval = 16; // ~60fps
            _hoverTimer.Tick += HoverTimer_Tick;
        }

        public Color NormalBackColor
        {
            get => _normalBackColor;
            set { _normalBackColor = value; Invalidate(); }
        }

        public Color HoverBackColor
        {
            get => _hoverBackColor;
            set { _hoverBackColor = value; Invalidate(); }
        }

        public int CornerRadius
        {
            get => _cornerRadius;
            set { _cornerRadius = Math.Max(0, value); Invalidate(); }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.Clear(Color.FromArgb(20, 20, 20));
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            // Interpolate colors based on animation progress
            float progress = _animationProgress;
            int r = (int)(_normalBackColor.R + (_hoverBackColor.R - _normalBackColor.R) * progress);
            int g = (int)(_normalBackColor.G + (_hoverBackColor.G - _normalBackColor.G) * progress);
            int b = (int)(_normalBackColor.B + (_hoverBackColor.B - _normalBackColor.B) * progress);
            Color currentColor = Color.FromArgb(r, g, b);

            // Draw rounded rectangle background
            using (var path = GetRoundedRectanglePath(ClientRectangle, _cornerRadius))
            {
                using (var brush = new SolidBrush(currentColor))
                {
                    e.Graphics.FillPath(brush, path);
                }
                using (var pen = new Pen(_borderColor, 1))
                {
                    e.Graphics.DrawPath(pen, path);
                }
            }

            // Draw text
            TextRenderer.DrawText(e.Graphics, Text, Font, ClientRectangle, 
                ForeColor, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
        }

        private GraphicsPath GetRoundedRectanglePath(Rectangle rect, int radius)
        {
            var path = new GraphicsPath();
            int diameter = radius * 2;

            if (radius == 0)
            {
                path.AddRectangle(rect);
            }
            else
            {
                path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90);
                path.AddArc(rect.Right - diameter, rect.Y, diameter, diameter, 270, 90);
                path.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90);
                path.AddArc(rect.X, rect.Bottom - diameter, diameter, diameter, 90, 90);
                path.CloseFigure();
            }

            return path;
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            _hoverTimer.Start();
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            _hoverTimer.Stop();
            _animationProgress = 0f;
            Invalidate();
        }

        private void HoverTimer_Tick(object sender, EventArgs e)
        {
            if (ClientRectangle.Contains(PointToClient(MousePosition)))
            {
                if (_animationProgress < 1f)
                {
                    _animationProgress = Math.Min(1f, _animationProgress + 0.1f);
                    Invalidate();
                }
            }
            else
            {
                if (_animationProgress > 0f)
                {
                    _animationProgress = Math.Max(0f, _animationProgress - 0.1f);
                    Invalidate();
                }
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _hoverTimer?.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
