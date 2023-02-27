Imports DevExpress.Maui.Core

Namespace LocalizeApplication

    Public Partial Class App
        Inherits Application

        Public Sub New()
            Localizer.StringLoader = New ResourceStringLoader(Resources.Localization.DevExpressMaui.ResourceManager)
            InitializeComponent()
            MainPage = New AppShell()
        End Sub
    End Class
End Namespace
