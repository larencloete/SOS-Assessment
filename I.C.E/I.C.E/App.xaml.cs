using Prism;
using Prism.Ioc;
using I.C.E.ViewModels;
using I.C.E.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using I.C.E.Services.Interfaces;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace I.C.E
{
    public partial class App
    {
        /* 
         * The Xamarin Forms XAML Previewer in Visual Studio uses System.Activator.CreateInstance.
         * This imposes a limitation in which the App class must have a default constructor. 
         * App(IPlatformInitializer initializer = null) cannot be handled by the Activator.
         */
        public App() : this(null) { }

        public App(IPlatformInitializer initializer) : base(initializer) { }

        protected override async void OnInitialized()
        {
            InitializeComponent();

            await NavigationService.NavigateAsync("NavigationPage/SignupORLoginPage");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)

        {
            containerRegistry.RegisterSingleton<ISecurityService, SecurityService>();

            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<MainPage, MainPageViewModel>();
            containerRegistry.RegisterForNavigation<SignupORLoginPage, SignupORLoginPageViewModel>();
            containerRegistry.RegisterForNavigation<LoginPage, LoginPageViewModel>();
            containerRegistry.RegisterForNavigation<SignupPage, SignupPageViewModel>();
            containerRegistry.RegisterForNavigation<HomePage, HomePageViewModel>();
            containerRegistry.RegisterForNavigation<CentrePage, CentrePageViewModel>();
            containerRegistry.RegisterForNavigation<My_Contacts, My_ContactsViewModel>();
            containerRegistry.RegisterForNavigation<Map, MapViewModel>();
            containerRegistry.RegisterForNavigation<AboutPage, AboutPageViewModel>();

            containerRegistry.RegisterForNavigation<LogOutPage, LogOutPageViewModel>();
            containerRegistry.RegisterForNavigation<HomePage1, HomePage1ViewModel>();
        }
    }
}
