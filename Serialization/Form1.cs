using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;
using Serialization.ClassMakeup;
using Serialization.FactoryAdd;
using System.Reflection;

namespace Serialization
{
    public partial class Form1 : Form
    {        
        const int n = 6;
        public List<FactoryMakeup> factory = new List<FactoryMakeup>();
        List<MakeupClass> MakeupList = new List<MakeupClass>();
        List<MakeupClass> MakeupListDes = new List<MakeupClass>();
        bool flagEdit = false, flagDelete = false;
        public List<Type> extraTypes = new List<Type>();
        List<TextBox> textBoxList = new List<TextBox>();
        List<string> paramList = new List<string>();
        public List<MakeupClass> setterLabels = new List<MakeupClass>();
        int i;

        public bool checkPlugin(string dllFile)
        {
            var sha1Hasher = new System.Security.Cryptography.SHA1CryptoServiceProvider();

            System.IO.FileInfo fileInfo = new System.IO.FileInfo(dllFile);
            long size = fileInfo.Length;

            int buffer = 0;
            byte[] bytes = new byte[size];
            int i = 0;

            FileStream file = new FileStream(dllFile, FileMode.Open);

            buffer = file.ReadByte();
            while (buffer != -1)
            {
                bytes[i++] = (byte)buffer;
                buffer = file.ReadByte();
            }

            byte[] hashBytes = new byte[size];
            hashBytes = sha1Hasher.ComputeHash(bytes);
            long hashSum = 0;
            foreach (byte oneByte in hashBytes)
            {
                hashSum = hashSum + (long)oneByte;
            }

            DateTime lastChanged = File.GetLastWriteTime(dllFile);
            hashSum = hashSum + lastChanged.GetHashCode();

            file.Close();

            int valueCheckSum;
            string nameCheckFile = dllFile.Replace("dll","pdb");
            try
            {
                StreamReader checkFile = new StreamReader(nameCheckFile);
                string checkSum;
                if ((checkSum = checkFile.ReadLine()) != null)
                {
                    if (!(int.TryParse(checkSum, out valueCheckSum)))
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }

            if (hashSum != valueCheckSum)
            {
                return false;
            }

            return true;
        }
        
        public Form1()
        {
            InitializeComponent();  
 
            textBoxList.Add(textBoxProducer);
            textBoxList.Add(textBoxColor);
            textBoxList.Add(textBoxPrice);
            textBoxList.Add(textBoxType);
            textBoxList.Add(textBox2);

            factory.Add(new FactoryBlush());
            factory.Add(new FactoryFoundation());
            factory.Add(new FactoryLipstick());
            factory.Add(new FactoryMascara());
            factory.Add(new FactoryNailPolish());
            factory.Add(new FactoryPowder());

            extraTypes.Add(typeof(BlushClass));
            extraTypes.Add(typeof(FoundationClass));
            extraTypes.Add(typeof(LipstickClass));
            extraTypes.Add(typeof(MascaraClass));
            extraTypes.Add(typeof(NailPolishClass));
            extraTypes.Add(typeof(PowderClass));

            setterLabels.Add(new BlushClass());
            setterLabels.Add(new FoundationClass());
            setterLabels.Add(new LipstickClass());
            setterLabels.Add(new MascaraClass());
            setterLabels.Add(new NailPolishClass());
            setterLabels.Add(new PowderClass());

            try
            {
                string[] dllFilesName = null;
                List<string> plugins = new List<string>();

                if (Directory.Exists(Constants.PluginsPath))
                {
                    dllFilesName = Directory.GetFiles(Constants.PluginsPath, "*.dll");
                    labelInfo.Text = "Could'n be loaded ";

                    foreach (string dllFile in dllFilesName)
                    {
                        if (checkPlugin(dllFile))
                        {
                            plugins.Add(dllFile);
                        }
                        else
                        {
                            labelInfo.Text = labelInfo.Text + dllFile + " ";
                            labelInfo.Visible = true;
                        }
                    }

                    if (plugins.Count > 0)
                    {
                        ICollection<IPlugin> loadedPlugins = LoadPlugin.Load(plugins);
                        foreach (IPlugin plugin in loadedPlugins)
                        {
                            plugin.Include(this);
                        }
                    }
                }
            }
            catch
            {
                labelInfo.Text = "Plugin could'n be loaded (check the path of plugin)";
                labelInfo.Visible = true;
            }

            paramList.Add("Blush");
            paramList.Add("Oriflame");
            paramList.Add("red");
            paramList.Add("5");
            paramList.Add("saricoban");
            BlushClass blush = new BlushClass();
            blush.SetValues(paramList);
            MakeupList.Add(blush);
            listBox1.Items.Add(blush.Name + "   " + blush.Producer);
        }        

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach(TextBox textBox in textBoxList)
            {
                textBox.Text = "";
            }
            setterLabels[comboBox1.SelectedIndex].SetLabels(this);
        }

        private bool checkInput()
        {
            int temp;
            if ((textBoxProducer.Text != "") & (textBoxColor.Text != "") & (int.TryParse(textBoxPrice.Text, out temp)) & ((textBoxType.Visible == true & (textBoxType.Text != "") | (!textBoxType.Visible)) & (textBox2.Visible == true & (textBox2.Text != "") | (!textBox2.Visible))))
                return true;
            return false;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                paramList.Clear();
                if ((!flagEdit) && (!flagDelete))
                {
                    MakeupList[listBox1.SelectedIndex].SetLabels(this);
                    comboBox1.DropDownStyle = ComboBoxStyle.DropDown;
                    comboBox1.Text = MakeupList[listBox1.SelectedIndex].Name;
                    MakeupList[listBox1.SelectedIndex].GetValues(paramList);
                    for (i = 0; i < paramList.Count; i++)
                        textBoxList[i].Text = paramList[i];
                    comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
                }
            }
            catch
            {
                labelInfo.Text = "You didn't choose the object";
                labelInfo.Visible = true;
            }
        }
        
        private void buttonOK_Click(object sender, EventArgs e)
        {
            paramList.Clear();
            if (radioButtonAdd.Checked)
            {
                labelInfo.Visible = false;
                if (checkInput())
                {
                    MakeupClass makeup = factory[comboBox1.SelectedIndex].FactoryAdd();
                    makeup.SetLabels(this);
                    paramList.Add(comboBox1.GetItemText(comboBox1.SelectedItem));
                    for (i = 1; i <= textBoxList.Count; i++)
                        if (textBoxList[i-1].Text != "")
                            paramList.Add(textBoxList[i-1].Text);
                    makeup.SetValues(paramList);
                    MakeupList.Add(makeup);
                    listBox1.Items.Add(makeup.Name + "   " + makeup.Producer);
                }
                else
                {
                    labelInfo.Text = "Check the input values";
                    labelInfo.Visible = true;
                }
            }

            if (radioButtonEdit.Checked)
            {
                if (listBox1.SelectedIndex != -1)
                {
                    labelInfo.Visible = false;
                    if (checkInput())
                    {
                        paramList.Add(comboBox1.GetItemText(comboBox1.SelectedItem));
                        for (i = 1; i <= textBoxList.Count; i++)
                            if (textBoxList[i - 1].Text != "")
                                paramList.Add(textBoxList[i - 1].Text);
                        MakeupList[listBox1.SelectedIndex].Name = comboBox1.GetItemText(comboBox1.SelectedItem);
                        MakeupList[listBox1.SelectedIndex].SetValues(paramList);
                        flagEdit = true;
                        listBox1.Items[listBox1.SelectedIndex] = MakeupList[listBox1.SelectedIndex].Name + "   " + MakeupList[listBox1.SelectedIndex].Producer;
                        flagEdit = false;
                    }
                    else
                    {
                        labelInfo.Text = "Check the input values";
                        labelInfo.Visible = true;
                    }
                }
                else
                {
                    labelInfo.Text = "Choose the object";
                    labelInfo.Visible = true;
                }
            }

            if (radioButtonDelete.Checked)
            {
                if (listBox1.SelectedIndex != -1)
                {
                    MakeupList.Remove(MakeupList[listBox1.SelectedIndex]);
                    flagDelete = true;
                    listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                    flagDelete = false;
                }
                else
                {
                    labelInfo.Text = "Choose the object";
                    labelInfo.Visible = true;
                }
            }
        }

        private void buttonSerialize_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    if (MakeupList.Count > 0)
                    {
                        XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<MakeupClass>), extraTypes.ToArray());
                        System.IO.StreamWriter file = new System.IO.StreamWriter(openFileDialog1.FileName);

                        xmlSerializer.Serialize(file, MakeupList);
                        file.Close();

                        labelInfo.Text = "Serialization completed successfully(results in" + openFileDialog1.FileName + ")";
                        labelInfo.Visible = true;
                    }
                    else
                    {
                        labelInfo.Text = "The list doesn't contain objects";
                        labelInfo.Visible = true;
                    }
                }
                else
                {
                    labelInfo.Text = "Check the file";
                    labelInfo.Visible = true;
                }
            }
            catch
            {
                labelInfo.Text = "Check the object(s) in list";
                labelInfo.Visible = true;
            }
        }

        private void buttonChooseFile_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    listBox2.Items.Clear();
                    MakeupListDes.Clear();
                    System.IO.StreamReader sr = new System.IO.StreamReader(openFileDialog1.FileName);

                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<MakeupClass>), extraTypes.ToArray());

                    List<MakeupClass> MakeupList = (List<MakeupClass>)xmlSerializer.Deserialize(sr);

                    foreach (MakeupClass element in MakeupList)
                    {
                        listBox2.Items.Add(element.Name + "   " + element.Producer);
                        MakeupListDes.Add(element);
                    }
                    sr.Close();

                    labelInfo.Text = "Deserialization completed successfully";
                    labelInfo.Visible = true;
                }
            }
            catch
            {
                labelInfo.Text = "Check the file";
                labelInfo.Visible = true;
            }            
        }

        private void listBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                paramList.Clear();
                MakeupListDes[listBox2.SelectedIndex].SetLabels(this);
                comboBox1.DropDownStyle = ComboBoxStyle.DropDown;
                comboBox1.Text = MakeupListDes[listBox2.SelectedIndex].Name;
                MakeupListDes[listBox2.SelectedIndex].GetValues(paramList);
                for (i = 0; i < paramList.Count; i++)
                    textBoxList[i].Text = paramList[i];
                comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            }
            catch
            {
                labelInfo.Text = "You didn't choose the object";
                labelInfo.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
