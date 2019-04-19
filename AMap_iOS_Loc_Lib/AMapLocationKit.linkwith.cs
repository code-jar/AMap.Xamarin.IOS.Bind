using System;
using ObjCRuntime;

[assembly: LinkWith("AMapLocationKit.a", LinkTarget.ArmV7 | LinkTarget.Simulator | LinkTarget.i386 | LinkTarget.x86_64 | LinkTarget.Arm64, SmartLink = true, ForceLoad = true)]
