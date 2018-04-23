Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraEditors.ViewInfo
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraEditors.Drawing
Imports DevExpress.XtraEditors.Controls

Namespace WindowsApplication1.CustomEditor
	Public Class ButtonEditCustomCaptionHelper

		Private ReadOnly _Column As GridColumn
		Private ReadOnly _EventHandler As GetButtonCaptionDelegate
		Public Sub New(ByVal view As GridView, ByVal column As GridColumn, ByVal eventHandler As GetButtonCaptionDelegate)
			_EventHandler = eventHandler
			_Column = column
			AddHandler view.CustomDrawCell, AddressOf view_CustomDrawCell
			AddHandler view.ShownEditor, AddressOf view_ShownEditor
		End Sub

		Public Shared Sub Register(ByVal column As GridColumn, ByVal eventHandler As GetButtonCaptionDelegate)
			Dim TempButtonEditCustomCaptionHelper As ButtonEditCustomCaptionHelper = New ButtonEditCustomCaptionHelper(TryCast(column.View, GridView), column, eventHandler)
		End Sub

		Private Sub view_ShownEditor(ByVal sender As Object, ByVal e As EventArgs)
			Dim view As GridView = TryCast(sender, GridView)
			If view.FocusedColumn IsNot _Column Then
				Return
			End If
			Dim edit As ExtendedButtonEdit = TryCast(view.ActiveEditor, ExtendedButtonEdit)
			If edit Is Nothing Then
				Return
			End If
			For Each button As EditorButton In edit.Properties.Buttons
				button.Caption = GetButtonCaption(view, view.FocusedRowHandle, view.FocusedColumn, button)
			Next button
		End Sub

		Private Sub view_CustomDrawCell(ByVal sender As Object, ByVal e As RowCellCustomDrawEventArgs)
			If e.Column IsNot _Column Then
				Return
			End If
			Dim cellInfo As GridCellInfo = TryCast(e.Cell, GridCellInfo)
			Dim viewInfo As ExtendedButtonEditViewInfo = TryCast(cellInfo.ViewInfo, ExtendedButtonEditViewInfo)
			If viewInfo IsNot Nothing Then
				UpdateButtonCaptions(sender, e, viewInfo)
			End If
		End Sub

		Private Sub UpdateButtonCaptions(ByVal sender As Object, ByVal e As RowCellCustomDrawEventArgs, ByVal viewInfo As ExtendedButtonEditViewInfo)
			UpdateButtonCollection(sender, e, viewInfo.LeftButtons, viewInfo)
			UpdateButtonCollection(sender, e, viewInfo.RightButtons, viewInfo)
		End Sub
		Private Sub UpdateButtonCollection(ByVal view As Object, ByVal e As RowCellCustomDrawEventArgs, ByVal buttonCollection As EditorButtonObjectCollection, ByVal viewInfo As ExtendedButtonEditViewInfo)
			For Each args As EditorButtonObjectInfoArgs In buttonCollection
			  viewInfo.CustomButtonCaptions(args.Button) = GetButtonCaption(TryCast(view, GridView), e.RowHandle, e.Column, args.Button)
			Next args
		End Sub
		Private Function GetButtonCaption(ByVal view As GridView, ByVal rowHandle As Integer, ByVal column As GridColumn, ByVal button As DevExpress.XtraEditors.Controls.EditorButton) As String
			Dim args As New GetButtonCaptionEventArgs(button, column, rowHandle, view)
			RaiseGetButtonCaptionEvent(args)
			Return args.ButtonText
		End Function


		Private Sub RaiseGetButtonCaptionEvent(ByVal args As GetButtonCaptionEventArgs)
			If _EventHandler IsNot Nothing Then
				_EventHandler(Me, args)
			End If
		End Sub
	End Class
End Namespace