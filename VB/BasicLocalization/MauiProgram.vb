Imports Microsoft.Maui
Imports Microsoft.Maui.Hosting
Imports Microsoft.Maui.Controls.Hosting
Imports DevExpress.Maui

Namespace BasicLocalization

    Public Module MauiProgram

        Public Function CreateMauiApp() As MauiApp
            Dim builder = MauiApp.CreateBuilder()
            builder.UseDevExpress(useLocalization:=True).UseMauiApp(Of App)().ConfigureFonts(Function(fonts)
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular")
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold")
            End Function)
            Return builder.Build()
        End Function
    End Module
End Namespace
