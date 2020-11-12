using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExchangeThings.Web.Models
{
    public class AddNewItemResponse
    {
        public bool success { get; set; }

        public ItemModel addedItem { get; set; }
    }
}
