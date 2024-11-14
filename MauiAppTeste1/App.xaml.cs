
using MauiAppTeste1.Models;

namespace MauiAppTeste1
{
    public partial class App : Application
    {
        public List<Local> lista_local = new List<Local> { 
        
        new Local()
        {
            Lugar = "Santo André-SP > Família",
            ParticipanteAdulto = 150.00
        },
        new Local()
        {
            Lugar = "Tatuapé-SP > Família",
            ParticipanteAdulto = 150.00
        },
         new Local()
        {
            Lugar = "Barra Funda-SP > Amigos-Família",
            ParticipanteAdulto = 120.00
        },
         new Local()
        {
            Lugar = "Barra Funda-SP > Amigos",
            ParticipanteAdulto = 100.00
        },
         new Local()
        {
            Lugar = "Sé-SP > Amigos",
            ParticipanteAdulto = 100.00
        },
         new Local()
        {
            Lugar = "jundiaí-INTERIOR > Família",
            ParticipanteAdulto = 100.00
         }
        };



        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Views.EventoTeste());
        }
        protected override Window CreateWindow(IActivationState? activationState)
        {
            var window = base.CreateWindow(activationState);

            window.Width = 400;
            window.Height= 700;

            return window;
        }

    }
}
