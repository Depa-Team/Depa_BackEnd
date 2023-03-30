using Hostlify.Infraestructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Hostlify.Infraestructure.Context;

public class HostlifyDB:DbContext
{
    public HostlifyDB() //Entity Framework me dice que debo tener constructores
    {
    }
    public HostlifyDB(DbContextOptions<HostlifyDB> options) : base(options) //Entity Framework me dice que debo tener constructores
    {
    }
    
    public DbSet<Plan> Plans { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Flat> Flats { get; set; }
    public DbSet<History> History { get; set; }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured) //Aqui valido otra vez si mi BD esta configurado, sino lo vuelvo a configurar 5 Y HACEMOS LA MIGRACION 6 NUGET:Entity framework core tools
        {
            var serverVersion = new MySqlServerVersion(new Version(8, 0, 31));
            optionsBuilder.UseMySql("server=localhost;user=root;password=123456;database=depadb; ",serverVersion);
        }
    }
    
    
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        
        builder.Entity<Plan>().ToTable("Plans");
        builder.Entity<Plan>().HasKey(p => p.Id);
        builder.Entity<Plan>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
        builder.Entity<Plan>().Property(p => p.Name).IsRequired().HasMaxLength(15);
        builder.Entity<Plan>().Property(p => p.Rooms).HasDefaultValue(null);
        builder.Entity<Plan>().Property(p => p.Price).IsRequired();
        builder.Entity<Plan>().Property(p => p.DateCreated).HasDefaultValue(DateTime.Now);
        builder.Entity<Plan>().Property(p => p.IsActive).HasDefaultValue(true);
        
        builder.Entity<User>().ToTable("Users");
        builder.Entity<User>().HasKey(p => p.Id);
        builder.Entity<User>().Property(c => c.Name).IsRequired();
        builder.Entity<User>().Property(c => c.Password).IsRequired();
        builder.Entity<User>().Property(c => c.Email).IsRequired();
        builder.Entity<User>().Property(c => c.Plan).HasDefaultValue(null);
        builder.Entity<User>().Property(c => c.Type).IsRequired();
        builder.Entity<User>().Property(c => c.phoneNumber).IsRequired();
        builder.Entity<User>().Property(c => c.DateCreated).IsRequired().HasDefaultValue(DateTime.Now);
        builder.Entity<User>().Property(c => c.IsActive).IsRequired().HasDefaultValue(true);

        builder.Entity<Flat>().ToTable("Flats");
        builder.Entity<Flat>().HasKey(p => p.Id);
        builder.Entity<Flat>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
        builder.Entity<Flat>().Property(p => p.flatName).IsRequired().HasMaxLength(15);
        builder.Entity<Flat>().Property(p => p.GuestId);
        builder.Entity<Flat>().Property(p => p.ManagerId).IsRequired();
        builder.Entity<Flat>().Property(p => p.Initialdate);
        builder.Entity<Flat>().Property(p => p.EndDate);
        builder.Entity<Flat>().Property(p => p.Status).IsRequired().HasDefaultValue(true);
        builder.Entity<Flat>().Property(p => p.Price);
        builder.Entity<Flat>().Property(p => p.DateCreated).HasDefaultValue(DateTime.Now);
        builder.Entity<Flat>().Property(p => p.IsActive).HasDefaultValue(true);

        builder.Entity<History>().ToTable("History");
        builder.Entity<History>().HasKey(p => p.id);
        builder.Entity<History>().Property(p => p.id).IsRequired().ValueGeneratedOnAdd();
        builder.Entity<History>().Property(p => p.flatName).IsRequired().HasMaxLength(15);
        builder.Entity<History>().Property(p => p.managerId).IsRequired();
        builder.Entity<History>().Property(p => p.guestName).IsRequired();
        builder.Entity<History>().Property(p => p.initialDate).IsRequired();
        builder.Entity<History>().Property(p => p.endDate).IsRequired();
        builder.Entity<History>().Property(p => p.price).IsRequired();
        builder.Entity<History>().Property(p => p.DateCreated).HasDefaultValue(DateTime.Now);
        builder.Entity<History>().Property(p => p.IsActive).HasDefaultValue(true);
       


    }
}