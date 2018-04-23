using System;
using System.Collections.Generic;
using System.Linq;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraEditors.Controls;

namespace WindowsApplication1.CustomEditor
{
    public delegate void GetButtonCaptionDelegate(ButtonEditCustomCaptionHelper helper, GetButtonCaptionEventArgs args);

    public class GetButtonCaptionEventArgs : EventArgs
    {

        // Fields...
        private string _ButtonText;
        private EditorButton _Button;
        private GridColumn _Column;
        private int _RowHandle;
        private GridView _View;

        /// <summary>
        /// Initializes a new instance of the GetButtonCaptionEventArgs class.
        /// </summary>
        /// <param name="button"></param>
        /// <param name="column"></param>
        /// <param name="rowHandle"></param>
        /// <param name="view"></param>
        public GetButtonCaptionEventArgs(EditorButton button, GridColumn column, int rowHandle, GridView view)
        {
            _Button = button;
            _Column = column;
            _RowHandle = rowHandle;
            _View = view;
            _ButtonText = button.Caption;
        }

        public GridView View
        {
            get { return _View; }
            set
            {
                _View = value;

            }
        }


        public int RowHandle
        {
            get { return _RowHandle; }
            set
            {
                _RowHandle = value;

            }
        }

        public GridColumn Column
        {
            get { return _Column; }
            set
            {
                _Column = value;

            }
        }


        public EditorButton Button
        {
            get { return _Button; }
            set
            {
                _Button = value;

            }
        }



        public string ButtonText
        {
            get { return _ButtonText; }
            set
            {
                _ButtonText = value;

            }
        }
    }
}
