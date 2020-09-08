using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using WalkingTec.Mvvm.Core;

namespace qcmz.Model
{
    
    public class T_Article : TopBasePoco
    {
        /// <summary>
        /// 标题
        /// </summary> 
        [Display(Name = "标题")]
        public string Title { get; set; }
        /// <summary>
        /// 文章类型【1：公告】【2：新闻】【3：通知】
        /// </summary> 
        [Display(Name = "文章类型")]
        public int ArticleClassify { get; set; }
        /// <summary>
        /// 内容
        /// </summary> 
        [Display(Name = "内容")]
        public string Content { get; set; }
        /// <summary>
        /// 发布对象
        /// </summary> 
        [Display(Name = "发布对象")]
        public int PublicObject { get; set; }
        /// <summary>
        /// 状态
        /// </summary> 
        [Display(Name = "状态")]
        public int Status { get; set; }
    }
}
