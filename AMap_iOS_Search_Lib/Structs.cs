using System;
using ObjCRuntime;

namespace AMapSearchKit
{
    [Native]
    public enum AMapRoutePOISearchType : long
    {
        GasStation = 0,
        MaintenanceStation = 1,
        Atm = 2,
        Toilet = 3,
        GasAirStation = 4,
        ParkStation = 5
    }

    [Native]
    public enum AMapWeatherType : long
    {
        Live = 1,
        Forecast
    }

    [Native]
    public enum AMapCloudSortType : long
    {
        Desc = 0,
        Asc = 1
    }

    [Native]
    public enum AMapNearbySearchType : long
    {
        Liner = 0,
        Driving = 1
    }

    [Native]
    public enum AMapTruckSizeType : long
    {
        Mini = 1,
        Light = 2,
        Medium = 3,
        Heavy = 4
    }

    [Native]
    public enum AMapSearchLanguage : long
    {
        ZhCN = 0,
        En = 1
    }

    [Native]
    public enum AMapSearchErrorCode : long
    {
        Ok = 1000,
        InvalidSignature = 1001,
        InvalidUserKey = 1002,
        ServiceNotAvailable = 1003,
        DailyQueryOverLimit = 1004,
        TooFrequently = 1005,
        InvalidUserIP = 1006,
        InvalidUserDomain = 1007,
        InvalidUserSCode = 1008,
        UserKeyNotMatch = 1009,
        IPQueryOverLimit = 1010,
        NotSupportHttps = 1011,
        InsufficientPrivileges = 1012,
        UserKeyRecycled = 1013,
        InvalidResponse = 1100,
        InvalidEngineData = 1101,
        ConnectTimeout = 1102,
        ReturnTimeout = 1103,
        InvalidParams = 1200,
        MissingRequiredParams = 1201,
        IllegalRequest = 1202,
        ServiceUnknown = 1203,
        ClientUnknown = 1800,
        InvalidProtocol = 1801,
        TimeOut = 1802,
        BadURL = 1803,
        CannotFindHost = 1804,
        CannotConnectToHost = 1805,
        NotConnectedToInternet = 1806,
        Cancelled = 1807,
        TableIDNotExist = 2000,
        IDNotExist = 2001,
        ServiceMaintenance = 2002,
        EngineTableIDNotExist = 2003,
        InvalidNearbyUserID = 2100,
        NearbyKeyNotBind = 2101,
        OutOfService = 3000,
        NoRoadsNearby = 3001,
        RouteFailed = 3002,
        OverDirectionRange = 3003,
        ShareLicenseExpired = 4000,
        ShareFailed = 4001
    }

    [Native]
    public enum AMapSearchCoordinateType : long
    {
        Gps = 1,
        AMap = 2
    }
}
