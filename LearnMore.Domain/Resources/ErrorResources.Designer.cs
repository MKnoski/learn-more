﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LearnMore.Domain.Resources {
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
    public class ErrorResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal ErrorResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("LearnMore.Domain.Resources.ErrorResources", typeof(ErrorResources).Assembly);
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
        ///   Looks up a localized string similar to Email cannot be empty.
        /// </summary>
        public static string EmailEmpty {
            get {
                return ResourceManager.GetString("EmailEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Email must be valid email address.
        /// </summary>
        public static string EmailValid {
            get {
                return ResourceManager.GetString("EmailValid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to First name cannot be empty.
        /// </summary>
        public static string FirstNameEmpty {
            get {
                return ResourceManager.GetString("FirstNameEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Last name cannot be empty.
        /// </summary>
        public static string LastNameEmpty {
            get {
                return ResourceManager.GetString("LastNameEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Password must contain digits.
        /// </summary>
        public static string PasswordDigit {
            get {
                return ResourceManager.GetString("PasswordDigit", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Password cannot be empty.
        /// </summary>
        public static string PasswordEmpty {
            get {
                return ResourceManager.GetString("PasswordEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Password must contain lowercase letter.
        /// </summary>
        public static string PasswordLowercaseLetter {
            get {
                return ResourceManager.GetString("PasswordLowercaseLetter", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Password minimum length is.
        /// </summary>
        public static string PasswordMinLength {
            get {
                return ResourceManager.GetString("PasswordMinLength", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Password must contain special characters.
        /// </summary>
        public static string PasswordSpecialCharacter {
            get {
                return ResourceManager.GetString("PasswordSpecialCharacter", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Password must contain uppercase letter.
        /// </summary>
        public static string PasswordUppercaseLetter {
            get {
                return ResourceManager.GetString("PasswordUppercaseLetter", resourceCulture);
            }
        }
    }
}
