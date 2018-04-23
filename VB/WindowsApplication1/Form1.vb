Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports WindowsApplication1.CustomEditor

Namespace WindowsApplication1
	Partial Public Class Form1
		Inherits Form
		Private Function CreateTable(ByVal RowCount As Integer) As DataTable
			Dim tbl As New DataTable()
			tbl.Columns.Add("Name", GetType(String))
			tbl.Columns.Add("ID", GetType(Integer))
			tbl.Columns.Add("Number", GetType(Integer))
			tbl.Columns.Add("Date", GetType(DateTime))
			For i As Integer = 0 To RowCount - 1
				tbl.Rows.Add(New Object() { String.Format("Name{0}", i), i, 3 - i, DateTime.Now.AddDays(i) })
			Next i
			Return tbl
		End Function

		Public Sub New()
			InitializeComponent()
			gridControl1.DataSource = CreateTable(20)
			ButtonEditCustomCaptionHelper.Register(gridView1.Columns(0), AddressOf OnGetButtonCaption)
			ButtonEditCustomCaptionHelper.Register(gridView1.Columns(1), AddressOf OnGetButtonCaption)
		End Sub

		Public Sub OnGetButtonCaption(ByVal helper As ButtonEditCustomCaptionHelper, ByVal args As GetButtonCaptionEventArgs)
			If args.RowHandle = 2 Then
				Return
			End If
			args.ButtonText = String.Format("{0};{1};Button{2}", args.Column.VisibleIndex, args.RowHandle, args.Button.Index)
		End Sub
	End Class
End Namespace