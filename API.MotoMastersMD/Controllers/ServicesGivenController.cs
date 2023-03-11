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
    public class ServicesGivenController : ControllerBase
    {
        private readonly IServicesGiven _context;
        private readonly IMapper _mapper;
        public ServicesGivenController(IServicesGiven context, IMapper mapper)
        {
                _context= context; 
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var MMDS = await _context.GetServicesGiven();
            var MMD = _mapper.Map<IEnumerable<ServicesGivenDTO>>(MMDS);
            return Ok(MMD);
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
                var OWO = _mapper.Map<ServicesGivenDTO>(UWU);
                return Ok(OWO);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Save(ServicesGivenDTO dTOs)
        {
            var UWU = _mapper.Map<ServicesGiven>(dTOs);
            await _context.Post(UWU);
            return Ok(UWU);
        }

        [HttpPut]
        public async Task<IActionResult> Actualizar(int Id, ServicesGivenDTO OWO)
        {
            var UWU = _mapper.Map<ServicesGiven>(OWO);
            UWU.ServiceGivenId = Id;
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
