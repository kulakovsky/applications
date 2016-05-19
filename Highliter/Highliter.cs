using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Serialization;
using Serialization.ClassMakeup;
using System.Windows.Forms;

namespace Highliter
{
    public class HighliterClass : MakeupClass
    {
        public string Appointment; //for body, for face

        public HighliterClass()
        { }

        public override void GetValues(List<string> paramList)
        {
            base.GetValues(paramList);
            paramList.Add(Appointment);
        }

        public override void SetValues(List<string> paramList)
        {
            base.SetValues(paramList);
            int i = 4;
            Appointment = paramList[i];
        }

        public override void SetLabels(Form1 form1)
        {
            base.SetLabels(form1);
            form1.textBoxType.Visible = true;
            form1.labelType.Text = "Appointment :";
            form1.labelType.Visible = true;
        }

    }
}
