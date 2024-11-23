using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lagoon.Infrastructure
{
    //Db Context es una clase que se encuentra en entity framework core y sirve para permitirnos conectar a la base de datos
    //y poderla modificar
    internal class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>options):base(options)
        {
            
        }
    }
}
