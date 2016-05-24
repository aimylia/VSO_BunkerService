using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VSO_LIBS.DatasModels.Log.Bunker
{
    public class BunkerInquiryLog
    {
        [Required, Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BunkerInquiryInfoLogID { get; set; }
        #region 外键
        public Guid BunkerInquiryInfoID { get; set; }
        [ForeignKey("BunkerInquiryInfoID")]
        public Business.Bunker.BunkerInquiry BunkerInquiry { get; set; }
        #endregion
        public Guid UserInfoID { get; set; }
        [Display(Name = "日志时间")]
        public DateTime LogTime { get; set; }
        [Display(Name = "操作类型")]
        public EBunkerInquiryOperationType OperationType { get; set; }
        [Display(Name = "日志备注")]
        public string LogMemo { get; set; }
    }
}
