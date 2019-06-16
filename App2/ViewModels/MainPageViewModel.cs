using Prism.Mvvm;

namespace App2.ViewModels
{
    public class MainPageViewModel : BindableBase
    {
        private string _markdownText;

        public string MarkdownText
        {
            get { return _markdownText; }
            set { this.SetProperty(ref _markdownText, value); }
        }
    }
}