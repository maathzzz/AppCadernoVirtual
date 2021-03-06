using System;
using AppCadernoVirtual.Anos.Segundo;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppCadernoVirtual.Anos.Segundo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SegundoAno : ContentPage
    {
        public SegundoAno()
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
            Navigation.PushAsync(new ArtesSegundo());
        }

        private void Btn_Biologia(object sender, EventArgs e)
        {
            Navigation.PushAsync(new BiologiaSegundo());
        }

        private void Btn_Filosofia(object sender, EventArgs e)
        {
            Navigation.PushAsync(new FilosofiaSegundo());
        }

        private void Btn_Fisica(object sender, EventArgs e)
        {
            Navigation.PushAsync(new FisicaSegundo());
        }

        private void Btn_Geografia(object sender, EventArgs e)
        {
            Navigation.PushAsync(new GeografiaSegundo());
        }

        private void Btn_Historia(object sender, EventArgs e)
        {
            Navigation.PushAsync(new HistoriaSegundo());
        }

        private void Btn_Ingles(object sender, EventArgs e)
        {
            Navigation.PushAsync(new InglesSegundo());
        }
        private void Btn_Matematica(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MatematicaSegundo());
        }

        private void Btn_Portugues(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PortuguesSegundo());
        }

        private void Btn_Quimica(object sender, EventArgs e)
        {
            Navigation.PushAsync(new QuimicaSegundo());
        }

        private void Btn_Sociologia(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SociologiaSegundo());
        }
    }
}