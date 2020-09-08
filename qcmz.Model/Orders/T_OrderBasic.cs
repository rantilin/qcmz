using System;
using System.ComponentModel.DataAnnotations;
using WalkingTec.Mvvm.Core;

namespace qcmz.Model
{
   
    public class T_OrderBasic : TopBasePoco
    {
        /// <summary>
        /// 订单名称
        /// </summary> 
        [Display(Name = "订单名称")]
        public string OrderName { get; set; }
        /// <summary>
        /// 订单号
        /// </summary> 
        [Display(Name = "订单号")]
        public string OrderNo { get; set; }
        /// <summary>
        /// 订单分类【1：门票】【2：农产品】
        /// </summary> 
        [Display(Name = "订单分类")]
        public int Classify { get; set; }
        /// <summary>
        /// 订单总金额
        /// </summary> 
        [Display(Name = "订单总金额")]
        public decimal TotalAmount { get; set; }
        /// <summary>
        /// 优惠金额
        /// </summary> 
        [Display(Name = "优惠金额")]
        public decimal PreferentialAmount { get; set; }
        /// <summary>
        /// 实际支付金额
        /// </summary> 
        [Display(Name = "实际支付金额")]
        public decimal TotalPayAmount { get; set; }
        /// <summary>
        /// 修改后总金额
        /// </summary> 
        [Display(Name = "修改后总金额")]
        public decimal UpdateTotalAmount { get; set; }
        /// <summary>
        /// 总运费
        /// </summary> 
        [Display(Name = "总运费")]
        public decimal TotalCostsAmount { get; set; }
        /// <summary>
        /// 总数量
        /// </summary> 
        [Display(Name = "总数量")]
        public int TotalQuantity { get; set; }
        /// <summary>
        /// 退款金额
        /// </summary> 
        [Display(Name = "退款金额")]
        public decimal RefundAmount { get; set; }
        /// <summary>
        /// 处理理由
        /// </summary> 
        [Display(Name = "处理理由")]
        public string OptionReason { get; set; }
        /// <summary>
        /// 订单状态【1：待支付】【2：待发货】【3：待收货】【4：已付定金】【5：代付尾款】【6：退款中】【7：已退款】【8：已完成】【9：已取消】
        /// </summary> 
        [Display(Name = "订单状态")]
        public int OrderStatus { get; set; }
        /// <summary>
        /// 取消状态【1：未取消】【2：取消待审核】【3：已取消】【4：取消失败】
        /// </summary> 
        [Display(Name = "取消状态")]
        public int CancelStatus { get; set; }
        /// <summary>
        /// 支付状态【1：待支付】【2：已支付】
        /// </summary> 
        [Display(Name = "支付状态")]
        public int PayStatus { get; set; }
        /// <summary>
        /// 配送方式【1：快递配送】【2：上门自取】
        /// </summary> 
        [Display(Name = "配送方式")]
        public int Deliveries { get; set; }
        /// <summary>
        /// 支付方式【1：微信支付】【2：支付宝支付】
        /// </summary> 
        [Display(Name = "支付方式")]
        public int PayClassify { get; set; }
        /// <summary>
        /// 支付时间
        /// </summary> 
        [Display(Name = "支付时间")]
        public DateTime PayTime { get; set; }
        /// <summary>
        /// 支付流水号
        /// </summary> 
        [Display(Name = "支付流水号")]
        public string PayTransactionNo { get; set; }
        /// <summary>
        /// 取消流水号
        /// </summary> 
        [Display(Name = "取消流水号")]
        public string CancelTransactionNo { get; set; }
        /// <summary>
        /// 快递公司
        /// </summary> 
        [Display(Name = "快递公司")]
        public string ExpressCompany { get; set; }
        /// <summary>
        /// 运单号
        /// </summary> 
        [Display(Name = "运单号")]
        public string WaybillNumber { get; set; }
        /// <summary>
        /// 收货人
        /// </summary> 
        [Display(Name = "收货人")]
        public string Consignee { get; set; }
        /// <summary>
        /// 收货地址
        /// </summary> 
        [Display(Name = "收货地址")]
        public string ConsigneeAddress { get; set; }
        /// <summary>
        /// 收货人手机号
        /// </summary> 
        [Display(Name = "收货人手机号")]
        public string ConsigneePhone { get; set; }
        /// <summary>
        /// 申请取消时间
        /// </summary> 
        [Display(Name = "申请取消时间")]
        public DateTime ApplyCancelTime { get; set; }
        /// <summary>
        /// 取消处理时间
        /// </summary> 
        [Display(Name = "取消处理时间")]
        public DateTime OptionCancelTime { get; set; }
        /// <summary>
        /// 发货时间
        /// </summary> 
        [Display(Name = "发货时间")]
        public DateTime SendProductTime { get; set; }
    }
}
