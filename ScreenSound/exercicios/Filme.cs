using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.Filmes;

internal class Filme
{
    public string Nome { get; set; }
    public string Genero { get; set; }
    public string Diretor { get; set; }
    private List<Artista> Artistas = new();
    public Filme(string nome)
    {
        this.Nome = nome;
    }
    public void AddArtista(Artista artista)
    {
        if (!Artistas.Contains(artista))
        {
            Artistas.Add(artista);
            artista.AddFilme(this);
        }
    }
}
