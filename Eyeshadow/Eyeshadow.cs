using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Serialization;
using Serialization.ClassMakeup;

namespace Eyeshadow
{
    public class EyeshadowClass : MakeupClass
    {
        public string Type; //matt, perl
        public string Format; //compact, pencil, liquid

        public EyeshadowClass()
        {}

        public override void GetValues(List<string> paramList)
        {
            base.GetValues(paramList);
            paramList.Add(Type);
            paramList.Add(Format);
        }

        public override void SetValues(List<string> paramList)
        {
            base.SetValues(paramList);
            int i = 4;
            Type = paramList[i++];
            Format = paramList[i];
        }

        public override void SetLabels(Form1 form1)
        {
            base.SetLabels(form1);
            form1.textBoxType.Visible = true;
            form1.labelType.Visible = true;
            form1.textBox2.Visible = true;
            form1.label1.Text = "Format :";
            form1.label1.Visible = true;
        } 

    }
}
