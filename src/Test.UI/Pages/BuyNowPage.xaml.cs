using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MvvmCross.Forms.Presenters.Attributes;
using MvvmCross.Forms.Views;
using Test.Core.ViewModels;


namespace Test.UI.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    [MvxContentPagePresentation(WrapInNavigationPage = true)]
    public partial class BuyNowPage : MvxContentPage<BuyNowViewModel>
    {    
        public BuyNowPage ()
        {
            InitializeComponent ();
        }
    }
}

