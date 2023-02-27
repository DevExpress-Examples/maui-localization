Imports System.Globalization
Imports Microsoft.Maui
Imports Microsoft.Maui.Hosting
Imports Microsoft.Maui.Controls.Hosting
Imports DevExpress.Maui

Namespace CustomLanguageResource

    Public Module MauiProgram

        Public Function CreateMauiApp() As MauiApp
            Thread.CurrentThread.CurrentCulture = New CultureInfo("pt-BR")
            Thread.CurrentThread.CurrentUICulture = Thread.CurrentThread.CurrentCulture
            Dim builder = MauiApp.CreateBuilder()
            builder.UseDevExpress().UseMauiApp(Of App)().ConfigureFonts(Function(fonts)
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular")
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold")
            End Function)
            Return builder.Build()
        End Function
    End Module
End Namespace
