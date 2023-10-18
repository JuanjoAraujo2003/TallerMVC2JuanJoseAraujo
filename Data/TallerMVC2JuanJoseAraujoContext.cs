using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TallerMVC2JuanJoseAraujo.Models;

namespace TallerMVC2JuanJoseAraujo.Data
{
    public class TallerMVC2JuanJoseAraujoContext : DbContext
    {
        public TallerMVC2JuanJoseAraujoContext (DbContextOptions<TallerMVC2JuanJoseAraujoContext> options)
            : base(options)
        {
        }

        public DbSet<TallerMVC2JuanJoseAraujo.Models.Burger> Burger { get; set; } = default!;

        public DbSet<TallerMVC2JuanJoseAraujo.Models.Promo>? Promo { get; set; }
    }
}
