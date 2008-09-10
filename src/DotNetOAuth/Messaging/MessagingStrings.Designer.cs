﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.3053
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DotNetOAuth.Messaging {
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
    internal class MessagingStrings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal MessagingStrings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("DotNetOAuth.Messaging.MessagingStrings", typeof(MessagingStrings).Assembly);
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
        ///   Looks up a localized string similar to An instance of type {0} was expected, but received unexpected derived type {1}..
        /// </summary>
        internal static string DerivedTypeNotExpected {
            get {
                return ResourceManager.GetString("DerivedTypeNotExpected", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The directed message&apos;s Recipient property must not be null..
        /// </summary>
        internal static string DirectedMessageMissingRecipient {
            get {
                return ResourceManager.GetString("DirectedMessageMissingRecipient", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error occurred while sending a direct message or gettings the response..
        /// </summary>
        internal static string ErrorInRequestReplyMessage {
            get {
                return ResourceManager.GetString("ErrorInRequestReplyMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This exception was not constructed with a root request message that caused it..
        /// </summary>
        internal static string ExceptionNotConstructedForTransit {
            get {
                return ResourceManager.GetString("ExceptionNotConstructedForTransit", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This method requires a current HttpContext.  Alternatively, use an overload of this method that allows you to pass in information without an HttpContext..
        /// </summary>
        internal static string HttpContextRequired {
            get {
                return ResourceManager.GetString("HttpContextRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Messages that indicate indirect transport must implement the {0} interface..
        /// </summary>
        internal static string IndirectMessagesMustImplementIDirectedProtocolMessage {
            get {
                return ResourceManager.GetString("IndirectMessagesMustImplementIDirectedProtocolMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A message response is already queued for sending in the response stream..
        /// </summary>
        internal static string QueuedMessageResponseAlreadyExists {
            get {
                return ResourceManager.GetString("QueuedMessageResponseAlreadyExists", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The type {0} or a derived type was expected, but {1} was given..
        /// </summary>
        internal static string UnexpectedType {
            get {
                return ResourceManager.GetString("UnexpectedType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} property has unrecognized value {1}..
        /// </summary>
        internal static string UnrecognizedEnumValue {
            get {
                return ResourceManager.GetString("UnrecognizedEnumValue", resourceCulture);
            }
        }
    }
}
