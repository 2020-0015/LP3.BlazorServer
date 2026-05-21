using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using LP3.BlazorServer.Domain.Entities;

namespace LP3.BlazorServer.Data;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
{
    public DbSet<Estudiante> Estudiantes=>Set<Estudiante>(); 
    
    public DbSet<Curso> Cursos=>Set<Curso>();

    public DbSet<Matriculacion> Matriculaciones=>Set<Matriculacion>();

    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        return base.SaveChangesAsync(cancellationToken);
    }
}


