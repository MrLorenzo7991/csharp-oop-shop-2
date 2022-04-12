using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop_shop_2
{
    internal class Prodotto
    {
        //attributi
        private protected string nome;
        private protected int codice;
        private protected string descrizione;
        private protected double prezzo;
        private protected int iva;
        private protected string codiceStampa;

        //costruttore con descrizione
        public Prodotto(string nome, string descrizione, double prezzo, int iva)
        {
            this.nome = nome;
            this.prezzo = prezzo;
            this.descrizione = descrizione;
            this.iva = iva;

            Random rnd = new Random();

            codice = rnd.Next(1, 100000000);
            codiceStampa = codice.ToString().PadLeft(8, '0');

        }
        //costruttore senza descizione
        public Prodotto(string nome, double prezzo, int iva)
        {
            this.nome = nome;
            this.prezzo = prezzo;
            this.iva = iva;

            Random rnd = new Random();

            codice = rnd.Next(1, 100000000);
            codiceStampa = codice.ToString().PadLeft(8, '0');
        }

        //Lettura attributi
        public string GetNome()
        {
            return nome;
        }
        public int GetCodice()
        {
            return codice;
        }
        public string GetDescrizione()
        {
            return descrizione;
        }
        public double GetPrezzoBase()
        {
            return prezzo;
        }

        public int GetIva()
        {
            return iva;
        }

        //Scrittura attributi
        public void CambiaNome(string nome)
        {
            this.nome = nome;
        }
        public void CambiaDescrizione(string descrizione)
        {
            this.descrizione = descrizione;
        }
        public void CambiaPrezzo(double prezzo)
        {
            this.prezzo = prezzo;
        }
        public void CambiaIva(int iva)
        {
            this.iva = iva;
        }

        //Calcolo prezzo con iva
        public double CalcolaPrezzoConIva()
        {
            double prezzoConIva = prezzo + (prezzo * ((double)iva / 100));
            return prezzoConIva;
        }

        //Stampa prodotto
        public virtual void StampaProdotto()
        {
            Console.WriteLine("----Prodotto----");
            Console.Write(this.codiceStampa + "-");
            Console.WriteLine(this.nome);
        }

        //stampa codice con padleft
        public void StampaCodice()
        {
            Console.WriteLine(codiceStampa);
        }
    }
}

