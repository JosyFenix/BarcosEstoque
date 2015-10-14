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
    public partial class Painel_Produtos : Form
    {
        public Painel_Produtos()
        {
            InitializeComponent();
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool preenchido = false;
            //String nomeProduto = "";
            int quant = -999999;
            String textoAux = textBox1.Text;
            if(textoAux != "") 
                quant = Int32.Parse(textoAux);
            String nomeProduto = "";
            nomeProduto = textBox2.Text;
            Item it = new Item();
            it.connectionItem();
            if ((quant == -999999) || (nomeProduto == ""))
            {
                MessageBox.Show("Complete Todos os Campos! ", "Importante", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation,
                    MessageBoxDefaultButton.Button1);
            }
            else //se entrar aki é pq os dois campos estao preenchidos!!!!
            {
                preenchido = true;
            }

            if ((nomeProduto != null) && (quant != -999999))
                if ((nomeProduto != "") && (quant != -999999) && (preenchido))
                {
                    it.cadastraItem(quant, nomeProduto);
                    MessageBox.Show("Produto Cadastrada com Sucesso!", "Cadastrada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            textBox1.Text = "";
            textBox2.Text = "";
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool preenchido = false;
            //String nomeProduto = "";
            int quant = -999999;
            String textoAux = textBox1.Text;
            if (textoAux != "") 
                 quant = Int32.Parse(textBox1.Text);
            String nomeProduto = "";
            nomeProduto = textBox2.Text;
            Item it = new Item();
            it.connectionItem();
            if ((quant == -999999) || (nomeProduto == ""))
            {
                MessageBox.Show("Complete Todos os Campos! ", "Importante", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation,
                    MessageBoxDefaultButton.Button1);
            }
            else //se entrar aki é pq os dois campos estao preenchidos!!!!
            {
                preenchido = true;
            }

            if ((nomeProduto != null) && (quant != -999999))
                if ((nomeProduto != "") && (quant != -999999) && (preenchido))
                {
                    if (MessageBox.Show("Tem Certeza que Deseja Excluir o Produto?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        it.excluiItem(quant,nomeProduto);
                        MessageBox.Show("Produto Excluído com Sucesso!", "Excluído", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }


            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 formula2 = new Form2();
            formula2.Show();
            this.Hide();
        }
    }
}
