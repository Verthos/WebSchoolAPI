using DataAccess.DbAccess;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository.IRepository
{
    public class AlunoRepository : Repository<Aluno>, IAlunoRepository
    {
        private readonly ISqlDataAccess _db;
        public AlunoRepository(ISqlDataAccess db) : base(db)
        {
            _db = db;
        }

        public void Save()
        {
            
            //_db.SaveData();
        }

        public void Update(Aluno aluno)
        {
            throw new NotImplementedException();
        }
    }
}
