﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace iADAATPA.MTProvider {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class PluginResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal PluginResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("iADAATPA.MTProvider.PluginResources", typeof(PluginResources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to https://app.iadaatpa.eu/api/.
        /// </summary>
        public static string iADAATPA_API {
            get {
                return ResourceManager.GetString("iADAATPA_API", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Icon similar to (Icon).
        /// </summary>
        public static System.Drawing.Icon iadaatpa_logo {
            get {
                object obj = ResourceManager.GetObject("iadaatpa_logo", resourceCulture);
                return ((System.Drawing.Icon)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to iADAATPA Translator plugin for SDL Trados Studio.
        /// </summary>
        public static string Plugin_Description {
            get {
                return ResourceManager.GetString("Plugin_Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to iADAATPA Translator.
        /// </summary>
        public static string Plugin_Name {
            get {
                return ResourceManager.GetString("Plugin_Name", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to iadaatpa.
        /// </summary>
        public static string Plugin_UriSchema {
            get {
                return ResourceManager.GetString("Plugin_UriSchema", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please enter your Consumer API Token..
        /// </summary>
        public static string UI_AuthText {
            get {
                return ResourceManager.GetString("UI_AuthText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to iADAATPA Authentication.
        /// </summary>
        public static string UI_AuthTitle {
            get {
                return ResourceManager.GetString("UI_AuthTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to GO.
        /// </summary>
        public static string UI_Go {
            get {
                return ResourceManager.GetString("UI_Go", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Clear.
        /// </summary>
        public static string UI_LogOut {
            get {
                return ResourceManager.GetString("UI_LogOut", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The Consumer API Token you have entered is not valid..
        /// </summary>
        public static string UI_TokenNotValid {
            get {
                return ResourceManager.GetString("UI_TokenNotValid", resourceCulture);
            }
        }
    }
}
