using MyLoginApp.Views;
namespace MyLoginApp;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		Routing.RegisterRoute(nameof(HomePage), typeof(HomePage));
	}
}
