﻿using AMapFoundationKit;
using CoreLocation;
using Foundation;
using ObjCRuntime;

namespace AMapFoundationKit
{
    [Static]
    //[Verify(ConstantsInterfaceAssociation)]
    partial interface Constants
    {
        // extern NSString *const AMapFoundationVersion;
        [Field("AMapFoundationVersion", "__Internal")]
        NSString AMapFoundationVersion { get; }

        // extern NSString *const AMapFoundationName;
        [Field("AMapFoundationName", "__Internal")]
        NSString AMapFoundationName { get; }
    }

    // @interface AMapServices : NSObject
    [BaseType(typeof(NSObject))]
    interface AMapServices
    {
        // +(AMapServices *)sharedServices;
        [Static]
        [Export("sharedServices")]
        //[Verify(MethodToProperty)]
        AMapServices SharedServices { get; }

        // @property (copy, nonatomic) NSString * apiKey;
        [Export("apiKey")]
        string ApiKey { get; set; }

        // @property (assign, nonatomic) BOOL enableHTTPS;
        [Export("enableHTTPS")]
        bool EnableHTTPS { get; set; }

        // @property (assign, nonatomic) BOOL crashReportEnabled;
        [Export("crashReportEnabled")]
        bool CrashReportEnabled { get; set; }

        // @property (readonly, nonatomic) NSString * identifier;
        [Export("identifier")]
        string Identifier { get; }
    }

    // @interface AMapNaviConfig : NSObject
    [BaseType(typeof(NSObject))]
    interface AMapNaviConfig
    {
        // @property (copy, nonatomic) NSString * appScheme;
        [Export("appScheme")]
        string AppScheme { get; set; }

        // @property (copy, nonatomic) NSString * appName;
        [Export("appName")]
        string AppName { get; set; }

        // @property (assign, nonatomic) CLLocationCoordinate2D destination;
        [Export("destination", ArgumentSemantic.Assign)]
        CLLocationCoordinate2D Destination { get; set; }

        // @property (assign, nonatomic) AMapDrivingStrategy strategy;
        [Export("strategy", ArgumentSemantic.Assign)]
        AMapDrivingStrategy Strategy { get; set; }
    }

    // @interface AMapRouteConfig : NSObject
    [BaseType(typeof(NSObject))]
    interface AMapRouteConfig
    {
        // @property (copy, nonatomic) NSString * appScheme;
        [Export("appScheme")]
        string AppScheme { get; set; }

        // @property (copy, nonatomic) NSString * appName;
        [Export("appName")]
        string AppName { get; set; }

        // @property (assign, nonatomic) CLLocationCoordinate2D startCoordinate;
        [Export("startCoordinate", ArgumentSemantic.Assign)]
        CLLocationCoordinate2D StartCoordinate { get; set; }

        // @property (assign, nonatomic) CLLocationCoordinate2D destinationCoordinate;
        [Export("destinationCoordinate", ArgumentSemantic.Assign)]
        CLLocationCoordinate2D DestinationCoordinate { get; set; }

        // @property (assign, nonatomic) AMapDrivingStrategy drivingStrategy;
        [Export("drivingStrategy", ArgumentSemantic.Assign)]
        AMapDrivingStrategy DrivingStrategy { get; set; }

        // @property (assign, nonatomic) AMapTransitStrategy transitStrategy;
        [Export("transitStrategy", ArgumentSemantic.Assign)]
        AMapTransitStrategy TransitStrategy { get; set; }

        // @property (assign, nonatomic) AMapRouteSearchType routeType;
        [Export("routeType", ArgumentSemantic.Assign)]
        AMapRouteSearchType RouteType { get; set; }
    }

    // @interface AMapPOIConfig : NSObject
    [BaseType(typeof(NSObject))]
    interface AMapPOIConfig
    {
        // @property (copy, nonatomic) NSString * appScheme;
        [Export("appScheme")]
        string AppScheme { get; set; }

        // @property (copy, nonatomic) NSString * appName;
        [Export("appName")]
        string AppName { get; set; }

        // @property (copy, nonatomic) NSString * keywords;
        [Export("keywords")]
        string Keywords { get; set; }

        // @property (assign, nonatomic) CLLocationCoordinate2D leftTopCoordinate;
        [Export("leftTopCoordinate", ArgumentSemantic.Assign)]
        CLLocationCoordinate2D LeftTopCoordinate { get; set; }

        // @property (assign, nonatomic) CLLocationCoordinate2D rightBottomCoordinate;
        [Export("rightBottomCoordinate", ArgumentSemantic.Assign)]
        CLLocationCoordinate2D RightBottomCoordinate { get; set; }
    }

    // @interface AMapURLSearch : NSObject
    [BaseType(typeof(NSObject))]
    interface AMapURLSearch
    {
        // +(void)getLatestAMapApp;
        [Static]
        [Export("getLatestAMapApp")]
        void GetLatestAMapApp();

        // +(BOOL)openAMapNavigation:(AMapNaviConfig *)config;
        [Static]
        [Export("openAMapNavigation:")]
        bool OpenAMapNavigation(AMapNaviConfig config);

        // +(BOOL)openAMapRouteSearch:(AMapRouteConfig *)config;
        [Static]
        [Export("openAMapRouteSearch:")]
        bool OpenAMapRouteSearch(AMapRouteConfig config);

        // +(BOOL)openAMapPOISearch:(AMapPOIConfig *)config;
        [Static]
        [Export("openAMapPOISearch:")]
        bool OpenAMapPOISearch(AMapPOIConfig config);
    }

    // @interface AMapSafe (NSMutableArray)
    [Category]
    [BaseType(typeof(NSMutableArray))]
    interface NSMutableArray_AMapSafe
    {
        // -(BOOL)amf_addObjectSafe:(ObjectType)anObject;
        [Export("amf_addObjectSafe:")]
        bool Amf_addObjectSafe(NSObject anObject);
    }

    // @interface AMapSafe (NSMutableDictionary)
    [Category]
    [BaseType(typeof(NSMutableDictionary))]
    interface NSMutableDictionary_AMapSafe
    {
        // -(BOOL)amf_setObjectSafe:(ObjectType)anObject forKey:(KeyType<NSCopying>)aKey;
        [Export("amf_setObjectSafe:forKey:")]
        bool Amf_setObjectSafe(NSObject anObject, NSObject aKey);
    }

    // @protocol AMapJsonManualSerialization <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface AMapJsonManualSerialization
    {
        // @optional -(void)manualDeserializationJsonData:(NSDictionary *)jsonDictionary forInfo:(id)customInfo;
        [Export("manualDeserializationJsonData:forInfo:")]
        void ManualDeserializationJsonData(NSDictionary jsonDictionary, NSObject customInfo);

        // @optional -(NSMutableDictionary *)manualSerializeObjectForInfo:(id)customInfo;
        [Export("manualSerializeObjectForInfo:")]
        NSMutableDictionary ManualSerializeObjectForInfo(NSObject customInfo);
    }

    // @interface AMapJsonSerialization (NSObject)
    [Category]
    [BaseType(typeof(NSObject))]
    interface NSObject_AMapJsonSerialization
    {
        // -(void)amf_deserializationJsonData:(NSDictionary *)dictionaryJson forInfo:(id)customInfo;
        [Export("amf_deserializationJsonData:forInfo:")]
        void Amf_deserializationJsonData(NSDictionary dictionaryJson, NSObject customInfo);

        // -(NSMutableDictionary *)amf_serializeJsonObjectForInfo:(id)customInfo;
        [Export("amf_serializeJsonObjectForInfo:")]
        NSMutableDictionary Amf_serializeJsonObjectForInfo(NSObject customInfo);

        // -(NSMutableArray *)amf_serializeJsonArrayForInfo:(id)customInfo;
        [Export("amf_serializeJsonArrayForInfo:")]
        NSMutableArray Amf_serializeJsonArrayForInfo(NSObject customInfo);
    }
}
