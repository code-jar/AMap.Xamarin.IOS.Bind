using System;
using ObjCRuntime;

[assembly: LinkWith("AMapLocationKit.a", LinkTarget.ArmV7 | LinkTarget.Simulator, SmartLink = true, ForceLoad = true)]
