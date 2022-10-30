using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using LilArtist.CA.BLL.Interfaces;
using LilArtist.CA.PL.WebApiLinux.Mappers;
using LotPL = LilArtist.CA.PL.WebApiLinux.Models.Lot;
using LotBLL = LilArtist.CA.BLL.Entities.Lot;
using DependensyResolver = LilArtist.CA.Dependencies.DependencyResolver;

namespace LilArtist.CA.PL.WebApiLinux.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class LotController : ControllerBase
    {
        ILotService lotService = DependensyResolver.Instance.lotService;
        IMapper<LotBLL, LotPL> lotMapper = new LotMapper();

        [HttpPost]
        [Route("/[controller]/[action]/{lot:Lot}")]
        public async Task<ActionResult<LotPL>> Add(LotPL lot)
        {
            var lotResult = lotService.Add(lotMapper.Map(lot));

            return Ok(lotResult.Name);
        }

        [HttpPost]
        [Route("/[controller]/[action]/{lot:Lot}")]
        public async Task<ActionResult<LotPL>> Edit(LotPL lot)
        {
            lotService.Edit(lotMapper.Map(lot));
            return Ok(lot);
        }

        [HttpDelete]
        [Route("/[controller]/[action]/{id:int}")]
        public async Task<ActionResult<LotPL>> Delete(int id)
        {
            lotService.Remove(id);
            return Ok();
        }

        [HttpGet]
        [Route("/[controller]/[action]/{id:int}")]
        public async Task<ActionResult<LotPL>> Get(int id)
        {
            var lot = lotMapper.Map(lotService.Get(id));

            if (lot != null)
                return Ok(lot);
            else
                return NotFound();
        }

        [HttpGet]
        [Route("/[controller]/[action]")]
        public async Task<ActionResult<IEnumerable<LotPL>>> GetAll()
        {
            var lots = lotMapper.Map(lotService.GetAll());

            if (lots != null)
                return Ok(lots);
            else
                return NotFound();
        }
    }
}
