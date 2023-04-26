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
    public partial class Resumen : ContentPage
    {
        public Resumen(string nombre, string montoInicial, string pagoMensual, string usuario)
        {
            
            InitializeComponent();
            lblUsuario.Text = usuario;
            lblNombre.Text = nombre;
            lblMinicial.Text = montoInicial;
            lblPagoMensual.Text = pagoMensual;
            double total = 0;
            total = Convert.ToDouble(pagoMensual)*3 + Convert.ToDouble(montoInicial);
            lblTotal.Text = total.ToString();
            
        }
    }
}