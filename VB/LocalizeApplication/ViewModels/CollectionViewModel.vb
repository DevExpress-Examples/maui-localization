Imports System.Collections.Generic
Imports System.Linq
Imports System.Threading
Imports System.Threading.Tasks
Imports System.Windows.Input
Imports LocalizeApplication.Model
Imports LocalizeApplication.Helpers

Namespace LocalizeApplication.ViewModel

    Public Class CollectionViewModel

        Public ReadOnly Property Calls As List(Of CallData)

        Public Sub New()
            Dim today As DateTime = DateTime.Now
            Calls = New List(Of CallData)() From {New CallData() With {.ContactName = "Nancy Davolio", .ContactPhone = "+1 (417) 166-3268", .NumberType = LocalizeEnumHelper.GetLocalizedString(NumberTypes.Mobile), .ContactColor = Color.FromArgb("#f15558"), .CallDate = today.AddDays(-1).AddMinutes(-180), .CallType = CallTypes.Incoming}, New CallData() With {.ContactName = "Andrew Fuller", .ContactPhone = "+1 (303) 718-1654", .NumberType = LocalizeEnumHelper.GetLocalizedString(NumberTypes.Mobile), .CallDate = today.AddDays(-1).AddMinutes(40), .ContactColor = Color.FromArgb("#0097ad"), .CallType = CallTypes.Incoming}, New CallData() With {.ContactName = "Janet Leverling", .ContactPhone = "+1 (720) 971-3972", .NumberType = LocalizeEnumHelper.GetLocalizedString(NumberTypes.Work), .CallDate = today.AddDays(-3).AddMinutes(-340), .ContactColor = Color.FromArgb("#ff7c11"), .CallType = CallTypes.Outgoing}, New CallData() With {.ContactName = "Margaret Peacock", .ContactPhone = "+1 (360) 186-4982", .NumberType = LocalizeEnumHelper.GetLocalizedString(NumberTypes.Unknown), .CallDate = today.AddDays(-4).AddMinutes(90), .ContactColor = Color.FromArgb("#ffbf22"), .CallType = CallTypes.Outgoing}, New CallData() With {.ContactName = "Steven Buchanan", .ContactPhone = "+1 (714) 226-7894", .NumberType = LocalizeEnumHelper.GetLocalizedString(NumberTypes.Home), .CallDate = today.AddDays(-7).AddMinutes(190), .ContactColor = Color.FromArgb("#ff6e86"), .CallType = CallTypes.Incoming}, New CallData() With {.ContactName = "Michael Suyama", .ContactPhone = "+1 (708) 799-8985", .NumberType = LocalizeEnumHelper.GetLocalizedString(NumberTypes.Home), .CallDate = today.AddDays(-7).AddMinutes(-190), .ContactColor = Color.FromArgb("#9865b0"), .CallType = CallTypes.Incoming}, New CallData() With {.ContactName = "Robert King", .ContactPhone = "+1 (718) 621-5291", .NumberType = LocalizeEnumHelper.GetLocalizedString(NumberTypes.Unknown), .CallDate = today.AddDays(-7).AddMinutes(400), .ContactColor = Color.FromArgb("#9865b0"), .CallType = CallTypes.Outgoing}, New CallData() With {.ContactName = "Laura Callahan", .ContactPhone = "+1 (425) 335-6226", .NumberType = LocalizeEnumHelper.GetLocalizedString(NumberTypes.Mobile), .CallDate = today.AddDays(-10).AddMinutes(-84), .ContactColor = Color.FromArgb("#01b0ee"), .CallType = CallTypes.Outgoing}, New CallData() With {.ContactName = "Anne Dodsworth", .ContactPhone = "+1 (224) 719-2759", .NumberType = LocalizeEnumHelper.GetLocalizedString(NumberTypes.Work), .CallDate = today.AddDays(-12).AddMinutes(25), .ContactColor = Color.FromArgb("#00c831"), .CallType = CallTypes.Incoming}}
        End Sub
    End Class
End Namespace
