Imports LocalizeApplication.ViewModel
Imports LocalizeApplication.Model
Imports DevExpress.Maui.Controls

Namespace LocalizeApplication.Views

    Public Partial Class Collection
        Inherits ContentPage

        Public Sub New()
            InitializeComponent()
            BindingContext = New CollectionViewModel()
        End Sub

        Private Sub emailClicked(ByVal sender As System.Object, ByVal e As System.EventArgs)
            Dim clickeditem = TryCast(TryCast(sender, SimpleButton).BindingContext, CallData)
            DisplayAlert(clickeditem.ContactName, clickeditem.ContactPhone & Global.Microsoft.VisualBasic.Constants.vbLf + clickeditem.CallDate, "OK")
        End Sub
    End Class
End Namespace
