using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Projeto_DS2.Models;
using PROJETO_DS22.Models;

namespace PROJETODS22.repositorio
{
    public class UsuarioRepositorio : IUsuarioRepositorio
    {
        private readonly AtividadeDS2Context bancoContext;
    
        public UsuarioRepositorio(AtividadeDS2Context bancoContext)
        {

        }
        public UsuarioModel adicionar(UsuarioModel usuario)
        {
            // gravar no banco de dados
            
            bancoContext.usuarios.Add(usuario);
            bancoContext.SaveChanges();

            return usuario;
        }
    }
}