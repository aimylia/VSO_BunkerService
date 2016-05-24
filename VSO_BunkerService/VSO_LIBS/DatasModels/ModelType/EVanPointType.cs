using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VSO_LIBS.DatasModels.ModelType
{
    public enum EVanPointType
    {
        [Display(Name = "泛洋积分")]
        VANPOINT = 400101,
        [Display(Name = "金积分")]
        GOLDPOINT = 400102,
        [Display(Name = "银积分")]
        SILVERPOINT = 400103
    }
}
