using NotasAPI.Entities;
using NotasAPI.Interfaces;
using NotasAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NotasAPI.Services
{
    public class AlunoService : IServiceAluno
    {
        public IList<Aluno> alunos;

        public AlunoModel Insert(AlunoModel alunoModel)
        {
            var aluno = new Aluno(alunoModel.Nome, alunoModel.Email, alunoModel.Cpf);
            alunos.Add(aluno);
            return alunoModel;
        }

        

    }
}
