using Senai.Wishlist.API.Domains;
using Senai.Wishlist.API.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Wishlist.API.Repositories
{
    public class DesejoRepository : IDesejoRepository
    {
        public void Cadastar(Desejos desejo)
        {
            throw new NotImplementedException();
        }

        public List<Desejos> Listar(int id)
        {
            using (WishListContext ctx = new WishListContext())
            {

                Usuarios usuario;
                usuario = ctx.Usuarios.FirstOrDefault(x => x.Id == id);

                return ctx.Desejos.Where(x => x.IdUsuarios == usuario.Id).ToList();
            }
        }
    }
}
