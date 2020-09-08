using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApi.Migrations
{
    public partial class AddBuscarAmigo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"

            CREATE PROCEDURE [dbo].[BuscarAmigo]
            AS
	            SELECT * from Amigo
            RETURN 0
         ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"

            DROP PROCEDURE [dbo].[BuscarAmigo]
            
        ");
        }
    }
}
