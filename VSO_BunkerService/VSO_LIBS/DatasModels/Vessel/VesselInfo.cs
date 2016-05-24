using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VSO_LIBS.DatasModels.Vessel
{
    public abstract class VesselInfo
    {
        #region 船舶ID
        [Required, Key]
        public Guid VesselID { get; set; }
        #endregion
        #region 船舶名称
        [Display(Name = "船舶名称")]
        [Required(ErrorMessage = "请填写船舶名称")]
        [StringLength(64, ErrorMessage = "船舶名称不得超过64个字符！")]
        public string VesselName { get; set; }
        #endregion
        #region 呼号
        [Required(ErrorMessage = "请填写呼号"), Display(Name = "呼号"), StringLength(32, ErrorMessage = "呼号不得超过32个字符！")]
        public string CallSign { get; set; }
        #endregion
        #region 海事卫星电话号码
        [Required(ErrorMessage = "请填写海事卫星电话号码"), Display(Name = "海事卫星电话号码"), StringLength(16, ErrorMessage = "海事卫星电话号码不得超过16个字符！")]
        public string INMARSAT { get; set; }
        #endregion
        #region 单边带
        [Required(ErrorMessage = "请填写单边带"), Display(Name = "单边带"), StringLength(6, ErrorMessage = "单边带不得超过6个字符")]
        public string SSB { get; set; }
        #endregion
        #region 船旗
        [Required(ErrorMessage = "请选择船旗"), Display(Name = "船旗")]
        public ModelType.EVesselNationalityType VesselNationality { get; set; }
        #endregion
        #region 船旗证书
        [Required(ErrorMessage = "请上传船旗证书"), Display(Name = "船旗证书"), StringLength(128, ErrorMessage = "文件路径过长！")]
        public string VesselNationalityDoc { get; set; }
        #endregion
        #region 外键：船舶所有者
        public Guid UserInfoID { get; set; }
        [ForeignKey("UserInfoID")]
        public User.UserDetail UserInfo { get; set; }
        #endregion
    }
}
