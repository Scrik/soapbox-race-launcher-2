using System;
using System.Drawing;
using System.Windows.Forms;
using static SoapboxLauncher.Extensions.Imports;
using static SoapboxLauncher.Variables.Colors;
using static SoapboxLauncher.Variables.Strings;

namespace SoapboxLauncher
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            ActiveControl = serversLabel; // To stop any item requesting focus on launch

            titleBar.BackColor = titleBarBackColor;
            foreach (Control control in Controls)
            {
                if (control.GetType() == typeof(Label))
                {
                    Label label = control as Label;
                    label.BackColor = labelBackColor;
                    label.ForeColor = labelForeColor;
                }
            }

        }

        #region TitleBar
        private void titleBar_Paint(object sender, PaintEventArgs e)
        {
            using (Brush aBrush = new SolidBrush(labelForeColor))
            using (Font font = new Font(Font, FontStyle.Bold))
            {
                e.Graphics.DrawString(titleText, font, aBrush, new PointF(5f, 6f));
            }
        }
        private void title_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        #endregion

        #region Button Handling
        private void button_MouseEnter(object sender, EventArgs e)
        {
            if (sender.GetType() == typeof(Label))
            {
                Label label = sender as Label;
                label.Font = new Font(label.Font, FontStyle.Bold);
                label.ForeColor = labelHoverForeColor;

                switch (label.Name)
                {
                    case "closeButton":
                        label.BackColor = labelHoverBackColor_Close;
                        break;
                    case "minButton":
                        label.BackColor = labelHoverBackColor_Minimize;
                        break;
                }
            }
            else
            {

            }
        }
        private void button_MouseLeave(object sender, EventArgs e)
        {
            if (sender.GetType() == typeof(Label))
            {
                Label label = sender as Label;
                label.Font = new Font(label.Font, FontStyle.Regular);
                label.ForeColor = labelForeColor;

                switch (label.Name)
                {
                    case "closeButton":
                        label.BackColor = labelBackColor;
                        break;
                    case "minButton":
                        label.BackColor = labelBackColor;
                        break;
                }
            }
            else
            {

            }
        }
        private void button_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (ClientRectangle.Contains(e.Location))
                {
                    if (sender.GetType() == typeof(Label))
                    {
                        Label label = sender as Label;
                        switch (label.Name)
                        {
                            case "closeButton":
                                Application.Exit();
                                break;
                            case "minButton":
                                this.WindowState = FormWindowState.Minimized;
                                break;
                        }
                    }
                    else
                    {

                    }
                }
            }
        }
        #endregion
    }
}
