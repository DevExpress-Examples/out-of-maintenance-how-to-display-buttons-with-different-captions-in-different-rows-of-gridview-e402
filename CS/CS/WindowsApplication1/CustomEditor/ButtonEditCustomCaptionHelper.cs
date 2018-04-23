using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraEditors.ViewInfo;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraEditors.Drawing;
using DevExpress.XtraEditors.Controls;

namespace WindowsApplication1.CustomEditor
{
    public class ButtonEditCustomCaptionHelper
    {

        private readonly GridColumn _Column;
        private readonly GetButtonCaptionDelegate _EventHandler;
        public ButtonEditCustomCaptionHelper(GridView view, GridColumn column, GetButtonCaptionDelegate eventHandler)
        {
            _EventHandler = eventHandler;
            _Column = column;
            view.CustomDrawCell += view_CustomDrawCell;
            view.ShownEditor += new EventHandler(view_ShownEditor);
        }

        public static void Register(GridColumn column, GetButtonCaptionDelegate eventHandler)
        {
            new ButtonEditCustomCaptionHelper(column.View as GridView, column, eventHandler);
        }

        void view_ShownEditor(object sender, EventArgs e)
        {
            GridView view = sender as GridView;
            if (view.FocusedColumn != _Column)
                return;
            ExtendedButtonEdit edit = view.ActiveEditor as ExtendedButtonEdit;
            if (edit == null)
                return;
            foreach (EditorButton button in edit.Properties.Buttons)
            {
                button.Caption = GetButtonCaption(view, view.FocusedRowHandle, view.FocusedColumn, button);
            }
        }

        void view_CustomDrawCell(object sender, RowCellCustomDrawEventArgs e)
        {
            if (e.Column != _Column)
                return;
            GridCellInfo cellInfo = e.Cell as GridCellInfo;
            ExtendedButtonEditViewInfo viewInfo = cellInfo.ViewInfo as ExtendedButtonEditViewInfo;
            if (viewInfo != null)
                UpdateButtonCaptions(sender, e, viewInfo);
        }

        private void UpdateButtonCaptions(object sender, RowCellCustomDrawEventArgs e, ExtendedButtonEditViewInfo viewInfo)
        {
            UpdateButtonCollection(sender, e, viewInfo.LeftButtons, viewInfo);
            UpdateButtonCollection(sender, e, viewInfo.RightButtons, viewInfo);
        }
        private void UpdateButtonCollection(object view, RowCellCustomDrawEventArgs e, EditorButtonObjectCollection buttonCollection, ExtendedButtonEditViewInfo viewInfo)
        {
            foreach (EditorButtonObjectInfoArgs args in buttonCollection)
            {
              viewInfo.CustomButtonCaptions[args.Button] = GetButtonCaption(view as GridView, e.RowHandle, e.Column, args.Button);
            }
        }
        private string GetButtonCaption(GridView view, int rowHandle, GridColumn column, DevExpress.XtraEditors.Controls.EditorButton button)
        {
            GetButtonCaptionEventArgs args = new GetButtonCaptionEventArgs(button, column, rowHandle, view);
            RaiseGetButtonCaptionEvent(args);
            return args.ButtonText;
        }


        private void RaiseGetButtonCaptionEvent(GetButtonCaptionEventArgs args)
        {
            if (_EventHandler != null )
                _EventHandler(this, args);
        }
    }
}