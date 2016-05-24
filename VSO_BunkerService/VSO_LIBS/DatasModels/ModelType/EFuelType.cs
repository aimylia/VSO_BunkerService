using System.ComponentModel.DataAnnotations;

namespace VSO_LIBS.DatasModels.ModelType
{
    public enum EFuelType
    {
        [Display(Name = "IFO180")]
        IFO180 = 310101,
        [Display(Name = "MGO")]
        MGO = 310102,
        [Display(Name = "IFO380")]
        IFO380 = 310103,
        [Display(Name = "调和油")]
        BLENDED = 310104
    }
}
