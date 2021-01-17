using Commands.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Commands.Repositories
{
    public class CommandDBContext : DbContext
    {
        public CommandDBContext(DbContextOptions<CommandDBContext> option) : base(option)
        {
                
        }
        public DbSet<Command> Commands { get; set; }
    }
}
