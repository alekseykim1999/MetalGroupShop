using MusicShop.Interfaces;
using MusicShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicShop.Data.Mocks
{
    public class MockGroups : IAllGroups
    {
        public IEnumerable<MetalGroup> getAllGroups
        {

            get{
                return new List<MetalGroup>
                {
                    new MetalGroup(){ id=1, GroupName = "Korn", CountryName="USA", GenreName="Nu Metal" },
                    new MetalGroup(){ id=2, GroupName = "Slipknot", CountryName="USA", GenreName="Nu Metal" }
                    
                };
            }
        }

        
    }
}
