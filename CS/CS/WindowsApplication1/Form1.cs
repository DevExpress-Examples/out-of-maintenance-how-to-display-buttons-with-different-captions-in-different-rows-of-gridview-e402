using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WindowsApplication1.CustomEditor;

namespace WindowsApplication1
{
    public partial class Form1 : Form
    {
        private DataTable CreateTable(int RowCount)
        {
            DataTable tbl = new DataTable();
            tbl.Columns.Add("Name", typeof(string));
            tbl.Columns.Add("ID", typeof(int));
            tbl.Columns.Add("Number", typeof(int));
            tbl.Columns.Add("Date", typeof(DateTime));
            for (int i = 0; i < RowCount; i++)
                tbl.Rows.Add(new object[] { String.Format("Name{0}", i), i, 3 - i, DateTime.Now.AddDays(i) });
            return tbl;
        }

        public Form1()
        {
            InitializeComponent();
            gridControl1.DataSource = CreateTable(20);
            ButtonEditCustomCaptionHelper.Register(gridView1.Columns[0], OnGetButtonCaption);
            ButtonEditCustomCaptionHelper.Register(gridView1.Columns[1], OnGetButtonCaption);
        }

        public void OnGetButtonCaption(ButtonEditCustomCaptionHelper helper, GetButtonCaptionEventArgs args)
        {
            if (args.RowHandle == 2)
                return;
            args.ButtonText = String.Format("{0};{1};Button{2}", args.Column.VisibleIndex, args.RowHandle, args.Button.Index);
        }
    }
}