using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Projeto_DS2.Models;

namespace PROJETO_DS22.Models
{
    public class AtividadeDS2Context : DbContext
    {
        public DbSet<FuncionarioModel> funcionarios {get; set;}
        public DbSet<UsuarioModel> usuarios {get; set;}
    }
}