﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
{
    using System;
    using System.Collections.Generic;
    
    #line 2 "..\..\Views\Shared\ObjectForm1.cshtml"
    using System.ComponentModel;
    
    #line default
    #line hidden
    using System.IO;
    using System.Linq;
    using System.Net;
    
    #line 3 "..\..\Views\Shared\ObjectForm1.cshtml"
    using System.Reflection;
    
    #line default
    #line hidden
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Optimization;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using MUI.WebSite;
    using NewLife;
    
    #line 4 "..\..\Views\Shared\ObjectForm1.cshtml"
    using NewLife.Cube;
    
    #line default
    #line hidden
    
    #line 5 "..\..\Views\Shared\ObjectForm1.cshtml"
    using NewLife.Reflection;
    
    #line default
    #line hidden
    using NewLife.Web;
    using XCode;
    
    #line 6 "..\..\Views\Shared\ObjectForm1.cshtml"
    using XCode.Membership;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Shared/ObjectForm1.cshtml")]
    public partial class _Views_Shared_ObjectForm1_cshtml : System.Web.Mvc.WebViewPage<Object>
    {
        public _Views_Shared_ObjectForm1_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 7 "..\..\Views\Shared\ObjectForm1.cshtml"
  
    Layout = NewLife.Cube.Setting.Current.Layout;

    var Obj = Model as Object;
    var pis = ViewBag.Properties as IEnumerable<PropertyInfo>;

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<div");

WriteLiteral(" class=\"m-portlet m-portlet--last m-portlet--responsive-mobile m-portlet--sticky\"" +
"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"m-portlet__body\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 17 "..\..\Views\Shared\ObjectForm1.cshtml"
       Write(Html.Partial("_Object_Nav", Model));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n        <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"col-md-12\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"form-horizontal\"");

WriteLiteral(">\r\n");

            
            #line 22 "..\..\Views\Shared\ObjectForm1.cshtml"
                    
            
            #line default
            #line hidden
            
            #line 22 "..\..\Views\Shared\ObjectForm1.cshtml"
                     using (Html.BeginForm("Update", null))
                    {
                        
            
            #line default
            #line hidden
            
            #line 24 "..\..\Views\Shared\ObjectForm1.cshtml"
                   Write(Html.AntiForgeryToken());

            
            #line default
            #line hidden
            
            #line 24 "..\..\Views\Shared\ObjectForm1.cshtml"
                                                
                        
            
            #line default
            #line hidden
            
            #line 25 "..\..\Views\Shared\ObjectForm1.cshtml"
                   Write(Html.ValidationSummary(true));

            
            #line default
            #line hidden
            
            #line 25 "..\..\Views\Shared\ObjectForm1.cshtml"
                                                     
                        foreach (var pi in pis)
                        {
                            var name = pi.Name;
                            var dis = pi.GetDisplayName();
                            var des = pi.GetDescription();
                            if (dis.IsNullOrEmpty() && !des.IsNullOrEmpty()) { dis = des; des = null; }
                            if (!dis.IsNullOrEmpty() && des.IsNullOrEmpty() && dis.Contains("。"))
                            {
                                des = dis.Substring("。");
                                dis = dis.Substring(null, "。");
                            }


            
            #line default
            #line hidden
WriteLiteral("                            <div");

WriteLiteral(" class=\"cube-flex-con\"");

WriteLiteral(" style=\"margin-bottom: 10px; width: 100%; min-height: 3rem;\"");

WriteLiteral(">\r\n                                <div");

WriteLiteral(" class=\"col-xs-2 col-md-4 col-xs-2 col-md-4 cube-flex-con cube-flex-items cube-fl" +
"ex-end\"");

WriteLiteral(" style=\"padding: 0;\"");

WriteLiteral(">\r\n                                    <label");

WriteLiteral(" class=\"control-label no-padding-left\"");

WriteAttribute("for", Tuple.Create(" for=\"", 1802), Tuple.Create("\"", 1816)
            
            #line 40 "..\..\Views\Shared\ObjectForm1.cshtml"
      , Tuple.Create(Tuple.Create("", 1808), Tuple.Create<System.Object, System.Int32>(pi.Name
            
            #line default
            #line hidden
, 1808), false)
);

WriteLiteral(" style=\"text-align: right; padding: 0;\"");

WriteLiteral(">");

            
            #line 40 "..\..\Views\Shared\ObjectForm1.cshtml"
                                                                                                                                   Write(dis ?? pi.Name);

            
            #line default
            #line hidden
WriteLiteral("</label>\r\n                                    <div");

WriteLiteral(" class=\"m--margin-right-5 m--margin-left-5 cube-flex-con cube-flex-items\"");

WriteLiteral(" style=\"width:18px;\"");

WriteLiteral(">\r\n");

            
            #line 42 "..\..\Views\Shared\ObjectForm1.cshtml"
                                        
            
            #line default
            #line hidden
            
            #line 42 "..\..\Views\Shared\ObjectForm1.cshtml"
                                         if (!des.IsNullOrEmpty())
                                        {

            
            #line default
            #line hidden
WriteLiteral("                                            <i");

WriteLiteral(" class=\"la la-question-circle\"");

WriteLiteral(" data-skin=\"light\"");

WriteLiteral(" data-toggle=\"m-popover\"");

WriteLiteral(" data-placement=\"top\"");

WriteLiteral(" title=\"\"");

WriteLiteral(" data-content=\"");

            
            #line 44 "..\..\Views\Shared\ObjectForm1.cshtml"
                                                                                                                                                              Write(des);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral(" style=\"margin-top: 4px;\"");

WriteLiteral("></i>\r\n");

            
            #line 45 "..\..\Views\Shared\ObjectForm1.cshtml"
                                        }

            
            #line default
            #line hidden
WriteLiteral("                                    </div>\r\n                                </div" +
">\r\n                                <div");

WriteLiteral(" class=\"input-group col-xs-10 col-md-4 cube-flex-con cube-flex-items\"");

WriteLiteral(" style=\"padding: 0;\"");

WriteLiteral(">\r\n");

WriteLiteral("                                    ");

            
            #line 49 "..\..\Views\Shared\ObjectForm1.cshtml"
                               Write(Html.ForEditorX(pi.Name, Obj.GetValue(pi), pi.PropertyType, null, new { @class = "form-control form-control-sm m-input" }.ToDictionary()));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                                    ");

            
            #line 50 "..\..\Views\Shared\ObjectForm1.cshtml"
                               Write(Html.ValidationMessage(pi.Name));

            
            #line default
            #line hidden
WriteLiteral("\r\n                                </div>\r\n                            </div>     " +
"                       \r\n");

            
            #line 53 "..\..\Views\Shared\ObjectForm1.cshtml"
                        }
                        if (this.Has(PermissionFlags.Update))
                        {

            
            #line default
            #line hidden
WriteLiteral("                            <div");

WriteLiteral(" class=\"clearfix form-actions col-sm-12 col-md-12\"");

WriteLiteral(">\r\n                                <label");

WriteLiteral(" class=\"control-label col-xs-4 col-sm-5 col-md-5\"");

WriteLiteral("></label>\r\n                                <button");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" class=\"btn btn-success\"");

WriteLiteral("><i");

WriteLiteral(" class=\"la la-save\"");

WriteLiteral("></i><strong>保存</strong></button>\r\n                                <button");

WriteLiteral(" type=\"button\"");

WriteLiteral(" class=\"btn btn-danger\"");

WriteLiteral(" onclick=\"history.go(-1);\"");

WriteLiteral("><i");

WriteLiteral(" class=\"la la-remove\"");

WriteLiteral("></i><strong>取消</strong></button>\r\n                            </div>\r\n");

            
            #line 61 "..\..\Views\Shared\ObjectForm1.cshtml"
                        }
                    }

            
            #line default
            #line hidden
WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r" +
"\n");

        }
    }
}
#pragma warning restore 1591