Imports DevExpress.Maui

Namespace LocalizeApplication

    Public Module MauiProgram

        Public Function CreateMauiApp() As MauiApp
            Dim builder = MauiApp.CreateBuilder()
            builder.UseMauiApp(Of App)().UseDevExpress(useLocalization:=True).ConfigureFonts(Function(fonts)
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular")
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold")
            End Function)
            Return builder.Build()
        End Function
    End Module
End Namespace
