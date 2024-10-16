﻿using DevExpress.Maui;

namespace LocalizeApplication;

public static class MauiProgram {
	public static MauiApp CreateMauiApp() {
		var builder = MauiApp.CreateBuilder();
		builder
		.UseMauiApp<App>()
        	.UseDevExpress(useLocalization: true)
			.UseDevExpressCollectionView()
			.UseDevExpressControls()
         	.ConfigureFonts(fonts =>
		{
			fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
			fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
		});
        return builder.Build();
	}
}
