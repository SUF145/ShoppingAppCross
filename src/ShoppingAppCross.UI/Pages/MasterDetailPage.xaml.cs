using MvvmCross.Forms.Presenters.Attributes;
using MvvmCross.Forms.Views;
using ShoppingAppCross.Core.ViewModels;
using Xamarin.Forms.Xaml;

namespace ShoppingAppCross.UI.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    [MvxMasterDetailPagePresentation(Position = MasterDetailPosition.Root, WrapInNavigationPage = false, Title = "Menu")]
    public partial class MasterDetailPage : MvxMasterDetailPage<MasterDetailViewModel>
    {    
        public MasterDetailPage ()
        {
            InitializeComponent();
        }
    }
}

