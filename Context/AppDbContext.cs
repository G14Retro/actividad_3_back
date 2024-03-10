using actividad_3_back.Models.DAO;
using Microsoft.EntityFrameworkCore;

namespace actividad_3_back.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public virtual DbSet<ProductModel>  Products { get; set; }
        public virtual DbSet<FeatureModel>  Features { get; set; }
        public virtual DbSet<ProductsFeatureModel> ProductsFeatures { get; set; }
        public virtual DbSet<UserModel> Users { get; set; }
        public virtual DbSet<RolesModel> Roles { get; set; }
        public virtual DbSet<Users_Has_RolesModel> Users_Has_Roles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<ProductModel>(entity =>
            //{

            //    entity.ToTable("products");

            //    entity.HasIndex(e => e.IdProducts, "idProducts_UNIQUE").IsUnique();

            //    entity.Property(e => e.IdProducts).ValueGeneratedOnAdd();

            //    entity.Property(e => e.Brand).HasComment("Indica la marca del producto");

            //    entity.Property(e => e.Resumen).HasComment("Da el resumen del producto");

            //    entity.Property(e => e.Price).HasComment("Es el valor del producto");

            //    entity.HasMany(d => d.Features)
            //    .WithMany(e => e.Product)
            //    .UsingEntity<Dictionary<string, object>>(
            //        "productsfeature",
            //        l => l.HasOne<FeatureModel>().WithMany().HasForeignKey("IdFeatures").OnDelete(DeleteBehavior.Cascade).HasConstraintName("fk_Products_has_Features_Features"),
            //        r => r.HasOne<ProductModel>().WithMany().HasForeignKey("IdProducts").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("fk_Products_has_Features_Products"),
            //        j =>
            //        {
            //            j.HasKey("IdFeatures", "IdProducts");
            //            j.ToTable("productsfeature");
            //        }
            //        );
            //});

            //modelBuilder.Entity<FeatureModel>(entity =>
            //{
            //    entity.ToTable("features");
            //    entity.HasIndex(e => e.IdFeatures, "idProducts_UNIQUE").IsUnique();

            //    entity.Property(e => e.IdFeatures).ValueGeneratedOnAdd();

            //    entity.Property(e => e.Name).HasComment("Indica el nombre de la caracteristica");

            //    entity.Property(e => e.Value).HasComment("Informa el valor de la caracteristica");
            //});

            //modelBuilder.Entity<ProductsFeatureModel>(entity =>
            //{
            //    entity.ToTable("productsfeature");
            //    entity.HasNoKey();
            //});
            //modelBuilder.Entity<UserModel>(entity =>
            //{

            //    entity.ToTable("users");

            //    entity.HasIndex(e => e.IdUsers, "idUsers_UNIQUE").IsUnique();

            //    entity.Property(e => e.IdUsers).ValueGeneratedOnAdd();

            //    entity.Property(e => e.Name).HasComment("Indica el nombre de la persona");

            //    entity.Property(e => e.FirtsName).HasComment("Indica el apellido de la persona");

            //    entity.Property(e => e.Email).HasComment("Indica el email del usuario");

            //    entity.Property(e => e.Password).HasComment("Indica la contraseña del usuario");

            //    entity.HasMany(d => d.Roles)
            //    .WithMany(e => e.User)
            //    .UsingEntity<Dictionary<string, object>>(
            //        "productsfeature",
            //        l => l.HasOne<FeatureModel>().WithMany().HasForeignKey("IdFeatures").OnDelete(DeleteBehavior.Cascade).HasConstraintName("fk_Products_has_Features_Features"),
            //        r => r.HasOne<ProductModel>().WithMany().HasForeignKey("IdProducts").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("fk_Products_has_Features_Products"),
            //        j =>
            //        {
            //            j.HasKey("IdFeatures", "IdProducts");
            //            j.ToTable("productsfeature");
            //        }
            //        );
            //});
            modelBuilder.Entity<UserModel>(entity =>
            {
                entity.HasKey(e => e.IdUsers);

                entity.HasMany(e => e.Roles)
                .WithMany(p=>p.Users).UsingEntity<Users_Has_RolesModel>();
            });

            modelBuilder.Entity<RolesModel>(entity =>
            {
                entity.HasKey(e => e.IdRoles);

                entity.HasMany(e => e.Users)
                .WithMany(p => p.Roles).UsingEntity<Users_Has_RolesModel>();
            });

            modelBuilder.Entity<Users_Has_RolesModel>().HasNoKey();
        }

    }
}
