using Banking_Platform.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Banking_Platform.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        Banking_DBEntities db = new Banking_DBEntities();
        public ActionResult Dashboard()
        {
            return View();
        }
        public ActionResult Deposit()
        {
            Transaction tr=new Transaction();
            return PartialView("_Deposit",tr);
        }
        [HttpPost]
        public ActionResult Deposit(Transaction tr)
        {
            return PartialView("_Deposit");
        }
        public ActionResult Withdraw()
        {
            Transaction tr = new Transaction();
            return PartialView("_Withdraw", tr);
        }
        [HttpPost]
        public ActionResult Withdraw(Transaction tr)
        {
            return PartialView("_Withdraw", tr);
        }
        public ActionResult Transfer()
        {
            Transaction tr = new Transaction();
            return PartialView("_Transfer", tr);
        }
        [HttpPost]
        public ActionResult Transfer(Transaction tr)
        {
            return PartialView("_Transfer", tr);
        }
        public ActionResult New_Account()
        {
            Transaction tr = new Transaction();
            return PartialView("_NewAccount", tr);
        }
        [HttpPost]
        public ActionResult New_Account(Transaction tr)
        {
            return PartialView("_NewAccount", tr);
        }
        public ActionResult Modify()
        {
            Transaction tr = new Transaction();
            return PartialView("_Modify_Account", tr);
        }
        [HttpPost]
        public ActionResult Modify(Transaction tr)
        {
            return PartialView("_Modify_Account", tr);
        }
        public ActionResult Balance_Inquary()
        {
            Transaction tr = new Transaction();
            return PartialView("_Balance_Inquary", tr);
        }
        [HttpPost]
        public ActionResult Balance_Inquary(Transaction tr)
        {
            return PartialView("_Balance_Inquary", tr);
        }

    }
}