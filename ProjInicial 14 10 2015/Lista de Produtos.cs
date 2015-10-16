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
    public partial class Lista_de_Produtos : Form
    {
        private MySqlConnection mConnB = null;
        private MySqlDataAdapter meuAdapter;
        private MySqlDataReader reader;
        private DataTable date = null;
        private String textoPesquisar;

        public Lista_de_Produtos()
        {
            InitializeComponent();
        }

        public void connectionProducts()
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
        }// fim do conBanco

        private void Lista_de_Produtos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'basetesteDataSet.produtos' table. You can move, or remove it, as needed.
            this.produtosTableAdapter.Fill(this.basetesteDataSet.produtos);

        }

        private void CampoPesquisa_TextChanged(object sender, EventArgs e)
        {
            connectionProducts();
            textoPesquisar = CampoPesquisa.Text;
            if (comboBox1.Text == "Nome")
            {
                meuAdapter = new MySqlDataAdapter("SELECT idprodutos, produtosDescr  from produtos WHERE produtosDescr LIKE'" + CampoPesquisa.Text + "%'", mConnB);
                date = new DataTable();
                meuAdapter.Fill(date);
                if (date != null)
                    dataGridView1.DataSource = date;
            }

            else if (comboBox1.Text == "Número")
            {
                meuAdapter = new MySqlDataAdapter("SELECT idprodutos, produtosDescr from produtos WHERE idprodutos LIKE'" + CampoPesquisa.Text + "%'", mConnB);
                date = new DataTable();
                meuAdapter.Fill(date);
                if (date != null)
                    dataGridView1.DataSource = date;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 formula2 = new Form2();
            formula2.Show();
            this.Hide();
        }
    }
}
