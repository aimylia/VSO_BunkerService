using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VSO_LIBS.DatasModels.Business
{
    public abstract class InquiryInformation
    {
        #region 主键
        [Required, Key, ScaffoldColumn(false)]
        public Guid InquiryInfoID { get; set; }
        #endregion
        #region 服务代码
        [Required, StringLength(15)]
        [Display(Name = "订单服务代码")]
        public string ServiceCode { get; set; }
        #endregion
        #region 询价单有效期
        [Required, Range(0, 3)]
        [Display(Name = "询价单有效期")]
        public int InquiryValidation { get; set; }
        #endregion
        #region 询价单过期日期
        [Required, ScaffoldColumn(false)]
        [Display(Name = "询价单过期日期")]
        public DateTime InquiryExpiryDate { get; set; }
        #endregion
        #region 询价经纬度
        [Required, Range(-90, 90)]
        [Display(Name = "询价纬度")]
        public double Inquiry_B { get; set; }
        [Required, Range(-180, 180)]
        [Display(Name = "询价纬度")]
        public double Inquiry_L { get; set; }
        #endregion
        #region 所在渔场
        [Required]
        [Display(Name = "所在渔场")]
        public ModelType.EFishingGroudType LocateFishingGround { get; set; }
        #endregion
        #region 预计服务日期
        [Required]
        [Display(Name = "预计服务日期")]
        public DateTime InquiryServiceDate { get; set; }
        #endregion
        #region 是否允许变更
        [Required]
        [Display(Name = "是否允许变更地点")]
        public bool IsRelocatable { get; set; }
        [Required]
        [Display(Name = "是否允许变更日期")]
        public bool IsRedate { get; set; }
        #endregion
        #region 是否支付美元
        [Display(Name = "支付货币")]
        public bool IsDollar { get; set; }
        #endregion
        #region 创建及更新时间
        [Required, ScaffoldColumn(false)]
        [Display(Name = "创建时间")]
        public DateTime CreateTime { get; set; }
        [Required,  ScaffoldColumn(false)]
        [Display(Name = "更新时间")]
        public DateTime UpdateTime { get; set; }
        #endregion
        #region 外键
        public Guid UserInfoID { get; set; }
        [ForeignKey("UserInfoID")]
        public User.UserDetail UserInfo { get; set; }
        #endregion
    }
}
