Imports Microsoft.VisualBasic
Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Registrator

Namespace WindowsApplication1
  <System.ComponentModel.DesignerCategory("")> _
  Public Class ExtendedButtonEdit
	  Inherits ButtonEdit
		Shared Sub New()
			RepositoryItemExtendedButtonEdit.Register()
		End Sub

		Public Overrides ReadOnly Property EditorTypeName() As String
			Get
				Return RepositoryItemExtendedButtonEdit.EditorName
			End Get
		End Property
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Content)> _
		Public Shadows ReadOnly Property Properties() As RepositoryItemExtendedButtonEdit
			Get
				Return TryCast(MyBase.Properties, RepositoryItemExtendedButtonEdit)
			End Get
		End Property
  End Class
End Namespace