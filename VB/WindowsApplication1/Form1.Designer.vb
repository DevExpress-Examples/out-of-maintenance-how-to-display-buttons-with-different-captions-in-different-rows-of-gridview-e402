Imports Microsoft.VisualBasic
Imports System
Namespace WindowsApplication1
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim serializableAppearanceObject1 As New DevExpress.Utils.SerializableAppearanceObject()
			Dim serializableAppearanceObject2 As New DevExpress.Utils.SerializableAppearanceObject()
			Dim serializableAppearanceObject3 As New DevExpress.Utils.SerializableAppearanceObject()
			Dim serializableAppearanceObject4 As New DevExpress.Utils.SerializableAppearanceObject()
			Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
			Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.gridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.repositoryItemMyButtonEdit3 = New WindowsApplication1.RepositoryItemExtendedButtonEdit()
			Me.gridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.repositoryItemMyButtonEdit2 = New WindowsApplication1.RepositoryItemExtendedButtonEdit()
			Me.defaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemMyButtonEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemMyButtonEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' gridControl1
			' 
			Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.gridControl1.Location = New System.Drawing.Point(0, 0)
			Me.gridControl1.MainView = Me.gridView1
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemMyButtonEdit2, Me.repositoryItemMyButtonEdit3})
			Me.gridControl1.Size = New System.Drawing.Size(476, 373)
			Me.gridControl1.TabIndex = 0
			Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1})
			' 
			' gridView1
			' 
			Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.gridColumn1, Me.gridColumn2})
			Me.gridView1.GridControl = Me.gridControl1
			Me.gridView1.Name = "gridView1"
			Me.gridView1.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways
			' 
			' gridColumn1
			' 
			Me.gridColumn1.Caption = "gridColumn1"
			Me.gridColumn1.ColumnEdit = Me.repositoryItemMyButtonEdit3
			Me.gridColumn1.Name = "gridColumn1"
			Me.gridColumn1.Visible = True
			Me.gridColumn1.VisibleIndex = 0
			' 
			' repositoryItemMyButtonEdit3
			' 
			Me.repositoryItemMyButtonEdit3.AutoHeight = False
			Me.repositoryItemMyButtonEdit3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "Test", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", Nothing, Nothing, True)})
			Me.repositoryItemMyButtonEdit3.Name = "repositoryItemMyButtonEdit3"
			Me.repositoryItemMyButtonEdit3.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
			' 
			' gridColumn2
			' 
			Me.gridColumn2.Caption = "gridColumn2"
			Me.gridColumn2.ColumnEdit = Me.repositoryItemMyButtonEdit2
			Me.gridColumn2.Name = "gridColumn2"
			Me.gridColumn2.Visible = True
			Me.gridColumn2.VisibleIndex = 1
			' 
			' repositoryItemMyButtonEdit2
			' 
			Me.repositoryItemMyButtonEdit2.AutoHeight = False
			Me.repositoryItemMyButtonEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "Test", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "", Nothing, Nothing, True), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "Test2", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject3, "", Nothing, Nothing, True), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "Test3", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject4, "", Nothing, Nothing, True)})
			Me.repositoryItemMyButtonEdit2.Name = "repositoryItemMyButtonEdit2"
			Me.repositoryItemMyButtonEdit2.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
			' 
			' defaultLookAndFeel1
			' 
			Me.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2010 Black"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(476, 373)
			Me.Controls.Add(Me.gridControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemMyButtonEdit3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemMyButtonEdit2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private gridControl1 As DevExpress.XtraGrid.GridControl
		Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
		Private defaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
		Private gridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
		Private repositoryItemMyButtonEdit3 As RepositoryItemExtendedButtonEdit
		Private gridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
		Private repositoryItemMyButtonEdit2 As RepositoryItemExtendedButtonEdit

	End Class
End Namespace
