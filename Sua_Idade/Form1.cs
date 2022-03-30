using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sua_Idade
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void result_Click(object sender, EventArgs e)
        {

           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sexo="";
            if (radioM.Checked)
            {
                sexo = "Masculino";
            }
            if (radioF.Checked)
            {
                sexo = "Feminino";
            }
            string nome = namebox.Text;
            int anoAtual = int.Parse(cyearbox.Text);
            int anoNasc = int.Parse(byearbox.Text);

            result.Text = 
             "Nome: " + namebox.Text + "\n"+
             "Idade atual: " + (anoAtual - anoNasc)+ "anos" + "\n" 
             + "Sexo: " + sexo + "\n" + 
             "Idade em 2050:  " + (2050 - anoNasc) + "anos";
        }

        private void cyearbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
