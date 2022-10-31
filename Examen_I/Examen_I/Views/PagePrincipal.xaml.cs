using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Examen_I.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PagePrincipal : ContentPage
    {
        public PagePrincipal()
        {
            InitializeComponent();
        }
        protected async override void OnAppearing() 
        { 
              base.OnAppearing();
              ListContact.ItemsSource = await App.dbemple.listacontactos();

        }

        private async void ToolAdd_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Views.PageContact());

        }

        private async void ToolMap_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Views.PageMap());

        }

        private void ListContact_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}