using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVC_Agile_Process_McMovie.Models;

namespace MVC_Agile_Process_McMovie.Data
{
    public class MVC_Agile_Process_McMovieContext : DbContext
    {
        public MVC_Agile_Process_McMovieContext (DbContextOptions<MVC_Agile_Process_McMovieContext> options)
            : base(options)
        {
        }

        public DbSet<MVC_Agile_Process_McMovie.Models.Movie> Movie { get; set; } = default!;
    }
}
