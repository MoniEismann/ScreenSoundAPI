using System.Text.Json;
using System.Text.Json.Serialization;

namespace ScreenSound_04.Modelos;

internal class MusicasPreferidas
{
    public string? Nome { get; set; }
    public List<Musica> ListaDeMusicasFavoritas {  get; }

    public MusicasPreferidas(string nome) 
    {
        Nome = nome;
        ListaDeMusicasFavoritas = new List<Musica>();
    
    }

    public void AdicionarMusicasFavoritas(Musica musica)
    {
        ListaDeMusicasFavoritas.Add(musica);
    }

    public void ExibirMusicasFavoritas()
    {
        Console.WriteLine($"Essas são as músicas favoritas -> {Nome}");
        foreach(var musica in ListaDeMusicasFavoritas)
        {
            Console.WriteLine($"->{musica.Nome} de {musica.Artista}");
        }
    }

    public void GerarAqruivoJson()
    {
        string Json = JsonSerializer.Serialize(new
        {
            nome = Nome,
            musicas = ListaDeMusicasFavoritas
        });
        string NomeDoArquivo = $"musicas-favoritas-{Nome}.json";
        
        File.WriteAllText(NomeDoArquivo, Json);
        Console.WriteLine($"O arquivo json foi criado com sucesso{Path.GetFullPath(NomeDoArquivo)}");
    }
}
