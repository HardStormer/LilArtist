using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LotDAL = LilArtist.CA.DAL.Entities.Lot;
using LotBLL = LilArtist.CA.BLL.Entities.Lot;
using LilArtist.CA.DAL.Interfaces;

namespace LilArtist.CA.DAL.SQL
{
    public class LotRepository : ILotRepository
    {
        public LotBLL Add(LotBLL lot)
        {
            using (var context = new CADbContext())
            {
                context.lots.Add(
                    new LotDAL
                    {
                        Name = lot.Name
                    });
                context.SaveChanges();
                return null;
            }
        }

        public void Edit(LotBLL lot)
        {
            using (var context = new CADbContext())
            {
                var oldLot = context.lots.Find(lot.Id);

                oldLot = new LotDAL
                {
                    Id = lot.Id,
                    Name = lot.Name
                };

                context.SaveChanges();
            }
        }

        public LotBLL? Get(int id)
        {
            using (var context = new CADbContext())
            {
                var lot = context.lots.Where(x => x.Id == id)
                    .Select(lot => new LotBLL
                    {
                        Id = lot.Id,
                        Name = lot.Name
                    }).FirstOrDefault();
                return lot;
            }
        }

        public IEnumerable<LotBLL>? GetAll()
        {
            using (var context = new CADbContext())
            {
                var lots = context.lots.Select(lot => new LotBLL
                {
                    Id = lot.Id,
                    Name = lot.Name
                }).ToList();
                return lots;
            }
        }

        public void Remove(int id)
        {
            using (var context = new CADbContext())
            {
                var removableLot = context.lots
                    .FirstOrDefault(x => x.Id == id);

                if (removableLot != null)
                    context.lots.Remove(removableLot);

                context.SaveChanges();
            }
        }
    }
}
