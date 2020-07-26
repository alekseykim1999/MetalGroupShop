﻿using MusicShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicShop.Interfaces
{
    public interface IAllAlbums
    {
        IEnumerable<Album> getAllAlbums { get; }
        Album getObjectAlbum(int id);
    }
}
