namespace CustomLocalizedString;
using DevExpress.Maui.Core;

public partial class App : Application
{
	public App()
    {
        Localizer.StringLoader = new MyStringLoader();
        InitializeComponent();
	}

    protected override Window CreateWindow(IActivationState activationState) {
		return new Window(new AppShell());
	}
}