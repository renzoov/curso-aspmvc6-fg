using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TareasMVC.Migrations
{
    /// <inheritdoc />
    public partial class AdminRol : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                IF NOT EXISTS(SELECT Id FROM AspNetRoles WHERE Id = '50d3d147-7977-45df-bc75-cb55906a13e7')
                BEGIN
                    INSERT AspNetRoles (Id, [Name], [NormalizedName])
                    VALUES ('50d3d147-7977-45df-bc75-cb55906a13e7', 'admin', 'ADMIN')
                END
            ");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE AspNetRoles WHERE Id = '50d3d147-7977-45df-bc75-cb55906a13e7'");
        }
    }
}
