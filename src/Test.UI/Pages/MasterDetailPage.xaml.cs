using MvvmCross.Forms.Presenters.Attributes;
using MvvmCross.Forms.Views;
using Test.Core.ViewModels;
using Xamarin.Forms.Xaml;

namespace Test.UI.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    [MvxMasterDetailPagePresentation(Position = MasterDetailPosition.Root, WrapInNavigationPage = false, Title = "<Menu")]
    public partial class MasterDetailPage : MvxMasterDetailPage<MasterDetailViewModel>
    {
        public MasterDetailPage ()
        {
            InitializeComponent();
        }
    }
}

