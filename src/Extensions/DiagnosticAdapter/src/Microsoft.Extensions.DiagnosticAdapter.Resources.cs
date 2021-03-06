// <auto-generated>
using System.Reflection;


namespace Microsoft.Extensions.DiagnosticAdapter
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

        /// <summary>The property '{0}' on type '{1}' must define a getter to support proxy generation.</summary>
        internal static string Converter_PropertyMustHaveGetter => GetResourceString("Converter_PropertyMustHaveGetter");
        /// <summary>The property '{0}' on type '{1}' must define a getter to support proxy generation.</summary>
        internal static string FormatConverter_PropertyMustHaveGetter(object p0, object p1)
           => string.Format(Culture, GetResourceString("Converter_PropertyMustHaveGetter"), p0, p1);

        /// <summary>The property '{0}' on type '{1}' must not use index parameters to support proxy generation.</summary>
        internal static string Converter_PropertyMustNotHaveIndexParameters => GetResourceString("Converter_PropertyMustNotHaveIndexParameters");
        /// <summary>The property '{0}' on type '{1}' must not use index parameters to support proxy generation.</summary>
        internal static string FormatConverter_PropertyMustNotHaveIndexParameters(object p0, object p1)
           => string.Format(Culture, GetResourceString("Converter_PropertyMustNotHaveIndexParameters"), p0, p1);

        /// <summary>The property '{0}' on type '{1}' must not define a setter to support proxy generation.</summary>
        internal static string Converter_PropertyMustNotHaveSetter => GetResourceString("Converter_PropertyMustNotHaveSetter");
        /// <summary>The property '{0}' on type '{1}' must not define a setter to support proxy generation.</summary>
        internal static string FormatConverter_PropertyMustNotHaveSetter(object p0, object p1)
           => string.Format(Culture, GetResourceString("Converter_PropertyMustNotHaveSetter"), p0, p1);

        /// <summary>Type '{0}' must be an interface in order to support proxy generation from source type '{1}'.</summary>
        internal static string Converter_TypeMustBeInterface => GetResourceString("Converter_TypeMustBeInterface");
        /// <summary>Type '{0}' must be an interface in order to support proxy generation from source type '{1}'.</summary>
        internal static string FormatConverter_TypeMustBeInterface(object p0, object p1)
           => string.Format(Culture, GetResourceString("Converter_TypeMustBeInterface"), p0, p1);

        /// <summary>Proxy method generation doesn't support types with properties that vary only by case. The type '{0}' defines multiple properties named '{1}' that vary only by case.</summary>
        internal static string Converter_TypeMustNotHavePropertiesThatVaryByCase => GetResourceString("Converter_TypeMustNotHavePropertiesThatVaryByCase");
        /// <summary>Proxy method generation doesn't support types with properties that vary only by case. The type '{0}' defines multiple properties named '{1}' that vary only by case.</summary>
        internal static string FormatConverter_TypeMustNotHavePropertiesThatVaryByCase(object p0, object p1)
           => string.Format(Culture, GetResourceString("Converter_TypeMustNotHavePropertiesThatVaryByCase"), p0, p1);

        /// <summary>Unable to generate a proxy for method '{0}'. See Inner Exception for details.</summary>
        internal static string Converter_UnableToGenerateProxy => GetResourceString("Converter_UnableToGenerateProxy");
        /// <summary>Unable to generate a proxy for method '{0}'. See Inner Exception for details.</summary>
        internal static string FormatConverter_UnableToGenerateProxy(object p0)
           => string.Format(Culture, GetResourceString("Converter_UnableToGenerateProxy"), p0);


    }
}
