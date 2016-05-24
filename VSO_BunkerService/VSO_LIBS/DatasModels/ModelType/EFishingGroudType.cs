using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace VSO_LIBS.DatasModels.ModelType
{
    public enum EFishingGroudType
    {
        [Display(Name = "秘鲁渔场")]
        PERU = 300101,
        [Display(Name = "西非渔场")]
        WESTAFRICA = 300102,
        [Display(Name = "阿根廷渔场")]
        ARGENTINA = 300103,
        [Display(Name = "南极渔场")]
        ANTARCTICA = 300104,
        [Display(Name = "北太平洋渔场")]
        NORTHPACIFIC = 300105,
        [Display(Name = "印度洋渔场")]
        INDIANOCEAN = 300106,
        [Display(Name = "其他区域")]
        NONOTHER = 300199
    }
}
