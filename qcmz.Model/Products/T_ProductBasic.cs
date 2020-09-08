using System;
using System.ComponentModel.DataAnnotations;
using WalkingTec.Mvvm.Core;

namespace qcmz.Model
{
   
    public class T_ProductBasic : TopBasePoco
    {
        /// <summary>
        /// 产品名称
        /// </summary> 
        [Display(Name = "产品名称")]
        public string ProductName { get; set; }
        /// <summary>
        /// 产品分类ID
        /// </summary> 
        [Display(Name = "产品分类ID")]
        public Guid ProductCategoriesId { get; set; }
        /// <summary>
        /// 产品编号
        /// </summary> 
        [Display(Name = "产品编号")]
        public string ProductNumber { get; set; }
        /// <summary>
        /// 最低市场价
        /// </summary> 
        [Display(Name = "最低市场价")]
        public decimal MinMarkPrice { get; set; }
        /// <summary>
        /// 最低分销价
        /// </summary> 
        [Display(Name = "最低分销价")]
        public decimal MinDistributionPrice { get; set; }
        /// <summary>
        /// 最低结算价
        /// </summary> 
        [Display(Name = "最低结算价")]
        public decimal MinSettlementPrice { get; set; }
        /// <summary>
        /// 库存类型【1：班期日历库存】【2：总库存】
        /// </summary> 
        [Display(Name = "库存类型")]
        public int InventoryClassify { get; set; }
        /// <summary>
        /// 供应商ID
        /// </summary> 
        [Display(Name = "供应商ID")]
        public Guid SupplierId { get; set; }
        /// <summary>
        /// 状态【1：未上架】【2：上架审核】【3：已上架】【4：拒绝上架】
        /// </summary> 
        [Display(Name = "状态")]
        public string Status { get; set; }
        /// <summary>
        /// 拒绝理由
        /// </summary> 
        [Display(Name = "拒绝理由")]
        public string Reason { get; set; }
        /// <summary>
        /// 类型【1：农产品】【2：门票】
        /// </summary> 
        [Display(Name = "类型")]
        public int Classify { get; set; }
        /// <summary>
        /// 排序
        /// </summary> 
        [Display(Name = "排序")]
        public int Sort { get; set; }
        /// <summary>
        /// 下架时间
        /// </summary> 
        [Display(Name = "下架时间")]
        public DateTime OffSaleTime { get; set; } 
    }
}
