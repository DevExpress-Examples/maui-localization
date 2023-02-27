Imports DevExpress.Maui.Core

Namespace CustomLocalizedString

    Public Partial Class App
        Inherits Application

        Public Sub New()
            Localizer.StringLoader = New MyStringLoader()
            InitializeComponent()
            MainPage = New AppShell()
        End Sub
    End Class
End Namespace
