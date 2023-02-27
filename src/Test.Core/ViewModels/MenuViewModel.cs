using System;
using System.Collections.ObjectModel;
using MvvmCross.ViewModels;
using MvvmCross.Navigation;
using System.Threading.Tasks;
using MvvmCross.Commands;

namespace Test.Core.ViewModels
{
    public class MenuViewModel : MvxViewModel
    {
        private ObservableCollection<Item> _menuList;
        public ObservableCollection<Item> MenuList
        {
            get => _menuList;
            set => SetProperty(ref _menuList, value);
        }
        readonly IMvxNavigationService _navigationService = MvvmCross.Mvx.IoCProvider.Resolve<IMvxNavigationService>();
        public MenuViewModel(IMvxNavigationService navigationService)
        {
            _navigationService = navigationService;
            
        }

        public override async Task Initialize()
        {
            await base.Initialize();

            MenuList = new ObservableCollection<Item>()
            {
                new Item("Shop"),
                new Item("Contact Us")
            };

        }
        private IMvxAsyncCommand<Item> _shopCommand;
        public IMvxAsyncCommand<Item> ShopCommand
        {
            get
            {
                _shopCommand = new MvxAsyncCommand<Item>(ShopCommandAsync);
                return _shopCommand;
            }
        }

        private async Task ShopCommandAsync(Item param)
        {
            switch (param.Name)
            {
                case "Shop":
                    await _navigationService.Navigate<ShopViewModel>();
                    break;
                case "Contact Us":
                    await _navigationService.Navigate<ContactUsViewModel>();
                    break;
                default:
                    break;
            }
        }
    }
    public class Item
    {
        public Item(string name)
        {
            Name = name;
        }
        public string Name { get; set; }
    }
}

