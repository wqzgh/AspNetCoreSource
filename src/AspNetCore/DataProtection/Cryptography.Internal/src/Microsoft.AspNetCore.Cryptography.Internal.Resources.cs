// <auto-generated>
using System.Reflection;


namespace Microsoft.AspNetCore.Cryptography.Internal
{
    internal static partial class Resources
    {
        private static global::System.Resources.ResourceManager s_resourceManager;
        internal static global::System.Resources.ResourceManager ResourceManager => s_resourceManager ?? (s_resourceManager = new global::System.Resources.ResourceManager(typeof(Resources)));
        internal static global::System.Globalization.CultureInfo Culture { get; set; }

        [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        internal static string GetResourceString(string resourceKey, string defaultValue = null) =>  ResourceManager.GetString(resourceKey, Culture);

        private static string GetResourceString(string resourceKey, string[] formatterNames)
        {
           var value = GetResourceString(resourceKey);
           if (formatterNames != null)
           {
               for (var i = 0; i < formatterNames.Length; i++)
               {
                   value = value.Replace("{" + formatterNames[i] + "}", "{" + i + "}");
               }
           }
           return value;
        }

        /// <summary>A provider could not be found for algorithm '{0}'.</summary>
        internal static string BCryptAlgorithmHandle_ProviderNotFound => GetResourceString("BCryptAlgorithmHandle_ProviderNotFound");
        /// <summary>A provider could not be found for algorithm '{0}'.</summary>
        internal static string FormatBCryptAlgorithmHandle_ProviderNotFound(object p0)
           => string.Format(Culture, GetResourceString("BCryptAlgorithmHandle_ProviderNotFound"), p0);

        /// <summary>The key length {0} is invalid. Valid key lengths are {1} to {2} bits (step size {3}).</summary>
        internal static string BCRYPT_KEY_LENGTHS_STRUCT_InvalidKeyLength => GetResourceString("BCRYPT_KEY_LENGTHS_STRUCT_InvalidKeyLength");
        /// <summary>The key length {0} is invalid. Valid key lengths are {1} to {2} bits (step size {3}).</summary>
        internal static string FormatBCRYPT_KEY_LENGTHS_STRUCT_InvalidKeyLength(object p0, object p1, object p2, object p3)
           => string.Format(Culture, GetResourceString("BCRYPT_KEY_LENGTHS_STRUCT_InvalidKeyLength"), p0, p1, p2, p3);

        /// <summary>This operation requires Windows 7 / Windows Server 2008 R2 or later.</summary>
        internal static string Platform_Windows7Required => GetResourceString("Platform_Windows7Required");
        /// <summary>This operation requires Windows 8 / Windows Server 2012 or later.</summary>
        internal static string Platform_Windows8Required => GetResourceString("Platform_Windows8Required");

    }
}
