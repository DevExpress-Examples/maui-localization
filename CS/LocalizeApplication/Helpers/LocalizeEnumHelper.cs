using System;
using LocalizeApplication.Resources.Localization;
using LocalizeApplication.Model;
using System.Reflection;
using System.Data;

namespace LocalizeApplication.Helpers
{
    public static class LocalizeEnumHelper
    {
        public static string GetLocalizedString(NumberTypes numbertype)
        {
            switch (numbertype)
            {
                case NumberTypes.Mobile: return Resources.Localization.ApplicationStrings.NumberType_Mobile;
                case NumberTypes.Home: return Resources.Localization.ApplicationStrings.NumberType_Home;
                case NumberTypes.Work: return Resources.Localization.ApplicationStrings.NumberType_Work;
                case NumberTypes.Unknown: return Resources.Localization.ApplicationStrings.NumberType_Unknown;

                default: throw new ArgumentOutOfRangeException("numbertype");
            }
        }
        public static string GetIcon(CallTypes calltype)
        {
            switch (calltype)
            {
                case CallTypes.Incoming: return "→";
                case CallTypes.Outgoing: return "←";

                default: throw new ArgumentOutOfRangeException("numbertype");
            }
        }
    }
}

