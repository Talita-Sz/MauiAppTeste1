using MauiAppTeste1.Models;
namespace MauiAppTeste1.Views;

public partial class EventoTeste : ContentPage
{
    App PropriedadesApp;

    public EventoTeste()
	{
		InitializeComponent();

        PropriedadesApp = (App)Application.Current;

        pck_local.ItemsSource = PropriedadesApp.lista_local;

        dtcpk_inicio.MinimumDate = DateTime.Now;
        dtcpk_inicio.MaximumDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month + 1, DateTime.Now.Day);

        dtcpk_termino.MinimumDate = dtcpk_inicio.Date.AddDays(1);
        dtcpk_termino.MaximumDate = dtcpk_inicio.Date.AddMonths(2);
        
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
        try {

            Informacoes t = new Informacoes { 
                Lugar = (Local)pck_local.SelectedItem,
                TotalPessoas = Convert.ToInt32(stp_adultos.Value),
                DataInicio = dtcpk_inicio.Date,
                DataTermino = dtcpk_termino.Date,
                NomeEvento = nome_evento.Text
            };



           await Navigation.PushAsync(new TesteEvento()
           {
               BindingContext = t 
           });

        } catch (Exception ex){

               await DisplayAlert("Ops", ex.Message, "OK");
        }
    }

    private void dtcpk_inicio_DateSelected(object sender, DateChangedEventArgs e)
    {
        DatePicker elemento = sender as DatePicker;

        DateTime data_selecionada_inicio = elemento.Date;

        dtcpk_termino.MinimumDate = data_selecionada_inicio.AddDays(1);
        dtcpk_termino.MaximumDate = data_selecionada_inicio.AddMonths(6);
    }

}