using csharp_oop_shop_2;

Prodotto fagioli = new Prodotto("Fagioli", "scatolo grande rosso", 2.30, 22);

fagioli.StampaProdotto();

Acqua acquaGuizza = new Acqua("Acqua Guizza", 2, 0.40, 4);
acquaGuizza.StampaProdotto();
acquaGuizza.Bevi(1.3);
acquaGuizza.Bevi(-2);
acquaGuizza.Bevi(0.7);
acquaGuizza.Riempi(1);
acquaGuizza.Riempi(-2);
acquaGuizza.Riempi(12);

acquaGuizza.Svuota();
Console.WriteLine(acquaGuizza.GetLitriDisponibili());

acquaGuizza.StampaProdotto();

Console.WriteLine(ConvertitoreLitriGalloni.ConvertiLitriGalloni(10));
Console.WriteLine(ConvertitoreLitriGalloni.ConvertiGalloniLitri(10));

SacchettoDiFruttaAPezzi sacchetto1 = new SacchettoDiFruttaAPezzi("Sacchetto di fragole", 3.0, 4);
sacchetto1.AggiungiPezzi(2);
sacchetto1.RimuoviPezzi(3);
sacchetto1.RimuoviPezzi(4);
sacchetto1.AggiungiPezzi(4);
sacchetto1.AggiungiPezzi(10);
sacchetto1.AggiungiPezzi(-1);