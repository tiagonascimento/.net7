namespace APICatalogo.Model;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
/// <summary>
/// Propriedade Anêmica
/// </summary>
/// 
[Table("Produtos")]
public class Produto
{
    [Key]
    public int ProdutoId { get; set; }
    [Required]
    [StringLength(100)]
    public string? Nome { get; set; }
    [Required]
    [StringLength(200)]
    public string? Descricao { get; set; }
    [Required]
    [Column(TypeName = "decimal(10,2)")]
    public decimal Preco { get; set; }
    [Required]
    [StringLength(400)]
    public string? ImagemUrl { get; set; }
    public float Estoque { get; set; }
    public DateTime DataCadastro { get; set; }
    [ForeignKey("CategoriaId")]
    public int CategoriaId { get; set; }
    [JsonIgnore]
    public Categoria? Categoria { get; set; }

}
