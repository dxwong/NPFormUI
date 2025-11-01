#region Imports

using System;
using System.Drawing;
using ReaLTaiizor.Utils;
using ReaLTaiizor.Colors;
using ReaLTaiizor.Controls;
using System.Windows.Forms;

#endregion

namespace ReaLTaiizor.Forms
{
    #region RoyalForm

    public class RoyalForm : System.Windows.Forms.Form
    {
        private RoyalButton maximizeButton;
        private RoyalButton minimizeButton;
        private RoyalButton closeButton;

        const int WM_NCHITTEST = 0x0084;
        const int HTCLIENT = 0x01;
        const int HTCAPTION = 0x02;
        const int wmNcHitTest = 0x84;
        const int htLeft = 10;
        const int htRight = 11;
        const int htTop = 12;
        const int htTopLeft = 13;
        const int htTopRight = 14;
        const int htBottom = 15;
        const int htBottomLeft = 16;
        const int htBottomRight = 17;

        bool drawBorder;
        public bool DrawBorder
        {
            get { return drawBorder; }
            set { drawBorder = value; }
        }

        int borderThickness;
        public int BorderThickness
        {
            get { return borderThickness; }
            set { borderThickness = value; }
        }

        private Color _BackColor2 = RoyalColors.BackColor;
        public Color BackColor2
        {
            get { return _BackColor2; }
            set { _BackColor2 = value; Invalidate(); }
        }

        bool moveable = true;
        public bool Moveable
        {
            get { return moveable; }
            set { moveable = value; }
        }

        private bool sizable = true;
        public bool Sizable
        {
            get { return sizable; }
            set { sizable = value; }
        }

        public RoyalForm()
        {
            InitializeComponent();

            ForeColor = RoyalColors.ForeColor;
            BackColor = _BackColor2;

            closeButton.BackColor = RoyalColors.BackColor;
            closeButton.HotTrackColor = Color.Crimson;
            closeButton.PressedColor = Color.Firebrick;
            closeButton.Cursor = Cursors.Hand;

            maximizeButton.BackColor = base.BackColor;
            maximizeButton.HotTrackColor = RoyalColors.HotTrackColor;
            maximizeButton.PressedColor = RoyalColors.PressedBackColor;
            maximizeButton.Cursor = Cursors.Hand;

            minimizeButton.BackColor = base.BackColor;
            minimizeButton.HotTrackColor = RoyalColors.HotTrackColor;
            minimizeButton.PressedColor = RoyalColors.PressedBackColor;
            minimizeButton.Cursor = Cursors.Hand;

            DrawBorder = false;
            BorderThickness = 1;
            Moveable = true;
            StartPosition = FormStartPosition.CenterScreen;
            MinimumSize = new Size(250, 250);
        }

        protected override void OnResize(EventArgs e)
        {
            closeButton.Location = new Point(Width - 34, 1);
            maximizeButton.Location = new Point(Width - 68, 1);
            if (MaximizeBox)
                minimizeButton.Location = new Point(Width - 102, 1);
            else
                minimizeButton.Location = new Point(Width - 68, 1);

            base.OnResize(e);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            if (DrawBorder)
                e.Graphics.DrawRectangle(new Pen(RoyalColors.BorderColor, BorderThickness), new Rectangle(0, 0, Width - BorderThickness, Height - BorderThickness));
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            if (Sizable && m.Msg == wmNcHitTest && WindowState != FormWindowState.Maximized)
            {
                int gripDist = 10;
                //int x = (int)(m.LParam.ToInt64() & 0xFFFF);
                //int x = Cursor.Position.X;
                // int y = (int)((m.LParam.ToInt64() & 0xFFFF0000) >> 16);
                //Console.WriteLine(x);
                Point pt = PointToClient(Cursor.Position);
                //Console.WriteLine(pt);
                Size clientSize = ClientSize;
                ///allow resize on the lower right corner
                if (pt.X >= clientSize.Width - gripDist && pt.Y >= clientSize.Height - gripDist && clientSize.Height >= gripDist)
                {
                    m.Result = (IntPtr)(IsMirrored ? htBottomLeft : htBottomRight);
                    return;
                }
                ///allow resize on the lower left corner
                if (pt.X <= gripDist && pt.Y >= clientSize.Height - gripDist && clientSize.Height >= gripDist)
                {
                    m.Result = (IntPtr)(IsMirrored ? htBottomRight : htBottomLeft);
                    return;
                }
                ///allow resize on the upper right corner
                if (pt.X <= gripDist && pt.Y <= gripDist && clientSize.Height >= gripDist)
                {
                    m.Result = (IntPtr)(IsMirrored ? htTopRight : htTopLeft);
                    return;
                }
                ///allow resize on the upper left corner
                if (pt.X >= clientSize.Width - gripDist && pt.Y <= gripDist && clientSize.Height >= gripDist)
                {
                    m.Result = (IntPtr)(IsMirrored ? htTopLeft : htTopRight);
                    return;
                }
                ///allow resize on the top border
                if (pt.Y <= 2 && clientSize.Height >= 2)
                {
                    m.Result = (IntPtr)(htTop);
                    return;
                }
                ///allow resize on the bottom border
                if (pt.Y >= clientSize.Height - gripDist && clientSize.Height >= gripDist)
                {
                    m.Result = (IntPtr)(htBottom);
                    return;
                }
                ///allow resize on the left border
                if (pt.X <= gripDist && clientSize.Height >= gripDist)
                {
                    m.Result = (IntPtr)(htLeft);
                    return;
                }
                ///allow resize on the right border
                if (pt.X >= clientSize.Width - gripDist && clientSize.Height >= gripDist)
                {
                    m.Result = (IntPtr)(htRight);
                    return;
                }
            }

            if (m.Msg == WM_NCHITTEST)
            {
                if (Moveable)
                {
                    if ((int)m.Result == HTCLIENT)
                        m.Result = new IntPtr(HTCAPTION);
                }
            }

            if (ControlBox == false)
            {
                closeButton.Hide();
                minimizeButton.Hide();
                maximizeButton.Hide();
            }
            else if (Visible && ControlBox == true && !closeButton.Visible)
            {
                closeButton.Show();

                if (MinimizeBox)
                    minimizeButton.Show();

                if (MaximizeBox)
                    maximizeButton.Show();
            }

            if (Visible && !MinimizeBox && minimizeButton.Visible)
                minimizeButton.Hide();
            else if (Visible && MinimizeBox && !minimizeButton.Visible && ControlBox)
                minimizeButton.Show();

            if (Visible && !MaximizeBox && maximizeButton.Visible)
                maximizeButton.Hide();
            else if (Visible && MaximizeBox && !maximizeButton.Visible && ControlBox)
                maximizeButton.Show();
        }

        private void InitializeComponent()
        {
            this.minimizeButton = new ReaLTaiizor.Controls.RoyalButton();
            this.maximizeButton = new ReaLTaiizor.Controls.RoyalButton();
            this.closeButton = new ReaLTaiizor.Controls.RoyalButton();
            this.SuspendLayout();
            // 
            // minimizeButton
            // 
            this.minimizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizeButton.BackColor = this.BackColor;
            this.minimizeButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.minimizeButton.BorderThickness = 3;
            this.minimizeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimizeButton.DrawBorder = false;
            this.minimizeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.minimizeButton.HotTrackColor = System.Drawing.Color.Gainsboro;
            this.minimizeButton.Image = global::ReaLTaiizor.Properties.Resources.Minimize;
            this.minimizeButton.LayoutFlags = ReaLTaiizor.Utils.RoyalLayoutFlags.ImageOnly;
            this.minimizeButton.Location = new System.Drawing.Point(1118, 1);
            this.minimizeButton.Margin = new System.Windows.Forms.Padding(1);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.PressedColor = System.Drawing.Color.CornflowerBlue;
            this.minimizeButton.PressedForeColor = System.Drawing.Color.White;
            this.minimizeButton.Size = new System.Drawing.Size(33, 30);
            this.minimizeButton.TabIndex = 2;
            this.minimizeButton.Text = "minimizeButton";
            this.minimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // maximizeButton
            // 
            this.maximizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maximizeButton.BackColor = this.BackColor;
            this.maximizeButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.maximizeButton.BorderThickness = 3;
            this.maximizeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.maximizeButton.DrawBorder = false;
            this.maximizeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.maximizeButton.HotTrackColor = System.Drawing.Color.Gainsboro;
            this.maximizeButton.Image = global::ReaLTaiizor.Properties.Resources.Maximize;
            this.maximizeButton.LayoutFlags = ReaLTaiizor.Utils.RoyalLayoutFlags.ImageOnly;
            this.maximizeButton.Location = new System.Drawing.Point(1153, 1);
            this.maximizeButton.Margin = new System.Windows.Forms.Padding(1);
            this.maximizeButton.Name = "maximizeButton";
            this.maximizeButton.PressedColor = System.Drawing.Color.CornflowerBlue;
            this.maximizeButton.PressedForeColor = System.Drawing.Color.White;
            this.maximizeButton.Size = new System.Drawing.Size(33, 30);
            this.maximizeButton.TabIndex = 1;
            this.maximizeButton.Text = "maximizeButton";
            this.maximizeButton.Click += new System.EventHandler(this.MaximizeButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.BackColor = this.BackColor;
            this.closeButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.closeButton.BorderThickness = 3;
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.DrawBorder = false;
            this.closeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.closeButton.HotTrackColor = System.Drawing.Color.Gainsboro;
            this.closeButton.Image = global::ReaLTaiizor.Properties.Resources.Close;
            this.closeButton.LayoutFlags = ReaLTaiizor.Utils.RoyalLayoutFlags.ImageOnly;
            this.closeButton.Location = new System.Drawing.Point(1188, 1);
            this.closeButton.Margin = new System.Windows.Forms.Padding(1);
            this.closeButton.Name = "closeButton";
            this.closeButton.PressedColor = System.Drawing.Color.Crimson;
            this.closeButton.PressedForeColor = System.Drawing.Color.White;
            this.closeButton.Size = new System.Drawing.Size(33, 30);
            this.closeButton.TabIndex = 0;
            this.closeButton.Text = "closeButton";
            this.closeButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // RoyalForm
            // 
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(730, 429);
            this.Controls.Add(this.minimizeButton);
            this.Controls.Add(this.maximizeButton);
            this.Controls.Add(this.closeButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RoyalForm";
            this.Text = "RoyalForm";
            this.ResumeLayout(false);

        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MaximizeButton_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
                WindowState = FormWindowState.Normal;
            else
                WindowState = FormWindowState.Maximized;
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }

    #endregion
}