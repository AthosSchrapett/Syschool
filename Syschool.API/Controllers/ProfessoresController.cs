using Microsoft.AspNetCore.Mvc;
using Syschool.Domain.Entities;
using Syschool.Domain.Interfaces.Services;

namespace Syschool.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfessoresController : ControllerBase
    {
        private readonly IProfessorService _professorService;

        public ProfessoresController(IProfessorService professorService)
        {
            _professorService = professorService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            List<Professor> professores = _professorService.Get().ToList();

            return Ok(professores);
        }

        [HttpGet("id")]
        public IActionResult Get(Guid id)
        {
            Professor professor = _professorService.Get(id);

            return Ok(professor);
        }

        [HttpPost]
        public IActionResult Post(Professor professor)
        {
            if (professor == null)
            {
                return BadRequest();
            }

            _professorService.Insert(professor);

            return Ok(professor);
        }

        [HttpPut]
        public IActionResult Put(Professor professor)
        {
            if (professor == null)
            {
                return BadRequest();
            }

            _professorService.Update(professor);

            return Ok(professor);
        }

        [HttpDelete]
        public IActionResult Delete(Guid id)
        {
            _professorService.Delete(id);

            return Ok();
        }
    }
}
