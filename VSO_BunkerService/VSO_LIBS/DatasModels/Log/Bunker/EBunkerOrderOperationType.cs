using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VSO_LIBS.DatasModels.Log.Bunker
{
    public enum EBunkerOrderOperationType
    {
        [Display(Name = "生成订单")]
        GENERATEORDER = 313201,
        [Display(Name = "用户付款")]
        USERPAY = 313202,
        [Display(Name = "供油商要求重新支付")]
        SUPPLIERREQUIREREPAY = 313203,
        [Display(Name = "供油商取消")]
        SUPPLIERCANCEL = 313204,
        [Display(Name = "供油商收款")]
        SUPPLIERRECEIVE = 313205,
        [Display(Name = "供油商结算")]
        SUPPLIERSETTLE = 313206,
        [Display(Name = "供油商退款")]
        SUPPLIERDEPAY = 313207,
        [Display(Name = "用户确认退款")]
        USERCONFIRMDEPAY = 313208,
        [Display(Name = "用户补缴")]
        USERREPAY = 313209,
        [Display(Name = "用户确认完成")]
        USERACCOMPLISH = 313210,
        [Display(Name = "供油商确认完成")]
        SUPPLIERACCOMPLISH = 313211,
        [Display(Name = "系统关闭该订单")]
        CLOSEDBYSYS = 313212
    }
}
