using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APICatalogo.Migrations
{
    /// <inheritdoc />
    public partial class pupulaCategoria : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("insert into Categorias (Nome, imagemURL) Values('Bebida', 'Bebida.pgj')");
            mb.Sql("insert into Categorias (Nome, imagemURL) Values('Lanche', 'Lanche.pgj')");
            mb.Sql("insert into Categorias (Nome, imagemURL) Values('Pizza', 'Pizza.pgj')");

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("truncate Categorias");
        }
    }
}
