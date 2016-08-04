using ST_MVC_Day1Homework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ST_MVC_Day1Homework.Controllers
{
    public class HomeworkController : Controller
    {
        // GET: Homework
        public ActionResult Homework()
        {
            HomeworkViewModel m = new HomeworkViewModel
            {
                TypeList= new List<SelectListItem>() {
                    new SelectListItem() { Value = "請選擇", Text = "請選擇" },
                    new SelectListItem() { Value = "支出", Text = "支出" },
                    new SelectListItem() { Value = "收入", Text = "收入" }
                },
                GridData = new List<HomeworkInputDataModel> {
                    new HomeworkInputDataModel { SerNum=1,Type="支出",Date="2016-01-01",Price=300},
                    new HomeworkInputDataModel { SerNum=2,Type="支出",Date="2016-01-02",Price=1600},
                    new HomeworkInputDataModel { SerNum=3,Type="支出",Date="2016-01-03",Price=800}
                }
            };
            return View(m);
        }



        [HttpPost]
        public ActionResult Homework(HomeworkViewModel m)
        {
            m.GridData.Add(new HomeworkInputDataModel{ Type=m.Type,Date=m.Date,Price=m.Price,SerNum=m.GridData.Count+1 });
            //這邊要提問，如果有很多的Select不就要一直重新綁值???
            m.TypeList = new List<SelectListItem>() {
                new SelectListItem() { Value = "請選擇", Text = "請選擇" },
                    new SelectListItem() { Value = "支出", Text = "支出" },
                    new SelectListItem() { Value = "收入", Text = "收入" }
            };
            ModelState.Clear();
            return View(m);
        }
    }
}