using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace VSO_LIBS.DatasModels.ModelType
{
    public enum EBunkerInquiryStatusType
    {
        [Display(Name = "未开盘")]
        NONCOMPLETED = 311101,
        [Display(Name = "已开盘")]
        ISCOMPLETED = 311102,
        [Display(Name = "失效")]
        INVALID = 311103,
        [Display(Name = "转换为订单")]
        TRANSINTOORDER = 311104
    }
}
