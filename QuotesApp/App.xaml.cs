using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using QuotesApp.Views;
using Unity;
using CommonServiceLocator;

namespace QuotesApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            var iocContainer = new UnityContainer();

            iocContainer.RegisterType<Interfaces.IQuotesService, Services.QuotesApiService>();

            ServiceLocator.SetLocatorProvider(() => new Unity.ServiceLocation.UnityServiceLocator(iocContainer));

            MainPage = new QuotesPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
