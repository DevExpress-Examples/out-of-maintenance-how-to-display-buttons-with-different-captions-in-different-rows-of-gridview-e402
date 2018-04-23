Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraEditors.Controls

Namespace WindowsApplication1.CustomEditor
	Public Delegate Sub GetButtonCaptionDelegate(ByVal helper As ButtonEditCustomCaptionHelper, ByVal args As GetButtonCaptionEventArgs)

	Public Class GetButtonCaptionEventArgs
		Inherits EventArgs

		' Fields...
		Private _ButtonText As String
		Private _Button As EditorButton
		Private _Column As GridColumn
		Private _RowHandle As Integer
		Private _View As GridView

		''' <summary>
		''' Initializes a new instance of the GetButtonCaptionEventArgs class.
		''' </summary>
		''' <param name="button"></param>
		''' <param name="column"></param>
		''' <param name="rowHandle"></param>
		''' <param name="view"></param>
		Public Sub New(ByVal button As EditorButton, ByVal column As GridColumn, ByVal rowHandle As Integer, ByVal view As GridView)
			_Button = button
			_Column = column
			_RowHandle = rowHandle
			_View = view
			_ButtonText = button.Caption
		End Sub

		Public Property View() As GridView
			Get
				Return _View
			End Get
			Set(ByVal value As GridView)
				_View = value

			End Set
		End Property


		Public Property RowHandle() As Integer
			Get
				Return _RowHandle
			End Get
			Set(ByVal value As Integer)
				_RowHandle = value

			End Set
		End Property

		Public Property Column() As GridColumn
			Get
				Return _Column
			End Get
			Set(ByVal value As GridColumn)
				_Column = value

			End Set
		End Property


		Public Property Button() As EditorButton
			Get
				Return _Button
			End Get
			Set(ByVal value As EditorButton)
				_Button = value

			End Set
		End Property



		Public Property ButtonText() As String
			Get
				Return _ButtonText
			End Get
			Set(ByVal value As String)
				_ButtonText = value

			End Set
		End Property
	End Class
End Namespace
