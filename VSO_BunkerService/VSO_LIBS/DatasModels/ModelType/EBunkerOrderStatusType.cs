using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VSO_LIBS.DatasModels.ModelType
{
    public enum EBunkerOrderStatusType
    {
        [Display(Name = "未付款")]
        NONPAID = 313101,
        [Display(Name = "等待供油商确认收款")]
        WAITINGFORRECEIVEMENT = 313102,
        [Display(Name = "付款信息有误")]
        PAYERROR = 313103,
        [Display(Name = "供油商终止此订单")]
        CANCELBYSUPPLIER = 313104,
        [Display(Name = "待确认结算")]
        FORCONFIRMSETTLE = 313105,
        [Display(Name = "结算提交")]
        SUBMITSETTLE = 313106,
        [Display(Name = "确认结算")]
        SETTLECONFIRM = 313107,
        [Display(Name = "供油商确认完成")]
        CONFIRMACCOMPLISH = 313107,
        [Display(Name = "系统关闭该订单")]
        CLOSEDBYSYS = 313108
    }
}
