Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraEditors.Drawing
Imports DevExpress.Skins
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.ViewInfo

Namespace WindowsApplication1
	Public Class ExtendedSkinEditorButtonPainter
		Inherits SkinEditorButtonPainter
		Public Sub New(ByVal provider As DevExpress.Skins.ISkinProvider)
			MyBase.New(provider)

		End Sub

		' Fields...

		Private privateOwnerEditInfo As BaseEditViewInfo
		Public Property OwnerEditInfo() As BaseEditViewInfo
			Get
				Return privateOwnerEditInfo
			End Get
			Set(ByVal value As BaseEditViewInfo)
				privateOwnerEditInfo = value
			End Set
		End Property

		Protected Overrides Sub DrawContent(ByVal e As DevExpress.Utils.Drawing.ObjectInfoArgs)
			Dim ee As EditorButtonObjectInfoArgs = TryCast(e, EditorButtonObjectInfoArgs)
			Dim caption As String = (CType(OwnerEditInfo, ExtendedButtonEditViewInfo)).GetButtonCaption(ee.Button)
			ButtonPainter.DrawCaption(ee, caption, ee.Appearance.Font, GetForeBrush(ee), e.Bounds, ee.Appearance.GetStringFormat())
		End Sub

	End Class
End Namespace