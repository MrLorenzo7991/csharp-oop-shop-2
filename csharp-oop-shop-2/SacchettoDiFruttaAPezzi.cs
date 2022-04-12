using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop_shop_2
{
    internal class SacchettoDiFruttaAPezzi : Prodotto
    {
        private int pezziMassimi = 5;
        private int pezziContenuti;

        public SacchettoDiFruttaAPezzi(string nome, double prezzoSacchettoPieno, int iva) : base(nome, prezzoSacchettoPieno, iva)
        {
            this.pezziContenuti = 5;
        }

        //getter
        public double GetPezziMassimi()
        {
            return pezziMassimi;
        }
        public double GetPezziContenuti()
        {
            return pezziContenuti;
        }

        //rimozione pezzi di frutta
        public void RimuoviPezzi(int pezziDaRimuovere)
        {
            if (pezziDaRimuovere > pezziContenuti)
            {
                Console.WriteLine("Hai rimosso tutti i pezzi di frutta, il sacchetto è vuoto");
                pezziContenuti = 0;
            }else if (pezziDaRimuovere < 0)
            {
                Console.WriteLine("Non puoi rimuovere pezzi negativi!");
            }
            else
            {
                pezziContenuti -= pezziDaRimuovere;
                Console.WriteLine("Hai rimosso " + pezziDaRimuovere + " pezzi, nel sacchetto ti rimangono: " + pezziContenuti + " pezzi");
            }
        }
        //Aggiunta pezzi di frutta
        public void AggiungiPezzi(int pezziDaAggiungere)
        {
            int spazioPezziRimanente = pezziMassimi - pezziContenuti;
            if(pezziDaAggiungere > spazioPezziRimanente)
            {
                pezziContenuti = pezziMassimi;
                Console.WriteLine("Non puoi aggiungere tutti quei pezzi di frutta! Hai riempito il sacchetto");
            }
            else if(pezziDaAggiungere < 0)
            {
                Console.WriteLine("Non puoi aggiungere pezzi di frutta negativi!");
            }
            else
            {
                pezziContenuti += pezziDaAggiungere;
                Console.WriteLine("Hai aggiunto " + pezziDaAggiungere + " pezzi di frutta, ora il tuo sacchetto contiene " + pezziContenuti + " pezzi di frutta");
            }
            
        }
    }
}
