﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ProjInicial
{
    class Estoque
    {
        private MySqlConnection mConnB = null;
        private MySqlDataAdapter mAdapterB;
        private MySqlDataReader reader;
        private static int countProds;
        private Item [] itens;
        /* Nova lista onde os nos sao as plataoformas e os itens são os segmentos de braços dos nos
         Verificar a inserçao de plataformas ou depósitos
        */

       private static Dictionary<Plataforma, Item> est = new Dictionary<Plataforma, Item>();

        /* pegar a plataforma nova e cadastra ela como chave.
         Depois, associa a ela os itens*/
       


       private void compraItem()
       {

       }

       private void vendeItem()
       {

       }

       private void consomeItem()
       {

       }
  
 
    }
}
