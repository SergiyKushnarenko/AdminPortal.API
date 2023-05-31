using AdminPortal.API.Models;
using AdminPortal.API.Repositories;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace AdminPortal.API.Controllers
{
    [ApiController]
    public class StudentsController : Controller
    {
        private readonly IStudentRepository _studentRepository;
       // private readonly IMapper _mapper;

        public StudentsController(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
           // _mapper = mapper;
        }

        [HttpGet]
        [Route("[controller]")]
        public async Task<IActionResult> GetAllStudentsAsync()
        {
            var students = await _studentRepository.GetStudentsAsync();

            return Ok(students);
        }
    }
}