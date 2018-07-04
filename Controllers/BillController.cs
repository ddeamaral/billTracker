using System;
using marriednowwhat.Models;
using Microsoft.AspNetCore.Mvc;

namespace marriednowwhat.Controllers
{
    [Route ("api/[controller]")]
    public class BillController : Controller
    {

        [HttpGet]
        public IActionResult BillHistory ()
        {
            return Ok ();
        }

        [HttpGet]
        public Bill GetBills (DateTime date)
        {

            return new Bill ();
        }
    }
}