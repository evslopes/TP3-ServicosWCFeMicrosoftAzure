using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApi.Migrations
{
    public partial class AddAdcionarAmigo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                    
                    CREATE PROCEDURE [dbo].[AdicionarAmigo]
	                @Nome nvarchar(MAX),
	                @Sobrenome nvarchar(MAX),
	                @Telefone nvarchar(MAX),
	                @DataDeAniversario datetime2(7)
                    AS
	                INSERT INTO [dbo].[Amigo] ([Nome], [Sobrenome], [Telefone], [DataDeAniversario]) 
	                VALUES (@Nome, @Sobrenome, @Telefone, @DataDeAniversario)

                RETURN 0

            "
                );
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                    
                    DROP PROCEDURE [dbo].[AdicionarAmigo]
	               
            "
                );
        }
    }
}
