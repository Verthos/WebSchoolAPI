using DataAccess.Models;
using DataAccess.DbAccess;
using Microsoft.AspNetCore.Mvc;
using DataAccess.Repository;
using DataAccess.Repository.IRepository;

namespace WebSchoolAPI.Controllers
{ 
    [ApiController]
    [Route("/api/[controller]")]
    public class AlunosController : Controller
    {
        private readonly IAlunoRepository _db;
        public AlunosController(IAlunoRepository db)
        {
            _db = db;
        }


        [HttpGet]
        public IResult Index()
        {
            try
            {
                IEnumerable<Aluno> alunos = _db.GetAll("dbo.GET_ALUNOS").Result;
                return Results.Ok(alunos);
            }
            catch (Exception e)
            {
                return Results.Problem($"Erro: {e.Message}");
            }            
        }



        [Route("[action]/{id}")]
        [HttpGet]
        public IResult GetAlunoWithId(int id)
        {
            try
            {
                object aluno = new Aluno();
                
                aluno = _db.GetFirstOrDefault(id, "spAlunos_GetById").Result;
                return Results.Ok(aluno);
            }
            catch (Exception e)
            {

                return Results.NotFound($"Error: {e.Message}");
            }
        }

        [Route("[action]")]
        [HttpPost]
        public IResult InsertAluno(string nome, string sobrenome, int idade, string rg)
        {
            try
            {
                Aluno aluno = new Aluno(nome, sobrenome, idade, rg);
                _db.Add("spAlunos_CreateAluno", new { Sobrenome = aluno.Sobrenome, Idade = aluno.Idade, Rg = aluno.RG });
                return Results.CreatedAtRoute("Aluno criado");
            }
            catch (Exception e)
            {
                return Results.Problem($"Erro: {e.Message}");
            }



        }

    }
}
