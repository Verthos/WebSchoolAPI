using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class Professor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Sobrenome { get; set; }
        public int Idade { get; set; }
        public string RG { get; set; }
        public DateTime DataInicio { get; set; }
        public int MateriaId { get; set; }

        public Professor(string nome, string sobrenome, int idade, string rg)
        {
            this.Name = nome;
            this.Sobrenome = sobrenome;
            this.Idade = idade;
            this.RG = rg;
            this.DataInicio = DateTime.Now;
        }
    }

}
