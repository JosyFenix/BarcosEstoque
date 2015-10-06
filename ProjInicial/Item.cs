using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjInicial
{
    class Item
    {
        public String No_ {get;set;}
        public String Descricao{get;set;}
        public int Quantidade {get;set;}

        public Item(String numero, String descreve, int quantidade)
        {
            No_ = numero;
            Descricao = descreve;
            Quantidade = quantidade;
        }

            

        
    }
}
