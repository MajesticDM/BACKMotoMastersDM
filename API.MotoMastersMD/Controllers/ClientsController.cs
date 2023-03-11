using AutoMapper;
using CORE.MotoMastersMD.DTOs;
using CORE.MotoMastersMD.Entities;
using CORE.MotoMastersMD.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API.MotoMastersMD.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ClientsController : ControllerBase
    {
        private readonly IClients _context;
        private readonly IMapper _mapper;
        public ClientsController(IClients context, IMapper mapper)
        {
                _context= context; 
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var Clients = await _context.GetClients();
            var Client = _mapper.Map<IEnumerable<ClientsDTO>>(Clients);
            return Ok(Client);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int Id)
        {
            var UWU = await _context.GetxId(Id);
            if (UWU == null)
            {
                return Ok(UWU);
            }
            else
            {
                var OWO = _mapper.Map<ClientsDTO>(UWU);
                return Ok(OWO);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Save(ClientsDTO dTOs)
        {
            var UWU = _mapper.Map<Clients>(dTOs);
            await _context.Post(UWU);
            return Ok(UWU);
        }

        [HttpPut]
        public async Task<IActionResult> Actualizar(int Id, ClientsDTO OWO)
        {
            var UWU = _mapper.Map<Clients>(OWO);
            UWU.ClientId = Id;
            await _context.Update(UWU);
            return Ok(UWU);
        }

        [HttpDelete]
        public async Task<IActionResult> Eliminar(int Id)
        {
            var UWU = await _context.Delete(Id);
            return Ok(UWU);
        }
    }
}
