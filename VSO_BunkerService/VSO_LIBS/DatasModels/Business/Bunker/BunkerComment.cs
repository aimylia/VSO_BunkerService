using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VSO_LIBS.DatasModels.Business.Bunker
{
    public class BunkerComment
    {
        [Required, Key]
        public Guid OrderID { get; set; }
        [ForeignKey("OrderID")]
        public BunkerOrder BunkerOrder { get; set; }
        [Display(Name = "服务态度")]
        [Required, Range(0, 5)]
        public int ServiceRank { get; set; }
        [Display(Name = "油品质量")]
        [Required, Range(0, 5)]
        public int QualityRank { get; set; }
        [Display(Name = "信誉")]
        [Required, Range(0, 5)]
        public int ReputationRank { get; set; }
        [Display(Name = "配合度")]
        [Required, Range(0, 5)]
        public int CollaborationRank { get; set; }
        [Display(Name = "付款及时度")]
        [Required, Range(0, 5)]
        public int PaymentIntimeRank { get; set; }
        [Display(Name = "争议度")]
        [Required, Range(0, 5)]
        public int DisputeRank { get; set; }
        [Display(Name = "意见箱")]
        public string PlatformAdvice { get; set; }
    }
}
