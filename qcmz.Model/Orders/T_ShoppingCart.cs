using System;
using System.ComponentModel.DataAnnotations;
using WalkingTec.Mvvm.Core;

namespace qcmz.Model
{
    
    public class T_ShoppingCart : TopBasePoco
    {
        /// <summary>
        /// 购物车名称
        /// </summary> 
        [Display(Name = "订单名称")]
        public string CartName { get; set; }
        /// <summary>
        /// 总金额
        /// </summary> 
        [Display(Name = "订单名称")]
        public decimal TotalAmount { get; set; }
        /// <summary>
        /// 总数量
        /// </summary> 
        [Display(Name = "订单名称")]
        public int TotalQuantity { get; set; }
        /// <summary>
        /// 总运费
        /// </summary> 
        [Display(Name = "订单名称")]
        public decimal TotalCostsAmount { get; set; }
    }
}
