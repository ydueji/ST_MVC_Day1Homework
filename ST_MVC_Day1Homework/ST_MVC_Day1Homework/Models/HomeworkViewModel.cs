using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace ST_MVC_Day1Homework.Models
{
    /// <summary>
    /// 表單的ViewModel
    /// </summary>
    public class HomeworkViewModel
    {
        [Display(Name = "種類")]
        public string Type { get; set; }

        [Display(Name = "種類")]
        public List<SelectListItem> TypeList { get; set; }

        [Display(Name = "金額")]
        public double Price { get; set; }
        [Display(Name = "日期")]
        public string Date { get; set; }
        [Display(Name = "Grid")]
        public List<HomeworkInputDataModel> GridData { get; set; }
    }

    /// <summary>
    /// Grid類別
    /// </summary>
    public class HomeworkInputDataModel {
        /// <summary>
        /// 種類
        /// </summary>
        public string Type { get; set; }
        /// <summary>
        /// 金額
        /// </summary>
        public double Price { get; set; }
        /// <summary>
        /// 日期
        /// </summary>
        public string Date { get; set; }
        /// <summary>
        /// 流水號
        /// </summary>
        public int SerNum { get; set; }
    }
}