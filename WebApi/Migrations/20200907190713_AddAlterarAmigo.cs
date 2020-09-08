using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Migrations.Operations;

namespace WebApi.Migrations
{
    public partial class AddAlterarAmigo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                CREATE PROCEDURE [dbo].[AlterarAmigo]
	                @id int,
                    @Nome nvarchar(MAX),
	                @Sobrenome nvarchar(MAX),
	                @Telefone nvarchar(MAX),
	                @DataDeAniversario datetime2(7)
                AS     
                    UPDATE AMIGO SET
                        Nome = @Nome, 
                        Sobrenome = @Sobrenome, 
                        Telefone = @Telefone, 
                        DataDeAniversario = @DataDeAniversario
                    WHERE ID = @id    

            RETURN 0
            ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                DROP PROCEDURE [dbo].[AlterarAmigo]
            ");
        }
    }
}
