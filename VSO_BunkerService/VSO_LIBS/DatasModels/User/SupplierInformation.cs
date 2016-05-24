using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VSO_LIBS.DatasModels.User
{
    public class SupplierInformation
    {
        [Required, Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SupplierInfoID { get; set; }
        #region 外键
        [Required]
        public Guid UserInfoID { get; set; }
        [ForeignKey("UserInfoID")]
        public UserDetail UserInfo { get; set; }
        #endregion
        #region
        [Display(Name = "开始日期")]
        public DateTime PromotionStartDate { get; set; }
        [Display(Name = "结束日期")]
        public DateTime PromotionEndDate { get; set; }
        [Display(Name = "积分类型")]
        public ModelType.EVanPointType PointType { get; set; }
        [Display(Name = "单吨积分")]
        public int PromotionPoint { get; set; }
        #endregion
    }
}
