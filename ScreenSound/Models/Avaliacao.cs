
namespace ScreenSound.Models;

internal class Avaliacao
{
    public int Nota 
    {
        get;
        set;
    }
    public Avaliacao(int nota)
    {
        this.Nota = nota;
    }
    public static Avaliacao ParseInt(int nota)
    {
        return new Avaliacao(nota);
    }
}
