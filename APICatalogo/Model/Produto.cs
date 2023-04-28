namespace APICatalogo.Model;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

/// <summary>
/// Propriedade Anêmica
/// </summary>
/// 
[Table("Produto")]
public class Produto
{
    [Key]
    public int IdProduto { get; set; }
    [Required]
    [StringLength (100)]
    public string? Nome { get; set; }
    [Required]
    [StringLength(200)]
    public string? Descricao { get; set; }
    [Required]
    [Column(TypeName ="decimal(10,2)")]
    public decimal Preco { get; set; }
    [Required]
    [StringLength(400)]
    public string? ImagemUrl { get; set; }
    public int Estoque { get; set; }
    public DateTime DataCadastro { get; set; }
    [ForeignKey("CategoriID")]
    public int CategoriID { get; set; }   
    public Categoria? Categoria { get; set; }

}
