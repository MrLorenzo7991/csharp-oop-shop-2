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
            ph = 7;
            sorgente = "Fonte Guizza";

        }

        //getter acqua
        public double GetLitri()
        {
            return litri;
        }
        public double GetPh()
        {
            return ph;
        }
        public string GetSorgente()
        {
            return sorgente;
        }
        //Setter acqua
        public void SetLitri(double litri)
        {
            this.litri = litri;
        }


        //Metodo Bevi
        public void Bevi(double litriDaBere)
        {
            if (litriDaBere < 0)
            {
                Console.WriteLine("Non puo bere litri negativi");
            }
            else if (litriDaBere > litri)
            {
                Console.WriteLine("Vuoi bere più litri di quanti ce ne siano, hai bevuto tutta l'acqua");
                litri = 0;
            }
            else
            {
                litri -= litriDaBere;
                Console.WriteLine("Hai bevuto " + litriDaBere + " litri, ti rimangono " + litri + " litri");
            }
        }
    }
}
