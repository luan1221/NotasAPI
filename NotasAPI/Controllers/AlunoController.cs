using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NotasAPI.Interfaces;
using NotasAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NotasAPI.Controllers
{
    [Route("api/alunos")]
    [ApiController]
    public class AlunoController : ControllerBase
    {
        private readonly IServiceAluno _serviceAluno;

        public AlunoController(IServiceAluno serviceAluno)
        {
            _serviceAluno = serviceAluno;
        }

        [HttpPost]
        public IActionResult Create([FromBody] AlunoModel alunoModel)
        {
            var aluno = _serviceAluno.Insert(alunoModel);
            return Created("", alunoModel);
        }
    }
}
