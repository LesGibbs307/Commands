using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Commands.Models;
using Commands.Repositories;
using Commands.Repositories.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Commands.Controllers
{
    //api/commands
    [ApiController]
    [Route("api/[controller]")]
    public class CommandsController : ControllerBase
    {
        private readonly ICommandRepo _commandRepo;
        public CommandsController(ICommandRepo repository)
        {
            _commandRepo = repository;
        }

        [HttpGet]
        public ActionResult <IEnumerable<Command>> GetAllCommands()
        { 
            var items = _commandRepo.GetAllCommands();
            return Ok(items);
        }

        [HttpGet("{id}")]
        public ActionResult GetAllCommandById(int id)
        {
            return Ok(_commandRepo.GetCommandById(id));
        }
    }
}
