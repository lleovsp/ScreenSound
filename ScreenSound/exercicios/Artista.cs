
namespace Alura.Filmes;

internal class Artista
{
    public string nome;
    public int idade;
    public List<Filme> filmes = new();
    public Artista(string nome)
    {
        this.nome = nome;
    }
    public void AddFilme(Filme filme)
    {
        if (!filmes.Contains(filme))
        {
            filmes.Add(filme);
            filme.AddArtista(this);
        }

    }
}
