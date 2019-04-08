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
    public class DesejosController : ControllerBase
    {
        private IDesejoRepository DesejoRepository { get; set; }

        public DesejosController()
        {
            DesejoRepository = new DesejoRepository();
        }

        [HttpGet]
        public IActionResult ListarDesejos()
        {
            try
            {
                using (WishListContext ctx = new WishListContext())
                {
                    return Ok(ctx.Desejos.ToList());
                }
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }

        [HttpPost]
        public IActionResult Cadastar (Desejos desejo)
        {
            try
            {
                using (WishListContext ctx = new WishListContext())
                {
                    ctx.Desejos.Add(desejo);
                    ctx.SaveChanges();
                }
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }

    }
}