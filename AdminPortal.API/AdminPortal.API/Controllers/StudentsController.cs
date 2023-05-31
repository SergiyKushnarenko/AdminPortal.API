using AdminPortal.API.DTOs;
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
        private readonly IMapper _mapper;

        public StudentsController(IStudentRepository studentRepository, IMapper mapper)
        {
            _studentRepository = studentRepository;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("[controller]")]
        public async Task<IActionResult> GetAllStudentsAsync()
        {
            var students = await _studentRepository.GetStudentsAsync();

            return Ok(_mapper.Map<List<StudentDto>>(students));
        }
    }
}