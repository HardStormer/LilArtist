using LilArtist.CA.BLL.Entities;

namespace LilArtist.CA.DAL.Interfaces
{
    public interface ILotRepository
    {
        Lot Add(Lot lot);
        void Edit(Lot lot);
        IEnumerable<Lot>? GetAll();
        Lot? Get(int id);
        void Remove(int id);
    }
}
