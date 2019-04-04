using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace PrintFramerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet("{Height}/{Width}")]
        public string GetQuery(string Height, string Width)
        {
        string result;
        result = CalculatePrice(Double.Parse(Height), Double.Parse(Width));
        return result;
        }

        private string CalculatePrice(double ht,double wd)
        {
        double area;
        area = ht * wd;

        if ((area > 20.00 ) &&  (area < 200.00))
        {
            return "20.00";
        }
        if ((area > 200.00) && (area < 1000.00))
        {
            return "50.00";
        }
        if ((area > 1000.00) && (area < 5000.00))
        {
            return "100.00";
        }
        return "not valid";
        }
    }
}
