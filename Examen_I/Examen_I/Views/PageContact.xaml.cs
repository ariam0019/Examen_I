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
    public partial class PageContact : ContentPage
    {
        public PageContact()
        {
            InitializeComponent();
        }

        private async void btnAgregar_Clicked(object sender, EventArgs e)
        {
            var emple = new Models.Contactos
            {
                Id = Convert.ToInt32(txtcodigo.Text),
                nombres = txtnombres.Text,
                apellidos = txtapellidos.Text,
                edad=Convert.ToInt32(txtedad.Text),
                pais = pickerCountry.SelectedItem.ToString(),
                nota = txtnota.Text,
            };
            if (await App.dbemple.Storecontactos(emple) > 0)
                await DisplayAlert("Aviso", "Registro Ingresado con exito !!", "OK");
                await DisplayAlert("Aviso", "Debe escribir un nombre !!", "OK");
                await DisplayAlert("Aviso", "Debe escribir un telefono !!", "OK");
                await DisplayAlert("Aviso", "Debe escribir un nombre !!", "OK");
        }
    }
}