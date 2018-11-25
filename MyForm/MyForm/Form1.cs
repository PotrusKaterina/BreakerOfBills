using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyForm.Properties;



namespace MyForm
{
    public partial class Form1 : Form
    {
        private double summ, sale, people;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            string instraction1 = ("How mach do you need to pay?");
            MessageBox.Show(instraction1); 
        }
        private void label2_Click(object sender, EventArgs e)
        {
            string instraction2 = ("How mach people have to pay?");
            MessageBox.Show(instraction2);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            string instraction3 = ("Do you have sales?");
            MessageBox.Show(instraction3);
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
             summ = Convert.ToDouble(textBox1.Text);
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            people = Convert.ToDouble(textBox2.Text);
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            sale = Convert.ToDouble(textBox3.Text);
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            BreakAccountLayer account = new BreakeAccount();
            account.AccountBreake(summ,sale,people);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }       
    }
}
