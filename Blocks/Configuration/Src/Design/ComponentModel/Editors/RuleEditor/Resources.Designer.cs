﻿//===============================================================================
// Microsoft patterns & practices Enterprise Library
// Core
//===============================================================================
// Copyright © Microsoft Corporation.  All rights reserved.
// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY
// OF ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT
// LIMITED TO THE IMPLIED WARRANTIES OF MERCHANTABILITY AND
// FITNESS FOR A PARTICULAR PURPOSE.
//===============================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.4927
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.Practices.EnterpriseLibrary.Configuration.Design.ComponentModel.Editors.RuleEditor {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0")]
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.Practices.EnterpriseLibrary.Configuration.Design.ComponentModel.Editors" +
                            ".RuleEditor.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to Not Authorized.
        /// </summary>
        internal static string AccessDenied {
            get {
                return ResourceManager.GetString("AccessDenied", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Authorized.
        /// </summary>
        internal static string AccessGranted {
            get {
                return ResourceManager.GetString("AccessGranted", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Expression is invalid..
        /// </summary>
        internal static string ParseFailedCaption {
            get {
                return ResourceManager.GetString("ParseFailedCaption", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Expression is invalid. {0}.
        /// </summary>
        internal static string ParseFailedMessage {
            get {
                return ResourceManager.GetString("ParseFailedMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Expression is valid..
        /// </summary>
        internal static string ParseSucceededMessageBox {
            get {
                return ResourceManager.GetString("ParseSucceededMessageBox", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Expression is valid..
        /// </summary>
        internal static string ParseSucceededMessageBoxCaption {
            get {
                return ResourceManager.GetString("ParseSucceededMessageBoxCaption", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You must specify a name for this Rule..
        /// </summary>
        internal static string RuleNameRequired {
            get {
                return ResourceManager.GetString("RuleNameRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to parse expression.
        /// </summary>
        internal static string UnableToParseDialogCaption {
            get {
                return ResourceManager.GetString("UnableToParseDialogCaption", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to parse expression.  Are you sure you want to exit?.
        /// </summary>
        internal static string UnableToParseDialogMessage {
            get {
                return ResourceManager.GetString("UnableToParseDialogMessage", resourceCulture);
            }
        }
    }
}
