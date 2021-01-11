using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NotasAPI.Entities
{
    public class Aluno
    {
        public Aluno(string name, string email, string cpf)
        {
            Name = name;
            Email = email;
            Cpf = cpf;
        }

        public string Name { get; set; }
        public string Email { get; set; }
        public string Cpf { get; set; }
    }
}
