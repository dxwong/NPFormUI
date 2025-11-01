using System.Drawing;
using System.Windows.Forms;

namespace ReaLTaiizor.UI
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void materialButton1_Click(object sender, System.EventArgs e)
        {
            // 循环切换到下一个主题
            currentTheme = (ThemeStyle)(((int)currentTheme + 1) % 5);
            ApplyTheme(currentTheme);
        }

        private void ApplyTheme(ThemeStyle theme)
        {
            switch (theme)
            {
                case ThemeStyle.FinancialBlueGold:
                    // 金融深蓝金配色
                    nightForm1.BackColor = Color.FromArgb(13, 28, 55);
                    nightForm1.HeadColor = Color.FromArgb(20, 40, 80);
                    nightForm1.TitleBarTextColor = Color.FromArgb(212, 175, 55);
                    nightForm1.Text = "金融深蓝金主题";
                    materialButton1.Text = "切换主题 - 金融蓝金";
                    break;

                case ThemeStyle.ModernTechBlue:
                    // 现代科技蓝配色
                    nightForm1.BackColor = Color.FromArgb(25, 35, 45);
                    nightForm1.HeadColor = Color.FromArgb(35, 50, 65);
                    nightForm1.TitleBarTextColor = Color.FromArgb(70, 150, 230);
                    nightForm1.Text = "现代科技蓝主题";
                    materialButton1.Text = "切换主题 - 科技蓝";
                    break;

                case ThemeStyle.LuxuryBlackGold:
                    // 奢华黑金配色
                    nightForm1.BackColor = Color.FromArgb(18, 18, 18);
                    nightForm1.HeadColor = Color.FromArgb(30, 30, 30);
                    nightForm1.TitleBarTextColor = Color.FromArgb(255, 215, 0);
                    nightForm1.Text = "奢华黑金主题";
                    materialButton1.Text = "切换主题 - 奢华金";
                    break;

                case ThemeStyle.ProfessionalNavy:
                    // 专业海军蓝配色
                    nightForm1.BackColor = Color.FromArgb(0, 32, 74);
                    nightForm1.HeadColor = Color.FromArgb(0, 48, 105);
                    nightForm1.TitleBarTextColor = Color.FromArgb(173, 216, 230);
                    nightForm1.Text = "专业海军蓝主题";
                    materialButton1.Text = "切换主题 - 海军蓝";
                    break;

                case ThemeStyle.ElegantCharcoal:
                    // 优雅炭灰配色
                    nightForm1.BackColor = Color.FromArgb(40, 44, 52);
                    nightForm1.HeadColor = Color.FromArgb(58, 63, 74);
                    nightForm1.TitleBarTextColor = Color.FromArgb(171, 178, 191);
                    nightForm1.Text = "优雅炭灰主题";
                    materialButton1.Text = "切换主题 - 优雅灰";
                    break;
            }

            // 刷新窗体
            nightForm1.Invalidate();
        }
        private enum ThemeStyle
        {
            FinancialBlueGold,    // 金融深蓝金
            ModernTechBlue,       // 现代科技蓝
            LuxuryBlackGold,      // 奢华黑金
            ProfessionalNavy,     // 专业海军蓝
            ElegantCharcoal       // 优雅炭灰
        }

        private ThemeStyle currentTheme = ThemeStyle.FinancialBlueGold;
    }
}