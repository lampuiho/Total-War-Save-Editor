﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EsfSaveEditorControls {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "12.0.0.0")]
    internal sealed partial class R2TW : global::System.Configuration.ApplicationSettingsBase {
        
        private static R2TW defaultInstance = ((R2TW)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new R2TW())));
        
        public static R2TW Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("<?xml version=\"1.0\" encoding=\"utf-16\"?>\r\n<ArrayOfString xmlns:xsi=\"http://www.w3." +
            "org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <s" +
            "tring>data_rome2.pack</string>\r\n</ArrayOfString>")]
        public global::System.Collections.Specialized.StringCollection dataPacks {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["dataPacks"]));
            }
            set {
                this["dataPacks"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("<?xml version=\"1.0\" encoding=\"utf-16\"?>\r\n<ArrayOfString xmlns:xsi=\"http://www.w3." +
            "org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <s" +
            "tring>local_en.pack</string>\r\n  <string>local_en_rome2.pack</string>\r\n</ArrayOfS" +
            "tring>")]
        public global::System.Collections.Specialized.StringCollection locDataPacks {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["locDataPacks"]));
            }
            set {
                this["locDataPacks"] = value;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Rome2.exe")]
        public string exe {
            get {
                return ((string)(this["exe"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Total War: Rome 2")]
        public string gameName {
            get {
                return ((string)(this["gameName"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string gamePath {
            get {
                return ((string)(this["gamePath"]));
            }
            set {
                this["gamePath"] = value;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("9")]
        public int character_class_path {
            get {
                return ((int)(this["character_class_path"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"<?xml version=""1.0"" encoding=""utf-16""?>
<ArrayOfString xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"">
  <string>general</string>
  <string>spy</string>
  <string>champion</string>
  <string>dignitary</string>
</ArrayOfString>")]
        public global::System.Collections.Specialized.StringCollection character_filter {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["character_filter"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("6")]
        public int character_gender {
            get {
                return ((int)(this["character_gender"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("MILITARY_FORCE_LEGACY\\0")]
        public string army_class {
            get {
                return ((string)(this["army_class"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("<?xml version=\"1.0\" encoding=\"utf-16\"?>\r\n<ArrayOfString xmlns:xsi=\"http://www.w3." +
            "org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <s" +
            "tring>army</string>\r\n  <string>navy</string>\r\n</ArrayOfString>")]
        public global::System.Collections.Specialized.StringCollection army_filter {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["army_filter"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("MILITARY_FORCE_LEGACY\\2")]
        public string army_index {
            get {
                return ((string)(this["army_index"]));
            }
        }
    }
}
