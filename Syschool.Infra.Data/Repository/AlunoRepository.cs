using Syschool.Domain.Entities;
using Syschool.Domain.Interfaces.Repositories;
using Syschool.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syschool.Infra.Data.Repository
{
    public class AlunoRepository : BaseRepository<Aluno>, IAlunoRepository
    {
        public AlunoRepository(SyschoolContext syschoolContext) : base(syschoolContext)
        {
        }
    }
}
