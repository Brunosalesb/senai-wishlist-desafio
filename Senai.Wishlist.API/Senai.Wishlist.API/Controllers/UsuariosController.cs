using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Senai.Wishlist.API.Domains;
using Senai.Wishlist.API.Interfaces;
using Senai.Wishlist.API.Repositories;

namespace Senai.Wishlist.API.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        private IUsuarioRepository UsuarioRepository { get; set; }

        public UsuariosController()
        {
            UsuarioRepository = new UsuarioRepository();
        }

        [HttpGet]
        public IActionResult ListarUsuarios()
        {
            try
            {
                using (WishListContext ctx = new WishListContext())
                {
                    return Ok(ctx.Usuarios.ToList());
                }
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }

        [HttpPost]
        public IActionResult Cadastrar(Usuarios usuario)
        {
            try
            {
                using (WishListContext ctx = new WishListContext())
                {
                    ctx.Usuarios.Add(usuario);
                    ctx.SaveChanges();
                }

                return Ok();
            }
            catch(Exception ex)
            {
                return BadRequest();
            }
        }


    }
}