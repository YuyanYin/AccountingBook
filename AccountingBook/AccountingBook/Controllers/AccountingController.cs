using AccountingBook.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AccountingBook.Controllers
{
    public class AccountingController : Controller
    {
        // GET: Accounting
        public ActionResult Accounting()
        {
            return View();
        }

        public ActionResult Detail()
        {
            var AccList = new List<AccountingViewModel>();
            AccList.Add(new AccountingViewModel { Seq = 1, Date = new DateTime(2016, 1, 1), Type = "支出", Amount = 300, Note = "" });
            AccList.Add(new AccountingViewModel { Seq = 1, Date = new DateTime(2016, 1, 2), Type = "支出", Amount = 1600, Note = "" });
            AccList.Add(new AccountingViewModel { Seq = 1, Date = new DateTime(2016, 1, 3), Type = "支出", Amount = 800, Note = "" });
            return View(AccList);
        }
    }
}