using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Serialization.ClassMakeup
{
    public class MakeupClass
    {
        public string Name { get; set; }
        public string Producer{ get; set; }
        public float Price { get; set; }
        public string Color { get; set; }

        public MakeupClass()
        { }

        public virtual void GetValues(List<string> paramList)
        {
            paramList.Add(Producer);
            paramList.Add(Color);
            paramList.Add(Convert.ToString(Price));
        }

        public virtual void SetValues(List<string> paramList)
        {
            int i = 0;
            Name = paramList[i++];
            Producer = paramList[i++];
            Color = paramList[i++];
            Price = Convert.ToInt16(paramList[i++]);
        }

        public virtual void SetLabels(Form1 form1)
        {
            form1.textBoxType.Visible = false;
            form1.textBox2.Visible = false;
            form1.labelType.Visible = false;
            form1.label1.Visible = false;
            form1.labelInfo.Visible = false;

        }
    }

}
