using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ProjInicial
{
    class Barco
    {
        private String nidBarco { get; set; }
        private String ndescricao { get; set; }
        private String nlocalizacao { get; set; }

        private MySqlConnection mConnB = null;
        private MySqlDataAdapter mAdapterB;
        private MySqlDataReader reader;


        private void connectionBarcos()
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

        private void cadastraBarco()
        {
            try {
              String query = "INSERT INTO baseteste (descrBarcos,barcoslocal) values ('" + nidBarco + "','" + ndescricao + "')";
              MySqlCommand comd = new MySqlCommand(query, mConnB);
              comd.ExecuteNonQuery();
              mConnB.Close();
            }
            catch (MySqlException e)
            {
                throw;
            }
           

        }

    }
}
