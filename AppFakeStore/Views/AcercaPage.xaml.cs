namespace AppFakeStore.Views;

public partial class AcercaPage : ContentPage
{
	public AcercaPage()
	{
		InitializeComponent();
	}

    private void OnCounterClicked(object sender, TappedEventArgs e)
    {
		Application.Current.MainPage.DisplayAlert("Aviso", "Mostramos mensaje!", "Aceptar");
    }

    private void IconBtn_Clicked(object sender, EventArgs e)
    {
        Application.Current.MainPage.DisplayAlert("Aviso", "Mostramos mensaje Alternativo!", "Aceptar");
    }
}