using System;
using AppCadernoVirtual.Anos.Terceiro;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppCadernoVirtual.Anos.Terceiro
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TerceiroAno : ContentPage
    {
        public TerceiroAno()
        {
            InitializeComponent();


            BtnArtes.Source = ImageSource.FromResource("AppCadernoVirtual.Imagens.5.png");
            BtnBiologia.Source = ImageSource.FromResource("AppCadernoVirtual.Imagens.11.png");
            BtnFilosofia.Source = ImageSource.FromResource("AppCadernoVirtual.Imagens.7.png");
            BtnFisica.Source = ImageSource.FromResource("AppCadernoVirtual.Imagens.9.png");
            BtnGeografia.Source = ImageSource.FromResource("AppCadernoVirtual.Imagens.4.png");
            BtnHistoria.Source = ImageSource.FromResource("AppCadernoVirtual.Imagens.3.png");
            BtnIngles.Source = ImageSource.FromResource("AppCadernoVirtual.Imagens.8.png");
            BtnMatematica.Source = ImageSource.FromResource("AppCadernoVirtual.Imagens.1.png");
            BtnPortugues.Source = ImageSource.FromResource("AppCadernoVirtual.Imagens.2.png");
            BtnQuimica.Source = ImageSource.FromResource("AppCadernoVirtual.Imagens.10.png");
            BtnSociologia.Source = ImageSource.FromResource("AppCadernoVirtual.Imagens.6.png");

        }

        private void Btn_Artes(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ArtesTerceiro());
        }

        private void Btn_Biologia(object sender, EventArgs e)
        {
            Navigation.PushAsync(new BiologiaTerceiro());
        }

        private void Btn_Filosofia(object sender, EventArgs e)
        {
            Navigation.PushAsync(new FilosofiaTerceiro());
        }

        private void Btn_Fisica(object sender, EventArgs e)
        {
            Navigation.PushAsync(new FisicaTerceiro());
        }

        private void Btn_Geografia(object sender, EventArgs e)
        {
            Navigation.PushAsync(new GeografiaTerceiro());
        }

        private void Btn_Historia(object sender, EventArgs e)
        {
            Navigation.PushAsync(new HistoriaTerceiro());
        }

        private void Btn_Ingles(object sender, EventArgs e)
        {
            Navigation.PushAsync(new InglesTerceiro());
        }
        private void Btn_Matematica(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MatematicaTerceiro());
        }

        private void Btn_Portugues(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PortuguesTerceiro());
        }

        private void Btn_Quimica(object sender, EventArgs e)
        {
            Navigation.PushAsync(new QuimicaTerceiro());
        }

        private void Btn_Sociologia(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SociologiaTerceiro());
        }
    }
}