namespace MoviesMostenAPI.DTOs;

public class CriarFilmeSerieDTO
{
    public required string Titulo { get; set; }
    public required List<string> Genero { get; set; }
    public string? Descricao { get; set; }
    public required string Imagem { get; set; }
}
