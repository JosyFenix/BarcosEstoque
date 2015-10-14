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
            try
            {

                String query = "INSERT INTO produtos (produtosDescr,quantidade, idprodutos) values ('" + ndescricao + "','" + quantidade + "','" + countProds + "')";
                MySqlCommand comd = new MySqlCommand(query, mConnB);
                comd.ExecuteNonQuery();
                mConnB.Close();
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

        public bool buscaItem(int quantidade, String ndescricao)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "Select * from barcos where ndescricaos =  @ndescricaos and barcoslocal = @barcoslocal;";
            cmd.Parameters.AddWithValue("@ndescricao", ndescricao);
            cmd.Parameters.AddWithValue("@quantidade", quantidade);

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

            //se ele achar, devolve
        }
    }
}
