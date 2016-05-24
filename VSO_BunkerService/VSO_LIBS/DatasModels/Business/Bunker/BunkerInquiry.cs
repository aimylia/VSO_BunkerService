using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace VSO_LIBS.DatasModels.Business.Bunker
{
    public class BunkerInquiry : InquiryInformation
    {
        [Display(Name = "询价加油量")]
        public int InquiryFuelQuantity { get; set; }
        [Display(Name = "油料类型")]
        public ModelType.EFuelType InquiryFuelType { get; set; }
        [Display(Name = "调和油比重")]
        public decimal BlendedFuelScale { get; set; }
        [Required, Display(Name = "询价单状态"), ScaffoldColumn(false)]
        public ModelType.EBunkerInquiryStatusType BunkerInquirtyStatus { get; set; }
        [Display(Name = "订单所在阶段"),ScaffoldColumn(false)]
        public ModelType.EBunkerStageType BunkerCurrentStage { get; set; }
        #region 外键
        #endregion
    }
}
