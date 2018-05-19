Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Xpo
Imports DevExpress.ExpressApp
Imports DevExpress.Persistent.Base
Imports DevExpress.Persistent.BaseImpl

Namespace WinSolution.Module
	<DefaultClassOptions> _
	Public Class Store
		Inherits BaseObject
		Public Sub New(ByVal session As Session)
			MyBase.New(session)
		End Sub
		Private _AssignedTo As Employee
		Public Property AssignedTo() As Employee
			Get
				Return _AssignedTo
			End Get
			Set(ByVal value As Employee)
				SetPropertyValue("AssignedTo", _AssignedTo, value)
			End Set
		End Property
		Public Overrides Sub AfterConstruction()
			MyBase.AfterConstruction()
			_AssignedTo = Session.GetObjectByKey(Of Employee)(SecuritySystem.CurrentUserId)
		End Sub
		Private _Name As String
		Public Property Name() As String
			Get
				Return _Name
			End Get
			Set(ByVal value As String)
				SetPropertyValue("Name", _Name, value)
			End Set
		End Property
	End Class
End Namespace
