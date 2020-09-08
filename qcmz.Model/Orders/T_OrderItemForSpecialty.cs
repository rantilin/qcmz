using System;
using System.ComponentModel.DataAnnotations;
using WalkingTec.Mvvm.Core;

namespace qcmz.Model
{
 
    public class T_OrderItemForSpecialty : TopBasePoco
    {
        /// <summary>
        /// 订单ID
        /// </summary> 
        [Display(Name = "订单ID")]
        public string OrderId { get; set; }
        /// <summary>
        /// 订单编号
        /// </summary> 
        [Display(Name = "订单编号")]
        public string OrderNo { get; set; }
        /// <summary>
        /// 产品名称
        /// </summary> 
        [Display(Name = "产品名称")]
        public string ProductName { get; set; }
        /// <summary>
        /// 产品ID
        /// </summary> 
        [Display(Name = "产品ID")]
        public string ProductID { get; set; }
        /// <summary>
        /// 单价
        /// </summary> 
        [Display(Name = "单价")]
        public string Price { get; set; }
        /// <summary>
        /// 数量
        /// </summary> 
        [Display(Name = "数量")]
        public string Quantity { get; set; }
        /// <summary>
        /// 小计
        /// </summary> 
        [Display(Name = "小计")]
        public string SubTotalAmount { get; set; }
        /// <summary>
        /// 定金比例
        /// </summary> 
        [Display(Name = "定金比例")]
        public string DepositRatio { get; set; }
        /// <summary>
        /// 定金
        /// </summary> 
        [Display(Name = "定金")]
        public string DepositPrice { get; set; }
        /// <summary>
        /// 运费
        /// </summary> 
        [Display(Name = "运费")]
        public string ExpressFee { get; set; }
        /// <summary>
        /// 品种
        /// </summary> 
        [Display(Name = "品种")]
        public string Varieties { get; set; }
        /// <summary>
        /// 规格
        /// </summary> 
        [Display(Name = "规格")]
        public string SpecsStr { get; set; }
        /// <summary>
        /// 单位
        /// </summary> 
        [Display(Name = "单位")]
        public string SalesUnit { get; set; }
        /// <summary>
        /// 销售模式
        /// </summary> 
        [Display(Name = "销售模式")]
        public string SalesModel { get; set; }
        /// <summary>
        /// 产品编号
        /// </summary> 
        [Display(Name = "产品编号")]
        public string ProductNo { get; set; }
        /// <summary>
        /// 产品分类名称
        /// </summary> 
        [Display(Name = "产品分类名称")]
        public string CategoryName { get; set; }
    }
}
