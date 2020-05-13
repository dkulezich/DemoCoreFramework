using System;
using System.Collections.Generic;

namespace UIFramework.Configuration
{
    public class UiFrameworkSection
    {
        public string DriverType { get; set; }
        public IDictionary<string, string> Capabilities { get; set; }
        public TimeSpan DefaultWait { get; set; } = TimeSpan.FromSeconds(60);
    }
}