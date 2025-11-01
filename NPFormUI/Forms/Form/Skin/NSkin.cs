using System;
using System.Drawing;
using System.Windows.Forms;

namespace ReaLTaiizor
{
    #region 圆角路径的样式
    /// <summary>
    /// 圆角路径的样式
    /// </summary>
    public enum RoundStyle
    {
        /// <summary>
        /// 四个角都不是圆角。
        /// </summary>
        None = 0,
        /// <summary>
        /// 四个角都为圆角。
        /// </summary>
        All = 1,
        /// <summary>
        /// 左边两个角为圆角。
        /// </summary>
        Left = 2,
        /// <summary>
        /// 右边两个角为圆角。
        /// </summary>
        Right = 3,
        /// <summary>
        /// 上边两个角为圆角。
        /// </summary>
        Top = 4,
        /// <summary>
        /// 下边两个角为圆角。
        /// </summary>
        Bottom = 5,
        /// <summary>
        /// 左下角为圆角。
        /// </summary>
        BottomLeft = 6,
        /// <summary>
        /// 右下角为圆角。
        /// </summary>
        BottomRight = 7,
    } 
    #endregion


    [Serializable]
	public class NSkin : IDisposable
	{
        #region 属性
        /// <summary>
        /// 标题颜色
        /// </summary>
        public Color TitleColor { get; set; }

        /// <summary>
        /// 头部背景颜色
        /// </summary>
        public Color HeaderBackColor { get; set; }

        /// <summary>
        /// 头部背景图片
        /// </summary>
        public Image HeaderBackgroundImage { get; set; }

		/// <summary>
		/// 头部高度 默认值
		/// </summary>
		int _HeaderHeight = 29;

		public int HeaderHeight
		{
			get { return _HeaderHeight; }
			set { _HeaderHeight = value; }
		}
		#endregion

		public NSkin(): base()
		{
            TitleColor = Color.White;
            HeaderHeight = _HeaderHeight;
            HeaderBackColor = Color.FromArgb(65, 81, 104);
		}

		public void Dispose()
		{

		}

		/// <summary>
		/// 克隆对象
		/// </summary>
		/// <returns></returns>
		public NSkin Clone()
		{
			var newobj = new NSkin();
            newobj.HeaderBackColor = this.HeaderBackColor;
            newobj.HeaderHeight = this.HeaderHeight;
			newobj.TitleColor = this.TitleColor;
			return newobj;
		}

		/// <summary>
		/// 移动窗体
		/// </summary>
		public static void MoveWindow(Form form)
		{
			Win32.ReleaseCapture();
			Win32.SendMessage(form.Handle, Win32.WM_NCLBUTTONDOWN, Win32.HTCAPTION, 0);
		}

		/// <summary>
		/// 利用九宫图绘制图像
		/// </summary>
		/// <param name="g">绘图对象</param>
		/// <param name="img">所需绘制的图片</param>
		/// <param name="targetRect">目标矩形</param>
		/// <param name="srcRect">来源矩形</param>
		public static void DrawImageWithNineRect(Graphics g, Image img, Rectangle targetRect, Rectangle srcRect)
		{
			int offset = 5;
			Rectangle NineRect = new Rectangle(img.Width / 2 - offset, img.Height / 2 - offset, 2 * offset, 2 * offset);
			int x = 0, y = 0, nWidth, nHeight;
			int xSrc = 0, ySrc = 0, nSrcWidth, nSrcHeight;
			int nDestWidth, nDestHeight;
			nDestWidth = targetRect.Width;
			nDestHeight = targetRect.Height;
			// 左上-------------------------------------;
			x = targetRect.Left;
			y = targetRect.Top;
			nWidth = NineRect.Left - srcRect.Left;
			nHeight = NineRect.Top - srcRect.Top;
			xSrc = srcRect.Left;
			ySrc = srcRect.Top;
			g.DrawImage(img, new Rectangle(x, y, nWidth, nHeight), xSrc, ySrc, nWidth, nHeight, GraphicsUnit.Pixel);
			// 上-------------------------------------;
			x = targetRect.Left + NineRect.Left - srcRect.Left;
			nWidth = nDestWidth - nWidth - (srcRect.Right - NineRect.Right);
			xSrc = NineRect.Left;
			nSrcWidth = NineRect.Right - NineRect.Left;
			nSrcHeight = NineRect.Top - srcRect.Top;
			g.DrawImage(img, new Rectangle(x, y, nWidth, nHeight), xSrc, ySrc, nSrcWidth, nSrcHeight, GraphicsUnit.Pixel);
			// 右上-------------------------------------;
			x = targetRect.Right - (srcRect.Right - NineRect.Right);
			nWidth = srcRect.Right - NineRect.Right;
			xSrc = NineRect.Right;
			g.DrawImage(img, new Rectangle(x, y, nWidth, nHeight), xSrc, ySrc, nWidth, nHeight, GraphicsUnit.Pixel);
			// 左-------------------------------------;
			x = targetRect.Left;
			y = targetRect.Top + NineRect.Top - srcRect.Top;
			nWidth = NineRect.Left - srcRect.Left;
			nHeight = targetRect.Bottom - y - (srcRect.Bottom - NineRect.Bottom);
			xSrc = srcRect.Left;
			ySrc = NineRect.Top;
			nSrcWidth = NineRect.Left - srcRect.Left;
			nSrcHeight = NineRect.Bottom - NineRect.Top;
			g.DrawImage(img, new Rectangle(x, y, nWidth, nHeight), xSrc, ySrc, nSrcWidth, nSrcHeight, GraphicsUnit.Pixel);
			// 中-------------------------------------;
			x = targetRect.Left + NineRect.Left - srcRect.Left;
			nWidth = nDestWidth - nWidth - (srcRect.Right - NineRect.Right);
			xSrc = NineRect.Left;
			nSrcWidth = NineRect.Right - NineRect.Left;
			g.DrawImage(img, new Rectangle(x, y, nWidth, nHeight), xSrc, ySrc, nSrcWidth, nSrcHeight, GraphicsUnit.Pixel);

			// 右-------------------------------------;
			x = targetRect.Right - (srcRect.Right - NineRect.Right);
			nWidth = srcRect.Right - NineRect.Right;
			xSrc = NineRect.Right;
			nSrcWidth = srcRect.Right - NineRect.Right;
			g.DrawImage(img, new Rectangle(x, y, nWidth, nHeight), xSrc, ySrc, nSrcWidth, nSrcHeight, GraphicsUnit.Pixel);

			// 左下-------------------------------------;
			x = targetRect.Left;
			y = targetRect.Bottom - (srcRect.Bottom - NineRect.Bottom);
			nWidth = NineRect.Left - srcRect.Left;
			nHeight = srcRect.Bottom - NineRect.Bottom;
			xSrc = srcRect.Left;
			ySrc = NineRect.Bottom;
			g.DrawImage(img, new Rectangle(x, y, nWidth, nHeight), xSrc, ySrc, nWidth, nHeight, GraphicsUnit.Pixel);
			// 下-------------------------------------;
			x = targetRect.Left + NineRect.Left - srcRect.Left;
			nWidth = nDestWidth - nWidth - (srcRect.Right - NineRect.Right);
			xSrc = NineRect.Left;
			nSrcWidth = NineRect.Right - NineRect.Left;
			nSrcHeight = srcRect.Bottom - NineRect.Bottom;
			g.DrawImage(img, new Rectangle(x, y, nWidth, nHeight), xSrc, ySrc, nSrcWidth, nSrcHeight, GraphicsUnit.Pixel);
			// 右下-------------------------------------;
			x = targetRect.Right - (srcRect.Right - NineRect.Right);
			nWidth = srcRect.Right - NineRect.Right;
			xSrc = NineRect.Right;
			g.DrawImage(img, new Rectangle(x, y, nWidth, nHeight), xSrc, ySrc, nWidth, nHeight, GraphicsUnit.Pixel);
		}
	}

}
