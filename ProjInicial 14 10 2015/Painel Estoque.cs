using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProjInicial
{
    public partial class Painel_Estoque : Form
    {
        private String textoPesquisar;
        private MySqlConnection mConnB = null;
        private MySqlDataAdapter meuAdapter;
        private MySqlDataReader reader;
        private DataTable date = null;
        private static int countProds;

        public void connectionEstoque()
        {
            try
            {
                mConnB = new MySqlConnection("Persist Security Info=False;SERVER=localhost;DATABASE=baseteste;UID=root;PASSWORD=Josyane;");
                mConnB.Open();
            }
            catch (MySqlException erro)
            {
                throw;
            }
        }

        public Painel_Estoque()
        {
            InitializeComponent();
        }

        private void Painel_Estoque_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'basetesteDataSet.estoque' table. You can move, or remove it, as needed.
            this.estoqueTableAdapter.Fill(this.basetesteDataSet.estoque);
        }

        private void CampoPesquisa_TextChanged(object sender, EventArgs e)
        {
            connectionEstoque();
            textoPesquisar = CampoPesquisa.Text;
            if (comboBox1.Text == "Nº Linha Estoque")
            {
                meuAdapter = new MySqlDataAdapter("SELECT idLinhaEstoque,idPlat ,idProduto, quantidadeItemPlat,nomeProduto, nomePlataforma, quantTotalProd,movimentacao,idBarco, nomeBarco  from estoque WHERE idLinhaEstoque LIKE'" + CampoPesquisa.Text + "%'", mConnB);
                date = new DataTable();
                meuAdapter.Fill(date);
                if (date != null)
                    dataGridView1.DataSource = date;
            }

            else if (comboBox1.Text == "Nº Plataforma")
            {
                meuAdapter = new MySqlDataAdapter("SELECT idLinhaEstoque,idPlat ,idProduto, quantidadeItemPlat,nomeProduto, nomePlataforma, quantTotalProd,movimentacao,idBarco, nomeBarco  from estoque WHERE idPlat LIKE'" + CampoPesquisa.Text + "%'", mConnB);
                date = new DataTable();
                meuAdapter.Fill(date);
                if (date != null)
                    dataGridView1.DataSource = date;
            }
            else if (comboBox1.Text == "Nº Produto")
            {
                meuAdapter = new MySqlDataAdapter("SELECT idLinhaEstoque,idPlat ,idProduto, quantidadeItemPlat,nomeProduto, nomePlataforma, quantTotalProd,movimentacao,idBarco, nomeBarco  from estoque WHERE idProduto LIKE'" + CampoPesquisa.Text + "%'", mConnB);
                date = new DataTable();
                meuAdapter.Fill(date);
                if (date != null)
                    dataGridView1.DataSource = date;
            }
            else if (comboBox1.Text == "Quant Na Plataforma")
            {
                meuAdapter = new MySqlDataAdapter("SELECT idLinhaEstoque,idPlat ,idProduto, quantidadeItemPlat,nomeProduto, nomePlataforma, quantTotalProd,movimentacao,idBarco, nomeBarco  from estoque WHERE quantidadeItemPlat LIKE'" + CampoPesquisa.Text + "%'", mConnB);
                date = new DataTable();
                meuAdapter.Fill(date);
                if (date != null)
                    dataGridView1.DataSource = date;
            }
            else if (comboBox1.Text == "Produto")
            {
                meuAdapter = new MySqlDataAdapter("SELECT idLinhaEstoque,idPlat ,idProduto, quantidadeItemPlat,nomeProduto, nomePlataforma, quantTotalProd,movimentacao,idBarco, nomeBarco  from estoque WHERE nomeProduto LIKE'" + CampoPesquisa.Text + "%'", mConnB);
                date = new DataTable();
                meuAdapter.Fill(date);
                if (date != null)
                    dataGridView1.DataSource = date;
            }
            else if (comboBox1.Text == "Plataforma")
            {
                meuAdapter = new MySqlDataAdapter("SELECT idLinhaEstoque,idPlat ,idProduto, quantidadeItemPlat,nomeProduto, nomePlataforma, quantTotalProd,movimentacao,idBarco, nomeBarco  from estoque WHERE nomePlataforma LIKE'" + CampoPesquisa.Text + "%'", mConnB);
                date = new DataTable();
                meuAdapter.Fill(date);
                if (date != null)
                    dataGridView1.DataSource = date;
            }
            else if (comboBox1.Text == "Quantidade Total Produto")
            {
                meuAdapter = new MySqlDataAdapter("SELECT idLinhaEstoque,idPlat ,idProduto, quantidadeItemPlat,nomeProduto, nomePlataforma, quantTotalProd,movimentacao,idBarco, nomeBarco  from estoque WHERE quantTotalProd LIKE'" + CampoPesquisa.Text + "%'", mConnB);
                date = new DataTable();
                meuAdapter.Fill(date);
                if (date != null)
                    dataGridView1.DataSource = date;
            }
            else if (comboBox1.Text == "Movimentação")
            {
                meuAdapter = new MySqlDataAdapter("SELECT idLinhaEstoque,idPlat ,idProduto, quantidadeItemPlat,nomeProduto, nomePlataforma, quantTotalProd,movimentacao,idBarco, nomeBarco  from estoque WHERE movimentacao LIKE'" + CampoPesquisa.Text + "%'", mConnB);
                date = new DataTable();
                meuAdapter.Fill(date);
                if (date != null)
                    dataGridView1.DataSource = date;
            }
            else if (comboBox1.Text == "Nº Barco")
            {
                meuAdapter = new MySqlDataAdapter("SELECT idLinhaEstoque,idPlat ,idProduto, quantidadeItemPlat,nomeProduto, nomePlataforma, quantTotalProd,movimentacao,idBarco, nomeBarco  from estoque WHERE idBarco LIKE'" + CampoPesquisa.Text + "%'", mConnB);
                date = new DataTable();
                meuAdapter.Fill(date);
                if (date != null)
                    dataGridView1.DataSource = date;
            }
            else if (comboBox1.Text == "Barco")
            {
                meuAdapter = new MySqlDataAdapter("SELECT idLinhaEstoque,idPlat ,idProduto, quantidadeItemPlat,nomeProduto, nomePlataforma, quantTotalProd,movimentacao,idBarco, nomeBarco  from estoque WHERE nomeBarco LIKE'" + CampoPesquisa.Text + "%'", mConnB);
                date = new DataTable();
                meuAdapter.Fill(date);
                if (date != null)
                    dataGridView1.DataSource = date;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 formula2 = new Form2();
            formula2.Show();
            this.Hide();
        }
    }
}