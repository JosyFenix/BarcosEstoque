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
        MySqlDataReader logginn;
       
        private String strSql = string.Empty;

        public Form1()
        {
                InitializeComponent();
        }


        private void db_connection()
        {
            try
            {
                mConn = new MySqlConnection("Persist Security Info=False;SERVER=localhost;DATABASE=baseteste;UID=root;PASSWORD=Josyane;");
             // 2   mConn = new MySqlConnection("server=localhost;user id=root;database=baseteste;UID=root;PASSWORD=Josyane");
            // mConn = new MySqlConnection("server=localhost;database=basetest;uid=root;password=Josyane");
             //   mConn = new MySqlConnection(" Persist Security Info=False;server=localhost;database=aplicacao;uid=root;pwd=");

                mConn.Open();
            }
            catch (MySqlException erro)
            {
                //throw;
                MessageBox.Show(erro.Message.ToString());
            }
        }
        


        public bool logar(String usuarios, String senha)
        {
            
            
                db_connection();
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = "Select usuarios, usuarioSenha from usuarios where usuarios =  @usuarios and usuarioSenha = @usuarioSenha;";
                cmd.Parameters.AddWithValue("@usuarios", usuarios);
                cmd.Parameters.AddWithValue("@usuarioSenha", senha);
                cmd.Connection = mConn;
                MySqlDataReader logginn = cmd.ExecuteReader();
                textBox1.Text = "";
                textBox2.Text = "";

                if (logginn.Read())
                {
                    mConn.Close();
                    return true;
                }
                else
                {
                    mConn.Close();
                    return false;
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
            login = textBox1.Text;
            senha = textBox2.Text;       
            if (login == "" || senha == "")
            {
                MessageBox.Show("Preencha Login e Senha!!");
                return;
            }

            bool r = logar(login,senha);

            if (r){
                 //   MessageBox.Show("Seja Bem Vindo");
                    Form2 formula2 = new Form2();
                    formula2.Show();
                    this.Hide();
            }
            
            else
                MessageBox.Show(" **** Login Incorreto! ****");                                
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
            textBox2.MaxLength = 14;
        }
    }
}
