namespace ScreenSound.Models;

internal class Banda
{
    private List<Album> albuns = [];
    private List<Avaliacao> notas = [];
    public Banda(string nome) => Nome = nome;

    public string Nome;
    public double Media
    {
        get
        {
            if (notas.Count == 0)
            {
                return 0; 
            }
            else
            {
                return notas.Average(n => n.Nota);
                
            }
        }
    }
    public IEnumerable<Album> Albuns => albuns;

    public void AdicionarAlbum(Album album) 
    { 
        albuns.Add(album);
    }

    public void AdicionarNota(Avaliacao nota)
    {
        if (nota.Nota > 10 || nota.Nota < 0)
        {
            Console.WriteLine("Nota Inválida");
        }
        else
        {
            notas.Add(nota);
        }
    }

    public void ExibirDiscografia()
    {
        Console.WriteLine($"Discografia da banda {Nome}");
        foreach (Album album in albuns)
        {
            Console.WriteLine($"Álbum: {album.Nome} ({album.DuracaoTotal})");
        }
    }
}