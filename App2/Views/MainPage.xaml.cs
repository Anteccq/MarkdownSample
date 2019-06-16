using Windows.System;
using Windows.UI.Xaml.Controls;

// 空白ページの項目テンプレートについては、https://go.microsoft.com/fwlink/?LinkId=234238 を参照してください

namespace App2.Views
{
    /// <summary>
    /// それ自体で使用できる空白ページまたはフレーム内に移動できる空白ページ。
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            this.RawText.PreviewKeyDown += (a, e) =>
            {
                if (e.Key == VirtualKey.Tab)
                {
                    var caretPos = RawText.SelectionStart;
                    RawText.Text = RawText.Text.Insert(caretPos, "\t");
                    RawText.SelectionStart = caretPos + "\t".Length + 1;
                    e.Handled = true;
                }
            };
        }
    }
}
