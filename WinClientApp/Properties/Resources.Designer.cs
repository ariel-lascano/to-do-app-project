﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WinClientApp.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
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
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("WinClientApp.Properties.Resources", typeof(Resources).Assembly);
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
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap AddRow {
            get {
                object obj = ResourceManager.GetObject("AddRow", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap ArrowDownEnd {
            get {
                object obj = ResourceManager.GetObject("ArrowDownEnd", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap ArrowUpEnd {
            get {
                object obj = ResourceManager.GetObject("ArrowUpEnd", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to http://localhost:5118/items.
        /// </summary>
        internal static string BASE_URI {
            get {
                return ResourceManager.GetString("BASE_URI", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap Delete {
            get {
                object obj = ResourceManager.GetObject("Delete", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Do You want remove item &apos;{0}&apos;?.
        /// </summary>
        internal static string DELETE_MESSAGE {
            get {
                return ResourceManager.GetString("DELETE_MESSAGE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Remove selected item.
        /// </summary>
        internal static string DELETE_SELECTED {
            get {
                return ResourceManager.GetString("DELETE_SELECTED", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to http://localhost:5118/items/delete/{0}.
        /// </summary>
        internal static string DELETE_URI_FORMAT {
            get {
                return ResourceManager.GetString("DELETE_URI_FORMAT", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to application/json.
        /// </summary>
        internal static string JSON_MEDIA_TYPE {
            get {
                return ResourceManager.GetString("JSON_MEDIA_TYPE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap LoginUser {
            get {
                object obj = ResourceManager.GetObject("LoginUser", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Move down selected item.
        /// </summary>
        internal static string MOVE_DOWN {
            get {
                return ResourceManager.GetString("MOVE_DOWN", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Move up selected item.
        /// </summary>
        internal static string MOVE_UP {
            get {
                return ResourceManager.GetString("MOVE_UP", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Add new item.
        /// </summary>
        internal static string NEW_ITEM {
            get {
                return ResourceManager.GetString("NEW_ITEM", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Todo....
        /// </summary>
        internal static string NEW_ITEM_DEFAULT_NAME {
            get {
                return ResourceManager.GetString("NEW_ITEM_DEFAULT_NAME", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Refresh required.
        /// </summary>
        internal static string REFRESH_CAPTION {
            get {
                return ResourceManager.GetString("REFRESH_CAPTION", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Items collection has been updated outside by client {0}
        ///
        ///REFRESH REQUIRED.
        /// </summary>
        internal static string REFRESH_MESSAGE {
            get {
                return ResourceManager.GetString("REFRESH_MESSAGE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to http://localhost:5118/items/{0}.
        /// </summary>
        internal static string UPDATE_URI_FORMAT {
            get {
                return ResourceManager.GetString("UPDATE_URI_FORMAT", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap user_32 {
            get {
                object obj = ResourceManager.GetObject("user-32", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Warning.
        /// </summary>
        internal static string WARNING {
            get {
                return ResourceManager.GetString("WARNING", resourceCulture);
            }
        }
    }
}
