using ST_MVC_Day1Homework.Models;
using ST_MVC_Day1Homework.Models.dbModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ST_MVC_Day1Homework.Controllers
{
    public class HomeworkController : Controller
    {
        private AccountBookDAO dao = new AccountBookDAO();
        // GET: Homework
        public ActionResult Homework()
        {
            var AccountBook = dao.GetAccountBookAllData();

            HomeworkViewModel m = new HomeworkViewModel
            {
                Date = DateTime.Now.ToString("yyyy-MM-dd"),
                TypeList= new List<SelectListItem>() {
                    new SelectListItem() { Value = "請選擇", Text = "請選擇" },
                    new SelectListItem() { Value = "支出", Text = "支出" },
                    new SelectListItem() { Value = "收入", Text = "收入" }
                },
                GridData = AccountBook
            };
            return View(m);
        }



        [HttpPost]
        public ActionResult Homework(HomeworkViewModel m)
        {
            //這邊要提問，如果有很多的Select不就要一直重新綁值???
            m.TypeList = new List<SelectListItem>() {
                new SelectListItem() { Value = "請選擇", Text = "請選擇" },
                    new SelectListItem() { Value = "支出", Text = "支出" },
                    new SelectListItem() { Value = "收入", Text = "收入" }
            };
            if (ModelState.IsValid)
            {
                m.GridData.Add(
                    new HomeworkInputDataModel {
                        Type = m.Type,
                        Date = m.Date,
                        Price = m.Price,
                        SerNum = m.GridData.Count + 1
                    });
            }



            return View(m);
        }
    }
}