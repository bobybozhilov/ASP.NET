using Microsoft.AspNetCore.Mvc;

namespace OdeToFood.Controllers
{

    [Route("about")]    //parameter
    [Route("company/[controller]/[action]")] //token
    public class AboutController
    {

        //[Route("phone")]
        public string Phone()
        {
            return "+359 888 123 456";
        }

       //[Route("adress")]
        public string Adress()
        {
            return "Bulgaria";
        }
    }
}
