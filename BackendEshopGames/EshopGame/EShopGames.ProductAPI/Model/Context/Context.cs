using Microsoft.EntityFrameworkCore;

namespace EShopGames.ProductAPI.Model.Context
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options) {}
    
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 3,
                Name = "Name1212",
                Price = new decimal(99.9),
                Description = "Decription",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/pt/thumb/0/02/Uncharted_3_Boxart.jpg/270px-Uncharted_3_Boxart.jpg",
                CategoryName = "Beatiful Picture"
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 4,
                Name = "Name2",
                Price = new decimal(99.9),
                Description = "Decription",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/pt/thumb/0/02/Uncharted_3_Boxart.jpg/270px-Uncharted_3_Boxart.jpgTYyQDkQbjuP8qKLK9kBdS9+QM90z996vrwBnoNOVjzzUUVrgaNiu6cI0Hn9yh1KgjLSefL4qlFKSAz4fBWooqA//9k=",
                CategoryName = "Beatiful Picture"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 5,
                Name = "Name3",
                Price = new decimal(99.9),
                Description = "Decription",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/pt/thumb/0/02/Uncharted_3_Boxart.jpg/270px-Uncharted_3_Boxart.jpgTYyQDkQbjuP8qKLK9kBdS9+QM90z996vrwBnoNOVjzzUUVrgaNiu6cI0Hn9yh1KgjLSefL4qlFKSAz4fBWooqA//9k=",
                CategoryName = "Beatiful Picture"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 6,
                Name = "Name4",
                Price = new decimal(99.9),
                Description = "Decription",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/pt/thumb/0/02/Uncharted_3_Boxart.jpg/270px-Uncharted_3_Boxart.jpgTYyQDkQbjuP8qKLK9kBdS9+QM90z996vrwBnoNOVjzzUUVrgaNiu6cI0Hn9yh1KgjLSefL4qlFKSAz4fBWooqA//9k=",
                CategoryName = "Beatiful Picture"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 7,
                Name = "Name5",
                Price = new decimal(99.9),
                Description = "Decription",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/pt/thumb/0/02/Uncharted_3_Boxart.jpg/270px-Uncharted_3_Boxart.jpgTYyQDkQbjuP8qKLK9kBdS9+QM90z996vrwBnoNOVjzzUUVrgaNiu6cI0Hn9yh1KgjLSefL4qlFKSAz4fBWooqA//9k=",
                CategoryName = "Beatiful Picture"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 8,
                Name = "Name6",
                Price = new decimal(99.9),
                Description = "Decription",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/pt/thumb/0/02/Uncharted_3_Boxart.jpg/270px-Uncharted_3_Boxart.jpgTYyQDkQbjuP8qKLK9kBdS9+QM90z996vrwBnoNOVjzzUUVrgaNiu6cI0Hn9yh1KgjLSefL4qlFKSAz4fBWooqA//9k=",
                CategoryName = "Beatiful Picture"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 9,
                Name = "Name7",
                Price = new decimal(99.9),
                Description = "Decription",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/pt/thumb/0/02/Uncharted_3_Boxart.jpg/270px-Uncharted_3_Boxart.jpgTYyQDkQbjuP8qKLK9kBdS9+QM90z996vrwBnoNOVjzzUUVrgaNiu6cI0Hn9yh1KgjLSefL4qlFKSAz4fBWooqA//9k=",
                CategoryName = "Beatiful Picture"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 10,
                Name = "Name8",
                Price = new decimal(99.9),
                Description = "Decription",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/pt/thumb/0/02/Uncharted_3_Boxart.jpg/270px-Uncharted_3_Boxart.jpgTYyQDkQbjuP8qKLK9kBdS9+QM90z996vrwBnoNOVjzzUUVrgaNiu6cI0Hn9yh1KgjLSefL4qlFKSAz4fBWooqA//9k=",
                CategoryName = "Beatiful Picture"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 11,
                Name = "Name9",
                Price = new decimal(99.9),
                Description = "Decription",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/pt/thumb/0/02/Uncharted_3_Boxart.jpg/270px-Uncharted_3_Boxart.jpgTYyQDkQbjuP8qKLK9kBdS9+QM90z996vrwBnoNOVjzzUUVrgaNiu6cI0Hn9yh1KgjLSefL4qlFKSAz4fBWooqA//9k=",
                CategoryName = "Beatiful Picture"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 12,
                Name = "Name10",
                Price = new decimal(99.9),
                Description = "Decription",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/pt/thumb/0/02/Uncharted_3_Boxart.jpg/270px-Uncharted_3_Boxart.jpgTYyQDkQbjuP8qKLK9kBdS9+QM90z996vrwBnoNOVjzzUUVrgaNiu6cI0Hn9yh1KgjLSefL4qlFKSAz4fBWooqA//9k=",
                CategoryName = "Beatiful Picture"
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 13,
                Name = "Name11",
                Price = new decimal(99.9),
                Description = "Decription",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/pt/thumb/0/02/Uncharted_3_Boxart.jpg/270px-Uncharted_3_Boxart.jpgTYyQDkQbjuP8qKLK9kBdS9+QM90z996vrwBnoNOVjzzUUVrgaNiu6cI0Hn9yh1KgjLSefL4qlFKSAz4fBWooqA//9k=",
                CategoryName = "Beatiful Picture"
            });
        }
    
    }
}
