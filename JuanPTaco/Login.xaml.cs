using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace JuanPTaco
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private async void btnAbrir_Clicked(object sender, EventArgs e)
        {
            try
            {
                string usuario = txtUsuario.Text;
                string password = txtPassword.Text;
                if (txtUsuario.Text == "juan2022" && txtPassword.Text == "uisrael2022")
                {
                    DisplayAlert("Bienvenido", txtUsuario.Text, "Cerrar");
                    await Navigation.PushAsync(new Registro(usuario, password));
                }
                else
                {
                    DisplayAlert("ALERTA", "Usuario o Password Incorrectos", "Cerrar");
                }
            }
            catch (Exception ex)
            {
                DisplayAlert("ERROR", ex.Message, "Cerrar");
            }

        }
    }
}