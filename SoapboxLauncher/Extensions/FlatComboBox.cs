using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using static SoapboxLauncher.Variables.Colors;

namespace SoapboxLauncher.Extensions
{
    public class FlatCombo : ComboBox
    {
        private Color backColor;
        public FlatCombo()
        {
            DrawItem += new DrawItemEventHandler(DrawCustomMenuItem);
            SetStyle(ControlStyles.UserPaint, true);
            DrawMode = DrawMode.OwnerDrawFixed;
            backColor = comboBoxBackColor;
        }

        protected void DrawCustomMenuItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();

            if (e.Index >= 0)
            {
                Graphics g = e.Graphics;
                Boolean isItemSelected = ((e.State & DrawItemState.Selected) == DrawItemState.Selected);
                Color itemBackColor = isItemSelected ? comboBoxSelectedItemBackColor : comboBoxItemBackColor;
                Color itemForeColor = isItemSelected ? labelHoverForeColor : labelForeColor;

                using (Brush itemBackColorBrush = new SolidBrush(itemBackColor))
                using (Brush itemForeColorBrush = new SolidBrush(itemForeColor))
                using (Font itemFont = new Font(e.Font, isItemSelected ? FontStyle.Bold : FontStyle.Regular))
                {
                    g.FillRectangle(itemBackColorBrush, e.Bounds);
                    e.Graphics.DrawString(Items[e.Index].ToString(), itemFont,
                               itemForeColorBrush, e.Bounds, StringFormat.GenericDefault);
                }
            }
            e.DrawFocusRectangle();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            using (Graphics g = CreateGraphics())
            using (SolidBrush backgroundBrush = new SolidBrush(backColor))
            {
                g.FillRectangle(backgroundBrush, ClientRectangle);

                using (GraphicsPath pth = new GraphicsPath())
                using (SolidBrush brush = new SolidBrush(DroppedDown ? comboBoxHoverArrowColor : comboBoxArrowColor))
                {
                    PointF TopLeft = new PointF(Width - 14, (Height - 4) / 2);
                    PointF TopRight = new PointF(Width - 6, (Height - 4) / 2);
                    PointF Bottom = new PointF(Width - 10, (Height + 4) / 2);
                    pth.AddLine(TopLeft, TopRight);
                    pth.AddLine(TopRight, Bottom);

                    g.SmoothingMode = SmoothingMode.AntiAlias;
                    g.FillPath(brush, pth);
                }
            }
            base.OnPaint(e);
        }

        #region blabla I like fancy colors blabla
        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            backColor = comboBoxHoverBackColor;
            Invalidate();
        }
        protected override void OnGotFocus(EventArgs e)
        {
            base.OnGotFocus(e);
            backColor = comboBoxHoverBackColor;
            Invalidate();
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            backColor = comboBoxBackColor;
            Invalidate();
        }
        protected override void OnLostFocus(EventArgs e)
        {
            base.OnLostFocus(e);
            backColor = comboBoxBackColor;
            Invalidate();
        }
        #endregion
    }
}
