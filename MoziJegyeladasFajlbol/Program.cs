using MoziJegyeladasFajlbol;

List<Film> filmek = new List<Film>();

foreach (string beolvasott in File.ReadAllLines("filmek.txt").Skip(1))
{
    string[] vagas = beolvasott.Split(";");
    Film aktuális = new Film();
    aktuális.Cim = vagas[0];
    aktuális.EladottJegyek = int.Parse(vagas[1]);
    aktuális.JegyAr = int.Parse(vagas[2]);
    filmek.Add(aktuális);
}