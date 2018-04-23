using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.Registrator;
using DevExpress.XtraEditors.Drawing;
using DevExpress.XtraEditors.ViewInfo;

namespace WindowsApplication1 {
    [System.ComponentModel.DesignerCategory("")]
	[UserRepositoryItem("Register")]
	public class RepositoryItemExtendedButtonEdit : RepositoryItemButtonEdit { 
		static RepositoryItemExtendedButtonEdit() { 
			Register(); 
		}
		public RepositoryItemExtendedButtonEdit() 
        {
        }
		
		internal const string EditorName = "MyButtonEdit";

  

        public static void Register()
        {
            EditorRegistrationInfo.Default.Editors.Add(new EditorClassInfo(EditorName, typeof(ExtendedButtonEdit),
                typeof(RepositoryItemExtendedButtonEdit), typeof(ExtendedButtonEditViewInfo),
                new ButtonEditPainter(), true, null));
        }
		public override string EditorTypeName { 
			get { return EditorName; } 
		}

	}
 
}