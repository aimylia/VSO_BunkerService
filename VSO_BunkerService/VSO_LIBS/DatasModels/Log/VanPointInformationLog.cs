using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VSO_LIBS.DatasModels.Log
{
    public class VanPointInformationLog
    {
        [Required, Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int VanPointInfoLogID { get; set; }
        public Guid UserInfoID { get; set; }
        [ForeignKey("UserInfoID")]
        public User.UserDetail UserInfo { get; set; }
        [Display(Name = "是否流入")]
        public bool IsImport { get; set; }
        [Display(Name = "日志时间")]
        public DateTime LogTime { get; set; }
        [Display(Name = "积分数量")]
        public int PointNum { get; set; }
        [Display(Name = "积分类型")]
        public ModelType.EVanPointType PointType { get; set; }
        [Display(Name = "当前余额")]
        public int NowAmount { get; set; }
        [Display(Name = "操作类型")]
        public ModelType.LogType.EVanPointOperationType OperationType { get; set; }
        [Display(Name = "是否刷新积分有效期")]
        public bool IsRefreshValidation { get; set; }
        [Display(Name = "备注"), StringLength(512)]
        public string LogMemo { get; set; }
    }
}
