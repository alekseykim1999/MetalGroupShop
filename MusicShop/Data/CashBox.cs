using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MusicShop.Interfaces;
using MusicShop.Models;

namespace Supermarket.Item
{

   
    class CashBox : ICalculable
    {

        private static CashBox instance;
        private CashBox()
        {

        }
        public static CashBox getInstance()
        {
            if (instance == null)
                instance = new CashBox();
            return instance;
        }
        public int calculate(List<Album> items_in_basket)
        {
            int sum = 0;
            return sum;
        }

       
    }
}
