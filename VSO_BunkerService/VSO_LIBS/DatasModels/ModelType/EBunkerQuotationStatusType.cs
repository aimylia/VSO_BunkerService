using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VSO_LIBS.DatasModels.ModelType
{
    public enum EBunkerQuotationStatusType
    {
        [Display(Name = "未开盘")]
        NONCOMPLETED = 312101,
        [Display(Name = "已开盘")]
        ISCOMPLETED = 312102,
        [Display(Name = "失效")]
        INVALID = 312103,
        [Display(Name = "转换为订单")]
        TRANSINTOORDER = 312104
    }
}
