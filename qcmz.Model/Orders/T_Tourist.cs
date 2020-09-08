using System;
using System.ComponentModel.DataAnnotations;
using WalkingTec.Mvvm.Core;

namespace qcmz.Model
{
    /// <summary>
    /// T_Tourist    	游客表
    /// </summary>
   
    public class T_Tourist : TopBasePoco
    { 
        /// <summary>
        /// 订单ID
        /// </summary>
        [Display(Name = "订单ID")]
        public Guid OrderId { get; set; } 
        /// <summary>
        /// 订单明细ID
        /// </summary>
        [Display(Name = "订单明细ID")]
        public Guid OrderDetailId { get; set; } 
        /// <summary>
        /// 游客姓名
        /// </summary>
        [Display(Name = "游客姓名")]
        public string Name { get; set; }
        /// <summary>
        /// 性别
        /// </summary>
        [Display(Name = "性别")]
        public string Sex { get; set; }
        /// <summary>
        /// 手机号
        /// </summary>
        [Display(Name = "手机号")]
        public string Phone { get; set; }
        /// <summary>
        /// 证件类型
        /// </summary>
        [Display(Name = "证件类型")]
        public int CredentialsType { get; set; }
        /// <summary>
        /// 证件号
        /// </summary>
        [Display(Name = "证件号")]
        public string Credentials { get; set; }
        /// <summary>
        /// 是否为取票人
        /// </summary>
        [Display(Name = "是否为取票人")]
        public bool IsTicket { get; set; }
    }
}
