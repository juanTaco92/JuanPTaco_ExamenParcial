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
    public partial class Registro : ContentPage
    {
        public Registro(String usuario, string password)
        {
            InitializeComponent();
            lblUser.Text = usuario;
            lblPass.Text = password;
        }

        private async void btnCalcular_Clicked(object sender, EventArgs e)
        {
            {
                try
                {
                    Decimal cuotaInicial = Decimal.Parse(txtCuotaInicial.Text);
                    if (cuotaInicial <= 3000)
                    {
                        string nombres = txtNombres.Text;                        
                        Decimal datoSubCuota = (3000 - cuotaInicial);
                        Decimal datoInteres = (3000 * 5)/100;
                        Decimal datoTotCuota = (datoSubCuota + datoInteres) / 5;
                        txtResultado.Text = datoTotCuota.ToString();


                    }
                    else
                    {
                        DisplayAlert("Error", "Cuota Inicial Mayor a $3000", "Cerrar");
                    }

                }
                catch (Exception ex)
                {
                    DisplayAlert("ERROR", ex.Message, "Cerrar");
                }
            }
        }

        private async void btnGuardar_Clicked(object sender, EventArgs e)
        {
            string nombres = txtNombres.Text;
            Decimal cuotaInicial = Decimal.Parse(txtCuotaInicial.Text);
            Decimal datoSubCuota = (3000 - cuotaInicial);
            Decimal datoInteres = (3000 * 5) / 100;
            Decimal totalPagar = (3000 + datoInteres);
            txtResultadoTotal.Text = totalPagar.ToString();

            DisplayAlert("Mensaje", "Elemento guardado con exito", "Cerrar");
            string user = lblUser.Text;
            string pass = lblPass.Text;
            string nombresenv = txtNombres.Text;
            string totalenv = txtResultadoTotal.Text;
            await Navigation.PushAsync(new Resumen(user, pass, nombresenv, totalenv));
        }
    }
}