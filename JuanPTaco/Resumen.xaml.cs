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
    public partial class Resumen : ContentPage
    {
        public Resumen(String usuario, String password, String nom, String tot)
        {
            InitializeComponent();
            lblUser.Text = usuario;
            lblPass.Text = password;
            lblNombres.Text = nom;
            lblTotalPagar.Text = tot;


        }
    }
}