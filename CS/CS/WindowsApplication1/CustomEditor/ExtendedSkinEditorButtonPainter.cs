using System;
using DevExpress.XtraEditors.Drawing;
using DevExpress.Skins;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.ViewInfo;

namespace WindowsApplication1
{
    public class ExtendedSkinEditorButtonPainter : SkinEditorButtonPainter
    {
        public ExtendedSkinEditorButtonPainter(DevExpress.Skins.ISkinProvider provider)
            : base(provider)
        {
            
        }

        // Fields...

        public BaseEditViewInfo OwnerEditInfo { get; set; }

        protected override void DrawContent(DevExpress.Utils.Drawing.ObjectInfoArgs e)
        {
            EditorButtonObjectInfoArgs ee = e as EditorButtonObjectInfoArgs;
            string caption = ((ExtendedButtonEditViewInfo)OwnerEditInfo).GetButtonCaption(ee.Button);
            ButtonPainter.DrawCaption(ee, caption, ee.Appearance.Font, GetForeBrush(ee), e.Bounds, ee.Appearance.GetStringFormat());
        }
  
    }
}