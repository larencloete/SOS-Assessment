using I.C.E.Messages.Security;
using I.C.E.Models.Security;
using I.C.E.Services.Interfaces;
using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace I.C.E.ViewModels
{
    public class HomePageViewModel : ViewModelBase
    {
        private ISecurityService _securityService;
        private IEventAggregator _eventAggregator;

        private ObservableCollection<MenuItem> _menuItems;
        public ObservableCollection<MenuItem> MenuItems
        {
            get { return _menuItems; }
            set { SetProperty(ref _menuItems, value); }
        }
        public HomePageViewModel(INavigationService navigationService, ISecurityService securityService, IEventAggregator eventAggregator) : base(navigationService)
        {
            _securityService = securityService;
            _eventAggregator = eventAggregator;

            MenuItems = new ObservableCollection<MenuItem>(_securityService.GetAllowedAccessItems());
            _eventAggregator.GetEvent<LogOutMessage>().Subscribe(LogOutEvent);
        }

        private void LogOutEvent()
        {
            throw new NotImplementedException();
        }
    }
}
