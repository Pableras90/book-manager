using Microsoft.EntityFrameworkCore;
using BookManager.Domain;


namespace BookManager.Persistence.SqlServer;

    public class BooksDbContext
        : DbContext
    {
        public  BooksDbContext (DbContextOptions<BooksDbContext>options) //Dbcontext se instancia con unas opciones que vienen inyectadas(aqui va el conexion string)
            : base(options)
        {

        }
    // DbSet para la entidad AuthorEntity
    public DbSet<AuthorEntity> Authors { get; set; }

    // DbSet para la entidad BookEntity
    public DbSet<BookEntity> Books { get; set; }


   //protected override void OnModelCreating(ModelBuilder modelBuilder)
   // {
       
   //     modelBuilder.Entity<AuthorEntity>().HasKey(a => a.Id);
   //     modelBuilder.Entity<BookEntity>().HasKey(b => b.Id);
     
   // }

    //Esto indica las claves primarias a EF, ¿es necesario?

}

