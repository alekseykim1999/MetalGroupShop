using MusicShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicShop.Interfaces
{
    public interface IAllGroups
    {
        IEnumerable<MetalGroup> getAllGroups { get; }
        MetalGroup getOneGroup(int id_band);

    }
}
