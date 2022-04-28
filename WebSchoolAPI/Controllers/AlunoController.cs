using BuildingClasses.Model;
using DataAccess.DbAccess;
using Microsoft.AspNetCore.Mvc;

namespace WebSchoolAPI.Controllers
{ 
    [ApiController]
    [Route("[controller]")]
    public class AlunoController : Controller
    {
        private readonly ISqlDataAccess _db;
        public AlunoController(ISqlDataAccess db)
        {
            _db = db;
        }


        [Route("[action]")]
        [HttpGet]
        public Task<IEnumerable<Aluno>> GetAlunos() => _db.LoadData<Aluno, dynamic>(storedProcedure: "dbo.GET_ALUNOS", new { });

        [Route("[action]")]
        [HttpGet]
        public async Task<Aluno?> GetAlunoWithId(int id)
        {
            var result = await _db.LoadData<Aluno, dynamic>(storedProcedure: "", new { Id = id });
            return result.FirstOrDefault();
        }

        [Route("[action]")]
        [HttpPost]
        public async Task<Aluno?> InsertAluno(int id)
        {
            var result = await _db.LoadData<Aluno, dynamic>(storedProcedure: "", new { Id = id });
            return result.FirstOrDefault();
        }




        [Route("[action]")]
        [HttpGet]
        public object We2()
        {
            return Json("we2");
        }

    }
}
