using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VSO_LIBS.DatasModels.Business.Bunker
{
    public class BunkerOrder : OrderInformation
    {
        #region 报价ID
        [Required, ScaffoldColumn(false)]
        [Display(Name = "报价ID")]
        public Guid QuotationInfoID { get; set; }
        #endregion
        #region 买方ID
        [Required, ScaffoldColumn(false)]
        [Display(Name = "买方ID")]
        public Guid OrderBuyerID { get; set; }
        #endregion
        #region 卖方ID
        [Required, ScaffoldColumn(false)]
        [Display(Name = "卖方ID")]
        public Guid OrderSellerID { get; set; }
        #endregion
        #region 订单油价
        [Required]
        [Display(Name = "订单油价")]
        public decimal OrderFuelPrice { get; set; }
        #endregion
        #region 预计加油量
        [Required]
        [Display(Name = "预计加油量")]
        public int InquiryFuelQuantity { get; set; }
        #endregion
        #region 预计加油类型
        [Required]
        [Display(Name = "预计加油类型")]
        public ModelType.EFuelType InquiryFuelType { get; set; }
        [Display(Name = "调和油比重")]
        [Range(0,1,ErrorMessage = "请输入0~1之间的小数，小数位数限制为2位！")]
        public decimal BlendedFuelScale { get; set; }
        #endregion
        #region 实际加油量
        [Required]
        [Display(Name = "实际加油量")]
        public decimal ActualFuelQuantity { get; set; }
        #endregion
        #region 浮动油量
        [Required]
        [Display(Name = "浮动油量")]
        public decimal FloatFuelQuantity { get; set; }
        #endregion
        #region 浮动金额
        [Required]
        [Display(Name = "浮动金额")]
        public decimal FloatAmount { get; set; }
        #endregion
        #region 完成日期
        [Required]
        [Display(Name = "完成日期")]
        public DateTime CompleteDate { get; set; }
        #endregion
        #region 付款凭证
        [Required]
        [Display(Name = "付款凭证")]
        [StringLength(128)]
        public string BillOfPaymentDoc { get; set; }
        #endregion
        #region BDN文档
        [Required]
        [Display(Name = "BDN文档")]
        [StringLength(128)]
        public string BDNDoc { get; set; }
        #endregion
        #region 补缴凭证
        [Display(Name = "补缴凭证")]
        public string BillOfRepaymentDoc { get; set; }
        #endregion
        #region 订单状态和当前阶段
        [ScaffoldColumn(false)]
        [Display(Name = "")]
        public ModelType.EBunkerOrderStatusType OrderStatus { get; set; }
        [ScaffoldColumn(false)]
        public ModelType.EBunkerStageType BunkerCurrentStage { get; set; }
        #endregion
    }
}
