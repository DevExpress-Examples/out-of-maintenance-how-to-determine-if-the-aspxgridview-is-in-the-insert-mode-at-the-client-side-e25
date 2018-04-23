Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports DevExpress.Web

Partial Public Class _Default
	Inherits System.Web.UI.Page
	Protected Sub ASPxGridView1_CustomJSProperties(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridViewClientJSPropertiesEventArgs)
		e.Properties("cpIsNewRowEditing") = (TryCast(sender, ASPxGridView)).IsNewRowEditing.ToString()
	End Sub
End Class
