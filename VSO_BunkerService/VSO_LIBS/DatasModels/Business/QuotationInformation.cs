using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VSO_LIBS.DatasModels.Business
{
    public abstract class QuotationInformation
    {
        #region 主键
        [Required, Key]
        [Display(Name = "报价ID")]
        public Guid QuotationInfoID { get; set; }
        #endregion
        #region 服务代码
        [Required, StringLength(15)]
        [Display(Name = "订单服务代码")]
        public string ServiceCode { get; set; }
        #endregion
        #region 报价过期日期（报价有效期至）
        [Display(Name = "报价过期日期")]
        public DateTime QuotationExpiryDate { get; set; }
        #endregion
        #region 报价服务日期
        [Display(Name = "报价服务日期")]
        public DateTime QuotationServiceDate { get; set; }
        #endregion
        #region 报价经纬度
        [Display(Name = "报价纬度")]
        public double Quotation_B { get; set; }
        [Display(Name = "报价经度")]
        public double Quotation_L { get; set; }
        #endregion
        #region 是否后付费
        [Display(Name = "是否后付费")]
        public bool IsPostpay { get; set; }
        #endregion
        #region 创建及更新时间
        [Display(Name = "创建时间")]
        public DateTime CreateTime { get; set; }
        [Display(Name = "更新时间")]
        public DateTime UpdateTime { get; set; }
        #endregion
        #region 付款通知书
        [StringLength(128)]
        [Display(Name = "付款通知书")]
        public string PaymentNoticeDoc { get; set; }
        #endregion
        #region 外键
        public Guid UserInfoID { get; set; }
        [ForeignKey("UserInfoID")]
        public User.UserDetail UserInfo { get; set; }
        #endregion
    }
}
