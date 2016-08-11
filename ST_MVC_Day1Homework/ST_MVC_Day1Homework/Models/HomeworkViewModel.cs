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
        [Required]
        public string Price { get; set; }

        [Display(Name = "日期")]
        [StringLength(10,MinimumLength =10, ErrorMessage ="格式不對")]
        public string Date { get; set; }

        [Display(Name = "備註")]
        public string Remark { get; set; }
        
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
        public string Price { get; set; }
        /// <summary>
        /// 日期
        /// </summary>
        public string Date { get; set; }
        /// <summary>
        /// 流水號
        /// </summary>
        public int SerNum { get; set; }

        /// <summary>
        /// 上次沒做到的備註
        /// </summary>
        public string Remark { get; set; }

        /// <summary>
        /// 上次沒做到的ID
        /// </summary>
        public string ID { get; set; }
    }
}