using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace VSO_LIBS.DatasModels.ModelType
{
    public enum EFisherType
    {
        [Display(Name = "鱿鱼钓船")]
        JIGGER = 200201,
        [Display(Name = "金枪鱼沿绳钓船")]
        LINER = 200202,
        [Display(Name = "拖网渔船")]
        TRAWLER = 200203,
        [Display(Name = "围网渔船")]
        SEINER = 200204,
        [Display(Name = "磷虾船")]
        KRILL = 200205,
        [Display(Name = "冷藏船")]
        REEFER = 200206,
        [Display(Name = "其他类型船只")]
        FISHBOAT = 200299
    }
}
