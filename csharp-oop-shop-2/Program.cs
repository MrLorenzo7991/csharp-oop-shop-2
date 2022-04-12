using csharp_oop_shop_2;

Prodotto fagioli = new Prodotto("Fagioli", "scatolo grande rosso", 2.30, 22);

fagioli.StampaProdotto();

Acqua acquaGuizza = new Acqua("Acqua Guizza", 2, 0.40, 4);
acquaGuizza.StampaProdotto();
acquaGuizza.Bevi(1.3);
acquaGuizza.Bevi(-2);
acquaGuizza.Bevi(0.7);