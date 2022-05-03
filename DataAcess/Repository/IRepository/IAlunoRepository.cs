using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository.IRepository
{
    public interface IAlunoRepository : IRepository<Aluno>
    {
        void Update(Aluno aluno);
        void Save();
    }
}
