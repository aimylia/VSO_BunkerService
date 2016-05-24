using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VSO_LIBS.DatasModels.ModelType.LogType
{
    public enum EVanPointOperationType
    {
        [Display(Name = "扣除押金")]
        GETDEPOSIT = 400201,
        [Display(Name = "返还押金")]
        RETURNDEPOSIT = 400202,
        [Display(Name = "支付积分")]
        BONUSOFCOMPLETE = 400203,
        [Display(Name = "奖励积分")]//用户从平台得到积分
        GETBONUS = 400204,
        [Display(Name = "获取积分")]//服务商获得用户支付的积分
        EXCHANGEBONUS = 400205,
        [Display(Name = "系统赠送")]
        SYSGRANT = 400206,
        [Display(Name = "系统没收")]
        SYSCONFISCATE = 400207
    }
}
