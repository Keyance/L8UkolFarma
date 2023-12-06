using L8UkolFarma;

List <Zvire> farma = new List<Zvire> ();

Husa nina = new Husa ("Nina", "Česká husa", 15);
farma.Add (nina);
Slepice adelka = new Slepice("Adélka", "Šumavanka", 2);
farma.Add (adelka);
Kun ferka = new Kun("Ferda", "Hucul");
farma.Add (ferka);

foreach (Zvire zvire in farma)
{
    Console.WriteLine(zvire.OzviSe());
}

adelka.SnasiVejce(7);
adelka.SbirameVejce();

nina.SnasiVejce(45);
nina.SbirameVejce();