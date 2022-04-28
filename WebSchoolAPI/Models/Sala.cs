using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingClasses.Model
{
    public class Sala
    {
        public int Id { get; set; }
        public char Bloco{ get; set; }
        public string Nome { get; set; }
    
        public Sala(char bloco, string nome)
        {
            this.Bloco = bloco;
            this.Nome = nome;
        }
    }

}
