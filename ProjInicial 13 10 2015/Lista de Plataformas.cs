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
    public partial class Lista_de_Plataformas : Form
    {
        private MySqlConnection mConnB = null;
        private MySqlDataAdapter meuAdapter;
        private MySqlDataReader reader;
        private DataTable date = null;
        private String textoPesquisar;


        public Lista_de_Plataformas()
        {
            InitializeComponent();
        }


        public void connectionPlataforma()
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
        private void plataformasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.plataformasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.basetesteDataSet);

        }

        private void Lista_de_Plataformas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'basetesteDataSet.plataformas' table. You can move, or remove it, as needed.
            this.plataformasTableAdapter.Fill(this.basetesteDataSet.plataformas);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
               // this.plataformasTableAdapter.FillBy(this.basetesteDataSet.plataformas, param1ToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void CampoPesquisa_TextChanged(object sender, EventArgs e)
        {
            connectionPlataforma();
            textoPesquisar = CampoPesquisa.Text;
            if (comboBox1.Text == "Nome")
            {
                meuAdapter = new MySqlDataAdapter("SELECT idPlataformas, PlataformaDescr, PlataformaLocal from plataformas WHERE PlataformaDescr LIKE'" + CampoPesquisa.Text + "%'", mConnB);
                date = new DataTable();
                meuAdapter.Fill(date);
                if (date != null)
                    plataformasDataGridView.DataSource = date;             
            }

            else if (comboBox1.Text == "Número")
            {
                meuAdapter = new MySqlDataAdapter("SELECT idPlataformas, PlataformaDescr, PlataformaLocal from plataformas WHERE idPlataformas LIKE'" + CampoPesquisa.Text + "%'", mConnB);
                date = new DataTable();
                meuAdapter.Fill(date);
                if (date != null)
                    plataformasDataGridView.DataSource = date;
            }

            else if (comboBox1.Text == "Localização")
            {
                meuAdapter = new MySqlDataAdapter("SELECT idPlataformas, PlataformaDescr, PlataformaLocal from plataformas WHERE PlataformaLocal LIKE'" + CampoPesquisa.Text + "%'", mConnB);
                date = new DataTable();
                meuAdapter.Fill(date);
                if (date != null)
                    plataformasDataGridView.DataSource = date;
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
