Imports System
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports DevExpress.Maui.Core.Internal

Namespace LocalizeApplication.Model

    Public Class CallData

        Private contactColorField As Color = DXColor.Default

        Public ReadOnly Property ContactDisplay As String
            Get
                Return [String].Format("{0} ({1})", ContactName, ContactPhone)
            End Get
        End Property

        Public ReadOnly Property ContactAvatarText As String
            Get
                Return ContactName.Substring(0, 1)
            End Get
        End Property

        Public Property ContactName As String

        Public Property ContactPhone As String

        Public Property CallDate As DateTime

        Public Property NumberType As String

        Public Property CallType As CallTypes

        Public Property ContactColor As Color
    End Class

    Public Enum NumberTypes
        Mobile
        Home
        Work
        Unknown
    End Enum

    Public Enum CallTypes
        Incoming
        Outgoing
    End Enum
End Namespace
