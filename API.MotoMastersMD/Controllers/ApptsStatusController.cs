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
    public class ApptsStatusController : ControllerBase
    {
        private readonly IApptsStatus _context;
        private readonly IMapper _mapper;
        public ApptsStatusController(IApptsStatus context, IMapper mapper)
        {
                _context= context; 
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var MMDS = await _context.GetApptsStatus();
            var MMD = _mapper.Map<IEnumerable<AppointmentsStatus>>(MMDS);
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
                var OWO = _mapper.Map<AppointmentsStatusDTO>(UWU);
                return Ok(OWO);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Save(AppointmentsStatusDTO dTOs)
        {
            var UWU = _mapper.Map<AppointmentsStatus>(dTOs);
            await _context.Post(UWU);
            return Ok(UWU);
        }

        [HttpPut]
        public async Task<IActionResult> Actualizar(int Id, AppointmentsStatusDTO OWO)
        {
            var UWU = _mapper.Map<AppointmentsStatus>(OWO);
            UWU.StatusId = Id;
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
