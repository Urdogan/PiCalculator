using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PiCalculator.Controllers
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class CalculateController : ControllerBase
    {
        //https://localhost:5001/calculate/pi?iterationCount=569
        [HttpPost]
        public double Pi(long iterationCount)//Daha büyük iterasyonlar için "long"
        {
            double pi = 0;
            try
            {
                if (iterationCount < 0)
                {
                    return -1;
                }

                for (long i = 0; i < iterationCount; i++)
                {
                    pi = pi + 8.0 / ((4 * i + 1) * (4 * i + 3)); //Pinin bölenini karşya 2'nin çarpanı olarak hesaplattım
                }
                return pi;
            }
            catch (Exception)
            {
                return -1;
            }
            
        }
    }
}
