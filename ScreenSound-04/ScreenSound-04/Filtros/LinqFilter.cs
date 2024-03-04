using ScreenSound_04.Modelos;

namespace ScreenSound_04.Filtros;

internal class LinqFilter
{
    public static void FiltrarTodosOsGenerosMusicais(List<Musica> musicas)
    {
        var todosOsGenerosMusicais = musicas.Select(generos => generos.Genero).Distinct().ToList();
        foreach (var genero in todosOsGenerosMusicais)
        {
            Console.WriteLine($"- {genero}");
        }
    }

    public static void FiltrarArtistasPorGeneroMusical(List<Musica> musicas, string genero)
    {
        var artistasPorGeneroMusical = musicas.Where(musicas => musicas.Genero!.Contains(genero))
            .Select(musicas => musicas.Artista).Distinct().ToList();
        Console.WriteLine($"Exibindo artistas por genero musical >>>> {genero}");
        foreach (var artist in artistasPorGeneroMusical)
        {
            Console.WriteLine($"- {artist}");
        }
    }

    public static void FiltrarMusicasDeUmArtista(List<Musica> musicas, string nomeDoArtista)
    {
        var musicasDoArtista = musicas.Where(musicas => musicas.Artista!.Equals(nomeDoArtista)).ToList();
        Console.WriteLine(nomeDoArtista);
        foreach (var musica in musicasDoArtista)
        {
            Console.WriteLine($"- {musica.Nome}");
        }
    }
    internal static void FiltrarPorCSharp(List<Musica> musicas)
    {
        var musicasEmCSharp = musicas.Where(musicas => musicas.Tonalidade.Equals("C#")).Select(musicas => musicas.Nome).ToList();
        Console.WriteLine("Musicas em C#:");

        foreach (var musica in musicasEmCSharp)
        {
            Console.WriteLine($"- {musica}");

        }
    }
}
