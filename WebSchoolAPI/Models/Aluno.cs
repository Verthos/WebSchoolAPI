using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingClasses.Model
{
    public class Aluno
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Sobrenome { get; set; }
        public int Idade { get; set; }
        public string? RG { get; set; }
        public DateTime DataMatricula { get; set; }
        public int? MateriaId{ get; set; }
        public int? SalaId{ get; set; }

        public Aluno()
        {
        }

        public Aluno(string nome, string sobrenome, int idade, string rg)
        {
            this.Name = nome;
            this.Sobrenome = sobrenome;
            this.Idade = idade;
            this.RG = rg;
            this.DataMatricula = DateTime.Now;           
        }
       
    }
}
