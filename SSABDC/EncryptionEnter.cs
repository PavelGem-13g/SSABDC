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
    public partial class EncryptionEnter : Form
    {
        public EncryptionEnter()
        {
            InitializeComponent();
        }

        private void encryptionButton_Click(object sender, EventArgs e)
        {
            Form1.instance.SetEncryptionCode(textBox1.Text);
        }
    }
}
