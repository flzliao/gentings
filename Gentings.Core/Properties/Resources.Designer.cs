﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Gentings.Properties {
    using System;
    
    
    /// <summary>
    ///   一个强类型的资源类，用于查找本地化的字符串等。
    /// </summary>
    // 此类是由 StronglyTypedResourceBuilder
    // 类通过类似于 ResGen 或 Visual Studio 的工具自动生成的。
    // 若要添加或移除成员，请编辑 .ResX 文件，然后重新运行 ResGen
    // (以 /str 作为命令选项)，或重新生成 VS 项目。
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   返回此类使用的缓存的 ResourceManager 实例。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Gentings.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   重写当前线程的 CurrentUICulture 属性
        ///   重写当前线程的 CurrentUICulture 属性。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   查找类似 参数值必须以“{0}”结尾！ 的本地化字符串。
        /// </summary>
        internal static string CommandArgs_Read_MustEndsWith {
            get {
                return ResourceManager.GetString("CommandArgs_Read_MustEndsWith", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 本程序可以使用的命令包含以下内容： 的本地化字符串。
        /// </summary>
        internal static string CommandHandlerFactory_CommandList {
            get {
                return ResourceManager.GetString("CommandHandlerFactory_CommandList", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 显示帮助信息 的本地化字符串。
        /// </summary>
        internal static string CommandHandlerFactory_ExecuteAsync_HelpDescription {
            get {
                return ResourceManager.GetString("CommandHandlerFactory_ExecuteAsync_HelpDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 不支持命令：.{0}，请使用.help命令查看可用命令 的本地化字符串。
        /// </summary>
        internal static string CommandHandlerFactory_ExecuteAsync_NotSupported {
            get {
                return ResourceManager.GetString("CommandHandlerFactory_ExecuteAsync_NotSupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 退出应用程序 的本地化字符串。
        /// </summary>
        internal static string CommandHandlerFactory_ExecuteAsync_Quit {
            get {
                return ResourceManager.GetString("CommandHandlerFactory_ExecuteAsync_Quit", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 程序即将在“{0}”秒后关闭... 的本地化字符串。
        /// </summary>
        internal static string CommandConsole_CloseAsync_DelayClose {
            get {
                return ResourceManager.GetString("CommandConsole_CloseAsync_DelayClose", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 关闭！ 的本地化字符串。
        /// </summary>
        internal static string CommandConsole_DelayAsync_Close {
            get {
                return ResourceManager.GetString("CommandConsole_DelayAsync_Close", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 正在初始化应用程序！ 的本地化字符串。
        /// </summary>
        internal static string CommandConsole_StartAsync_Initailize {
            get {
                return ResourceManager.GetString("CommandConsole_StartAsync_Initailize", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 已经成功启动了应用程序，可以输入命令进行手动操作！ 的本地化字符串。
        /// </summary>
        internal static string CommandConsole_StartAsync_SuccessStart {
            get {
                return ResourceManager.GetString("CommandConsole_StartAsync_SuccessStart", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 不支持命令“{0}”，请使用.help命令来获取帮助信息！ 的本地化字符串。
        /// </summary>
        internal static string CommandConsole_StartAsync_UseHelp {
            get {
                return ResourceManager.GetString("CommandConsole_StartAsync_UseHelp", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 关闭调试信息显示！ 的本地化字符串。
        /// </summary>
        internal static string DebugCommandHandler_ExecuteAsync_DebugOff {
            get {
                return ResourceManager.GetString("DebugCommandHandler_ExecuteAsync_DebugOff", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 开启调试信息显示！ 的本地化字符串。
        /// </summary>
        internal static string DebugCommandHandler_ExecuteAsync_DebugOn {
            get {
                return ResourceManager.GetString("DebugCommandHandler_ExecuteAsync_DebugOn", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 是否显示调试信息，如果关闭使用命令.debug off 的本地化字符串。
        /// </summary>
        internal static string DebugCommandHandler_Help_DebugOff {
            get {
                return ResourceManager.GetString("DebugCommandHandler_Help_DebugOff", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 属性表达式&apos;{0}&apos;不正确， 表达式必须提供一种属性访问，如： &apos;t =&gt; t.MyProperty&apos;；如果式多个属性，需要如下代码表示：&apos;t =&gt; new {{ t.MyProperty1, t.MyProperty2 }}&apos;。 的本地化字符串。
        /// </summary>
        internal static string InvalidPropertiesExpression {
            get {
                return ResourceManager.GetString("InvalidPropertiesExpression", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 属性表达式&apos;{0}&apos;不正确， 表达式必须提供一种属性访问，如： &apos;t =&gt; t.MyProperty&apos;。 的本地化字符串。
        /// </summary>
        internal static string InvalidPropertyExpression {
            get {
                return ResourceManager.GetString("InvalidPropertyExpression", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 字节大小必须能被 8 整除。 的本地化字符串。
        /// </summary>
        internal static string RandomNumberGenerator_SizeInvalid {
            get {
                return ResourceManager.GetString("RandomNumberGenerator_SizeInvalid", resourceCulture);
            }
        }
    }
}
