using System.ComponentModel.DataAnnotations;

namespace WebAppMvcCalviFederico.Models;

public class Anagrafica
{
    public string? Nome { get; set; }
    public string? Cognome { get; set; }
    [DataType(DataType.Date)]
    public DateTime DataNascita { get; set; }
    public string? Via { get; set; }
    public int NumCivico { get; set; }
    public string? Citta { get; set; }
    public int Cap { get; set; }
    public string? Provincia { get; set; }
    public int Telefono { get; set; }
    public string? Email { get; set; }
    public string? Social { get; set; }
    [Key]
    public string? CodFiscale { get; set; }
}