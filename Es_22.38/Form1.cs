using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Es_22._38
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!float.TryParse(textBox1.Text, out float a) || !float.TryParse(textBox2.Text, out float b))
            {
                MessageBox.Show("Errore: uno dei due numeri non è valido.");
                return;
            }
            listBox1.Items.Add(a + b);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!float.TryParse(textBox1.Text, out float a) || !float.TryParse(textBox2.Text, out float b))
            {
                MessageBox.Show("Errore: uno dei due numeri non è valido.");
                return;
            }
            listBox1.Items.Add(a - b);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!float.TryParse(textBox1.Text, out float a) || !float.TryParse(textBox2.Text, out float b))
            {
                MessageBox.Show("Errore: uno dei due numeri non è valido.");
                return;
            }
            listBox1.Items.Add(a * b);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!float.TryParse(textBox1.Text, out float a) || !float.TryParse(textBox2.Text, out float b))
            {
                MessageBox.Show("Errore: uno dei due numeri non è valido.");
                return;
            }
            listBox1.Items.Add(a / b);
        }
    }
}
