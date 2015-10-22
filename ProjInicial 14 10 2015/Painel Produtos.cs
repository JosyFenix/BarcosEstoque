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
            bool resposta;
            //String nomeProduto = "";
            int quant = -999999;
            String textoAux = textBox1.Text;
            if (textoAux != "")
                quant = Int32.Parse(textoAux);
            String nomeProduto = "";
            nomeProduto = textBox2.Text;
            Item it = new Item();
            it.connectionItem();
            resposta = it.buscaItem(nomeProduto);
            
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
                    if (resposta == false)
                    {
                        if (quant >=0){
                            it.cadastraItem(quant, nomeProduto);
                            MessageBox.Show("Produto Cadastrado com Sucesso!", "Cadastrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("A Quantidade Não Pode Ser Negativa!!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        
                    }
                    else
                    {
                        MessageBox.Show("Produto Já Cadastrado!", "Cadastrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            textBox1.Text = "";
            textBox2.Text = "";
           
        }

        private void button1_Click(object sender, EventArgs e) // BOTAO EXCLUIR 
        {
            bool preenchido = false;
            bool resposta;
            //String nomeProduto = "";
            int quant = -999999;
            String textoAux = textBox1.Text;
            if (textoAux != "") 
                 quant = Int32.Parse(textBox1.Text);
            String nomeProduto = "";
            nomeProduto = textBox2.Text;
            Item it = new Item();
            it.connectionItem();
            resposta = it.buscaItem(nomeProduto);
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

            if ((nomeProduto != null) && (quant != -999999)){
                if ((nomeProduto != "") && (quant != -999999) && (preenchido))
                {
                    if (resposta == true)
                    {
                        if (it.validaExclusao(nomeProduto) == true)
                        {
                            if (MessageBox.Show("Tem Certeza que Deseja Excluir o Produto?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                it.excluiItem(quant, nomeProduto);
                                MessageBox.Show("Produto Excluído com Sucesso!", "Excluído", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else
                        {
                            MessageBox.Show ("O Produto Possui Quantidade Em Estoque - Não Pode Ser Excluído!!", "Exclusão", MessageBoxButtons.OK,MessageBoxIcon.Error);
                        }
                    }
                        else
                        {
                            MessageBox.Show("O Produto Inserido Não Existe!", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
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

        private void button9_Click(object sender, EventArgs e)
        {
            Lista_de_Produtos lprods = new Lista_de_Produtos();
            lprods.Show();
            this.Hide();

        }

        private void button5_Click(object sender, EventArgs e){
        bool preenchido = false;
            bool resposta;
            //String nomeProduto = "";
            int quant = -999999;
            String textoAux = textBox1.Text;
            if (textoAux != "")
                quant = Int32.Parse(textoAux);
            String nomeProduto = "";
            nomeProduto = textBox2.Text;
            Item it = new Item();
            it.connectionItem();
            resposta = it.buscaItem(nomeProduto);
            
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
                    if (resposta == false)
                    {
                        if (quant >=0){
                            it.cadastraItem(quant, nomeProduto);
                            MessageBox.Show("Produto Cadastrado com Sucesso!", "Cadastrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("A Quantidade Não Pode Ser Negativa!!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        
                    }
                    else
                    {
                        MessageBox.Show("Produto Já Cadastrado!", "Cadastrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            textBox1.Text = "";
            textBox2.Text = "";
           
        }

    }
}
