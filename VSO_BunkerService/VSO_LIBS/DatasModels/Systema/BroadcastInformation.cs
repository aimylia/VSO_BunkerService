using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VSO_LIBS.DatasModels.Systema
{
    public class BroadcastInformation
    {
        [Required, Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BroadcastID { get; set; }
        [Display(Name = "目标用户")]
        public Guid ToUserID { get; set; }
        [Display(Name = "广播时间")]
        public DateTime CastTime { get; set; }
        [Display(Name = "广播内容")]
        [StringLength(128)]
        public string CastContent { get; set; }
        [Display(Name = "是否有效")]
        public bool IsValid { get; set; }
        [StringLength(512)]
        public string Memo { get; set; }
    }
}
