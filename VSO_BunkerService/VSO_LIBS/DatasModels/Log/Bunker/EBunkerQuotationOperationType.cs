using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VSO_LIBS.DatasModels.Log.Bunker
{
    public enum EBunkerQuotationOperationType
    {
        [Display(Name = "报价")]
        QUOTE = 312201,
        [Display(Name = "修改")]
        MODIFY = 312202,
        [Display(Name = "锁定")]
        LOCKDOWN = 312203,
        [Display(Name = "取消")]
        CANCEL = 312204,
        [Display(Name = "过期")]
        EXPIRY = 312205,
        [Display(Name = "订单流失")]
        RUNOFF = 312206,
        [Display(Name = "转换为订单")]
        TRANSTOORDER = 312207
    }
}
