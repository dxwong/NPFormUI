using System.Drawing;
using System.Windows.Forms;

namespace ReaLTaiizor
{
	/// <summary>
	/// 窗体自绘辅助类
	/// </summary>
	public class NSkinHelper
	{
		private static NSkin _JFormSkin;

		/// <summary>
		/// 窗体主题对象
		/// </summary>
		public static NSkin NFormSkin
		{
			get
			{
				if (_JFormSkin == null) _JFormSkin = new NSkin();
				return _JFormSkin;
			}
		}

	}
}
