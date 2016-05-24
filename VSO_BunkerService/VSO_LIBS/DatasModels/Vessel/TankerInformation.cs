using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace VSO_LIBS.DatasModels.Vessel
{
    public class TankerInformation : VesselInfo
    {
        #region IMO
        [Display(Name = "船舶代码（IMO）")]
        [Required(ErrorMessage = "请填写船舶代码！")]
        public string IMO { get; set; }
        #endregion
        #region 燃油仓容
        [Display(Name = "燃油仓容")]
        [Required(ErrorMessage = "请填写燃油仓容！")]
        public decimal FuelCapacity { get; set; }
        #endregion
        #region 是否可调油
        [Display(Name = "是否可调油")]
        [Required(ErrorMessage = "请选择是否可调油！")]
        public bool IsBlendable { get; set; }
        #endregion
        #region 是否配有靠球
        [Display(Name = "是否配有靠球")]
        [Required(ErrorMessage = "请选择是否配有靠球！")]
        public bool IsFender { get; set; }
        #endregion
        #region 船级社证书
        [Display(Name = "船级社证书")]
        [Required(ErrorMessage = "请上传船级社证书！")]
        public string VesselClassficationDoc { get; set; }
        #endregion
    }
}
