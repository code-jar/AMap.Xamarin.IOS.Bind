﻿using System;
using System.Runtime.InteropServices;
using CoreLocation;
using Foundation;
using MAMapKit;
using ObjCRuntime;

namespace MAMapKit
{
    [StructLayout(LayoutKind.Sequential)]
    public struct MACoordinateBounds
    {
        public CLLocationCoordinate2D northEast;

        public CLLocationCoordinate2D southWest;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct MACoordinateSpan
    {
        public double latitudeDelta;

        public double longitudeDelta;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct MACoordinateRegion
    {
        public CLLocationCoordinate2D center;

        public MACoordinateSpan span;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct MAMapPoint
    {
        public double x;

        public double y;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct MAMapSize
    {
        public double width;

        public double height;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct MAMapRect
    {
        public MAMapPoint origin;

        public MAMapSize size;
    }

    // typedef void (^AMapTileProjectionBlock)(int, int, int, int, int, int);
    delegate void AMapTileProjectionBlock(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5);

    static class CFunctions
    {
        // MACoordinateBounds MACoordinateBoundsMake (CLLocationCoordinate2D northEast, CLLocationCoordinate2D southWest);
        [DllImport("__Internal")]
        //[Verify(PlatformInvoke)]
        static extern MACoordinateBounds MACoordinateBoundsMake(CLLocationCoordinate2D northEast, CLLocationCoordinate2D southWest);

        // MACoordinateSpan MACoordinateSpanMake (CLLocationDegrees latitudeDelta, CLLocationDegrees longitudeDelta);
        [DllImport("__Internal")]
        //[Verify(PlatformInvoke)]
        static extern MACoordinateSpan MACoordinateSpanMake(double latitudeDelta, double longitudeDelta);

        // MACoordinateRegion MACoordinateRegionMake (CLLocationCoordinate2D centerCoordinate, MACoordinateSpan span);
        [DllImport("__Internal")]
        //[Verify(PlatformInvoke)]
        static extern MACoordinateRegion MACoordinateRegionMake(CLLocationCoordinate2D centerCoordinate, MACoordinateSpan span);

        // extern MACoordinateRegion MACoordinateRegionMakeWithDistance (CLLocationCoordinate2D centerCoordinate, CLLocationDistance latitudinalMeters, CLLocationDistance longitudinalMeters);
        [DllImport("__Internal")]
        //[Verify(PlatformInvoke)]
        static extern MACoordinateRegion MACoordinateRegionMakeWithDistance(CLLocationCoordinate2D centerCoordinate, double latitudinalMeters, double longitudinalMeters);

        // extern MAMapPoint MAMapPointForCoordinate (CLLocationCoordinate2D coordinate);
        [DllImport("__Internal")]
        //[Verify(PlatformInvoke)]
        static extern MAMapPoint MAMapPointForCoordinate(CLLocationCoordinate2D coordinate);

        // extern CLLocationCoordinate2D MACoordinateForMapPoint (MAMapPoint mapPoint);
        [DllImport("__Internal")]
        //[Verify(PlatformInvoke)]
        static extern CLLocationCoordinate2D MACoordinateForMapPoint(MAMapPoint mapPoint);

        // extern MACoordinateRegion MACoordinateRegionForMapRect (MAMapRect rect);
        [DllImport("__Internal")]
        //[Verify(PlatformInvoke)]
        static extern MACoordinateRegion MACoordinateRegionForMapRect(MAMapRect rect);

        // extern MAMapRect MAMapRectForCoordinateRegion (MACoordinateRegion region);
        [DllImport("__Internal")]
        //[Verify(PlatformInvoke)]
        static extern MAMapRect MAMapRectForCoordinateRegion(MACoordinateRegion region);

        // extern CLLocationDistance MAMetersPerMapPointAtLatitude (CLLocationDegrees latitude);
        [DllImport("__Internal")]
        //[Verify(PlatformInvoke)]
        static extern double MAMetersPerMapPointAtLatitude(double latitude);

        // extern double MAMapPointsPerMeterAtLatitude (CLLocationDegrees latitude);
        [DllImport("__Internal")]
        //[Verify(PlatformInvoke)]
        static extern double MAMapPointsPerMeterAtLatitude(double latitude);

        // extern CLLocationDistance MAMetersBetweenMapPoints (MAMapPoint a, MAMapPoint b);
        [DllImport("__Internal")]
        //[Verify(PlatformInvoke)]
        static extern double MAMetersBetweenMapPoints(MAMapPoint a, MAMapPoint b);

        // extern double MAAreaBetweenCoordinates (CLLocationCoordinate2D northEast, CLLocationCoordinate2D southWest);
        [DllImport("__Internal")]
        //[Verify(PlatformInvoke)]
        static extern double MAAreaBetweenCoordinates(CLLocationCoordinate2D northEast, CLLocationCoordinate2D southWest);

        // extern MAMapRect MAMapRectInset (MAMapRect rect, double dx, double dy);
        [DllImport("__Internal")]
        //[Verify(PlatformInvoke)]
        static extern MAMapRect MAMapRectInset(MAMapRect rect, double dx, double dy);

        // extern MAMapRect MAMapRectUnion (MAMapRect rect1, MAMapRect rect2);
        [DllImport("__Internal")]
        //[Verify(PlatformInvoke)]
        static extern MAMapRect MAMapRectUnion(MAMapRect rect1, MAMapRect rect2);

        // extern BOOL MAMapSizeContainsSize (MAMapSize size1, MAMapSize size2);
        [DllImport("__Internal")]
        //[Verify(PlatformInvoke)]
        static extern bool MAMapSizeContainsSize(MAMapSize size1, MAMapSize size2);

        // extern BOOL MAMapRectContainsPoint (MAMapRect rect, MAMapPoint point);
        [DllImport("__Internal")]
        //[Verify(PlatformInvoke)]
        static extern bool MAMapRectContainsPoint(MAMapRect rect, MAMapPoint point);

        // extern BOOL MAMapRectIntersectsRect (MAMapRect rect1, MAMapRect rect2);
        [DllImport("__Internal")]
        //[Verify(PlatformInvoke)]
        static extern bool MAMapRectIntersectsRect(MAMapRect rect1, MAMapRect rect2);

        // extern BOOL MAMapRectContainsRect (MAMapRect rect1, MAMapRect rect2);
        [DllImport("__Internal")]
        //[Verify(PlatformInvoke)]
        static extern bool MAMapRectContainsRect(MAMapRect rect1, MAMapRect rect2);

        // extern BOOL MACircleContainsPoint (MAMapPoint point, MAMapPoint center, double radius);
        [DllImport("__Internal")]
        //[Verify(PlatformInvoke)]
        static extern bool MACircleContainsPoint(MAMapPoint point, MAMapPoint center, double radius);

        // extern BOOL MACircleContainsCoordinate (CLLocationCoordinate2D point, CLLocationCoordinate2D center, double radius);
        [DllImport("__Internal")]
        //[Verify(PlatformInvoke)]
        static extern bool MACircleContainsCoordinate(CLLocationCoordinate2D point, CLLocationCoordinate2D center, double radius);

        // extern BOOL MAPolygonContainsPoint (MAMapPoint point, MAMapPoint *polygon, NSUInteger count);
        [DllImport("__Internal")]
        //[Verify(PlatformInvoke)]
        static extern unsafe bool MAPolygonContainsPoint(MAMapPoint point, MAMapPoint polygon, int count);

        // extern BOOL MAPolygonContainsCoordinate (CLLocationCoordinate2D point, CLLocationCoordinate2D *polygon, NSUInteger count);
        [DllImport("__Internal")]
        //[Verify(PlatformInvoke)]
        static extern unsafe bool MAPolygonContainsCoordinate(CLLocationCoordinate2D point, CLLocationCoordinate2D polygon, int count);

        // extern MAMapPoint MAGetNearestMapPointFromLine (MAMapPoint lineStart, MAMapPoint lineEnd, MAMapPoint point);
        [DllImport("__Internal")]
        //[Verify(PlatformInvoke)]
        static extern MAMapPoint MAGetNearestMapPointFromLine(MAMapPoint lineStart, MAMapPoint lineEnd, MAMapPoint point);

        // extern void MAGetTileProjectionFromBounds (MACoordinateBounds bounds, int levelOfDetails, AMapTileProjectionBlock tileProjection);
        [DllImport("__Internal")]
        //[Verify(PlatformInvoke)]
        static extern void MAGetTileProjectionFromBounds(MACoordinateBounds bounds, int levelOfDetails, AMapTileProjectionBlock tileProjection);

        // extern double MAAreaForPolygon (CLLocationCoordinate2D *coordinates, int count);
        [DllImport("__Internal")]
        //[Verify(PlatformInvoke)]
        static extern unsafe double MAAreaForPolygon(CLLocationCoordinate2D coordinates, int count);

        // MAMapPoint MAMapPointMake (double x, double y);
        [DllImport("__Internal")]
        //[Verify(PlatformInvoke)]
        static extern MAMapPoint MAMapPointMake(double x, double y);

        // MAMapSize MAMapSizeMake (double width, double height);
        [DllImport("__Internal")]
        //[Verify(PlatformInvoke)]
        static extern MAMapSize MAMapSizeMake(double width, double height);

        // MAMapRect MAMapRectMake (double x, double y, double width, double height);
        [DllImport("__Internal")]
        //[Verify(PlatformInvoke)]
        static extern MAMapRect MAMapRectMake(double x, double y, double width, double height);

        // double MAMapRectGetMinX (MAMapRect rect);
        [DllImport("__Internal")]
        //[Verify(PlatformInvoke)]
        static extern double MAMapRectGetMinX(MAMapRect rect);

        // double MAMapRectGetMinY (MAMapRect rect);
        [DllImport("__Internal")]
        //[Verify(PlatformInvoke)]
        static extern double MAMapRectGetMinY(MAMapRect rect);

        // double MAMapRectGetMidX (MAMapRect rect);
        [DllImport("__Internal")]
        //[Verify(PlatformInvoke)]
        static extern double MAMapRectGetMidX(MAMapRect rect);

        // double MAMapRectGetMidY (MAMapRect rect);
        [DllImport("__Internal")]
        //[Verify(PlatformInvoke)]
        static extern double MAMapRectGetMidY(MAMapRect rect);

        // double MAMapRectGetMaxX (MAMapRect rect);
        [DllImport("__Internal")]
        //[Verify(PlatformInvoke)]
        static extern double MAMapRectGetMaxX(MAMapRect rect);

        // double MAMapRectGetMaxY (MAMapRect rect);
        [DllImport("__Internal")]
        //[Verify(PlatformInvoke)]
        static extern double MAMapRectGetMaxY(MAMapRect rect);

        // double MAMapRectGetWidth (MAMapRect rect);
        [DllImport("__Internal")]
        //[Verify(PlatformInvoke)]
        static extern double MAMapRectGetWidth(MAMapRect rect);

        // double MAMapRectGetHeight (MAMapRect rect);
        [DllImport("__Internal")]
        //[Verify(PlatformInvoke)]
        static extern double MAMapRectGetHeight(MAMapRect rect);

        // BOOL MAMapPointEqualToPoint (MAMapPoint point1, MAMapPoint point2);
        [DllImport("__Internal")]
        //[Verify(PlatformInvoke)]
        static extern bool MAMapPointEqualToPoint(MAMapPoint point1, MAMapPoint point2);

        // BOOL MAMapSizeEqualToSize (MAMapSize size1, MAMapSize size2);
        [DllImport("__Internal")]
        //[Verify(PlatformInvoke)]
        static extern bool MAMapSizeEqualToSize(MAMapSize size1, MAMapSize size2);

        // BOOL MAMapRectEqualToRect (MAMapRect rect1, MAMapRect rect2);
        [DllImport("__Internal")]
        //[Verify(PlatformInvoke)]
        static extern bool MAMapRectEqualToRect(MAMapRect rect1, MAMapRect rect2);

        // BOOL MAMapRectIsNull (MAMapRect rect);
        [DllImport("__Internal")]
        //[Verify(PlatformInvoke)]
        static extern bool MAMapRectIsNull(MAMapRect rect);

        // BOOL MAMapRectIsEmpty (MAMapRect rect);
        [DllImport("__Internal")]
        //[Verify(PlatformInvoke)]
        static extern bool MAMapRectIsEmpty(MAMapRect rect);

        // NSString * MAStringFromMapPoint (MAMapPoint point);
        [DllImport("__Internal")]
        //[Verify(PlatformInvoke)]
        static extern NSString MAStringFromMapPoint(MAMapPoint point);

        // NSString * MAStringFromMapSize (MAMapSize size);
        [DllImport("__Internal")]
        //[Verify(PlatformInvoke)]
        static extern NSString MAStringFromMapSize(MAMapSize size);

        // NSString * MAStringFromMapRect (MAMapRect rect);
        [DllImport("__Internal")]
        //[Verify(PlatformInvoke)]
        static extern NSString MAStringFromMapRect(MAMapRect rect);

        // extern CLLocationCoordinate2D MACoordinateConvert (CLLocationCoordinate2D coordinate, MACoordinateType type) __attribute__((deprecated("已废弃，使用AMapFoundation中关于坐标转换的接口")));
        [DllImport("__Internal")]
        //[Verify(PlatformInvoke)]
        static extern CLLocationCoordinate2D MACoordinateConvert(CLLocationCoordinate2D coordinate, MACoordinateType type);

        // extern CLLocationDirection MAGetDirectionFromCoords (CLLocationCoordinate2D fromCoord, CLLocationCoordinate2D toCoord);
        [DllImport("__Internal")]
        //[Verify(PlatformInvoke)]
        static extern double MAGetDirectionFromCoords(CLLocationCoordinate2D fromCoord, CLLocationCoordinate2D toCoord);

        // extern CLLocationDirection MAGetDirectionFromPoints (MAMapPoint fromPoint, MAMapPoint toPoint);
        [DllImport("__Internal")]
        //[Verify(PlatformInvoke)]
        static extern double MAGetDirectionFromPoints(MAMapPoint fromPoint, MAMapPoint toPoint);

        // extern double MAGetDistanceFromPointToLine (MAMapPoint point, MAMapPoint lineBegin, MAMapPoint lineEnd);
        [DllImport("__Internal")]
        //[Verify(PlatformInvoke)]
        static extern double MAGetDistanceFromPointToLine(MAMapPoint point, MAMapPoint lineBegin, MAMapPoint lineEnd);
    }

    [Native]
    public enum MACoordinateType : long
    {
        Baidu = 0,
        MapBar,
        MapABC,
        SoSoMap,
        AliYun,
        Google,
        Gps
    }

    public enum MALineJoinType : long
    {
        Bevel,
        Miter,
        Round
    }

    public enum MALineCapType : long
    {
        Butt,
        Square,
        Arrow,
        Round
    }

    [Native]
    public enum MALineDashType : long
    {
        None = 0,
        Square,
        Dot
    }

    [Native]
    public enum MAAnnotationViewDragState : long
    {
        None = 0,
        Starting,
        Dragging,
        Canceling,
        Ending
    }

    [Native]
    public enum MAMapLanguage : long
    {
        ZhCN = 0,
        En = 1,
    }

    [Native]
    public enum MAMapType : long
    {
        Standard = 0,
        Satellite,
        StandardNight,
        Navi,
        Bus
    }

    [Native]
    public enum MAUserTrackingMode : long
    {
        None = 0,
        Follow = 1,
        FollowWithHeading = 2
    }

    [Native]
    public enum MATrafficStatus : long
    {
        Smooth = 1,
        Slow,
        Jam,
        SeriousJam
    }

    [Native]
    public enum MAOverlayLevel : long
    {
        Roads = 0,
        Labels
    }

    [Native]
    public enum MAPinAnnotationColor : long
    {
        Red = 0,
        Green,
        Purple
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct MATileOverlayPath
    {
        public nint x;

        public nint y;

        public nint z;

        public nfloat contentScaleFactor;
    }

    [Native]
    public enum MAParticleOverlayType : long
    {
        Sunny = 1,
        Rain,
        Snowy,
        Haze
    }

    [Native]
    public enum MAOfflineItemStatus : long
    {
        None = 0,
        Cached,
        Installed,
        Expired
    }

    public enum MAOfflineCityStatus : long
    {
        None = MAOfflineItemStatus.None,
        Cached = MAOfflineItemStatus.Cached,
        Installed = MAOfflineItemStatus.Installed,
        Expired = MAOfflineItemStatus.Expired
    }

    [Native]
    public enum MAOfflineMapDownloadStatus : long
    {
        Waiting = 0,
        Start,
        Progress,
        Completed,
        Cancelled,
        Unzip,
        Finished,
        Error
    }

    [Native]
    public enum MAOfflineMapError : long
    {
        Unknown = -1,
        CannotWriteToTmp = -2,
        CannotOpenZipFile = -3,
        CannotExpand = -4
    }
}
