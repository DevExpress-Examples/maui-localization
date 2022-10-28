namespace CustomLocalizedString;
using DevExpress.Maui.Core;

public partial class App : Application
{
	public App()
    {
        Localizer.StringLoader = new MyStringLoader();
        InitializeComponent();

		MainPage = new AppShell();
	}
}