using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VSO_LIBS.DatasModels.VanPoint
{
    public class VanPointInformation
    {
        [Required, Key]
        public int VanPointInfoID { get; set; }
        #region 外键
        public Guid UserInfoID { get; set; }
        [ForeignKey("UserInfoID")]
        public User.UserDetail UserInfo { get; set; }
        #endregion
        [Display(Name = "积分数量")]
        public int UserPoints { get; set; }
        [Display(Name = "积分类型")]
        public ModelType.EVanPointType PointType { get; set; }
        [Display(Name = "有效日期")]
        public DateTime ValidDate { get; set; }
    }
}
