using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EShopGames.ProductAPI.Migrations
{
    public partial class SeedProductDataTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "product",
                columns: new[] { "id", "category_name", "description", "image_url", "name", "price" },
                values: new object[,]
                {
                    { 3L, "Beatiful Picture", "Decription", "https://upload.wikimedia.org/wikipedia/pt/thumb/0/02/Uncharted_3_Boxart.jpg/270px-Uncharted_3_Boxart.jpg", "Name1212", 99.9m },
                    { 4L, "Beatiful Picture", "Decription", "https://upload.wikimedia.org/wikipedia/pt/thumb/0/02/Uncharted_3_Boxart.jpg/270px-Uncharted_3_Boxart.jpgTYyQDkQbjuP8qKLK9kBdS9+QM90z996vrwBnoNOVjzzUUVrgaNiu6cI0Hn9yh1KgjLSefL4qlFKSAz4fBWooqA//9k=", "Name2", 99.9m },
                    { 5L, "Beatiful Picture", "Decription", "https://upload.wikimedia.org/wikipedia/pt/thumb/0/02/Uncharted_3_Boxart.jpg/270px-Uncharted_3_Boxart.jpgTYyQDkQbjuP8qKLK9kBdS9+QM90z996vrwBnoNOVjzzUUVrgaNiu6cI0Hn9yh1KgjLSefL4qlFKSAz4fBWooqA//9k=", "Name3", 99.9m },
                    { 6L, "Beatiful Picture", "Decription", "https://upload.wikimedia.org/wikipedia/pt/thumb/0/02/Uncharted_3_Boxart.jpg/270px-Uncharted_3_Boxart.jpgTYyQDkQbjuP8qKLK9kBdS9+QM90z996vrwBnoNOVjzzUUVrgaNiu6cI0Hn9yh1KgjLSefL4qlFKSAz4fBWooqA//9k=", "Name4", 99.9m },
                    { 7L, "Beatiful Picture", "Decription", "https://upload.wikimedia.org/wikipedia/pt/thumb/0/02/Uncharted_3_Boxart.jpg/270px-Uncharted_3_Boxart.jpgTYyQDkQbjuP8qKLK9kBdS9+QM90z996vrwBnoNOVjzzUUVrgaNiu6cI0Hn9yh1KgjLSefL4qlFKSAz4fBWooqA//9k=", "Name5", 99.9m },
                    { 8L, "Beatiful Picture", "Decription", "https://upload.wikimedia.org/wikipedia/pt/thumb/0/02/Uncharted_3_Boxart.jpg/270px-Uncharted_3_Boxart.jpgTYyQDkQbjuP8qKLK9kBdS9+QM90z996vrwBnoNOVjzzUUVrgaNiu6cI0Hn9yh1KgjLSefL4qlFKSAz4fBWooqA//9k=", "Name6", 99.9m },
                    { 9L, "Beatiful Picture", "Decription", "https://upload.wikimedia.org/wikipedia/pt/thumb/0/02/Uncharted_3_Boxart.jpg/270px-Uncharted_3_Boxart.jpgTYyQDkQbjuP8qKLK9kBdS9+QM90z996vrwBnoNOVjzzUUVrgaNiu6cI0Hn9yh1KgjLSefL4qlFKSAz4fBWooqA//9k=", "Name7", 99.9m },
                    { 10L, "Beatiful Picture", "Decription", "https://upload.wikimedia.org/wikipedia/pt/thumb/0/02/Uncharted_3_Boxart.jpg/270px-Uncharted_3_Boxart.jpgTYyQDkQbjuP8qKLK9kBdS9+QM90z996vrwBnoNOVjzzUUVrgaNiu6cI0Hn9yh1KgjLSefL4qlFKSAz4fBWooqA//9k=", "Name8", 99.9m },
                    { 11L, "Beatiful Picture", "Decription", "https://upload.wikimedia.org/wikipedia/pt/thumb/0/02/Uncharted_3_Boxart.jpg/270px-Uncharted_3_Boxart.jpgTYyQDkQbjuP8qKLK9kBdS9+QM90z996vrwBnoNOVjzzUUVrgaNiu6cI0Hn9yh1KgjLSefL4qlFKSAz4fBWooqA//9k=", "Name9", 99.9m },
                    { 12L, "Beatiful Picture", "Decription", "https://upload.wikimedia.org/wikipedia/pt/thumb/0/02/Uncharted_3_Boxart.jpg/270px-Uncharted_3_Boxart.jpgTYyQDkQbjuP8qKLK9kBdS9+QM90z996vrwBnoNOVjzzUUVrgaNiu6cI0Hn9yh1KgjLSefL4qlFKSAz4fBWooqA//9k=", "Name10", 99.9m },
                    { 13L, "Beatiful Picture", "Decription", "https://upload.wikimedia.org/wikipedia/pt/thumb/0/02/Uncharted_3_Boxart.jpg/270px-Uncharted_3_Boxart.jpgTYyQDkQbjuP8qKLK9kBdS9+QM90z996vrwBnoNOVjzzUUVrgaNiu6cI0Hn9yh1KgjLSefL4qlFKSAz4fBWooqA//9k=", "Name11", 99.9m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 12L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 13L);
        }
    }
}
