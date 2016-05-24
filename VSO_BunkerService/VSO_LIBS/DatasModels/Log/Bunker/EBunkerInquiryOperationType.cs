using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VSO_LIBS.DatasModels.Log.Bunker
{
    public enum EBunkerInquiryOperationType
    {
        [Display(Name = "创建")]
        CREATE = 311201,
        [Display(Name = "开盘")]
        OPEN = 311202,
        [Display(Name = "取消")]
        CANCEL = 311203,
        [Display(Name = "流标")]
        FAIL = 311204,
        [Display(Name = "过期")]
        INVALID = 311205,
        [Display(Name = "转换为订单")]
        TRANSTOORDER = 311206
    }
}
