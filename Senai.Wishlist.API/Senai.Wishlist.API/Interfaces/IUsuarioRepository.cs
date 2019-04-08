using Senai.Wishlist.API.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Wishlist.API.Interfaces
{
    interface IUsuarioRepository
    {
        void Cadastrar(Usuarios usuario);

        List<Usuarios> Listar();

        Usuarios BuscarPorEmailESenha(string email, string senha);
    }
}
