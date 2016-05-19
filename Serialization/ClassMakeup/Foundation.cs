using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Serialization.ClassMakeup
{
    public class FoundationClass: MakeupClass
    {
        public string Type { get; set; } //cover up or hydrant

        public FoundationClass()
        { }

        public override void GetValues(List<string> paramList)
        {
            base.GetValues(paramList);
            paramList.Add(Type);
        }

        public override void SetValues(List<string> paramList)
        {
            base.SetValues(paramList);
            int i = 4;
            Type = paramList[i];
        }

        public override void SetLabels(Form1 form1)
        {
            base.SetLabels(form1);
            form1.labelType.Text = "Type";
            form1.textBoxType.Visible = true;
            form1.labelType.Visible = true;
        }

    }

}
