Imports System.Resources
Imports DevExpress.Maui.Core

Namespace CustomLanguageResource

    Public Partial Class App
        Inherits Application

        Public Sub New()
            Localizer.StringLoader = New ResourceStringLoader(New ResourceManager("CustomLanguageResource.Resources.DevExpressMaui", GetType(App).Assembly))
            InitializeComponent()
            MainPage = New AppShell()
        End Sub
    End Class
End Namespace
