﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Huddled.WPF.Controls.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Consolas, Lucida Console")]
        public global::System.Windows.Media.FontFamily FontFamily {
            get {
                return ((global::System.Windows.Media.FontFamily)(this["FontFamily"]));
            }
            set {
                this["FontFamily"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("12")]
        public double FontSize {
            get {
                return ((double)(this["FontSize"]));
            }
            set {
                this["FontSize"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool CopyOnMouseSelect {
            get {
                return ((bool)(this["CopyOnMouseSelect"]));
            }
            set {
                this["CopyOnMouseSelect"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("2")]
        public int TabCompleteMenuThreshold {
            get {
                return ((int)(this["TabCompleteMenuThreshold"]));
            }
            set {
                this["TabCompleteMenuThreshold"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("250")]
        public int TabCompleteDoubleTapMilliseconds {
            get {
                return ((int)(this["TabCompleteDoubleTapMilliseconds"]));
            }
            set {
                this["TabCompleteDoubleTapMilliseconds"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool HistoryMenuFilterDupes {
            get {
                return ((bool)(this["HistoryMenuFilterDupes"]));
            }
            set {
                this["HistoryMenuFilterDupes"] = value;
            }
        }
    }
}
