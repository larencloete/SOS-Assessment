using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace I.C.E.ViewModels
{
    public class LoginPageViewModel : ViewModelBase
    {

        private string _title;
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        private INavigationService _navigationService;
        private DelegateCommand _navigateCommand;
        public DelegateCommand NavigateCommand =>
            _navigateCommand ?? (_navigateCommand = new DelegateCommand(ExecuteNavigateLoginCommand));

        private async void ExecuteNavigateLoginCommand()
        {
            //await NavigationService.NavigateAsync("HomePage/NavigationPage/SignupORLoginPage", useModalNavigation: true);
            await _navigationService.NavigateAsync("NavigationPage/HomePage1");
        }

        //private async void ExecuteNavigateLoginCommand()
        //{
        //    await _navigationService.NavigateAsync("HomePage/NavigationPage/SignupORLoginPage", useModalNavigation: true);
        //}

        public LoginPageViewModel(INavigationService navigationService ) :base(navigationService)
        {
            Title = "LoginPage";
            _navigationService = navigationService;

        }
    }
}
