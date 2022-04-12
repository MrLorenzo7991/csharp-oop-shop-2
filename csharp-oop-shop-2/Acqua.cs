using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop_shop_2
{
    internal class Acqua : Prodotto
    {
        private double litri;
        private double ph;
        private string sorgente;
        public Acqua(string nome, double litri ,double prezzo, int iva) : base(nome, prezzo, iva)
        {
            this.litri = litri;
        }
    }
}
