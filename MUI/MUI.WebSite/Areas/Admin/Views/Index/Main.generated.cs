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
    
    #line 2 "..\..\Areas\Admin\Views\Index\Main.cshtml"
    using System.Collections;
    
    #line default
    #line hidden
    using System.Collections.Generic;
    
    #line 1 "..\..\Areas\Admin\Views\Index\Main.cshtml"
    using System.Diagnostics;
    
    #line default
    #line hidden
    using System.IO;
    using System.Linq;
    using System.Net;
    
    #line 3 "..\..\Areas\Admin\Views\Index\Main.cshtml"
    using System.Reflection;
    
    #line default
    #line hidden
    
    #line 4 "..\..\Areas\Admin\Views\Index\Main.cshtml"
    using System.Runtime;
    
    #line default
    #line hidden
    
    #line 5 "..\..\Areas\Admin\Views\Index\Main.cshtml"
    using System.Runtime.Versioning;
    
    #line default
    #line hidden
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using NewLife;
    
    #line 6 "..\..\Areas\Admin\Views\Index\Main.cshtml"
    using NewLife.Common;
    
    #line default
    #line hidden
    using NewLife.Cube;
    using NewLife.Reflection;
    
    #line 7 "..\..\Areas\Admin\Views\Index\Main.cshtml"
    using NewLife.Web;
    
    #line default
    #line hidden
    using XCode;
    using XCode.Membership;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/Admin/Views/Index/Main.cshtml")]
    public partial class _Areas_Admin_Views_Index_Main_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Areas_Admin_Views_Index_Main_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 8 "..\..\Areas\Admin\Views\Index\Main.cshtml"
  
    Layout = NewLife.Cube.Setting.Current.Layout;

    ViewBag.Title = "服务器信息";

    var asm = Assembly.GetExecutingAssembly();
    var att = asm.GetCustomAttribute<TargetFrameworkAttribute>();
    var ver = att.FrameworkDisplayName ?? att.FrameworkName;
    var req = HttpContext.Current.Request;

    // GC设置
    var gc = "IsServerGC={0},LatencyMode={1}".F(GCSettings.IsServerGC, GCSettings.LatencyMode);

            
            #line default
            #line hidden
WriteLiteral("\r\n<div");

WriteLiteral(" class=\"kt-portlet kt-portlet--mobile\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"kt-portlet__head kt-portlet__head--lg\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"kt-portlet__head-label\"");

WriteLiteral(">\r\n            <span");

WriteLiteral(" class=\"kt-portlet__head-icon\"");

WriteLiteral(">\r\n                <i");

WriteLiteral(" class=\"kt-font-brand flaticon2-line-chart\"");

WriteLiteral("></i>\r\n            </span>\r\n            <h3");

WriteLiteral(" class=\"kt-portlet__head-title\"");

WriteLiteral(">\r\n                服务器信息\r\n            </h3>\r\n        </div>\r\n    </div>\r\n    <div" +
"");

WriteLiteral(" class=\"kt-portlet__body\"");

WriteLiteral(" style=\"overflow-x:auto;\"");

WriteLiteral(">\r\n        <table");

WriteLiteral(" class=\"table table-bordered table-hover table-striped table-condensed\"");

WriteLiteral(">\r\n            <tbody>\r\n                <tr>\r\n                    <td");

WriteLiteral(" class=\"name\"");

WriteLiteral(">\r\n                        应用系统：\r\n                    </td>\r\n                    " +
"<td");

WriteLiteral(" class=\"value\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 40 "..\..\Areas\Admin\Views\Index\Main.cshtml"
                   Write(HttpRuntime.AppDomainAppVirtualPath);

            
            #line default
            #line hidden
WriteLiteral("&nbsp;\r\n");

            
            #line 41 "..\..\Areas\Admin\Views\Index\Main.cshtml"
                        
            
            #line default
            #line hidden
            
            #line 41 "..\..\Areas\Admin\Views\Index\Main.cshtml"
                         if (this.Has((PermissionFlags)16))
                        {

            
            #line default
            #line hidden
WriteLiteral("                            <a");

WriteAttribute("href", Tuple.Create(" href=\"", 1533), Tuple.Create("\"", 1562)
            
            #line 43 "..\..\Areas\Admin\Views\Index\Main.cshtml"
, Tuple.Create(Tuple.Create("", 1540), Tuple.Create<System.Object, System.Int32>(Url.Action("Restart")
            
            #line default
            #line hidden
, 1540), false)
);

WriteLiteral(" onclick=\"return confirm(\'仅重启ASP.Net应用程序域，而不是操作系统！\\n确认重启？\')\"");

WriteLiteral(">重启应用系统</a>\r\n");

            
            #line 44 "..\..\Areas\Admin\Views\Index\Main.cshtml"
                        }

            
            #line default
            #line hidden
WriteLiteral("                        &nbsp;&nbsp;&nbsp;&nbsp;");

            
            #line 45 "..\..\Areas\Admin\Views\Index\Main.cshtml"
                                           Write(req.GetRawUrl());

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </td>\r\n                    <td");

WriteLiteral(" class=\"name\"");

WriteLiteral(">\r\n                        目录：\r\n                    </td>\r\n                    <t" +
"d");

WriteLiteral(" class=\"value\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 51 "..\..\Areas\Admin\Views\Index\Main.cshtml"
                   Write(HttpRuntime.AppDomainAppPath);

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n                <tr>\r\n       " +
"             <td");

WriteLiteral(" class=\"name\"");

WriteLiteral(">\r\n                        域名地址：\r\n                    </td>\r\n                    " +
"<td");

WriteLiteral(" class=\"value\"");

WriteLiteral(">\r\n                        <span");

WriteLiteral(" title=\"SERVER_NAME\"");

WriteLiteral(">");

            
            #line 59 "..\..\Areas\Admin\Views\Index\Main.cshtml"
                                             Write(Request.ServerVariables["SERVER_NAME"]);

            
            #line default
            #line hidden
WriteLiteral("</span>，\r\n                        <span");

WriteLiteral(" title=\"LOCAl_ADDR\"");

WriteLiteral(">");

            
            #line 60 "..\..\Areas\Admin\Views\Index\Main.cshtml"
                                            Write(Request.ServerVariables["LOCAl_ADDR"]);

            
            #line default
            #line hidden
WriteLiteral(":");

            
            #line 60 "..\..\Areas\Admin\Views\Index\Main.cshtml"
                                                                                   Write(Request.ServerVariables["Server_Port"]);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n                        &nbsp;<span");

WriteLiteral(" title=\"REMOTE_HOST\"");

WriteLiteral(">[");

            
            #line 61 "..\..\Areas\Admin\Views\Index\Main.cshtml"
                                                    Write(Request.ServerVariables["REMOTE_HOST"]);

            
            #line default
            #line hidden
WriteLiteral("]</span>\r\n                        <a");

WriteAttribute("href", Tuple.Create(" href=\"", 2522), Tuple.Create("\"", 2558)
            
            #line 62 "..\..\Areas\Admin\Views\Index\Main.cshtml"
, Tuple.Create(Tuple.Create("", 2529), Tuple.Create<System.Object, System.Int32>(Url.Action("Main/ServerVar")
            
            #line default
            #line hidden
, 2529), false)
);

WriteLiteral(" target=\"main\"");

WriteLiteral(" title=\"点击打开服务器变量列表\"");

WriteLiteral(">服务器变量列表</a>\r\n                    </td>\r\n                    <td");

WriteLiteral(" class=\"name\"");

WriteLiteral(">\r\n                        计算机用户：\r\n                    </td>\r\n                   " +
" <td");

WriteLiteral(" class=\"value\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 68 "..\..\Areas\Admin\Views\Index\Main.cshtml"
                   Write(Environment.UserName);

            
            #line default
            #line hidden
WriteLiteral("/");

            
            #line 68 "..\..\Areas\Admin\Views\Index\Main.cshtml"
                                         Write(Environment.MachineName);

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n                <tr>\r\n       " +
"             <td");

WriteLiteral(" class=\"name\"");

WriteLiteral(">\r\n                        应用程序域：\r\n                    </td>\r\n                   " +
" <td");

WriteLiteral(" class=\"value\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 76 "..\..\Areas\Admin\Views\Index\Main.cshtml"
                   Write(AppDomain.CurrentDomain.FriendlyName);

            
            #line default
            #line hidden
WriteLiteral("\r\n                        <a");

WriteAttribute("href", Tuple.Create(" href=\"", 3143), Tuple.Create("\"", 3178)
            
            #line 77 "..\..\Areas\Admin\Views\Index\Main.cshtml"
, Tuple.Create(Tuple.Create("", 3150), Tuple.Create<System.Object, System.Int32>(Url.Action("Main/Assembly")
            
            #line default
            #line hidden
, 3150), false)
);

WriteLiteral(" target=\"main\"");

WriteLiteral(" title=\"点击打开进程程序集列表\"");

WriteLiteral(">程序集列表</a>\r\n                    </td>\r\n                    <td");

WriteLiteral(" class=\"name\"");

WriteLiteral(">\r\n                        .Net 版本：\r\n                    </td>\r\n                 " +
"   <td");

WriteLiteral(" class=\"value\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 83 "..\..\Areas\Admin\Views\Index\Main.cshtml"
                   Write(Environment.Version);

            
            #line default
            #line hidden
WriteLiteral(" &nbsp;");

            
            #line 83 "..\..\Areas\Admin\Views\Index\Main.cshtml"
                                              Write(ver);

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n                <tr>\r\n       " +
"             <td");

WriteLiteral(" class=\"name\"");

WriteLiteral(">\r\n                        操作系统：\r\n                    </td>\r\n                    " +
"<td");

WriteLiteral(" class=\"value\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 91 "..\..\Areas\Admin\Views\Index\Main.cshtml"
                   Write(Environment.OSVersion);

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </td>\r\n                    <td");

WriteLiteral(" class=\"name\"");

WriteLiteral(">\r\n                        Web服务器：\r\n                    </td>\r\n                  " +
"  <td");

WriteLiteral(" class=\"value\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 97 "..\..\Areas\Admin\Views\Index\Main.cshtml"
                   Write(ViewBag.WebServerName);

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n                <tr>\r\n       " +
"             <td");

WriteLiteral(" class=\"name\"");

WriteLiteral(">\r\n                        处理器：\r\n                    </td>\r\n                    <" +
"td");

WriteLiteral(" class=\"value\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 105 "..\..\Areas\Admin\Views\Index\Main.cshtml"
                   Write(Environment.ProcessorCount);

            
            #line default
            #line hidden
WriteLiteral("\r\n                        核心，");

            
            #line 106 "..\..\Areas\Admin\Views\Index\Main.cshtml"
                      Write(gc);

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </td>\r\n                    <td");

WriteLiteral(" class=\"name\"");

WriteLiteral(">\r\n                        时间：\r\n                    </td>\r\n                    <t" +
"d");

WriteLiteral(" class=\"value\"");

WriteLiteral(" title=\"这里使用了服务器默认的时间格式！后面是开机时间。\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 112 "..\..\Areas\Admin\Views\Index\Main.cshtml"
                   Write(DateTime.Now);

            
            #line default
            #line hidden
WriteLiteral("，开机");

            
            #line 112 "..\..\Areas\Admin\Views\Index\Main.cshtml"
                                    Write(new TimeSpan(0, 0, 0, 0, Environment.TickCount));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n                <tr>\r\n");

            
            #line 116 "..\..\Areas\Admin\Views\Index\Main.cshtml"
                    
            
            #line default
            #line hidden
            
            #line 116 "..\..\Areas\Admin\Views\Index\Main.cshtml"
                       var process = Process.GetCurrentProcess();
            
            #line default
            #line hidden
WriteLiteral("\r\n                    <td");

WriteLiteral(" class=\"name\"");

WriteLiteral(">\r\n                        内存：\r\n                    </td>\r\n                    <t" +
"d");

WriteLiteral(" class=\"value\"");

WriteLiteral(">\r\n\r\n                        工作集: ");

            
            #line 122 "..\..\Areas\Admin\Views\Index\Main.cshtml"
                         Write((process.WorkingSet64 / 1024 / 1024).ToString("n0"));

            
            #line default
            #line hidden
WriteLiteral("M\r\n                        提交: ");

            
            #line 123 "..\..\Areas\Admin\Views\Index\Main.cshtml"
                        Write((process.PrivateMemorySize64 / 1024 / 1024).ToString("n0"));

            
            #line default
            #line hidden
WriteLiteral("M\r\n                        GC: ");

            
            #line 124 "..\..\Areas\Admin\Views\Index\Main.cshtml"
                        Write((GC.GetTotalMemory(false) / 1024 / 1024).ToString("n0"));

            
            #line default
            #line hidden
WriteLiteral("M\r\n                        <a");

WriteAttribute("href", Tuple.Create(" href=\"", 5070), Tuple.Create("\"", 5111)
            
            #line 125 "..\..\Areas\Admin\Views\Index\Main.cshtml"
, Tuple.Create(Tuple.Create("", 5077), Tuple.Create<System.Object, System.Int32>(Url.Action("Main/ProcessModules")
            
            #line default
            #line hidden
, 5077), false)
);

WriteLiteral(" target=\"main\"");

WriteLiteral(" title=\"点击打开进程模块列表\"");

WriteLiteral(">模块列表</a>\r\n                        <a");

WriteAttribute("href", Tuple.Create(" href=\"", 5182), Tuple.Create("\"", 5214)
            
            #line 126 "..\..\Areas\Admin\Views\Index\Main.cshtml"
, Tuple.Create(Tuple.Create("", 5189), Tuple.Create<System.Object, System.Int32>(Url.Action("MemoryFree")
            
            #line default
            #line hidden
, 5189), false)
);

WriteLiteral(" title=\"点击释放进程内存\"");

WriteLiteral(">释放内存</a>\r\n                    </td>\r\n                    <td");

WriteLiteral(" class=\"name\"");

WriteLiteral(">\r\n                        进程时间：\r\n                    </td>\r\n                    " +
"<td");

WriteLiteral(" class=\"value\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 132 "..\..\Areas\Admin\Views\Index\Main.cshtml"
                   Write(process.TotalProcessorTime.TotalSeconds.ToString("N2"));

            
            #line default
            #line hidden
WriteLiteral("秒 启动于 ");

            
            #line 132 "..\..\Areas\Admin\Views\Index\Main.cshtml"
                                                                                Write(process.StartTime.ToFullString());

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n                <tr>\r\n       " +
"             <td");

WriteLiteral(" class=\"name\"");

WriteLiteral(">\r\n                        Session：\r\n                    </td>\r\n                 " +
"   <td");

WriteLiteral(" class=\"value\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 140 "..\..\Areas\Admin\Views\Index\Main.cshtml"
                   Write(Session.Contents.Count);

            
            #line default
            #line hidden
WriteLiteral(" 个，");

            
            #line 140 "..\..\Areas\Admin\Views\Index\Main.cshtml"
                                             Write(Session.Timeout);

            
            #line default
            #line hidden
WriteLiteral(" 分钟，SessionID：");

            
            #line 140 "..\..\Areas\Admin\Views\Index\Main.cshtml"
                                                                           Write(Session.Contents.SessionID);

            
            #line default
            #line hidden
WriteLiteral("\r\n                        <a");

WriteAttribute("href", Tuple.Create(" href=\"", 5874), Tuple.Create("\"", 5908)
            
            #line 141 "..\..\Areas\Admin\Views\Index\Main.cshtml"
, Tuple.Create(Tuple.Create("", 5881), Tuple.Create<System.Object, System.Int32>(Url.Action("Main/Session")
            
            #line default
            #line hidden
, 5881), false)
);

WriteLiteral(" target=\"main\"");

WriteLiteral(" title=\"点击打开Session列表\"");

WriteLiteral(">Session列表</a>\r\n                    </td>\r\n                    <td");

WriteLiteral(" class=\"name\"");

WriteLiteral(">\r\n                        Cache：\r\n                    </td>\r\n                   " +
" <td");

WriteLiteral(" class=\"value\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 147 "..\..\Areas\Admin\Views\Index\Main.cshtml"
                   Write(Cache.Count);

            
            #line default
            #line hidden
WriteLiteral(" 个，可用：");

            
            #line 147 "..\..\Areas\Admin\Views\Index\Main.cshtml"
                                      Write((Cache.EffectivePrivateBytesLimit / 1024).ToString("n0"));

            
            #line default
            #line hidden
WriteLiteral("KB\r\n                        <a");

WriteAttribute("href", Tuple.Create(" href=\"", 6257), Tuple.Create("\"", 6289)
            
            #line 148 "..\..\Areas\Admin\Views\Index\Main.cshtml"
, Tuple.Create(Tuple.Create("", 6264), Tuple.Create<System.Object, System.Int32>(Url.Action("Main/Cache")
            
            #line default
            #line hidden
, 6264), false)
);

WriteLiteral(" target=\"main\"");

WriteLiteral(" title=\"点击打开Cache列表\"");

WriteLiteral(">Cache列表</a>\r\n                    </td>\r\n                </tr>\r\n            </tbo" +
"dy>\r\n        </table>\r\n    </div>\r\n</div>\r\n<div");

WriteLiteral(" class=\"kt-portlet kt-portlet--mobile\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"kt-portlet__head kt-portlet__head--lg\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"kt-portlet__head-label\"");

WriteLiteral(">\r\n            <span");

WriteLiteral(" class=\"kt-portlet__head-icon\"");

WriteLiteral(">\r\n                <i");

WriteLiteral(" class=\"kt-font-brand flaticon2-line-chart\"");

WriteLiteral("></i>\r\n            </span>\r\n            <h3");

WriteLiteral(" class=\"kt-portlet__head-title\"");

WriteLiteral(">\r\n                程序集信息\r\n            </h3>\r\n        </div>\r\n    </div>\r\n    <div" +
"");

WriteLiteral(" class=\"kt-portlet__body\"");

WriteLiteral(" style=\"overflow-x:auto;\"");

WriteLiteral(">\r\n        <table");

WriteLiteral(" class=\"table table-bordered table-hover table-striped table-condensed\"");

WriteLiteral(@">
            <thead>
                <tr>
                    <th>名称</th>
                    <th>标题</th>
                    <th>文件版本</th>
                    <th>内部版本</th>
                    <th>编译时间</th>
                    <th>描述</th>
                </tr>
            </thead>
            <tbody>
");

            
            #line 179 "..\..\Areas\Admin\Views\Index\Main.cshtml"
                
            
            #line default
            #line hidden
            
            #line 179 "..\..\Areas\Admin\Views\Index\Main.cshtml"
                 foreach (AssemblyX item in ViewBag.MyAsms)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <tr>\r\n                        <td>");

            
            #line 182 "..\..\Areas\Admin\Views\Index\Main.cshtml"
                       Write(item.Name);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                        <td>");

            
            #line 183 "..\..\Areas\Admin\Views\Index\Main.cshtml"
                       Write(item.Title);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                        <td>");

            
            #line 184 "..\..\Areas\Admin\Views\Index\Main.cshtml"
                       Write(item.FileVersion);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                        <td>");

            
            #line 185 "..\..\Areas\Admin\Views\Index\Main.cshtml"
                       Write(item.Version);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                        <td>");

            
            #line 186 "..\..\Areas\Admin\Views\Index\Main.cshtml"
                       Write(item.Compile.ToFullString());

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                        <td>");

            
            #line 187 "..\..\Areas\Admin\Views\Index\Main.cshtml"
                       Write(item.Description);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                    </tr>\r\n");

            
            #line 189 "..\..\Areas\Admin\Views\Index\Main.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>");

        }
    }
}
#pragma warning restore 1591