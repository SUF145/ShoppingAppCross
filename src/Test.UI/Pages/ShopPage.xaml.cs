using Xamarin.Forms.Xaml;
using MvvmCross.Forms.Presenters.Attributes;
using MvvmCross.Forms.Views;
using Test.Core.ViewModels;

namespace Test.UI.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    [MvxMasterDetailPagePresentation(Position = MasterDetailPosition.Detail, NoHistory = true, Title = "Display Page")]
    public partial class ShopPage : MvxContentPage<ShopViewModel>
    {
        
        public ShopPage ()
        {
            InitializeComponent ();
        }
    }
}