using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using System.Web.Services.Discovery;
using Microsoft.AspNetCore.Mvc;
using NewLife.Cube;
using NewLife.Log;
using NewLife.Reflection;
using XCode.Membership;

namespace MUI.WebSite
{
    /// <summary>
    /// 系统配置服务，用于枚举魔方中所有继承于ConfigController的子类于集中进行系统相关配置
    /// </summary>
    public class ConfigSettingService
    {
        private static ConfigSettingService _current;
        public IDictionary<String, String> Links { get; }

        public ConfigSettingService()
        {
            Links = new Dictionary<String, String>();
        }

        public static ConfigSettingService Current
        {
            get
            {
                if (_current == null)
                {
                    _current = new ConfigSettingService();

                    var controllers = typeof(ControllerBaseX).GetAllSubclasses(false).ToArray();
                    foreach (var controller in controllers)
                    {
                        var name = controller.GetName();
                        name = name.Substring(0, name.Length - 10); // 截去名称中Controller字符
                        var menu = Menu.FindForName(name);
                        if (HasImplementedGeneric(controller, typeof(ConfigController<>)) && menu != null)
                            _current.Links.Add(menu.DisplayName, menu.Url);
                    }
                }

                return _current;
            }
        }

        /// <summary>
        /// 判断指定的类型 <paramref name="type"/> 是否是指定泛型类型的子类型，或实现了指定泛型接口。
        /// </summary>
        /// <param name="type">需要测试的类型。</param>
        /// <param name="generic">泛型接口类型，传入 typeof(IXxx&lt;&gt;)</param>
        /// <returns>如果是泛型接口的子类型，则返回 true，否则返回 false。</returns>
        private static bool HasImplementedGeneric(Type type, Type generic)
        {
            if (type == null) throw new ArgumentNullException(nameof(type));
            if (generic == null) throw new ArgumentNullException(nameof(generic));

            // 测试接口。
            var isTheRawGenericType = type.GetInterfaces().Any(IsTheRawGenericType);
            if (isTheRawGenericType) return true;

            // 测试类型。
            while (type != null && type != typeof(object))
            {
                isTheRawGenericType = IsTheRawGenericType(type);
                if (isTheRawGenericType) return true;
                type = type.BaseType;
            }

            // 没有找到任何匹配的接口或类型。
            return false;

            // 测试某个类型是否是指定的原始接口。
            bool IsTheRawGenericType(Type test)
                => generic == (test.IsGenericType ? test.GetGenericTypeDefinition() : test);
        }
    }

}