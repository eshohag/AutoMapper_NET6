using AutoMapper;
using AutoMapper_NET6.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AutoMapper_NET6.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IMapper _mapper;

        public StudentController(IMapper mapper)
        {
            _mapper = mapper;
        }

        [HttpGet()]
        public async Task<IActionResult> Get()
        {
            var originalDB = new List<Student>();
            originalDB.Add(new Student() { Id = 1, FirstName = "Md Shohag", LastName = "Mia", Email = "eshohag@outlook.com" });
            originalDB.Add(new Student() { Id = 2, FirstName = "Md Shohag", LastName = "Hassan", Email = "eshohag@outlook.com" });

            var viewData = _mapper.Map<List<StudentViewModel>>(originalDB);
            return Ok(viewData);
        }
    }
}
