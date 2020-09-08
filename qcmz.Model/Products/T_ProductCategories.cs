using System;
using System.ComponentModel.DataAnnotations;
using WalkingTec.Mvvm.Core;

namespace qcmz.Model
{
    
    public class T_ProductCategories : TopBasePoco
    {
        /// <summary>
        /// 分类类型
        /// </summary> 
        [Display(Name = "分类类型")]
        public int CateClassify { get; set; }
        /// <summary>
        /// 分类名称
        /// </summary> 
        [Display(Name = "分类名称")]
        public string CateName { get; set; } 
    }
}
