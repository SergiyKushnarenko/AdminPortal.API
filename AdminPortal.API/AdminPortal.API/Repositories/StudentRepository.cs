using AdminPortal.API.DBContext;
using AdminPortal.API.Models;
using Microsoft.EntityFrameworkCore;

namespace AdminPortal.API.Repositories;

public class StudentRepository : IStudentRepository
{
    private readonly StudentAdminContext _context;
    public StudentRepository(StudentAdminContext context)
    {
        _context = context;
    }

    public async Task<List<Student>> GetStudentsAsync()
    {
        return await _context.Student.Include(nameof(Gender)).Include(nameof(Address)).ToListAsync();
    }
}