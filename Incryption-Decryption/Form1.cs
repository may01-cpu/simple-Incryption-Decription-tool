using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Incryption_Decryption
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

    

        string EncryptText(string Text, short EncryptionKey)
        {
            char[] enc = Text.ToCharArray();
            for (int i = 0; i < enc.Length; i++)
            {
                enc[i] = (char)(enc[i] + EncryptionKey);
            }
            return new string(enc);
        }
        string DecryptText(string Text, short EncryptionKey)
        {
            char[] enc = Text.ToCharArray();
            for (int i = 0; i < enc.Length; i++)
            {
                enc[i] = (char)(enc[i] - EncryptionKey);
            }
            return new string(enc);
        }
        private void button1_Click(object sender, EventArgs e)
        {

            if (!ValidateChildren()) return;
            short key = (short)numericUpDown1.Value;
            TbEncrypt.Text = EncryptText(textBox1.Text.Trim(), key);

        }

        private void button2_Click(object sender, EventArgs e) 
        {
            if(!ValidateChildren()) return;
            short key = (short)numericUpDown1.Value;
            TbDecrypt.Text = DecryptText(textBox4.Text.Trim(), key);
        }

        private void numericUpDown1_Validating(object sender, CancelEventArgs e)
        {
            if (numericUpDown1.Value <= 0)
            {
                e.Cancel = true;
                numericUpDown1.Focus();
                errorProvider1.SetError(numericUpDown1, "You must enter a positive key");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(numericUpDown1, "");
             

            }
        }

      
    }
}
