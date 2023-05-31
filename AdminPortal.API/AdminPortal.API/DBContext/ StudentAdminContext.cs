using AdminPortal.API.Models;
using Microsoft.EntityFrameworkCore;

namespace AdminPortal.API.DBContext;

public class StudentAdminContext : DbContext
{
    public StudentAdminContext(DbContextOptions<StudentAdminContext> options) : base(options)
    {
    }

    public DbSet<Student> Student { get; set; }
    public DbSet<Gender> Gender { get; set; }
    public DbSet<Address> Address { get; set; }
}