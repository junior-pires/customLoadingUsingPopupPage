using Rg.Plugins.Popup.Extensions;
using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Rg.Plugins.Popup.Services;
using System.Threading.Tasks;

namespace customLoading.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            var page = new popup();
            await PopupNavigation.Instance.PushAsync(page);
            await Task.Delay(3000);
            await PopupNavigation.Instance.PopAsync();
        }
    }
}