using System;
using AMapLocationKit;
using CoreLocation;
using Foundation;
using ObjCRuntime;

namespace AMapLocationKit
{
    [Static]
    //[Verify(ConstantsInterfaceAssociation)]
    partial interface Constants
    {
        // extern NSString *const AMapLocationVersion;
        [Field("AMapLocationVersion", "__Internal")]
        NSString AMapLocationVersion { get; }

        // extern NSString *const AMapLocationName;
        [Field("AMapLocationName", "__Internal")]
        NSString AMapLocationName { get; }

        // extern NSString *const AMapLocationErrorDomain;
        [Field("AMapLocationErrorDomain", "__Internal")]
        NSString AMapLocationErrorDomain { get; }

        // extern NSString *const AMapGeoFenceErrorDomain;
        [Field("AMapGeoFenceErrorDomain", "__Internal")]
        NSString AMapGeoFenceErrorDomain { get; }
    }

    // @interface AMapLocationReGeocode : NSObject <NSCopying, NSCoding>
    [BaseType(typeof(NSObject))]
    interface AMapLocationReGeocode : INSCopying, INSCoding
    {
        // @property (copy, nonatomic) NSString * formattedAddress;
        [Export("formattedAddress")]
        string FormattedAddress { get; set; }

        // @property (copy, nonatomic) NSString * country;
        [Export("country")]
        string Country { get; set; }

        // @property (copy, nonatomic) NSString * province;
        [Export("province")]
        string Province { get; set; }

        // @property (copy, nonatomic) NSString * city;
        [Export("city")]
        string City { get; set; }

        // @property (copy, nonatomic) NSString * district;
        [Export("district")]
        string District { get; set; }

        // @property (copy, nonatomic) NSString * township __attribute__((deprecated("该字段从v2.2.0版本起不再返回数据,建议您使用AMapSearchKit的逆地理功能获取.")));
        [Export("township")]
        string Township { get; set; }

        // @property (copy, nonatomic) NSString * neighborhood __attribute__((deprecated("该字段从v2.2.0版本起不再返回数据,建议您使用AMapSearchKit的逆地理功能获取.")));
        [Export("neighborhood")]
        string Neighborhood { get; set; }

        // @property (copy, nonatomic) NSString * building __attribute__((deprecated("该字段从v2.2.0版本起不再返回数据,建议您使用AMapSearchKit的逆地理功能获取.")));
        [Export("building")]
        string Building { get; set; }

        // @property (copy, nonatomic) NSString * citycode;
        [Export("citycode")]
        string Citycode { get; set; }

        // @property (copy, nonatomic) NSString * adcode;
        [Export("adcode")]
        string Adcode { get; set; }

        // @property (copy, nonatomic) NSString * street;
        [Export("street")]
        string Street { get; set; }

        // @property (copy, nonatomic) NSString * number;
        [Export("number")]
        string Number { get; set; }

        // @property (copy, nonatomic) NSString * POIName;
        [Export("POIName")]
        string POIName { get; set; }

        // @property (copy, nonatomic) NSString * AOIName;
        [Export("AOIName")]
        string AOIName { get; set; }
    }

    // @interface AMapLocationPoint : NSObject <NSCopying, NSCoding>
    [BaseType(typeof(NSObject))]
    interface AMapLocationPoint : INSCopying, INSCoding
    {
        // @property (assign, nonatomic) CGFloat latitude;
        [Export("latitude")]
        nfloat Latitude { get; set; }

        // @property (assign, nonatomic) CGFloat longitude;
        [Export("longitude")]
        nfloat Longitude { get; set; }

        // +(AMapLocationPoint *)locationWithLatitude:(CGFloat)lat longitude:(CGFloat)lon;
        [Static]
        [Export("locationWithLatitude:longitude:")]
        AMapLocationPoint LocationWithLatitude(nfloat lat, nfloat lon);
    }

    // @interface AMapLocationPOIItem : NSObject <NSCopying, NSCoding>
    [BaseType(typeof(NSObject))]
    interface AMapLocationPOIItem : INSCopying, INSCoding
    {
        // @property (copy, nonatomic) NSString * pId;
        [Export("pId")]
        string PId { get; set; }

        // @property (copy, nonatomic) NSString * name;
        [Export("name")]
        string Name { get; set; }

        // @property (copy, nonatomic) NSString * type;
        [Export("type")]
        string Type { get; set; }

        // @property (copy, nonatomic) NSString * typeCode;
        [Export("typeCode")]
        string TypeCode { get; set; }

        // @property (copy, nonatomic) NSString * address;
        [Export("address")]
        string Address { get; set; }

        // @property (nonatomic, strong) AMapLocationPoint * location;
        [Export("location", ArgumentSemantic.Strong)]
        AMapLocationPoint Location { get; set; }

        // @property (copy, nonatomic) NSString * tel;
        [Export("tel")]
        string Tel { get; set; }

        // @property (copy, nonatomic) NSString * province;
        [Export("province")]
        string Province { get; set; }

        // @property (copy, nonatomic) NSString * city;
        [Export("city")]
        string City { get; set; }

        // @property (copy, nonatomic) NSString * district;
        [Export("district")]
        string District { get; set; }
    }

    // @interface AMapLocationDistrictItem : NSObject <NSCopying, NSCoding>
    [BaseType(typeof(NSObject))]
    interface AMapLocationDistrictItem : INSCopying, INSCoding
    {
        // @property (copy, nonatomic) NSString * cityCode;
        [Export("cityCode")]
        string CityCode { get; set; }

        // @property (copy, nonatomic) NSString * districtCode;
        [Export("districtCode")]
        string DistrictCode { get; set; }

        // @property (copy, nonatomic) NSString * district;
        [Export("district")]
        string District { get; set; }

        // @property (copy, nonatomic) NSArray<NSArray<AMapLocationPoint *> *> * polylinePoints;
        [Export("polylinePoints", ArgumentSemantic.Copy)]
        NSArray<AMapLocationPoint>[] PolylinePoints { get; set; }
    }

    // @interface AMapLocationRegion : NSObject <NSCopying>
    [BaseType(typeof(NSObject))]
    interface AMapLocationRegion : INSCopying
    {
        // @property (readonly, copy, nonatomic) NSString * identifier;
        [Export("identifier")]
        string Identifier { get; }

        // @property (assign, nonatomic) BOOL notifyOnEntry;
        [Export("notifyOnEntry")]
        bool NotifyOnEntry { get; set; }

        // @property (assign, nonatomic) BOOL notifyOnExit;
        [Export("notifyOnExit")]
        bool NotifyOnExit { get; set; }

        // -(instancetype)initWithIdentifier:(NSString *)identifier;
        [Export("initWithIdentifier:")]
        IntPtr Constructor(string identifier);

        // -(BOOL)containsCoordinate:(CLLocationCoordinate2D)coordinate;
        [Export("containsCoordinate:")]
        bool ContainsCoordinate(CLLocationCoordinate2D coordinate);
    }

    // @interface AMapLocationCircleRegion : AMapLocationRegion
    [BaseType(typeof(AMapLocationRegion))]
    interface AMapLocationCircleRegion
    {
        // @property (readonly, nonatomic) CLLocationCoordinate2D center;
        [Export("center")]
        CLLocationCoordinate2D Center { get; }

        // @property (readonly, nonatomic) CLLocationDistance radius;
        [Export("radius")]
        double Radius { get; }

        // -(instancetype)initWithCenter:(CLLocationCoordinate2D)center radius:(CLLocationDistance)radius identifier:(NSString *)identifier;
        [Export("initWithCenter:radius:identifier:")]
        IntPtr Constructor(CLLocationCoordinate2D center, double radius, string identifier);
    }

    // @interface AMapLocationPolygonRegion : AMapLocationRegion
    [BaseType(typeof(AMapLocationRegion))]
    interface AMapLocationPolygonRegion
    {
        // @property (readonly, nonatomic) CLLocationCoordinate2D * coordinates;
        [Export("coordinates")]
        unsafe CLLocationCoordinate2D* Coordinates { get; }

        // @property (readonly, nonatomic) NSInteger count;
        [Export("count")]
        uint Count { get; }

        // -(instancetype)initWithCoordinates:(CLLocationCoordinate2D *)coordinates count:(NSInteger)count identifier:(NSString *)identifier;
        [Export("initWithCoordinates:count:identifier:")]
        unsafe IntPtr Constructor(CLLocationCoordinate2D* coordinates, uint count, string identifier);
    }

    // typedef void (^AMapLocatingCompletionBlock)(CLLocation *, AMapLocationReGeocode *, NSError *);
    delegate void AMapLocatingCompletionBlock(CLLocation arg0, AMapLocationReGeocode arg1, NSError arg2);

    // @interface AMapLocationManager : NSObject
    [BaseType(typeof(NSObject))]
    interface AMapLocationManager
    {
        [Wrap("WeakDelegate")]
        AMapLocationManagerDelegate Delegate { get; set; }

        // @property (nonatomic, weak) id<AMapLocationManagerDelegate> delegate;
        [NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
        NSObject WeakDelegate { get; set; }

        // @property (assign, nonatomic) CLLocationDistance distanceFilter;
        [Export("distanceFilter")]
        double DistanceFilter { get; set; }

        // @property (assign, nonatomic) CLLocationAccuracy desiredAccuracy;
        [Export("desiredAccuracy")]
        double DesiredAccuracy { get; set; }

        // @property (assign, nonatomic) BOOL pausesLocationUpdatesAutomatically;
        [Export("pausesLocationUpdatesAutomatically")]
        bool PausesLocationUpdatesAutomatically { get; set; }

        // @property (assign, nonatomic) BOOL allowsBackgroundLocationUpdates;
        [Export("allowsBackgroundLocationUpdates")]
        bool AllowsBackgroundLocationUpdates { get; set; }

        // @property (assign, nonatomic) NSInteger locationTimeout;
        [Export("locationTimeout")]
        uint LocationTimeout { get; set; }

        // @property (assign, nonatomic) NSInteger reGeocodeTimeout;
        [Export("reGeocodeTimeout")]
        uint ReGeocodeTimeout { get; set; }

        // @property (assign, nonatomic) BOOL locatingWithReGeocode;
        [Export("locatingWithReGeocode")]
        bool LocatingWithReGeocode { get; set; }

        // @property (assign, nonatomic) AMapLocationReGeocodeLanguage reGeocodeLanguage;
        [Export("reGeocodeLanguage", ArgumentSemantic.Assign)]
        AMapLocationReGeocodeLanguage ReGeocodeLanguage { get; set; }

        // @property (readonly, copy, nonatomic) NSSet * monitoredRegions;
        [Export("monitoredRegions", ArgumentSemantic.Copy)]
        NSSet MonitoredRegions { get; }

        // @property (assign, nonatomic) BOOL detectRiskOfFakeLocation;
        [Export("detectRiskOfFakeLocation")]
        bool DetectRiskOfFakeLocation { get; set; }

        // +(BOOL)headingAvailable;
        [Static]
        [Export("headingAvailable")]
        [Verify(MethodToProperty)]
        bool HeadingAvailable { get; }

        // -(void)startUpdatingHeading;
        [Export("startUpdatingHeading")]
        void StartUpdatingHeading();

        // -(void)stopUpdatingHeading;
        [Export("stopUpdatingHeading")]
        void StopUpdatingHeading();

        // -(void)dismissHeadingCalibrationDisplay;
        [Export("dismissHeadingCalibrationDisplay")]
        void DismissHeadingCalibrationDisplay();

        // -(BOOL)requestLocationWithReGeocode:(BOOL)withReGeocode completionBlock:(AMapLocatingCompletionBlock)completionBlock;
        [Export("requestLocationWithReGeocode:completionBlock:")]
        bool RequestLocationWithReGeocode(bool withReGeocode, AMapLocatingCompletionBlock completionBlock);

        // -(void)startUpdatingLocation;
        [Export("startUpdatingLocation")]
        void StartUpdatingLocation();

        // -(void)stopUpdatingLocation;
        [Export("stopUpdatingLocation")]
        void StopUpdatingLocation();

        // -(void)startMonitoringForRegion:(AMapLocationRegion *)region __attribute__((deprecated("请使用AMapGeoFenceManager")));
        [Export("startMonitoringForRegion:")]
        void StartMonitoringForRegion(AMapLocationRegion region);

        // -(void)stopMonitoringForRegion:(AMapLocationRegion *)region __attribute__((deprecated("请使用AMapGeoFenceManager")));
        [Export("stopMonitoringForRegion:")]
        void StopMonitoringForRegion(AMapLocationRegion region);

        // -(void)requestStateForRegion:(AMapLocationRegion *)region __attribute__((deprecated("请使用AMapGeoFenceManager")));
        [Export("requestStateForRegion:")]
        void RequestStateForRegion(AMapLocationRegion region);
    }

    // @protocol AMapLocationManagerDelegate <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface AMapLocationManagerDelegate
    {
        // @optional -(void)amapLocationManager:(AMapLocationManager *)manager doRequireLocationAuth:(CLLocationManager *)locationManager;
        [Export("amapLocationManager:doRequireLocationAuth:")]
        void AmapLocationManager(AMapLocationManager manager, CLLocationManager locationManager);

        // @optional -(void)amapLocationManager:(AMapLocationManager *)manager didFailWithError:(NSError *)error;
        [Export("amapLocationManager:didFailWithError:")]
        void AmapLocationManager(AMapLocationManager manager, NSError error);

        // @optional -(void)amapLocationManager:(AMapLocationManager *)manager didUpdateLocation:(CLLocation *)location;
        [Export("amapLocationManager:didUpdateLocation:")]
        void AmapLocationManager(AMapLocationManager manager, CLLocation location);

        // @optional -(void)amapLocationManager:(AMapLocationManager *)manager didUpdateLocation:(CLLocation *)location reGeocode:(AMapLocationReGeocode *)reGeocode;
        [Export("amapLocationManager:didUpdateLocation:reGeocode:")]
        void AmapLocationManager(AMapLocationManager manager, CLLocation location, AMapLocationReGeocode reGeocode);

        // @optional -(void)amapLocationManager:(AMapLocationManager *)manager didChangeAuthorizationStatus:(CLAuthorizationStatus)status;
        [Export("amapLocationManager:didChangeAuthorizationStatus:")]
        void AmapLocationManager(AMapLocationManager manager, CLAuthorizationStatus status);

        // @optional -(BOOL)amapLocationManagerShouldDisplayHeadingCalibration:(AMapLocationManager *)manager;
        [Export("amapLocationManagerShouldDisplayHeadingCalibration:")]
        bool AmapLocationManagerShouldDisplayHeadingCalibration(AMapLocationManager manager);

        // @optional -(void)amapLocationManager:(AMapLocationManager *)manager didUpdateHeading:(CLHeading *)newHeading;
        [Export("amapLocationManager:didUpdateHeading:")]
        void AmapLocationManager(AMapLocationManager manager, CLHeading newHeading);

        // @optional -(void)amapLocationManager:(AMapLocationManager *)manager didStartMonitoringForRegion:(AMapLocationRegion *)region __attribute__((deprecated("请使用AMapGeoFenceManager")));
        [Export("amapLocationManager:didStartMonitoringForRegion:")]
        void AmapLocationManager(AMapLocationManager manager, AMapLocationRegion region);

        // @optional -(void)amapLocationManager:(AMapLocationManager *)manager didEnterRegion:(AMapLocationRegion *)region __attribute__((deprecated("请使用AMapGeoFenceManager")));
        [Export("amapLocationManager:didEnterRegion:")]
        void AmapLocationManager(AMapLocationManager manager, AMapLocationRegion region);

        // @optional -(void)amapLocationManager:(AMapLocationManager *)manager didExitRegion:(AMapLocationRegion *)region __attribute__((deprecated("请使用AMapGeoFenceManager")));
        [Export("amapLocationManager:didExitRegion:")]
        void AmapLocationManager(AMapLocationManager manager, AMapLocationRegion region);

        // @optional -(void)amapLocationManager:(AMapLocationManager *)manager didDetermineState:(AMapLocationRegionState)state forRegion:(AMapLocationRegion *)region __attribute__((deprecated("请使用AMapGeoFenceManager")));
        [Export("amapLocationManager:didDetermineState:forRegion:")]
        void AmapLocationManager(AMapLocationManager manager, AMapLocationRegionState state, AMapLocationRegion region);

        // @optional -(void)amapLocationManager:(AMapLocationManager *)manager monitoringDidFailForRegion:(AMapLocationRegion *)region withError:(NSError *)error __attribute__((deprecated("请使用AMapGeoFenceManager")));
        [Export("amapLocationManager:monitoringDidFailForRegion:withError:")]
        void AmapLocationManager(AMapLocationManager manager, AMapLocationRegion region, NSError error);
    }

    // @interface AMapGeoFenceRegion : NSObject <NSCopying>
    [BaseType(typeof(NSObject))]
    interface AMapGeoFenceRegion : INSCopying
    {
        // @property (readonly, copy, nonatomic) NSString * identifier;
        [Export("identifier")]
        string Identifier { get; }

        // @property (readonly, copy, nonatomic) NSString * customID;
        [Export("customID")]
        string CustomID { get; }

        // @property (assign, nonatomic) AMapGeoFenceRegionStatus fenceStatus;
        [Export("fenceStatus", ArgumentSemantic.Assign)]
        AMapGeoFenceRegionStatus FenceStatus { get; set; }

        // @property (assign, nonatomic) AMapGeoFenceRegionType regionType;
        [Export("regionType", ArgumentSemantic.Assign)]
        AMapGeoFenceRegionType RegionType { get; set; }

        // @property (copy, nonatomic) CLLocation * currentLocation;
        [Export("currentLocation", ArgumentSemantic.Copy)]
        CLLocation CurrentLocation { get; set; }
    }

    // @interface AMapGeoFenceCircleRegion : AMapGeoFenceRegion
    [BaseType(typeof(AMapGeoFenceRegion))]
    interface AMapGeoFenceCircleRegion
    {
        // @property (readonly, nonatomic) CLLocationCoordinate2D center;
        [Export("center")]
        CLLocationCoordinate2D Center { get; }

        // @property (readonly, nonatomic) CLLocationDistance radius;
        [Export("radius")]
        double Radius { get; }
    }

    // @interface AMapGeoFencePolygonRegion : AMapGeoFenceRegion
    [BaseType(typeof(AMapGeoFenceRegion))]
    interface AMapGeoFencePolygonRegion
    {
        // @property (readonly, nonatomic) CLLocationCoordinate2D * coordinates;
        [Export("coordinates")]
        unsafe CLLocationCoordinate2D* Coordinates { get; }

        // @property (readonly, nonatomic) NSInteger count;
        [Export("count")]
        uint Count { get; }
    }

    // @interface AMapGeoFencePOIRegion : AMapGeoFenceCircleRegion
    [BaseType(typeof(AMapGeoFenceCircleRegion))]
    interface AMapGeoFencePOIRegion
    {
        // @property (readonly, nonatomic, strong) AMapLocationPOIItem * POIItem;
        [Export("POIItem", ArgumentSemantic.Strong)]
        AMapLocationPOIItem POIItem { get; }
    }

    // @interface AMapGeoFenceDistrictRegion : AMapGeoFenceRegion
    [BaseType(typeof(AMapGeoFenceRegion))]
    interface AMapGeoFenceDistrictRegion
    {
        // @property (readonly, nonatomic, strong) AMapLocationDistrictItem * districtItem;
        [Export("districtItem", ArgumentSemantic.Strong)]
        AMapLocationDistrictItem DistrictItem { get; }

        // @property (readonly, copy, nonatomic) NSArray<NSArray<AMapLocationPoint *> *> * polylinePoints;
        [Export("polylinePoints", ArgumentSemantic.Copy)]
        NSArray<AMapLocationPoint>[] PolylinePoints { get; }
    }

    // @interface AMapGeoFenceManager : NSObject
    [BaseType(typeof(NSObject))]
    interface AMapGeoFenceManager
    {
        [Wrap("WeakDelegate")]
        AMapGeoFenceManagerDelegate Delegate { get; set; }

        // @property (nonatomic, weak) id<AMapGeoFenceManagerDelegate> delegate;
        [NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
        NSObject WeakDelegate { get; set; }

        // @property (assign, nonatomic) AMapGeoFenceActiveAction activeAction;
        [Export("activeAction", ArgumentSemantic.Assign)]
        AMapGeoFenceActiveAction ActiveAction { get; set; }

        // @property (assign, nonatomic) BOOL pausesLocationUpdatesAutomatically;
        [Export("pausesLocationUpdatesAutomatically")]
        bool PausesLocationUpdatesAutomatically { get; set; }

        // @property (assign, nonatomic) BOOL allowsBackgroundLocationUpdates;
        [Export("allowsBackgroundLocationUpdates")]
        bool AllowsBackgroundLocationUpdates { get; set; }

        // @property (assign, nonatomic) BOOL detectRiskOfFakeLocation;
        [Export("detectRiskOfFakeLocation")]
        bool DetectRiskOfFakeLocation { get; set; }

        // -(void)addCircleRegionForMonitoringWithCenter:(CLLocationCoordinate2D)center radius:(CLLocationDistance)radius customID:(NSString *)customID;
        [Export("addCircleRegionForMonitoringWithCenter:radius:customID:")]
        void AddCircleRegionForMonitoringWithCenter(CLLocationCoordinate2D center, double radius, string customID);

        // -(void)addPolygonRegionForMonitoringWithCoordinates:(CLLocationCoordinate2D *)coordinates count:(NSInteger)count customID:(NSString *)customID;
        [Export("addPolygonRegionForMonitoringWithCoordinates:count:customID:")]
        unsafe void AddPolygonRegionForMonitoringWithCoordinates(CLLocationCoordinate2D* coordinates, uint count, string customID);

        // -(void)addKeywordPOIRegionForMonitoringWithKeyword:(NSString *)keyword POIType:(NSString *)type city:(NSString *)city size:(NSInteger)size customID:(NSString *)customID;
        [Export("addKeywordPOIRegionForMonitoringWithKeyword:POIType:city:size:customID:")]
        void AddKeywordPOIRegionForMonitoringWithKeyword(string keyword, string type, string city, uint size, string customID);

        // -(void)addAroundPOIRegionForMonitoringWithLocationPoint:(CLLocationCoordinate2D)locationPoint aroundRadius:(NSInteger)aroundRadius keyword:(NSString *)keyword POIType:(NSString *)type size:(NSInteger)size customID:(NSString *)customID;
        [Export("addAroundPOIRegionForMonitoringWithLocationPoint:aroundRadius:keyword:POIType:size:customID:")]
        void AddAroundPOIRegionForMonitoringWithLocationPoint(CLLocationCoordinate2D locationPoint, uint aroundRadius, string keyword, string type, uint size, string customID);

        // -(void)addDistrictRegionForMonitoringWithDistrictName:(NSString *)districtName customID:(NSString *)customID;
        [Export("addDistrictRegionForMonitoringWithDistrictName:customID:")]
        void AddDistrictRegionForMonitoringWithDistrictName(string districtName, string customID);

        // -(AMapGeoFenceRegionActiveStatus)statusWithGeoFenceRegion:(AMapGeoFenceRegion *)region;
        [Export("statusWithGeoFenceRegion:")]
        AMapGeoFenceRegionActiveStatus StatusWithGeoFenceRegion(AMapGeoFenceRegion region);

        // -(NSArray *)geoFenceRegionsWithCustomID:(NSString *)customID;
        [Export("geoFenceRegionsWithCustomID:")]
        //[Verify(StronglyTypedNSArray)]
        NSObject[] GeoFenceRegionsWithCustomID(string customID);

        // -(NSArray *)monitoringGeoFenceRegionsWithCustomID:(NSString *)customID;
        [Export("monitoringGeoFenceRegionsWithCustomID:")]
        //[Verify(StronglyTypedNSArray)]
        NSObject[] MonitoringGeoFenceRegionsWithCustomID(string customID);

        // -(NSArray *)pausedGeoFenceRegionsWithCustomID:(NSString *)customID;
        [Export("pausedGeoFenceRegionsWithCustomID:")]
        //[Verify(StronglyTypedNSArray)]
        NSObject[] PausedGeoFenceRegionsWithCustomID(string customID);

        // -(NSArray *)pauseGeoFenceRegionsWithCustomID:(NSString *)customID;
        [Export("pauseGeoFenceRegionsWithCustomID:")]
        //[Verify(StronglyTypedNSArray)]
        NSObject[] PauseGeoFenceRegionsWithCustomID(string customID);

        // -(BOOL)pauseTheGeoFenceRegion:(AMapGeoFenceRegion *)region;
        [Export("pauseTheGeoFenceRegion:")]
        bool PauseTheGeoFenceRegion(AMapGeoFenceRegion region);

        // -(NSArray *)startGeoFenceRegionsWithCustomID:(NSString *)customID;
        [Export("startGeoFenceRegionsWithCustomID:")]
        //[Verify(StronglyTypedNSArray)]
        NSObject[] StartGeoFenceRegionsWithCustomID(string customID);

        // -(BOOL)startTheGeoFenceRegion:(AMapGeoFenceRegion *)region;
        [Export("startTheGeoFenceRegion:")]
        bool StartTheGeoFenceRegion(AMapGeoFenceRegion region);

        // -(void)removeTheGeoFenceRegion:(AMapGeoFenceRegion *)region;
        [Export("removeTheGeoFenceRegion:")]
        void RemoveTheGeoFenceRegion(AMapGeoFenceRegion region);

        // -(void)removeGeoFenceRegionsWithCustomID:(NSString *)customID;
        [Export("removeGeoFenceRegionsWithCustomID:")]
        void RemoveGeoFenceRegionsWithCustomID(string customID);

        // -(void)removeAllGeoFenceRegions;
        [Export("removeAllGeoFenceRegions")]
        void RemoveAllGeoFenceRegions();
    }

    // @protocol AMapGeoFenceManagerDelegate <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface AMapGeoFenceManagerDelegate
    {
        // @optional -(void)amapGeoFenceManager:(AMapGeoFenceManager *)manager doRequireLocationAuth:(CLLocationManager *)locationManager;
        [Export("amapGeoFenceManager:doRequireLocationAuth:")]
        void DoRequireLocationAuth(AMapGeoFenceManager manager, CLLocationManager locationManager);

        // @optional -(void)amapGeoFenceManager:(AMapGeoFenceManager *)manager didAddRegionForMonitoringFinished:(NSArray<AMapGeoFenceRegion *> *)regions customID:(NSString *)customID error:(NSError *)error;
        [Export("amapGeoFenceManager:didAddRegionForMonitoringFinished:customID:error:")]
        void DidAddRegionForMonitoringFinished(AMapGeoFenceManager manager, AMapGeoFenceRegion[] regions, string customID, NSError error);

        // @optional -(void)amapGeoFenceManager:(AMapGeoFenceManager *)manager didGeoFencesStatusChangedForRegion:(AMapGeoFenceRegion *)region customID:(NSString *)customID error:(NSError *)error;
        [Export("amapGeoFenceManager:didGeoFencesStatusChangedForRegion:customID:error:")]
        void DidGeoFencesStatusChangedForRegion(AMapGeoFenceManager manager, AMapGeoFenceRegion region, string customID, NSError error);
    }

    //[Static]
    ////[Verify(ConstantsInterfaceAssociation)]
    //partial interface Constants
    //{
    //    // extern NSString *const AMapGeoFenceErrorDomain;
    //    [Field("AMapGeoFenceErrorDomain", "__Internal")]
    //    NSString AMapGeoFenceErrorDomain { get; }
    //}
}
