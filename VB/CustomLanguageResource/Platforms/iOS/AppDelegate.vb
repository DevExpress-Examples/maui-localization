Imports Foundation

Namespace CustomLanguageResource

    <Register("AppDelegate")>
    Public Class AppDelegate
        Inherits MauiUIApplicationDelegate

        Protected Overrides Function CreateMauiApp() As MauiApp
            Return MauiProgram.CreateMauiApp()
        End Function
    End Class
End Namespace
