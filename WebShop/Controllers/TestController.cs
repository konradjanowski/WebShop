using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;
using System.Web.Mvc;

namespace WebShop.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            
            if(User.Identity.IsAuthenticated)
            {
                ClaimsIdentity identity = User.Identity as ClaimsIdentity;
                Claim user_id_claim = identity.Claims.FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier);
                
                ViewBag.TestMessage = "User " + user_id_claim.Value + " authenticated";
            }
            else
            {
                ViewBag.TestMessage = "User NOT authenticated";
            }
            
            return View("TestView");
        }
    }
}