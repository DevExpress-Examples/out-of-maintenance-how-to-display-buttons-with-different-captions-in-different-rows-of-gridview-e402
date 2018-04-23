using System;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.Drawing;
using DevExpress.XtraEditors.ViewInfo;
using DevExpress.XtraEditors.Controls;
using System.Collections.Generic;

namespace WindowsApplication1
{
    public class ExtendedButtonEditViewInfo : ButtonEditViewInfo
    {
        public ExtendedButtonEditViewInfo(RepositoryItem item)
            : base(item)
        {

        }
        protected override EditorButtonPainter CreateButtonPainter()
        {
            ExtendedSkinEditorButtonPainter painter = new ExtendedSkinEditorButtonPainter(LookAndFeel);
            painter.OwnerEditInfo = this;
            return painter;
        }

        // Fields...
        private Dictionary<EditorButton, string> _CustomButtonCaptions = new Dictionary<EditorButton,string>();

        public Dictionary<EditorButton, string> CustomButtonCaptions
        {
            get { return _CustomButtonCaptions; }
            set
            {
                _CustomButtonCaptions = value;
            }
        }
        public string GetButtonCaption(EditorButton button)
        {
            string text = string.Empty;
            if (!CustomButtonCaptions.TryGetValue(button, out text)) 
                text = button.Caption;
            return text;
        }

    }
}