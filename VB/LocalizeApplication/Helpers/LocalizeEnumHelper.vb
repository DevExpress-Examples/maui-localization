Imports System
Imports LocalizeApplication.Resources.Localization
Imports LocalizeApplication.Model
Imports System.Reflection
Imports System.Data

Namespace LocalizeApplication.Helpers

    Public Module LocalizeEnumHelper

        Public Function GetLocalizedString(ByVal numbertype As NumberTypes) As String
            Select Case numbertype
                Case NumberTypes.Mobile
                    Return ApplicationStrings.NumberType_Mobile
                Case NumberTypes.Home
                    Return ApplicationStrings.NumberType_Home
                Case NumberTypes.Work
                    Return ApplicationStrings.NumberType_Work
                Case NumberTypes.Unknown
                    Return ApplicationStrings.NumberType_Unknown
                Case Else
                    Throw New ArgumentOutOfRangeException("numbertype")
            End Select
        End Function

        Public Function GetIcon(ByVal calltype As CallTypes) As String
            Select Case calltype
                Case CallTypes.Incoming
                    Return "→"
                Case CallTypes.Outgoing
                    Return "←"
                Case Else
                    Throw New ArgumentOutOfRangeException("numbertype")
            End Select
        End Function
    End Module
End Namespace
