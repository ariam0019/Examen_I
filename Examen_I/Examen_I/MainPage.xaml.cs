using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Examen_I
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnAgregar_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Aviso", txtnombres.Text + " " + txtapellidos.Text, "OK");

        }

        private async void btnSegunda_Clicked(object sender, EventArgs e)
        {
            var emple = new Models.Contactos
            {
                nombres = txtnombres.Text,
                apellidos = txtapellidos.Text,
                edad = Convert.ToInt32(txtedad.Text),
                pais = txtpais.Text,
                nota = txtnota.Text,    
            };
            var page = new Views.PageTwo();
            page.BindingContext = emple;
            await Navigation.PushAsync(page);
        }
    }
}
