using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop_shop_2
{
    internal class CiboInScatola : Prodotto
    {
        private const double PESO_MASSIMO = 0.3;
        private double pesoCiboScatola;

        public CiboInScatola(string nome, string descrizione, double pesoCiboScatolaInKg, double prezzo, int iva) : base(nome, descrizione, prezzo, iva)
        {
            if (pesoCiboScatolaInKg > PESO_MASSIMO)
            {
                Console.WriteLine("Hai superato il peso massimo per il cibo in scatola, il peso è stato settato a: " + PESO_MASSIMO + " kg");
                this.pesoCiboScatola = PESO_MASSIMO;
            }
            else
            {
                this.pesoCiboScatola = pesoCiboScatolaInKg;
            }
        }
        
        //getter
        public double GetPesoCiboInScatola()
        {
            return pesoCiboScatola;
        }

        //setter
        public void SetPesoCiboInScatola(double pesoCiboInScatolaInKg)
        {
            pesoCiboScatola = pesoCiboInScatolaInKg;
        }

    }
}
