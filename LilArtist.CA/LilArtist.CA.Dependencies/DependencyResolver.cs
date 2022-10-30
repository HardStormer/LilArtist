using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LilArtist.CA.BLL.Interfaces;
using LilArtist.CA.DAL.Interfaces;
using LilArtist.CA.DAL.SQL;
using LilArtist.CA.BLL.Standart;

namespace LilArtist.CA.Dependencies
{
    public class DependencyResolver
    {
        #region SINGLETONE

        private static DependencyResolver _instance = null;

        public static DependencyResolver Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new DependencyResolver();

                return _instance;
            }
        }

        #endregion

        public ILotRepository lotRepository => new LotRepository();

        public ILotService lotService => new LotService(lotRepository);
    }
}
