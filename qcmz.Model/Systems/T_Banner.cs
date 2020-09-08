using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using WalkingTec.Mvvm.Core;

namespace qcmz.Model
{
    /// <summary>
    /// 广告表
    /// </summary>
    public class T_Banner : TopBasePoco
    {

        /// <summary>
        /// Url地址
        /// </summary>
        [DataMember]
        public string Url { get; set; }

        /// <summary>
        /// banner类型  【1：首页banner】【2：农产品banner】
        /// </summary>
        [DataMember]
        public int Classify { get; set; }

        /// <summary>
        /// 发布对象  【1：B2C】【2：供应商】【3：游客中心】【4：总部】
        /// </summary>
        [DataMember]
        public int PublicObject { get; set; }

        /// <summary>
        /// 上线时间
        /// </summary>
        [DataMember]
        public DateTime OnlineTime { get; set; }

        /// <summary>
        /// 下线时间
        /// </summary>
        [DataMember]
        public DateTime OfflineTime { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        [DataMember]
        public DateTime Status { get; set; }
        /// <summary>
        /// 排序
        /// </summary>
        [DataMember]
        public int Sort { get; set; }


    }
}
