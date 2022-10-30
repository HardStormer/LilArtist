using AutoMapper;
using LotBLL = LilArtist.CA.BLL.Entities.Lot;
using LotPL = LilArtist.CA.PL.WebApiLinux.Models.Lot;

namespace LilArtist.CA.PL.WebApiLinux.Mappers
{
    public class LotMapper : IMapper<LotBLL, LotPL>
    {
        public LotBLL Map(LotPL model)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<LotPL, LotBLL>()
            .ForMember(x => x.Id, x => x.MapFrom(y => y.Id))
            .ForMember(x => x.Name, x => x.MapFrom(y => y.Name))
            );
            var mapper = config.CreateMapper();
            var newModel = mapper.Map<LotPL, LotBLL>(model);
            return newModel;
        }

        public LotPL Map(LotBLL model)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<LotBLL, LotPL>()
            .ForMember(x => x.Id, x => x.MapFrom(y => y.Id))
            .ForMember(x => x.Name, x => x.MapFrom(y => y.Name))
            );
            var mapper = config.CreateMapper();
            var newModel = mapper.Map<LotBLL, LotPL>(model);
            return newModel;
        }

        public IEnumerable<LotBLL> Map(IEnumerable<LotPL> model)
        {
            if (model != null)
            {
                List<LotBLL> models = new List<LotBLL>();
                foreach (var lot in model)
                {
                    var config = new MapperConfiguration(cfg => cfg.CreateMap<LotPL, LotBLL>()
                .ForMember(x => x.Id, x => x.MapFrom(y => y.Id))
                .ForMember(x => x.Name, x => x.MapFrom(y => y.Name))
                );
                    var mapper = config.CreateMapper();
                    var newModel = mapper.Map<LotPL, LotBLL>(lot);
                    models.Add(newModel);
                }

                return models;
            }
            else return null;
        }

        public IEnumerable<LotPL> Map(IEnumerable<LotBLL> model)
        {
            if (model != null)
            {
                List<LotPL> models = new List<LotPL>();
                foreach (var lot in model)
                {
                    var config = new MapperConfiguration(cfg => cfg.CreateMap<LotBLL, LotPL>()
                .ForMember(x => x.Id, x => x.MapFrom(y => y.Id))
                .ForMember(x => x.Name, x => x.MapFrom(y => y.Name))
                );
                    var mapper = config.CreateMapper();
                    var newModel = mapper.Map<LotBLL, LotPL>(lot);
                    models.Add(newModel);
                }

                return models;
            }
            else return null;
        }
    }
}
