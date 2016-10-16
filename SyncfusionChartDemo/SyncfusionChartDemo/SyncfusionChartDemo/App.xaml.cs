using SyncfusionChartDemo.PageModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace SyncfusionChartDemo
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            var demoPage = FreshMvvm.FreshPageModelResolver.ResolvePageModel<ChartPageModel>();
            var navContainer = new FreshMvvm.FreshNavigationContainer(demoPage);
            MainPage = navContainer;
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
