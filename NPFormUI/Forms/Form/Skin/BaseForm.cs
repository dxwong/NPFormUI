using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;

namespace ReaLTaiizor
{
    public partial class BaseForm : FormMain
	{
		//BackForm backform;
		public BaseForm()
		{
			InitializeComponent();
            SetStyles();

			if (!DesignMode)
			{
				//backform = new BackForm(this);
			}
		}


		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);
			BackColor = Color.LightSteelBlue;
			RenderSkin();
			BindEvent();
			ChangeSysControl();
		}

		protected override void OnMouseDown(MouseEventArgs e)
		{
			base.OnMouseDown(e);
			ReaLTaiizor.NSkin.MoveWindow(this);
		}

		protected override void OnSizeChanged(EventArgs e)
		{
			base.OnSizeChanged(e);
			ChangeSysControl();
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);
			var g = e.Graphics;
			var x = 4;

			using (SolidBrush sb = new SolidBrush(_Skin.HeaderBackColor))
			{
                g.FillRectangle(sb, new Rectangle(0, 0, Width, _Skin.HeaderHeight));

                if (ShowIcon)
				{
					g.DrawIcon(Icon, new Rectangle(6, 6, 16, 16));//默认值 ICON位置
					x += 20;
				}
				g.SmoothingMode = SmoothingMode.AntiAlias; //使绘图质量最高，即消除锯齿
				g.InterpolationMode = InterpolationMode.HighQualityBicubic;
				g.CompositingQuality = CompositingQuality.HighQuality;
				g.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
				g.SmoothingMode = SmoothingMode.Default;
				g.InterpolationMode = InterpolationMode.Default;
				g.CompositingQuality = CompositingQuality.Default;
				g.DrawString(Text, new Font("微软雅黑", 10.5F), new SolidBrush(_Skin.TitleColor), x, 4);//默认值 标题栏字体位置
			}
		}

		protected override void OnClosing(CancelEventArgs e)
		{
			base.OnClosing(e);
			//if (backform != null)
			//{
			//    backform.Close();
			//}
		}

		public override string Text
		{
			get
			{
				return base.Text;
			}
			set
			{
				base.Text = value;
				Invalidate();
			}
		}

		/// <summary>
		/// 皮肤渲染回调函数（适用自定义窗体界面的时候用）
		/// </summary>
		public Func<NSkin, NSkin> RenderSkinCallback { get; set; }

		

        private NSkin _Skin;

		/// <summary>
		/// 渲染主题
		/// </summary>
		public void RenderSkin()
		{
			_Skin = NSkinHelper.NFormSkin.Clone();
			if (RenderSkinCallback != null)
			{
				RenderSkinCallback(_Skin);
			}

			Invalidate();
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
				ControlStyles.DoubleBuffer, true);
			//强制分配样式重新应用到控件上
			UpdateStyles();
			base.AutoScaleMode = AutoScaleMode.None;
		}

		/// <summary>
		/// 重置系统按钮位置
		/// </summary>
		protected void ChangeSysControl()
		{
			if (btnSysClose == null) return;
			btnSysClose.Top = 1;
			btnSysMax.Top = 1;
			btnSysMin.Top = 1;
			btnSysMenu.Top = 1;
			//btnSysMenu.Visible = false;

			var x = Width; 

			if (btnSysClose.Visible)
            {
                x -= btnSysClose.Width;
                btnSysClose.Left = x;
            }
			if (btnSysMax.Visible)
			{
				x -= btnSysMax.Width;
				btnSysMax.Left = x;
			}
			if (btnSysMin.Visible)
			{
				x -= btnSysMin.Width;
				btnSysMin.Left = x;
			}
			if (btnSysMenu.Visible)
			{
				x -= btnSysMenu.Width;
				btnSysMenu.Left = x;
			}
		}

		protected void BindEvent()
		{
			btnSysClose.Click += (s, e) =>
			{
				Close();
				//Application.Exit();
			};
			btnSysMax.MouseDown += (s, e) =>
			{
				if (e.Button == MouseButtons.Left)
				{
					this.ShowInTaskbar = true;
					if (this.WindowState == FormWindowState.Maximized)
					{
						this.WindowState = FormWindowState.Normal;
						btnSysMax.BackgroundImage = ReaLTaiizor.Properties.Resources.sysbtn_max_normal;
					}
					else
					{
						this.MaximumSize = new Size(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height);
						this.WindowState = FormWindowState.Maximized;
						btnSysMax.BackgroundImage = ReaLTaiizor.Properties.Resources.sysbtn_max_normal;
					}
				}
				if (e.Button == MouseButtons.Right)
				{
					this.ShowInTaskbar = true;
					if (this.WindowState == FormWindowState.Maximized)
					{
						this.WindowState = FormWindowState.Normal;
					}
					else
					{
						this.MaximumSize = new Size(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height + SystemInformation.WorkingArea.Height);
						this.WindowState = FormWindowState.Maximized;
					}
				}
			};
			btnSysMin.Click += (s, e) =>
			{
				WindowState = FormWindowState.Minimized;
				ShowInTaskbar = true;
			};
		}
	}
}
