using DevExpress.Maui.Core;

namespace LocalizeApplication;

public partial class App : Application {
	public App() {
		Localizer.StringLoader = new ResourceStringLoader(LocalizeApplication.Resources.Localization.DevExpressMaui.ResourceManager);

		InitializeComponent();

		MainPage = new AppShell();
	}
}