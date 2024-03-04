using ScreenSound_04.Modelos;

namespace ScreenSound_04.Filtros;

internal class LinqOrder
{
    public static void ExibirListaDeArtistasOrdenados(List<Musica> musicas)
    {
        var artistasOrdenados = musicas.OrderBy(musicas => musicas.Artista).Select(musicas => musicas.Artista).Distinct().ToList();
        Console.WriteLine("Lista de artistas ordenados");
        foreach (var artist in artistasOrdenados)
        {
            Console.WriteLine($"- {artist}");
        }
    }
}
