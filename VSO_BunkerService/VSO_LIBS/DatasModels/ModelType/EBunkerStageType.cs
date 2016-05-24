using System.ComponentModel.DataAnnotations;

namespace VSO_LIBS.DatasModels.ModelType
{
    public enum EBunkerStageType
    {
        [Display(Name = "用户询价")]
        INQUERY = 310201,
        [Display(Name = "供应商报价")]
        OFFER = 310202,
        [Display(Name = "用户选择报价")]
        SELECTION = 310203,
        [Display(Name = "供应商开始服务")]
        CONFIRMSTART = 310204,
        [Display(Name = "用户付款")]
        PAYMENT = 310205,
        [Display(Name = "供应商收款")]
        RECEIVE = 310206,
        [Display(Name = "供应商服务")]
        SUPPLY = 310207,
        [Display(Name = "用户补缴补收")]
        REPAYMENT = 310208,
        [Display(Name = "供应商确认收款")]
        RECEIVEREPAY = 310209,
        [Display(Name = "完成")]
        COMPLETE = 310210
    }
}
