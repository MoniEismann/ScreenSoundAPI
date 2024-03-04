using ScreenSound_04.Modelos;
using System.Text.Json;
using ScreenSound_04.Filtros;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;

        LinqFilter.FiltrarPorCSharp(musicas);

        //musicas[0].ExibirDetalhesDaMusica();
        //LinqFilter.FiltrarTodosOsGenerosMusicais(musicas);
        //LinqOrder.ExibirListaDeArtistasOrdenados(musicas);
        //LinqFilter.FiltrarArtistasPorGeneroMusical(musicas, "rock");
        //LinqFilter.FiltrarMusicasDeUmArtista(musicas, "One Direction");


        //var musicasPreferidasDoIgor = new MusicasPreferidas("Igor");
        //musicasPreferidasDoIgor.AdicionarMusicasFavoritas(musicas[1]);
        //musicasPreferidasDoIgor.AdicionarMusicasFavoritas(musicas[394]);
        //musicasPreferidasDoIgor.AdicionarMusicasFavoritas(musicas[1587]);
        //musicasPreferidasDoIgor.AdicionarMusicasFavoritas(musicas[467]);
        //musicasPreferidasDoIgor.AdicionarMusicasFavoritas(musicas[584]);

        //musicasPreferidasDoIgor.ExibirMusicasFavoritas();

        //var musicasPreferidasDaMonica = new MusicasPreferidas("Mônica");
        //musicasPreferidasDaMonica.AdicionarMusicasFavoritas(musicas[652]);
        //musicasPreferidasDaMonica.AdicionarMusicasFavoritas(musicas[14]);
        //musicasPreferidasDaMonica.AdicionarMusicasFavoritas(musicas[53]);
        //musicasPreferidasDaMonica.AdicionarMusicasFavoritas(musicas[496]);
        //musicasPreferidasDaMonica.AdicionarMusicasFavoritas(musicas[1498]);

        //musicasPreferidasDaMonica.ExibirMusicasFavoritas();

        //musicasPreferidasDaMonica.GerarArquivoJson();


    }
    catch (Exception ex) 
    { 
        Console.WriteLine($"Temos um problema: {ex.Message}");
    }

 }