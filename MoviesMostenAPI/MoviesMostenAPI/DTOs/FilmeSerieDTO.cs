using System.ComponentModel.DataAnnotations;

namespace MoviesMostenAPI.DTOs;

public class FilmeSerieDTO
{
    public int Id { get; set; }
    public required string Titulo { get; set; }
    public required string Genero { get; set; }
    public string? Descricao { get; set; }
    public required string Imagem { get; set; }
    public int Gostei { get; set; }
    public int NaoGostei { get; set; }
}
