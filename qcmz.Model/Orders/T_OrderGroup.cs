using System;
using System.ComponentModel.DataAnnotations;
using WalkingTec.Mvvm.Core;

namespace qcmz.Model
{
    public class T_OrderGroup : TopBasePoco
    {
        /// <summary>
        /// 订单名称
        /// </summary> 
        [Display(Name = "订单名称")]
        public string OrderGroupName { get; set; }
        /// <summary>
        /// 订单分组编号
        /// </summary> 
        [Display(Name = "订单分组编号")]
        public string GroupOrderNo { get; set; }
        /// <summary>
        /// 订单编号
        /// </summary> 
        [Display(Name = "订单编号")]
        public string OrderNoStr { get; set; }
        /// <summary>
        /// 支付流水号
        /// </summary> 
        [Display(Name = "支付流水号")]
        public string PayTransactionNo { get; set; }
        /// <summary>
        /// 支付方式
        /// </summary> 
        [Display(Name = "支付方式")]
        public int PayClassify { get; set; }
        /// <summary>
        /// 总金额
        /// </summary> 
        [Display(Name = "总金额")]
        public decimal TotalAmount { get; set; }
    }
}
