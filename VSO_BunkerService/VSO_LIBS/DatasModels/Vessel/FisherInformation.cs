using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VSO_LIBS.DatasModels.Vessel
{
    public class FisherInformation : VesselInfo
    {
        #region 渔获仓容
        [Required(ErrorMessage = "请填写渔获仓容"), Display(Name = "渔获仓容")]
        public decimal FishCapacity { get; set; }
        #endregion
        #region 燃油仓容
        [Required(ErrorMessage = "请填写燃油仓容"), Display(Name = "燃油仓容")]
        public decimal FuelCapacity { get; set; }
        #endregion
        #region 渔船类型
        [Required(ErrorMessage = "请选择渔船类型"), Display(Name = "渔船类型")]
        public ModelType.EFisherType FisherType { get; set; }
        #endregion
    }
}
