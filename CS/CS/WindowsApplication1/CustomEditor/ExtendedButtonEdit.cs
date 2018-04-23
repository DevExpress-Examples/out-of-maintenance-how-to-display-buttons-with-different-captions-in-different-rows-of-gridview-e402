using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.Registrator;

namespace WindowsApplication1
{
  [System.ComponentModel.DesignerCategory("")]
    public class ExtendedButtonEdit : ButtonEdit
    {
        static ExtendedButtonEdit()
        {
            RepositoryItemExtendedButtonEdit.Register();
        }
     
        public override string EditorTypeName
        {
            get { return RepositoryItemExtendedButtonEdit.EditorName; }
        }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public new RepositoryItemExtendedButtonEdit Properties
        {
            get { return base.Properties as RepositoryItemExtendedButtonEdit; }
        }
    }
}