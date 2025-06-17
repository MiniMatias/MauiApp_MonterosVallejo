using MauiApp_MonterosVallejo.ViewModels;

namespace MauiApp_MonterosVallejo.Views;

public partial class WeatherView : ContentPage
{
	public WeatherView()
	{
		InitializeComponent();
        bindingContext = new WeatherViewModel();
    }
}