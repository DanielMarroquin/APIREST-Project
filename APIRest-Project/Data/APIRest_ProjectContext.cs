using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using APIRest_Project.Models;

namespace APIRest_Project.Data
{
    public class APIRest_ProjectContext : DbContext
    {
        public APIRest_ProjectContext (DbContextOptions<APIRest_ProjectContext> options)
            : base(options)
        {
        }

        public DbSet<APIRest_Project.Models.Persona> Persona { get; set; }
    }
}
