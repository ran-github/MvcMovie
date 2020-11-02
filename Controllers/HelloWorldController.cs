using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Welcome(string name, int numTimes)
        {
            ViewData["Message"] = string.Format("Hello, {0}", name);
            ViewData["NumTimes"] = numTimes;
            return View();
        }
    }
}

//using Microsoft.AspNetCore.Mvc;
//using System.Text.Encodings.Web;

//namespace MvcMovie.Controllers
//{
//    public class HelloWorldController : Controller
//    {
//        // 
//        // GET: /HelloWorld/

//        public string Index()
//        {
//            return "This is my default action...";
//        }

//        // 
//        // GET: /HelloWorld/Welcome/ 

//        public string Welcome(string name, int numTimes = 1)
//        {
//            //return "This is the Welcome action method...";
//            return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
//        }

//        public string Abcde(int num)
//        {
//            //return "abcde";
//            return HtmlEncoder.Default.Encode($"Abcde - {num}");
//        }
//    }
//}
