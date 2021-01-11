using NotasAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NotasAPI.Interfaces
{
    public interface IServiceAluno
    {
        AlunoModel Insert(AlunoModel alunoModel);

    }
}
