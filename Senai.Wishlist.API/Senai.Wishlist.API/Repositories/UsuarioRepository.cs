using Microsoft.EntityFrameworkCore;
using Senai.Wishlist.API.Domains;
using Senai.Wishlist.API.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Wishlist.API.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        public Usuarios BuscarPorEmailESenha(string email, string senha)
        {
            using (WishListContext ctx = new WishListContext())
            {
                Usuarios usuarioBuscado = ctx.Usuarios.FirstOrDefault(x => x.Email == email && x.Senha == senha);
                if(usuarioBuscado == null)
                {
                    return null;
                }
                return usuarioBuscado;
            }
        }

        public void Cadastrar(Usuarios usuario)
        {
            throw new NotImplementedException();
        }

        public List<Usuarios> Listar()
        {
            throw new NotImplementedException();
        }
    }
}
