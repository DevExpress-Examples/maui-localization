using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using DevExpress.Maui.Core.Internal;

namespace LocalizeApplication.Model
{
    public class CallData {
        Color contactColor = DXColor.Default;
        public string ContactDisplay => String.Format("{0} ({1})", ContactName, ContactPhone);
        public string ContactAvatarText => ContactName.Substring(0, 1);
        public string ContactName { get; set; }
        public string ContactPhone { get; set; }
        public DateTime CallDate { get; set; }
        public string NumberType { get; set; }
        public CallTypes CallType { get; set; }
        public Color ContactColor { get; set; }
    }

    public enum NumberTypes {
        Mobile,
        Home,
        Work,
        Unknown
    }

    public enum CallTypes
    {
        Incoming,
        Outgoing
    }
}