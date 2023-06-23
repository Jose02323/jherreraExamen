using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace jherreraExamen
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Registro : ContentPage
    {
        string usuario;
        public Registro(string usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            lblUsuario.Text = "Usuario Conectado: " + usuario;
            this.usuario=usuario;
        }

        private void btnPagoM_Clicked(object sender, EventArgs e)
        {
            double valor1 = (Convert.ToInt32(txtMontoInicial.Text) - 1500);
            double valor2 = (Convert.ToInt32(valor1) / 4);
            double valor3 = (Convert.ToInt32(valor2) * 0.4);
            double valor4 = (Convert.ToInt32(valor3) + valor2);
            double valor5 = (Convert.ToInt32(valor4) * -1);
            txtPagoMensual.Text = valor5.ToString();
        }

        private void btnResumen_Clicked(object sender, EventArgs e)
        {
            //Navigation.PushAsync(new Resumen(usuario, txtNombre, pkPais, pkCiudad, dpFecha, txtApellido, txtEdad, txtMontoInicial, txtPagoMensual));
        }
    }
}