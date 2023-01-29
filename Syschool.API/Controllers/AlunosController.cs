using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Syschool.Domain.Entities;
using Syschool.Domain.Interfaces.Services;

namespace Syschool.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlunosController : ControllerBase
    {
        private readonly IAlunoService _alunoService;

        public AlunosController(IAlunoService alunoService)
        {
            _alunoService = alunoService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            List<Aluno> alunos = _alunoService.Get().ToList();

            return Ok(alunos);
        }

        [HttpGet("id")]
        public IActionResult Get(Guid id)
        {
            Aluno aluno = _alunoService.Get(id);

            return Ok(aluno);
        }

        [HttpPost]
        public IActionResult Post(Aluno aluno)
        {
            if (aluno == null)
            {
                return BadRequest();
            }

            _alunoService.Insert(aluno);

            return Ok(aluno);
        }

        [HttpPut]
        public IActionResult Put(Aluno aluno)
        {
            if (aluno == null)
            {
                return BadRequest();
            }

            _alunoService.Update(aluno);

            return Ok(aluno);
        }

        [HttpDelete]
        public IActionResult Delete(Guid id)
        {
            _alunoService.Delete(id);

            return Ok();
        }
    }
}
