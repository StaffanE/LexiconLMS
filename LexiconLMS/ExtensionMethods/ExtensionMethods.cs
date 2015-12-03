using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace LexiconLMS.ExtensionMethods {
    public static class ExtensionMethods {

        public static string DisplayFor(this Enum value) {
            Type enumType = value.GetType();
            var enumValue = Enum.GetName(enumType, value);
            var member = enumType.GetMember(enumValue)[0];
            string outString = "";
            var attrs = member.GetCustomAttributes(typeof(DisplayAttribute), false);
            if (attrs.Any()) {
                var displayAttr = ((DisplayAttribute)attrs[0]);

                outString = displayAttr.Name;

                if (displayAttr.ResourceType != null) {
                    outString = displayAttr.GetName();
                }
            }
            else {
                outString = value.ToString();
            }

            return outString;
        }
    }
    public static class EnumHelper {
        /// <summary>
        /// Gets an attribute on an enum field value
        /// </summary>
        /// <typeparam name="T">The type of the attribute you want to retrieve</typeparam>
        /// <param name="enumVal">The enum value</param>
        /// <returns>The attribute of type T that exists on the enum value</returns>
        /// <example>string desc = myEnumVariable.GetAttributeOfType<DescriptionAttribute>().Description;</example>
        public static T GetAttributeOfType<T>(this Enum enumVal) where T : System.Attribute {
            var type = enumVal.GetType();
            var memInfo = type.GetMember(enumVal.ToString());
            var attributes = memInfo[0].GetCustomAttributes(typeof(T), false);
            return (attributes.Length > 0) ? (T)attributes[0] : null;
        }
    }
}
