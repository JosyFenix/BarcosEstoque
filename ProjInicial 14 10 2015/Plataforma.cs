using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ProjInicial
{
    class Plataforma
    {
        String IdPlataforma { get; set;}
        String localizacao { get; set;}
        Item[] estoquePlat { get; set;}

        private MySqlConnection mConnB = null;
        private MySqlDataAdapter mAdapterB;
        private MySqlDataReader reader;
        private static int countPlataformas;

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

        public void cadastraPlataforma(String nLocalPlataforma, String ndescricao)
        {
            try {

                String query = "INSERT INTO plataformas (PlataformaDescr,Plataformalocal, idPlataformas) values ('" + ndescricao + "','" + nLocalPlataforma + "','" + countPlataformas + "')";
              MySqlCommand comd = new MySqlCommand(query, mConnB);
              comd.ExecuteNonQuery();
              mConnB.Close();
              
            }
            catch (MySqlException e)
            {
                throw;
            }

        }

        public bool excluiPlaforma(String nomePlataforma, String localizacao)
        {
            try
            {
           /*     String query = "DELETE FROM barcos where descrBarcos = +'" + nomeBarco + "' and barcoslocal ='" + localizacao + "';";
             //   DELETE FROM barcos where descrBarcos = 'barquinho Igorzin';
                MySqlCommand comd = new MySqlCommand(query, mConnB);
                comd.ExecuteNonQuery();
                mConnB.Close();*/

                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = "Delete from plataformas where PlataformaDescr =  @PlataformaDescr and Plataformalocal = @Plataformalocal;";
                cmd.Parameters.AddWithValue("@PlataformaDescr", nomePlataforma);
                cmd.Parameters.AddWithValue("@Plataformalocal", localizacao);

                if (mConnB != null) cmd.Connection = mConnB;
                MySqlDataReader lePlataformas = cmd.ExecuteReader();


                if (lePlataformas.Read())
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

        public bool buscaPlataforma(String nomePlataforma, String localizaçao)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "Select * from plataformas where PlataformaDescr =  @PlataformaDescr and Plataformalocal = @Plataformalocal;";
            cmd.Parameters.AddWithValue("@PlataformaDescr", nomePlataforma);
            cmd.Parameters.AddWithValue("@Plataformalocal", localizaçao);

            if (mConnB != null) cmd.Connection = mConnB;
            MySqlDataReader lePlataformas = cmd.ExecuteReader();
            
            if (lePlataformas.Read())
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
 