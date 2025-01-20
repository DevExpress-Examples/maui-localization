using DevExpress.Maui.Core;

namespace LocalizeApplication;

public partial class App : Application {
	public App() {
		Localizer.StringLoader = new ResourceStringLoader(LocalizeApplication.Resources.Localization.DevExpressMaui.ResourceManager);

		InitializeComponent();
	}

	protected override Window CreateWindow(IActivationState activationState) {
		return new Window(new AppShell());
	}
}