﻿using System;
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
    public partial class Painel_Plataformas : Form
    {
        public Painel_Plataformas()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool preenchido = false;
            bool respPlataforma;
            String nomeProduto = "";
            nomeProduto = textBox1.Text;
            String localizaProduto = "";
            localizaProduto = textBox2.Text;
            Plataforma p01 = new Plataforma();
            p01.connectionPlataforma();
            respPlataforma = p01.buscaPlataforma(nomeProduto);

            if ((localizaProduto == "") || (nomeProduto == ""))
            {
                MessageBox.Show("Complete Todos os Campos! ", "Importante", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation,
                    MessageBoxDefaultButton.Button1);
            }
            else //se entrar aki é pq os dois campos estao preenchidos!!!!
            {
                preenchido = true;
            }

            if ((nomeProduto != null) && (localizaProduto != null))
                if ((nomeProduto != "") && (localizaProduto != "") && (preenchido))
                {
                    if (respPlataforma == false)///AKIIIIIIIIIIIII    
                    {
                        p01.cadastraPlataforma(localizaProduto, nomeProduto);
                        MessageBox.Show("Plataforma Cadastrada com Sucesso!", "Cadastrada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else///AKIIIIIIIIIIIII    
                    {
                        MessageBox.Show("Plataforma Já Cadastrada!", "Cadastrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }


            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool preenchido = false;
            bool respostaPlat;
            String nomeProduto = "";
            nomeProduto = textBox1.Text;
            String localizaProduto = "";
            localizaProduto = textBox2.Text;
            Plataforma p02 = new Plataforma();
            p02.connectionPlataforma();
            respostaPlat = p02.buscaPlataforma(nomeProduto);
            
            if ((localizaProduto == "") || (nomeProduto == ""))
            {
                MessageBox.Show("Complete Todos os Campos! ", "Importante", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation,
                    MessageBoxDefaultButton.Button1);
            }
            else //se entrar aki é pq os dois campos estao preenchidos!!!!
            {
                preenchido = true;
            }

            if ((nomeProduto != null) && (localizaProduto != null))
                if ((nomeProduto != "") && (localizaProduto != "") && (preenchido))
                {
                    if (respostaPlat == true)
                    {
                        if (MessageBox.Show("Tem Certeza que Deseja Excluir a Plataforma?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            p02.excluiPlataforma(nomeProduto, localizaProduto);
                            MessageBox.Show("Plataforma Excluída com Sucesso!", "Excluída", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("A Plataforma Inserida Não Existe!", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }


            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Lista_de_Plataformas lp = new Lista_de_Plataformas();
            lp.Show();
            this.Hide();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 formula2 = new Form2();
            formula2.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
            {
                bool preenchido = false;
                bool respPlataforma;
                String nomeProduto = "";
                nomeProduto = textBox1.Text;
                String localizaProduto = "";
                localizaProduto = textBox2.Text;
                Plataforma p01 = new Plataforma();
                p01.connectionPlataforma();
                respPlataforma = p01.buscaPlataforma(nomeProduto);

                if ((localizaProduto == "") || (nomeProduto == ""))
                {
                    MessageBox.Show("Complete Todos os Campos! ", "Importante", MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation,
                        MessageBoxDefaultButton.Button1);
                }
                else //se entrar aki é pq os dois campos estao preenchidos!!!!
                {
                    preenchido = true;
                }

                if ((nomeProduto != null) && (localizaProduto != null))
                    if ((nomeProduto != "") && (localizaProduto != "") && (preenchido))
                    {
                        if (respPlataforma == false)///AKIIIIIIIIIIIII    
                        {
                            p01.cadastraPlataforma(localizaProduto, nomeProduto);
                            MessageBox.Show("Plataforma Cadastrada com Sucesso!", "Cadastrada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else///AKIIIIIIIIIIIII    
                        {
                            MessageBox.Show("Plataforma Já Cadastrada!", "Cadastrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }


                textBox1.Text = "";
                textBox2.Text = "";
            
        }
    }
}
