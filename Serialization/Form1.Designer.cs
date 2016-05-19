namespace Serialization
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        public void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelProducer = new System.Windows.Forms.Label();
            this.labelColor = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelType = new System.Windows.Forms.Label();
            this.textBoxProducer = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.textBoxType = new System.Windows.Forms.TextBox();
            this.textBoxColor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.labelInfo = new System.Windows.Forms.Label();
            this.buttonSerialize = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.buttonDeserialize = new System.Windows.Forms.Button();
            this.radioButtonAdd = new System.Windows.Forms.RadioButton();
            this.radioButtonEdit = new System.Windows.Forms.RadioButton();
            this.radioButtonDelete = new System.Windows.Forms.RadioButton();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(15, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(251, 148);
            this.listBox1.TabIndex = 2;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Blush",
            "Foundation",
            "Lipstick",
            "Mascara",
            "NailPolish",
            "Powder"});
            this.comboBox1.Location = new System.Drawing.Point(133, 32);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // labelProducer
            // 
            this.labelProducer.AutoSize = true;
            this.labelProducer.Location = new System.Drawing.Point(133, 63);
            this.labelProducer.Name = "labelProducer";
            this.labelProducer.Size = new System.Drawing.Size(78, 17);
            this.labelProducer.TabIndex = 5;
            this.labelProducer.Text = "Producer : ";
            // 
            // labelColor
            // 
            this.labelColor.AutoSize = true;
            this.labelColor.Location = new System.Drawing.Point(290, 15);
            this.labelColor.Name = "labelColor";
            this.labelColor.Size = new System.Drawing.Size(49, 17);
            this.labelColor.TabIndex = 6;
            this.labelColor.Text = "Color :";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(290, 64);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(48, 17);
            this.labelPrice.TabIndex = 7;
            this.labelPrice.Text = "Price :";
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(450, 13);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(48, 17);
            this.labelType.TabIndex = 8;
            this.labelType.Text = "Type :";
            this.labelType.Visible = false;
            // 
            // textBoxProducer
            // 
            this.textBoxProducer.Location = new System.Drawing.Point(133, 86);
            this.textBoxProducer.Name = "textBoxProducer";
            this.textBoxProducer.Size = new System.Drawing.Size(121, 22);
            this.textBoxProducer.TabIndex = 9;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(290, 84);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(121, 22);
            this.textBoxPrice.TabIndex = 10;
            // 
            // textBoxType
            // 
            this.textBoxType.Location = new System.Drawing.Point(450, 33);
            this.textBoxType.Name = "textBoxType";
            this.textBoxType.Size = new System.Drawing.Size(121, 22);
            this.textBoxType.TabIndex = 11;
            this.textBoxType.Visible = false;
            // 
            // textBoxColor
            // 
            this.textBoxColor.Location = new System.Drawing.Point(290, 34);
            this.textBoxColor.Name = "textBoxColor";
            this.textBoxColor.Size = new System.Drawing.Size(121, 22);
            this.textBoxColor.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(452, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(450, 84);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(121, 22);
            this.textBox2.TabIndex = 14;
            this.textBox2.Visible = false;
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Location = new System.Drawing.Point(23, 360);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(46, 17);
            this.labelInfo.TabIndex = 15;
            this.labelInfo.Text = "label2";
            this.labelInfo.Visible = false;
            // 
            // buttonSerialize
            // 
            this.buttonSerialize.Location = new System.Drawing.Point(145, 176);
            this.buttonSerialize.Name = "buttonSerialize";
            this.buttonSerialize.Size = new System.Drawing.Size(121, 26);
            this.buttonSerialize.TabIndex = 16;
            this.buttonSerialize.Text = "Serialize";
            this.buttonSerialize.UseVisualStyleBackColor = true;
            this.buttonSerialize.Click += new System.EventHandler(this.buttonSerialize_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(12, 175);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(73, 27);
            this.buttonOK.TabIndex = 20;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // buttonDeserialize
            // 
            this.buttonDeserialize.Location = new System.Drawing.Point(302, 176);
            this.buttonDeserialize.Name = "buttonDeserialize";
            this.buttonDeserialize.Size = new System.Drawing.Size(121, 26);
            this.buttonDeserialize.TabIndex = 22;
            this.buttonDeserialize.Text = "Deserialize";
            this.buttonDeserialize.UseVisualStyleBackColor = true;
            this.buttonDeserialize.Click += new System.EventHandler(this.buttonChooseFile_Click);
            // 
            // radioButtonAdd
            // 
            this.radioButtonAdd.AutoSize = true;
            this.radioButtonAdd.Location = new System.Drawing.Point(14, 32);
            this.radioButtonAdd.Name = "radioButtonAdd";
            this.radioButtonAdd.Size = new System.Drawing.Size(54, 21);
            this.radioButtonAdd.TabIndex = 26;
            this.radioButtonAdd.TabStop = true;
            this.radioButtonAdd.Text = "Add";
            this.radioButtonAdd.UseVisualStyleBackColor = true;
            // 
            // radioButtonEdit
            // 
            this.radioButtonEdit.AutoSize = true;
            this.radioButtonEdit.Location = new System.Drawing.Point(14, 59);
            this.radioButtonEdit.Name = "radioButtonEdit";
            this.radioButtonEdit.Size = new System.Drawing.Size(53, 21);
            this.radioButtonEdit.TabIndex = 27;
            this.radioButtonEdit.TabStop = true;
            this.radioButtonEdit.Text = "Edit";
            this.radioButtonEdit.UseVisualStyleBackColor = true;
            // 
            // radioButtonDelete
            // 
            this.radioButtonDelete.AutoSize = true;
            this.radioButtonDelete.Location = new System.Drawing.Point(14, 86);
            this.radioButtonDelete.Name = "radioButtonDelete";
            this.radioButtonDelete.Size = new System.Drawing.Size(70, 21);
            this.radioButtonDelete.TabIndex = 28;
            this.radioButtonDelete.TabStop = true;
            this.radioButtonDelete.Text = "Delete";
            this.radioButtonDelete.UseVisualStyleBackColor = true;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(302, 12);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(308, 148);
            this.listBox2.TabIndex = 29;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(399, 85);
            this.label2.TabIndex = 30;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxProducer);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.labelProducer);
            this.groupBox1.Controls.Add(this.radioButtonDelete);
            this.groupBox1.Controls.Add(this.labelColor);
            this.groupBox1.Controls.Add(this.radioButtonEdit);
            this.groupBox1.Controls.Add(this.labelPrice);
            this.groupBox1.Controls.Add(this.radioButtonAdd);
            this.groupBox1.Controls.Add(this.labelType);
            this.groupBox1.Controls.Add(this.textBoxPrice);
            this.groupBox1.Controls.Add(this.textBoxType);
            this.groupBox1.Controls.Add(this.textBoxColor);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 218);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(598, 129);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 380);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(598, 118);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 510);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.buttonDeserialize);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.buttonSerialize);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        public void SetLabels()
        {
            textBoxType.Visible = false;
            textBox2.Visible = false;
            labelType.Visible = false;
            label1.Visible = false;
            labelInfo.Visible = false;
            textBoxProducer.Text = "";
            textBoxColor.Text = "";
            textBoxPrice.Text = "";
            textBoxType.Text = "";
            textBox2.Text = "";

            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    textBoxType.Visible = true;
                    labelType.Visible = true;
                    break;
                case 1:
                    textBoxType.Visible = true;
                    labelType.Visible = true;
                    break;
                case 2:
                    textBoxType.Visible = true;
                    labelType.Visible = true;
                    textBox2.Visible = true;
                    label1.Text = "Texture :";
                    label1.Visible = true;
                    break;
                case 3:
                    textBoxType.Visible = true;
                    labelType.Visible = true;
                    textBox2.Visible = true;
                    label1.Text = "Waterproof :";
                    label1.Visible = true;
                    break;
                case 4:
                    break;
                case 5:
                    textBoxType.Visible = true;
                    labelType.Visible = true;
                    break;
            }
        }

        #endregion

        public System.Windows.Forms.ListBox listBox1;
        public System.Windows.Forms.ComboBox comboBox1;
        public System.Windows.Forms.Label labelProducer;
        public System.Windows.Forms.Label labelColor;
        public System.Windows.Forms.Label labelPrice;
        public System.Windows.Forms.Label labelType;
        public System.Windows.Forms.TextBox textBoxProducer;
        public System.Windows.Forms.TextBox textBoxPrice;
        public System.Windows.Forms.TextBox textBoxType;
        public System.Windows.Forms.TextBox textBoxColor;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox textBox2;
        public System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Button buttonSerialize;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button buttonDeserialize;
        private System.Windows.Forms.RadioButton radioButtonAdd;
        private System.Windows.Forms.RadioButton radioButtonEdit;
        private System.Windows.Forms.RadioButton radioButtonDelete;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

