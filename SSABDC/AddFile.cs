using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SSABDC
{
    public partial class AddFile : Form
    {
        string filePath;
        private OpenFileDialog fileDialog;

        public AddFile()
        {
            InitializeComponent();
            if (Form1.instance.Level== 1) 
            {
                comboBox1.Items.Add("Base");
            }
            else if (Form1.instance.Level == 2)
            {
                comboBox1.Items.Add("Base");
                comboBox1.Items.Add("Authorized");
            }
            else if (Form1.instance.Level == 3)
            {
                comboBox1.Items.Add("Base");
                comboBox1.Items.Add("Authorized");
                comboBox1.Items.Add("Encryption");
            }
            else if (Form1.instance.Level == 4)
            {
                comboBox1.Items.Add("Base");
                comboBox1.Items.Add("Authorized");
                comboBox1.Items.Add("Encryption");
                comboBox1.Items.Add("Biometrics");
            }
        }

        private void chooseFilename_Click(object sender, EventArgs e)
        {
            fileDialog = new OpenFileDialog();
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = fileDialog.FileName;
                textBox1.Text = filePath;
            }
        }

        private void addFileButtonForm_Click(object sender, EventArgs e)
        {
            Form1.instance.AddFile(filePath, Converts.GetLevelFromString((string)comboBox1.SelectedItem));
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            filePath = textBox1.Text;
        }
    }
}
