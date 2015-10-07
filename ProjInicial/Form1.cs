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
    public partial class Form1 : Form
    {
        private String login;
        private String senha;
        MySqlConnection mConn = null;
        MySqlDataAdapter mAdapter;
     
       
        private String strSql = string.Empty;

        public Form1()
        {
          //  Item item1 = new Item("P0004", "Primeiro Produto", 10);
            InitializeComponent();
        }

        public void logar()
        {
            DataSet mDataSet = new DataSet();
            login = textBox1.Text;
            senha = textBox2.Text;
            mConn = new MySqlConnection("SERVER=localhost;DATABASE=baseteste;UID=root;PASSWORD=Josyane");
            
            try
                  {
                    //abre a conexao
                  if (mConn != null)mConn.Open();
                    
                    strSql = "SELECT idusuarios FROM usuarios WHERE usuarios =  @usuarios and usuarioSenha = @usuarioSenha";
               
                    MySqlCommand mySqlCommand = new MySqlCommand(strSql, mConn);
                    mySqlCommand.Parameters.AddWithValue("@usuarios", MySqlDbType.VarChar).Value = login;
                    mySqlCommand.Parameters.AddWithValue("@usuarioSenha", MySqlDbType.VarChar).Value = senha;
                    if (mConn != null)
                    {
                        if (mConn.State == ConnectionState.Open)
                        {
                            mAdapter = new MySqlDataAdapter(mySqlCommand);
                        }
                    }
                    
               
    
            }
            catch (MySqlException erroSql)
            {
                MessageBox.Show(erroSql + "no banco");
            }


         }


        private void button1_Click(object sender, EventArgs e)
        {
         //   MessageBox.Show("Hello World");
         //  String mensagem = "Josy Teste";
        //    MessageBox.Show(mensagem);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
           // textoItem1.Text = it1.No_;
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
          

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textoPrincipal_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textoValor_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
              

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            logar();            
            
            if ((login == "Josy") && (senha == "Josy"))
                MessageBox.Show ("***** BEM VINDO," + login +", ****** ");
            if ((login == "Igor") && (senha == "Igor"))
                MessageBox.Show("***** BEM VINDO " + login + " ****** ");
            
            Form2 formula2 = new Form2();
            formula2.ShowDialog();
            
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
            textBox2.MaxLength = 14;
        }
    }
}
