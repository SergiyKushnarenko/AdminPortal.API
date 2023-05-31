using AdminPortal.API.Models;

namespace AdminPortal.API.Repositories;

public interface IStudentRepository
{
    Task<List<Student>> GetStudentsAsync();
}