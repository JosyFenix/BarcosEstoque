using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ProjInicial
{
    public class Barco
    {
        private String nidBarco { get; set; }
        private String ndescricao { get; set; }
        private String nlocalizacao { get; set; }
        private static int count;

        private MySqlConnection mConnB = null;
        private MySqlDataAdapter mAdapterB;
        private MySqlDataReader reader;

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

        public void cadastraBarco(String nLocalBarco,String ndescricao)
        {
            try {
           
              String query = "INSERT INTO barcos (descrBarcos,barcoslocal, idBarcos) values ('" + ndescricao + "','" + nLocalBarco + "','" + count + "')";
             // String query = "INSERT INTO barcos ( idBarcos, descrBarcos,barcoslocal) values (,'"+ ndescricao + "','" + nLocalBarco+"')";
              MySqlCommand comd = new MySqlCommand(query, mConnB);
             comd.ExecuteNonQuery();
             mConnB.Close();
              
            }
            catch (MySqlException e)
            {
                throw;
            }

        }

        public bool excluiBarco(String nomeBarco, String localizacao)
        {
            try
            {
           /*     String query = "DELETE FROM barcos where descrBarcos = +'" + nomeBarco + "' and barcoslocal ='" + localizacao + "';";
             //   DELETE FROM barcos where descrBarcos = 'barquinho Igorzin';
                MySqlCommand comd = new MySqlCommand(query, mConnB);
                comd.ExecuteNonQuery();
                mConnB.Close();*/

                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = "Delete from barcos where descrBarcos =  @descrBarcos and barcoslocal = @barcoslocal;";
                cmd.Parameters.AddWithValue("@descrBarcos", nomeBarco);
                cmd.Parameters.AddWithValue("@barcoslocal", localizacao);

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

            


        }

        public bool buscaBarco(String nomeBarco, String localizaçao)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "Select * from barcos where descrBarcos =  @descrBarcos and barcoslocal = @barcoslocal;";
            cmd.Parameters.AddWithValue("@descrBarcos", nomeBarco);
            cmd.Parameters.AddWithValue("@barcoslocal", localizaçao);

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

        public bool buscaItem(String barcosDescr)
        {
            try
            {
                mConnB = new MySqlConnection("Persist Security Info=False;SERVER=localhost;DATABASE=baseteste;UID=root;PASSWORD=Josyane;");
                mConnB.Open();

                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = "Select * from barcos where descrBarcos = @descrBarcos;";
                cmd.Parameters.AddWithValue("@descrBarcos", barcosDescr);
                //cmd.Parameters.AddWithValue("@quantidade", quantidade);

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

    }
}
