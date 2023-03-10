using ImageGallery.Models;
using Microsoft.EntityFrameworkCore;

namespace ImageGallery.DataBase
{
    public class GalleryContext : DbContext
    {
        public GalleryContext(DbContextOptions<GalleryContext> options) : base(options)
        {

        }

        public GalleryContext()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Configurando a string de conexão com o banco de dados.

            optionsBuilder.UseMySql("server=localhost;port=3306;database=dbGallery;uid=root;SslMode=None;ConvertZeroDateTime=true;pooling=no");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configurando a nomenclatura das tabelas ao serem geradas

            modelBuilder.Entity<Image>().ToTable("Imagem");
            modelBuilder.Entity<Gallery>().ToTable("Galeria");
        }

        // instância contextual das tabelas criadas na base de dados.

        public DbSet<Gallery> Galerias { get; set; }
        public DbSet<Image> Imagens { get; set; }
    }
}