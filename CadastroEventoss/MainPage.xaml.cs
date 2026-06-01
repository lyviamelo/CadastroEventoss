using CadastroEventoss.Models;

namespace CadastroEventoss;

public partial class MainPage : ContentPage
{
    Evento evento = new Evento();

    public MainPage()
    {
        InitializeComponent();

        evento.DataInicio = DateTime.Today;
        evento.DataTermino = DateTime.Today;

        BindingContext = evento;
    }

    private async void Button_Clicked(object? sender, EventArgs e)
    {
        await Navigation.PushAsync(
            new ResumoEventoPage(evento));
    }
}