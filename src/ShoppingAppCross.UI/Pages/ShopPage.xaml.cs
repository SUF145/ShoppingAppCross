using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MvvmCross.Forms.Presenters.Attributes;
using MvvmCross.Forms.Views;
using ShoppingAppCross.Core.ViewModels;

namespace ShoppingAppCross.UI.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    [MvxMasterDetailPagePresentation(Position = MasterDetailPosition.Master, WrapInNavigationPage = false, Title = "Menu")]
    public partial class ShopPage : MvxContentPage<ShopViewModel>
    {    
        public ShopPage ()
        {
            InitializeComponent();
        }
    }
}

