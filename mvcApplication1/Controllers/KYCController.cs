using Microsoft.AspNetCore.Mvc;
using mvcApplication1.Data;
using mvcApplication1.Models;

namespace mvcApplication1.Controllers
{
    public class KYCController : Controller
    {
        Mvc _context;

        public KYCController(Mvc context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var kyc = new KYC();

            List<KYC> KYClist = _context.KYC.ToList();
            return View(KYClist);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(KYC kyc) 
        {
            if(ModelState.IsValid)
            {
                _context.KYC.Add(kyc);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
           
            return View();
        }
        
    }
}
