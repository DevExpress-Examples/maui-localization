Imports DevExpress.Maui.Scheduler
Imports Microsoft.Maui.Controls
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel

Namespace CustomLanguageResource

    Public Partial Class MainPage
        Inherits ContentPage

        Public Sub New()
            BindingContext = New ReceptionDeskViewModel()
            InitializeComponent()
        End Sub

        Private Sub WorkWeekView_Tap(ByVal sender As Object, ByVal e As SchedulerGestureEventArgs)
            If e.AppointmentInfo Is Nothing Then
                ShowNewAppointmentEditPage(e.IntervalInfo)
                Return
            End If

            Dim appointment As AppointmentItem = e.AppointmentInfo.Appointment
            Me.ShowAppointmentEditPage(appointment)
        End Sub

        Private Sub ShowAppointmentEditPage(ByVal appointment As AppointmentItem)
            Dim appEditPage As AppointmentEditPage = New AppointmentEditPage(appointment, Me.storage)
            Navigation.PushAsync(appEditPage)
        End Sub

        Private Sub ShowNewAppointmentEditPage(ByVal info As IntervalInfo)
            Dim appEditPage As AppointmentEditPage = New AppointmentEditPage(info.Start, info.[End], info.AllDay, Me.storage)
            Navigation.PushAsync(appEditPage)
        End Sub

        Public Class ReceptionDeskViewModel
            Inherits INotifyPropertyChanged

            Private ReadOnly data As ReceptionDeskData

            Public Event PropertyChanged As PropertyChangedEventHandler

            Public ReadOnly Property StartDate As DateTime
                Get
                    Return ReceptionDeskData.BaseDate
                End Get
            End Property

            Public ReadOnly Property MedicalAppointments As IReadOnlyList(Of MedicalAppointment)
                Get
                    Return data.MedicalAppointments
                End Get
            End Property

            Public ReadOnly Property AppointmentTypes As IReadOnlyList(Of MedicalAppointmentType)
                Get
                    Return data.Labels
                End Get
            End Property

            Public Sub New()
                data = New ReceptionDeskData()
            End Sub

            Protected Sub RaisePropertyChanged(ByVal name As String)
                RaiseEvent PropertyChangedEvent(Me, New PropertyChangedEventArgs(name))
            End Sub
        End Class
    End Class
End Namespace
