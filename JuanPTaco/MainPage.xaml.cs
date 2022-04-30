using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace JuanPTaco
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnIniciar_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Mensaje", "Bienvenido al examen, Parcial 1", "Cerrar");
            await Navigation.PushAsync(new Login());
        }
    }
}
