using System;
using System.ComponentModel.DataAnnotations;
using WalkingTec.Mvvm.Core;

namespace qcmz.Model
{
   
    public class T_ShoppingCartItem : TopBasePoco
    {
        /// <summary>
        /// 购物车ID
        /// </summary> 
        [Display(Name = "购物车ID")]
        public Guid CartId { get; set; }
       
        /// <summary>
        /// 产品ID
        /// </summary> 
        [Display(Name = "产品ID")]
        public Guid ProductId { get; set; }
        /// <summary>
        /// 产品名称
        /// </summary> 
        [Display(Name = "产品名称")]
        public string ProductName { get; set; }
        /// <summary>
        /// 产品规格
        /// </summary> 
        [Display(Name = "产品规格")]
        public string SpecsStr { get; set; }
        /// <summary>
        /// 产品图片
        /// </summary> 
        [Display(Name = "产品图片")]
        public string ProductImg { get; set; }
        /// <summary>
        /// 单价
        /// </summary> 
        [Display(Name = "单价")]
        public decimal Amount { get; set; }
        /// <summary>
        /// 数量
        /// </summary> 
        [Display(Name = "数量")]
        public int Quantity { get; set; }
        /// <summary>
        /// 小计
        /// </summary> 
        [Display(Name = "小计")]
        public decimal SubAmount { get; set; }
        /// <summary>
        /// 运费
        /// </summary> 
        [Display(Name = "运费")]
        public decimal CostsAmount { get; set; }
    }
}
