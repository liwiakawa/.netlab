using ExchangeThings.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExchangeThings.Web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AddingController : ControllerBase
    {
        public AddNewItemResponse Post(ItemModel item)
        {
            var response = new AddNewItemResponse()
            {
                success = true,
                addedItem = item
            };


            return response;
        }

    }
}
