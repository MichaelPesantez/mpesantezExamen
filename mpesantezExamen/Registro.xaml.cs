using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace mpesantezExamen
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Registro : ContentPage
    {
        public Registro(string usuario)
        {
            InitializeComponent();
            lblUsuario.Text = usuario;
        }

        private void txtMinicial_TextChanged(object sender, TextChangedEventArgs e)
        {
            double montoInicial = 0;
            if (txtMinicial.Text != "")
            {
                montoInicial = Convert.ToDouble(txtMinicial.Text);
                if (montoInicial<0 || montoInicial>=3000)
                {
                    DisplayAlert("Mensaje de Alerta", "El monto Incial esta mal Ingresado", "Cerrar");
                    txtMinicial.Text = null;
                    txtMinicial.Focus();
                }
            }
        }

        private void btnPagoMensual_Clicked(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || txtNombre.Text == null)
            {
                DisplayAlert("Mensaje de Alerta", "Ingrese el nombre por favor", "Cerrar");
            }
            else
            {
                if (txtMinicial.Text == "" || txtMinicial.Text == null)
                {
                    DisplayAlert("Mensaje de Alerta", "Ingrese el monto inicial", "Cerrar");
                }
                else 
                {
                    double montoInicial = Convert.ToDouble(txtMinicial.Text);
                    double cuotaMensual = ((3000*1.05)-montoInicial)/3;
                    txtPagoMensual.Text = Math.Round(cuotaMensual, 2).ToString();
                }
            }
        }

        private void btnGuardar_Clicked(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string montoInicial = txtMinicial.Text;
            string pagoMensual = txtPagoMensual.Text;
            string usuario = lblUsuario.Text;
            Navigation.PushAsync(new Resumen(nombre, montoInicial, pagoMensual, usuario));
        }
    }
}