using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace varios_formulários
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Insira nome no campo !!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox1.Focus();
                return;
            }
        //else opcional

        textBox2.Text += textBox1.Text + ", ";
            textBox1.Clear();
            textBox1.Focus();
            }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = " ";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(textBox2.Text);
            form2.ShowDialog();
        }
    }
}
