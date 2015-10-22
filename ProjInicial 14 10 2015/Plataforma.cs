using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
//using System.Object;
//using System.Collections.Hashtable;
//using System.Collections.SortedList;
//using System.Collections.ArrayList;


namespace ProjInicial
{
    class Plataforma
    {
        String IdPlataforma { get; set;}
        String localizacao { get; set;}
        Item[] plataformas { get; set;}

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

              String query = "INSERT INTO plataformas (PlataformaDescr,PlataformaLocal, idPlataformas) values ('" + ndescricao + "','" + nLocalPlataforma + "','" + countPlataformas + "')";
              MySqlCommand comd = new MySqlCommand(query, mConnB);
              comd.ExecuteNonQuery();
              mConnB.Close();
              
            }
            catch (MySqlException e)
            {
                throw;
            }

        }

        /*public bool excluiPlaforma(String PlataformaLocal, String localizacao)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = "Delete from plataformas where PlataformaDescr =  @PlataformaDescr and PlataformaLocal = @PlataformaLocal;";
                cmd.Parameters.AddWithValue("@PlataformaDescr", PlataformaLocal);
                cmd.Parameters.AddWithValue("@PlataformaLocal", localizacao);

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
            }*/

        public bool excluiPlataforma(String PlataformaDescr, String PlataformaLocal)
           {
            try
            {
                connectionPlataforma();
                MySqlCommand cmd = new MySqlCommand();
                 cmd.CommandText = "Delete from plataformas where PlataformaDescr = @PlataformaDescr and PlataformaLocal = @PlataformaLocal;";
              //cmd.CommandText = "DELETE FROM plataformas where PlataformaDescr = 'Plataforma 01' and PlataformaLocal = 'Rio de Janeiro';";
                cmd.Parameters.AddWithValue("@PlataformaDescr", PlataformaDescr);
                cmd.Parameters.AddWithValue("@PlataformaLocal", PlataformaLocal);

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

        public bool buscaPlataforma(String PlataformaDescr)
        {
            try
            {
                mConnB = new MySqlConnection("Persist Security Info=False;SERVER=localhost;DATABASE=baseteste;UID=root;PASSWORD=Josyane;");
                mConnB.Open();

                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = "Select * from plataformas where PlataformaDescr = @PlataformaDescr;";
                cmd.Parameters.AddWithValue("@PlataformaDescr", PlataformaDescr);
                //   cmd.Parameters.AddWithValue("@quantidade", PlataformaDescr);

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



            //se ele achar, devolve
        }

    }


}
 