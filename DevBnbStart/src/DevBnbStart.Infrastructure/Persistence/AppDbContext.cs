using DevBnbStart.Core.Entities;
using Microsoft.EntityFrameworkCore;


namespace DevBnbStart.Infrastructure.Persistence
{
    public class AppDbContext : DbContext
    {
        public AppDbContext( DbContextOptions<AppDbContext> options) : base (options)
        {

        }
        public DbSet<Host> Hosts { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Property> Properties { get; set; }
        public DbSet<Accomodation> Accomodations { get; set; }
        public DbSet<AccomodationAmenity> AccommodationAmenities { get; set; }
        public DbSet<Amenity> Amenities { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            // Configurar Address como tipo complexo (owned entity)
            builder.Entity<Host>(e =>
            {
                e.HasKey(h => h.Id);
                e.Property(h => h.Bio).HasMaxLength(300).IsRequired().HasDefaultValue("");
                e.Property(h => h.BankData).HasMaxLength(200).IsRequired().HasDefaultValue("");
                
                e.OwnsOne(h => h.Address, address =>
                {
                    address.Property(a => a.Street).HasMaxLength(200).IsRequired();
                    address.Property(a => a.Number).HasMaxLength(20).IsRequired();
                    address.Property(a => a.Neighborhood).HasMaxLength(100).IsRequired();
                    address.Property(a => a.City).HasMaxLength(100).IsRequired();
                    address.Property(a => a.State).HasMaxLength(50).IsRequired();
                    address.Property(a => a.Country).HasMaxLength(100).IsRequired();
                    address.Property(a => a.ZipCode).HasMaxLength(20).IsRequired();
                });
                e.HasMany(h => h.Properties)
                    .WithOne(p => p.Host)
                    .HasForeignKey(p => p.IdHost)
                    .OnDelete(DeleteBehavior.Restrict);

            });

            builder.Entity<Client>(e =>
            {
                e.HasKey(c => c.Id);
                e.Property(c => c.Observations).HasMaxLength(1000).IsRequired().HasDefaultValue("");
                
                e.OwnsOne(c => c.Address, address =>
                {
                    address.Property(a => a.Street).HasColumnName("Street").HasMaxLength(200).IsRequired();
                    address.Property(a => a.Number).HasColumnName("Number").HasMaxLength(20).IsRequired();
                    address.Property(a => a.Neighborhood).HasColumnName("Neighborhood").HasMaxLength(100).IsRequired();
                    address.Property(a => a.City).HasColumnName("City").HasMaxLength(100).IsRequired();
                    address.Property(a => a.State).HasColumnName("State").HasMaxLength(50).IsRequired();
                    address.Property(a => a.Country).HasColumnName("Country").HasMaxLength(100).IsRequired();
                    address.Property(a => a.ZipCode).HasColumnName("ZipCode").HasMaxLength(20).IsRequired();
               
                });
            });

            builder.Entity<Property>(e =>
            {
                e.HasKey(p => p.Id);

                e.HasMany(p => p.Accomodations)
                 .WithOne(a => a.Property)
                 .HasForeignKey(a => a.IdProperty)
                 .OnDelete(DeleteBehavior.Restrict);

                e.Property(p => p.Title).HasMaxLength(100).IsRequired();
                
                
                e.OwnsOne(p => p.Address, address =>
                {
                    address.Property(a => a.Street).HasColumnName("Street").HasMaxLength(200).IsRequired();
                    address.Property(a => a.Number).HasColumnName("Number").HasMaxLength(20).IsRequired();
                    address.Property(a => a.Neighborhood).HasColumnName("Neighborhood").HasMaxLength(100).IsRequired();
                    address.Property(a => a.City).HasColumnName("City").HasMaxLength(100).IsRequired();
                    address.Property(a => a.State).HasColumnName("State").HasMaxLength(50).IsRequired();
                    address.Property(a => a.Country).HasColumnName("Country").HasMaxLength(100).IsRequired();
                    address.Property(a => a.ZipCode).HasColumnName("ZipCode").HasMaxLength(20).IsRequired();
                
                });
            });

            builder.Entity<Accomodation>(e =>
            {
                e.HasKey(p => p.Id);

            });

            builder.Entity<Amenity>(e =>
            {
                e.HasKey(a => a.Id);
            });

            builder.Entity<AccomodationAmenity>(e =>
            {
                e.HasKey(a => a.Id);
                e.HasOne(a => a.Amenity)
                    .WithMany(a => a.AccomodationAmenities)
                    .HasForeignKey(a => a.IdAmenity)
                    .OnDelete(DeleteBehavior.Restrict);

                e.HasOne(a => a.Accomodation)
                    .WithMany(a => a.Amenities)
                    .HasForeignKey(a => a.IdAccommodation)
                    .OnDelete(DeleteBehavior.Restrict);

            });
            base.OnModelCreating(builder);
        }
    }
}
