using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VSO_LIBS.DatasModels.Log.Bunker
{
    public class BunkerQuotationLog
    {
        [Required, Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BunkerOfferInfoLogID { get; set; }
        #region 外键
        public Guid BunkerOfferInfoID { get; set; }
        [ForeignKey("BunkerOfferInfoID")]
        public Business.Bunker.BunkerQuotation BunkerQuotation { get; set; }
        #endregion
        [Display(Name = "用户ID")]
        public Guid UserInfoID { get; set; }
        [Display(Name = "日志时间")]
        public DateTime LogTime { get; set; }
        [Display(Name = "报价单操作类型")]
        public EBunkerQuotationOperationType OperationType { get; set; }
        [Display(Name = "报价单操作内容")]
        public decimal OperationContent { get; set; }
        [Display(Name = "日志备注")]
        public string LogMemo { get; set; }
    }
}
