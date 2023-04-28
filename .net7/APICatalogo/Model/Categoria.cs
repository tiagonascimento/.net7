using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APICatalogo.Model;
/// <summary>
/// Propriedade anêmica
/// </summary>

[Table("Categoria")]
public class Categoria
{
    public Categoria()
    {
        Produto= new Collection<Produto>();
    }
    [Key]
    public int IdCategoria { get; set; }
    [Required]
    [MaxLength(100)]    
    public string? Nome { get; set; }    
    [Required]
    [MaxLength(300)]
    public string? ImagemURL { get; set; }
    public ICollection<Produto> Produto { get; set; }
}
