using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace VSO_LIBS.DatasModels.User
{
    public class UserDetail
    {
        #region 外键做主键，手工关联
        [Key]
        public Guid UserInfoID { get; set; }
        #endregion
        #region 公司基本信息
        #region 英文
        [Display(Name = "公司名称（英文）")]
        [StringLength(128, ErrorMessage = "公司名称不得超过128个字符！")]
        public string CompanyNameE { get; set; }
        [Display(Name = "联系人姓氏（英文）")]
        [StringLength(16, ErrorMessage = "联系人姓氏（英文）不得超过16个字符！")]
        public string ContactLastNameE { get; set; }
        [Display(Name = "联系人名称（英文）"), StringLength(16)]
        public string ContactFirstNameE { get; set; }
        [Display(Name = "联系人职务（英文）"), StringLength(32)]
        public string ContactPositionE { get; set; }
        [Display(Name = "公司所在地址（英文）"), StringLength(128)]
        public string CompanyAddressE { get; set; }
        #endregion
        #region 非英文
        [Display(Name = "公司中文（中文）"), StringLength(128)]
        public string CompanyName { get; set; }
        [Display(Name = "联系人姓氏（中文）"), StringLength(16)]
        public string ContactLastName { get; set; }
        [Display(Name = "联系人姓氏（中文）"), StringLength(16)]
        public string ContactFirstName { get; set; }
        [Display(Name = "联系人职务（中文）"), StringLength(32)]
        public string ContactPosition { get; set; }
        [Display(Name = "公司所在地址（中文）"), StringLength(128)]
        public string CompanyAddress { get; set; }
        #endregion
        #region 联系人电话
        [Display(Name = "联系人电话"), StringLength(16)]
        public string ContactPhone { get; set; }
        #endregion
        #region 移动电话
        [Display(Name = "移动电话"), StringLength(16)]
        public string MobilePhone { get; set; }
        #endregion
        #region 传真
        [Display(Name = "公司传真"), StringLength(16)]
        public string CompanyFax { get; set; }
        #endregion
        #region 公司营业执照或注册证书
        [Display(Name = "公司营业执照或注册证书"), StringLength(128)]
        public string CompanyDoc { get; set; }
        #endregion
        #endregion
        #region 发票抬头
        [Display(Name = "发票抬头（英文）"), StringLength(256)]
        public string InvoiceTitleE { get; set; }
        [Display(Name = "发票抬头（中文）"), StringLength(256)]
        public string InvoiceTitle { get; set; }
        #endregion
        #region 收款信息
        #region 英文
        [Display(Name = "收款公司名称（美元）"), StringLength(128)]
        public string BeneficiaryNameE { get; set; }
        [Display(Name = "收款行（美元）"), StringLength(128)]
        public string BeneficiaryBankE { get; set; }
        [Display(Name = "收款账户（美元）"), StringLength(32)]
        public string BeneficiaryAccountE { get; set; }
        [Display(Name = "收款行地址（美元）"), StringLength(128)]
        public string BeneficiaryBankAddressE { get; set; }
        #endregion
        #region 中文
        [Display(Name = "收款公司名称（中文）"), StringLength(128)]
        public string BeneficiaryName { get; set; }
        [Display(Name = "收款行（中文）"), StringLength(128)]
        public string BeneficiaryBank { get; set; }
        [Display(Name = "收款账户（中文）"), StringLength(32)]
        public string BeneficiaryAccount { get; set; }
        [Display(Name = "收款行地址（中文）"), StringLength(128)]
        public string BeneficiaryBankAddress { get; set; }
        #endregion
        #region 收款行SwiftCode
        [Display(Name = "收款行SwiftCode"), StringLength(32)]
        public string BeneficiarySwiftCode { get; set; }
        #endregion
        #endregion
        #region 付款信息
        #region 英文
        [Display(Name = "付款公司名称（美元）"), StringLength(128)]
        public string PaymentNameE { get; set; }
        [Display(Name = "付款行（美元）"), StringLength(128)]
        public string PaymentBankE { get; set; }
        [Display(Name = "付款账户（美元）"), StringLength(32)]
        public string PaymentAccountE { get; set; }
        [Display(Name = "付款行地址（美元）"), StringLength(128)]
        public string PaymentBankAddressE { get; set; }
        #endregion
        #region 中文
        [Display(Name = "付款公司名称（中文）"), StringLength(128)]
        public string PaymentNameC { get; set; }
        [Display(Name = "付款行（中文）"), StringLength(128)]
        public string PaymentBankC { get; set; }
        [Display(Name = "付款账户（中文）"), StringLength(32)]
        public string PaymentAccountC { get; set; }
        [Display(Name = "收款行地址（中文）"), StringLength(128)]
        public string PaymentBankAddressC { get; set; }
        #endregion
        #region 付款行SwiftCode
        [Display(Name = "付款行SwiftCode"), StringLength(32)]
        public string PaymentSwiftCode { get; set; }
        #endregion
        #endregion
        #region 外键关联信息
        public ICollection<Vessel.FisherInformation> FisherFleet { get; set; }
        public ICollection<Vessel.TankerInformation> TankerFleet { get; set; }
        public ICollection<Vessel.ReeferInformation> ReeferFleet { get; set; }

        public ICollection<Business.Bunker.BunkerInquiry> BunkerInquiries { get; set; }
        public ICollection<Business.Bunker.BunkerQuotation> BunkerQuotations { get; set; }
        public ICollection<Business.Bunker.BunkerOrder> BunkerOrders { get; set; }
        #endregion
    }
}
