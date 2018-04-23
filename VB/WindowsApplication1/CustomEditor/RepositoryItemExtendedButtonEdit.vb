Imports Microsoft.VisualBasic
Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Registrator
Imports DevExpress.XtraEditors.Drawing
Imports DevExpress.XtraEditors.ViewInfo

Namespace WindowsApplication1
	<System.ComponentModel.DesignerCategory(""), UserRepositoryItem("Register")> _
	Public Class RepositoryItemExtendedButtonEdit
		Inherits RepositoryItemButtonEdit
		Shared Sub New()
			Register()
		End Sub
		Public Sub New()
		End Sub

		Friend Const EditorName As String = "MyButtonEdit"



		Public Shared Sub Register()
			EditorRegistrationInfo.Default.Editors.Add(New EditorClassInfo(EditorName, GetType(ExtendedButtonEdit), GetType(RepositoryItemExtendedButtonEdit), GetType(ExtendedButtonEditViewInfo), New ButtonEditPainter(), True))
		End Sub
		Public Overrides ReadOnly Property EditorTypeName() As String
			Get
				Return EditorName
			End Get
		End Property

	End Class

End Namespace