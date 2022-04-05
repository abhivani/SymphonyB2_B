using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using SymphonyProject.DB;
using SymphonyProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SymphonyProject.Controllers
{
    public class DashboardController : Controller
    {

        private IConfiguration configuration;

        private readonly AccountDBContext _dbAccountContext;

        public DashboardController(IConfiguration iConfig, AccountDBContext dbAccountContext)
        {
            configuration = iConfig;
            _dbAccountContext = dbAccountContext;
        }

        public IActionResult Index()
        {
            //var count = _dbAccountContext.getTotalUser();
            //ViewBag.counts = count;
            return View();
        }

        public IActionResult GenerateOrder()
        {
            return View();
        }

        public IActionResult MyOrder()
        {
            return View();
        }

        public IActionResult OpenSales()
        {
            return View();
        }

        public IActionResult OpenCreditLimit()
        {
            return View();
        }

        public IActionResult OverdueOutstanding()
        {
            return View();
        }
        public IActionResult CustomerLedger()
        {
            return View();
        }
        public IActionResult OrderDelivered()
        {
            return View();
        }
        public IActionResult ProductSummary()
        {
            return View();
        }

    }
}
