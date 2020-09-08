using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using WalkingTec.Mvvm.Core;

namespace qcmz.Model
{
    /// <summary>
    /// 	用户表
    /// </summary>
    public class T_Contacts : TopBasePoco
    {
        /// <summary>
        /// 游客姓名
        /// </summary>
        [Display(Name = "游客姓名")]
        public string Name { get; set; }

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



    }
}
