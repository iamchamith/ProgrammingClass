using Microsoft.AspNetCore.Mvc;

namespace SecondDay.Controllers
{
    public class HomeController : Controller
    {
        [Route("sum")]
        public IActionResult Sum(int firstValue, int secondValue)
        {
            int finalResult = firstValue + secondValue;
            string result;
            if (finalResult < 50)
            {
                result = "failed";
            }
            else
            {

                result = "pass";
            }
            return Ok(result);
        }

        [Route("sub")]
        public IActionResult Sub(int firstValue, int secondValue)
        {

            int finalResult = firstValue - secondValue;
            return Ok(finalResult);
        }


        [Route("identity")]
        public IActionResult Identity(string name, int age, bool isMale)
        {
            string ageAlias = "";
            if (age < 13)
            {
                ageAlias = "Kid";
            }
            else if (age < 20)
            {

                ageAlias = "teen age";
            }
            else if (age < 30)
            {

                ageAlias = "mature";
            }
            else if (age < 40)
            {

                ageAlias = "middle age";
            }
            else if (age < 60)
            {
                ageAlias = "Old";
            }
            else {

                ageAlias = "too old";
            }

            string gender = "";
            if (isMale == true)
            {
                gender = "Male";
            }
            else
            {
                gender = "Female";
            }
            string result = $"your name is {name}. your are {ageAlias} {gender}";

            /*
              your name is Supun.
              you are teen age male 

             */

            return Ok(result);
        }




    }
}
