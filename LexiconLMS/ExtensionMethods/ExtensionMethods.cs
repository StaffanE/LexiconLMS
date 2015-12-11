using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace LexiconLMS{
    public static class ExtensionMethods
    {

        public static string DisplayFor(this Enum value)
        {
            Type enumType = value.GetType();
            var enumValue = Enum.GetName(enumType, value);
            var member = enumType.GetMember(enumValue)[0];
            string outString = "";
            var attrs = member.GetCustomAttributes(typeof(DisplayAttribute), false);
            if (attrs.Any())
            {
                var displayAttr = ((DisplayAttribute)attrs[0]);

                outString = displayAttr.Name;

                if (displayAttr.ResourceType != null)
                {
                    outString = displayAttr.GetName();
                }
            }
            else
            {
                outString = value.ToString();
            }

            return outString;
        }

        //---------------------------------------------------------------------------------------------------------
        // Compare startdate and enddate against current date to see if this is past/current or future periods
        // return different backgroundcolors depending on period type
        //---------------------------------------------------------------------------------------------------------
        public static string trColor(DateTime? Starttime, DateTime? Endtime)
        {
            var ThisMoment = DateTime.Now;
            var StartBeforeNow = ThisMoment.CompareTo(Starttime);
            var EndAfterNow = ThisMoment.CompareTo(Endtime);
            switch ((StartBeforeNow + EndAfterNow))
            {
                // Period ended Endtime lower than actual datetime
                case 0:
                    return "background:rgba(65,173,73,0.5);";            
                // Todaysdate lower than startdat(and enddate) = future period
                case -2:
                    return "background:rgba(245,121,32,0.5);";
                // Todaysdate in current tested period
                default:
                    return "background:rgba(247,247,247,0.5);";
            }
        }
        //---------------------------------------------------------------------------------------------------------
        // Compare startdate and enddate against current date to see if this is past/current or future periods
        // return different backgroundcolors depending on period type
        //---------------------------------------------------------------------------------------------------------
        public static string trTextColor(DateTime? Starttime, DateTime? Endtime)
        {
            var ThisMoment = DateTime.Now;
            var StartBeforeNow = ThisMoment.CompareTo(Starttime);
            var EndAfterNow = ThisMoment.CompareTo(Endtime);
            switch ((StartBeforeNow + EndAfterNow)) {
                // Period ended Endtime lower than actual datetime
                case 0:
                    return "color:rgb(0,0,0);";
                // Todaysdate lower than startdat(and enddate) = future period
                case -2:
                    return "color:rgb(245,121,32);";
                // Todaysdate in current tested period
                default:
                    return "color:rgb(247,247,247);";                    
            }
        }
        public static string PeriodStatus(DateTime? Starttime, DateTime? Endtime) {
            var ThisMoment = DateTime.Now;
            var StartBeforeNow = ThisMoment.CompareTo(Starttime);
            var EndAfterNow = ThisMoment.CompareTo(Endtime);
            switch ((StartBeforeNow + EndAfterNow)) {
                // Period ended Endtime lower than actual datetime
                case 0:
                    return "Pågående"; 
                // Todaysdate lower than startdat(and enddate) = future period
                case -2:
                    return "Kommande";
                // Todaysdate in current tested period
                default:
                    return "Avslutad";
            }
        }
        public static string trColorGrayWhite(int testnum) 
        {
            if ((testnum % 2 !=0)) 
            {
                return "background:#ffffff";
            };
            return "background:#f2f2f2;";
        }
    }
}
