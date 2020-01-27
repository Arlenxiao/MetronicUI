using NewLife.Xml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace MUI.WebSite
{
    /// <summary>公司信息</summary>
    [DisplayName("公司信息")]
    [XmlConfigFile(@"Config\company.config", 15000)]
    public class CompanySetting : XmlConfig<CompanySetting>
    {
        /// <summary> 公司名称</summary>
        [Description("公司名称")]
        public String Name { get; set; }
        /// <summary> 公司电话</summary>
        [Description("公司电话")]
        public String Telephone { get; set; }
        /// <summary> 公司地址</summary>
        [Description("公司地址")]
        public String Address { get; set; }
        /// <summary> 发票名称</summary>
        [Description("发票名称")]
        public String Title { get; set; }
        /// <summary> 信用代码</summary>
        [Description("信用代码")]
        public String CreditCode { get; set; }
        /// <summary> 开户银行</summary>
        [Description("开户银行")]
        public String Bank { get; set; }
        /// <summary> 银行账号</summary>
        [Description("银行账号")]
        public String Account { get; set; }
        /// <summary> 开票地址</summary>
        [Description("开票地址")]
        public String CreditCodeAddress { get; set; }

        /// <summary> 附件</summary>
        [Description("附件")]
        public String Attachment { get; set; } = "~\\Attachment\\UploadImages";
    }

}