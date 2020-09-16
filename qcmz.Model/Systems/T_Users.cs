using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using WalkingTec.Mvvm.Core;

namespace qcmz.Model
{
    /// <summary>
    /// 用户表
    /// </summary>
    public class T_Users : TopBasePoco
    {
        /// <summary>
        /// 用户名称
        /// </summary>
        [Display(Name = "用户名称")]
        public string Name { get; set; }
        /// <summary>
        /// 用户邮箱
        /// </summary>
        [Display(Name = "用户邮箱")]
        public string Email { get; set; }
        /// <summary>
        /// 用户密码
        /// </summary>
        [Display(Name = "用户密码")]
        public string PassWord { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        [Display(Name = "创建时间")]
        public DateTime CreatedAt { get; set; }
        /// <summary>
        /// 更新时间
        /// </summary>
        [Display(Name = "更新时间")]
        public DateTime UpdatedAt { get; set; }
        /// <summary>
        /// 微信用户唯一标示码
        /// </summary>
        [Display(Name = "微信用户唯一标示码")]
        public string openid { get; set; }
        /// <summary>
        /// 性别
        /// </summary>
        [Display(Name = "性别")]
        public int Sex { get; set; }
        /// <summary>
        /// 省份
        /// </summary>
        [Display(Name = "省份")]
        public string Province { get; set; }
        /// <summary>
        /// 城市
        /// </summary>
        [Display(Name = "城市")]
        public string City { get; set; }
        /// <summary>
        /// 国家
        /// </summary>
        [Display(Name = "国家")]
        public string Country { get; set; }
        /// <summary>
        /// 用户头像
        /// </summary>
        [Display(Name = "用户头像")]
        public string Headimgurl { get; set; }
        /// <summary>
        /// 是否关注公众号
        /// 0是未关注1是已关注
        /// </summary>
        [Display(Name = "是否关注公众号")]
        public int Subscribe { get; set; }
        /// <summary>
        /// 会员等级id 用户等级id
        /// </summary>
        [Display(Name = "会员等级id")]
        public int level_id { get; set; }
        /// <summary>
        /// 累计充值金额 用户累计充值金额作为提升vip等级的
        /// </summary>
        [Display(Name = "累计充值金额")]
        public decimal deposit { get; set; }
        /// <summary>
        /// 用户手机号
        /// </summary>
        [Display(Name = "用户手机号")]
        public string phone { get; set; }
        /// <summary>
        /// 是否解封 是否冻结默认0正常1冻结
        /// </summary>
        [Display(Name = "是否解封")]
        public int is_frz { get; set; }
    }
}
