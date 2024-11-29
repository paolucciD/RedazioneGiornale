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
            Articolo a3 = new Articolo("", "");
            g.AggiungiArticolo(a1);
            g.AggiungiArticolo(a2);
            g.CreaCommentoNormale(a1, "sono contento");
            g.CreaCommentoNormale(a2, "non ci voleva");
            g.CreaCommentoRedazione(a2, "affluenza record alle urne");
            Console.WriteLine(g.TrovaArticolo(a2));
            Console.WriteLine(g.ToString());
        }
    }
}
