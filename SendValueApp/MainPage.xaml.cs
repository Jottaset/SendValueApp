using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SendValueApp
{
    public partial class MainPage : ContentPage
    {
        void Calcular(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new PageCalc(valor_01.Text, valor_02.Text));
        }

        public MainPage()
        {
            InitializeComponent();
        }
    }
}
