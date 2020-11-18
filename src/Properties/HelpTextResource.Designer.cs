﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Umbraco.Packager.CI.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class HelpTextResource {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal HelpTextResource() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("UmbPack.Properties.HelpTextResource", typeof(HelpTextResource).Assembly);
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
        ///   Looks up a localized string similar to Initializes a new package.xml file from provided defaults
        ///
        ///Example usage:
        ///- umbpack init
        ///- umbpack init folder/subfolder.
        /// </summary>
        public static string HelpInit {
            get {
                return ResourceManager.GetString("HelpInit", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Folder to save package.xml in (default current folder)
        ///The folder should exist prior to running the command.
        /// </summary>
        public static string HelpInitFolder {
            get {
                return ResourceManager.GetString("HelpInitFolder", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Use nuspec file as a starting point for the package.xml file.
        /// </summary>
        public static string HelpInitNuspec {
            get {
                return ResourceManager.GetString("HelpInitNuspec", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Create an Umbraco package from a folder or existing package.xml file.
        /// </summary>
        public static string HelpPack {
            get {
                return ResourceManager.GetString("HelpPack", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The package.xml file or folder you want to create your package from.
        /// </summary>
        public static string HelpPackFile {
            get {
                return ResourceManager.GetString("HelpPackFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Specified the directory the created package will be saved to.
        /// </summary>
        public static string HelpPackOutput {
            get {
                return ResourceManager.GetString("HelpPackOutput", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An explicit file name to give the generated package file.
        /// </summary>
        public static string HelpPackPackageFileName {
            get {
                return ResourceManager.GetString("HelpPackPackageFileName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Properties to replace in the package.xml file.
        /// </summary>
        public static string HelpPackProperties {
            get {
                return ResourceManager.GetString("HelpPackProperties", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Override the version defined in the package.xml file.
        /// </summary>
        public static string HelpPackVersion {
            get {
                return ResourceManager.GetString("HelpPackVersion", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Push an Umbraco package to our.umbraco.com.
        /// </summary>
        public static string HelpPush {
            get {
                return ResourceManager.GetString("HelpPush", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to One or more wildcard patterns to match against existing package files to be archived.
        /// </summary>
        public static string HelpPushArchive {
            get {
                return ResourceManager.GetString("HelpPushArchive", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Make this package the current package file.
        /// </summary>
        public static string HelpPushCurrent {
            get {
                return ResourceManager.GetString("HelpPushCurrent", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Change the required DotNetVersion for the package.
        /// </summary>
        public static string HelpPushDotNet {
            get {
                return ResourceManager.GetString("HelpPushDotNet", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Api Key to use .
        /// </summary>
        public static string HelpPushKey {
            get {
                return ResourceManager.GetString("HelpPushKey", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Path to the package.zip you wish to push.
        /// </summary>
        public static string HelpPushPackage {
            get {
                return ResourceManager.GetString("HelpPushPackage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Compatible Umbraco versions (in the form v850,v840,v830).
        /// </summary>
        public static string HelpPushWorks {
            get {
                return ResourceManager.GetString("HelpPushWorks", resourceCulture);
            }
        }
    }
}
