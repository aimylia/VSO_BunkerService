using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VSO_LIBS.DatasModels.Vessel
{
    public class ReeferInformation : VesselInfo
    {
        #region IMO
        [Display(Name = "船舶代码（IMO）"), Required(ErrorMessage = "请填写船舶代码！")]
        public string IMO { get; set; }
        #endregion
        #region 燃油仓容
        [Display(Name = "燃油仓容"), Required(ErrorMessage = "请填写燃油仓容！")]
        public decimal FuelCapacity { get; set; }
        #endregion
        #region 冻舱舱容
        public decimal ReeferCapacity { get; set; }
        #endregion
        #region 是否配有靠球
        [Display(Name = "是否配有靠球"), Required(ErrorMessage = "请选择是否配有靠球！")]
        public bool IsFender { get; set; }
        #endregion
        #region 冷冻船吊机类型
        public ModelType.EReeferGearType GearType { get; set; }
        #endregion
        #region 船长度
        [Display(Name = "船长度"), Required(ErrorMessage = "请填写船长度！")]
        public decimal VesselLength { get; set; }
        #endregion
        #region 船宽度
        [Display(Name = "船宽度"), Required(ErrorMessage = "请填写船宽度！")]
        public decimal VesselBeam { get; set; }
        #endregion
        #region 船深度
        [Display(Name = "船深度"), Required(ErrorMessage = "请填写船深度！")]
        public decimal VesselDeep { get; set; }
        #endregion
        #region 舷外臂展
        public decimal OutReach { get; set; }
        #endregion
        #region 载重吨
        public decimal DWTonnage { get; set; }
        #endregion
        #region 最大航速
        public decimal MaxSpeed { get; set; }
        #endregion
        #region 经济航速
        public decimal CruiseSpeed { get; set; }
        #endregion
        #region 建造年代
        public DateTime BuiltYear { get; set; }
        #endregion
        #region 船级社证书
        [Display(Name = "船级社证书"), Required(ErrorMessage = "请上传船级社证书！")]
        public string VesselClassficationDoc { get; set; }
        #endregion
    }
}
