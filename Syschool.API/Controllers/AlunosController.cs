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
            List<Aluno> alunos = _alunoService.SelectAllAlunos().ToList();

            return Ok(alunos);
        }
    }
}
