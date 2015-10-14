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
    public partial class lista_de_Embarcações : Form
    {
        private MySqlConnection mConnB = null;
        private MySqlDataAdapter meuAdapter;
        private MySqlDataReader reader;
        private DataTable date = null;
        private String textoPesquisar;
       
        public lista_de_Embarcações()
        {
            InitializeComponent();
        }

        public void connectionBarcos()
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

        private void barcosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.barcosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.basetesteDataSet);

        }

        private void lista_de_Embarcações_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'basetesteDataSet.barcos' table. You can move, or remove it, as needed.
         //   this.barcosTableAdapter.Fill(this.basetesteDataSet.barcos);

        }

        private void idBarcosLabel_Click(object sender, EventArgs e)
        {

        }

        private void idBarcosTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.barcosTableAdapter.busca_NomeBarco(basetesteDataSet.barcos, descrBarcosTextBox.Text);
        }

        private void descrBarcosTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 formula2 = new Form2();
            formula2.Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

               
        }

        private void CampoPesquisa_TextChanged(object sender, EventArgs e)
        {
            connectionBarcos();
            textoPesquisar = CampoPesquisa.Text;
            if (comboBox1.Text == "Nome")
            {
                meuAdapter = new MySqlDataAdapter("SELECT idBarcos, descrBarcos, barcoslocal from barcos WHERE descrBarcos LIKE'" + CampoPesquisa.Text + "%'", mConnB);
                date = new DataTable();
                meuAdapter.Fill(date);
                if (date != null)
                    dataGridView1.DataSource = date;
            }

            else if (comboBox1.Text == "Número")
            {
                meuAdapter = new MySqlDataAdapter("SELECT idBarcos, descrBarcos, barcoslocal from barcos WHERE idBarcos LIKE'" + CampoPesquisa.Text + "%'", mConnB);
                date = new DataTable();
                meuAdapter.Fill(date);
                if (date != null)
                    dataGridView1.DataSource = date;
            }


            else if (comboBox1.Text == "Localização")
            {
                meuAdapter = new MySqlDataAdapter("SELECT idBarcos, descrBarcos, barcoslocal from barcos WHERE barcoslocal LIKE'" + CampoPesquisa.Text + "%'", mConnB);
                date = new DataTable();
                meuAdapter.Fill(date);
                if (date != null)
                    dataGridView1.DataSource = date;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
