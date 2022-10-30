using Lot = LilArtist.CA.BLL.Entities.Lot;
using LilArtist.CA.BLL.Interfaces;
using LilArtist.CA.DAL.Interfaces;

namespace LilArtist.CA.BLL.Standart
{
    public class LotService : ILotService
    {
        private ILotRepository _lotRepository;
        public LotService(ILotRepository lotRepository)
        {
            _lotRepository = lotRepository;
        }

        public Lot Add(Lot lot)
        {
            return _lotRepository.Add(lot);
        }

        public void Edit(Lot lot)
        {
            _lotRepository.Edit(lot);
        }

        public Lot? Get(int id)
        {
            return _lotRepository.Get(id);
        }

        public IEnumerable<Lot>? GetAll()
        {
            return _lotRepository.GetAll();
        }

        public void Remove(int id)
        {
            _lotRepository.Remove(id);
        }
    }
}
