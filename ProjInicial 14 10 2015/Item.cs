using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ProjInicial
{
    class Item
    {
        public String No_ { get; set; }
        public String Descricao { get; set; }
        public int Quantidade { get; set; }
        public String localizacaoItem { get; set; }
        
        private MySqlConnection mConnB = null;
        private MySqlDataAdapter mAdapterB;
        private MySqlDataReader reader;
        private static int countProds;
        
        

        public void connectionItem()
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


        public void cadastraItem(int quantidade, String ndescricao)
        {
        /*{
               if (buscaItem(quantidade, ndescricao)== false){
                String query = "INSERT INTO produtos (produtosDescr,quantidade, idprodutos) values ('" + ndescricao + "','" + quantidade + "','" + countProds + "')";
                MySqlCommand comd = new MySqlCommand(query, mConnB);
                comd.ExecuteNonQuery();
            //    String query2 = "INSERT INTO estoque (idPlat,idProduto,quantidadeItemPlat,nomeProduto,nomePlataforma,quantTotalProd,movimentacao,idBarco,nomeBarco) values ('','" + countProds + "',0 '" + ndescricao + "',null, 0, null,null,null)'";
            //    MySqlCommand comd2 = new MySqlCommand(query2, mConnB);
            //   comd2.ExecuteNonQuery();
                 mConnB.Close();
            }
        }*/
            
               try
               {
                   connectionItem();
                   String query = "INSERT INTO produtos (idprodutos,produtosDescr,quantidade) values ('" + countProds + "','" + ndescricao + "','" + quantidade + "')";
                   MySqlCommand comd = new MySqlCommand(query, mConnB);
                   comd.ExecuteNonQuery();
                   
                   
                   // String query = "INSERT INTO barcos ( idBarcos, descrBarcos,barcoslocal) values (,'"+ ndescricao + "','" + nLocalBarco+"')";
                 
                   
                   mConnB.Close();

               }
               catch (MySqlException e)
               {
                   throw;
               }

           }


        public bool validaExclusao(String produtosDescr)
        {
            try
            {
                int quantCompare = 0;
                String query = "Select quantidade from produtos where produtosDescr LIKE produtosDescr;";
                MySqlCommand comando = new MySqlCommand(query, mConnB);
                mConnB.Open();
                MySqlDataReader leitor = comando.ExecuteReader();
                if(leitor.HasRows){
                    String ux = leitor.GetString(0);
                  //  String aux = (leitor["quantidade"].ToString());
                    quantCompare = Int32.Parse(ux);
                }

                mConnB.Close();
                if (quantCompare == 0) return true;
                else return false;
            }
            catch (MySqlException e)
            {
                throw;  
            }            
        }


        public bool excluiItem(int quantidade, String ndescricao)
        {
            try
            {
                connectionItem();
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = "Delete from produtos where quantidade =  @quantidade and produtosDescr = @produtosDescr;";
                cmd.Parameters.AddWithValue("@quantidade", quantidade);
                cmd.Parameters.AddWithValue("@produtosDescr", ndescricao);

                if (mConnB != null) cmd.Connection = mConnB;
                MySqlDataReader leItem = cmd.ExecuteReader();

                if (leItem.Read())
                {
                    mConnB.Close();
                    return true;
                }
                else
                {
                    mConnB.Close();
                    return false;
                }
            }
            catch (MySqlException e)
            {
                throw;
            }
        }

        public bool buscaItem( String produtosDescr)
        {
            try {
                mConnB = new MySqlConnection("Persist Security Info=False;SERVER=localhost;DATABASE=baseteste;UID=root;PASSWORD=Josyane;");
                mConnB.Open();

                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = "Select * from produtos where produtosDescr = @produtosDescr;";
                cmd.Parameters.AddWithValue("@produtosDescr", produtosDescr);
             //   cmd.Parameters.AddWithValue("@quantidade", quantidade);

                if (mConnB != null) cmd.Connection = mConnB;
                MySqlDataReader leBarcos = cmd.ExecuteReader();


                if (leBarcos.Read())
                {
                    mConnB.Close();
                    return true;
                }
                else
                {
                    mConnB.Close();
                    return false;
                }
            }
            catch (MySqlException e)
            {
                throw;
            }
            
           

            //se ele achar, devolve
        }


        public Boolean existe (String nome, int quantidade)
        {
            try
            {
                mConnB = new MySqlConnection("Persist Security Info=False;SERVER=localhost;DATABASE=baseteste;UID=root;PASSWORD=Josyane;");
                mConnB.Open();

                MySqlCommand cmd = new MySqlCommand();
                cmd.Parameters.AddWithValue("@produtosDescr", nome);
                cmd.Parameters.AddWithValue("@quantidade", quantidade);

                if (mConnB != null) cmd.Connection = mConnB;
                MySqlDataReader leExiste = cmd.ExecuteReader();

                if (leExiste.Read())
                {
                    mConnB.Close();
                    return true;
                }
                else
                {
                    mConnB.Close();
                    return false;
                }
            }
            catch (MySqlException e)
            {
                throw;
            }
            
        }
    }
}
