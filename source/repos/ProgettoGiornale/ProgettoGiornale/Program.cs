using ProgettoGiornale.Models;

namespace ProgettoGiornale
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Giornale g = new Giornale();
            Articolo a1 = new Articolo("Trump ha vinto","Osvaldo");
            Articolo a2 = new Articolo("Acqua alta a Venezia", "Lu");
            //Articolo a3 = new Articolo("", "");
            //Articolo a4 = new Articolo("Acqua alta a Venezia", "Lu");
            Commento c = new CommentoDellaRedazione("");
            g.AggiungiArticolo(a1);
            g.AggiungiArticolo(a2);
            g.CreaCommentoNormale(0, "sono contento");
            g.CreaCommentoNormale(1, "non ci voleva");
            g.CreaCommentoRedazione(1, "affluenza record alle urne");
            Console.WriteLine(g.TrovaArticolo(a1));
            Console.WriteLine(g.ToString());
            Console.WriteLine(a2.Equals(a1));
        }
    }
}
