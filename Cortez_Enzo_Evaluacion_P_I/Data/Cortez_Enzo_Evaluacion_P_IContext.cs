using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Cortez_Enzo_Evaluacion_P_I.Models;

namespace Cortez_Enzo_Evaluacion_P_I.Data
{
    public class Cortez_Enzo_Evaluacion_P_IContext : DbContext
    {
        public Cortez_Enzo_Evaluacion_P_IContext (DbContextOptions<Cortez_Enzo_Evaluacion_P_IContext> options)
            : base(options)
        {
        }

        public DbSet<Cortez_Enzo_Evaluacion_P_I.Models.Celular> Celular { get; set; } = default!;
        public DbSet<Cortez_Enzo_Evaluacion_P_I.Models.ECortez> ECortez { get; set; } = default!;
    }
}
