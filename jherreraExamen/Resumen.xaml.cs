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
    public partial class Resumen : ContentPage
    {
        string usuario;
        public Resumen(string usuario, string nombre, string apellido, string edad, string fecha, string ciudad, string pais, string MontoI, string PagoM)
        {
            InitializeComponent();
            this.usuario = usuario;
            lblUsuario.Text = "Usuario Conectado: " + usuario;
            this.usuario = usuario;
            txtNombre.Text = nombre;
            txtApellido.Text = apellido;
            txtEdad.Text = edad;
            txtFecha.Text = fecha;
            txtCiudad.Text = ciudad;
            txtPais.Text = pais;
            txtPagoM.Text = PagoM;
            txtMontoI.Text = MontoI;
        }
    }
}