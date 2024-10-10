using Microsoft.EntityFrameworkCore;

class ElContext : DbContext{
    public DbSet<Administrador> Administrador {get; set;}
    public DbSet<Usuario> Usuario {get; set;}

    string stringConexao = "Server=localhost;Port=3306;Database=Hotel;Uid=root;Pwd=root;";

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseMySql(stringConexao, ServerVersion.AutoDetect(stringConexao));

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
       modelBuilder.Entity<Administrador>().ToTable("Usuario");
       modelBuilder.Entity<Administrador>().ToTable("Administrador");
    }

}