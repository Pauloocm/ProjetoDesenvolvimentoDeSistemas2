using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Projeto_DS2.Models;

namespace PROJETODS22.repositorio
{
    public interface IUsuarioRepositorio
    {
        UsuarioModel adicionar(UsuarioModel usuario);
    }
}