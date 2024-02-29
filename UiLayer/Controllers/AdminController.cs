using DALLBlog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UiLayer.Controllers
{
    public class AdminController : Controller
    {
        readonly IEmpInfo EmpOperations = new EmpInfoRepository();

        public ActionResult EmployeeList()
        {
            IEnumerable<EmpInfo> emplist = EmpOperations.GetAllEmpInfo();
            return View(emplist);
        }


        // GET: Admin/Create
        public ActionResult SaveEmployee()
        {
            return View();
        }

        // POST: Admin/Create
        [HttpPost]
        public ActionResult SaveEmployee(FormCollection collection)
        {
            EmpInfo emp = new EmpInfo
            {
                EmailId = collection["EmailId"],
                Name = collection["Name"],
                DateOfJoining = DateTime.Parse(collection["DateOfJoining"]),
                PassCode = Convert.ToInt32(collection["PassCode"])
            };

            EmpOperations.Insert(emp);
            EmpOperations.Save();
            return RedirectToAction("EmployeeList");
        }
        public ActionResult Edit(string mail)
        {
            EmpInfo emp = EmpOperations.GetEmpInfo(mail);
            return View(emp);
        }
        [HttpPost]
        public ActionResult Edit(string mail, FormCollection collection)
        {
            EmpInfo emp = new EmpInfo()
            {
                EmailId = collection["EmailId"],
                Name = collection["Name"],
                DateOfJoining = DateTime.Parse(collection["DateOfJoining"]),
                PassCode = Convert.ToInt32(collection["PassCode"])
            };
            EmpOperations.Update(emp);
            EmpOperations.Save();
            return RedirectToAction("EmployeeList");
        }




        // GET: Admin/Delete/5
        public ActionResult Delete(string mail)
        {
            EmpInfo emp = EmpOperations.GetEmpInfo(mail);
            return View(emp);
        }

        // POST: Admin/Delete/5
        [HttpPost]
        public ActionResult Delete(string mail, FormCollection collection)
        {
            EmpOperations.Delete(mail);
            EmpOperations.Save();
            return RedirectToAction("EmployeeList");
        }
    }
}