namespace ScreenSound.Modelos;

internal class Banda : IAvaliavel
{
    private List<Album> albuns = new();
    private List<Avaliacao> notas = new();

    public Banda(string nome) => Nome = nome;

    public string Nome { get; }
    public List<Album> Albuns => albuns;
    public double Media => notas.Count == 0 ? 0 : notas.Average(a => a.Nota);

    public void AdicionarAlbum(Album album) => albuns.Add(album);
    public void AdicionarNota(Avaliacao nota) => notas.Add(nota);

    public void ExibirDiscografia()
    {
        Console.WriteLine($"Discografia da banda {Nome}");
        foreach (Album album in albuns)
        {
            Console.WriteLine($"Álbum: {album.Nome} ({album.DuracaoTotal}s)");
        }
    }
}