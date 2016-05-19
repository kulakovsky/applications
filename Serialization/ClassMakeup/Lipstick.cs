using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Serialization.ClassMakeup
{
    public class LipstickClass : MakeupClass
    {
        public string Texture { get; set; } //dull or brilliant or pearl
        public string Type { get; set; } //chapstick or moisturizing or nourishing

        public LipstickClass()
        { }

        public override void GetValues(List<string> paramList)
        {
            base.GetValues(paramList);
            paramList.Add(Type);
            paramList.Add(Texture);
        }

        public override void SetValues(List<string> paramList)
        {
            base.SetValues(paramList);
            int i = 4;
            Type = paramList[i++];
            Texture = paramList[i];
        }

        public override void SetLabels(Form1 form1)
        {
            base.SetLabels(form1);
            form1.textBoxType.Visible = true;
            form1.labelType.Text = "Type";
            form1.labelType.Visible = true;
            form1.textBox2.Visible = true;
            form1.label1.Text = "Texture :";
            form1.label1.Visible = true;
        } 

    }

}
