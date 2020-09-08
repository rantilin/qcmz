using System;
using System.ComponentModel.DataAnnotations;
using WalkingTec.Mvvm.Core;

namespace qcmz.Model
{
    
    public class T_File : TopBasePoco
    {
        /// <summary>
        /// 外键ID
        /// </summary> 
        [Display(Name = "外键ID")]
        public Guid ForeignKeyId { get; set; }
        /// <summary>
        /// 文件路径
        /// </summary> 
        [Display(Name = "文件路径")]
        public string FilePath { get; set; }
        /// <summary>
        /// 文件名称
        /// </summary> 
        [Display(Name = "文件名称")]
        public string FileName { get; set; }
        /// <summary>
        /// 文件类型：【1：图片】【2：文件】
        /// </summary> 
        [Display(Name = "文件类型")]
        public int FileClassify { get; set; }
        /// <summary>
        /// 外键类型：【1：产品】【2：品种】【3：企业资质】
        /// </summary> 
        [Display(Name = "外键类型")]
        public int ForeignKeyClassify { get; set; }
        /// <summary>
        /// 是否封面图
        /// </summary> 
        [Display(Name = "是否封面图")]
        public bool Iscover { get; set; }
        /// <summary>
        /// 是否轮播
        /// </summary> 
        [Display(Name = "是否轮播")]
        public bool IsFocus { get; set; }
    }
}
