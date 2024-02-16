using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MasjidLibraryAPI.Migrations
{
    /// <inheritdoc />
    public partial class TagTableAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BorrowedForNumberOfDays",
                table: "Distributions");

            migrationBuilder.AlterColumn<string>(
                name: "MobileNo",
                table: "Readers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<short>(
                name: "Gender",
                table: "Readers",
                type: "smallint",
                nullable: false,
                defaultValue: (short)0);

            migrationBuilder.AddColumn<string>(
                name: "ImageName",
                table: "Readers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "NIDImage",
                table: "Readers",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NIDName",
                table: "Readers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Pin",
                table: "Readers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserIdentifier",
                table: "Readers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "UserImage",
                table: "Readers",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserImageUrl",
                table: "Readers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<short>(
                name: "UserStatusType",
                table: "Readers",
                type: "smallint",
                nullable: false,
                defaultValue: (short)0);

            migrationBuilder.AddColumn<short>(
                name: "NumberOfDay",
                table: "Distributions",
                type: "smallint",
                nullable: false,
                defaultValue: (short)0);

            migrationBuilder.AddColumn<byte[]>(
                name: "CoverImage",
                table: "Books",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CoverImageName",
                table: "Books",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CoverImageUrl",
                table: "Books",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Publication",
                table: "Books",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Reference",
                table: "Books",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "TableOfContentImage",
                table: "Books",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TableOfContentImageName",
                table: "Books",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Tags",
                columns: table => new
                {
                    TagId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TagName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tags", x => x.TagId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tags");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Readers");

            migrationBuilder.DropColumn(
                name: "ImageName",
                table: "Readers");

            migrationBuilder.DropColumn(
                name: "NIDImage",
                table: "Readers");

            migrationBuilder.DropColumn(
                name: "NIDName",
                table: "Readers");

            migrationBuilder.DropColumn(
                name: "Pin",
                table: "Readers");

            migrationBuilder.DropColumn(
                name: "UserIdentifier",
                table: "Readers");

            migrationBuilder.DropColumn(
                name: "UserImage",
                table: "Readers");

            migrationBuilder.DropColumn(
                name: "UserImageUrl",
                table: "Readers");

            migrationBuilder.DropColumn(
                name: "UserStatusType",
                table: "Readers");

            migrationBuilder.DropColumn(
                name: "NumberOfDay",
                table: "Distributions");

            migrationBuilder.DropColumn(
                name: "CoverImage",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "CoverImageName",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "CoverImageUrl",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "Publication",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "Reference",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "TableOfContentImage",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "TableOfContentImageName",
                table: "Books");

            migrationBuilder.AlterColumn<int>(
                name: "MobileNo",
                table: "Readers",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BorrowedForNumberOfDays",
                table: "Distributions",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
