using MasterMenuSample.Models;
using MasterMenuSample.ViewModels;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MasterMenuSample.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : MasterDetailPage
    {
        public MainPage()
        {
            InitializeComponent();
            this.Title = "master";
            BindingContext = new MainPageViewModel();
            MessagingCenter.Subscribe<MasterMenu>(this, "OpenMenu", (Menu) =>
              {
                  this.Detail = new NavigationPage((Page)Activator.CreateInstance(Menu.TargetType));
                  IsPresented = false;
              });
        }
    }
}