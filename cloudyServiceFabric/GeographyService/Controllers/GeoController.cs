using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace GeographyService.Controllers
{
    class Geography
    {
        public string Name { get; set; }
        public int ID { get; set; }
    }
    [Route("app/[controller]")]
    public class GeoController : Controller
    {
        List<Geography> geograpies = new List<Geography>();
        public IActionResult Index()
        {
            geograpies.Add(new Geography() { ID = 1, Name = "Murali" });
            geograpies.Add(new Geography() { ID = 2, Name = "Madhu" });
            return new  JsonResult(geograpies);
        }
    }
}
