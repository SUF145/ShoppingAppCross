using System;
using System.Collections.Generic;

using Xamarin.Forms;
using MvvmCross.Forms.Views;
using Test.Core.ViewModels;
using MvvmCross.Forms.Presenters.Attributes;
using Xamarin.Forms.Xaml;

namespace Test.UI.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    [MvxMasterDetailPagePresentation(Position = MasterDetailPosition.Master, WrapInNavigationPage = false, Title = "Menu")]
    public partial class MenuPage : MvxContentPage<MenuViewModel>
    {    
        public MenuPage ()
        {
            InitializeComponent();
        }
    }
}

