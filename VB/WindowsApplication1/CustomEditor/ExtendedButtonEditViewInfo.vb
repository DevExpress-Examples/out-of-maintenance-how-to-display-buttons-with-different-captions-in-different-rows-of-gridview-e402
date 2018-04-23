Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Drawing
Imports DevExpress.XtraEditors.ViewInfo
Imports DevExpress.XtraEditors.Controls
Imports System.Collections.Generic

Namespace WindowsApplication1
	Public Class ExtendedButtonEditViewInfo
		Inherits ButtonEditViewInfo
		Public Sub New(ByVal item As RepositoryItem)
			MyBase.New(item)

		End Sub
		Protected Overrides Function CreateButtonPainter() As EditorButtonPainter
			Dim painter As New ExtendedSkinEditorButtonPainter(LookAndFeel)
			painter.OwnerEditInfo = Me
			Return painter
		End Function

		' Fields...
		Private _CustomButtonCaptions As New Dictionary(Of EditorButton, String)()

		Public Property CustomButtonCaptions() As Dictionary(Of EditorButton, String)
			Get
				Return _CustomButtonCaptions
			End Get
			Set(ByVal value As Dictionary(Of EditorButton, String))
				_CustomButtonCaptions = value
			End Set
		End Property
		Public Function GetButtonCaption(ByVal button As EditorButton) As String
			Dim text As String = String.Empty
			If (Not CustomButtonCaptions.TryGetValue(button, text)) Then
				text = button.Caption
			End If
			Return text
		End Function

	End Class
End Namespace