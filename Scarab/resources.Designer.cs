﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Scarab {
    using System;
    
    
    /// <summary>
    ///   一个强类型的资源类，用于查找本地化的字符串等。
    /// </summary>
    // 此类是由 StronglyTypedResourceBuilder
    // 类通过类似于 ResGen 或 Visual Studio 的工具自动生成的。
    // 若要添加或移除成员，请编辑 .ResX 文件，然后重新运行 ResGen
    // (以 /str 作为命令选项)，或重新生成 VS 项目。
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Scarab.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   重写当前线程的 CurrentUICulture 属性，对
        ///   使用此强类型资源类的所有资源查找执行重写。
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
        ///   查找类似 Uninstall 的本地化字符串。
        /// </summary>
        internal static string MI_InstallText_Installed {
            get {
                return ResourceManager.GetString("MI_InstallText_Installed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Install 的本地化字符串。
        /// </summary>
        internal static string MI_InstallText_NotInstalled {
            get {
                return ResourceManager.GetString("MI_InstallText_NotInstalled", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Disable API 的本地化字符串。
        /// </summary>
        internal static string MLVM_ApiButtonText_DisableAPI {
            get {
                return ResourceManager.GetString("MLVM_ApiButtonText_DisableAPI", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Enable API 的本地化字符串。
        /// </summary>
        internal static string MLVM_ApiButtonText_EnableAPI {
            get {
                return ResourceManager.GetString("MLVM_ApiButtonText_EnableAPI", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Toggle API 的本地化字符串。
        /// </summary>
        internal static string MLVM_ApiButtonText_ToggleAPI {
            get {
                return ResourceManager.GetString("MLVM_ApiButtonText_ToggleAPI", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Re-open the installer to use your new path. 的本地化字符串。
        /// </summary>
        internal static string MLVM_ChangePathAsync_Msgbox_Text {
            get {
                return ResourceManager.GetString("MLVM_ChangePathAsync_Msgbox_Text", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Path Changed! 的本地化字符串。
        /// </summary>
        internal static string MLVM_ChangePathAsync_Msgbox_Title {
            get {
                return ResourceManager.GetString("MLVM_ChangePathAsync_Msgbox_Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 The download hash for {0} ({1}) didn&apos;t match the given signature ({2}). It is either corrupt or the entry is incorrect. 的本地化字符串。
        /// </summary>
        internal static string MLVM_DisplayHashMismatch_Msgbox_Text {
            get {
                return ResourceManager.GetString("MLVM_DisplayHashMismatch_Msgbox_Text", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Hash mismatch! 的本地化字符串。
        /// </summary>
        internal static string MLVM_DisplayHashMismatch_Msgbox_Title {
            get {
                return ResourceManager.GetString("MLVM_DisplayHashMismatch_Msgbox_Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Unable to download {0}! The site may be down or you may lack network connectivity. 的本地化字符串。
        /// </summary>
        internal static string MLVM_DisplayNetworkError_Msgbox_Text {
            get {
                return ResourceManager.GetString("MLVM_DisplayNetworkError_Msgbox_Text", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Network Error 的本地化字符串。
        /// </summary>
        internal static string MLVM_DisplayNetworkError_Msgbox_Title {
            get {
                return ResourceManager.GetString("MLVM_DisplayNetworkError_Msgbox_Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Hollow Knight is open! This may lead to issues when installing mods. Close Hollow Knight? 的本地化字符串。
        /// </summary>
        internal static string MLVM_InternalUpdateInstallAsync_Msgbox_W_Text {
            get {
                return ResourceManager.GetString("MLVM_InternalUpdateInstallAsync_Msgbox_W_Text", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Warning! 的本地化字符串。
        /// </summary>
        internal static string MLVM_InternalUpdateInstallAsync_Msgbox_W_Title {
            get {
                return ResourceManager.GetString("MLVM_InternalUpdateInstallAsync_Msgbox_W_Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 failed with HTTP error {0} 的本地化字符串。
        /// </summary>
        internal static string MWVM_Impl_Error_Fetch_ModLinks_Error {
            get {
                return ResourceManager.GetString("MWVM_Impl_Error_Fetch_ModLinks_Error", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Unable to fetch modlinks, the operation {0} 的本地化字符串。
        /// </summary>
        internal static string MWVM_Impl_Error_Fetch_ModLinks_Msgbox_Text {
            get {
                return ResourceManager.GetString("MWVM_Impl_Error_Fetch_ModLinks_Msgbox_Text", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Error! 的本地化字符串。
        /// </summary>
        internal static string MWVM_Impl_Error_Fetch_ModLinks_Msgbox_Title {
            get {
                return ResourceManager.GetString("MWVM_Impl_Error_Fetch_ModLinks_Msgbox_Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 timed out 的本地化字符串。
        /// </summary>
        internal static string MWVM_Impl_Error_Fetch_ModLinks_Timeout {
            get {
                return ResourceManager.GetString("MWVM_Impl_Error_Fetch_ModLinks_Timeout", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Change Path 的本地化字符串。
        /// </summary>
        internal static string XAML_ChangPath {
            get {
                return ResourceManager.GetString("XAML_ChangPath", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 \nDependencies:\n 的本地化字符串。
        /// </summary>
        internal static string XAML_Dependencies {
            get {
                return ResourceManager.GetString("XAML_Dependencies", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Donate 的本地化字符串。
        /// </summary>
        internal static string XAML_Donate {
            get {
                return ResourceManager.GetString("XAML_Donate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 All 的本地化字符串。
        /// </summary>
        internal static string XAML_ModsFilter_All {
            get {
                return ResourceManager.GetString("XAML_ModsFilter_All", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Enabled 的本地化字符串。
        /// </summary>
        internal static string XAML_ModsFilter_Enabled {
            get {
                return ResourceManager.GetString("XAML_ModsFilter_Enabled", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Installed 的本地化字符串。
        /// </summary>
        internal static string XAML_ModsFilter_Installed {
            get {
                return ResourceManager.GetString("XAML_ModsFilter_Installed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Out of date 的本地化字符串。
        /// </summary>
        internal static string XAML_ModsFilter_OutOfDate {
            get {
                return ResourceManager.GetString("XAML_ModsFilter_OutOfDate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Open Mods 的本地化字符串。
        /// </summary>
        internal static string XAML_OpenMods {
            get {
                return ResourceManager.GetString("XAML_OpenMods", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 \nRepository:\n 的本地化字符串。
        /// </summary>
        internal static string XAML_Repository {
            get {
                return ResourceManager.GetString("XAML_Repository", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Mod Search 的本地化字符串。
        /// </summary>
        internal static string XAML_SearchMark {
            get {
                return ResourceManager.GetString("XAML_SearchMark", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Update API 的本地化字符串。
        /// </summary>
        internal static string XAML_UpdateAPI {
            get {
                return ResourceManager.GetString("XAML_UpdateAPI", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 \nVersion:\n 的本地化字符串。
        /// </summary>
        internal static string XAML_Version {
            get {
                return ResourceManager.GetString("XAML_Version", resourceCulture);
            }
        }

        /// <summary>
        ///   No path was selected!
        /// </summary>
        internal static string PU_NoSelect {
            get {
                return ResourceManager.GetString("PU_NoSelect", resourceCulture);
            }
        }

        /// <summary>
        ///   No application was selected!
        /// </summary>
        internal static string PU_NoSelectMac {
            get {
                return ResourceManager.GetString("PU_NoSelectMac", resourceCulture);
            }
        }

        /// <summary>
        ///   Invalid Hollow Knight path!
        /// </summary>
        internal static string PU_InvalidPathHeader {
            get {
                return ResourceManager.GetString("PU_InvalidPathHeader", resourceCulture);
            }
        }

        /// <summary>
        ///   Invalid Hollow Knight app!
        /// </summary>
        internal static string PU_InvalidAppHeader {
            get {
                return ResourceManager.GetString("PU_InvalidAppHeader", resourceCulture);
            }
        }

        /// <summary>
        ///   Select the folder containing hollow_knight_Data or Hollow Knight_Data.
        /// </summary>
        internal static string PU_InvalidPath {
            get {
                return ResourceManager.GetString("PU_InvalidPath", resourceCulture);
            }
        }

        /// <summary>
        ///   Missing Managed folder or Assembly-CSharp!
        /// </summary>
        internal static string PU_InvalidApp {
            get {
                return ResourceManager.GetString("PU_InvalidApp", resourceCulture);
            }
        }

        /// <summary>
        ///   Select your Hollow Knight folder.
        /// </summary>
        internal static string PU_SelectPath {
            get {
                return ResourceManager.GetString("PU_SelectPath", resourceCulture);
            }
        }

        /// <summary>
        ///  Path 
        /// </summary>
        internal static string PU_InvalidPathTitle {
            get {
                return ResourceManager.GetString("PU_InvalidPathTitle", resourceCulture);
            }
        }

        /// <summary>
        ///   Select your Hollow Knight app.
        /// </summary>
        internal static string PU_SelectApp {
            get {
                return ResourceManager.GetString("PU_SelectApp", resourceCulture);
            }
        }

        /// <summary>
        ///   Get the latest release
        /// </summary>
        internal static string MWVM_OutOfDate_GetLatest {
            get {
                return ResourceManager.GetString("MWVM_OutOfDate_GetLatest", resourceCulture);
            }
        }

        /// <summary>
        ///   Continue anyways.
        /// </summary>
        internal static string MWVM_OutOfDate_ContinueAnyways {
            get {
                return ResourceManager.GetString("MWVM_OutOfDate_ContinueAnyways", resourceCulture);
            }
        }

        /// <summary>
        ///   Out of date!
        /// </summary>
        internal static string MWVM_OutOfDate_Title {
            get {
                return ResourceManager.GetString("MWVM_OutOfDate_Title", resourceCulture);
            }
        }

        /// <summary>
        ///   This program is out of date! It may not function correctly.
        /// </summary>
        internal static string MWVM_OutOfDate_Message {
            get {
                return ResourceManager.GetString("MWVM_OutOfDate_Message", resourceCulture);
            }
        }

        /// <summary>
        ///   Warning
        /// </summary>
        internal static string MWVM_Warning {
            get {
                return ResourceManager.GetString("MWVM_Warning", resourceCulture);
            }
        }

        /// <summary>
        ///   The saved Hollow Knight path is invalid, please re-select a valid path.
        /// </summary>
        internal static string MWVM_InvalidSavedPath_Message {
            get {
                return ResourceManager.GetString("MWVM_InvalidSavedPath_Message", resourceCulture);
            }
        }

        /// <summary>
        ///   Info
        /// </summary>
        internal static string MWVM_Info {
            get {
                return ResourceManager.GetString("MWVM_Info", resourceCulture);
            }
        }

        /// <summary>
        ///   Unable to detect your Hollow Knight installation. Please select it.
        /// </summary>
        internal static string MWVM_UnableToDetect_Message {
            get {
                return ResourceManager.GetString("MWVM_UnableToDetect_Message", resourceCulture);
            }
        }

        /// <summary>
        ///   Detected path!
        /// </summary>
        internal static string MWVM_DetectedPath_Title {
            get {
                return ResourceManager.GetString("MWVM_DetectedPath_Title", resourceCulture);
            }
        }

        /// <summary>
        ///   Detected Hollow Knight install at {path.Root}. Is this correct?
        /// </summary>
        internal static string MWVM_DetectedPath_Message {
            get {
                return ResourceManager.GetString("MWVM_DetectedPath_Message", resourceCulture);
            }
        }
        

    }
}