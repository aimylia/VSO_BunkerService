using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VSO_LIBS.DatasModels.Business.Bunker
{
    public class BunkerRelation
    {
        [Required, Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RelationID { get; set; }
        [Display(Name = "订单服务代码")]
        [StringLength(15)]
        public string ServiceCode { get; set; }
        [Display(Name = "询价单ID")]
        public Guid InquiryInfoID { get; set; }
        [Display(Name = "报价单ID")]
        public Guid QuotationInfoID { get; set; }
        [Display(Name = "订单ID")]
        public Guid OrderInfoID { get; set; }
        [Display(Name = "船舶信息ID")]
        public Guid VesselInfoID { get; set; }
    }
}
