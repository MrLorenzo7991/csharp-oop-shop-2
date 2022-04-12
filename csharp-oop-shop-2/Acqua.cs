using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop_shop_2
{
    internal class Acqua : Prodotto
    {
        private double capacitaInLitri;
        private const double CAPACITA_MASSIMA = 1.5;
        private double litriDisponibili;
        private double ph;
        private string sorgente;
        public Acqua(string nome, double capacitaInLitri ,double prezzo, int iva) : base(nome, prezzo, iva)
        {
            if (capacitaInLitri > CAPACITA_MASSIMA)
            {
                Console.WriteLine("Hai superato la massima capacità settabile, la capacità della bottiglia è stata settata a: " + CAPACITA_MASSIMA + " lt");
                this.capacitaInLitri = CAPACITA_MASSIMA;
                litriDisponibili = CAPACITA_MASSIMA;
            } else
            {
                this.capacitaInLitri = capacitaInLitri;
                litriDisponibili = capacitaInLitri;
            }
            ph = 7;
            sorgente = "Fonte Guizza";
        }

        //getter acqua
        public double GetDimensioneInLitri()
        {
            return capacitaInLitri;
        }
        public double GetLitriDisponibili()
        {
            return litriDisponibili;
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
        public void SetDimensioneInLitri(double litri)
        {
            this.capacitaInLitri = litri;
        }


        //Metodo Bevi
        public void Bevi(double litriDaBere)
        {
            if (litriDaBere < 0)
            {
                Console.WriteLine("Non puo bere litri negativi");
            }
            else if (litriDaBere > litriDisponibili)
            {
                Console.WriteLine("Vuoi bere più litri di quanti ce ne siano, hai bevuto tutta l'acqua");
                litriDisponibili = 0;
            }
            else
            {
                litriDisponibili -= litriDaBere;
                if (litriDisponibili == 0)
                {
                    Console.WriteLine("Hai bevuto " + litriDaBere + " litri, non ti rimane più acqua");
                }
                else
                {
                    Console.WriteLine("Hai bevuto " + litriDaBere + " litri, ti rimangono " + litriDisponibili + " litri");
                }
            }

        }

        //Metodo Riempi 
        public void Riempi(double litriDaRiempire)
        {
            double capiezaRimanente = capacitaInLitri - litriDisponibili;
            if(litriDaRiempire < 0)
            {
                Console.WriteLine("Non puoi riempire litri negativi!");
            }
            else if(litriDaRiempire > capiezaRimanente)
            {
                litriDisponibili = capacitaInLitri;
                Console.WriteLine("Hai riempito più di quanto potevi! La bottiglia è piena con " + litriDisponibili + " litri");
            }
            else
            {
                litriDisponibili += litriDaRiempire;
                Console.WriteLine("Hai versato " + litriDaRiempire + " litri la bottiglia contiene ora " + litriDisponibili + " litri");
            }
        }

        //Metodo Svuota
        public void Svuota()
        {
            litriDisponibili = 0;
            Console.WriteLine("Hai svuotato la bottiglia");
        }

        //override Stampatrodotto()
        public void StampaProdotto()
        {
            Console.WriteLine("----Acqua----");
            Console.Write(base.codiceStampa + "-");
            Console.WriteLine(base.nome);
            Console.WriteLine("sorgente: " + this.sorgente);
            Console.WriteLine("Ph: " + this.ph);
            Console.WriteLine("Capienza in litri: " + this.capacitaInLitri);
        }
    }
}
