using GalaSoft.MvvmLight;

namespace ContentWithOptionalDP
{
    public class MainWindowViewModel : ViewModelBase
    {
        private object _content;

        public void SetContent(object content)
        {
            _content = content;
        }

    }
}
