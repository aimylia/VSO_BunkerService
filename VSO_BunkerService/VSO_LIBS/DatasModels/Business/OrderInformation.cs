using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VSO_LIBS.DatasModels.Business
{
    public abstract class OrderInformation
    {
        #region 主键
        [Required, Key]
        public Guid OrderInfoID { get; set; }
        #endregion
        #region 服务代码
        [Display(Name = "订单服务代码")]
        public string ServiceCode { get; set; }
        #endregion
        #region 有效期及过期日期
        [Display(Name = "订单有效期")]
        public int OrderValidation { get; set; }
        [Display(Name = "订单过期日期")]
        public DateTime OrderExpiryDate { get; set; }
        #endregion
        #region 订单经纬度
        [Display(Name = "订单纬度")]
        public double Order_B { get; set; }
        [Display(Name = "订单经度")]
        public double Order_L { get; set; }
        #endregion
        #region 创建及更新时间
        [Display(Name = "创建时间")]
        public DateTime CreateTime { get; set; }
        [Display(Name = "更新时间")]
        public DateTime UpdateTime { get; set; }
        #endregion
        #region 外键
        public Guid UserInfoID { get; set; }
        [ForeignKey("UserInfoID")]
        public User.UserDetail UserInfo { get; set; }
        #endregion
    }
}
