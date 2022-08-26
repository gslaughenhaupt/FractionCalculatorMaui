using FractionCalculatorMaui.ViewModels;

namespace FractionCalculatorMaui;

public partial class MainPage : ContentPage
{

	public MainPage(MainPageViewModel vm)
	{
		InitializeComponent();
		BindingContext =vm;
	}

}

