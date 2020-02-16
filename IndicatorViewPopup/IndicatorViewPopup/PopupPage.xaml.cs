using IndicatorViewPopup.ViewModels;
using Xamarin.Forms.Xaml;

namespace IndicatorViewPopup
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PopupPage : Rg.Plugins.Popup.Pages.PopupPage
    {
        private PopupViewModel viewModel;

        public PopupPage(PopupViewModel vm)
        {
            InitializeComponent();
            viewModel = vm;
            BindingContext = viewModel;
        }
    }
}