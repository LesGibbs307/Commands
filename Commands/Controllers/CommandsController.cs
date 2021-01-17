using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Commands.DTOs;
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
        private readonly IMapper _mapper;
        private readonly ICommandRepo _commandRepo;
        public CommandsController(ICommandRepo repository, IMapper mapper)
        {
            _mapper = mapper;
            _commandRepo = repository;
        }

        [HttpGet]
        public ActionResult <IEnumerable<CommandReadDTO>> GetAllCommands()
        { 
            var items = _commandRepo.GetAllCommands();
            return Ok(_mapper.Map<IEnumerable<CommandReadDTO>>(items));
        }

        [HttpGet("{id}")]
        public ActionResult<CommandReadDTO> GetAllCommandById(int id)
        {
            var commandItem = _commandRepo.GetCommandById(id);
            if (commandItem == null)
            {
                return NotFound();
            }
            return Ok(_mapper.Map<CommandReadDTO>(commandItem));
        }
    }
}
