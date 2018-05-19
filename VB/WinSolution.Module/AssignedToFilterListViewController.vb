Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.ExpressApp
Imports DevExpress.Data.Filtering

Namespace WinSolution.Module
	Partial Public Class AssignedToFilterListViewController
		Inherits ViewController
		Public Sub New()
			TargetObjectType = GetType(Store)
			TargetViewType = ViewType.ListView
		End Sub
		Protected Overrides Sub OnActivated()
			MyBase.OnActivated()
			Dim lv As ListView = CType(View, ListView)
			If Not(CType(SecuritySystem.CurrentUser, Employee)).IsAdministrator Then
				lv.CollectionSource.Criteria("AssignedTo") = CriteriaOperator.Parse("AssignedTo.Oid = ?", SecuritySystem.CurrentUserId)
			End If
		End Sub
	End Class
End Namespace
