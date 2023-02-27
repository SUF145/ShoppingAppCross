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
    [MvxMasterDetailPagePresentation(Position = MasterDetailPosition.Detail, NoHistory = true, Title = "Contact Us Page")]
    public partial class ContactUsPage : MvxContentPage<ContactUsViewModel>
    {    
        public ContactUsPage ()
        {
            InitializeComponent ();
        }
    }
}