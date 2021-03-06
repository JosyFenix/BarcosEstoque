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
    public partial class Painel_Embarcação : Form
    {
        public Painel_Embarcação()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            bool preenchido = false;
            String nomeProduto = "";
            nomeProduto = textBox1.Text;
            String localizaProduto = "";
            localizaProduto = textBox2.Text;
            Barco b1 = new Barco();
            b1.connectionBarcos();
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
                    b1.cadastraBarco(localizaProduto, nomeProduto);
                    MessageBox.Show("Embarcação Cadastrada com Sucesso!", "Cadastrada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*String nomeProduto = textBox1.Text;
            String localizaProduto = textBox2.Text;
            Barco b1 = new Barco();
            //b1.connectionBarcos();
            if ((nomeProduto != null) && (localizaProduto != null))
                b1.cadastraBarco(localizaProduto, nomeProduto);
            textBox1.Text = "";
            textBox2.Text = "";
            Nova_Embarcação_Cadastrada embarca1 = new Nova_Embarcação_Cadastrada();
            embarca1.Show();
             */
            bool preenchido = false;
            String nomeProduto ="";
            nomeProduto = textBox1.Text;
            String localizaProduto = "";
            localizaProduto = textBox2.Text;
            Barco b1 = new Barco();
            b1.connectionBarcos();
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
                   b1.cadastraBarco(localizaProduto, nomeProduto);
                   MessageBox.Show("Embarcação Cadastrada com Sucesso!","Cadastrada",MessageBoxButtons.OK ,MessageBoxIcon.Information);
               }
            
            
            textBox1.Text = "";
            textBox2.Text = "";

            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            lista_de_Embarcações listaEmbark = new lista_de_Embarcações();
            listaEmbark.Show();
            this.Hide();
            
            
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

        private void button1_Click(object sender, EventArgs e) //Botao Excluir
        {
            bool preenchido = false;
            String nomeProduto = "";
            nomeProduto = textBox1.Text;
            String localizaProduto = "";
            localizaProduto = textBox2.Text;
            Barco b1 = new Barco();
            b1.connectionBarcos();
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
                    if (MessageBox.Show("Tem Certeza que Deseja Excluir a Embarcação?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        b1.excluiBarco(nomeProduto, localizaProduto);
                            MessageBox.Show("Embarcação Excluída com Sucesso!", "Excluída", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
