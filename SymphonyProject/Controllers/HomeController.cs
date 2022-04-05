using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using SymphonyProject.DB;
using SymphonyProject.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SymphonyProject.Controllers
{
    public class HomeController : Controller
    {
        private IConfiguration configuration;

        private readonly AccountDBContext _dbAccountContext;

        private readonly ILogger<HomeController> _logger;

        public HomeController(IConfiguration iConfig, ILogger<HomeController> logger, AccountDBContext dbAccountContext)
        {
            configuration = iConfig;
            _logger = logger;
            _dbAccountContext = dbAccountContext;
        }

        #region [Index]
        public IActionResult Index()
        {
            return View();
        }
        #endregion

        #region [Dealer Registration]
        public IActionResult DealerRegistration()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> DealerRegistration(DealerRegistration dealerRegistration)
        {
            bool ok = false;
            if (ModelState.IsValid)
            {
                DealerRegistration objForEnquiry = new DealerRegistration()
                {
                    DealerName = dealerRegistration.DealerName,
                    Name1 = dealerRegistration.Name1,
                    GSTNo = dealerRegistration.GSTNo,
                    PANNO = dealerRegistration.PANNO,
                    Email = dealerRegistration.Email,
                    Mobile = dealerRegistration.Mobile,
                    Address = dealerRegistration.Address,
                    State = dealerRegistration.State,
                    City = dealerRegistration.City,
                    Pin = dealerRegistration.Pin,
                    Remarks = dealerRegistration.Remarks,
                };

                int count = await _dbAccountContext.AddDealer(objForEnquiry);
                ok = true;
            }
        Next:

            if (ok)
            {
                ModelState.Clear();
                ViewBag.Error = "Data is Inserted succefully.";
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.Error = "data is not Inserted, Someting went wrong!!!";
            }
            return View();
        }

        #endregion

        #region[Enquiry Form]
        public IActionResult EnquiryForm()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> EnquiryForm(Enquiry enquiry)
        {
            bool ok = false;
            if (ModelState.IsValid)
            {
                     Enquiry objForEnquiry = new Enquiry()
                     {
                        CustomerName = enquiry.CustomerName,
                        Email = enquiry.Email,
                        Mobile = enquiry.Mobile,
                        Product = enquiry.Product,
                        Address = enquiry.Address,
                        State = enquiry.State,
                        City = enquiry.City,
                        Pincode = enquiry.Pincode,
                        Remarks = enquiry.Remarks,
                     };
               
                 int count = await _dbAccountContext.AddEnquiry(objForEnquiry);
                 ok = true;
            }
        Next:

            if (ok)
            {
                ModelState.Clear();
                ViewBag.Error = "Data is Inserted succefully.";
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.Error = "data is not Inserted, Someting went wrong!!!";
            }
            return View();
        }
        #endregion

        #region[Login]
        public IActionResult Login()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Login(User model)
        {
            //string adminUNFromSetting = configuration.GetValue<string>("AdminCredentials:AdminUserName");
            //string adminPWFromSetting = configuration.GetValue<string>("AdminCredentials:AdminPassword");

            if (ModelState.IsValid)
            {
                var adminDB = await _dbAccountContext.GetLoginDetails(model);
                if(adminDB != null)
                {
                    if(model.UserName == adminDB.UserName)
                    {
                        if(model.Password == adminDB.Password)
                        {
                            return RedirectToAction("Index", "Dashboard");
                        }
                    }
                }
            }
            ModelState.Clear();
            return View();
        }
        #endregion

        public IActionResult Logout()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
