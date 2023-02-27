Imports DevExpress.Maui.Core
Imports System.Runtime.InteropServices

Namespace CustomLocalizedString

    Public Class MyStringLoader
        Inherits Localizer.IStringLoader

        Public Function TryGetString(ByVal key As String, <Out> ByRef value As String) As Boolean
            If Equals(key, "SchedulerStringId.AppointmentEdit_NewAppointmentTitle") Then
                value = "Nueva Cita"
                Return True
            End If

            value = Nothing
            Return False
        End Function
    End Class
End Namespace
