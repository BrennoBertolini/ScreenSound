namespace ScreenSound.Modelos;

internal class Album : IAvaliavel
{
    private List<Musica> musicas = new();
    private List<Avaliacao> notas = new();

    public Album(string nome) => Nome = nome;

    public string Nome { get; }
    public int DuracaoTotal => musicas.Sum(m => m.Duracao);
    public List<Musica> Musicas => musicas;

    public double Media => notas.Count == 0 ? 0 : notas.Average(n => n.Nota);

    public void AdicionarMusica(Musica musica) => musicas.Add(musica);

    public void AdicionarNota(Avaliacao nota) => notas.Add(nota);

    public void ExibirMusicasDoAlbum()
    {
        Console.WriteLine($"Músicas do álbum {Nome}:\n");
        foreach (var musica in musicas)
        {
            Console.WriteLine($"Música: {musica.Nome}");
        }
    }
}