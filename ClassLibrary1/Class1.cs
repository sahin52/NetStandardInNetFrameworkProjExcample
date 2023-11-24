using System;
using System.Diagnostics;

namespace ClassLibrary1
{
public class Class1
{
public static void LogTest()
{
        if (!EventLog.SourceExists(System.AppDomain.CurrentDomain.FriendlyName))
            EventLog.CreateEventSource(System.AppDomain.CurrentDomain.FriendlyName, "Application");
}
}
}
