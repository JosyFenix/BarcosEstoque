using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjInicial
{
    public partial class Painel_Embarcação : Form
    {
        public Painel_Embarcação()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            String nomeProduto = textBox1.Text;
            String localizaProduto = textBox2.Text;
            Barco b1 = new Barco();
            b1.connectionBarcos();
            if ((nomeProduto!= null) && (localizaProduto != null))
                b1.cadastraBarco(localizaProduto, nomeProduto);
            Barco b2 = new Barco();
           


            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String nomeProduto = textBox1.Text;
            String localizaProduto = textBox2.Text;
            Barco b1 = new Barco();
            //b1.connectionBarcos();
            if ((nomeProduto != null) && (localizaProduto != null))
                b1.cadastraBarco(localizaProduto, nomeProduto);
            textBox1.Text = "";
            textBox2.Text = "";
            Nova_Embarcação_Cadastrada embarca1 = new Nova_Embarcação_Cadastrada();
            embarca1.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            lista_de_Embarcações listaEmbark = new lista_de_Embarcações();
            listaEmbark.Show();
            this.Hide();
            /*
            String nomeProduto = textBox1.Text;
            String localizaProduto = textBox2.Text;
            Barco b1 = new Barco();
            //b1.connectionBarcos();
            if ((nomeProduto != null) && (localizaProduto != null))
                b1.buscaBarco(localizaProduto, nomeProduto);
            textBox1.Text = "";
            textBox2.Text = "";
            //Lista_de_Barcos listaBarcos = new Lista_de_Barcos();
            //listaBarcos.Show();
            this.Hide();
            */
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
