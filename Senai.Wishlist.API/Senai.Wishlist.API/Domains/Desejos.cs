using System;
using System.Collections.Generic;

namespace Senai.Wishlist.API.Domains
{
    public partial class Desejos
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public DateTime Datadesejo { get; set; }
        public int IdUsuarios { get; set; }

        public Usuarios IdUsuariosNavigation { get; set; }
    }
}
