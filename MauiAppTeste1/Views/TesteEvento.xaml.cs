namespace MauiAppTeste1.Views;

public partial class TesteEvento : ContentPage
{
	public TesteEvento()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		try {

			Navigation.PopAsync();

		}
		catch (Exception ex){

			DisplayAlert("Ops", ex.Message, "OK");

		}
    }
}