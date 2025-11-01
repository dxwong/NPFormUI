#region Imports

using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

#endregion

namespace ReaLTaiizor.Controls
{
    #region AirTabPage

    public class AirTabPage : System.Windows.Forms.TabControl
    {

        public AirTabPage()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.ResizeRedraw | ControlStyles.UserPaint | ControlStyles.DoubleBuffer, true);
            DoubleBuffered = true;
            SizeMode = TabSizeMode.Fixed;
            ItemSize = new Size(30, 115);
        }
        protected override void CreateHandle()
        {
            base.CreateHandle();
            Alignment = TabAlignment.Left;
        }

        Color _SquareColor = Color.FromArgb(78, 87, 100);
        public Color SquareColor
        {
            get { return _SquareColor; }
            set
            {
                _SquareColor = value;
                Invalidate();
            }
        }

        Color _ActiveColor = Color.DarkGray;

        [Category("Colors")]
        public Color ActiveColor
        {
            get { return _ActiveColor; }
            set { _ActiveColor = value; }
        }

        int _Squarewith = 2;
        public int Squarewith
        {
            get { return _Squarewith; }
            set
            {
                _Squarewith = value;
                Invalidate();
            }
        }

        public Color BgColor
        {
            get { return _BGColor; }
            set { _BGColor = value; }
        }


        [Category("Colors")]
        public Color BaseColor
        {
            get { return _BaseColor; }
            set { _BaseColor = value; }
        }

        bool OB = false;
        public bool ShowOuterBorders
        {
            get { return OB; }
            set
            {
                OB = value;
                Invalidate();
            }
        }
        private Color _BGColor = Color.FromArgb(60, 70, 73);
        private Color _BaseColor = Color.FromArgb(45, 47, 49);

        protected override void OnPaint(PaintEventArgs e)
        {
            Bitmap B = new Bitmap(Width, Height);
            Graphics G = Graphics.FromImage(B);
            try
            {
                SelectedTab.BackColor = Color.White;
            }
            catch
            {
            }
            G.Clear(_BaseColor);

            try
            {
                SelectedTab.BackColor = _BGColor;
            }
            catch
            {
            }

            for (int i = 0; i <= TabCount - 1; i++)
            {
                Rectangle x2 = new Rectangle(new Point(GetTabRect(i).Location.X - 2, GetTabRect(i).Location.Y - 2), new Size(GetTabRect(i).Width + 3, GetTabRect(i).Height - 1));
                Rectangle textrectangle = new Rectangle(x2.Location.X + 20, x2.Location.Y, x2.Width, x2.Height);
                Rectangle textrectangle2 = new Rectangle(x2.Location.X+ _Squarewith, x2.Location.Y, x2.Width- _Squarewith, x2.Height);
                if (i == SelectedIndex)
                {
                    G.FillRectangle(new SolidBrush(_BaseColor), textrectangle);

                    G.FillRectangle(new SolidBrush(_ActiveColor), textrectangle2);

                    G.FillRectangle(new SolidBrush(_SquareColor), new Rectangle(x2.Location, new Size(_Squarewith, x2.Height)));

                    if (ImageList != null)
                    {
                        try
                        {
                            if (ImageList.Images[TabPages[i].ImageIndex] != null)
                            {
                                G.DrawImage(ImageList.Images[TabPages[i].ImageIndex], new Point(textrectangle.Location.X + 8, textrectangle.Location.Y + 6));
                                G.DrawString("      " + TabPages[i].Text, Font, Brushes.Black, textrectangle, new StringFormat
                                {
                                    LineAlignment = StringAlignment.Center,
                                    Alignment = StringAlignment.Near
                                });
                            }
                            else
                            {
                                G.DrawString(TabPages[i].Text, Font, Brushes.Black, textrectangle, new StringFormat
                                {
                                    LineAlignment = StringAlignment.Center,
                                    Alignment = StringAlignment.Near
                                });
                            }
                        }
                        catch
                        {
                            G.DrawString(TabPages[i].Text, Font, Brushes.Black, textrectangle, new StringFormat
                            {
                                LineAlignment = StringAlignment.Center,
                                Alignment = StringAlignment.Near
                            });
                        }
                    }
                    else
                    {
                        G.DrawString(TabPages[i].Text, Font, Brushes.Black, textrectangle, new StringFormat
                        {
                            LineAlignment = StringAlignment.Center,
                            Alignment = StringAlignment.Near
                        });
                    }

                }
                else
                {
                    if (ImageList != null)
                    {
                        try
                        {
                            if (ImageList.Images[TabPages[i].ImageIndex] != null)
                            {
                                G.DrawImage(ImageList.Images[TabPages[i].ImageIndex], new Point(textrectangle.Location.X + 8, textrectangle.Location.Y + 6));
                                G.DrawString("      " + TabPages[i].Text, Font, Brushes.DimGray, textrectangle, new StringFormat
                                {
                                    LineAlignment = StringAlignment.Center,
                                    Alignment = StringAlignment.Near
                                });
                            }
                            else
                            {
                                G.DrawString(TabPages[i].Text, Font, Brushes.DimGray, textrectangle, new StringFormat
                                {
                                    LineAlignment = StringAlignment.Center,
                                    Alignment = StringAlignment.Near
                                });
                            }
                        }
                        catch
                        {
                            G.DrawString(TabPages[i].Text, Font, Brushes.DimGray, textrectangle, new StringFormat
                            {
                                LineAlignment = StringAlignment.Center,
                                Alignment = StringAlignment.Near
                            });
                        }
                    }
                    else
                    {
                        G.DrawString(TabPages[i].Text, Font, Brushes.DimGray, textrectangle, new StringFormat
                        {
                            LineAlignment = StringAlignment.Center,
                            Alignment = StringAlignment.Near
                        });
                    }
                }
            }

            e.Graphics.DrawImage((Image)B.Clone(), 0, 0);
            G.Dispose();
            B.Dispose();
        }
    }

    #endregion
}