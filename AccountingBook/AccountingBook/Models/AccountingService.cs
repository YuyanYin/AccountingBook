using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AccountingBook.Models;

namespace AccountingBook.Service
{
    public class AccountingService
    {
        private readonly SkillTreeHomeworkEntities _db;

        public AccountingService()
        {
            _db = new SkillTreeHomeworkEntities();
        }
        public IQueryable<AccountBook> getAccountingBook()
        {
            return _db.AccountBook;
        }
    }
}