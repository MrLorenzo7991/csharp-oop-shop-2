using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop_shop_2
{
    internal class Elettrodomestico : Prodotto
    {
        private uint potenzaInWatt;
        private char classeEnergetica;

        public Elettrodomestico(string nome, string descrizione, uint potenzaInWatt, char classeEnergetica, double prezzo, int iva) : base(nome, descrizione, prezzo, iva)
        {
            this.classeEnergetica = classeEnergetica;
            this.potenzaInWatt = potenzaInWatt;
        }

        //getter 
        public uint GetPotenzaInWatt()
        {
            return potenzaInWatt;
        }
        public char GetClasseEnergetica()
        {
            return classeEnergetica;
        }

        //setter
        public void SetPotenzaInWatt(uint nuovaPotenza)
        {
            potenzaInWatt = nuovaPotenza;
        }
        public void SetClasseEnergetica(char nuovaClasseEnergetica)
        {
            classeEnergetica = nuovaClasseEnergetica;
        }
    }
}
