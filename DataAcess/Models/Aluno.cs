using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class Aluno
    {
        public int Aluno_Id { get; set; }
        public string? Nome { get; set; }
        public string? Sobrenome { get; set; }
        public int Idade { get; set; }
        public string? RG { get; set; }
        public DateTime Data_Matricula { get; set; }
        public int? Materia_Id{ get; set; }
        public int? Sala_Id{ get; set; }

        public Aluno()
        {
        }

        public Aluno(string nome, string sobrenome, int idade, string rg)
        {
            this.Nome = nome;
            this.Sobrenome = sobrenome;
            this.Idade = idade;
            this.RG = rg;
        }
       
    }
}
