using System;
using System.ComponentModel.DataAnnotations;
using WalkingTec.Mvvm.Core;

namespace qcmz.Model
{
    
    public class T_RefundableRecord : TopBasePoco
    {
        /// <summary>
        /// 订单编号
        /// </summary> 
        [Display(Name = "订单编号")]
        public string OrderNo { get; set; }
        /// <summary>
        /// 理由
        /// </summary> 
        [Display(Name = "理由")]
        public string Reason { get; set; }
        /// <summary>
        /// 详细理由
        /// </summary> 
        [Display(Name = "详细理由")]
        public string ReasonDetail { get; set; }
        /// <summary>
        /// 商品数量
        /// </summary> 
        [Display(Name = "商品数量")]
        public int ProductQuantity { get; set; }
        /// <summary>
        /// 操作类型
        /// </summary> 
        [Display(Name = "操作类型")]
        public int OptionClassify { get; set; }
        /// <summary>
        /// 状态
        /// </summary> 
        [Display(Name = "状态")]
        public int Status { get; set; }
    }
}
