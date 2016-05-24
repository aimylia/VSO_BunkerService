using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VSO_LIBS.DatasModels.ModelType
{
    public enum EReeferGearType
    {
        [Display(Name = "克令吊")]
        CRANE = 200301,
        [Display(Name = "吊杆")]
        DERRICK = 200302
    }
}
