using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace APICatalogo.Model;
/// <summary>
/// Propriedade anêmica
/// </summary>

[Table("Categorias")]
public class Categoria
{
    public Categoria()
    {
        Produtos = new Collection<Produto>();
    }
    [Key]
    public int CategoriaId { get; set; }
    [Required]
    [MaxLength(100)]
    public string? Nome { get; set; }
    [Required]
    [MaxLength(300)]
    public string? ImagemURL { get; set; }
    [JsonIgnore(Condition =JsonIgnoreCondition.WhenWritingNull)]
    public ICollection<Produto>? Produtos { get; set; }
}
