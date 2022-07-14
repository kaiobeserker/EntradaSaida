using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntradaSaida
{
    public partial class Form1 : Form
    {
        string name = "";
        string sobrenome = "";
        int data = 0;

          
        public Form1()
        {
            InitializeComponent();
        }

       

        private void btlogin_Click(object sender, EventArgs e)
        {
            name = txtnome.Text;
            sobrenome = txtSobrenome.Text;
            data = int.Parse(textano.Text);

            int anoatual = int.Parse(DateTime.Now.ToString("yyyy"));

            int idade = anoatual - data;

            if(idade >= 18)
            {
                labelvictoria.Text = "aprovado";
                labelvictoria.BackColor = Color.Green;
                pictureBox2.Image = Properties.Resources.caveira_da_capoeira_break_dance;

            }
            else
            {
                labelvictoria.Text = "recusado";
                labelvictoria.BackColor = Color.Red;
                pictureBox2.Image = Properties.Resources.caveira05;

            }


        }

        private void txtSobrenome_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
