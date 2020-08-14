using MusicShop.Interfaces;
using MusicShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicShop.Data.Repository
{
    public class BandRepository : IAllGroups
    {
        private readonly AppDBContent appDbContent;

        public BandRepository(AppDBContent _appdbcont)
        {
            this.appDbContent = _appdbcont;
        }

        public IEnumerable<MetalGroup> getAllGroups => appDbContent.MetalGroup;

        public MetalGroup getOneGroup(int id_band)
        {
            throw new NotImplementedException();
        }
    }
}
