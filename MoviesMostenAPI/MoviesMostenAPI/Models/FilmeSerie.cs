using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoviesMostenAPI.Models;

public class FilmeSerie
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Required(ErrorMessage = "Você deve preencher o {0}")]
    public required string Titulo { get; set; }

    [Required(ErrorMessage = "Você deve preencher o {0}")]
    public required List<string> Genero { get; set; }

    public string? Descricao { get; set; }

    [Required(ErrorMessage = "Você deve preencher a {0}")]
    public required string Imagem { get; set; }
    public int Gostei { get; set; } = 0;
    public int NaoGostei { get; set; } = 0;
    
}
