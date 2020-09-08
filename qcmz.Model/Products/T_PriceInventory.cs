using System;
using System.ComponentModel.DataAnnotations;
using WalkingTec.Mvvm.Core;

namespace qcmz.Model
{
   
    public class T_PriceInventory : TopBasePoco
    {
        /// <summary>
        /// 价格名称
        /// </summary> 
        [Display(Name = "价格名称")]
        public string PriceName { get; set; }
        /// <summary>
        /// 外键ID
        /// </summary> 
        [Display(Name = "外键ID")]
        public Guid ForeignKeyId { get; set; }
        /// <summary>
        /// 外键类型【1：产品】【2：班期日历】
        /// </summary> 
        [Display(Name = "外键类型")]
        public int ForeignKeyClassify { get; set; }
        /// <summary>
        /// 价格类型【1：结算价】【2：分销价】【3：市场价】
        /// </summary> 
        [Display(Name = "价格类型")]
        public int PriceClassify { get; set; }
        /// <summary>
        /// 库存
        /// </summary> 
        [Display(Name = "库存")]
        public int Inventory { get; set; }
        /// <summary>
        /// 已售库存
        /// </summary> 
        [Display(Name = "已售库存")]
        public int SoldInventory { get; set; }
        /// <summary>
        /// 价格
        /// </summary> 
        [Display(Name = "价格")]
        public decimal Price { get; set; } 
    }
}
