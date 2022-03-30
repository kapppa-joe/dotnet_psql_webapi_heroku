using Microsoft.EntityFrameworkCore;
using project.Models;

namespace project.Data;

public class PsqlDbContext : DbContext
{
    public PsqlDbContext(DbContextOptions<PsqlDbContext> options) : base(options)
    {
        // this.Database.EnsureCreated();
        this.Database.MigrateAsync();
    }

    public DbSet<Note> Notes => Set<Note>();

    public DbSet<Alpaca> Alpacas => Set<Alpaca>();

    public DbSet<Appointment> Appointments => Set<Appointment>();
}