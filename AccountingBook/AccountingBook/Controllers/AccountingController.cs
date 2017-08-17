using AccountingBook.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AccountingBook.Models;
using AccountingBook.Service;
using PagedList;

namespace AccountingBook.Controllers
{
    public class AccountingController : Controller
    {
        private readonly AccountingService _accountingSvc;

        private int pagesize = 25;

        public AccountingController()
        {
            _accountingSvc = new AccountingService();
        }
        // GET: Accounting
        public ActionResult Accounting()
        {
            return View();
        }

        public ActionResult Detail(int Page = 1)
        {
            int currentpage = Page < 1 ? 1 : Page;
            var AccList = (from p in _accountingSvc.getAccountingBook()
                       select new AccountingViewModel
                       {
                           Amount = p.Amounttt,
                           Type = p.Categoryyy == 1 ? "收入" : "支出",
                           Date = p.Dateee,
                           Note = p.Remarkkk
                       }).OrderBy(p => p.Date).ThenBy(p => p.Type);
            var result = AccList.ToPagedList(currentpage, pagesize);
            return View(result);
        }
    }
}