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
        private bool acceso;

        public Elettrodomestico(string nome, string descrizione, uint potenzaInWatt, char classeEnergetica, double prezzo, int iva) : base(nome, descrizione, prezzo, iva)
        {
            this.classeEnergetica = classeEnergetica;
            this.potenzaInWatt = potenzaInWatt;
            acceso = false;
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
        public bool GetAcceso()
        {
            return acceso;
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

        //metodi
        public void Accendi()
        {
            if (acceso)
            {
                Console.WriteLine("L'elettrodomestico è già acceso");
            }
            else
            {
                acceso=true;
                Console.WriteLine("Ho acceso l'elettetrodomestico");
            }
        }
        public void Spegni()
        {
            if (!acceso)
            {
                Console.WriteLine("L'elettrodomestico è già spento");
            }
            else
            {
                acceso = false;
                Console.WriteLine("Ho spento l'elettetrodomestico");
            }
        }
        
    }
}
