using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class Materia
    {
        public int Id{ get; set; }
        public string Nome{ get; set; }

        public Materia(string nome)
        {
            this.Nome = nome;
        }

    }
}
