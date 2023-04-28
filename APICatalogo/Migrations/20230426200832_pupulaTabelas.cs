using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APICatalogo.Migrations
{
    /// <inheritdoc />
    public partial class pupulaTabelas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder mb)
        {
            //categoria 

            mb.Sql("insert into Categoria (Nome, imagemURL)"
                    + "Values('Bebida', 'Bebida.pgj')");
            mb.Sql("insert into Categoria (Nome, imagemURL)"
                + "Values('Lanche', 'Lanche.pgj')");
            mb.Sql("insert into Categoria (Nome, imagemURL)"
                + "Values('Pizza', 'Pizza.pgj')");


            /// Produto
            /// 
            
           
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder mb)
        {
           
            mb.Sql("TRUNCATE Categoria");
           
        }
    }
}
