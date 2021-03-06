﻿using System;
using System.Runtime.InteropServices;
using AMapLocationKit;
using CoreLocation;
using ObjCRuntime;

namespace AMapLocationKit
{
    [Native]
    public enum AMapLocationErrorCode : long
    {
        Unknown = 1,
        LocateFailed = 2,
        ReGeocodeFailed = 3,
        TimeOut = 4,
        Canceled = 5,
        CannotFindHost = 6,
        BadURL = 7,
        NotConnectedToInternet = 8,
        CannotConnectToHost = 9,
        RegionMonitoringFailure = 10,
        RiskOfFakeLocation = 11
    }

    [Native]
    public enum AMapLocationRegionState : long
    {
        Unknow = 0,
        Inside = 1,
        Outside = 2
    }

    [Native]
    public enum AMapLocationReGeocodeLanguage : long
    {
        Default = 0,
        Chinse = 1,
        English = 2
    }

    [Native]
    public enum AMapLocationCoordinateType : long
    {
        Baidu = 0,
        MapBar,
        MapABC,
        SoSoMap,
        AliYun,
        Google,
        Gps
    }

    static class CFunctions
    {
        // extern CLLocationCoordinate2D AMapLocationCoordinateConvert (CLLocationCoordinate2D coordinate, AMapLocationCoordinateType type);
        [DllImport("__Internal")]
        //[Verify(PlatformInvoke)]
        static extern CLLocationCoordinate2D AMapLocationCoordinateConvert(CLLocationCoordinate2D coordinate, AMapLocationCoordinateType type);

        // extern BOOL AMapLocationDataAvailableForCoordinate (CLLocationCoordinate2D coordinate);
        [DllImport("__Internal")]
        //[Verify(PlatformInvoke)]
        static extern bool AMapLocationDataAvailableForCoordinate(CLLocationCoordinate2D coordinate);
    }

    [Native]
    public enum AMapGeoFenceRegionStatus : long
    {
        Unknown = 0,
        Inside = 1,
        Outside = 2,
        Stayed = 3
    }

    [Native]
    public enum AMapGeoFenceRegionType : long
    {
        Circle = 0,
        Polygon = 1,
        Poi = 2,
        District = 3
    }

    [Native]
    public enum AMapGeoFenceActiveAction : long
    {
        None = 0,
        Inside = 1 << 0,
        Outside = 1 << 1,
        Stayed = 1 << 2
    }

    [Native]
    public enum AMapGeoFenceRegionActiveStatus : long
    {
        UNMonitor = 0,
        Monitoring = 1 << 0,
        Paused = 1 << 1
    }

    [Native]
    public enum AMapGeoFenceErrorCode : long
    {
        rUnknown = 1,
        rInvalidParameter = 2,
        rFailureConnection = 3,
        rFailureAuth = 4,
        rNoValidFence = 5,
        FailureLocating = 6
    }
}
