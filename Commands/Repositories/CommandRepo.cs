using Commands.Models;
using Commands.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Commands.Repositories
{
    public class CommandRepo : ICommandRepo
    {
        public CommandRepo(CommandDBContext context)
        {

        }

        public IEnumerable<Command> GetAllCommands()
        {
            throw new NotImplementedException();
        }

        public Command GetCommandById(int id)
        {
            throw new NotImplementedException();
        }

        //public IEnumerable<Command> GetAllCommands()
        //{
        //    var commands = new List<Command>
        //    {
        //        new Command { Id = 0, HowTo = "Test", Line = "Study", Platform = "School" },
        //        new Command { Id = 1, HowTo = "Quiz", Line = "Study", Platform = "School" },
        //        new Command { Id = 2, HowTo = "Final Exam", Line = "Study", Platform = "School" }
        //    };
        //    return commands;
        //}

        //public Command GetCommandById(int id)
        //{
        //    return new Command { Id = 0, HowTo = "Test", Line = "Study", Platform = "School" };
        //}
    }
}
