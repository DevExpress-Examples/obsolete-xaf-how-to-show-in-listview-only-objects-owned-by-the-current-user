Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Xpo
Imports DevExpress.ExpressApp.Updating

Namespace WinSolution.Module
	Public Class Updater
		Inherits ModuleUpdater
		Public Sub New(ByVal objectSpace As DevExpress.ExpressApp.IObjectSpace, ByVal currentDBVersion As Version)
			MyBase.New(objectSpace, currentDBVersion)
		End Sub
		Public Overrides Sub UpdateDatabaseAfterUpdateSchema()
			MyBase.UpdateDatabaseAfterUpdateSchema()
			If New XPCollection(Of Employee)(Session).Count = 0 Then
				Dim admin As New Employee(Session)
				admin.UserName = "Administrator"
				admin.SetPassword("")
				admin.IsAdministrator = True
				admin.Save()

				Dim adminStore As New Store(Session)
				adminStore.Name = admin.UserName & " Store"
				adminStore.AssignedTo = admin
				adminStore.Save()

				Dim user As New Employee(Session)
				user.UserName = "Sam"
				user.SetPassword("")
				user.Save()

				Dim userStore As New Store(Session)
				userStore.Name = user.UserName & " Store"
				userStore.AssignedTo = user
				userStore.Save()

				Dim user2 As New Employee(Session)
				user2.UserName = "John"
				user2.SetPassword("")
				user2.Save()

				Dim user2Store As New Store(Session)
				user2Store.Name = user2.UserName & " Store"
				user2Store.AssignedTo = user2
				user2Store.Save()
			End If
		End Sub
	End Class
End Namespace
