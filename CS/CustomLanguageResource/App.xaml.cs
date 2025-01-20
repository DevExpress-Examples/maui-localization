using System.Resources;
using DevExpress.Maui.Core;

namespace CustomLanguageResource;

public partial class App : Application
{
	public App()
	{
        Localizer.StringLoader = new ResourceStringLoader(new ResourceManager ("CustomLanguageResource.Resources.DevExpressMaui", (typeof(App).Assembly)));
        InitializeComponent();
	}

	protected override Window CreateWindow(IActivationState activationState) {
		return new Window(new AppShell());
	}
}

