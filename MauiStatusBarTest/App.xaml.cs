// App.xaml.cs

using Microsoft.Extensions.DependencyInjection;

namespace MauiStatusBarTest;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
	}

	protected override Window CreateWindow(IActivationState? activationState)
	{
		return new Window(new AppShell());
	}
}