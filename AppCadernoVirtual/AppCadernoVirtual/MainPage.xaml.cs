using AppCadernoVirtual.Anos;
using AppCadernoVirtual.Anos.Primeiro;
using AppCadernoVirtual.Anos.Segundo;
using AppCadernoVirtual.Anos.Terceiro;
using AppCadernoVirtual.Primeiro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;


namespace AppCadernoVirtual
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

        }

        // evento de clique, que faz acesso (navegação) à página das matérias do primeiro ano
        private void Btn_Primeiro(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PrimeiroAno());
        }

        // evento de clique, que faz acesso à página das matérias do segundo ano
        private void Btn_Segundo(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SegundoAno());
        }

        // evento de clique, que faz acesso à página das matérias do terceiro ano
        private void Btn_Terceiro(object sender, EventArgs e)
        {
            Navigation.PushAsync(new TerceiroAno());
        }
    }
}
