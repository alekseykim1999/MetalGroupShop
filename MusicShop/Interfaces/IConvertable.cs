using MusicShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicShop.Interfaces
{
    interface IConvertable
    {
        StringBuilder ConvertSound(string _path);

    }
}
