using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VSO_LIBS.DatasModels.Log.Bunker
{
    public class BunkerOrderLog
    {
        [Required, Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BunkerOrderInfoLogID { get; set; }
        #region 外键
        public Guid BunkerOrderInfoID { get; set; }
        [ForeignKey("BunkerOrderInfoID")]
        public Business.Bunker.BunkerOrder BunkerOrder { get; set; }
        #endregion
        public Guid UserInfoID { get; set; }
        [Display(Name = "日志时间")]
        public DateTime LogTime { get; set; }
        [Display(Name = "操作类型")]
        public EBunkerOrderOperationType OperationType { get; set; }
    }
}
