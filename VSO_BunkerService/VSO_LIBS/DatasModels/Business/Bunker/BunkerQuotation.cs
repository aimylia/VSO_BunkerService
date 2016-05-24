using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VSO_LIBS.DatasModels.Business.Bunker
{
    public class BunkerQuotation : QuotationInformation
    {
        #region 燃油价格
        [Display(Name = "燃油价格")]
        public decimal QuotationFuelPrice { get; set; }
        #endregion
        #region 询价加油量
        [Display(Name = "询价加油量")]
        public int InquiryFuelQuantity { get; set; }
        #endregion
        #region 油料类型
        [Display(Name = "油料类型")]
        public ModelType.EFuelType InquiryFuelType { get; set; }
        #endregion
        #region 调和油比重
        [Display(Name = "调和油比重")]
        public decimal BlendedFuelScale { get; set; }
        #endregion
        #region 报价状态及所在阶段
        [Display(Name = "报价状态")]
        public ModelType.EBunkerQuotationStatusType QuotationStatus { get; set; }
        [Display(Name = "所在阶段")]
        public ModelType.EBunkerStageType BunkerCurrentStage { get; set; }
        #endregion
        #region 外键
        public Guid FuelServiceVesselID { get; set; }
        public Guid InquiryInfoID { get; set; }
        #endregion
    }
}
