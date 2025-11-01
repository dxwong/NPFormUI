using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ReaLTaiizor
{
	[DefaultEvent("Click")]
	public class NButton : Control
	{
		private Color _NormaColor;
		private Color _HoverColor;
		private bool _IsShadow;


		public NButton(): base()
		{
			Size = new Size(80, 30);
			HoverColor = Color.FromArgb(56, 184, 0);
			NormaColor = Color.FromArgb(38, 181, 255);
			ForeColor = Color.White;
			SetStyles();
		}

		[Category("NPubControl"),
		Description("鼠标经过时背景颜色"),
		DefaultValue(typeof(Color), "#38B800")]
		public Color HoverColor
		{
			get { return _HoverColor; }
			set
			{
				_HoverColor = value;
				Invalidate();
			}
		}

		[Category("NPubControl"),
		Description("默认背景颜色"),
		DefaultValue(typeof(Color), "#42ADEC")]
		public Color NormaColor
		{
			get { return _NormaColor; }
			set
			{
				_NormaColor = value;
				BackColor = value;
				Invalidate();
			}
		}


		[Category("NPubControlEx"),
		Description("是否启用阴影")]
		public bool IsShadow
		{
			get { return _IsShadow; }
			set
			{
				if (value != _IsShadow)
				{
					Invalidate();
				}
				_IsShadow = value;
			}
		}

		[Category("NPubControl")]
		public override Image BackgroundImage
		{
			get
			{
				return base.BackgroundImage;
			}
			set
			{
				base.BackgroundImage = value;
			}
		}

		[Category("NPubControl")]
		public override ImageLayout BackgroundImageLayout
		{
			get
			{
				return base.BackgroundImageLayout;
			}
			set
			{
				base.BackgroundImageLayout = value;
			}
		}
		[Category("NPubControl")]
		public override Color BackColor
		{
			get
			{
				return base.BackColor;
			}
			set
			{
				base.BackColor = value;
			}
		}
		[Category("NPubControl")]
		public override string Text
		{
			get
			{
				return base.Text;
			}
			set
			{
				base.Text = value;
			}
		}

		[Category("NPubControl")]
		public override System.Drawing.Color ForeColor
		{
			get
			{
				return base.ForeColor;
			}
			set
			{
				base.ForeColor = value;
			}
		}
		protected override void OnMouseEnter(EventArgs e)
		{
			base.OnMouseEnter(e);
			BackColor = Enabled ? HoverColor : SystemColors.ControlDark;
		}

		protected override void OnMouseLeave(EventArgs e)
		{
			base.OnMouseLeave(e);
			BackColor = Enabled ? NormaColor : SystemColors.ControlDark;

		}

		protected override void OnClick(EventArgs e)
		{
			base.OnClick(e);
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);
			Color textColor = Enabled ? ForeColor : SystemColors.GrayText;
			using (SolidBrush sb = new SolidBrush(textColor))
			{
				StringFormat sf = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center };
				e.Graphics.DrawString(Text, Font, sb, ClientRectangle, sf);

				if (IsShadow)
				{
					var rec = ClientRectangle;
					rec.Height -= 1;
					rec.Y = rec.Height;
					rec.Height = 1;
					e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(50, 0, 0, 0)), rec);//阴影
				}
			}
		}

		/// <summary>
		/// 开启双缓冲，减少闪烁
		/// </summary>
		protected void SetStyles()
		{
			SetStyle(
				ControlStyles.UserPaint |
				ControlStyles.AllPaintingInWmPaint |
				ControlStyles.OptimizedDoubleBuffer |
				ControlStyles.ResizeRedraw |
				ControlStyles.DoubleBuffer |
				ControlStyles.SupportsTransparentBackColor, true);
			//强制分配样式重新应用到控件上
			UpdateStyles();
		}

	}
}