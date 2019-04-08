using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Senai.Wishlist.API.Domains;
using Senai.Wishlist.API.Interfaces;
using Senai.Wishlist.API.Repositories;
using Senai.Wishlist.API.ViewModels;

namespace Senai.Wishlist.API.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private IUsuarioRepository UsuarioRepository { get; set; }

        public LoginController()
        {
            UsuarioRepository = new UsuarioRepository();
        }

        [HttpPost]
        public IActionResult Post (LoginViewModel login)
        {
            try
            {
                Usuarios usuario = UsuarioRepository.BuscarPorEmailESenha(login.Email, login.Senha);

                if(usuario == null)
                {
                    return NotFound();
                }

                var claims = new[]
                {
                    new Claim(JwtRegisteredClaimNames.Email, usuario.Email),
                    new Claim(JwtRegisteredClaimNames.Jti, usuario.Id.ToString()),
                    new Claim(ClaimTypes.Role),
                };
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }
    }
}