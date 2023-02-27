Imports System
Imports System.Collections.ObjectModel

Namespace CustomLocalizedString

    Public Class MedicalAppointment

        Public Property Id As Integer

        Public Property StartTime As DateTime

        Public Property EndTime As DateTime

        Public Property Subject As String

        Public Property LabelId As Integer

        Public Property Location As String
    End Class

    Public Class MedicalAppointmentType

        Public Property Id As Integer

        Public Property Caption As String

        Public Property Color As Color
    End Class

    Public Class ReceptionDeskData

        Private _MedicalAppointments As ObservableCollection(Of CustomLocalizedString.MedicalAppointment), _Labels As ObservableCollection(Of CustomLocalizedString.MedicalAppointmentType)

        Public Shared BaseDate As DateTime = DateTime.Today

        Public Shared PatientNames As String() = {"Andrew Glover", "Mark Oliver", "Taylor Riley", "Addison Davis", "Benjamin Hughes", "Lucas Smith", "Robert King", "Laura Callahan", "Miguel Simmons", "Isabella Carter", "Andrew Fuller", "Madeleine Russell", "Steven Buchanan", "Nancy Davolio", "Michael Suyama", "Margaret Peacock", "Janet Leverling", "Ariana Alexander", "Brad Farkus", "Bart Arnaz", "Arnie Schwartz", "Billy Zimmer"}

        Public Shared AppointmentTypes As String() = {"Hospital", "Office", "Phone Consultation", "Home", "Hospice"}

        Public Shared AppointmentTypeColors As Color() = {Color.FromHex("#dfcfe9"), Color.FromHex("#c2f49d"), Color.FromHex("#8de8df"), Color.FromHex("#a8d5ff"), Color.FromHex("#c8f4ff")}

        Private Shared rnd As Random = New Random()

        Private Sub CreateLabels()
            Dim result As ObservableCollection(Of MedicalAppointmentType) = New ObservableCollection(Of MedicalAppointmentType)()
            Dim count As Integer = AppointmentTypes.Length
            For i As Integer = 0 To count - 1
                Dim appointmentType As MedicalAppointmentType = New MedicalAppointmentType()
                appointmentType.Id = i
                appointmentType.Caption = AppointmentTypes(i)
                appointmentType.Color = AppointmentTypeColors(i)
                result.Add(appointmentType)
            Next

            Labels = result
        End Sub

        Private Sub CreateMedicalAppointments()
            Dim appointmentId As Integer = 1
            Dim patientIndex As Integer = 0
            Dim start As DateTime
            Dim duration As TimeSpan
            Dim result As ObservableCollection(Of MedicalAppointment) = New ObservableCollection(Of MedicalAppointment)()
            For i As Integer = -20 To 20 - 1
                For j As Integer = 0 To 6 - 1
                    Dim room As Integer = rnd.[Next](1, 100)
                    start = BaseDate.AddDays(i).AddHours(rnd.[Next](8, 17)).AddMinutes(rnd.[Next](0, 40))
                    duration = TimeSpan.FromMinutes(rnd.[Next](20, 30))
                    result.Add(Me.CreateMedicAppointment(appointmentId, PatientNames(patientIndex), start, duration, room))
                    appointmentId += 1
                    patientIndex += 1
                    If patientIndex >= PatientNames.Length - 1 Then patientIndex = 1
                Next
            Next

            MedicalAppointments = result
        End Sub

        Private Function CreateMedicAppointment(ByVal appointmentId As Integer, ByVal patientName As String, ByVal start As DateTime, ByVal duration As TimeSpan, ByVal room As Integer) As MedicalAppointment
            Dim medicalAppointment As MedicalAppointment = New MedicalAppointment()
            medicalAppointment.Id = appointmentId
            medicalAppointment.StartTime = start
            medicalAppointment.EndTime = start.Add(duration)
            medicalAppointment.Subject = patientName
            ' Assign one of the predefined labels to an appointment
            medicalAppointment.LabelId = rnd.[Next](1, 10)
            medicalAppointment.Location = [String].Format("{0}", room)
            Return medicalAppointment
        End Function

        Public Property MedicalAppointments As ObservableCollection(Of MedicalAppointment)
            Get
                Return _MedicalAppointments
            End Get

            Private Set(ByVal value As ObservableCollection(Of MedicalAppointment))
                _MedicalAppointments = value
            End Set
        End Property

        Public Property Labels As ObservableCollection(Of MedicalAppointmentType)
            Get
                Return _Labels
            End Get

            Private Set(ByVal value As ObservableCollection(Of MedicalAppointmentType))
                _Labels = value
            End Set
        End Property

        Public Sub New()
            CreateLabels()
            CreateMedicalAppointments()
        End Sub
    End Class
End Namespace
