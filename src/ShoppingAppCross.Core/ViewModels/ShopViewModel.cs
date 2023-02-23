using System;
using System.Collections.ObjectModel;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;

namespace ShoppingAppCross.Core.ViewModels
{
    
    public class ShopViewModel : MvxViewModel
    {
        readonly IMvxNavigationService _navigationService;
        private ObservableCollection<string> _menuItemList;
        public ObservableCollection<string> MenuItemList
        {
            get => _menuItemList;
            set
            {
                SetProperty(ref _menuItemList, value);
            }
        }
        public ShopViewModel(IMvxNavigationService navigationService)
        {
            _navigationService = navigationService;
            MenuItemList = new MvxObservableCollection<string>()
            {
                "Shop",
                "Contact Us"
            };
        }
    }
}